using Microsoft.Extensions.Logging;

using SwiftConductor.Client;
using SwiftConductor.Client.Worker;

using csharp.examples;

namespace csharp_examples
{
    public class Runner
    {

        /// <summary>
        /// Running multiple task as background services
        /// </summary>
        public async void RunMultipleWorkers()
        {
            var configuration = new Configuration();
            var host1 = WorkerHost.Create(configuration, LogLevel.Information, new Worker1());
            var ct1 = new CancellationTokenSource();
            await host1.StartAsync(ct1.Token);

            var host2 = WorkerHost.Create(configuration, LogLevel.Information, new Worker2());
            var ct2 = new CancellationTokenSource();
            await host2.StartAsync(ct1.Token);
            
            Thread.Sleep(TimeSpan.FromSeconds(100)); // will stop the service after 1 minute
        }

        /// <summary>
        /// Run single task as background service
        /// </summary>
        public async void RunOneWorker()
        {
            var configuration = new Configuration();
            
            var host = WorkerHost.Create(configuration, LogLevel.Information, new Worker1());
            
            var ct = new CancellationTokenSource();
            await host.StartAsync(ct.Token);
            
            Thread.Sleep(TimeSpan.FromSeconds(60)); // will stop the service after 1 minute 
        }
    }
}
