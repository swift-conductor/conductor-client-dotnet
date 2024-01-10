using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class SetVariableTask : WorkflowTask
    {
        public SetVariableTask(string taskReferenceName) : 
            base(taskReferenceName: taskReferenceName, workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.SETVARIABLE) { }
    }
}
