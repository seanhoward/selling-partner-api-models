# Amazon.SellingPartnerAPIAA.Clients.Models.Pricing.ItemOffersRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | The resource path of the operation you are calling in batch without any query parameters.  If you are calling &#x60;getItemOffersBatch&#x60;, supply the path of &#x60;getItemOffers&#x60;.  **Example:** &#x60;/products/pricing/v0/items/B000P6Q7MY/offers&#x60;  If you are calling &#x60;getListingOffersBatch&#x60;, supply the path of &#x60;getListingOffers&#x60;.  **Example:** &#x60;/products/pricing/v0/listings/B000P6Q7MY/offers&#x60; | 
**Method** | [**HttpMethod**](HttpMethod.md) |  | 
**Headers** | [**HttpRequestHeaders**](HttpRequestHeaders.md) |  | [optional] 
**MarketplaceId** | **string** |  | 
**ItemCondition** | [**ItemCondition**](ItemCondition.md) | Filters the offer listings to be considered based on item condition. Possible values: New, Used, Collectible, Refurbished, Club. | 
**CustomerType** | [**CustomerType**](CustomerType.md) | Indicates whether to request Consumer or Business offers. Default is Consumer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

