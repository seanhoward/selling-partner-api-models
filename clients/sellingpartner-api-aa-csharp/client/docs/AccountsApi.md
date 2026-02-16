# Amazon.SellingPartnerAPIAA.Clients.API.AccountsApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccount**](AccountsApi.md#getaccount) | **GET** /finances/transfers/wallet/2024-03-01/accounts/{accountId} | Find particular Amazon SW account by Amazon account identifier
[**ListAccountBalances**](AccountsApi.md#listaccountbalances) | **GET** /finances/transfers/wallet/2024-03-01/accounts/{accountId}/balance | Find balance in particular Amazon SW account by Amazon account identifier
[**ListAccounts**](AccountsApi.md#listaccounts) | **GET** /finances/transfers/wallet/2024-03-01/accounts | Get all Amazon SW accounts for the seller


<a name="getaccount"></a>
# **GetAccount**
> BankAccount GetAccount (string accountId, string marketplaceId)

Find particular Amazon SW account by Amazon account identifier

Retrieve a Seller Wallet bank account by Amazon account identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet;

namespace Example
{
    public class GetAccountExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountId = amzn1.account.AGUGL2EM3ZHYSRJWH2UCRPIM5JFQ;  // string | ID of the Amazon SW account
            var marketplaceId = A1RKKUPIHCS9HS;  // string | The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                // Find particular Amazon SW account by Amazon account identifier
                BankAccount result = apiInstance.GetAccount(accountId, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccount: " + e.Message );
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

### Return type

[**BankAccount**](BankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccountbalances"></a>
# **ListAccountBalances**
> BalanceListing ListAccountBalances (string accountId, string marketplaceId)

Find balance in particular Amazon SW account by Amazon account identifier

Retrieve the balance in a given Seller Wallet bank account.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet;

namespace Example
{
    public class ListAccountBalancesExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var accountId = amzn1.account.AGUGL2EM3ZHYSRJWH2UCRPIM5JFQ;  // string | ID of the Amazon SW account
            var marketplaceId = A1RKKUPIHCS9HS;  // string | The marketplace for which items are returned. The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                // Find balance in particular Amazon SW account by Amazon account identifier
                BalanceListing result = apiInstance.ListAccountBalances(accountId, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListAccountBalances: " + e.Message );
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

### Return type

[**BalanceListing**](BalanceListing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccounts"></a>
# **ListAccounts**
> BankAccountListing ListAccounts (string marketplaceId)

Get all Amazon SW accounts for the seller

Get Seller Wallet accounts for a seller.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet;

namespace Example
{
    public class ListAccountsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var marketplaceId = A1RKKUPIHCS9HS;  // string | A marketplace identifier. Specifies the marketplace for which items are returned.

            try
            {
                // Get all Amazon SW accounts for the seller
                BankAccountListing result = apiInstance.ListAccounts(marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| A marketplace identifier. Specifies the marketplace for which items are returned. | 

### Return type

[**BankAccountListing**](BankAccountListing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

