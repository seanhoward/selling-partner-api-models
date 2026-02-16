# Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments.PackageLineItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageLineItemId** | **string** | The line item ID. | 
**Quantity** | **int?** | The number of items of a particular line item of a shipment that are packed into the package. | 
**SerialNumbers** | **List&lt;string&gt;** | The list of serial numbers of items in the package, if required to be provided. | [optional] 
**Pieces** | **int?** | The number of pieces of a multi-piece item that are in this package. This is applicable only for items that are shipped in multiple pieces. | [optional] 
**CountryOfOrigin** | **string** | The country of origin provided by the seller, represented by a two-letter country code in ISO-3166 alpha-2 format. You must pass this field when &#x60;countryOfOriginRequirement&#x60; is &#x60;REQUIRED&#x60; in the &#x60;getShipment&#x60; or &#x60;getShipments&#x60; response. | [optional] 
**ItemValue** | [**Amount**](Amount.md) | The value of the item being shipped, as provided by the seller. This serves as the basis for import duty/tax calculations. You must pass this field when &#x60;itemValueRequirement&#x60; is &#x60;REQUIRED&#x60; in the &#x60;getShipment&#x60; or &#x60;getShipments&#x60; response. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

