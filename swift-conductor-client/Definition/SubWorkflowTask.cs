using SwiftConductor.Client.Models;
using System.Collections.Generic;

namespace SwiftConductor.Definition
{
    public class SubWorkflowTask : WorkflowTask
    {
        public SubWorkflowTask(string taskReferenceName, SubWorkflowParams subWorkflowParams) : 
            base(name: taskReferenceName, taskReferenceName: taskReferenceName, inputParameters: new Dictionary<string, object>(), workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.SUBWORKFLOW)
        {
            SubWorkflowParam = subWorkflowParams;
        }

        public SubWorkflowTask(string taskReferenceName, WorkflowDef workflow, Dictionary<string, string> taskToDomain = default(Dictionary<string, string>)) : 
            base(name: taskReferenceName, taskReferenceName: taskReferenceName, inputParameters: new Dictionary<string, object>(), workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.SUBWORKFLOW)
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
