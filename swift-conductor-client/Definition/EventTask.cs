using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class EventTask : WorkflowTaskEx
    {
        public EventTask(string taskReferenceName, string eventSink) : base(taskReferenceName, WorkflowTask.WorkflowTaskTypeEnum.EVENT)
        {
            Sink = eventSink;
        }
    }
}
