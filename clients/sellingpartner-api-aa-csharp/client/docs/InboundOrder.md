# Amazon.SellingPartnerAPIAA.Clients.Models.Awd.InboundOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime?** | Date when this order was created. | 
**DestinationDetails** | [**DestinationDetails**](DestinationDetails.md) | Destination details of an inbound order based on the assigned region and DC for the order. | [optional] 
**ExternalReferenceId** | **string** | Reference ID that can be used to correlate the order with partner resources. | [optional] 
**OrderId** | **string** | Inbound order ID. | 
**OrderStatus** | **InboundStatus** | Inbound order status. | 
**OriginAddress** | [**Address**](Address.md) | Origin address from where the inbound order will be shipped. | 
**PackagesToInbound** | [**List&lt;DistributionPackageQuantity&gt;**](DistributionPackageQuantity.md) | List of packages to be inbounded. | 
**Preferences** | [**InboundPreferences**](InboundPreferences.md) |  | [optional] 
**UpdatedAt** | **DateTime?** | Date when this order was last updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

