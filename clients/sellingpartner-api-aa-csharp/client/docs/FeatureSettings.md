# Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound.FeatureSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FeatureName** | **string** | The name of the feature. Valid feature names are:  - &#x60;BLOCK_AMZL&#x60;: Blocks orders from being shipped using Amazon Logistics (AMZL).   - Note: Using this feature will incur additional fee surcharges on MCF orders and may increase the risk of unfulfilled or delayed deliveries if alternative carriers are unavailable. Using &#x60;BLOCK_AMZL&#x60; in an order request will take precedence over your Seller Central account setting. - &#x60;BLANK_BOX&#x60;: Ships orders in non-Amazon branded packaging (blank boxes). - &#x60;SIGNATURE_CONFIRMATION&#x60;: Requires a signature from the recipient upon delivery.    - Note: Using signature confirmation features will incur additional fees on MCF orders and are currently supported only in the US marketplace. | [optional] 
**FeatureFulfillmentPolicy** | **string** | Specifies the policy to use when fulfilling an order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

