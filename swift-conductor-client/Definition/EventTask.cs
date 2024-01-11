using System.Collections.Generic;
using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class EventTask : WorkflowTask
    {
        public EventTask(string taskReferenceName, string eventSink) : base(name: taskReferenceName, taskReferenceName: taskReferenceName, inputParameters: new Dictionary<string, object>(), workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.EVENT)
        {
            Sink = eventSink;
        }
    }
}
