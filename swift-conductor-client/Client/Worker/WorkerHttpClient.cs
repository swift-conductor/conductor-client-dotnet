using SwiftConductor.Api;
using SwiftConductor.Client.Interfaces;
using SwiftConductor.Client.Models;
using System.Collections.Generic;

namespace SwiftConductor.Client.Worker
{
    public class WorkerHttpClient : IWorkerClient
    {
        private readonly TaskResourceApi _client;
        public WorkerHttpClient(Configuration configuration)
        {
            _client = configuration.GetClient<TaskResourceApi>();
        }

        public List<WorkerTask> PollTask(string taskType, string workerId, string domain, int count = 1)
        {
            return _client.BatchPoll(taskType, workerId, domain, count);
        }

        public string UpdateTask(WorkerTaskResult result)
        {
            return _client.UpdateTask(result);
        }
    }
}
