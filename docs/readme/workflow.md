# Authoring Workflows with the C# SDK

## A simple two-step workflow

```csharp
using SwiftConductor.Client;
using SwiftConductor.Definition;

WorkflowDef CreateWorkflowDef()
{
    return new WorkflowBuilder()
        .WithName("my_first_workflow")
        .WithVersion(1)
        .WithOwnerEmail("test@test.com")
            .WithTask(new CustomTask("custom_task_2", "custom_task_1"))
            .WithTask(new CustomTask("custom_task_1", "custom_task_2"));
}

var configuration = new Configuration();
var workflowManager = new WorkflowManager(configuration);

var workflowDef = CreateWorkflowDef();
workflowManager.RegisterWorkflow(workflow: workflowDef, overwrite: true);

var startWorkflowRequest = workflowDef.GetStartWorkflowRequest();
var workflowId = workflowManager.StartWorkflow();
```
