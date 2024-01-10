using SwiftConductor.Client.Interfaces;
using SwiftConductor.Client.Models;
using SwiftConductor.Client.Worker;
using SwiftConductor.Client.Extensions;

namespace csharp.examples
{
    public class CustomTask1 : IWorker
    {
        public string TaskType { get; }
        public WorkerSettings WorkerSettings { get; }

        public CustomTask1(string taskType = "CustomTask_1")
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
