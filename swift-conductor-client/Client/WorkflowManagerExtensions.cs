using SwiftConductor.Api;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace SwiftConductor.Client.Extensions
{
    public static class WorkflowManagerExtensions
    {
        private static int RETRY_ATTEMPT_LIMIT = 3;

        public static async Task<ConcurrentBag<string>> StartWorkflows(this WorkflowManager manager, Models.StartWorkflowRequest startWorkflowRequest, int maxAllowedInParallel, int total)
        {
            var workflowClient = manager.WorkflowClient; 
            
            var workflowIds = new ConcurrentBag<string>();
            
            await StartWorkflowBatch(workflowClient, startWorkflowRequest, total % maxAllowedInParallel, workflowIds);
            
            for (int i = 1; i * maxAllowedInParallel <= total; i += 1)
            {
                await StartWorkflowBatch(workflowClient, startWorkflowRequest, maxAllowedInParallel, workflowIds);
            }
            
            Console.WriteLine($"Started {workflowIds.Count} workflows");
            
            return workflowIds;
        }

        private static async Task StartWorkflowBatch(WorkflowResourceApi workflowClient, Models.StartWorkflowRequest startWorkflowRequest, int quantity, ConcurrentBag<string> workflowIds)
        {
            var threads = new List<Task>();
            for (int counter = 0; counter < quantity; counter += 1)
            {
                threads.Add(Task.Run(() => StartWorkflow(workflowClient, startWorkflowRequest, workflowIds)));
            }
            await Task.WhenAll(threads);
        }

        private static void StartWorkflow(WorkflowResourceApi workflowClient, Models.StartWorkflowRequest startWorkflowRequest, ConcurrentBag<string> workflowIds)
        {
            for (int attempt = 0; attempt < RETRY_ATTEMPT_LIMIT; attempt += 1)
            {
                try
                {
                    var workflowId = workflowClient.StartWorkflow(startWorkflowRequest);
                    workflowIds.Add(workflowId);
                    
                    return;
                }
                catch (ApiException e)
                {
                    Console.WriteLine($"Failed to start workflow, reason: {e}");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1 << attempt));
                }
            }
        }
    }
}