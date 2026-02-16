# Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound.GetFulfillmentPreviewRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketplaceId** | **string** | The marketplace the fulfillment order is placed against. | [optional] 
**Address** | [**Address**](Address.md) | The destination address for the fulfillment order preview. | 
**Items** | [**GetFulfillmentPreviewItemList**](GetFulfillmentPreviewItemList.md) | Identifying information and quantity information for the items in the fulfillment order preview. Maximum of 100 line items with a maximum of 250 units per order.  | 
**ShippingSpeedCategories** | [**ShippingSpeedCategoryList**](ShippingSpeedCategoryList.md) | A list of shipping methods used for creating fulfillment order previews.  Possible values:  * &#x60;Standard&#x60;: Standard shipping method. * &#x60;Expedited&#x60;: Expedited shipping method. * &#x60;Priority&#x60;: Priority shipping method. * &#x60;ScheduledDelivery&#x60;: Scheduled Delivery shipping method. **Note:** Shipping method service level agreements vary by marketplace. Sellers should see the Seller Central website in their marketplace for shipping method service level agreements and fulfillment fees. | [optional] 
**IncludeCODFulfillmentPreview** | **bool?** | When true, returns all fulfillment order previews both for COD and not for COD. Otherwise, returns only fulfillment order previews that are not for COD. | [optional] 
**IncludeDeliveryWindows** | **bool?** | When true, returns the &#x60;ScheduledDeliveryInfo&#x60; response object, which contains the available delivery windows for a Scheduled Delivery. The &#x60;ScheduledDeliveryInfo&#x60; response object can only be returned for fulfillment order previews with &#x60;ShippingSpeedCategories&#x60; equal to &#x60;ScheduledDelivery&#x60;. | [optional] 
**FeatureConstraints** | [**List&lt;FeatureSettings&gt;**](FeatureSettings.md) | A list of features and their fulfillment policies to apply to the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

