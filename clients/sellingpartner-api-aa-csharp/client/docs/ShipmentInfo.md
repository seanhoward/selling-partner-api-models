# Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments.ShipmentInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShipmentType** | **string** | The type of shipment. | 
**OriginalShipmentInfo** | [**ReplacedShipmentInfo**](ReplacedShipmentInfo.md) | This field contains details of the original shipment if &#x60;shipmentType&#x60; is either &#x60;REPLACEMENT&#x60; or &#x60;EXCHANGE&#x60;. | [optional] 
**NumberOfUnits** | **int?** | Total number of units in the shipment. | 
**Priority** | **Priority** | The priority of the order. | 
**BuyerOrderId** | **string** | The buyer&#39;s order ID. | 
**OrderStatesEligibleForRejection** | **List&lt;string&gt;** | A list of order statuses for which the marketplace allows order rejection (seller cancellation). If the order has a status that does not belong to this list, then seller cancellation is not possible. | [optional] 
**OrderPlacedTimestamp** | **string** | The timestamp of when the order was placed, in UTC | [optional] 
**ProcessingSource** | **string** | The source of the order operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

