# Amazon.SellingPartnerAPIAA.Clients.Models.ProductPricing.CompetitiveSummaryRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Asin** | **string** | The Amazon Standard Identification Number for the item. | 
**MarketplaceId** | **string** | A marketplace identifier. | 
**IncludedData** | [**List&lt;CompetitiveSummaryIncludedData&gt;**](CompetitiveSummaryIncludedData.md) | The list of requested competitive pricing data for the product. | 
**LowestPricedOffersInputs** | [**List&lt;LowestPricedOffersInput&gt;**](LowestPricedOffersInput.md) | The list of &#x60;lowestPricedOffersInput&#x60; parameters that are used to build &#x60;lowestPricedOffers&#x60; in the response. This attribute is only valid if &#x60;lowestPricedOffers&#x60; is requested in &#x60;includedData&#x60; | [optional] 
**Method** | **HttpMethod** | HTTP method type | 
**Uri** | **string** | The URI associated with the individual APIs that are called as part of the batch request. For &#x60;getCompetitiveSummary&#x60;, this is &#x60;/products/pricing/2022-05-01/items/competitiveSummary&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

