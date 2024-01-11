using SwiftConductor.Client.Extensions;
using SwiftConductor.Client.Interfaces;
using SwiftConductor.Client.Models;
using SwiftConductor.Client.Worker;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Worker
{
    public class Worker : IWorker
    {
        private const string TASK_TYPE = "test-sdk-csharp-task-type";

        public string TaskType { get; }

        public WorkerSettings WorkerSettings { get; }

        public Worker(string taskType = TASK_TYPE )
        {
            TaskType = taskType;
            WorkerSettings = new WorkerSettings();
        }

        public async Task<WorkerTaskResult> Run(WorkerTask workerTask, CancellationToken token)
        {
            if (token != CancellationToken.None && token.IsCancellationRequested)
                return workerTask.Failed("Token request Cancel");

            return await Task.Run(() => workerTask.Completed());
        }
    }
}
