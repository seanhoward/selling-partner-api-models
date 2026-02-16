# Amazon.SellingPartnerAPIAA.Clients.API.OffersApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListOfferMetrics**](OffersApi.md#listoffermetrics) | **POST** /replenishment/2022-11-07/offers/metrics/search | 
[**ListOffers**](OffersApi.md#listoffers) | **POST** /replenishment/2022-11-07/offers/search | 


<a name="listoffermetrics"></a>
# **ListOfferMetrics**
> ListOfferMetricsResponse ListOfferMetrics (ListOfferMetricsRequest body = null)



Returns aggregated replenishment program metrics for a selling partner's offers.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Replenishment;

namespace Example
{
    public class ListOfferMetricsExample
    {
        public void main()
        {
            var apiInstance = new OffersApi();
            var body = new ListOfferMetricsRequest(); // ListOfferMetricsRequest | The request body for the `listOfferMetrics` operation. (optional) 

            try
            {
                ListOfferMetricsResponse result = apiInstance.ListOfferMetrics(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.ListOfferMetrics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ListOfferMetricsRequest**](ListOfferMetricsRequest.md)| The request body for the &#x60;listOfferMetrics&#x60; operation. | [optional] 

### Return type

[**ListOfferMetricsResponse**](ListOfferMetricsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listoffers"></a>
# **ListOffers**
> ListOffersResponse ListOffers (ListOffersRequest body = null)



Returns the details of a selling partner's replenishment program offers.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Replenishment;

namespace Example
{
    public class ListOffersExample
    {
        public void main()
        {
            var apiInstance = new OffersApi();
            var body = new ListOffersRequest(); // ListOffersRequest | The request body for the `listOffers` operation. (optional) 

            try
            {
                ListOffersResponse result = apiInstance.ListOffers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.ListOffers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ListOffersRequest**](ListOffersRequest.md)| The request body for the &#x60;listOffers&#x60; operation. | [optional] 

### Return type

[**ListOffersResponse**](ListOffersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

