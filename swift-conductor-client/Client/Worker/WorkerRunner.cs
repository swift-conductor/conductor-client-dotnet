﻿using SwiftConductor.Client.Interfaces;
using SwiftConductor.Client.Extensions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using SwiftConductor.Client.Models;

namespace SwiftConductor.Client.Worker
{
    internal class WorkerRunner : IWorkerRunner
    {
        private static TimeSpan SLEEP_FOR_TIME_SPAN_ON_WORKER_ERROR = TimeSpan.FromMilliseconds(10);
        private static int UPDATE_TASK_RETRY_COUNT_LIMIT = 5;

        private readonly ILogger<WorkerRunner> _logger;
        private readonly IWorker _worker;
        private readonly IWorkerClient _taskClient;
        private readonly WorkerSettings _workerSettings;
        private readonly WorkerMonitor _workflowTaskMonitor;

        public WorkerRunner(
            ILogger<WorkerRunner> logger,
            IWorkerClient client,
            IWorker worker,
            WorkerMonitor workflowTaskMonitor)
        {
            _logger = logger;
            _taskClient = client;
            _worker = worker;
            _workerSettings = worker.WorkerSettings;
            _workflowTaskMonitor = workflowTaskMonitor;
        }

        public System.Threading.Tasks.Task Start(CancellationToken token)
        {
            if (token != CancellationToken.None)
                token.ThrowIfCancellationRequested();

            var thread = System.Threading.Tasks.Task.Run(() => Forever(token));
            _logger.LogInformation(
                $"[{_workerSettings.WorkerId}] Started worker"
                + $", taskName: {_worker.TaskType}"
                + $", domain: {_workerSettings.Domain}"
                + $", pollInterval: {_workerSettings.PollInterval}"
                + $", batchSize: {_workerSettings.BatchSize}"
            );

            if (token != CancellationToken.None)
                token.ThrowIfCancellationRequested();

            return thread;
        }

        private void Forever(CancellationToken token)
        {
            while (true)
            {
                try
                {
                    if (token != CancellationToken.None)
                        token.ThrowIfCancellationRequested();

                    Once(token);
                }
                catch (Exception e)
                {
                    _logger.LogDebug(
                        $"[{_workerSettings.WorkerId}] worker error: {e.Message}"
                        + $", taskName: {_worker.TaskType}"
                        + $", domain: {_worker.WorkerSettings.Domain}"
                        + $", batchSize: {_workerSettings.BatchSize}"
                    );
                    Sleep(SLEEP_FOR_TIME_SPAN_ON_WORKER_ERROR);
                }
            }
        }

        private async void Once(CancellationToken token)
        {
            if (token != CancellationToken.None)
                token.ThrowIfCancellationRequested();

            var tasks = PollTasks();
            if (tasks.Count == 0)
            {
                Sleep(_workerSettings.PollInterval);
                return;
            }
            var uniqueBatchId = Guid.NewGuid();
            _logger.LogTrace(
                  $"[{_workerSettings.WorkerId}] Processing tasks batch"
                  + $", Task batch unique Id: {uniqueBatchId}"
                  );

            await System.Threading.Tasks.Task.Run(() => ProcessTasks(tasks, token));

            _logger.LogTrace(
                  $"[{_workerSettings.WorkerId}] Completed tasks batch"
                  + $", Task batch unique Id: {uniqueBatchId}"
                  );
        }

        private List<Models.WorkerTask> PollTasks()
        {
            _logger.LogTrace(
                $"[{_workerSettings.WorkerId}] Polling for worker"
                + $", taskType: {_worker.TaskType}"
                + $", domain: {_workerSettings.Domain}"
                + $", batchSize: {_workerSettings.BatchSize}"
            );

            var availableWorkerCounter = _workerSettings.BatchSize - _workflowTaskMonitor.GetRunningWorkers();
            if (availableWorkerCounter < 1)
            {
                throw new Exception("no worker available");
            }
            
            var tasks = _taskClient.PollTask(_worker.TaskType, _workerSettings.WorkerId, _workerSettings.Domain, availableWorkerCounter);
            if (tasks == null)
            {
                tasks = new List<Models.WorkerTask>();
            }

            _logger.LogTrace(
                $"[{_workerSettings.WorkerId}] Polled {tasks.Count} tasks"
                + $", taskType: {_worker.TaskType}"
                + $", domain: {_workerSettings.Domain}"
                + $", batchSize: {_workerSettings.BatchSize}"
            );
            
            return tasks;
        }

