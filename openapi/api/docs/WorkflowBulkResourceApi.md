# SwiftConductor.Api.WorkflowBulkResourceApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PauseWorkflow1**](WorkflowBulkResourceApi.md#pauseworkflow1) | **PUT** /api/workflow/bulk/pause | Pause the list of workflows |
| [**Restart1**](WorkflowBulkResourceApi.md#restart1) | **POST** /api/workflow/bulk/restart | Restart the list of completed workflow |
| [**ResumeWorkflow1**](WorkflowBulkResourceApi.md#resumeworkflow1) | **PUT** /api/workflow/bulk/resume | Resume the list of workflows |
| [**Retry1**](WorkflowBulkResourceApi.md#retry1) | **POST** /api/workflow/bulk/retry | Retry the last failed task for each workflow from the list |
| [**Terminate**](WorkflowBulkResourceApi.md#terminate) | **POST** /api/workflow/bulk/terminate | Terminate workflows execution |

<a id="pauseworkflow1"></a>
# **PauseWorkflow1**
> BulkResponse PauseWorkflow1 (List<string> requestBody)

Pause the list of workflows

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class PauseWorkflow1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowBulkResourceApi(config);
            var requestBody = new List<string>(); // List<string> | 

            try
            {
                // Pause the list of workflows
                BulkResponse result = apiInstance.PauseWorkflow1(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowBulkResourceApi.PauseWorkflow1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PauseWorkflow1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pause the list of workflows
    ApiResponse<BulkResponse> response = apiInstance.PauseWorkflow1WithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowBulkResourceApi.PauseWorkflow1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) |  |  |

### Return type

[**BulkResponse**](BulkResponse.md)

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

<a id="restart1"></a>
# **Restart1**
> BulkResponse Restart1 (List<string> requestBody, bool? useLatestDefinitions = null)

Restart the list of completed workflow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class Restart1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowBulkResourceApi(config);
            var requestBody = new List<string>(); // List<string> | 
            var useLatestDefinitions = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Restart the list of completed workflow
                BulkResponse result = apiInstance.Restart1(requestBody, useLatestDefinitions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowBulkResourceApi.Restart1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Restart1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restart the list of completed workflow
    ApiResponse<BulkResponse> response = apiInstance.Restart1WithHttpInfo(requestBody, useLatestDefinitions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowBulkResourceApi.Restart1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) |  |  |
| **useLatestDefinitions** | **bool?** |  | [optional] [default to false] |

### Return type

[**BulkResponse**](BulkResponse.md)

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

<a id="resumeworkflow1"></a>
# **ResumeWorkflow1**
> BulkResponse ResumeWorkflow1 (List<string> requestBody)

Resume the list of workflows

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class ResumeWorkflow1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowBulkResourceApi(config);
            var requestBody = new List<string>(); // List<string> | 

            try
            {
                // Resume the list of workflows
                BulkResponse result = apiInstance.ResumeWorkflow1(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowBulkResourceApi.ResumeWorkflow1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResumeWorkflow1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resume the list of workflows
    ApiResponse<BulkResponse> response = apiInstance.ResumeWorkflow1WithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowBulkResourceApi.ResumeWorkflow1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) |  |  |

### Return type

[**BulkResponse**](BulkResponse.md)

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

<a id="retry1"></a>
# **Retry1**
> BulkResponse Retry1 (List<string> requestBody)

Retry the last failed task for each workflow from the list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class Retry1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowBulkResourceApi(config);
            var requestBody = new List<string>(); // List<string> | 

            try
            {
                // Retry the last failed task for each workflow from the list
                BulkResponse result = apiInstance.Retry1(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowBulkResourceApi.Retry1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Retry1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retry the last failed task for each workflow from the list
    ApiResponse<BulkResponse> response = apiInstance.Retry1WithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowBulkResourceApi.Retry1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) |  |  |

### Return type

[**BulkResponse**](BulkResponse.md)

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

<a id="terminate"></a>
# **Terminate**
> BulkResponse Terminate (List<string> requestBody, string? reason = null)

Terminate workflows execution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class TerminateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new WorkflowBulkResourceApi(config);
            var requestBody = new List<string>(); // List<string> | 
            var reason = "reason_example";  // string? |  (optional) 

            try
            {
                // Terminate workflows execution
                BulkResponse result = apiInstance.Terminate(requestBody, reason);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkflowBulkResourceApi.Terminate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TerminateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Terminate workflows execution
    ApiResponse<BulkResponse> response = apiInstance.TerminateWithHttpInfo(requestBody, reason);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkflowBulkResourceApi.TerminateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) |  |  |
| **reason** | **string?** |  | [optional]  |

### Return type

[**BulkResponse**](BulkResponse.md)

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

