using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class SetVariableTask : WorkflowTaskEx
    {
        public SetVariableTask(string taskReferenceName) : base(taskReferenceName, WorkflowTask.WorkflowTaskTypeEnum.SETVARIABLE) { }
    }
}
