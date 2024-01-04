using System;

namespace SwiftConductor.Client.Worker
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class WorkerAttribute : Attribute
    {
        public string TaskType { get; }
        public WorkerSettings WorkerSettings { get; set; }

        public WorkerAttribute()
        {
            WorkerSettings = new WorkerSettings();
        }

        public WorkerAttribute(string taskType, int batchSize, string domain, int pollIntervalMs, string workerId)
        {
            TaskType = taskType;
            WorkerSettings = new WorkerSettings
            {
                BatchSize = batchSize,
                Domain = domain,
                PollInterval = TimeSpan.FromMilliseconds(pollIntervalMs),
                WorkerId = workerId,
            };
        }
    }
}
