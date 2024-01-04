using SwiftConductor.Client.Interfaces;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.Logging;

namespace SwiftConductor.Client.Worker
{
    public class WorkerService : BackgroundService
    {
        private readonly IWorkerManager _workerManager;
        private readonly IEnumerable<IWorker> _workers;
        private readonly ILogger<WorkerService> _logger;

        public WorkerService(IWorkerManager workflowTaskCoordinator, IEnumerable<IWorker> workers, ILogger<WorkerService> logger)
        {
            _workerManager = workflowTaskCoordinator;
            _workers = workers;
            _logger = logger;
        }

        protected override System.Threading.Tasks.Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                _logger.LogTrace($"Task Service execution started.....");
                
                foreach (var worker in _workers)
                {
                    _workerManager.RegisterWorker(worker);
                }

                return _workerManager.Start(stoppingToken);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Task Service execution error out.....Message: {ex.Message}, Exception Stack trace: {ex.StackTrace}");
                StopAsync(stoppingToken);
                throw ex;
            }
        }
    }
}
