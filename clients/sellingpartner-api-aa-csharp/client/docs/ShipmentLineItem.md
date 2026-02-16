# Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments.ShipmentLineItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShipmentLineItemId** | **string** | An identifier for a shipment&#39;s line item. This identifier is guaranteed to be unique within the scope of its containing shipment. | 
**MerchantSku** | **string** | The seller&#39;s identifier for the SKU in this line item. | 
**NumberOfUnits** | **int?** | The number of items of the SKU in this line item. | 
**SerialNumbers** | **List&lt;string&gt;** | The serial numbers for each item in this line item. | [optional] 
**PieceType** | **PieceType** | Whether the line item has multiple pieces. | [optional] 
**HazmatLabels** | **List&lt;string&gt;** | A list of HAZMAT label identifiers that must be applied to the packages for this line item. | [optional] 
**GiftAttributes** | [**GiftAttributes**](GiftAttributes.md) | Information about any gift wrapping that is needed for this line item. | [optional] 
**Charges** | [**Charges**](Charges.md) | The charges associated with the line item. The charge amount does not include the tax amount. | 
**Cancellations** | [**Cancellations**](Cancellations.md) | A list of cancellations for the given line item. | [optional] 
**HsnCode** | **string** | The HSN code of SKU in this line item. | [optional] 
**RecommendedCountryOfOrigin** | **string** | The country of origin recommended by the marketplace, represented as a two-letter country code following the ISO-3166 alpha-2 standard. | [optional] 
**CountryOfOrigin** | **string** | The country of origin provided by the seller, represented by a two-letter country code in ISO-3166 alpha-2 format. You must pass this field when &#x60;countryOfOriginRequirement&#x60; is &#x60;REQUIRED&#x60; in the &#x60;getShipment&#x60; or &#x60;getShipments&#x60; response. | [optional] 
**RecommendedCurrencyCode** | **string** | The three digit currency code of the currency recommended by the marketplace, in ISO 4217 format. | [optional] 
**ItemValue** | [**Amount**](Amount.md) | The value of the item being shipped, as provided by the seller. This serves as the basis for import duty/tax calculations. You must pass this field when &#x60;itemValueRequirement&#x60; is &#x60;REQUIRED&#x60; in the &#x60;getShipment&#x60; or &#x60;getShipments&#x60; response. | [optional] 
**ComplianceAttributes** | [**ComplianceAttributes**](ComplianceAttributes.md) | All necessary compliance attributes specific to the line item. | 
**CustomAttributes** | [**List&lt;CustomAttribute&gt;**](CustomAttribute.md) | A list of custom passthrough attributes. For details on these attributes, reach out to your respective program teams at Amazon. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

