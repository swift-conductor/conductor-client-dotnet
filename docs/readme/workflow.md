# Authoring Workflows with the C# SDK

## A simple two-step workflow

```csharp
using SwiftConductor.Client;
using SwiftConductor.Definition;

WorkflowDefEx CreateWorkflowDef()
{
    return new WorkflowDefEx()
        .WithName("my_first_workflow")
        .WithVersion(1)
        .WithOwnerEmail("test@test.com")
            .WithTask(new SimpleTask("simple_task_2", "simple_task_1"))
            .WithTask(new SimpleTask("simple_task_1", "simple_task_2"));
}

var configuration = new Configuration();
var workflowManager = new WorkflowManager(configuration);

var workflowDef = CreateWorkflowDef();
workflowManager.RegisterWorkflow(workflow: workflowDef, overwrite: true);

var workflowId = workflowManager.StartWorkflow(workflowDefinition);
```
