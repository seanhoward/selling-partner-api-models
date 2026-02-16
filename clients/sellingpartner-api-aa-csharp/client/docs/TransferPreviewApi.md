# Amazon.SellingPartnerAPIAA.Clients.API.TransferPreviewApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTransferPreview**](TransferPreviewApi.md#gettransferpreview) | **GET** /finances/transfers/wallet/2024-03-01/transferPreview | Fetch potential fees that could be applied on a transaction on the basis of the source and destination country currency code


<a name="gettransferpreview"></a>
# **GetTransferPreview**
> TransferRatePreview GetTransferPreview (string sourceCountryCode, string sourceCurrencyCode, string destinationCountryCode, string destinationCurrencyCode, decimal? baseAmount, string marketplaceId)

Fetch potential fees that could be applied on a transaction on the basis of the source and destination country currency code

Returns list of potential fees on a transaction based on the source and destination country currency code

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet;

namespace Example
{
    public class GetTransferPreviewExample
    {
        public void main()
        {
            var apiInstance = new TransferPreviewApi();
            var sourceCountryCode = US;  // string | Represents 2 character country code of source transaction account in ISO 3166 standard format.
            var sourceCurrencyCode = USD;  // string | Represents 3 letter currency code in ISO 4217 standard format of the source transaction country.
            var destinationCountryCode = FR;  // string | Represents 2 character country code of destination transaction account in ISO 3166 standard format.
            var destinationCurrencyCode = EUR;  // string | Represents 3 letter currency code in ISO 4217 standard format of the destination transaction country.
            var baseAmount = 1000.0;  // decimal? | Represents the base transaction amount without any markup fees, rates that will be used to get the transfer preview.
            var marketplaceId = A1RKKUPIHCS9HS;  // string | The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                // Fetch potential fees that could be applied on a transaction on the basis of the source and destination country currency code
                TransferRatePreview result = apiInstance.GetTransferPreview(sourceCountryCode, sourceCurrencyCode, destinationCountryCode, destinationCurrencyCode, baseAmount, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferPreviewApi.GetTransferPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sourceCountryCode** | **string**| Represents 2 character country code of source transaction account in ISO 3166 standard format. | 
 **sourceCurrencyCode** | **string**| Represents 3 letter currency code in ISO 4217 standard format of the source transaction country. | 
 **destinationCountryCode** | **string**| Represents 2 character country code of destination transaction account in ISO 3166 standard format. | 
 **destinationCurrencyCode** | **string**| Represents 3 letter currency code in ISO 4217 standard format of the destination transaction country. | 
 **baseAmount** | **decimal?**| Represents the base transaction amount without any markup fees, rates that will be used to get the transfer preview. | 
 **marketplaceId** | **string**| The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 

### Return type

[**TransferRatePreview**](TransferRatePreview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

