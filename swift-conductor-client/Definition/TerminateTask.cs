using System.Collections.Generic;
using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class TerminateTask : WorkflowTask
    {
        private static string WORKFLOW_ID_PARAMETER = "workflowId";
        private static string TERMINATION_REASON_PARAMETER = "terminationReason";
        private static string TERMINATION_STATUS_PARAMETER = "terminationStatus";

        public TerminateTask(string taskReferenceName, WorkflowStatus.StatusEnum terminationStatus = WorkflowStatus.StatusEnum.FAILED, string workflowId = null, string terminationReason = null) : 
            base(name: taskReferenceName, taskReferenceName: taskReferenceName, inputParameters: new Dictionary<string, object>(), workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.TERMINATE)
        {
            InputParameters.Add(TERMINATION_STATUS_PARAMETER, terminationStatus);
            
            if (workflowId != null)
            {
                InputParameters.Add(WORKFLOW_ID_PARAMETER, workflowId);
            }

            if (terminationReason != null)
            {
                InputParameters.Add(TERMINATION_REASON_PARAMETER, terminationReason);
            }
        }
    }
}
