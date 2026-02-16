# Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound.FulfillmentOrderItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SellerSku** | **string** | The seller SKU of the item. | 
**SellerFulfillmentOrderItemId** | **string** | A fulfillment order item identifier submitted with a call to the &#x60;createFulfillmentOrder&#x60; operation. | 
**Quantity** | **int?** |  | 
**GiftMessage** | **string** | A message to the gift recipient, if applicable. | [optional] 
**DisplayableComment** | **string** | Item-specific text that displays in recipient-facing materials such as the outbound shipment packing slip. | [optional] 
**FulfillmentNetworkSku** | **string** | Amazon&#39;s fulfillment network SKU of the item. | [optional] 
**OrderItemDisposition** | **string** | Indicates whether the item is sellable or unsellable. | [optional] 
**CancelledQuantity** | **int?** | The item quantity that was cancelled by the seller. | 
**UnfulfillableQuantity** | **int?** | The item quantity that is unfulfillable. | 
**EstimatedShipDate** | **DateTime?** | The estimated date and time that the item quantity is scheduled to ship from the fulfillment center. Note that this value can change over time. If the shipment that contains the item quantity is cancelled, &#x60;estimatedShipDate&#x60; is not returned. | [optional] 
**EstimatedArrivalDate** | **DateTime?** | The estimated arrival date and time of the item quantity. Note that this value can change over time. If the shipment that contains the item quantity is cancelled, &#x60;estimatedArrivalDate&#x60; is not returned. | [optional] 
**PerUnitPrice** | [**Money**](Money.md) | The amount to be collected from the recipient for this item in a COD (Cash On Delivery) order. | [optional] 
**PerUnitTax** | [**Money**](Money.md) | The tax on the amount to be collected from the recipient for this item in a COD (Cash On Delivery) order. | [optional] 
**PerUnitDeclaredValue** | [**Money**](Money.md) | The monetary value assigned by the seller to this item. This is a required field for India MCF orders. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

