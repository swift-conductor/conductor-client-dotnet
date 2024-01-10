using SwiftConductor.Client.Models;
using System.Collections.Generic;

namespace SwiftConductor.Definition
{
    public class WorkflowBuilder : WorkflowDef
    {
        public WorkflowBuilder() : base(name: "", tasks: new List<WorkflowTask>(), timeoutSeconds: 0)
        {
            InputParameters = new List<string>();
        }

        public WorkflowBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public WorkflowBuilder WithVersion(int version)
        {
            Version = version;
            return this;
        }

        public WorkflowBuilder WithDescription(string description)
        {
            Description = description;
            return this;
        }

        public WorkflowBuilder WithTimeoutPolicy(WorkflowDef.TimeoutPolicyEnum timeoutPolicy, int timeoutSeconds)
        {
            TimeoutPolicy = timeoutPolicy;
            TimeoutSeconds = timeoutSeconds;
            return this;
        }

        public WorkflowBuilder WithTasks(params WorkflowTask[] tasks)
        {
            foreach (WorkflowTask task in tasks)
            {
                Tasks.Add(task);
            }
            return this;
        }

        public WorkflowBuilder WithFailureWorkflow(string failureWorkflow)
        {
            FailureWorkflow = failureWorkflow;
            return this;
        }

        public WorkflowBuilder WithRestartable(bool restartable)
        {
            Restartable = restartable;
            return this;
        }

        public WorkflowBuilder WithOutputParameter(string key, object value)
        {
            OutputParameters.Add(key, value);
            return this;
        }

        public WorkflowBuilder WithOwnerEmail(string ownerEmail)
        {
            OwnerEmail = ownerEmail;
            return this;
        }

        public WorkflowBuilder WithInputParameter(string key)
        {
            InputParameters.Add(key);
            return this;
        }
    }
}
