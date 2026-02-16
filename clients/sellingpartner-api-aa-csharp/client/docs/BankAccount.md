# Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet.BankAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The unique bank account identifier provided by Amazon. To initiate a &#x60;SELF&#x60; transaction with Seller Wallet, you must choose &#x60;BANK_ACCOUNT&#x60; as the payment method type in the [getPaymentMethod](https://developer-docs.amazon.com/sp-api/reference/getpaymentmethods) request. Your Amazon Seller Wallet bank account identifier should match the &#x60;paymentMethodId&#x60; in the response. This field is required. | [optional] 
**AccountHolderName** | **string** | The bank account holder&#39;s name (expected to be an Amazon customer). There is a 50 character limit. | [optional] 
**BankAccountNumberFormat** | **BankAccountNumberFormat** | The format in which the bank account number is provided for &#x60;THIRD_PARTY&#x60; transaction requests. | [optional] 
**BankName** | **string** | The name of the bank. This value is Amazon Seller Wallet for Amazon Seller Wallet accounts. | [optional] 
**BankAccountOwnershipType** | **BankAccountOwnershipType** | Type of ownership of the bank account. This value is &#x60;SELF&#x60; for Amazon Seller Wallet accounts. | 
**RoutingNumber** | **string** | Routing number for automated clearing house transfers for &#x60;THIRD_PARTY&#x60; transaction requests. This value is nine consecutive zeros for Amazon Seller Wallet accounts. | [optional] 
**BankNumberFormat** | **BankNumberFormat** | The bank number format or routing number type for &#x60;THIRD_PARTY&#x60; transaction requests. | [optional] 
**AccountCountryCode** | **string** | The two digit country code, in ISO 3166 format.  | 
**AccountCurrency** | **string** | BankAccount currency code in ISO 4217 format  | 
**BankAccountNumberTail** | **string** | Last 3 digit of the bank account number, for all Amazon Seller Wallet account the value will be three consecutive 0&#39;s  | 
**BankAccountHolderStatus** | **BankAccountHolderStatus** | Bank account holder compliance status  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

