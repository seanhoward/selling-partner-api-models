# Amazon.SellingPartnerAPIAA.Clients.API.ApplicationsApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RotateApplicationClientSecret**](ApplicationsApi.md#rotateapplicationclientsecret) | **POST** /applications/2023-11-30/clientSecret | 


<a name="rotateapplicationclientsecret"></a>
# **RotateApplicationClientSecret**
> void RotateApplicationClientSecret ()



Rotates application client secrets for a developer application. Developers must register a destination queue in the developer console before calling this operation. When this operation is called a new client secret is generated and sent to the developer-registered queue. For more information, refer to [Rotate your application client secret](https://developer-docs.amazon.com/sp-api/v0/docs/application-management-api-v2023-11-30-use-case-guide#tutorial-rotate-your-applications-client-secret).  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 0.0167 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Application;

namespace Example
{
    public class RotateApplicationClientSecretExample
    {
        public void main()
        {
            var apiInstance = new ApplicationsApi();

            try
            {
                apiInstance.RotateApplicationClientSecret();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationsApi.RotateApplicationClientSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

