# Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound.FulfillmentPreviewShipment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EarliestShipDate** | **DateTime?** | The earliest date that the shipment is expected to be sent from the fulfillment center. Must be in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format. | [optional] 
**LatestShipDate** | **DateTime?** | The latest date that the shipment is expected to be sent from the fulfillment center. Must be in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format. | [optional] 
**EarliestArrivalDate** | **DateTime?** | The earliest date that the shipment is expected to arrive at its destination. | [optional] 
**LatestArrivalDate** | **DateTime?** | The latest date that the shipment is expected to arrive at its destination. Must be in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format. | [optional] 
**ShippingNotes** | **List&lt;string&gt;** | Provides additional insight into the shipment timeline when exact delivery dates are not able to be precomputed. | [optional] 
**FulfillmentPreviewItems** | [**FulfillmentPreviewItemList**](FulfillmentPreviewItemList.md) | Information about the items in the shipment. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

