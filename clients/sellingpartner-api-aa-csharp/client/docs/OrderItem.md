# Amazon.SellingPartnerAPIAA.Clients.Models.Orders.OrderItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ASIN** | **string** | The item&#39;s Amazon Standard Identification Number (ASIN). | 
**SellerSKU** | **string** | The item&#39;s seller stock keeping unit (SKU). | [optional] 
**OrderItemId** | **string** | An Amazon-defined order item identifier. | 
**AssociatedItems** | [**List&lt;AssociatedItem&gt;**](AssociatedItem.md) | A list of associated items that a customer has purchased with a product. For example, a tire installation service purchased with tires. | [optional] 
**Title** | **string** | The item&#39;s name. | [optional] 
**QuantityOrdered** | **int?** | The number of items in the order.  | 
**QuantityShipped** | **int?** | The number of items shipped. | [optional] 
**ProductInfo** | [**ProductInfoDetail**](ProductInfoDetail.md) | The item&#39;s product information. | [optional] 
**PointsGranted** | [**PointsGrantedDetail**](PointsGrantedDetail.md) | The number and value of Amazon Points granted with the purchase of an item. | [optional] 
**ItemPrice** | [**Money**](Money.md) | The selling price of the order item. Note that an order item is an item and a quantity. This means that the value of &#x60;ItemPrice&#x60; is equal to the selling price of the item multiplied by the quantity ordered. &#x60;ItemPrice&#x60; excludes &#x60;ShippingPrice&#x60; and GiftWrapPrice. | [optional] 
**ShippingPrice** | [**Money**](Money.md) | The item&#39;s shipping price. | [optional] 
**ItemTax** | [**Money**](Money.md) | The tax on the item price. | [optional] 
**ShippingTax** | [**Money**](Money.md) | The tax on the shipping price. | [optional] 
**ShippingDiscount** | [**Money**](Money.md) | The discount on the shipping price. | [optional] 
**ShippingDiscountTax** | [**Money**](Money.md) | The tax on the discount on the shipping price. | [optional] 
**PromotionDiscount** | [**Money**](Money.md) | The total of all promotional discounts in the offer. | [optional] 
**PromotionDiscountTax** | [**Money**](Money.md) | The tax on the total of all promotional discounts in the offer. | [optional] 
**PromotionIds** | [**PromotionIdList**](PromotionIdList.md) |  | [optional] 
**CODFee** | [**Money**](Money.md) | The fee charged for COD service. | [optional] 
**CODFeeDiscount** | [**Money**](Money.md) | The discount on the COD fee. | [optional] 
**IsGift** | **string** | Indicates whether the item is a gift.  **Possible values**: &#x60;true&#x60; and &#x60;false&#x60;. | [optional] 
**ConditionNote** | **string** | The condition of the item, as described by the seller. | [optional] 
**ConditionId** | **string** | The condition of the item.  **Possible values**: &#x60;New&#x60;, &#x60;Used&#x60;, &#x60;Collectible&#x60;, &#x60;Refurbished&#x60;, &#x60;Preorder&#x60;, and &#x60;Club&#x60;. | [optional] 
**ConditionSubtypeId** | **string** | The subcondition of the item.  **Possible values**: &#x60;New&#x60;, &#x60;Mint&#x60;, &#x60;Very Good&#x60;, &#x60;Good&#x60;, &#x60;Acceptable&#x60;, &#x60;Poor&#x60;, &#x60;Club&#x60;, &#x60;OEM&#x60;, &#x60;Warranty&#x60;, &#x60;Refurbished Warranty&#x60;, &#x60;Refurbished&#x60;, &#x60;Open Box&#x60;, &#x60;Any&#x60;, and &#x60;Other&#x60;. | [optional] 
**ScheduledDeliveryStartDate** | **string** | The start date of the scheduled delivery window in the time zone for the order destination. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date time format. | [optional] 
**ScheduledDeliveryEndDate** | **string** | The end date of the scheduled delivery window in the time zone for the order destination. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date time format. | [optional] 
**PriceDesignation** | **string** | Indicates that the selling price is a special price that is only available for Amazon Business orders. For more information about the Amazon Business Seller Program, refer to the [Amazon Business website](https://www.amazon.com/b2b/info/amazon-business).   **Possible values**: &#x60;BusinessPrice&#x60; | [optional] 
**TaxCollection** | [**TaxCollection**](TaxCollection.md) | Information about withheld taxes. | [optional] 
**SerialNumberRequired** | **bool?** | When true, the product type for this item has a serial number.   Only returned for Amazon Easy Ship orders. | [optional] 
**IsTransparency** | **bool?** | When true, the ASIN is enrolled in Transparency. The Transparency serial number that you must submit is determined by:  **1D or 2D Barcode:** This has a **T** logo. Submit either the 29-character alpha-numeric identifier beginning with **AZ** or **ZA**, or the 38-character Serialized Global Trade Item Number (SGTIN). **2D Barcode SN:** Submit the 7- to 20-character serial number barcode, which likely has the prefix **SN**. The serial number is applied to the same side of the packaging as the GTIN (UPC/EAN/ISBN) barcode. **QR code SN:** Submit the URL that the QR code generates. | [optional] 
**IossNumber** | **string** | The IOSS number of the marketplace. Sellers shipping to the EU from outside the EU must provide this IOSS number to their carrier when Amazon has collected the VAT on the sale. | [optional] 
**StoreChainStoreId** | **string** | The store chain store identifier. Linked to a specific store in a store chain. | [optional] 
**DeemedResellerCategory** | **string** | The category of deemed reseller. This applies to selling partners that are not based in the EU and is used to help them meet the VAT Deemed Reseller tax laws in the EU and UK. | [optional] 
**BuyerInfo** | [**ItemBuyerInfo**](ItemBuyerInfo.md) | A single item&#39;s buyer information.  **Note**: The &#x60;BuyerInfo&#x60; contains restricted data. Use the Restricted Data Token (RDT) and restricted SPDS roles to access the restricted data in &#x60;BuyerInfo&#x60;. For example, &#x60;BuyerCustomizedInfo&#x60; and &#x60;GiftMessageText&#x60;. | [optional] 
**BuyerRequestedCancel** | [**BuyerRequestedCancel**](BuyerRequestedCancel.md) | Information about whether or not a buyer requested cancellation. | [optional] 
**SerialNumbers** | **List&lt;string&gt;** | A list of serial numbers for electronic products that are shipped to customers. Returned for FBA orders only. | [optional] 
**SubstitutionPreferences** | [**SubstitutionPreferences**](SubstitutionPreferences.md) | Substitution preferences for the order item. This is an optional field that is only present if a seller supports substitutions, as is the case with some grocery sellers. | [optional] 
**Measurement** | [**Measurement**](Measurement.md) | Measurement information for the order item. | [optional] 
**ShippingConstraints** | [**ShippingConstraints**](ShippingConstraints.md) | Shipping constraints applicable to this order. | [optional] 
**AmazonPrograms** | [**AmazonPrograms**](AmazonPrograms.md) | Contains the list of programs that are associated with an item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

