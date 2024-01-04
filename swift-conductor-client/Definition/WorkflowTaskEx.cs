using SwiftConductor.Client.Models;
using System.Collections.Generic;

namespace SwiftConductor.Definition
{
    public abstract class WorkflowTaskEx : WorkflowTask
    {
        public WorkflowTaskEx(string taskReferenceName, WorkflowTask.WorkflowTaskTypeEnum taskType) :
            base(
                name: taskReferenceName,
                taskReferenceName: taskReferenceName,
                workflowTaskType: taskType,
                inputParameters: new Dictionary<string, object>()
            )
        { }

        public WorkflowTaskEx WithInput(string key, object value)
        {
            InputParameters.Add(key, value);
            return this;
        }
    }
}
