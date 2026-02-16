# Amazon.SellingPartnerAPIAA.Clients.Models.VendorInvoices.InvoiceItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemSequenceNumber** | **int?** | Unique number related to this line item. | 
**AmazonProductIdentifier** | **string** | Amazon Standard Identification Number (ASIN) of an item. | [optional] 
**VendorProductIdentifier** | **string** | The vendor selected product identifier of the item. Should be the same as was provided in the purchase order. | [optional] 
**InvoicedQuantity** | [**ItemQuantity**](ItemQuantity.md) | Invoiced quantity of this item. Quantity must be greater than zero. | 
**NetCost** | [**Money**](Money.md) | The item cost to Amazon, which should match the cost on the order. Price information should not be zero or negative. It indicates net unit price. Net cost means VAT is not included in cost. If items are priced by weight, this cost need to be considered in conjunction with netCostUnitOfMeasure. E.g.: $5/LB | 
**NetCostUnitOfMeasure** | **NetCostUnitOfMeasure** | This field represents weight unit of measure of items that are ordered by cases and supporting priced by weight. | [optional] 
**PurchaseOrderNumber** | **string** | The Amazon purchase order number for this invoiced line item. Formatting Notes: 8-character alpha-numeric code. This value is mandatory only when invoiceType is Invoice, and is not required when invoiceType is CreditNote. | [optional] 
**HsnCode** | **string** | HSN Tax code. The HSN number cannot contain alphabets. | [optional] 
**CreditNoteDetails** | [**CreditNoteDetails**](CreditNoteDetails.md) | Details required in order to process a credit note. This information is required only if invoiceType is CreditNote. | [optional] 
**TaxDetails** | [**List&lt;TaxDetails&gt;**](TaxDetails.md) | Individual tax details per line item. | [optional] 
**ChargeDetails** | [**List&lt;ChargeDetails&gt;**](ChargeDetails.md) | Individual charge details per line item. | [optional] 
**AllowanceDetails** | [**List&lt;AllowanceDetails&gt;**](AllowanceDetails.md) | Individual allowance details per line item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

