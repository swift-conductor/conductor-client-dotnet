using SwiftConductor.Client.Models;
using System.Collections.Generic;

namespace SwiftConductor.Client.Interfaces
{
    public interface IWorkerClient
    {
        List<WorkerTask> PollTask(string taskType, string workerId, string domain, int count);
        string UpdateTask(WorkerTaskResult result);
    }
}
