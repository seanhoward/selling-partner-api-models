# Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound.FulfillmentPreview
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShippingSpeedCategory** | **ShippingSpeedCategory** |  | 
**ScheduledDeliveryInfo** | [**ScheduledDeliveryInfo**](ScheduledDeliveryInfo.md) |  | [optional] 
**IsFulfillable** | **bool?** | When true, this fulfillment order preview is fulfillable. | 
**IsCODCapable** | **bool?** | When true, this fulfillment order preview is for COD (Cash On Delivery). | 
**EstimatedShippingWeight** | [**Weight**](Weight.md) | Estimated shipping weight for this fulfillment order preview. | [optional] 
**EstimatedFees** | [**FeeList**](FeeList.md) | The estimated fulfillment fees for this fulfillment order preview, if applicable. The fees data will not be available for IN marketplace orders. | [optional] 
**FulfillmentPreviewShipments** | [**FulfillmentPreviewShipmentList**](FulfillmentPreviewShipmentList.md) |  | [optional] 
**UnfulfillablePreviewItems** | [**UnfulfillablePreviewItemList**](UnfulfillablePreviewItemList.md) |  | [optional] 
**OrderUnfulfillableReasons** | [**StringList**](StringList.md) | Error codes associated with the fulfillment order preview that indicate why the order is not fulfillable.  Error code examples:  &#x60;DeliverySLAUnavailable&#x60; &#x60;InvalidDestinationAddress&#x60; | [optional] 
**MarketplaceId** | **string** | The marketplace the fulfillment order is placed against. | 
**FeatureConstraints** | [**List&lt;FeatureSettings&gt;**](FeatureSettings.md) | A list of features and their fulfillment policies to apply to the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

