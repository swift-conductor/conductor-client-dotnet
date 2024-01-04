using System;

namespace SwiftConductor.Client.Worker
{
    public class WorkerSettings
    {
        public int BatchSize { get; set; } = Math.Max(2, Environment.ProcessorCount * 2);
        public string Domain { get; set; } = null;
        public TimeSpan PollInterval { get; set; } = TimeSpan.FromMilliseconds(100);
        public string WorkerId { get; set; } = Environment.MachineName;
    }
}