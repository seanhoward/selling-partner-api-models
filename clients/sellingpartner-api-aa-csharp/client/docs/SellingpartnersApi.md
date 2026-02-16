# Amazon.SellingPartnerAPIAA.Clients.API.SellingpartnersApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSellingPartnerMetrics**](SellingpartnersApi.md#getsellingpartnermetrics) | **POST** /replenishment/2022-11-07/sellingPartners/metrics/search | 


<a name="getsellingpartnermetrics"></a>
# **GetSellingPartnerMetrics**
> GetSellingPartnerMetricsResponse GetSellingPartnerMetrics (GetSellingPartnerMetricsRequest body = null)



Returns aggregated replenishment program metrics for a selling partner.   **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Replenishment;

namespace Example
{
    public class GetSellingPartnerMetricsExample
    {
        public void main()
        {
            var apiInstance = new SellingpartnersApi();
            var body = new GetSellingPartnerMetricsRequest(); // GetSellingPartnerMetricsRequest | The request body for the `getSellingPartnerMetrics` operation. (optional) 

            try
            {
                GetSellingPartnerMetricsResponse result = apiInstance.GetSellingPartnerMetrics(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SellingpartnersApi.GetSellingPartnerMetrics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetSellingPartnerMetricsRequest**](GetSellingPartnerMetricsRequest.md)| The request body for the &#x60;getSellingPartnerMetrics&#x60; operation. | [optional] 

### Return type

[**GetSellingPartnerMetricsResponse**](GetSellingPartnerMetricsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

