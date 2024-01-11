using SwiftConductor.Api;
using SwiftConductor.Client.Models;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Security.Cryptography;

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

        public WorkflowResourceApi WorkflowClient {
            get {
                return _workflowClient; 
            }
        }

        public MetadataResourceApi MetadataClient {
            get {
                return _metadataClient; 
            }
        }

        public void RegisterWorkflow(WorkflowDef workflow, bool overwrite=false)
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
