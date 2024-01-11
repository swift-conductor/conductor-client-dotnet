using SwiftConductor.Client.Models;
using System;
using System.Collections.Generic;

namespace SwiftConductor.Definition
{
    public class WaitTask : WorkflowTask
    {
        private static string DURATION_PARAMETER = "duration";
        private static string UNTIL_PARAMETER = "until";

        public WaitTask(string taskReferenceName, TimeSpan duration) : base(name: taskReferenceName, taskReferenceName: taskReferenceName, inputParameters: new Dictionary<string, object>(), workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.WAIT)
        {
            InputParameters.Add(DURATION_PARAMETER, duration.Seconds.ToString() + "s");
        }

        public WaitTask(string taskReferenceName, DateTime until) : base(name: taskReferenceName, taskReferenceName: taskReferenceName, inputParameters: new Dictionary<string, object>(), workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.WAIT)
        {
            InputParameters.Add(UNTIL_PARAMETER, until.ToString("yyyy-MM-dd HH:mm z"));
        }
    }
}
