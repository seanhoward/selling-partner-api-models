# Amazon.SellingPartnerAPIAA.Clients.Models.VendorOrders.OrderStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PurchaseOrderNumber** | **string** | The buyer&#39;s purchase order number for this order. Formatting Notes: 8-character alpha-numeric code. | 
**PurchaseOrderStatus** | **string** | The status of the buyer&#39;s purchase order for this order. | 
**PurchaseOrderDate** | **DateTime?** | The date the purchase order was placed. Must be in ISO-8601 date/time format. | 
**LastUpdatedDate** | **DateTime?** | The date when the purchase order was last updated. Must be in ISO-8601 date/time format. | [optional] 
**SellingParty** | [**PartyIdentification**](PartyIdentification.md) | Name/Address and tax details of the selling party. | 
**ShipToParty** | [**PartyIdentification**](PartyIdentification.md) | Name/Address and tax details of the ship to party. Find a list of fulfillment center addresses for a region on the [Resources page of Amazon Vendor Central](https://vendorcentral.amazon.com/hz/vendor/members/support/help/node/GPZ88XH8HQM97ZV6). | 
**ItemStatus** | [**ItemStatus**](ItemStatus.md) | Detailed order status. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

