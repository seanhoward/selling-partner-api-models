# Amazon.SellingPartnerAPIAA.Clients.Models.VendorInvoices.Invoice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvoiceType** | **string** | Identifies the type of invoice. | 
**Id** | **string** | Unique number relating to the charges defined in this document. This will be invoice number if the document type is Invoice or CreditNote number if the document type is Credit Note. Failure to provide this reference will result in a rejection. | 
**ReferenceNumber** | **string** | An additional unique reference number used for regulatory or other purposes. | [optional] 
**Date** | **DateTime?** | Date when the invoice/credit note information was generated in the origin&#39;s accounting system. The invoice date should be on or after the purchase order creation date. | 
**RemitToParty** | [**PartyIdentification**](PartyIdentification.md) | Name, address and tax details of the party receiving the payment of this invoice. | 
**ShipToParty** | [**PartyIdentification**](PartyIdentification.md) | Name, address and tax details of the party receiving a shipment of products. | [optional] 
**ShipFromParty** | [**PartyIdentification**](PartyIdentification.md) | Name, address and tax details of the party sending a shipment of products. | [optional] 
**BillToParty** | [**PartyIdentification**](PartyIdentification.md) | Name, address and tax details of the party to whom this invoice is issued. | [optional] 
**PaymentTerms** | [**PaymentTerms**](PaymentTerms.md) | The payment terms for the invoice. | [optional] 
**InvoiceTotal** | [**Money**](Money.md) | Total monetary amount charged in the invoice or full value of credit note to be paid including all relevant taxes. It is the total amount of invoice (including charges, less allowances) before terms discount (if discount is applicable). | 
**TaxDetails** | [**List&lt;TaxDetails&gt;**](TaxDetails.md) | Total tax amount details for all line items. | [optional] 
**AdditionalDetails** | [**List&lt;AdditionalDetails&gt;**](AdditionalDetails.md) | Additional details provided by the selling party, for tax related or other purposes. | [optional] 
**ChargeDetails** | [**List&lt;ChargeDetails&gt;**](ChargeDetails.md) | Total charge amount details for all line items. | [optional] 
**AllowanceDetails** | [**List&lt;AllowanceDetails&gt;**](AllowanceDetails.md) | Total allowance amount details for all line items. | [optional] 
**Items** | [**List&lt;InvoiceItem&gt;**](InvoiceItem.md) | The list of invoice items. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

