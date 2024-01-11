# SwiftConductor.Api.HealthCheckResourceApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DoCheck**](HealthCheckResourceApi.md#docheck) | **GET** /health |  |

<a id="docheck"></a>
# **DoCheck**
> HealthCheckStatus DoCheck ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SwiftConductor.Api;
using SwiftConductor.Client;
using SwiftConductor.Model;

namespace Example
{
    public class DoCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new HealthCheckResourceApi(config);

            try
            {
                HealthCheckStatus result = apiInstance.DoCheck();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HealthCheckResourceApi.DoCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DoCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<HealthCheckStatus> response = apiInstance.DoCheckWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HealthCheckResourceApi.DoCheckWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HealthCheckStatus**](HealthCheckStatus.md)

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

