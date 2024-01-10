using SwiftConductor.Client.Models;
using System.Collections.Generic;

namespace SwiftConductor.Definition
{
    public class ForkJoinTask : WorkflowTask
    {
        public ForkJoinTask(string taskReferenceName, params WorkflowTask[][] forkTasks) : 
            base(taskReferenceName: taskReferenceName, workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.FORKJOIN)
        {
            ForkTasks = new List<List<WorkflowTask>>();
            foreach (WorkflowTask[] forkTask in forkTasks)
            {
                ForkTasks.Add(new List<WorkflowTask>(forkTask));
            }
            JoinOn = new List<string>();
        }
    }
}
