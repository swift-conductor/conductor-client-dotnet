# SwiftConductor.Api.QueueAdminResourceApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Names**](QueueAdminResourceApi.md#names) | **GET** /api/queue/ | Get Queue Names |
| [**Size1**](QueueAdminResourceApi.md#size1) | **GET** /api/queue/size | Get the queue length |
| [**Update1**](QueueAdminResourceApi.md#update1) | **POST** /api/queue/update/{workflowId}/{taskRefName}/{status} | Publish a message in queue to mark a wait task as completed. |
| [**UpdateByTaskId**](QueueAdminResourceApi.md#updatebytaskid) | **POST** /api/queue/update/{workflowId}/task/{taskId}/{status} | Publish a message in queue to mark a wait task (by taskId) as completed. |

<a id="names"></a>
# **Names**
> Dictionary&lt;string, string&gt; Names ()

Get Queue Names

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class NamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new QueueAdminResourceApi(config);

            try
            {
                // Get Queue Names
                Dictionary<string, string> result = apiInstance.Names();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueAdminResourceApi.Names: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NamesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Queue Names
    ApiResponse<Dictionary<string, string>> response = apiInstance.NamesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueAdminResourceApi.NamesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Dictionary<string, string>**

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

<a id="size1"></a>
# **Size1**
> Dictionary&lt;string, long&gt; Size1 ()

Get the queue length

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class Size1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new QueueAdminResourceApi(config);

            try
            {
                // Get the queue length
                Dictionary<string, long> result = apiInstance.Size1();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueAdminResourceApi.Size1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Size1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the queue length
    ApiResponse<Dictionary<string, long>> response = apiInstance.Size1WithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueAdminResourceApi.Size1WithHttpInfo: " + e.Message);
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

<a id="update1"></a>
# **Update1**
> void Update1 (string workflowId, string taskRefName, string status, Dictionary<string, Object> requestBody)

Publish a message in queue to mark a wait task as completed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class Update1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new QueueAdminResourceApi(config);
            var workflowId = "workflowId_example";  // string | 
            var taskRefName = "taskRefName_example";  // string | 
            var status = "IN_PROGRESS";  // string | 
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 

            try
            {
                // Publish a message in queue to mark a wait task as completed.
                apiInstance.Update1(workflowId, taskRefName, status, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueAdminResourceApi.Update1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Update1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Publish a message in queue to mark a wait task as completed.
    apiInstance.Update1WithHttpInfo(workflowId, taskRefName, status, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueAdminResourceApi.Update1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |
| **taskRefName** | **string** |  |  |
| **status** | **string** |  |  |
| **requestBody** | [**Dictionary&lt;string, Object&gt;**](Object.md) |  |  |

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

<a id="updatebytaskid"></a>
# **UpdateByTaskId**
> void UpdateByTaskId (string workflowId, string taskId, string status, Dictionary<string, Object> requestBody)

Publish a message in queue to mark a wait task (by taskId) as completed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class UpdateByTaskIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new QueueAdminResourceApi(config);
            var workflowId = "workflowId_example";  // string | 
            var taskId = "taskId_example";  // string | 
            var status = "IN_PROGRESS";  // string | 
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 

            try
            {
                // Publish a message in queue to mark a wait task (by taskId) as completed.
                apiInstance.UpdateByTaskId(workflowId, taskId, status, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueueAdminResourceApi.UpdateByTaskId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateByTaskIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Publish a message in queue to mark a wait task (by taskId) as completed.
    apiInstance.UpdateByTaskIdWithHttpInfo(workflowId, taskId, status, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueueAdminResourceApi.UpdateByTaskIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** |  |  |
| **taskId** | **string** |  |  |
| **status** | **string** |  |  |
| **requestBody** | [**Dictionary&lt;string, Object&gt;**](Object.md) |  |  |

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

