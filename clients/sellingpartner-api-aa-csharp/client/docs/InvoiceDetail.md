# Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentPayments.InvoiceDetail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvoiceNumber** | **string** | The unique invoice number. | 
**InvoiceDate** | **DateTime?** | Invoice date. | 
**ReferenceNumber** | **string** | An additional unique reference number used for regulatory or other purposes. | [optional] 
**RemitToParty** | [**PartyIdentification**](PartyIdentification.md) | Name, address and tax details of the party receiving the payment of this invoice. | 
**ShipFromParty** | [**PartyIdentification**](PartyIdentification.md) | Warehouse code of the vendor as in the order. | 
**BillToParty** | [**PartyIdentification**](PartyIdentification.md) | Name, address and tax details of the party to whom this invoice is issued. | [optional] 
**ShipToCountryCode** | **string** | Ship-to country code. | [optional] 
**PaymentTermsCode** | **string** | The payment terms for the invoice. | [optional] 
**InvoiceTotal** | [**Money**](Money.md) | Total amount details of the invoice. | 
**TaxTotals** | [**List&lt;TaxDetail&gt;**](TaxDetail.md) | Individual tax details per line item. | [optional] 
**AdditionalDetails** | [**List&lt;AdditionalDetails&gt;**](AdditionalDetails.md) | Additional details provided by the selling party, for tax-related or other purposes. | [optional] 
**ChargeDetails** | [**List&lt;ChargeDetails&gt;**](ChargeDetails.md) | Total charge amount details for all line items. | [optional] 
**Items** | [**List&lt;InvoiceItem&gt;**](InvoiceItem.md) | Provides the details of the items in this invoice. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

