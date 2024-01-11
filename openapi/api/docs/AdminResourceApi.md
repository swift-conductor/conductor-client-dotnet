# SwiftConductor.Api.AdminResourceApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllConfig**](AdminResourceApi.md#getallconfig) | **GET** /api/admin/config | Get all the configuration parameters |
| [**GetEventQueues**](AdminResourceApi.md#geteventqueues) | **GET** /api/admin/queues | Get registered queues |
| [**RequeueSweep**](AdminResourceApi.md#requeuesweep) | **POST** /api/admin/sweep/requeue/{workflowId} | Queue up all the running workflows for sweep |
| [**VerifyAndRepairWorkflowConsistency**](AdminResourceApi.md#verifyandrepairworkflowconsistency) | **POST** /api/admin/consistency/verifyAndRepair/{workflowId} | Verify and repair workflow consistency |
| [**View**](AdminResourceApi.md#view) | **GET** /api/admin/task/{tasktype} | Get the list of pending tasks for a given task type |

<a id="getallconfig"></a>
# **GetAllConfig**
> Dictionary&lt;string, Object&gt; GetAllConfig ()

Get all the configuration parameters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetAllConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new AdminResourceApi(config);

            try
            {
                // Get all the configuration parameters
                Dictionary<string, Object> result = apiInstance.GetAllConfig();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminResourceApi.GetAllConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all the configuration parameters
    ApiResponse<Dictionary<string, Object>> response = apiInstance.GetAllConfigWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminResourceApi.GetAllConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Dictionary<string, Object>**

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

<a id="geteventqueues"></a>
# **GetEventQueues**
> Dictionary&lt;string, Object&gt; GetEventQueues (bool? verbose = null)

Get registered queues

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetEventQueuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new AdminResourceApi(config);
            var verbose = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Get registered queues
                Dictionary<string, Object> result = apiInstance.GetEventQueues(verbose);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminResourceApi.GetEventQueues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventQueuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get registered queues
    ApiResponse<Dictionary<string, Object>> response = apiInstance.GetEventQueuesWithHttpInfo(verbose);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminResourceApi.GetEventQueuesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **verbose** | **bool?** |  | [optional] [default to false] |

### Return type

**Dictionary<string, Object>**

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

<a id="requeuesweep"></a>
# **RequeueSweep**
> string RequeueSweep (string workflowId)

Queue up all the running workflows for sweep

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class RequeueSweepExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new AdminResourceApi(config);
            var workflowId = "workflowId_example";  // string | 

            try
            {
                // Queue up all the running workflows for sweep
                string result = apiInstance.RequeueSweep(workflowId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminResourceApi.RequeueSweep: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequeueSweepWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Queue up all the running workflows for sweep
    ApiResponse<string> response = apiInstance.RequeueSweepWithHttpInfo(workflowId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminResourceApi.RequeueSweepWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |

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

<a id="verifyandrepairworkflowconsistency"></a>
# **VerifyAndRepairWorkflowConsistency**
> string VerifyAndRepairWorkflowConsistency (string workflowId)

Verify and repair workflow consistency

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class VerifyAndRepairWorkflowConsistencyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new AdminResourceApi(config);
            var workflowId = "workflowId_example";  // string | 

            try
            {
                // Verify and repair workflow consistency
                string result = apiInstance.VerifyAndRepairWorkflowConsistency(workflowId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminResourceApi.VerifyAndRepairWorkflowConsistency: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyAndRepairWorkflowConsistencyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify and repair workflow consistency
    ApiResponse<string> response = apiInstance.VerifyAndRepairWorkflowConsistencyWithHttpInfo(workflowId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminResourceApi.VerifyAndRepairWorkflowConsistencyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |

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

<a id="view"></a>
# **View**
> List&lt;Task&gt; View (string tasktype, int? start = null, int? count = null)

Get the list of pending tasks for a given task type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class ViewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new AdminResourceApi(config);
            var tasktype = "tasktype_example";  // string | 
            var start = 0;  // int? |  (optional)  (default to 0)
            var count = 100;  // int? |  (optional)  (default to 100)

            try
            {
                // Get the list of pending tasks for a given task type
                List<Task> result = apiInstance.View(tasktype, start, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminResourceApi.View: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ViewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of pending tasks for a given task type
    ApiResponse<List<Task>> response = apiInstance.ViewWithHttpInfo(tasktype, start, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminResourceApi.ViewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tasktype** | **string** |  |  |
| **start** | **int?** |  | [optional] [default to 0] |
| **count** | **int?** |  | [optional] [default to 100] |

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

