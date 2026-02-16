# Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound.UpdateFulfillmentOrderRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketplaceId** | **string** | The marketplace the fulfillment order is placed against. | [optional] 
**DisplayableOrderId** | **string** | A fulfillment order identifier that the seller creates. This value displays as the order identifier in recipient-facing materials such as the outbound shipment packing slip. The value of &#x60;DisplayableOrderId&#x60; should match the order identifier that the seller provides to the recipient. The seller can use the &#x60;SellerFulfillmentOrderId&#x60; for this value or they can specify an alternate value if they want the recipient to reference an alternate order identifier. | [optional] 
**DisplayableOrderDate** | **DateTime?** | The date and time of the fulfillment order. Displays as the order date in recipient-facing materials such as the outbound shipment packing slip. | [optional] 
**DisplayableOrderComment** | **string** | Order-specific text that appears in recipient-facing materials such as the outbound shipment packing slip. | [optional] 
**ShippingSpeedCategory** | **ShippingSpeedCategory** |  | [optional] 
**DestinationAddress** | [**Address**](Address.md) | The destination address for the fulfillment order. | [optional] 
**FulfillmentAction** | **FulfillmentAction** |  | [optional] 
**FulfillmentPolicy** | **FulfillmentPolicy** |  | [optional] 
**ShipFromCountryCode** | **string** | The two-character country code for the country from which the fulfillment order ships. Must be in ISO 3166-1 alpha-2 format. | [optional] 
**NotificationEmails** | [**NotificationEmailList**](NotificationEmailList.md) |  | [optional] 
**FeatureConstraints** | [**List&lt;FeatureSettings&gt;**](FeatureSettings.md) | A list of features and their fulfillment policies to apply to the order. | [optional] 
**Items** | [**UpdateFulfillmentOrderItemList**](UpdateFulfillmentOrderItemList.md) | A list of items to include in the fulfillment order preview, including quantity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

