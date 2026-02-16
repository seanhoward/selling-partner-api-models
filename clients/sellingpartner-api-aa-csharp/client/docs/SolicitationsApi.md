# Amazon.SellingPartnerAPIAA.Clients.API.SolicitationsApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProductReviewAndSellerFeedbackSolicitation**](SolicitationsApi.md#createproductreviewandsellerfeedbacksolicitation) | **POST** /solicitations/v1/orders/{amazonOrderId}/solicitations/productReviewAndSellerFeedback | 
[**GetSolicitationActionsForOrder**](SolicitationsApi.md#getsolicitationactionsfororder) | **GET** /solicitations/v1/orders/{amazonOrderId} | 


<a name="createproductreviewandsellerfeedbacksolicitation"></a>
# **CreateProductReviewAndSellerFeedbackSolicitation**
> CreateProductReviewAndSellerFeedbackSolicitationResponse CreateProductReviewAndSellerFeedbackSolicitation (string amazonOrderId, List<string> marketplaceIds)



Sends a solicitation to a buyer asking for seller feedback and a product review for the specified order. Send only one productReviewAndSellerFeedback or free form proactive message per order.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Solicitations;

namespace Example
{
    public class CreateProductReviewAndSellerFeedbackSolicitationExample
    {
        public void main()
        {
            var apiInstance = new SolicitationsApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This specifies the order for which a solicitation is sent.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This specifies the marketplace in which the order was placed. Only one marketplace can be specified.

            try
            {
                CreateProductReviewAndSellerFeedbackSolicitationResponse result = apiInstance.CreateProductReviewAndSellerFeedbackSolicitation(amazonOrderId, marketplaceIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SolicitationsApi.CreateProductReviewAndSellerFeedbackSolicitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This specifies the order for which a solicitation is sent. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This specifies the marketplace in which the order was placed. Only one marketplace can be specified. | 

### Return type

[**CreateProductReviewAndSellerFeedbackSolicitationResponse**](CreateProductReviewAndSellerFeedbackSolicitationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsolicitationactionsfororder"></a>
# **GetSolicitationActionsForOrder**
> GetSolicitationActionsForOrderResponse GetSolicitationActionsForOrder (string amazonOrderId, List<string> marketplaceIds)



Returns a list of solicitation types that are available for an order that you specify. A solicitation type is represented by an actions object, which contains a path and query parameter(s). You can use the path and parameter(s) to call an operation that sends a solicitation. Currently only the productReviewAndSellerFeedbackSolicitation solicitation type is available.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Solicitations;

namespace Example
{
    public class GetSolicitationActionsForOrderExample
    {
        public void main()
        {
            var apiInstance = new SolicitationsApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This specifies the order for which you want a list of available solicitation types.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This specifies the marketplace in which the order was placed. Only one marketplace can be specified.

            try
            {
                GetSolicitationActionsForOrderResponse result = apiInstance.GetSolicitationActionsForOrder(amazonOrderId, marketplaceIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SolicitationsApi.GetSolicitationActionsForOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This specifies the order for which you want a list of available solicitation types. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This specifies the marketplace in which the order was placed. Only one marketplace can be specified. | 

### Return type

[**GetSolicitationActionsForOrderResponse**](GetSolicitationActionsForOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

