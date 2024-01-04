using SwiftConductor.Client.Interfaces;
using SwiftConductor.Client.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net.Http;

namespace SwiftConductor.Client.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddWorker<T>(this IServiceCollection services) where T : IWorker
        {
            services.AddTransient(typeof(IWorker), typeof(T));
            services.AddTransient(typeof(T));
            return services;
        }

        public static IServiceCollection AddWorker<T>(this IServiceCollection services, T worker) where T : IWorker
        {
            services.AddTransient(typeof(IWorker), typeof(T));
            services.AddTransient(typeof(T));
            return services;
        }

        public static IServiceCollection AddWorkerManager(this IServiceCollection services, Configuration configuration = null, Action<IServiceProvider, HttpClient> configureHttpClient = null)
        {
            services.AddHttpClient();
            services.AddOptions();
            if (configuration == null)
            {
                configuration = new Configuration();
            }
            services.AddSingleton<Configuration>(configuration);
            services.AddSingleton<IWorkerClient, WorkerHttpClient>();
            services.AddTransient<IWorkerManager, WorkerManager>();
            return services;
        }

        public static IServiceCollection WithHostedService<T>(this IServiceCollection services) where T : BackgroundService
        {
            services.AddHostedService<T>();
            return services;
        }

        public static IServiceCollection WithHostedService(this IServiceCollection services)
        {
            services.AddHostedService<WorkerService>();
            return services;
        }
    }
}
