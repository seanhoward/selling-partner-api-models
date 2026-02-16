# Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet.TransactionInitiationRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceAccountId** | **string** | The unique identifier of the source Amazon SW bank account from where the money needs to be debited  | 
**DestinationAccountId** | **string** | Optional field to specify the unique identifier of the destination bank account where the money needs to be deposited  | [optional] 
**DestinationTransactionInstrument** | [**TransactionInstrumentDetails**](TransactionInstrumentDetails.md) | Destination bank account details of the transaction request  | 
**TransactionDescription** | **string** | A description of the transaction. | [optional] 
**CustomerPaymentReference** | **string** | If the payment is for VAT (Value-Added-Tax) then enter VAT identification number in this field which will be mandatory. The length constraint is 140 characters and do not allow user to enter any sensitive information other than VAT-ID. | [optional] 
**PayeeContactInformation** | [**PayeeContactInformation**](PayeeContactInformation.md) | The contact information of a payee. | [optional] 
**SourceAmount** | [**Currency**](Currency.md) | The transaction amount in the source account&#39;s currency format. Requests that use a currency other than the source bank account currency fail. | 
**TransferRateDetails** | [**TransferRatePreview**](TransferRatePreview.md) | The fees and foreign exchange rates that apply to the transaction. Transfer Rate Preview is currently optional. This field is required when the third party honors the fees and rates of the Seller Wallet transaction. | [optional] 
**RequestTime** | **DateTime?** | The transaction initiation request time in date-time format  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

