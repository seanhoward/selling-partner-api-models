# Amazon.SellingPartnerAPIAA.Clients.Models.Awd.ProductQuantity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attributes** | [**List&lt;ProductAttribute&gt;**](ProductAttribute.md) | Contains attributes for this instance of the product. For example, item color, or other attributes that distinguish the product beyond the SKU. This is metadata for the product and Amazon does not process this data. | [optional] 
**Quantity** | **int?** | Product quantity. | 
**Sku** | **string** | The seller or merchant SKU. | 
**Expiration** | **DateTime?** | The expiration date for the SKU. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. | [optional] 
**PrepDetails** | [**PrepDetails**](PrepDetails.md) | Preparation details of a product which contains the prep category, prep owner and the label owner. If not passed while creating an inbound order, NO_PREP will be used on the product by-default. Prep instructions will be generated based on the category passed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

