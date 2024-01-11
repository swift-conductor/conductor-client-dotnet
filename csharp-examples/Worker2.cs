using SwiftConductor.Client.Interfaces;
using SwiftConductor.Client.Models;
using SwiftConductor.Client.Worker;
using SwiftConductor.Client.Extensions;

namespace csharp.examples
{
    public class Worker2 : IWorker
    {
        public string TaskType { get; }
        public WorkerSettings WorkerSettings { get; }

        public Worker2(string taskType = "CustomTask_2")
        {
            TaskType = taskType;
            WorkerSettings = new WorkerSettings();
        }

        public async Task<WorkerTaskResult> Run(SwiftConductor.Client.Models.WorkerTask workerTask, CancellationToken token)
        {
            if (token != CancellationToken.None && token.IsCancellationRequested)
                return workerTask.Failed("Token request Cancel");

            return await System.Threading.Tasks.Task.Run(() => workerTask.Completed());
        }
    }
}
