using System.Threading.Tasks.Dataflow;
using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class CustomTask : WorkflowTask
    {
        public CustomTask(string taskName, string taskReferenceName) : 
            base(name: taskName, taskReferenceName: taskReferenceName, workflowTaskType: WorkflowTaskTypeEnum.CUSTOM) 
        {
            Name = taskName;
        }
    }
}