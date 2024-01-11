using System.Collections.Generic;
using SwiftConductor.Client.Models;

namespace SwiftConductor.Definition
{
    public class InlineTask : WorkflowTask
    {
        private const string EXPRESSION_PARAMETER = "expression";
        private const string EVALUATOR_TYPE_PARAMETER = "evaluatorType";

        public InlineTask(string taskReferenceName, string script) : 
            base(name: taskReferenceName, taskReferenceName: taskReferenceName, inputParameters: new Dictionary<string, object>(), workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.INLINE)
        {
            InputParameters.Add(EVALUATOR_TYPE_PARAMETER, "javascript");
            InputParameters.Add(EXPRESSION_PARAMETER, script);
        }
    }
}
