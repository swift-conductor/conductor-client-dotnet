# SwiftConductor.Api.WorkflowResourceApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Decide**](WorkflowResourceApi.md#decide) | **PUT** /api/workflow/decide/{workflowId} | Starts the decision task for a workflow |
| [**Delete**](WorkflowResourceApi.md#delete) | **DELETE** /api/workflow/{workflowId}/remove | Removes the workflow from the system |
| [**GetExecutionStatus**](WorkflowResourceApi.md#getexecutionstatus) | **GET** /api/workflow/{workflowId} | Gets the workflow by workflow id |
| [**GetExternalStorageLocation**](WorkflowResourceApi.md#getexternalstoragelocation) | **GET** /api/workflow/external-storage-location | Get the uri and path of the external storage where the workflow payload is to be stored |
| [**GetExternalStorageLocation1**](WorkflowResourceApi.md#getexternalstoragelocation1) | **GET** /api/workflow/externalstoragelocation | Get the uri and path of the external storage where the workflow payload is to be stored |
| [**GetRunningWorkflow**](WorkflowResourceApi.md#getrunningworkflow) | **GET** /api/workflow/running/{name} | Retrieve all the running workflows |
| [**GetWorkflows**](WorkflowResourceApi.md#getworkflows) | **POST** /api/workflow/{name}/correlated | Lists workflows for the given correlation id list |
| [**GetWorkflows1**](WorkflowResourceApi.md#getworkflows1) | **GET** /api/workflow/{name}/correlated/{correlationId} | Lists workflows for the given correlation id |
| [**PauseWorkflow**](WorkflowResourceApi.md#pauseworkflow) | **PUT** /api/workflow/{workflowId}/pause | Pauses the workflow |
| [**Rerun**](WorkflowResourceApi.md#rerun) | **POST** /api/workflow/{workflowId}/rerun | Reruns the workflow from a specific task |
| [**ResetWorkflow**](WorkflowResourceApi.md#resetworkflow) | **POST** /api/workflow/{workflowId}/resetcallbacks | Resets callback times of all non-terminal CUSTOM tasks to 0 |
| [**Restart**](WorkflowResourceApi.md#restart) | **POST** /api/workflow/{workflowId}/restart | Restarts a completed workflow |
| [**ResumeWorkflow**](WorkflowResourceApi.md#resumeworkflow) | **PUT** /api/workflow/{workflowId}/resume | Resumes the workflow |
| [**Retry**](WorkflowResourceApi.md#retry) | **POST** /api/workflow/{workflowId}/retry | Retries the last failed task |
| [**Search**](WorkflowResourceApi.md#search) | **GET** /api/workflow/search | Search for workflows based on payload and other parameters |
| [**SearchV2**](WorkflowResourceApi.md#searchv2) | **GET** /api/workflow/search-v2 | Search for workflows based on payload and other parameters |
| [**SearchWorkflowsByTasks**](WorkflowResourceApi.md#searchworkflowsbytasks) | **GET** /api/workflow/search-by-tasks | Search for workflows based on task parameters |
| [**SearchWorkflowsByTasksV2**](WorkflowResourceApi.md#searchworkflowsbytasksv2) | **GET** /api/workflow/search-by-tasks-v2 | Search for workflows based on task parameters |
| [**SkipTaskFromWorkflow**](WorkflowResourceApi.md#skiptaskfromworkflow) | **PUT** /api/workflow/{workflowId}/skiptask/{taskReferenceName} | Skips a given task from a current running workflow |
| [**StartWorkflow**](WorkflowResourceApi.md#startworkflow) | **POST** /api/workflow | Start a new workflow with StartWorkflowRequest, which allows task to be executed in a domain |
| [**StartWorkflow1**](WorkflowResourceApi.md#startworkflow1) | **POST** /api/workflow/{name} | Start a new workflow. Returns the ID of the workflow instance that can be later used for tracking |
| [**Terminate1**](WorkflowResourceApi.md#terminate1) | **DELETE** /api/workflow/{workflowId} | Terminate workflow execution |
| [**TestWorkflow**](WorkflowResourceApi.md#testworkflow) | **POST** /api/workflow/test | Test workflow execution using mock data |

<a id="decide"></a>
# **Decide**
> void Decide (string workflowId)

Starts the decision task for a workflow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class DecideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var workflowId = "workflowId_example";  // string | 

            try
            {
                // Starts the decision task for a workflow
                apiInstance.Decide(workflowId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.Decide: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecideWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Starts the decision task for a workflow
    apiInstance.DecideWithHttpInfo(workflowId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.DecideWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="delete"></a>
# **Delete**
> void Delete (string workflowId, bool? archiveWorkflow = null)

Removes the workflow from the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var workflowId = "workflowId_example";  // string | 
            var archiveWorkflow = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Removes the workflow from the system
                apiInstance.Delete(workflowId, archiveWorkflow);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.Delete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes the workflow from the system
    apiInstance.DeleteWithHttpInfo(workflowId, archiveWorkflow);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |
| **archiveWorkflow** | **bool?** |  | [optional] [default to true] |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getexecutionstatus"></a>
# **GetExecutionStatus**
> Workflow GetExecutionStatus (string workflowId, bool? includeTasks = null)

Gets the workflow by workflow id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetExecutionStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var workflowId = "workflowId_example";  // string | 
            var includeTasks = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Gets the workflow by workflow id
                Workflow result = apiInstance.GetExecutionStatus(workflowId, includeTasks);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.GetExecutionStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExecutionStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the workflow by workflow id
    ApiResponse<Workflow> response = apiInstance.GetExecutionStatusWithHttpInfo(workflowId, includeTasks);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.GetExecutionStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |
| **includeTasks** | **bool?** |  | [optional] [default to true] |

### Return type

[**Workflow**](Workflow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getexternalstoragelocation"></a>
# **GetExternalStorageLocation**
> ExternalStorageLocation GetExternalStorageLocation (string path, string operation, string payloadType)

Get the uri and path of the external storage where the workflow payload is to be stored

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetExternalStorageLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var path = "path_example";  // string | 
            var operation = "operation_example";  // string | 
            var payloadType = "payloadType_example";  // string | 

            try
            {
                // Get the uri and path of the external storage where the workflow payload is to be stored
                ExternalStorageLocation result = apiInstance.GetExternalStorageLocation(path, operation, payloadType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.GetExternalStorageLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExternalStorageLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the uri and path of the external storage where the workflow payload is to be stored
    ApiResponse<ExternalStorageLocation> response = apiInstance.GetExternalStorageLocationWithHttpInfo(path, operation, payloadType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.GetExternalStorageLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** |  |  |
| **operation** | **string** |  |  |
| **payloadType** | **string** |  |  |

### Return type

[**ExternalStorageLocation**](ExternalStorageLocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getexternalstoragelocation1"></a>
# **GetExternalStorageLocation1**
> ExternalStorageLocation GetExternalStorageLocation1 (string path, string operation, string payloadType)

Get the uri and path of the external storage where the workflow payload is to be stored

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetExternalStorageLocation1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var path = "path_example";  // string | 
            var operation = "operation_example";  // string | 
            var payloadType = "payloadType_example";  // string | 

            try
            {
                // Get the uri and path of the external storage where the workflow payload is to be stored
                ExternalStorageLocation result = apiInstance.GetExternalStorageLocation1(path, operation, payloadType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.GetExternalStorageLocation1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExternalStorageLocation1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the uri and path of the external storage where the workflow payload is to be stored
    ApiResponse<ExternalStorageLocation> response = apiInstance.GetExternalStorageLocation1WithHttpInfo(path, operation, payloadType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.GetExternalStorageLocation1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** |  |  |
| **operation** | **string** |  |  |
| **payloadType** | **string** |  |  |

### Return type

[**ExternalStorageLocation**](ExternalStorageLocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrunningworkflow"></a>
# **GetRunningWorkflow**
> List&lt;string&gt; GetRunningWorkflow (string name, int? varVersion = null, long? startTime = null, long? endTime = null)

Retrieve all the running workflows

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetRunningWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var name = "name_example";  // string | 
            var varVersion = 1;  // int? |  (optional)  (default to 1)
            var startTime = 789L;  // long? |  (optional) 
            var endTime = 789L;  // long? |  (optional) 

            try
            {
                // Retrieve all the running workflows
                List<string> result = apiInstance.GetRunningWorkflow(name, varVersion, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.GetRunningWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunningWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve all the running workflows
    ApiResponse<List<string>> response = apiInstance.GetRunningWorkflowWithHttpInfo(name, varVersion, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.GetRunningWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |
| **varVersion** | **int?** |  | [optional] [default to 1] |
| **startTime** | **long?** |  | [optional]  |
| **endTime** | **long?** |  | [optional]  |

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkflows"></a>
# **GetWorkflows**
> Dictionary&lt;string, List&lt;Workflow&gt;&gt; GetWorkflows (string name, List<string> requestBody, bool? includeClosed = null, bool? includeTasks = null)

Lists workflows for the given correlation id list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetWorkflowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var name = "name_example";  // string | 
            var requestBody = new List<string>(); // List<string> | 
            var includeClosed = false;  // bool? |  (optional)  (default to false)
            var includeTasks = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Lists workflows for the given correlation id list
                Dictionary<string, List<Workflow>> result = apiInstance.GetWorkflows(name, requestBody, includeClosed, includeTasks);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.GetWorkflows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkflowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists workflows for the given correlation id list
    ApiResponse<Dictionary<string, List<Workflow>>> response = apiInstance.GetWorkflowsWithHttpInfo(name, requestBody, includeClosed, includeTasks);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.GetWorkflowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |
| **requestBody** | [**List&lt;string&gt;**](string.md) |  |  |
| **includeClosed** | **bool?** |  | [optional] [default to false] |
| **includeTasks** | **bool?** |  | [optional] [default to false] |

### Return type

**Dictionary<string, List<Workflow>>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkflows1"></a>
# **GetWorkflows1**
> List&lt;Workflow&gt; GetWorkflows1 (string name, string correlationId, bool? includeClosed = null, bool? includeTasks = null)

Lists workflows for the given correlation id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetWorkflows1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var name = "name_example";  // string | 
            var correlationId = "correlationId_example";  // string | 
            var includeClosed = false;  // bool? |  (optional)  (default to false)
            var includeTasks = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Lists workflows for the given correlation id
                List<Workflow> result = apiInstance.GetWorkflows1(name, correlationId, includeClosed, includeTasks);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.GetWorkflows1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkflows1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists workflows for the given correlation id
    ApiResponse<List<Workflow>> response = apiInstance.GetWorkflows1WithHttpInfo(name, correlationId, includeClosed, includeTasks);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.GetWorkflows1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |
| **correlationId** | **string** |  |  |
| **includeClosed** | **bool?** |  | [optional] [default to false] |
| **includeTasks** | **bool?** |  | [optional] [default to false] |

### Return type

[**List&lt;Workflow&gt;**](Workflow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pauseworkflow"></a>
# **PauseWorkflow**
> void PauseWorkflow (string workflowId)

Pauses the workflow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class PauseWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var workflowId = "workflowId_example";  // string | 

            try
            {
                // Pauses the workflow
                apiInstance.PauseWorkflow(workflowId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.PauseWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PauseWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pauses the workflow
    apiInstance.PauseWorkflowWithHttpInfo(workflowId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.PauseWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rerun"></a>
# **Rerun**
> string Rerun (string workflowId, RerunWorkflowRequest rerunWorkflowRequest)

Reruns the workflow from a specific task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class RerunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var workflowId = "workflowId_example";  // string | 
            var rerunWorkflowRequest = new RerunWorkflowRequest(); // RerunWorkflowRequest | 

            try
            {
                // Reruns the workflow from a specific task
                string result = apiInstance.Rerun(workflowId, rerunWorkflowRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.Rerun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RerunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reruns the workflow from a specific task
    ApiResponse<string> response = apiInstance.RerunWithHttpInfo(workflowId, rerunWorkflowRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.RerunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |
| **rerunWorkflowRequest** | [**RerunWorkflowRequest**](RerunWorkflowRequest.md) |  |  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resetworkflow"></a>
# **ResetWorkflow**
> void ResetWorkflow (string workflowId)

Resets callback times of all non-terminal CUSTOM tasks to 0

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class ResetWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var workflowId = "workflowId_example";  // string | 

            try
            {
                // Resets callback times of all non-terminal CUSTOM tasks to 0
                apiInstance.ResetWorkflow(workflowId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.ResetWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resets callback times of all non-terminal CUSTOM tasks to 0
    apiInstance.ResetWorkflowWithHttpInfo(workflowId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.ResetWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="restart"></a>
# **Restart**
> void Restart (string workflowId, bool? useLatestDefinitions = null)

Restarts a completed workflow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class RestartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var workflowId = "workflowId_example";  // string | 
            var useLatestDefinitions = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Restarts a completed workflow
                apiInstance.Restart(workflowId, useLatestDefinitions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.Restart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RestartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restarts a completed workflow
    apiInstance.RestartWithHttpInfo(workflowId, useLatestDefinitions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.RestartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |
| **useLatestDefinitions** | **bool?** |  | [optional] [default to false] |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resumeworkflow"></a>
# **ResumeWorkflow**
> void ResumeWorkflow (string workflowId)

Resumes the workflow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class ResumeWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var workflowId = "workflowId_example";  // string | 

            try
            {
                // Resumes the workflow
                apiInstance.ResumeWorkflow(workflowId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.ResumeWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResumeWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resumes the workflow
    apiInstance.ResumeWorkflowWithHttpInfo(workflowId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.ResumeWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retry"></a>
# **Retry**
> void Retry (string workflowId, bool? resumeSubworkflowTasks = null)

Retries the last failed task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class RetryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var workflowId = "workflowId_example";  // string | 
            var resumeSubworkflowTasks = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Retries the last failed task
                apiInstance.Retry(workflowId, resumeSubworkflowTasks);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.Retry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retries the last failed task
    apiInstance.RetryWithHttpInfo(workflowId, resumeSubworkflowTasks);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.RetryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |
| **resumeSubworkflowTasks** | **bool?** |  | [optional] [default to false] |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="search"></a>
# **Search**
> SearchResultWorkflowSummary Search (int? start = null, int? size = null, string? sort = null, string? freeText = null, string? query = null)

Search for workflows based on payload and other parameters

use sort options as sort=<field>:ASC|DESC e.g. sort=name&sort=workflowId:DESC. If order is not specified, defaults to ASC.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class SearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var start = 0;  // int? |  (optional)  (default to 0)
            var size = 100;  // int? |  (optional)  (default to 100)
            var sort = "sort_example";  // string? |  (optional) 
            var freeText = "\"*\"";  // string? |  (optional)  (default to "*")
            var query = "query_example";  // string? |  (optional) 

            try
            {
                // Search for workflows based on payload and other parameters
                SearchResultWorkflowSummary result = apiInstance.Search(start, size, sort, freeText, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.Search: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for workflows based on payload and other parameters
    ApiResponse<SearchResultWorkflowSummary> response = apiInstance.SearchWithHttpInfo(start, size, sort, freeText, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.SearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** |  | [optional] [default to 0] |
| **size** | **int?** |  | [optional] [default to 100] |
| **sort** | **string?** |  | [optional]  |
| **freeText** | **string?** |  | [optional] [default to &quot;*&quot;] |
| **query** | **string?** |  | [optional]  |

### Return type

[**SearchResultWorkflowSummary**](SearchResultWorkflowSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchv2"></a>
# **SearchV2**
> SearchResultWorkflow SearchV2 (int? start = null, int? size = null, string? sort = null, string? freeText = null, string? query = null)

Search for workflows based on payload and other parameters

use sort options as sort=<field>:ASC|DESC e.g. sort=name&sort=workflowId:DESC. If order is not specified, defaults to ASC.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class SearchV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var start = 0;  // int? |  (optional)  (default to 0)
            var size = 100;  // int? |  (optional)  (default to 100)
            var sort = "sort_example";  // string? |  (optional) 
            var freeText = "\"*\"";  // string? |  (optional)  (default to "*")
            var query = "query_example";  // string? |  (optional) 

            try
            {
                // Search for workflows based on payload and other parameters
                SearchResultWorkflow result = apiInstance.SearchV2(start, size, sort, freeText, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.SearchV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for workflows based on payload and other parameters
    ApiResponse<SearchResultWorkflow> response = apiInstance.SearchV2WithHttpInfo(start, size, sort, freeText, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.SearchV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** |  | [optional] [default to 0] |
| **size** | **int?** |  | [optional] [default to 100] |
| **sort** | **string?** |  | [optional]  |
| **freeText** | **string?** |  | [optional] [default to &quot;*&quot;] |
| **query** | **string?** |  | [optional]  |

### Return type

[**SearchResultWorkflow**](SearchResultWorkflow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchworkflowsbytasks"></a>
# **SearchWorkflowsByTasks**
> SearchResultWorkflowSummary SearchWorkflowsByTasks (int? start = null, int? size = null, string? sort = null, string? freeText = null, string? query = null)

Search for workflows based on task parameters

use sort options as sort=<field>:ASC|DESC e.g. sort=name&sort=workflowId:DESC. If order is not specified, defaults to ASC

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class SearchWorkflowsByTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var start = 0;  // int? |  (optional)  (default to 0)
            var size = 100;  // int? |  (optional)  (default to 100)
            var sort = "sort_example";  // string? |  (optional) 
            var freeText = "\"*\"";  // string? |  (optional)  (default to "*")
            var query = "query_example";  // string? |  (optional) 

            try
            {
                // Search for workflows based on task parameters
                SearchResultWorkflowSummary result = apiInstance.SearchWorkflowsByTasks(start, size, sort, freeText, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.SearchWorkflowsByTasks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchWorkflowsByTasksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for workflows based on task parameters
    ApiResponse<SearchResultWorkflowSummary> response = apiInstance.SearchWorkflowsByTasksWithHttpInfo(start, size, sort, freeText, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.SearchWorkflowsByTasksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** |  | [optional] [default to 0] |
| **size** | **int?** |  | [optional] [default to 100] |
| **sort** | **string?** |  | [optional]  |
| **freeText** | **string?** |  | [optional] [default to &quot;*&quot;] |
| **query** | **string?** |  | [optional]  |

### Return type

[**SearchResultWorkflowSummary**](SearchResultWorkflowSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchworkflowsbytasksv2"></a>
# **SearchWorkflowsByTasksV2**
> SearchResultWorkflow SearchWorkflowsByTasksV2 (int? start = null, int? size = null, string? sort = null, string? freeText = null, string? query = null)

Search for workflows based on task parameters

use sort options as sort=<field>:ASC|DESC e.g. sort=name&sort=workflowId:DESC. If order is not specified, defaults to ASC

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class SearchWorkflowsByTasksV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var start = 0;  // int? |  (optional)  (default to 0)
            var size = 100;  // int? |  (optional)  (default to 100)
            var sort = "sort_example";  // string? |  (optional) 
            var freeText = "\"*\"";  // string? |  (optional)  (default to "*")
            var query = "query_example";  // string? |  (optional) 

            try
            {
                // Search for workflows based on task parameters
                SearchResultWorkflow result = apiInstance.SearchWorkflowsByTasksV2(start, size, sort, freeText, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.SearchWorkflowsByTasksV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchWorkflowsByTasksV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for workflows based on task parameters
    ApiResponse<SearchResultWorkflow> response = apiInstance.SearchWorkflowsByTasksV2WithHttpInfo(start, size, sort, freeText, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.SearchWorkflowsByTasksV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** |  | [optional] [default to 0] |
| **size** | **int?** |  | [optional] [default to 100] |
| **sort** | **string?** |  | [optional]  |
| **freeText** | **string?** |  | [optional] [default to &quot;*&quot;] |
| **query** | **string?** |  | [optional]  |

### Return type

[**SearchResultWorkflow**](SearchResultWorkflow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="skiptaskfromworkflow"></a>
# **SkipTaskFromWorkflow**
> void SkipTaskFromWorkflow (string workflowId, string taskReferenceName, SkipTaskRequest skipTaskRequest)

Skips a given task from a current running workflow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class SkipTaskFromWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var workflowId = "workflowId_example";  // string | 
            var taskReferenceName = "taskReferenceName_example";  // string | 
            var skipTaskRequest = new SkipTaskRequest(); // SkipTaskRequest | 

            try
            {
                // Skips a given task from a current running workflow
                apiInstance.SkipTaskFromWorkflow(workflowId, taskReferenceName, skipTaskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.SkipTaskFromWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SkipTaskFromWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Skips a given task from a current running workflow
    apiInstance.SkipTaskFromWorkflowWithHttpInfo(workflowId, taskReferenceName, skipTaskRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.SkipTaskFromWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |
| **taskReferenceName** | **string** |  |  |
| **skipTaskRequest** | [**SkipTaskRequest**](SkipTaskRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="startworkflow"></a>
# **StartWorkflow**
> string StartWorkflow (StartWorkflowRequest startWorkflowRequest)

Start a new workflow with StartWorkflowRequest, which allows task to be executed in a domain

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class StartWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var startWorkflowRequest = new StartWorkflowRequest(); // StartWorkflowRequest | 

            try
            {
                // Start a new workflow with StartWorkflowRequest, which allows task to be executed in a domain
                string result = apiInstance.StartWorkflow(startWorkflowRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.StartWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start a new workflow with StartWorkflowRequest, which allows task to be executed in a domain
    ApiResponse<string> response = apiInstance.StartWorkflowWithHttpInfo(startWorkflowRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.StartWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startWorkflowRequest** | [**StartWorkflowRequest**](StartWorkflowRequest.md) |  |  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="startworkflow1"></a>
# **StartWorkflow1**
> string StartWorkflow1 (string name, Dictionary<string, Object> requestBody, int? varVersion = null, string? correlationId = null, int? priority = null)

Start a new workflow. Returns the ID of the workflow instance that can be later used for tracking

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class StartWorkflow1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var name = "name_example";  // string | 
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 
            var varVersion = 56;  // int? |  (optional) 
            var correlationId = "correlationId_example";  // string? |  (optional) 
            var priority = 0;  // int? |  (optional)  (default to 0)

            try
            {
                // Start a new workflow. Returns the ID of the workflow instance that can be later used for tracking
                string result = apiInstance.StartWorkflow1(name, requestBody, varVersion, correlationId, priority);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.StartWorkflow1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartWorkflow1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start a new workflow. Returns the ID of the workflow instance that can be later used for tracking
    ApiResponse<string> response = apiInstance.StartWorkflow1WithHttpInfo(name, requestBody, varVersion, correlationId, priority);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.StartWorkflow1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |
| **requestBody** | [**Dictionary&lt;string, Object&gt;**](Object.md) |  |  |
| **varVersion** | **int?** |  | [optional]  |
| **correlationId** | **string?** |  | [optional]  |
| **priority** | **int?** |  | [optional] [default to 0] |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="terminate1"></a>
# **Terminate1**
> void Terminate1 (string workflowId, string? reason = null)

Terminate workflow execution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class Terminate1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var workflowId = "workflowId_example";  // string | 
            var reason = "reason_example";  // string? |  (optional) 

            try
            {
                // Terminate workflow execution
                apiInstance.Terminate1(workflowId, reason);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.Terminate1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Terminate1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Terminate workflow execution
    apiInstance.Terminate1WithHttpInfo(workflowId, reason);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.Terminate1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |
| **reason** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="testworkflow"></a>
# **TestWorkflow**
> Workflow TestWorkflow (WorkflowTestRequest workflowTestRequest)

Test workflow execution using mock data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class TestWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowResourceApi(config);
            var workflowTestRequest = new WorkflowTestRequest(); // WorkflowTestRequest | 

            try
            {
                // Test workflow execution using mock data
                Workflow result = apiInstance.TestWorkflow(workflowTestRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowResourceApi.TestWorkflow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestWorkflowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test workflow execution using mock data
    ApiResponse<Workflow> response = apiInstance.TestWorkflowWithHttpInfo(workflowTestRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowResourceApi.TestWorkflowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowTestRequest** | [**WorkflowTestRequest**](WorkflowTestRequest.md) |  |  |

### Return type

[**Workflow**](Workflow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

