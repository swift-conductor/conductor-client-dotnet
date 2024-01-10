using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class EventTask : WorkflowTask
    {
        public EventTask(string taskReferenceName, string eventSink) : base(taskReferenceName: taskReferenceName, workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.EVENT)
        {
            Sink = eventSink;
        }
    }
}
