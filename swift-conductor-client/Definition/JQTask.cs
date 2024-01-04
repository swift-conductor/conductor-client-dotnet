using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class JQTask : WorkflowTaskEx
    {
        private static string QUERY_EXPRESSION_PARAMETER = "queryExpression";

        public JQTask(string taskReferenceName, string queryExpression) : base(taskReferenceName, WorkflowTask.WorkflowTaskTypeEnum.JSONJQTRANSFORM)
        {
            WithInput(QUERY_EXPRESSION_PARAMETER, queryExpression);
        }
    }
}
