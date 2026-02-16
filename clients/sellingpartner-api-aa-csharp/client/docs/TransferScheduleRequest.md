# Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet.TransferScheduleRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceAccountId** | **string** | The unique identifier of the source Amazon SW bank account from where the money needs to be debited  | 
**SourceCurrencyCode** | **string** | Represents 3 letter currency code in ISO 4217 standard format of the source payment method country  | 
**DestinationAccountId** | **string** | Optional field to specify the unique identifier of the destination bank account where the money needs to be deposited  | 
**DestinationTransactionInstrument** | [**TransactionInstrumentDetails**](TransactionInstrumentDetails.md) | Destination bank account details of the transaction request  | 
**TransactionType** | **TransactionType** | Type of the scheduled transaction  | 
**TransferScheduleInformation** | [**TransferScheduleInformation**](TransferScheduleInformation.md) | Fields required for the scheduled transfer  | 
**PaymentPreference** | [**PaymentPreference**](PaymentPreference.md) | Payment preference of the scheduled transfer  | 
**TransferScheduleStatus** | **TransferScheduleStatus** | Type of the transaction schedule which is mandatory field in request body if a transfer schedule needs to be updated  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

