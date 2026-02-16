# Amazon.SellingPartnerAPIAA.Clients.API.ListingsApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetListingsRestrictions**](ListingsApi.md#getlistingsrestrictions) | **GET** /listings/2021-08-01/restrictions | 


<a name="getlistingsrestrictions"></a>
# **GetListingsRestrictions**
> RestrictionList GetListingsRestrictions (string asin, string sellerId, List<string> marketplaceIds, string conditionType = null, string reasonLocale = null)



Returns listing restrictions for an item in the Amazon Catalog.   **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values then those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ListingsRestrictions;

namespace Example
{
    public class GetListingsRestrictionsExample
    {
        public void main()
        {
            var apiInstance = new ListingsApi();
            var asin = B0000ASIN1;  // string | The Amazon Standard Identification Number (ASIN) of the item.
            var sellerId = sellerId_example;  // string | A selling partner identifier, such as a merchant account.
            var marketplaceIds = new List<string>(); // List<string> | A comma-delimited list of Amazon marketplace identifiers for the request.
            var conditionType = used_very_good;  // string | The condition used to filter restrictions. (optional) 
            var reasonLocale = en_US;  // string | A locale for reason text localization. When not provided, the default language code of the first marketplace is used. Examples: \"en_US\", \"fr_CA\", \"fr_FR\". Localized messages default to \"en_US\" when a localization is not available in the specified locale. (optional) 

            try
            {
                RestrictionList result = apiInstance.GetListingsRestrictions(asin, sellerId, marketplaceIds, conditionType, reasonLocale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListingsApi.GetListingsRestrictions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asin** | **string**| The Amazon Standard Identification Number (ASIN) of the item. | 
 **sellerId** | **string**| A selling partner identifier, such as a merchant account. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A comma-delimited list of Amazon marketplace identifiers for the request. | 
 **conditionType** | **string**| The condition used to filter restrictions. | [optional] 
 **reasonLocale** | **string**| A locale for reason text localization. When not provided, the default language code of the first marketplace is used. Examples: \&quot;en_US\&quot;, \&quot;fr_CA\&quot;, \&quot;fr_FR\&quot;. Localized messages default to \&quot;en_US\&quot; when a localization is not available in the specified locale. | [optional] 

### Return type

[**RestrictionList**](RestrictionList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

