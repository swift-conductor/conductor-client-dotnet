using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class SimpleTask : WorkflowTaskEx
    {
        public SimpleTask(string taskName, string taskReferenceName) : base(taskReferenceName, WorkflowTask.WorkflowTaskTypeEnum.SIMPLE)
        {
            Name = taskName;
        }
    }
}