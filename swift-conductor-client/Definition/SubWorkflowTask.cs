using SwiftConductor.Client.Models;
using System.Collections.Generic;

namespace SwiftConductor.Definition
{
    public class SubWorkflowTask : WorkflowTaskEx
    {
        public SubWorkflowTask(string taskReferenceName, SubWorkflowParams subWorkflowParams) : base(taskReferenceName, WorkflowTask.WorkflowTaskTypeEnum.SUBWORKFLOW)
        {
            SubWorkflowParam = subWorkflowParams;
        }

        public SubWorkflowTask(string taskReferenceName, WorkflowDef workflow, Dictionary<string, string> taskToDomain = default(Dictionary<string, string>)) : base(taskReferenceName, WorkflowTask.WorkflowTaskTypeEnum.SUBWORKFLOW)
        {
            SubWorkflowParam = new SubWorkflowParams
            (
                name: workflow.Name,
                version: workflow.Version,
                taskToDomain: taskToDomain,
                workflowDefinition: workflow
            );
        }
    }
}
