# Swift Conductor Client for .NET

## ⭐ Swift Conductor

Show support for Swift Conductor.  Please help spread the awareness by starring Swift Conductor repo.

[![GitHub stars](https://img.shields.io/github/stars/swift-conductor/conductor.svg?style=social&label=Star&maxAge=)](https://GitHub.com/swift-conductor/conductor/)

Client usage:

1. Setup `swift-conductor-client` package
2. Create and run task workers
3. Create workflows using code
4. API Documentation

## Install Swift Conductor Client Package​

```sh
dotnet add package swift-conductor-client
```

## Configure API Client

```csharp
using SwiftConductor.Api;
using SwiftConductor.Client;

var configuration = new Configuration() {
    BasePath = "http://localhost:8080",
};

var workflowClient = configuration.GetClient<WorkflowResourceApi>();

workflowClient.StartWorkflow(
    name: "test-sdk-csharp-workflow",
    body: new Dictionary<string, object>(),
    version: 1
)
```

## Create and run task workers 

[Create and run task workers](https://github.com/swift-conductor/conductor-client-dotnet/blob/main/docs/readme/workers.md)

## Create and Execute Workflows 

[Create and Execute Workflows](https://github.com/swift-conductor/conductor-client-dotnet/blob/main/docs/readme/workflow.md)
