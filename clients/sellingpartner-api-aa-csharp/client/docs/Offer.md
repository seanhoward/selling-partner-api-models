# Amazon.SellingPartnerAPIAA.Clients.Models.Pricing.Offer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SellerId** | **string** | The seller identifier for the offer. | 
**Condition** | **Condition** | Item Condition. | 
**SubCondition** | **string** | The item subcondition of the offer. | [optional] 
**FulfillmentType** | **FulfillmentType** | The fulfillment type for the offer. Possible values are &#x60;AFN&#x60; (Amazon Fulfillment Network) and &#x60;MFN&#x60; (Merchant Fulfillment Network). | 
**ListingPrice** | [**MoneyType**](MoneyType.md) | The offer buying price. This doesn&#39;t include shipping, points, or applicable promotions. | 
**ShippingOptions** | [**List&lt;ShippingOption&gt;**](ShippingOption.md) | A list of shipping options associated with this offer | [optional] 
**Points** | [**Points**](Points.md) | The number of Amazon Points that are offered with the purchase of an item and the monetary value of these points. Note that the Points element is only returned in Japan (JP). | [optional] 
**PrimeDetails** | [**PrimeDetails**](PrimeDetails.md) | Amazon Prime details. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

