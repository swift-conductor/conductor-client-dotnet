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
        public async void RunMultiSimpleTask()
        {
            var configuration = new Configuration();
            var host = WorkerHosting.CreateWorkerHost(configuration, LogLevel.Information, new SimpleTask1());
            var ct = new CancellationTokenSource();
            await host.StartAsync(ct.Token);
            var host1 = WorkerHosting.CreateWorkerHost(configuration, LogLevel.Information, new SimpleTask2());
            var ct1 = new CancellationTokenSource();
            await host1.StartAsync(ct.Token);
            Thread.Sleep(TimeSpan.FromSeconds(100)); // after 100 seconds will stop the service
        }

        /// <summary>
        /// Run single task as background service
        /// </summary>
        public async void RunSimpleTask()
        {
            var configuration = new Configuration();
            var host = WorkerHosting.CreateWorkerHost(configuration, LogLevel.Information, new SimpleTask1());
            var ct = new CancellationTokenSource();
            await host.StartAsync();
            Thread.Sleep(TimeSpan.FromSeconds(100)); // after 100 seconds will stop the service
        }
    }
}
