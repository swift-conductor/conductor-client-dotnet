using SwiftConductor.Client.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace SwiftConductor.Client.Worker
{
    internal class WorkerManager : IWorkerManager
    {
        private readonly ILogger<WorkerManager> _logger;
        private readonly ILogger<WorkerRunner> _loggerWorkflowTaskExecutor;
        private readonly ILogger<WorkerMonitor> _loggerWorkflowTaskMonitor;
        private readonly HashSet<IWorkerRunner> _workers;
        private readonly IWorkerClient _client;

        public WorkerManager(IWorkerClient client, ILogger<WorkerManager> logger, ILogger<WorkerRunner> loggerWorkflowTaskExecutor, ILogger<WorkerMonitor> loggerWorkflowTaskMonitor)
        {
            _logger = logger;
            _client = client;
            _workers = new HashSet<IWorkerRunner>();
            _loggerWorkflowTaskExecutor = loggerWorkflowTaskExecutor;
            _loggerWorkflowTaskMonitor = loggerWorkflowTaskMonitor;
        }

        public async Task Start(CancellationToken token)
        {
            if (token != CancellationToken.None)
                token.ThrowIfCancellationRequested();

            _logger.LogDebug("Starting workers...");
            DiscoverWorkers();
            var runningWorkers = new List<Task>();
            foreach (var worker in _workers)
            {
                var runningWorker = worker.Start(token);
                runningWorkers.Add(runningWorker);
            }
            _logger.LogDebug("Started all workers");
            await Task.WhenAll(runningWorkers);
        }

        public void RegisterWorker(IWorker worker)
        {
            var workflowTaskMonitor = new WorkerMonitor(_loggerWorkflowTaskMonitor);
            var workflowTaskExecutor = new WorkerRunner(
                _loggerWorkflowTaskExecutor,
                _client,
                worker,
                workflowTaskMonitor
            );
            _workers.Add(workflowTaskExecutor);
        }

        private void DiscoverWorkers()
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in assembly.GetTypes())
                {
                    if (type.GetCustomAttribute<WorkerAttribute>() == null)
                    {
                        continue;
                    }
                    foreach (var method in type.GetMethods())
                    {
                        var workerTask = method.GetCustomAttribute<WorkerAttribute>();
                        if (workerTask == null)
                        {
                            continue;
                        }
                        object workerInstance = null;
                        if (!method.IsStatic)
                        {
                            workerInstance = Activator.CreateInstance(type);
                        }
                        var worker = new Worker(
                            workerTask.TaskType,
                            workerTask.WorkerSettings,
                            method,
                            workerInstance
                        );
                        RegisterWorker(worker);
                    }
                }
            }
        }
    }
}
