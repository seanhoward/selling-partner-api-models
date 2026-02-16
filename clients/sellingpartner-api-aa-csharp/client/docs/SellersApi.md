# Amazon.SellingPartnerAPIAA.Clients.API.SellersApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccount**](SellersApi.md#getaccount) | **GET** /sellers/v1/account | 
[**GetMarketplaceParticipations**](SellersApi.md#getmarketplaceparticipations) | **GET** /sellers/v1/marketplaceParticipations | 


<a name="getaccount"></a>
# **GetAccount**
> GetAccountResponse GetAccount ()



Returns information about a seller account and its marketplaces.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 0.016 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Sellers;

namespace Example
{
    public class GetAccountExample
    {
        public void main()
        {
            var apiInstance = new SellersApi();

            try
            {
                GetAccountResponse result = apiInstance.GetAccount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SellersApi.GetAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetAccountResponse**](GetAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketplaceparticipations"></a>
# **GetMarketplaceParticipations**
> GetMarketplaceParticipationsResponse GetMarketplaceParticipations ()



Returns a list of marketplaces where the seller can list items and information about the seller's participation in those marketplaces.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 0.016 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Sellers;

namespace Example
{
    public class GetMarketplaceParticipationsExample
    {
        public void main()
        {
            var apiInstance = new SellersApi();

            try
            {
                GetMarketplaceParticipationsResponse result = apiInstance.GetMarketplaceParticipations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SellersApi.GetMarketplaceParticipations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetMarketplaceParticipationsResponse**](GetMarketplaceParticipationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

