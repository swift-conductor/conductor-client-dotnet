using SwiftConductor.Client.Models;
using System.Collections.Generic;

namespace SwiftConductor.Definition
{
    public class JoinTask : WorkflowTaskEx
    {
        public JoinTask(string taskReferenceName, params WorkflowTask[] joinOn) : base(taskReferenceName, WorkflowTask.WorkflowTaskTypeEnum.JOIN)
        {
            JoinOn = new List<string>();
            foreach (WorkflowTask forkTask in joinOn)
            {
                JoinOn.Add(forkTask.TaskReferenceName);
            }
        }
    }
}