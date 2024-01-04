using SwiftConductor.Api;
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
        private const string TASK_DOMAIN = "taskDomain";

        private readonly WorkflowResourceApi _workflowClient;

        public WorkerTests()
        {
            _workflowClient = ApiExtensions.GetClient<WorkflowResourceApi>();
        }

        [Fact]
        public async System.Threading.Tasks.Task TestWorkflowAsyncExecution()
        {
            var workflow = GetConductorWorkflow();

            ApiExtensions.GetWorkflowManager().RegisterWorkflow(workflow, true);
            var workflowIdList = await StartWorkflows(workflow, quantity: 35);
            await ExecuteWorkflowTasks(workflowCompletionTimeout: TimeSpan.FromSeconds(20));
            await ValidateWorkflowCompletion(workflowIdList.ToArray());
        }

        private SwiftConductor.Definition.WorkflowDefEx GetConductorWorkflow()
        {
            var workflow = new SwiftConductor.Definition.WorkflowDefEx()
                .WithName(WORKFLOW_NAME)
                .WithVersion(WORKFLOW_VERSION)
                .WithOwnerEmail("test@test.com")
                .WithTask(new SimpleTask(TASK_NAME, TASK_NAME));

            return workflow;
        }

        private async System.Threading.Tasks.Task<ConcurrentBag<string>> StartWorkflows(SwiftConductor.Definition.WorkflowDefEx workflow, int quantity)
        {
            var startWorkflowRequest = workflow.GetStartWorkflowRequest();
            startWorkflowRequest.TaskToDomain = new Dictionary<string, string> { { TASK_NAME, TASK_DOMAIN } };
            var startedWorkflows = await WorkflowExtensions.StartWorkflows(
                _workflowClient,
                startWorkflowRequest,
                maxAllowedInParallel: 10,
                total: quantity
            );
            return startedWorkflows;
        }

        private async System.Threading.Tasks.Task ExecuteWorkflowTasks(TimeSpan workflowCompletionTimeout)
        {
            var host = WorkerHosting.CreateWorkerHost(Microsoft.Extensions.Logging.LogLevel.Debug);
            host = WorkerHosting.CreateWorkerHost(Microsoft.Extensions.Logging.LogLevel.Debug, new ClassWorker());
            await host.StartAsync();
            Thread.Sleep(workflowCompletionTimeout);
            await host.StopAsync();
        }

        private async System.Threading.Tasks.Task ValidateWorkflowCompletion(params string[] workflowIdList)
        {
            var workflowStatusList = await WorkflowExtensions.GetWorkflowStatusList(
                _workflowClient,
                maxAllowedInParallel: 10,
                workflowIdList
            );
            var incompleteWorkflowCounter = 0;
            foreach (var workflowStatus in workflowStatusList)
            {
                if (workflowStatus.Status.Value != WorkflowStatus.StatusEnum.COMPLETED)
                {
                    incompleteWorkflowCounter += 1;
                    Console.WriteLine($"Workflow not completed, workflowId: {workflowStatus.WorkflowId}");
                }
            }
            Assert.Equal(0, incompleteWorkflowCounter);
        }
    }
}
