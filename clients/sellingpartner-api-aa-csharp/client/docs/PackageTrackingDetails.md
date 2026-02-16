# Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound.PackageTrackingDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageNumber** | **int?** | The package identifier. | 
**TrackingNumber** | **string** | The tracking number for the package. | [optional] 
**CustomerTrackingLink** | **string** | Link on swiship.com that allows customers to track the package. | [optional] 
**CarrierCode** | **string** | The name of the carrier. | [optional] 
**CarrierPhoneNumber** | **string** | The phone number of the carrier. | [optional] 
**CarrierURL** | **string** | The URL of the carrier&#39;s website. | [optional] 
**ShipDate** | **DateTime?** | The shipping date for the package. | [optional] 
**EstimatedArrivalDate** | **DateTime?** | The estimated arrival date. | [optional] 
**ShipToAddress** | [**TrackingAddress**](TrackingAddress.md) | The destination city for the package. | [optional] 
**CurrentStatus** | **CurrentStatus** |  | [optional] 
**CurrentStatusDescription** | **string** | Description corresponding to the &#x60;CurrentStatus&#x60; value. | [optional] 
**DeliveryWindow** | [**DateRange**](DateRange.md) | The delivery window for the package. This is available after the package reaches its destination delivery station. | [optional] 
**SignedForBy** | **string** | The name of the person who signed for the package. | [optional] 
**AdditionalLocationInfo** | **AdditionalLocationInfo** |  | [optional] 
**TrackingEvents** | [**TrackingEventList**](TrackingEventList.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

