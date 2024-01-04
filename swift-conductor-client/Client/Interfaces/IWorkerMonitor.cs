using System.Threading;

namespace SwiftConductor.Client.Interfaces
{
    public interface IWorkerMonitor
    {
        void IncrementRunningWorker();
        int GetRunningWorkers();
        void RunningWorkerDone();
    }
}