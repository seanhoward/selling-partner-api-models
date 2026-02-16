# Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment.ShipmentRequestDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmazonOrderId** | **string** | An Amazon-defined order identifier in 3-7-7 format. | 
**SellerOrderId** | **string** | A seller-defined order identifier. | [optional] 
**ItemList** | [**ItemList**](ItemList.md) |  | 
**ShipFromAddress** | [**Address**](Address.md) | The address of the sender. | 
**PackageDimensions** | [**PackageDimensions**](PackageDimensions.md) | The package dimensions. | 
**Weight** | [**Weight**](Weight.md) | The package weight. | 
**MustArriveByDate** | **DateTime?** | The date by which the package must arrive to keep the promise to the customer, in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. If &#x60;MustArriveByDate&#x60; is specified, only shipping service offers that can be delivered by that date are returned. | [optional] 
**ShipDate** | **DateTime?** | When used in a request, this is the date and time that the seller wants to ship the package. When used in a response, this is the date and time that the package can be shipped by the indicated method. | [optional] 
**ShippingServiceOptions** | [**ShippingServiceOptions**](ShippingServiceOptions.md) | Extra services offered by the carrier. | 
**LabelCustomization** | [**LabelCustomization**](LabelCustomization.md) | Label customization options. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

