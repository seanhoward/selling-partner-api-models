# Amazon.SellingPartnerAPIAA.Clients.Models.ShipmentInvoicing.ShipmentItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ASIN** | **string** | The Amazon Standard Identification Number (ASIN) of the item. | [optional] 
**SellerSKU** | **string** | The seller SKU of the item. | [optional] 
**OrderItemId** | **string** | The Amazon-defined identifier for the order item. | [optional] 
**Title** | **string** | The name of the item. | [optional] 
**QuantityOrdered** | **decimal?** | The number of items ordered. | [optional] 
**ItemPrice** | [**Money**](Money.md) | The selling price of the item multiplied by the quantity ordered. Note that ItemPrice excludes ShippingPrice and GiftWrapPrice. | [optional] 
**ShippingPrice** | [**Money**](Money.md) | The shipping price of the item. | [optional] 
**GiftWrapPrice** | [**Money**](Money.md) | The gift wrap price of the item. | [optional] 
**ShippingDiscount** | [**Money**](Money.md) | The discount on the shipping price. | [optional] 
**PromotionDiscount** | [**Money**](Money.md) | The total of all promotional discounts in the offer. | [optional] 
**SerialNumbers** | [**SerialNumbersList**](SerialNumbersList.md) | The list of serial numbers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

