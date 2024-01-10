using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class JQTask : WorkflowTask
    {
        private static string QUERY_EXPRESSION_PARAMETER = "queryExpression";

        public JQTask(string taskReferenceName, string queryExpression) : 
            base(taskReferenceName: taskReferenceName, workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.JSONJQTRANSFORM)
        {
            InputParameters.Add(QUERY_EXPRESSION_PARAMETER, queryExpression);
        }
    }
}
