# Amazon.SellingPartnerAPIAA.Clients.API.DefaultApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPaymentMethods**](DefaultApi.md#getpaymentmethods) | **GET** /finances/transfers/2024-06-01/paymentMethods | 
[**InitiatePayout**](DefaultApi.md#initiatepayout) | **POST** /finances/transfers/2024-06-01/payouts | 


<a name="getpaymentmethods"></a>
# **GetPaymentMethods**
> GetPaymentMethodsResponse GetPaymentMethods (string marketplaceId, List<string> paymentMethodTypes = null)



Returns the list of payment methods for the seller, which can be filtered by method type.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | .5 | 30 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Transfers;

namespace Example
{
    public class GetPaymentMethodsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var marketplaceId = ATVPDKIKX0DER;  // string | The identifier of the marketplace from which you want to retrieve payment methods. For the list of possible marketplace identifiers, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var paymentMethodTypes = BANK_ACCOUNT,CARD;  // List<string> | A comma-separated list of the payment method types you want to include in the response. (optional) 

            try
            {
                GetPaymentMethodsResponse result = apiInstance.GetPaymentMethods(marketplaceId, paymentMethodTypes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPaymentMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| The identifier of the marketplace from which you want to retrieve payment methods. For the list of possible marketplace identifiers, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **paymentMethodTypes** | **List&lt;string&gt;**| A comma-separated list of the payment method types you want to include in the response. | [optional] 

### Return type

[**GetPaymentMethodsResponse**](GetPaymentMethodsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initiatepayout"></a>
# **InitiatePayout**
> InitiatePayoutResponse InitiatePayout (InitiatePayoutRequest body)



Initiates an on-demand payout to the seller's default deposit method in Seller Central for the given `marketplaceId` and `accountType`, if eligible. You can only initiate one on-demand payout for each marketplace and account type within a 24-hour period.   **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 0.017 | 2 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Transfers;

namespace Example
{
    public class InitiatePayoutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new InitiatePayoutRequest(); // InitiatePayoutRequest | The request body for the `initiatePayout` operation.

            try
            {
                InitiatePayoutResponse result = apiInstance.InitiatePayout(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.InitiatePayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InitiatePayoutRequest**](InitiatePayoutRequest.md)| The request body for the &#x60;initiatePayout&#x60; operation. | 

### Return type

[**InitiatePayoutResponse**](InitiatePayoutResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

