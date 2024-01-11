# Authoring Workflows with the C# SDK

## A simple two-step workflow

```csharp
using SwiftConductor.Client;
using SwiftConductor.Definition;

List<TaskDef> CreateTaskDefs()
{
    return new List<TaskDef>() { 
        new TaskDef(name: "custom_task_type", timeoutSeconds: -1, ownerEmail: "test@test.com") 
    };
}

WorkflowDef CreateWorkflowDef()
{
    return new WorkflowBuilder()
        .WithName("my_first_workflow")
        .WithVersion(1)
        .WithOwnerEmail("test@test.com")
        .WithTasks(    
            new CustomTask("custom_task_type", "custom_task_1"),
            new CustomTask("custom_task_type", "custom_task_2")
        );
}

var configuration = new Configuration();
var manager = new WorkflowManager(configuration);

var taskDefs = CreateTaskDefs();
manager.MetadataClient.RegisterTaskDefs(taskDefs);

var workflowDef = CreateWorkflowDef();
manager.MetadataClient.Create(workflowDef);

var startWorkflowRequest = new StartWorkflowRequest(name: workflowDef.Name, version: workflowDef.Version, workflowDef: workflowDef);
var workflowId = manager.WorkflowClient.StartWorkflow(startWorkflowRequest)

```
