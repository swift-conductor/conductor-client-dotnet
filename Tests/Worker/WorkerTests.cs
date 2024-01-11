using Microsoft.Extensions.Logging;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Client.Extensions;
using SwiftConductor.Client.Models;
using SwiftConductor.Client.Worker;
using SwiftConductor.Definition;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace Tests.Worker
{
    public class WorkerTests
    {
        private const string WORKFLOW_NAME = "test-sdk-csharp-worker";
        private const int WORKFLOW_VERSION = 1;
        private const string TASK_NAME = "test-sdk-csharp-task";
        private const string TASK_TYPE = "test-sdk-csharp-task-type";
        private const string TASK_DOMAIN = "taskDomain";

        private readonly WorkflowResourceApi _workflowClient;

        public WorkerTests()
        {
            _workflowClient = Conductor.GetClient<WorkflowResourceApi>();
        }

        [Fact]
        public async System.Threading.Tasks.Task TestWorkflowAsyncExecution()
        {
            var manager = Conductor.GetWorkflowManager();

            var taskDefs = CreateTaskDefs();
            manager.MetadataClient.RegisterTaskDefs(taskDefs);

            var workflowDef = CreateWorkflowDef();
            manager.RegisterWorkflow(workflowDef, overwrite: true);

            var workflowIdList = await StartWorkflows(workflowDef, quantity: 1);
            
            await ExecuteWorkflowTasks(workflowCompletionTimeout: TimeSpan.FromSeconds(20));
            
            await ValidateWorkflowCompletion(workflowIdList.ToArray());
        }

        private List<TaskDef> CreateTaskDefs()
        {
            return new List<TaskDef>() { 
                new TaskDef(name: TASK_TYPE, timeoutSeconds: -1, ownerEmail: "tets@test.com") 
            };
        }

        private WorkflowDef CreateWorkflowDef()
        {
            var workflow = new WorkflowBuilder()
                .WithName(WORKFLOW_NAME)
                .WithVersion(WORKFLOW_VERSION)
                .WithOwnerEmail("test@test.com")
                .WithTasks(new CustomTask(TASK_TYPE, TASK_NAME));

            return workflow;
        }

        private async System.Threading.Tasks.Task<ConcurrentBag<string>> StartWorkflows(WorkflowDef workflow, int quantity)
        {
            var manager = Conductor.GetWorkflowManager();

            var startWorkflowRequest = new StartWorkflowRequest(name: workflow.Name, version: workflow.Version, workflowDef: workflow) {
                TaskToDomain = new Dictionary<string, string> { { TASK_NAME, TASK_DOMAIN } }
            };

            var startedWorkflows = await manager.StartWorkflows(startWorkflowRequest, maxAllowedInParallel: 10, total: quantity);
            return startedWorkflows;
        }

        private async System.Threading.Tasks.Task ExecuteWorkflowTasks(TimeSpan workflowCompletionTimeout)
        {
            var host = WorkerHost.Create(LogLevel.Debug, new Worker());
            await host.StartAsync();
            
            Thread.Sleep(workflowCompletionTimeout);
            
            await host.StopAsync();
        }

        private async System.Threading.Tasks.Task ValidateWorkflowCompletion(params string[] workflowIdList)
        {
            var manager = Conductor.GetWorkflowManager();

            var incompleteWorkflowCounter = 0;

            foreach (var workflowId in workflowIdList)
            {
                var workflow = manager.WorkflowClient.GetExecutionStatus(workflowId);
                if (workflow.Status.Value != Workflow.StatusEnum.COMPLETED)
                {
                    incompleteWorkflowCounter += 1;
                    Console.WriteLine($"Workflow not completed, workflowId: {workflowId}");
                }
            }

            Assert.Equal(0, incompleteWorkflowCounter);
        }
    }
}
