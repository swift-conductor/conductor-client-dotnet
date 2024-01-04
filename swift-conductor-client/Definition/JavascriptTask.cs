using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class JavascriptTask : WorkflowTaskEx
    {
        private const string EXPRESSION_PARAMETER = "expression";
        private const string EVALUATOR_TYPE_PARAMETER = "evaluatorType";

        public JavascriptTask(string taskReferenceName, string script) : base(taskReferenceName, WorkflowTask.WorkflowTaskTypeEnum.INLINE)
        {
            WithInput(EVALUATOR_TYPE_PARAMETER, "javascript");
            WithInput(EXPRESSION_PARAMETER, script);
        }
    }
}
