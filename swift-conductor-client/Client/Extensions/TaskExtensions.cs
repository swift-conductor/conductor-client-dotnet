using SwiftConductor.Client.Models;
using System;
using System.Collections.Generic;

namespace SwiftConductor.Client.Extensions
{
    public static class TaskExtensions
    {
        public static WorkerTaskResult InProgress(this WorkerTask task, string log = null, long? callbackAfterSeconds = null, Dictionary<string, object> outputData = null)
        {
            return new WorkerTaskResult
            (
                workflowInstanceId: task.WorkflowInstanceId,
                taskId: task.TaskId,
                status: WorkerTaskResult.StatusEnum.INPROGRESS,
                outputData: outputData,
                logs: new List<TaskExecLog>
                {
                    new TaskExecLog { TaskId = task.TaskId, Log = log, CreatedTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() }
                },
                callbackAfterSeconds: callbackAfterSeconds.Value
            );
        }

        public static WorkerTaskResult InProgress(this WorkerTask task, Dictionary<string, object> outputData = null, List<TaskExecLog> logs = null)
        {
            return new WorkerTaskResult
            (
                workflowInstanceId: task.WorkflowInstanceId,
                taskId: task.TaskId,
                status: WorkerTaskResult.StatusEnum.INPROGRESS,
                outputData: outputData,
                logs: logs
            );
        }

        public static WorkerTaskResult Completed(this WorkerTask task, Dictionary<string, object> outputData = null, List<TaskExecLog> logs = null)
        {
            return new WorkerTaskResult
            (
                workflowInstanceId: task.WorkflowInstanceId,
                taskId: task.TaskId,
                status: WorkerTaskResult.StatusEnum.COMPLETED,
                outputData: outputData,
                logs: logs
            );
        }

        public static WorkerTaskResult Failed(this WorkerTask task, string errorMessage, Dictionary<string, object> outputData = null, List<TaskExecLog> logs = null)
        {
            return new WorkerTaskResult
            (
                workflowInstanceId: task.WorkflowInstanceId,
                taskId: task.TaskId,
                status: WorkerTaskResult.StatusEnum.FAILED,
                reasonForIncompletion: errorMessage,
                outputData: outputData,
                logs: logs
            );
        }

        public static WorkerTaskResult FailedWithTerminalError(this WorkerTask task, string errorMessage, Dictionary<string, object> outputData = null, List<TaskExecLog> logs = null)
        {
            return new WorkerTaskResult
            (
                workflowInstanceId: task.WorkflowInstanceId,
                taskId: task.TaskId,
                status: WorkerTaskResult.StatusEnum.FAILEDWITHTERMINALERROR,
                reasonForIncompletion: errorMessage,
                outputData: outputData,
                logs: logs
            );
        }
    }
}
