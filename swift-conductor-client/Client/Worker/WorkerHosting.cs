using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using SwiftConductor.Client.Interfaces;
using SwiftConductor.Client.Extensions;

namespace SwiftConductor.Client.Worker
{
    public class WorkerHosting
    {
        public static IHost CreateWorkerHost(LogLevel logLevel = LogLevel.Information)
        {
            return CreateWorkerHost(ApiExtensions.GetConfiguration(), logLevel);
        }

        public static IHost CreateWorkerHost(Configuration configuration, LogLevel logLevel = LogLevel.Information)
        {
            return CreateWorkerHost(configuration, logLevel, workers: new IWorker[0]);
        }

        public static IHost CreateWorkerHost<T>(LogLevel logLevel = LogLevel.Information, params T[] workers) where T : IWorker
        {
            return CreateWorkerHost(ApiExtensions.GetConfiguration(), logLevel, workers);
        }

        public static IHost CreateWorkerHost<T>(Configuration configuration, LogLevel logLevel = LogLevel.Information, params T[] workers) where T : IWorker
        {
            return new HostBuilder()
                .ConfigureServices(
                    (ctx, services) =>
                        {
                            services.AddWorkerManager(configuration);
                            foreach (var worker in workers)
                            {
                                services.AddWorker(worker);
                            }
                            services.WithHostedService();
                        }
                ).ConfigureLogging(
                    logging =>
                        {
                            logging.SetMinimumLevel(logLevel);
                            logging.AddConsole();
                        }
                ).Build();
        }
    }
}
