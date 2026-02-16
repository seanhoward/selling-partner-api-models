# Amazon.SellingPartnerAPIAA.Clients.Models.VendorShipments.ItemDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PurchaseOrderNumber** | **string** | The purchase order number for the shipment being confirmed. If the items in this shipment belong to multiple purchase order numbers that are in particular carton or pallet within the shipment, then provide the purchaseOrderNumber at the appropriate carton or pallet level. Formatting Notes: 8-character alpha-numeric code. | [optional] 
**LotNumber** | **string** | The batch or lot number associates an item with information the manufacturer considers relevant for traceability of the trade item to which the Element String is applied. The data may refer to the trade item itself or to items contained. This field is mandatory for all perishable items. | [optional] 
**LotNumberSourceReference** | **string** | The location identifier where the product receives a traceability lot number. Provide this field for products subject to the FDA Food Safety Modernization Act (FSMA) Section 204. When you provide &#x60;lotNumberSourceReference&#x60;, you must also specify the corresponding &#x60;lotNumberSourceType&#x60; field. | [optional] 
**LotNumberSourceType** | **string** | The identifier type used for the lot number source. Provide this field when you specify &#x60;lotNumberSourceReference&#x60;. | [optional] 
**CountryOfOrigin** | **string** | The two-character country code for the country where the product was manufactured or originates. Use ISO 3166-1 alpha-2 format. | [optional] 
**RegulationReferences** | [**RegulationReferences**](RegulationReferences.md) | Regulatory requirements and compliance information for the item. | [optional] 
**Expiry** | [**Expiry**](Expiry.md) | Expiry refers to the collection of dates required  for certain items. These could be either expiryDate or mfgDate and expiryAfterDuration. These are mandatory for perishable items. | [optional] 
**MaximumRetailPrice** | [**Money**](Money.md) | Maximum retail price of the item being shipped. | [optional] 
**HandlingCode** | **string** | Identification of the instructions on how specified item/carton/pallet should be handled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

