# Amazon.SellingPartnerAPIAA.Clients.API.TransactionsApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTransaction**](TransactionsApi.md#createtransaction) | **POST** /finances/transfers/wallet/2024-03-01/transactions | Create a transaction request from Amazon SW account to another customer provided account
[**GetTransaction**](TransactionsApi.md#gettransaction) | **GET** /finances/transfers/wallet/2024-03-01/transactions/{transactionId} | Find particular Amazon SW account transaction by Amazon transaction identifier
[**ListAccountTransactions**](TransactionsApi.md#listaccounttransactions) | **GET** /finances/transfers/wallet/2024-03-01/transactions | The API will return all the transactions for a given Amazon SW account sorted by the transaction request date


<a name="createtransaction"></a>
# **CreateTransaction**
> CreateTransactionResponse CreateTransaction (TransactionInitiationRequest body, string destAccountDigitalSignature, string amountDigitalSignature, string marketplaceId)

Create a transaction request from Amazon SW account to another customer provided account

Create a transaction request from a Seller Wallet account to another customer-provided account.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet;

namespace Example
{
    public class CreateTransactionExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var body = new TransactionInitiationRequest(); // TransactionInitiationRequest | Defines the actual payload of the request
            var destAccountDigitalSignature = U8AsRXdh5fvjozFIv6vRUal1EHdFHhrCArIgmWbPtW0HuTlN_LPteg8G8tbvF4QmoRekOO84nQxg8j4gs0wEyAktg2Sm80a_FaTswv-U8XUXGHZ1UBagGD9zEPrGBbia_N5gm4fCOW-V3mSieblwBiUyq8frUYL606WtuStHtE3zJgaj9-B1ObhudxxQALuBKjPeksc7-qyrT8lwchdkiaprNwsqpv3aKid7Ux3uwEzxiEedO3QWvv6nCZnNNxK-zz2Zj6tPDE_mgQk5tJv4xRgMxtcTMmr7_ce4A9wqRxQqwBerIHpOIzpZizmXAG56uG8-hJojmPwnsPif7ihMuw;  // string | Digital signature for the destination bank account details. For more information, refer to [Third-Party Provider Signature Guidance](https://developer-docs.amazon.com/sp-api/docs/tpp-registration-signature-guidance).
            var amountDigitalSignature = 1EHdFHhrCArIgmWbPtW0HuTlN_LPteg8G8tbvF4QmoRekOO84nQxg8j4gs0wEyAktg2Sm80a_FaTswv-U8XUXGHZ1UBagGD9zEPrGBbia_N5gm4fCOW-qyrT8lwchdkiaprNwsqpv3aKid7Ux3uwEzxiEedO3QWvv6nCZnNNxK-zz2Zj6tPDE_mgQk5tJv4xRgMxtcTMmr7;  // string | Digital signature for the source currency transaction amount. Sign in the order of the request definitions. You can omit empty or optional fields. For more information, refer to [Third-Party Provider Signature Guidance](https://developer-docs.amazon.com/sp-api/docs/tpp-registration-signature-guidance).
            var marketplaceId = A1RKKUPIHCS9HS;  // string | The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                // Create a transaction request from Amazon SW account to another customer provided account
                CreateTransactionResponse result = apiInstance.CreateTransaction(body, destAccountDigitalSignature, amountDigitalSignature, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionInitiationRequest**](TransactionInitiationRequest.md)| Defines the actual payload of the request | 
 **destAccountDigitalSignature** | **string**| Digital signature for the destination bank account details. For more information, refer to [Third-Party Provider Signature Guidance](https://developer-docs.amazon.com/sp-api/docs/tpp-registration-signature-guidance). | 
 **amountDigitalSignature** | **string**| Digital signature for the source currency transaction amount. Sign in the order of the request definitions. You can omit empty or optional fields. For more information, refer to [Third-Party Provider Signature Guidance](https://developer-docs.amazon.com/sp-api/docs/tpp-registration-signature-guidance). | 
 **marketplaceId** | **string**| The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 

### Return type

[**CreateTransactionResponse**](CreateTransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransaction"></a>
# **GetTransaction**
> Transaction GetTransaction (string transactionId, string marketplaceId)

Find particular Amazon SW account transaction by Amazon transaction identifier

Returns a transaction

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet;

namespace Example
{
    public class GetTransactionExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var transactionId = amzn1.transaction.AGUGL2EM3ZHYSRJWH2UCRPIM5JFQ;  // string | ID of the Amazon SW transaction
            var marketplaceId = A1RKKUPIHCS9HS;  // string | The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                // Find particular Amazon SW account transaction by Amazon transaction identifier
                Transaction result = apiInstance.GetTransaction(transactionId, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionId** | **string**| ID of the Amazon SW transaction | 
 **marketplaceId** | **string**| The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 

### Return type

[**Transaction**](Transaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccounttransactions"></a>
# **ListAccountTransactions**
> TransactionListing ListAccountTransactions (string accountId, string marketplaceId, string nextPageToken = null)

The API will return all the transactions for a given Amazon SW account sorted by the transaction request date

Retrieve a list of transactions for a given Seller Wallet bank account.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet;

namespace Example
{
    public class ListAccountTransactionsExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var accountId = amzn1.account.AGUGL2EM3ZHYSRJWH2UCRPIM5JFQ;  // string | ID of the Amazon SW account
            var marketplaceId = A1RKKUPIHCS9HS;  // string | The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var nextPageToken = Next Page Token;  // string | Pagination token to retrieve a specific page of results. (optional) 

            try
            {
                // The API will return all the transactions for a given Amazon SW account sorted by the transaction request date
                TransactionListing result = apiInstance.ListAccountTransactions(accountId, marketplaceId, nextPageToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.ListAccountTransactions: " + e.Message );
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

[**TransactionListing**](TransactionListing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

