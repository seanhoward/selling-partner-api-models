# Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment.ShippingServiceOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeliveryExperience** | **DeliveryExperienceType** | The delivery confirmation level. | 
**DeclaredValue** | [**CurrencyAmount**](CurrencyAmount.md) | The declared value of the shipment. The carrier uses this value to determine the amount to use to insure the shipment. If &#x60;DeclaredValue&#x60; is greater than the carrier&#39;s minimum insurance amount, the seller is charged for the additional insurance, as determined by the carrier. For information about optional insurance coverage, refer to Seller Central Help: [UK](https://sellercentral.amazon.co.uk/gp/help/200204080), [US](https://sellercentral.amazon.com/gp/help/200204080). | [optional] 
**CarrierWillPickUp** | **bool?** | When true, the carrier will pick up the package. Note: Scheduled carrier pickup is available only using Dynamex (US), DPD (UK), and Royal Mail (UK). | 
**CarrierWillPickUpOption** | **CarrierWillPickUpOption** |  | [optional] 
**LabelFormat** | **LabelFormat** | The seller&#39;s preferred label format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

