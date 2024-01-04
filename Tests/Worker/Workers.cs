using SwiftConductor.Client.Extensions;
using SwiftConductor.Client.Interfaces;
using SwiftConductor.Client.Models;
using SwiftConductor.Client.Worker;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Worker
{
    [Worker]
    public class FunctionalWorkers
    {
        private static Random _random;

        static FunctionalWorkers()
        {
            _random = new Random();
        }

        // Polls for 5 task every 200ms
        [Worker("test-sdk-csharp-task", 5, "taskDomain", 200, "workerId")]
        public static WorkerTaskResult SimpleWorker(SwiftConductor.Client.Models.WorkerTask task)
        {
            return task.Completed();
        }

        // Polls for 12 tasks every 420ms
        [Worker("test-sdk-csharp-task", 12, "taskDomain", 420, "workerId")]
        public WorkerTaskResult LazyWorker(SwiftConductor.Client.Models.WorkerTask task)
        {
            var timeSpan = System.TimeSpan.FromMilliseconds(_random.Next(128, 2048));
            Console.WriteLine($"Lazy worker is going to rest for {timeSpan.Milliseconds} ms");
            System.Threading.Tasks.Task.Delay(timeSpan).GetAwaiter().GetResult();
            return task.Completed();
        }
    }

    public class ClassWorker : IWorker
    {
        public string TaskType { get; }

        public WorkerSettings WorkerSettings { get; }

        public ClassWorker(string taskType = "random_task_type")
        {
            TaskType = taskType;
            WorkerSettings = new WorkerSettings();
        }

        public async Task<WorkerTaskResult> Run(SwiftConductor.Client.Models.WorkerTask task, CancellationToken token)
        {
            if (token != CancellationToken.None && token.IsCancellationRequested)
                throw new Exception("Cancellation token request");

            throw new NotImplementedException();
        }
    }
}
