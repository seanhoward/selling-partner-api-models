# Amazon.SellingPartnerAPIAA.Clients.Models.Replenishment.ListOffersRequestFilters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketplaceId** | **string** | The marketplace identifier. The supported marketplaces for both sellers and vendors are US, CA, ES, UK, FR, IT, IN, DE and JP. The supported marketplaces for vendors only are BR, AU, MX, AE and NL.  Refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids) to find the identifier for the marketplace. | 
**Skus** | **List&lt;string&gt;** | A list of SKUs to filter. This filter is only supported for sellers and not for vendors. | [optional] 
**Asins** | **List&lt;string&gt;** | A list of Amazon Standard Identification Numbers (ASINs). | [optional] 
**Eligibilities** | [**List&lt;EligibilityStatus&gt;**](EligibilityStatus.md) | A list of eligibilities associated with an offer. | [optional] 
**Preferences** | [**Preference**](Preference.md) | Offer preferences to include in the result filter criteria. | [optional] 
**Promotions** | [**Promotion**](Promotion.md) | Offer promotions to include in the result filter criteria. | [optional] 
**ProgramTypes** | [**ProgramTypes**](ProgramTypes.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

