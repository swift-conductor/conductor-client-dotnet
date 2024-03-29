using System;

using SwiftConductor.Api;

namespace SwiftConductor.Client
{
    public class Conductor
    {
        private const string ENV_ROOT_URI = "CONDUCTOR_SERVER_URL";
        public static Configuration Configuration { get; set; }

        static Conductor()
        {
            Configuration = new Configuration
            {
                Timeout = 30 * 1000,
                BasePath = GetEnvironmentVariable(ENV_ROOT_URI) ?? "http://localhost:8080/api",
            };
        }

        public static WorkflowManager GetWorkflowManager()
        {
            return new WorkflowManager(
                metadataClient: GetClient<MetadataResourceApi>(),
                workflowClient: GetClient<WorkflowResourceApi>()
            );
        }

        public static T GetClient<T>() where T : IApiAccessor, new()
        {
            return Configuration.GetClient<T>();
        }

        public static Configuration GetConfiguration()
        {
            return Configuration;
        }

        public static string GetWorkflowExecutionURL(string workflowId)
        {
            var basePath = Configuration.BasePath;
            var prefix = basePath.Remove(basePath.Length - 4);
            return $"{prefix}/execution/{workflowId}";
        }

        private static string GetEnvironmentVariable(string variable)
        {
            string value = Environment.GetEnvironmentVariable(variable);
            return value;
        }
    }
}
