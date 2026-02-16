# Amazon.SellingPartnerAPIAA.Clients.Models.VendorOrders.OrderAcknowledgement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PurchaseOrderNumber** | **string** | The purchase order number. Formatting Notes: 8-character alpha-numeric code. | 
**SellingParty** | [**PartyIdentification**](PartyIdentification.md) | Name, address and tax details of the party receiving a shipment of products. | 
**AcknowledgementDate** | **DateTime?** | The date and time when the purchase order is acknowledged, in ISO-8601 date/time format. | 
**Items** | [**List&lt;OrderAcknowledgementItem&gt;**](OrderAcknowledgementItem.md) | A list of the items being acknowledged with associated details. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

