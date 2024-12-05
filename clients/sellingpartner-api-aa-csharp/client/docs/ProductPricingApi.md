# Amazon.SellingPartnerAPIAA.Clients.API.ProductPricingApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCompetitiveSummary**](ProductPricingApi.md#getcompetitivesummary) | **POST** /batches/products/pricing/2022-05-01/items/competitiveSummary | 
[**GetFeaturedOfferExpectedPriceBatch**](ProductPricingApi.md#getfeaturedofferexpectedpricebatch) | **POST** /batches/products/pricing/2022-05-01/offer/featuredOfferExpectedPrice | 


<a name="getcompetitivesummary"></a>
# **GetCompetitiveSummary**
> CompetitiveSummaryBatchResponse GetCompetitiveSummary (CompetitiveSummaryBatchRequest requests)



Returns the competitive summary response, including featured buying options for the ASIN and `marketplaceId` combination.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 0.033 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that are applied to the requested operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may receive higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api) in the Selling Partner API.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Pricing;

namespace Example
{
    public class GetCompetitiveSummaryExample
    {
        public void main()
        {
            var apiInstance = new ProductPricingApi();
            var requests = new CompetitiveSummaryBatchRequest(); // CompetitiveSummaryBatchRequest | The batch of `getCompetitiveSummary` requests.

            try
            {
                CompetitiveSummaryBatchResponse result = apiInstance.GetCompetitiveSummary(requests);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductPricingApi.GetCompetitiveSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requests** | [**CompetitiveSummaryBatchRequest**](CompetitiveSummaryBatchRequest.md)| The batch of &#x60;getCompetitiveSummary&#x60; requests. | 

### Return type

[**CompetitiveSummaryBatchResponse**](CompetitiveSummaryBatchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeaturedofferexpectedpricebatch"></a>
# **GetFeaturedOfferExpectedPriceBatch**
> GetFeaturedOfferExpectedPriceBatchResponse GetFeaturedOfferExpectedPriceBatch (GetFeaturedOfferExpectedPriceBatchRequest getFeaturedOfferExpectedPriceBatchRequestBody)



Returns the set of responses that correspond to the batched list of up to 40 requests defined in the request body. The response for each successful (HTTP status code 200) request in the set includes the computed listing price at or below which a seller can expect to become the featured offer (before applicable promotions). This is called the featured offer expected price (FOEP). Featured offer is not guaranteed because competing offers might change. Other offers might be featured based on factors such as fulfillment capabilities to a specific customer. The response to an unsuccessful request includes the available error text.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 0.033 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that are applied to the requested operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may receive higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api) in the Selling Partner API.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Pricing;

namespace Example
{
    public class GetFeaturedOfferExpectedPriceBatchExample
    {
        public void main()
        {
            var apiInstance = new ProductPricingApi();
            var getFeaturedOfferExpectedPriceBatchRequestBody = new GetFeaturedOfferExpectedPriceBatchRequest(); // GetFeaturedOfferExpectedPriceBatchRequest | The batch of `getFeaturedOfferExpectedPrice` requests.

            try
            {
                GetFeaturedOfferExpectedPriceBatchResponse result = apiInstance.GetFeaturedOfferExpectedPriceBatch(getFeaturedOfferExpectedPriceBatchRequestBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductPricingApi.GetFeaturedOfferExpectedPriceBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getFeaturedOfferExpectedPriceBatchRequestBody** | [**GetFeaturedOfferExpectedPriceBatchRequest**](GetFeaturedOfferExpectedPriceBatchRequest.md)| The batch of &#x60;getFeaturedOfferExpectedPrice&#x60; requests. | 

### Return type

[**GetFeaturedOfferExpectedPriceBatchResponse**](GetFeaturedOfferExpectedPriceBatchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

