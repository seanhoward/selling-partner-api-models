# Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound.FulfillmentOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SellerFulfillmentOrderId** | **string** | The fulfillment order identifier submitted with the &#x60;createFulfillmentOrder&#x60; operation. | 
**MarketplaceId** | **string** | The identifier for the marketplace the fulfillment order is placed against. | 
**DisplayableOrderId** | **string** | A fulfillment order identifier submitted with the &#x60;createFulfillmentOrder&#x60; operation. Displays as the order identifier in recipient-facing materials such as the packing slip. | 
**DisplayableOrderDate** | **DateTime?** | A date and time submitted with the &#x60;createFulfillmentOrder&#x60; operation. Displays as the order date in recipient-facing materials such as the packing slip. | 
**DisplayableOrderComment** | **string** | A text block submitted with the &#x60;createFulfillmentOrder&#x60; operation. Displays in recipient-facing materials such as the packing slip. | 
**ShippingSpeedCategory** | **ShippingSpeedCategory** |  | 
**DeliveryWindow** | [**DeliveryWindow**](DeliveryWindow.md) |  | [optional] 
**DestinationAddress** | [**Address**](Address.md) | The destination address submitted with the &#x60;createFulfillmentOrder&#x60; operation. | 
**FulfillmentAction** | **FulfillmentAction** |  | [optional] 
**FulfillmentPolicy** | **FulfillmentPolicy** |  | [optional] 
**CodSettings** | [**CODSettings**](CODSettings.md) |  | [optional] 
**ReceivedDate** | **DateTime?** | The date and time that the fulfillment order was received by an Amazon fulfillment center. | 
**FulfillmentOrderStatus** | **FulfillmentOrderStatus** |  | 
**StatusUpdatedDate** | **DateTime?** | The date and time that the status of the fulfillment order last changed. Must be in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format. | 
**NotificationEmails** | [**NotificationEmailList**](NotificationEmailList.md) |  | [optional] 
**FeatureConstraints** | [**List&lt;FeatureSettings&gt;**](FeatureSettings.md) | A list of features and their fulfillment policies to apply to the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

