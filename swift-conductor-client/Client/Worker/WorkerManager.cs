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
        private readonly ILogger<WorkerRunner> _loggerWorkerRunner;
        private readonly ILogger<WorkerMonitor> _loggerWorkflowTaskMonitor;
        private readonly HashSet<IWorkerRunner> _workers;
        private readonly IWorkerClient _client;

        public WorkerManager(IWorkerClient client, ILogger<WorkerManager> logger, ILogger<WorkerRunner> loggerWorkflowTaskExecutor, ILogger<WorkerMonitor> loggerWorkflowTaskMonitor)
        {
            _logger = logger;
            _client = client;
            _workers = new HashSet<IWorkerRunner>();
            _loggerWorkerRunner = loggerWorkflowTaskExecutor;
            _loggerWorkflowTaskMonitor = loggerWorkflowTaskMonitor;
        }

        public async Task Start(CancellationToken token)
        {
            if (token != CancellationToken.None)
                token.ThrowIfCancellationRequested();

            _logger.LogDebug("Starting workers...");

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
            var workerRunner = new WorkerRunner(
                _loggerWorkerRunner,
                _client,
                worker,
                workflowTaskMonitor
            );

            _workers.Add(workerRunner);
        }
    }
}
