# Amazon.SellingPartnerAPIAA.Clients.Models.Awd.DestinationDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DestinationAddress** | [**Address**](Address.md) | Destination address of the AWD facility where the shipment will be shipped to | [optional] 
**DestinationRegion** | **string** | Assigned region where the order will be shipped. This can differ from what was passed as preference. AWD currently supports following region IDs: [us-west, us-east, us-southcentral, us-southeast] | [optional] 
**ShipmentId** | **string** | Unique ID of the confirmed shipment being shipped to the assigned destination. This will be available only after an inbound order is confirmed and can be used to track the shipment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

