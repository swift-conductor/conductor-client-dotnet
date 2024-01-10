using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class JavascriptTask : WorkflowTask
    {
        private const string EXPRESSION_PARAMETER = "expression";
        private const string EVALUATOR_TYPE_PARAMETER = "evaluatorType";

        public JavascriptTask(string taskReferenceName, string script) : 
            base(taskReferenceName: taskReferenceName, workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.INLINE)
        {
            InputParameters.Add(EVALUATOR_TYPE_PARAMETER, "javascript");
            InputParameters.Add(EXPRESSION_PARAMETER, script);
        }
    }
}
