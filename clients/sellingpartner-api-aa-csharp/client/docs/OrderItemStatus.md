# Amazon.SellingPartnerAPIAA.Clients.Models.VendorOrders.OrderItemStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemSequenceNumber** | **string** | Numbering of the item on the purchase order. The first item will be 1, the second 2, and so on. | 
**BuyerProductIdentifier** | **string** | Buyer&#39;s Standard Identification Number (ASIN) of an item. | [optional] 
**VendorProductIdentifier** | **string** | The vendor selected product identification of the item. | [optional] 
**NetCost** | [**Money**](Money.md) | The net cost of an item per each or weight unit. | [optional] 
**ListPrice** | [**Money**](Money.md) | The list price of an item per each or weight unit. | [optional] 
**OrderedQuantity** | [**OrderItemStatusOrderedQuantity**](OrderItemStatusOrderedQuantity.md) |  | [optional] 
**AcknowledgementStatus** | [**OrderItemStatusAcknowledgementStatus**](OrderItemStatusAcknowledgementStatus.md) |  | [optional] 
**ReceivingStatus** | [**OrderItemStatusReceivingStatus**](OrderItemStatusReceivingStatus.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

