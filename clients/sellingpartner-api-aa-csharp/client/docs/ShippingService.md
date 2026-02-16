# Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment.ShippingService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShippingServiceName** | **string** | A plain text representation of a carrier&#39;s shipping service. For example, \&quot;UPS Ground\&quot; or \&quot;FedEx Standard Overnight\&quot;.  | 
**CarrierName** | **string** | The name of the carrier. | 
**ShippingServiceId** | **string** |  | 
**ShippingServiceOfferId** | **string** | An Amazon-defined shipping service offer identifier. | 
**ShipDate** | **DateTime?** | The date that the carrier will ship the package. | 
**EarliestEstimatedDeliveryDate** | **DateTime?** | The earliest date by which the shipment will be delivered. | [optional] 
**LatestEstimatedDeliveryDate** | **DateTime?** | The latest date by which the shipment will be delivered. | [optional] 
**Rate** | [**CurrencyAmount**](CurrencyAmount.md) | The amount that the carrier will charge for the shipment. | 
**RateWithAdjustments** | [**CurrencyAmount**](CurrencyAmount.md) | The amount that the carrier will charge for the shipment with adjustments. | 
**AdjustmentItemList** | [**AdjustmentItemList**](AdjustmentItemList.md) | A list of adjustments applied to a shipping service. | [optional] 
**ShippingServiceOptions** | [**ShippingServiceOptions**](ShippingServiceOptions.md) | Extra services offered by the carrier. | 
**AvailableShippingServiceOptions** | [**AvailableShippingServiceOptions**](AvailableShippingServiceOptions.md) |  | [optional] 
**AvailableLabelFormats** | [**LabelFormatList**](LabelFormatList.md) |  | [optional] 
**AvailableFormatOptionsForLabel** | [**AvailableFormatOptionsForLabelList**](AvailableFormatOptionsForLabelList.md) |  | [optional] 
**RequiresAdditionalSellerInputs** | **bool?** | When true, additional seller inputs are required. | 
**Benefits** | [**Benefits**](Benefits.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

