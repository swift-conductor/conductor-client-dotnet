# Swift Conductor client SDK for .NET

The conductor-client-dotnet repository provides the client SDKs to build task workers in C#.

Building the task workers in C# mainly consists of the following steps:

1. Setup `conductor-client-dotnet` package
1. Create and run task workers
1. Create workflows using code
1. API Documentation

## ⭐ Swift Conductor
Show support for Swift Conductor.  Please help spread the awareness by starring Conductor repo.

[![GitHub stars](https://img.shields.io/github/stars/swift-conductor/conductor.svg?style=social&label=Star&maxAge=)](https://GitHub.com/swift-conductor/conductor/)

   
### Setup Conductor C# Package​

```shell
dotnet add package conductor-client-dotnet
```

## Configurations

### Configure API Client
```csharp
using Conductor.Api;
using Conductor.Client;

var configuration = new Configuration() {
    BasePath = basePath,
};

var workflowClient = configuration.GetClient<WorkflowResourceApi>();

workflowClient.StartWorkflow(
    name: "test-sdk-csharp-workflow",
    body: new Dictionary<string, object>(),
    version: 1
)
```

### Next: [Create and run task workers](https://github.com/swift-conductor/conductor-client-dotnet/blob/main/docs/readme/workers.md)
