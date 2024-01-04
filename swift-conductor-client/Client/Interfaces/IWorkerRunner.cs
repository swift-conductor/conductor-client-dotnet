using System.Threading;
using System.Threading.Tasks;

namespace SwiftConductor.Client.Interfaces
{
    public interface IWorkerRunner
    {
        Task Start(CancellationToken token = default);
    }
}
