using SwiftConductor.Client.Worker;
using System.Threading;
using System.Threading.Tasks;

namespace SwiftConductor.Client.Interfaces
{
    public interface IWorkerManager
    {
        Task Start(CancellationToken token = default);
        void RegisterWorker(IWorker worker);
    }
}
