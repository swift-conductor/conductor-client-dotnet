# SwiftConductor.Api.TaskResourceApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**All**](TaskResourceApi.md#all) | **GET** /api/tasks/queue/all | Get the details about each queue |
| [**AllVerbose**](TaskResourceApi.md#allverbose) | **GET** /api/tasks/queue/all/verbose | Get the details about each queue |
| [**BatchPoll**](TaskResourceApi.md#batchpoll) | **GET** /api/tasks/poll/batch/{tasktype} | Batch poll for a task of a certain type |
| [**GetAllPollData**](TaskResourceApi.md#getallpolldata) | **GET** /api/tasks/queue/polldata/all | Get the last poll data for all task types |
| [**GetExternalStorageLocation2**](TaskResourceApi.md#getexternalstoragelocation2) | **GET** /api/tasks/external-storage-location | Get the external uri where the task payload is to be stored |
| [**GetPollData**](TaskResourceApi.md#getpolldata) | **GET** /api/tasks/queue/polldata | Get the last poll data for a given task type |
| [**GetTask**](TaskResourceApi.md#gettask) | **GET** /api/tasks/{taskId} | Get task by Id |
| [**GetTaskLogs**](TaskResourceApi.md#gettasklogs) | **GET** /api/tasks/{taskId}/log | Get Task Execution Logs |
| [**Log**](TaskResourceApi.md#log) | **POST** /api/tasks/{taskId}/log | Log Task Execution Details |
| [**Poll**](TaskResourceApi.md#poll) | **GET** /api/tasks/poll/{tasktype} | Poll for a task of a certain type |
| [**RequeuePendingTask**](TaskResourceApi.md#requeuependingtask) | **POST** /api/tasks/queue/requeue/{taskType} | Requeue pending tasks |
| [**Search1**](TaskResourceApi.md#search1) | **GET** /api/tasks/search | Search for tasks based in payload and other parameters |
| [**SearchV21**](TaskResourceApi.md#searchv21) | **GET** /api/tasks/search-v2 | Search for tasks based in payload and other parameters |
| [**Size**](TaskResourceApi.md#size) | **GET** /api/tasks/queue/sizes | Deprecated. Please use /tasks/queue/size endpoint |
| [**TaskDepth**](TaskResourceApi.md#taskdepth) | **GET** /api/tasks/queue/size | Get queue size for a task type. |
| [**UpdateTask**](TaskResourceApi.md#updatetask) | **POST** /api/tasks | Update a task |

<a id="all"></a>
# **All**
> Dictionary&lt;string, long&gt; All ()

Get the details about each queue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class AllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);

            try
            {
                // Get the details about each queue
                Dictionary<string, long> result = apiInstance.All();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.All: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details about each queue
    ApiResponse<Dictionary<string, long>> response = apiInstance.AllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.AllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Dictionary<string, long>**

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

<a id="allverbose"></a>
# **AllVerbose**
> Dictionary&lt;string, Dictionary&lt;string, Dictionary&lt;string, long&gt;&gt;&gt; AllVerbose ()

Get the details about each queue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class AllVerboseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);

            try
            {
                // Get the details about each queue
                Dictionary<string, Dictionary<string, Dictionary<string, long>>> result = apiInstance.AllVerbose();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.AllVerbose: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AllVerboseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details about each queue
    ApiResponse<Dictionary<string, Dictionary<string, Dictionary<string, long>>>> response = apiInstance.AllVerboseWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.AllVerboseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Dictionary<string, Dictionary<string, Dictionary<string, long>>>**

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

<a id="batchpoll"></a>
# **BatchPoll**
> List&lt;Task&gt; BatchPoll (string tasktype, string? workerid = null, string? domain = null, int? count = null, int? timeout = null)

Batch poll for a task of a certain type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class BatchPollExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var tasktype = "tasktype_example";  // string | 
            var workerid = "workerid_example";  // string? |  (optional) 
            var domain = "domain_example";  // string? |  (optional) 
            var count = 1;  // int? |  (optional)  (default to 1)
            var timeout = 100;  // int? |  (optional)  (default to 100)

            try
            {
                // Batch poll for a task of a certain type
                List<Task> result = apiInstance.BatchPoll(tasktype, workerid, domain, count, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.BatchPoll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchPollWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Batch poll for a task of a certain type
    ApiResponse<List<Task>> response = apiInstance.BatchPollWithHttpInfo(tasktype, workerid, domain, count, timeout);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.BatchPollWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tasktype** | **string** |  |  |
| **workerid** | **string?** |  | [optional]  |
| **domain** | **string?** |  | [optional]  |
| **count** | **int?** |  | [optional] [default to 1] |
| **timeout** | **int?** |  | [optional] [default to 100] |

### Return type

[**List&lt;Task&gt;**](Task.md)

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

<a id="getallpolldata"></a>
# **GetAllPollData**
> List&lt;PollData&gt; GetAllPollData ()

Get the last poll data for all task types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetAllPollDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);

            try
            {
                // Get the last poll data for all task types
                List<PollData> result = apiInstance.GetAllPollData();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.GetAllPollData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllPollDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the last poll data for all task types
    ApiResponse<List<PollData>> response = apiInstance.GetAllPollDataWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.GetAllPollDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;PollData&gt;**](PollData.md)

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

<a id="getexternalstoragelocation2"></a>
# **GetExternalStorageLocation2**
> ExternalStorageLocation GetExternalStorageLocation2 (string path, string operation, string payloadType)

Get the external uri where the task payload is to be stored

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetExternalStorageLocation2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var path = "path_example";  // string | 
            var operation = "operation_example";  // string | 
            var payloadType = "payloadType_example";  // string | 

            try
            {
                // Get the external uri where the task payload is to be stored
                ExternalStorageLocation result = apiInstance.GetExternalStorageLocation2(path, operation, payloadType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.GetExternalStorageLocation2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExternalStorageLocation2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the external uri where the task payload is to be stored
    ApiResponse<ExternalStorageLocation> response = apiInstance.GetExternalStorageLocation2WithHttpInfo(path, operation, payloadType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.GetExternalStorageLocation2WithHttpInfo: " + e.Message);
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

<a id="getpolldata"></a>
# **GetPollData**
> List&lt;PollData&gt; GetPollData (string taskType)

Get the last poll data for a given task type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetPollDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var taskType = "taskType_example";  // string | 

            try
            {
                // Get the last poll data for a given task type
                List<PollData> result = apiInstance.GetPollData(taskType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.GetPollData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPollDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the last poll data for a given task type
    ApiResponse<List<PollData>> response = apiInstance.GetPollDataWithHttpInfo(taskType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.GetPollDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskType** | **string** |  |  |

### Return type

[**List&lt;PollData&gt;**](PollData.md)

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

<a id="gettask"></a>
# **GetTask**
> Task GetTask (string taskId)

Get task by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var taskId = "taskId_example";  // string | 

            try
            {
                // Get task by Id
                Task result = apiInstance.GetTask(taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.GetTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get task by Id
    ApiResponse<Task> response = apiInstance.GetTaskWithHttpInfo(taskId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.GetTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskId** | **string** |  |  |

### Return type

[**Task**](Task.md)

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

<a id="gettasklogs"></a>
# **GetTaskLogs**
> List&lt;TaskExecLog&gt; GetTaskLogs (string taskId)

Get Task Execution Logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetTaskLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var taskId = "taskId_example";  // string | 

            try
            {
                // Get Task Execution Logs
                List<TaskExecLog> result = apiInstance.GetTaskLogs(taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.GetTaskLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaskLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Task Execution Logs
    ApiResponse<List<TaskExecLog>> response = apiInstance.GetTaskLogsWithHttpInfo(taskId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.GetTaskLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskId** | **string** |  |  |

### Return type

[**List&lt;TaskExecLog&gt;**](TaskExecLog.md)

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

<a id="log"></a>
# **Log**
> void Log (string taskId, string body)

Log Task Execution Details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class LogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var taskId = "taskId_example";  // string | 
            var body = "body_example";  // string | 

            try
            {
                // Log Task Execution Details
                apiInstance.Log(taskId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.Log: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log Task Execution Details
    apiInstance.LogWithHttpInfo(taskId, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.LogWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskId** | **string** |  |  |
| **body** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="poll"></a>
# **Poll**
> Task Poll (string tasktype, string? workerid = null, string? domain = null)

Poll for a task of a certain type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class PollExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var tasktype = "tasktype_example";  // string | 
            var workerid = "workerid_example";  // string? |  (optional) 
            var domain = "domain_example";  // string? |  (optional) 

            try
            {
                // Poll for a task of a certain type
                Task result = apiInstance.Poll(tasktype, workerid, domain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.Poll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PollWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Poll for a task of a certain type
    ApiResponse<Task> response = apiInstance.PollWithHttpInfo(tasktype, workerid, domain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.PollWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tasktype** | **string** |  |  |
| **workerid** | **string?** |  | [optional]  |
| **domain** | **string?** |  | [optional]  |

### Return type

[**Task**](Task.md)

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

<a id="requeuependingtask"></a>
# **RequeuePendingTask**
> string RequeuePendingTask (string taskType)

Requeue pending tasks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class RequeuePendingTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var taskType = "taskType_example";  // string | 

            try
            {
                // Requeue pending tasks
                string result = apiInstance.RequeuePendingTask(taskType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.RequeuePendingTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequeuePendingTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requeue pending tasks
    ApiResponse<string> response = apiInstance.RequeuePendingTaskWithHttpInfo(taskType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.RequeuePendingTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskType** | **string** |  |  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="search1"></a>
# **Search1**
> SearchResultTaskSummary Search1 (int? start = null, int? size = null, string? sort = null, string? freeText = null, string? query = null)

Search for tasks based in payload and other parameters

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
    public class Search1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var start = 0;  // int? |  (optional)  (default to 0)
            var size = 100;  // int? |  (optional)  (default to 100)
            var sort = "sort_example";  // string? |  (optional) 
            var freeText = "\"*\"";  // string? |  (optional)  (default to "*")
            var query = "query_example";  // string? |  (optional) 

            try
            {
                // Search for tasks based in payload and other parameters
                SearchResultTaskSummary result = apiInstance.Search1(start, size, sort, freeText, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.Search1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Search1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for tasks based in payload and other parameters
    ApiResponse<SearchResultTaskSummary> response = apiInstance.Search1WithHttpInfo(start, size, sort, freeText, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.Search1WithHttpInfo: " + e.Message);
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

[**SearchResultTaskSummary**](SearchResultTaskSummary.md)

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

<a id="searchv21"></a>
# **SearchV21**
> SearchResultTask SearchV21 (int? start = null, int? size = null, string? sort = null, string? freeText = null, string? query = null)

Search for tasks based in payload and other parameters

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
    public class SearchV21Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var start = 0;  // int? |  (optional)  (default to 0)
            var size = 100;  // int? |  (optional)  (default to 100)
            var sort = "sort_example";  // string? |  (optional) 
            var freeText = "\"*\"";  // string? |  (optional)  (default to "*")
            var query = "query_example";  // string? |  (optional) 

            try
            {
                // Search for tasks based in payload and other parameters
                SearchResultTask result = apiInstance.SearchV21(start, size, sort, freeText, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.SearchV21: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchV21WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for tasks based in payload and other parameters
    ApiResponse<SearchResultTask> response = apiInstance.SearchV21WithHttpInfo(start, size, sort, freeText, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.SearchV21WithHttpInfo: " + e.Message);
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

[**SearchResultTask**](SearchResultTask.md)

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

<a id="size"></a>
# **Size**
> Dictionary&lt;string, int&gt; Size (List<string>? taskType = null)

Deprecated. Please use /tasks/queue/size endpoint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class SizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var taskType = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                // Deprecated. Please use /tasks/queue/size endpoint
                Dictionary<string, int> result = apiInstance.Size(taskType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.Size: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deprecated. Please use /tasks/queue/size endpoint
    ApiResponse<Dictionary<string, int>> response = apiInstance.SizeWithHttpInfo(taskType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.SizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

**Dictionary<string, int>**

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

<a id="taskdepth"></a>
# **TaskDepth**
> int TaskDepth (string taskType, string? domain = null, string? isolationGroupId = null, string? executionNamespace = null)

Get queue size for a task type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class TaskDepthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var taskType = "taskType_example";  // string | 
            var domain = "domain_example";  // string? |  (optional) 
            var isolationGroupId = "isolationGroupId_example";  // string? |  (optional) 
            var executionNamespace = "executionNamespace_example";  // string? |  (optional) 

            try
            {
                // Get queue size for a task type.
                int result = apiInstance.TaskDepth(taskType, domain, isolationGroupId, executionNamespace);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.TaskDepth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TaskDepthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get queue size for a task type.
    ApiResponse<int> response = apiInstance.TaskDepthWithHttpInfo(taskType, domain, isolationGroupId, executionNamespace);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.TaskDepthWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskType** | **string** |  |  |
| **domain** | **string?** |  | [optional]  |
| **isolationGroupId** | **string?** |  | [optional]  |
| **executionNamespace** | **string?** |  | [optional]  |

### Return type

**int**

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

<a id="updatetask"></a>
# **UpdateTask**
> string UpdateTask (TaskResult taskResult)

Update a task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class UpdateTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TaskResourceApi(config);
            var taskResult = new TaskResult(); // TaskResult | 

            try
            {
                // Update a task
                string result = apiInstance.UpdateTask(taskResult);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskResourceApi.UpdateTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a task
    ApiResponse<string> response = apiInstance.UpdateTaskWithHttpInfo(taskResult);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskResourceApi.UpdateTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskResult** | [**TaskResult**](TaskResult.md) |  |  |

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

