# Amazon.SellingPartnerAPIAA.Clients.Models.Transfers.PaymentMethodDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountHolderName** | **string** | The name of the account holder who is registered for the payment method. | [optional] 
**PaymentMethodId** | **string** | The payment method identifier. | [optional] 
**Tail** | **string** | The last three or four digits of the payment method. | [optional] 
**ExpiryDate** | [**ExpiryDate**](ExpiryDate.md) | The expiration date of the card used for payment. | [optional] 
**CountryCode** | **string** | The two-letter country code in ISO 3166-1 alpha-2 format. For payment methods in the &#x60;card&#x60; category, the code is for the country where the card was issued. For payment methods in the &#x60;bank account&#x60; category, the code is for the country where the account is located. | [optional] 
**PaymentMethodType** | **PaymentMethodType** | The payment method type. | [optional] 
**AssignmentType** | **AssignmentType** | The payment method assignment type, whether it is assigned as default to the given marketplace or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

