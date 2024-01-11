using SwiftConductor.Client.Models;
using System.Collections.Generic;

namespace SwiftConductor.Definition
{
    public class DoWhileTask : WorkflowTask
    {
        public DoWhileTask(string taskReferenceName, string loopCondition, params WorkflowTask[] loopOver) : 
            base(name: taskReferenceName, taskReferenceName: taskReferenceName, inputParameters: new Dictionary<string, object>(), workflowTaskType: WorkflowTask.WorkflowTaskTypeEnum.DOWHILE)
        {
            LoopCondition = loopCondition;
            LoopOver = new List<WorkflowTask>(loopOver);
        }
    }

    public class LoopTask : DoWhileTask
    {
        public LoopTask(string taskReferenceName, int iterations, params WorkflowTask[] loopOver) :
            base(
                taskReferenceName: taskReferenceName, 
                loopCondition: GetForLoopCondition(taskReferenceName, iterations),
                loopOver: loopOver
            )
        { }

        private static string GetForLoopCondition(string taskReferenceName, int iterations)
        {
            return "if ( $." + taskReferenceName + "['iteration'] < " + iterations.ToString() + " ) { true; } else { false; }";
        }
    }
}
