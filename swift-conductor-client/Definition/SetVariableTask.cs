using System.Collections.Generic;
using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class SetVariableTask : WorkflowTask
    {
        public SetVariableTask(string taskReferenceName) : 
            base(name: taskReferenceName, taskReferenceName: taskReferenceName, inputParameters: new Dictionary<string, object>(), workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.SETVARIABLE) { }
    }
}
