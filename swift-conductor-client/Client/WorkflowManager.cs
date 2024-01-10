using SwiftConductor.Api;
using SwiftConductor.Client.Models;
using System.Collections.Generic;

namespace SwiftConductor.Client
{
    public class WorkflowManager
    {
        private WorkflowResourceApi _workflowClient;
        private MetadataResourceApi _metadataClient;

        public WorkflowManager(Configuration configuration)
        {
            _workflowClient = configuration.GetClient<WorkflowResourceApi>();
            _metadataClient = configuration.GetClient<MetadataResourceApi>();
        }

        public WorkflowManager(WorkflowResourceApi workflowClient, MetadataResourceApi metadataClient)
        {
            _workflowClient = workflowClient;
            _metadataClient = metadataClient;
        }

        public void RegisterWorkflow(WorkflowDef workflow, bool overwrite)
        {
            if (overwrite)
            {
                _metadataClient.UpdateWorkflowDefinitions(new List<WorkflowDef>(1) { workflow });
            }
            else
            {
                _metadataClient.Create(workflow);
            }
        }

        public string StartWorkflow(StartWorkflowRequest startWorkflowRequest)
        {
            return _workflowClient.StartWorkflow(startWorkflowRequest);
        }
    }
}
