using SwiftConductor.Client.Models;
using SwiftConductor.Client.Worker;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SwiftConductor.Client.Interfaces
{
    public interface IWorker
    {
        string TaskType { get; }
        
        WorkerSettings WorkerSettings { get; }
        
       Task<WorkerTaskResult> Run(Models.WorkerTask task, CancellationToken token = default);
    }
}