        private async void ProcessTasks(List<Models.WorkerTask> tasks, CancellationToken token)
        {

            List<System.Threading.Tasks.Task> threads = new List<System.Threading.Tasks.Task>();
            if (tasks == null || tasks.Count == 0)
            {
                return;
            }
            foreach (var task in tasks)
            {
                if (token != CancellationToken.None)
                    token.ThrowIfCancellationRequested();

                _workflowTaskMonitor.IncrementRunningWorker();
                threads.Add(System.Threading.Tasks.Task.Run(() => ProcessTask(task, token)));
            }
            await System.Threading.Tasks.Task.WhenAll(threads);
        }

        private async void ProcessTask(Models.WorkerTask task, CancellationToken token)
        {
            if (token != CancellationToken.None)
                token.ThrowIfCancellationRequested();

            _logger.LogTrace(
                $"[{_workerSettings.WorkerId}] Processing task for worker"
                + $", taskType: {_worker.TaskType}"
                + $", domain: {_workerSettings.Domain}"
                + $", taskId: {task.TaskId}"
                + $", workflowId: {task.WorkflowInstanceId}"
                + $", CancelToken: {token}"
            );

            try
            {
                WorkerTaskResult taskResult = await _worker.Run(task, token);

                _logger.LogTrace(
                   $"[{_workerSettings.WorkerId}] Done processing task for worker"
                   + $", taskType: {_worker.TaskType}"
                   + $", domain: {_workerSettings.Domain}"
                   + $", taskId: {task.TaskId}"
                   + $", workflowId: {task.WorkflowInstanceId}"
                   + $", CancelToken: {token}"
                );
                
                UpdateTask(taskResult);
            }
            catch (Exception e)
            {
                _logger.LogDebug(
                    $"[{_workerSettings.WorkerId}] Failed to process task for worker, reason: {e.Message}"
                    + $", taskType: {_worker.TaskType}"
                    + $", domain: {_workerSettings.Domain}"
                    + $", taskId: {task.TaskId}"
                    + $", workflowId: {task.WorkflowInstanceId}"
                    + $", CancelToken: {token}"
                );
                var taskResult = task.Failed(e.Message);
                UpdateTask(taskResult);

            }
            finally
            {
                if (token == CancellationToken.None)
                    token.ThrowIfCancellationRequested();
                _workflowTaskMonitor.RunningWorkerDone();
            }
        }

        private void UpdateTask(Models.WorkerTaskResult taskResult)
        {
            taskResult.WorkerId = taskResult.WorkerId ?? _workerSettings.WorkerId;
            for (var attemptCounter = 0; attemptCounter < UPDATE_TASK_RETRY_COUNT_LIMIT; attemptCounter += 1)
            {
                try
                {
                    // Retries in increasing time intervals (0s, 2s, 4s, 8s...)
                    if (attemptCounter > 0)
                    {
                        Sleep(TimeSpan.FromSeconds(1 << attemptCounter));
                    }
                    _taskClient.UpdateTask(taskResult);
                    _logger.LogTrace(
                        $"[{_workerSettings.WorkerId}] Done updating task"
                        + $", taskType: {_worker.TaskType}"
                        + $", domain: {_workerSettings.Domain}"
                        + $", taskId: {taskResult.TaskId}"
                        + $", workflowId: {taskResult.WorkflowInstanceId}"
                    );
                    return;
                }
                catch (Exception e)
                {
                    _logger.LogTrace(
                        $"[{_workerSettings.WorkerId}] Failed to update task, reason: {e.Message}"
                        + $", taskType: {_worker.TaskType}"
                        + $", domain: {_workerSettings.Domain}"
                        + $", taskId: {taskResult.TaskId}"
                        + $", workflowId: {taskResult.WorkflowInstanceId}"
                    );
                }
            }
            throw new Exception("Failed to update task after retries");
        }

        private void Sleep(TimeSpan timeSpan)
        {
            _logger.LogDebug($"[{_workerSettings.WorkerId}] Sleeping for {timeSpan.Milliseconds}ms");
            Thread.Sleep(timeSpan);
        }

        private void LogInfo()
        {

        }
    }
}
