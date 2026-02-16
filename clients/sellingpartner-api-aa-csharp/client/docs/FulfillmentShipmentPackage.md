# Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound.FulfillmentShipmentPackage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageNumber** | **int?** | Identifies a package in a shipment. | 
**CarrierCode** | **string** | Identifies the carrier who will deliver the shipment to the recipient. | 
**TrackingNumber** | **string** | The tracking number, if provided, can be used to obtain tracking and delivery information. | [optional] 
**AmazonFulfillmentTrackingNumber** | **string** | The Amazon fulfillment tracking number, if provided, can be used to obtain tracking and delivery information. | [optional] 
**EstimatedArrivalDate** | **DateTime?** | The estimated arrival date and time of the package. Must be in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format. | [optional] 
**LockerDetails** | [**LockerDetails**](LockerDetails.md) | The locker details, if provided can be used to access locker delivery box. | [optional] 
**DeliveryInformation** | [**DeliveryInformation**](DeliveryInformation.md) | The delivery information for the package. This information is available after the package is delivered. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

