# Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound.FulfillmentPreviewItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SellerSku** | **string** | The seller SKU of the item. | 
**Quantity** | **int?** | The item quantity. | 
**SellerFulfillmentOrderItemId** | **string** | A fulfillment order item identifier that the seller created with a call to the &#x60;createFulfillmentOrder&#x60; operation. | 
**EstimatedShippingWeight** | [**Weight**](Weight.md) | The estimated shipping weight of the item quantity for a single item, as identified by &#x60;sellerSku&#x60;, in a shipment. | [optional] 
**ShippingWeightCalculationMethod** | **string** | The method used to calculate the estimated shipping weight. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

