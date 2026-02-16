# Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet.TransactionInstrumentDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankAccount** | [**BankAccount**](BankAccount.md) | Specifies the destination bank account details where the money needs to be deposited  | 
**BankAccountNumber** | **string** | This field would be used to populate the bank account number of the destination payment method. The field is intentionally not included in any other Schemas since Amazon internal systems will never receive it in unencrypted format, so field won&#39;t be part of the request signature  | 
**AccountHolderName** | **string** | The bank account holder&#39;s name (expected to be an Amazon customer).  **Note:** This field is encrypted before Amazon receives it, so should not be used to generate &#x60;destAccountDigitalSignature&#x60;, and should not be included in the request signature. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

