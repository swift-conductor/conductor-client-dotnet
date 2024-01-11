# SwiftConductor.Api.EventResourceApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddEventHandler**](EventResourceApi.md#addeventhandler) | **POST** /api/event | Add a new event handler. |
| [**GetEventHandlers**](EventResourceApi.md#geteventhandlers) | **GET** /api/event | Get all the event handlers |
| [**GetEventHandlersForEvent**](EventResourceApi.md#geteventhandlersforevent) | **GET** /api/event/{event} | Get event handlers for a given event |
| [**RemoveEventHandlerStatus**](EventResourceApi.md#removeeventhandlerstatus) | **DELETE** /api/event/{name} | Remove an event handler |
| [**UpdateEventHandler**](EventResourceApi.md#updateeventhandler) | **PUT** /api/event | Update an existing event handler. |

<a id="addeventhandler"></a>
# **AddEventHandler**
> void AddEventHandler (EventHandler eventHandler)

Add a new event handler.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class AddEventHandlerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EventResourceApi(config);
            var eventHandler = new EventHandler(); // EventHandler | 

            try
            {
                // Add a new event handler.
                apiInstance.AddEventHandler(eventHandler);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventResourceApi.AddEventHandler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddEventHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new event handler.
    apiInstance.AddEventHandlerWithHttpInfo(eventHandler);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventResourceApi.AddEventHandlerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventHandler** | [**EventHandler**](EventHandler.md) |  |  |

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

<a id="geteventhandlers"></a>
# **GetEventHandlers**
> List&lt;EventHandler&gt; GetEventHandlers ()

Get all the event handlers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetEventHandlersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EventResourceApi(config);

            try
            {
                // Get all the event handlers
                List<EventHandler> result = apiInstance.GetEventHandlers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventResourceApi.GetEventHandlers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventHandlersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all the event handlers
    ApiResponse<List<EventHandler>> response = apiInstance.GetEventHandlersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventResourceApi.GetEventHandlersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;EventHandler&gt;**](EventHandler.md)

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

<a id="geteventhandlersforevent"></a>
# **GetEventHandlersForEvent**
> List&lt;EventHandler&gt; GetEventHandlersForEvent (string varEvent, bool? activeOnly = null)

Get event handlers for a given event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class GetEventHandlersForEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EventResourceApi(config);
            var varEvent = "varEvent_example";  // string | 
            var activeOnly = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Get event handlers for a given event
                List<EventHandler> result = apiInstance.GetEventHandlersForEvent(varEvent, activeOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventResourceApi.GetEventHandlersForEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventHandlersForEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get event handlers for a given event
    ApiResponse<List<EventHandler>> response = apiInstance.GetEventHandlersForEventWithHttpInfo(varEvent, activeOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventResourceApi.GetEventHandlersForEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varEvent** | **string** |  |  |
| **activeOnly** | **bool?** |  | [optional] [default to true] |

### Return type

[**List&lt;EventHandler&gt;**](EventHandler.md)

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

<a id="removeeventhandlerstatus"></a>
# **RemoveEventHandlerStatus**
> void RemoveEventHandlerStatus (string name)

Remove an event handler

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class RemoveEventHandlerStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EventResourceApi(config);
            var name = "name_example";  // string | 

            try
            {
                // Remove an event handler
                apiInstance.RemoveEventHandlerStatus(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventResourceApi.RemoveEventHandlerStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveEventHandlerStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove an event handler
    apiInstance.RemoveEventHandlerStatusWithHttpInfo(name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventResourceApi.RemoveEventHandlerStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

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

<a id="updateeventhandler"></a>
# **UpdateEventHandler**
> void UpdateEventHandler (EventHandler eventHandler)

Update an existing event handler.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class UpdateEventHandlerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EventResourceApi(config);
            var eventHandler = new EventHandler(); // EventHandler | 

            try
            {
                // Update an existing event handler.
                apiInstance.UpdateEventHandler(eventHandler);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventResourceApi.UpdateEventHandler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEventHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing event handler.
    apiInstance.UpdateEventHandlerWithHttpInfo(eventHandler);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventResourceApi.UpdateEventHandlerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventHandler** | [**EventHandler**](EventHandler.md) |  |  |

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

