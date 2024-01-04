using SwiftConductor.Client.Models;
using System.Collections.Generic;

namespace SwiftConductor.Definition
{
    public class WorkflowDefEx : WorkflowDef
    {
        public WorkflowDefEx() : base(name: "", tasks: new List<WorkflowTask>(), timeoutSeconds: 0)
        {
            InputParameters = new List<string>();
        }

        public WorkflowDefEx WithName(string name)
        {
            Name = name;
            return this;
        }

        public WorkflowDefEx WithVersion(int version)
        {
            Version = version;
            return this;
        }

        public WorkflowDefEx WithDescription(string description)
        {
            Description = description;
            return this;
        }

        public WorkflowDefEx WithTimeoutPolicy(WorkflowDef.TimeoutPolicyEnum timeoutPolicy, int timeoutSeconds)
        {
            TimeoutPolicy = timeoutPolicy;
            TimeoutSeconds = timeoutSeconds;
            return this;
        }

        public WorkflowDefEx WithTask(params WorkflowTask[] tasks)
        {
            foreach (WorkflowTask task in tasks)
            {
                Tasks.Add(task);
            }
            return this;
        }

        public WorkflowDefEx WithFailureWorkflow(string failureWorkflow)
        {
            FailureWorkflow = failureWorkflow;
            return this;
        }

        public WorkflowDefEx WithRestartable(bool restartable)
        {
            Restartable = restartable;
            return this;
        }

        public WorkflowDefEx WithOutputParameter(string key, object value)
        {
            OutputParameters.Add(key, value);
            return this;
        }

        public WorkflowDefEx WithOwnerEmail(string ownerEmail)
        {
            OwnerEmail = ownerEmail;
            return this;
        }

        public WorkflowDefEx WithInputParameter(string key)
        {
            InputParameters.Add(key);
            return this;
        }

        public StartWorkflowRequest GetStartWorkflowRequest()
        {
            return new StartWorkflowRequest(
                name: Name,
                version: Version
            );
        }
    }
}
