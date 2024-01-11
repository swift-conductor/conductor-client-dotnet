# SwiftConductor.Api.MetadataResourceApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Create**](MetadataResourceApi.md#create) | **POST** /api/metadata/workflow | Create a new workflow definition |
| [**Get**](MetadataResourceApi.md#get) | **GET** /api/metadata/workflow/{name} | Retrieves workflow definition along with blueprint |
| [**GetAll**](MetadataResourceApi.md#getall) | **GET** /api/metadata/workflow | Retrieves all workflow definition along with blueprint |
| [**GetAllWorkflowsWithLatestVersions**](MetadataResourceApi.md#getallworkflowswithlatestversions) | **GET** /api/metadata/workflow/latest-versions | Returns only the latest version of all workflow definitions |
| [**GetTaskDef**](MetadataResourceApi.md#gettaskdef) | **GET** /api/metadata/taskdefs/{tasktype} | Gets the task definition |
| [**GetTaskDefs**](MetadataResourceApi.md#gettaskdefs) | **GET** /api/metadata/taskdefs | Gets all task definition |
| [**GetWorkflowNamesAndVersions**](MetadataResourceApi.md#getworkflownamesandversions) | **GET** /api/metadata/workflow/names-and-versions | Returns workflow names and versions only (no definition bodies) |
| [**RegisterTaskDef**](MetadataResourceApi.md#registertaskdef) | **PUT** /api/metadata/taskdefs | Update an existing task |
| [**RegisterTaskDef1**](MetadataResourceApi.md#registertaskdef1) | **POST** /api/metadata/taskdefs | Create new task definition(s) |
| [**UnregisterTaskDef**](MetadataResourceApi.md#unregistertaskdef) | **DELETE** /api/metadata/taskdefs/{tasktype} | Remove a task definition |
| [**UnregisterWorkflowDef**](MetadataResourceApi.md#unregisterworkflowdef) | **DELETE** /api/metadata/workflow/{name}/{version} | Removes workflow definition. It does not remove workflows associated with the definition. |
| [**Update**](MetadataResourceApi.md#update) | **PUT** /api/metadata/workflow | Create or update workflow definition |
| [**Validate**](MetadataResourceApi.md#validate) | **POST** /api/metadata/workflow/validate | Validates a new workflow definition |

<a id="create"></a>
# **Create**
> void Create (WorkflowDef workflowDef)

Create a new workflow definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);
            var workflowDef = new WorkflowDef(); // WorkflowDef | 

            try
            {
                // Create a new workflow definition
                apiInstance.Create(workflowDef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.Create: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new workflow definition
    apiInstance.CreateWithHttpInfo(workflowDef);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowDef** | [**WorkflowDef**](WorkflowDef.md) |  |  |

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

<a id="get"></a>
# **Get**
> WorkflowDef Get (string name, int? varVersion = null)

Retrieves workflow definition along with blueprint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);
            var name = "name_example";  // string | 
            var varVersion = 56;  // int? |  (optional) 

            try
            {
                // Retrieves workflow definition along with blueprint
                WorkflowDef result = apiInstance.Get(name, varVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves workflow definition along with blueprint
    ApiResponse<WorkflowDef> response = apiInstance.GetWithHttpInfo(name, varVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |
| **varVersion** | **int?** |  | [optional]  |

### Return type

[**WorkflowDef**](WorkflowDef.md)

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

<a id="getall"></a>
# **GetAll**
> List&lt;WorkflowDef&gt; GetAll ()

Retrieves all workflow definition along with blueprint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);

            try
            {
                // Retrieves all workflow definition along with blueprint
                List<WorkflowDef> result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.GetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all workflow definition along with blueprint
    ApiResponse<List<WorkflowDef>> response = apiInstance.GetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.GetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;WorkflowDef&gt;**](WorkflowDef.md)

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

<a id="getallworkflowswithlatestversions"></a>
# **GetAllWorkflowsWithLatestVersions**
> List&lt;WorkflowDef&gt; GetAllWorkflowsWithLatestVersions ()

Returns only the latest version of all workflow definitions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetAllWorkflowsWithLatestVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);

            try
            {
                // Returns only the latest version of all workflow definitions
                List<WorkflowDef> result = apiInstance.GetAllWorkflowsWithLatestVersions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.GetAllWorkflowsWithLatestVersions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllWorkflowsWithLatestVersionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns only the latest version of all workflow definitions
    ApiResponse<List<WorkflowDef>> response = apiInstance.GetAllWorkflowsWithLatestVersionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.GetAllWorkflowsWithLatestVersionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;WorkflowDef&gt;**](WorkflowDef.md)

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

<a id="gettaskdef"></a>
# **GetTaskDef**
> TaskDef GetTaskDef (string tasktype)

Gets the task definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetTaskDefExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);
            var tasktype = "tasktype_example";  // string | 

            try
            {
                // Gets the task definition
                TaskDef result = apiInstance.GetTaskDef(tasktype);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.GetTaskDef: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaskDefWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the task definition
    ApiResponse<TaskDef> response = apiInstance.GetTaskDefWithHttpInfo(tasktype);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.GetTaskDefWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tasktype** | **string** |  |  |

### Return type

[**TaskDef**](TaskDef.md)

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

<a id="gettaskdefs"></a>
# **GetTaskDefs**
> List&lt;TaskDef&gt; GetTaskDefs ()

Gets all task definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetTaskDefsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);

            try
            {
                // Gets all task definition
                List<TaskDef> result = apiInstance.GetTaskDefs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.GetTaskDefs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaskDefsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all task definition
    ApiResponse<List<TaskDef>> response = apiInstance.GetTaskDefsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.GetTaskDefsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;TaskDef&gt;**](TaskDef.md)

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

<a id="getworkflownamesandversions"></a>
# **GetWorkflowNamesAndVersions**
> Dictionary&lt;string, Object&gt; GetWorkflowNamesAndVersions ()

Returns workflow names and versions only (no definition bodies)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetWorkflowNamesAndVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);

            try
            {
                // Returns workflow names and versions only (no definition bodies)
                Dictionary<string, Object> result = apiInstance.GetWorkflowNamesAndVersions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.GetWorkflowNamesAndVersions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkflowNamesAndVersionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns workflow names and versions only (no definition bodies)
    ApiResponse<Dictionary<string, Object>> response = apiInstance.GetWorkflowNamesAndVersionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.GetWorkflowNamesAndVersionsWithHttpInfo: " + e.Message);
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

<a id="registertaskdef"></a>
# **RegisterTaskDef**
> void RegisterTaskDef (TaskDef taskDef)

Update an existing task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class RegisterTaskDefExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);
            var taskDef = new TaskDef(); // TaskDef | 

            try
            {
                // Update an existing task
                apiInstance.RegisterTaskDef(taskDef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.RegisterTaskDef: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterTaskDefWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing task
    apiInstance.RegisterTaskDefWithHttpInfo(taskDef);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.RegisterTaskDefWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskDef** | [**TaskDef**](TaskDef.md) |  |  |

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

<a id="registertaskdef1"></a>
# **RegisterTaskDef1**
> void RegisterTaskDef1 (List<TaskDef> taskDef)

Create new task definition(s)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class RegisterTaskDef1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);
            var taskDef = new List<TaskDef>(); // List<TaskDef> | 

            try
            {
                // Create new task definition(s)
                apiInstance.RegisterTaskDef1(taskDef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.RegisterTaskDef1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterTaskDef1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create new task definition(s)
    apiInstance.RegisterTaskDef1WithHttpInfo(taskDef);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.RegisterTaskDef1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskDef** | [**List&lt;TaskDef&gt;**](TaskDef.md) |  |  |

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

<a id="unregistertaskdef"></a>
# **UnregisterTaskDef**
> void UnregisterTaskDef (string tasktype)

Remove a task definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class UnregisterTaskDefExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);
            var tasktype = "tasktype_example";  // string | 

            try
            {
                // Remove a task definition
                apiInstance.UnregisterTaskDef(tasktype);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.UnregisterTaskDef: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnregisterTaskDefWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a task definition
    apiInstance.UnregisterTaskDefWithHttpInfo(tasktype);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.UnregisterTaskDefWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tasktype** | **string** |  |  |

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

<a id="unregisterworkflowdef"></a>
# **UnregisterWorkflowDef**
> void UnregisterWorkflowDef (string name, int varVersion)

Removes workflow definition. It does not remove workflows associated with the definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class UnregisterWorkflowDefExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);
            var name = "name_example";  // string | 
            var varVersion = 56;  // int | 

            try
            {
                // Removes workflow definition. It does not remove workflows associated with the definition.
                apiInstance.UnregisterWorkflowDef(name, varVersion);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.UnregisterWorkflowDef: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnregisterWorkflowDefWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes workflow definition. It does not remove workflows associated with the definition.
    apiInstance.UnregisterWorkflowDefWithHttpInfo(name, varVersion);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.UnregisterWorkflowDefWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |
| **varVersion** | **int** |  |  |

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

<a id="update"></a>
# **Update**
> BulkResponse Update (List<WorkflowDef> workflowDef)

Create or update workflow definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class UpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);
            var workflowDef = new List<WorkflowDef>(); // List<WorkflowDef> | 

            try
            {
                // Create or update workflow definition
                BulkResponse result = apiInstance.Update(workflowDef);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.Update: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create or update workflow definition
    ApiResponse<BulkResponse> response = apiInstance.UpdateWithHttpInfo(workflowDef);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.UpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowDef** | [**List&lt;WorkflowDef&gt;**](WorkflowDef.md) |  |  |

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

<a id="validate"></a>
# **Validate**
> void Validate (WorkflowDef workflowDef)

Validates a new workflow definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class ValidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new MetadataResourceApi(config);
            var workflowDef = new WorkflowDef(); // WorkflowDef | 

            try
            {
                // Validates a new workflow definition
                apiInstance.Validate(workflowDef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataResourceApi.Validate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validates a new workflow definition
    apiInstance.ValidateWithHttpInfo(workflowDef);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataResourceApi.ValidateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowDef** | [**WorkflowDef**](WorkflowDef.md) |  |  |

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

