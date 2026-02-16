# Amazon.SellingPartnerAPIAA.Clients.API.TransferScheduleApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTransferSchedule**](TransferScheduleApi.md#createtransferschedule) | **POST** /finances/transfers/wallet/2024-03-01/transferSchedules | Create a transfer schedule request from Amazon SW account to another customer provided account
[**DeleteScheduleTransaction**](TransferScheduleApi.md#deletescheduletransaction) | **DELETE** /finances/transfers/wallet/2024-03-01/transferSchedules/{transferScheduleId} | Delete a transaction request that is scheduled from Amazon Seller Wallet account to another customer-provided account
[**GetTransferSchedule**](TransferScheduleApi.md#gettransferschedule) | **GET** /finances/transfers/wallet/2024-03-01/transferSchedules/{transferScheduleId} | Find particular Amazon Seller Wallet account transfer schedule by Amazon transfer schedule identifier
[**ListTransferSchedules**](TransferScheduleApi.md#listtransferschedules) | **GET** /finances/transfers/wallet/2024-03-01/transferSchedules | The API will return all the transfer schedules for a given Amazon SW account
[**UpdateTransferSchedule**](TransferScheduleApi.md#updatetransferschedule) | **PUT** /finances/transfers/wallet/2024-03-01/transferSchedules | Update a transfer schedule information. Only fields (i.e; transferScheduleInformation, paymentPreference, transferScheduleStatus) in the request body can be updated.


<a name="createtransferschedule"></a>
# **CreateTransferSchedule**
> TransferSchedule CreateTransferSchedule (TransferScheduleRequest body, string destAccountDigitalSignature, string amountDigitalSignature, string marketplaceId)

Create a transfer schedule request from Amazon SW account to another customer provided account

Create a transfer schedule request from a Seller Wallet account to another customer-provided account.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet;

namespace Example
{
    public class CreateTransferScheduleExample
    {
        public void main()
        {
            var apiInstance = new TransferScheduleApi();
            var body = new TransferScheduleRequest(); // TransferScheduleRequest | Defines the actual payload of the request
            var destAccountDigitalSignature = U8AsRXdh5fvjozFIv6vRUal1EHdFHhrCArIgmWbPtW0HuTlN_LPteg8G8tbvF4QmoRekOO84nQxg8j4gs0wEyAktg2Sm80a_FaTswv-U8XUXGHZ1UBagGD9zEPrGBbia_N5gm4fCOW-V3mSieblwBiUyq8frUYL606WtuStHtE3zJgaj9-B1ObhudxxQALuBKjPeksc7-qyrT8lwchdkiaprNwsqpv3aKid7Ux3uwEzxiEedO3QWvv6nCZnNNxK-zz2Zj6tPDE_mgQk5tJv4xRgMxtcTMmr7_ce4A9wqRxQqwBerIHpOIzpZizmXAG56uG8-hJojmPwnsPif7ihMuw;  // string | Digital signature for the destination bank account details.
            var amountDigitalSignature = 1EHdFHhrCArIgmWbPtW0HuTlN_LPteg8G8tbvF4QmoRekOO84nQxg8j4gs0wEyAktg2Sm80a_FaTswv-U8XUXGHZ1UBagGD9zEPrGBbia_N5gm4fCOW-qyrT8lwchdkiaprNwsqpv3aKid7Ux3uwEzxiEedO3QWvv6nCZnNNxK-zz2Zj6tPDE_mgQk5tJv4xRgMxtcTMmr7;  // string | Digital signature for the source currency transaction amount.
            var marketplaceId = A1RKKUPIHCS9HS;  // string | The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                // Create a transfer schedule request from Amazon SW account to another customer provided account
                TransferSchedule result = apiInstance.CreateTransferSchedule(body, destAccountDigitalSignature, amountDigitalSignature, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferScheduleApi.CreateTransferSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransferScheduleRequest**](TransferScheduleRequest.md)| Defines the actual payload of the request | 
 **destAccountDigitalSignature** | **string**| Digital signature for the destination bank account details. | 
 **amountDigitalSignature** | **string**| Digital signature for the source currency transaction amount. | 
 **marketplaceId** | **string**| The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 

### Return type

[**TransferSchedule**](TransferSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletescheduletransaction"></a>
# **DeleteScheduleTransaction**
> DeleteTransferSchedule DeleteScheduleTransaction (string transferScheduleId, string marketplaceId)

Delete a transaction request that is scheduled from Amazon Seller Wallet account to another customer-provided account

Delete a transaction request that is scheduled from Amazon Seller Wallet account to another customer-provided account.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet;

namespace Example
{
    public class DeleteScheduleTransactionExample
    {
        public void main()
        {
            var apiInstance = new TransferScheduleApi();
            var transferScheduleId = amzn1.scheduletransfer.AGUGL2EM3ZHYSRJWH2UCRPIM5JFQ;  // string | A unique reference ID for a scheduled transfer.
            var marketplaceId = A1RKKUPIHCS9HS;  // string | The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                // Delete a transaction request that is scheduled from Amazon Seller Wallet account to another customer-provided account
                DeleteTransferSchedule result = apiInstance.DeleteScheduleTransaction(transferScheduleId, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferScheduleApi.DeleteScheduleTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferScheduleId** | **string**| A unique reference ID for a scheduled transfer. | 
 **marketplaceId** | **string**| The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 

### Return type

[**DeleteTransferSchedule**](DeleteTransferSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransferschedule"></a>
# **GetTransferSchedule**
> TransferSchedule GetTransferSchedule (string transferScheduleId, string marketplaceId)

Find particular Amazon Seller Wallet account transfer schedule by Amazon transfer schedule identifier

Find a particular Amazon Seller Wallet account transfer schedule.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet;

namespace Example
{
    public class GetTransferScheduleExample
    {
        public void main()
        {
            var apiInstance = new TransferScheduleApi();
            var transferScheduleId = amzn1.transferschedule.AKNWCDNVP3FNJDCLK876;  // string | The schedule ID of the Amazon Seller Wallet transfer.
            var marketplaceId = A1RKKUPIHCS9HS;  // string | The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                // Find particular Amazon Seller Wallet account transfer schedule by Amazon transfer schedule identifier
                TransferSchedule result = apiInstance.GetTransferSchedule(transferScheduleId, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferScheduleApi.GetTransferSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transferScheduleId** | **string**| The schedule ID of the Amazon Seller Wallet transfer. | 
 **marketplaceId** | **string**| The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 

### Return type

[**TransferSchedule**](TransferSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtransferschedules"></a>
# **ListTransferSchedules**
> TransferScheduleListing ListTransferSchedules (string accountId, string marketplaceId, string nextPageToken = null)

The API will return all the transfer schedules for a given Amazon SW account

Retrieve transfer schedules of a Seller Wallet bank account.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet;

namespace Example
{
    public class ListTransferSchedulesExample
    {
        public void main()
        {
            var apiInstance = new TransferScheduleApi();
            var accountId = amzn1.account.AGUGL2EM3ZHYSRJWH2UCRPIM5JFQ;  // string | ID of the Amazon SW account
            var marketplaceId = A1RKKUPIHCS9HS;  // string | The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var nextPageToken = Next Page Token;  // string | Pagination token to retrieve a specific page of results. (optional) 

            try
            {
                // The API will return all the transfer schedules for a given Amazon SW account
                TransferScheduleListing result = apiInstance.ListTransferSchedules(accountId, marketplaceId, nextPageToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferScheduleApi.ListTransferSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| ID of the Amazon SW account | 
 **marketplaceId** | **string**| The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **nextPageToken** | **string**| Pagination token to retrieve a specific page of results. | [optional] 

### Return type

[**TransferScheduleListing**](TransferScheduleListing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetransferschedule"></a>
# **UpdateTransferSchedule**
> TransferSchedule UpdateTransferSchedule (TransferSchedule body, string destAccountDigitalSignature, string amountDigitalSignature, string marketplaceId)

Update a transfer schedule information. Only fields (i.e; transferScheduleInformation, paymentPreference, transferScheduleStatus) in the request body can be updated.

Returns a transfer belonging to the updated scheduled transfer request

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet;

namespace Example
{
    public class UpdateTransferScheduleExample
    {
        public void main()
        {
            var apiInstance = new TransferScheduleApi();
            var body = new TransferSchedule(); // TransferSchedule | Defines the actual payload of the scheduled transfer request that is to be updated. 
            var destAccountDigitalSignature = U8AsRXdh5fvjozFIv6vRUal1EHdFHhrCArIgmWbPtW0HuTlN_LPteg8G8tbvF4QmoRekOO84nQxg8j4gs0wEyAktg2Sm80a_FaTswv-U8XUXGHZ1UBagGD9zEPrGBbia_N5gm4fCOW-V3mSieblwBiUyq8frUYL606WtuStHtE3zJgaj9-B1ObhudxxQALuBKjPeksc7-qyrT8lwchdkiaprNwsqpv3aKid7Ux3uwEzxiEedO3QWvv6nCZnNNxK-zz2Zj6tPDE_mgQk5tJv4xRgMxtcTMmr7_ce4A9wqRxQqwBerIHpOIzpZizmXAG56uG8-hJojmPwnsPif7ihMuw;  // string | Digital signature for the destination bank account details.
            var amountDigitalSignature = 1EHdFHhrCArIgmWbPtW0HuTlN_LPteg8G8tbvF4QmoRekOO84nQxg8j4gs0wEyAktg2Sm80a_FaTswv-U8XUXGHZ1UBagGD9zEPrGBbia_N5gm4fCOW-qyrT8lwchdkiaprNwsqpv3aKid7Ux3uwEzxiEedO3QWvv6nCZnNNxK-zz2Zj6tPDE_mgQk5tJv4xRgMxtcTMmr7;  // string | Digital signature for the source currency transaction amount.
            var marketplaceId = A1RKKUPIHCS9HS;  // string | The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                // Update a transfer schedule information. Only fields (i.e; transferScheduleInformation, paymentPreference, transferScheduleStatus) in the request body can be updated.
                TransferSchedule result = apiInstance.UpdateTransferSchedule(body, destAccountDigitalSignature, amountDigitalSignature, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferScheduleApi.UpdateTransferSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransferSchedule**](TransferSchedule.md)| Defines the actual payload of the scheduled transfer request that is to be updated.  | 
 **destAccountDigitalSignature** | **string**| Digital signature for the destination bank account details. | 
 **amountDigitalSignature** | **string**| Digital signature for the source currency transaction amount. | 
 **marketplaceId** | **string**| The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 

### Return type

[**TransferSchedule**](TransferSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

