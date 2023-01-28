# Amazon.SellingPartnerAPIAA.Client - the C# library for the Selling Partner API for Pricing

The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: v0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://sellercentral.amazon.com/gp/mws/contactus.html](https://sellercentral.amazon.com/gp/mws/contactus.html)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Amazon.SellingPartnerAPIAA.Client.Api;
using Amazon.SellingPartnerAPIAA.Client.Client;
using Amazon.SellingPartnerAPIAA.Client.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Amazon.SellingPartnerAPIAA.Client.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Client.Api;
using Amazon.SellingPartnerAPIAA.Client.Client;
using Amazon.SellingPartnerAPIAA.Client.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new ProductPricingApi();
            var marketplaceId = marketplaceId_example;  // string | A marketplace identifier. Specifies the marketplace for which prices are returned.
            var itemType = itemType_example;  // string | Indicates whether ASIN values or seller SKU values are used to identify items. If you specify Asin, the information in the response will be dependent on the list of Asins you provide in the Asins parameter. If you specify Sku, the information in the response will be dependent on the list of Skus you provide in the Skus parameter. Possible values: Asin, Sku.
            var asins = new List<string>(); // List<string> | A list of up to twenty Amazon Standard Identification Number (ASIN) values used to identify items in the given marketplace. (optional) 
            var skus = new List<string>(); // List<string> | A list of up to twenty seller SKU values used to identify items in the given marketplace. (optional) 
            var customerType = customerType_example;  // string | Indicates whether to request pricing information from the point of view of Consumer or Business buyers. Default is Consumer. (optional) 

            try
            {
                GetPricingResponse result = apiInstance.GetCompetitivePricing(marketplaceId, itemType, asins, skus, customerType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductPricingApi.GetCompetitivePricing: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ProductPricingApi* | [**GetCompetitivePricing**](docs/ProductPricingApi.md#getcompetitivepricing) | **GET** /products/pricing/v0/competitivePrice | 
*ProductPricingApi* | [**GetItemOffers**](docs/ProductPricingApi.md#getitemoffers) | **GET** /products/pricing/v0/items/{Asin}/offers | 
*ProductPricingApi* | [**GetItemOffersBatch**](docs/ProductPricingApi.md#getitemoffersbatch) | **POST** /batches/products/pricing/v0/itemOffers | 
*ProductPricingApi* | [**GetListingOffers**](docs/ProductPricingApi.md#getlistingoffers) | **GET** /products/pricing/v0/listings/{SellerSKU}/offers | 
*ProductPricingApi* | [**GetListingOffersBatch**](docs/ProductPricingApi.md#getlistingoffersbatch) | **POST** /batches/products/pricing/v0/listingOffers | 
*ProductPricingApi* | [**GetPricing**](docs/ProductPricingApi.md#getpricing) | **GET** /products/pricing/v0/price | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ASINIdentifier](docs/ASINIdentifier.md)
 - [Model.AttributeSetList](docs/AttributeSetList.md)
 - [Model.BatchOffersRequestParams](docs/BatchOffersRequestParams.md)
 - [Model.BatchOffersResponse](docs/BatchOffersResponse.md)
 - [Model.BatchRequest](docs/BatchRequest.md)
 - [Model.BuyBoxEligibleOffers](docs/BuyBoxEligibleOffers.md)
 - [Model.BuyBoxPriceType](docs/BuyBoxPriceType.md)
 - [Model.BuyBoxPrices](docs/BuyBoxPrices.md)
 - [Model.CompetitivePriceList](docs/CompetitivePriceList.md)
 - [Model.CompetitivePriceType](docs/CompetitivePriceType.md)
 - [Model.CompetitivePricingType](docs/CompetitivePricingType.md)
 - [Model.ConditionType](docs/ConditionType.md)
 - [Model.CustomerType](docs/CustomerType.md)
 - [Model.DetailedShippingTimeType](docs/DetailedShippingTimeType.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorList](docs/ErrorList.md)
 - [Model.Errors](docs/Errors.md)
 - [Model.FulfillmentChannelType](docs/FulfillmentChannelType.md)
 - [Model.GetItemOffersBatchRequest](docs/GetItemOffersBatchRequest.md)
 - [Model.GetItemOffersBatchResponse](docs/GetItemOffersBatchResponse.md)
 - [Model.GetListingOffersBatchRequest](docs/GetListingOffersBatchRequest.md)
 - [Model.GetListingOffersBatchResponse](docs/GetListingOffersBatchResponse.md)
 - [Model.GetOffersHttpStatusLine](docs/GetOffersHttpStatusLine.md)
 - [Model.GetOffersResponse](docs/GetOffersResponse.md)
 - [Model.GetOffersResult](docs/GetOffersResult.md)
 - [Model.GetPricingResponse](docs/GetPricingResponse.md)
 - [Model.HttpMethod](docs/HttpMethod.md)
 - [Model.HttpRequestHeaders](docs/HttpRequestHeaders.md)
 - [Model.HttpResponseHeaders](docs/HttpResponseHeaders.md)
 - [Model.IdentifierType](docs/IdentifierType.md)
 - [Model.ItemCondition](docs/ItemCondition.md)
 - [Model.ItemIdentifier](docs/ItemIdentifier.md)
 - [Model.ItemOffersRequest](docs/ItemOffersRequest.md)
 - [Model.ItemOffersRequestList](docs/ItemOffersRequestList.md)
 - [Model.ItemOffersRequestParams](docs/ItemOffersRequestParams.md)
 - [Model.ItemOffersResponse](docs/ItemOffersResponse.md)
 - [Model.ItemOffersResponseList](docs/ItemOffersResponseList.md)
 - [Model.ListingOffersRequest](docs/ListingOffersRequest.md)
 - [Model.ListingOffersRequestList](docs/ListingOffersRequestList.md)
 - [Model.ListingOffersRequestParams](docs/ListingOffersRequestParams.md)
 - [Model.ListingOffersResponse](docs/ListingOffersResponse.md)
 - [Model.ListingOffersResponseList](docs/ListingOffersResponseList.md)
 - [Model.LowestPriceType](docs/LowestPriceType.md)
 - [Model.LowestPrices](docs/LowestPrices.md)
 - [Model.MoneyType](docs/MoneyType.md)
 - [Model.NumberOfOfferListingsList](docs/NumberOfOfferListingsList.md)
 - [Model.NumberOfOffers](docs/NumberOfOffers.md)
 - [Model.OfferCountType](docs/OfferCountType.md)
 - [Model.OfferCustomerType](docs/OfferCustomerType.md)
 - [Model.OfferDetail](docs/OfferDetail.md)
 - [Model.OfferDetailList](docs/OfferDetailList.md)
 - [Model.OfferListingCountType](docs/OfferListingCountType.md)
 - [Model.OfferType](docs/OfferType.md)
 - [Model.OffersList](docs/OffersList.md)
 - [Model.Points](docs/Points.md)
 - [Model.Price](docs/Price.md)
 - [Model.PriceList](docs/PriceList.md)
 - [Model.PriceType](docs/PriceType.md)
 - [Model.PrimeInformationType](docs/PrimeInformationType.md)
 - [Model.Product](docs/Product.md)
 - [Model.QuantityDiscountPriceType](docs/QuantityDiscountPriceType.md)
 - [Model.QuantityDiscountType](docs/QuantityDiscountType.md)
 - [Model.RelationshipList](docs/RelationshipList.md)
 - [Model.SalesRankList](docs/SalesRankList.md)
 - [Model.SalesRankType](docs/SalesRankType.md)
 - [Model.SellerFeedbackType](docs/SellerFeedbackType.md)
 - [Model.SellerSKUIdentifier](docs/SellerSKUIdentifier.md)
 - [Model.ShipsFromType](docs/ShipsFromType.md)
 - [Model.Summary](docs/Summary.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.