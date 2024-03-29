# Writing Workers with the C# SDK

A worker is responsible for executing a task. 
Operator and System tasks are handled by the Conductor server, while user defined tasks needs to have a worker created that awaits the work to be scheduled by the server for it to be executed.

Worker framework provides features such as polling threads, metrics and server communication.

### Design Principles for Workers

Worker implementation should follow certain design principles:

1. Workers are stateless and do not implement a workflow specific logic. 
2. Each worker executes a very specific task and produces well-defined output given specific inputs. 
3. Workers are meant to be idempotent (or should handle cases where the task that partially executed gets rescheduled due to timeouts etc.)
4. Workers do not implement the logic to handle retries etc, that is taken care by the Conductor server.

### Creating Task Workers

Example worker

```csharp
public class CustomWorker : IWorker
{
    public string TaskType { get; }
    public WorkerSettings WorkerSettings { get; }

    public CustomWorker()
    {
        TaskType = "custom_task_type";
        WorkerSettings = new WorkerSettings();
    }

    public async Task<WorkerTaskResult> Run(WorkerTask workerTask, CancellationToken token)
    {
        if (token != CancellationToken.None && token.IsCancellationRequested)
            return workerTask.Failed("Cancellation token request");

        return await Task.Run(() => workerTask.Completed());
    }
}
```

## Starting Workers

You can use `WorkerHost` to create a worker host, it requires a configuration object and then you can add your workers.

```csharp
using System;
using System.Threading.Thread;

using SwiftConductor.Client;
using SwiftConductor.Client.Worker;

var configuration = new Configuration();

var host = WorkerHost.Create(configuration, new CustomWorker());

await host.startAsync();
Thread.Sleep(TimeSpan.FromSeconds(60));

await host.StopAsync();
```

Check out our [integration tests](https://github.com/swift-conductor/conductor-client-dotnet/blob/main/Tests/Worker/WorkerTests.cs) for more examples

Worker SDK collects the following metrics:


| Name               | Purpose                                      | Tags                             |
| ------------------ | :------------------------------------------- | -------------------------------- |
| task_poll_error    | Client error when polling for a task queue   | taskType, includeRetries, status |
| task_execute_error | Execution error                              | taskType                         |
| task_update_error  | Task status cannot be updated back to server | taskType                         |
| task_poll_counter  | Incremented each time polling is done        | taskType                         |
| task_poll_time     | Time to poll for a batch of tasks            | taskType                         |
| task_execute_time  | Time to execute a task                       | taskType                         |
| task_result_size   | Records output payload size of a task        | taskType                         |

Metrics on client side supplements the one collected from server in identifying the network as well as client side issues.
