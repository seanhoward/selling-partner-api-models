# Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet.TransferSchedule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransferScheduleId** | **string** | The unique identifier provided by Amazon to the scheduled transfer  | 
**TransactionType** | **TransactionType** | Type of the transfer  | 
**TransactionSourceAccount** | [**TransactionAccount**](TransactionAccount.md) | Source bank account details in the scheduled transfer  | [optional] 
**TransactionDestinationAccount** | [**TransactionAccount**](TransactionAccount.md) | Destination bank account details in the scheduled transfer. Here bankAccountCountryCode is a MANDATORY field  | 
**TransferScheduleStatus** | **TransferScheduleStatus** | Type of the transfer schedule. This information can be modified when updating a transfer schedule.  | 
**TransferScheduleInformation** | [**TransferScheduleInformation**](TransferScheduleInformation.md) | Fields required for the scheduled transfer. This information can be modified when updating a transfer schedule.  | 
**PaymentPreference** | [**PaymentPreference**](PaymentPreference.md) | Payment preference of the scheduled transfer. This information can be modified when updating a transfer schedule.  | [optional] 
**TransferScheduleFailures** | [**List&lt;TransferScheduleFailures&gt;**](TransferScheduleFailures.md) | Collection that holds Transfer Schedules that has been cancelled or failed due to certain reasons.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

