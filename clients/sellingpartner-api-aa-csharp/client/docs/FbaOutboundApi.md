# Amazon.SellingPartnerAPIAA.Clients.API.FbaOutboundApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelFulfillmentOrder**](FbaOutboundApi.md#cancelfulfillmentorder) | **PUT** /fba/outbound/2020-07-01/fulfillmentOrders/{sellerFulfillmentOrderId}/cancel | 
[**CreateFulfillmentOrder**](FbaOutboundApi.md#createfulfillmentorder) | **POST** /fba/outbound/2020-07-01/fulfillmentOrders | 
[**CreateFulfillmentReturn**](FbaOutboundApi.md#createfulfillmentreturn) | **PUT** /fba/outbound/2020-07-01/fulfillmentOrders/{sellerFulfillmentOrderId}/return | 
[**DeliveryOffers**](FbaOutboundApi.md#deliveryoffers) | **POST** /fba/outbound/2020-07-01/deliveryOffers | 
[**GetFeatureInventory**](FbaOutboundApi.md#getfeatureinventory) | **GET** /fba/outbound/2020-07-01/features/inventory/{featureName} | 
[**GetFeatureSKU**](FbaOutboundApi.md#getfeaturesku) | **GET** /fba/outbound/2020-07-01/features/inventory/{featureName}/{sellerSku} | 
[**GetFeatures**](FbaOutboundApi.md#getfeatures) | **GET** /fba/outbound/2020-07-01/features | 
[**GetFulfillmentOrder**](FbaOutboundApi.md#getfulfillmentorder) | **GET** /fba/outbound/2020-07-01/fulfillmentOrders/{sellerFulfillmentOrderId} | 
[**GetFulfillmentPreview**](FbaOutboundApi.md#getfulfillmentpreview) | **POST** /fba/outbound/2020-07-01/fulfillmentOrders/preview | 
[**GetPackageTrackingDetails**](FbaOutboundApi.md#getpackagetrackingdetails) | **GET** /fba/outbound/2020-07-01/tracking | 
[**ListAllFulfillmentOrders**](FbaOutboundApi.md#listallfulfillmentorders) | **GET** /fba/outbound/2020-07-01/fulfillmentOrders | 
[**ListReturnReasonCodes**](FbaOutboundApi.md#listreturnreasoncodes) | **GET** /fba/outbound/2020-07-01/returnReasonCodes | 
[**SubmitFulfillmentOrderStatusUpdate**](FbaOutboundApi.md#submitfulfillmentorderstatusupdate) | **PUT** /fba/outbound/2020-07-01/fulfillmentOrders/{sellerFulfillmentOrderId}/status | 
[**UpdateFulfillmentOrder**](FbaOutboundApi.md#updatefulfillmentorder) | **PUT** /fba/outbound/2020-07-01/fulfillmentOrders/{sellerFulfillmentOrderId} | 


<a name="cancelfulfillmentorder"></a>
# **CancelFulfillmentOrder**
> CancelFulfillmentOrderResponse CancelFulfillmentOrder (string sellerFulfillmentOrderId)



Requests that Amazon stop attempting to fulfill the fulfillment order indicated by the specified order identifier.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class CancelFulfillmentOrderExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var sellerFulfillmentOrderId = sellerFulfillmentOrderId_example;  // string | The identifier assigned to the item by the seller when the fulfillment order was created.

            try
            {
                CancelFulfillmentOrderResponse result = apiInstance.CancelFulfillmentOrder(sellerFulfillmentOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.CancelFulfillmentOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sellerFulfillmentOrderId** | **string**| The identifier assigned to the item by the seller when the fulfillment order was created. | 

### Return type

[**CancelFulfillmentOrderResponse**](CancelFulfillmentOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfulfillmentorder"></a>
# **CreateFulfillmentOrder**
> CreateFulfillmentOrderResponse CreateFulfillmentOrder (CreateFulfillmentOrderRequest body)



Requests that Amazon ship items from the seller's inventory in Amazon's fulfillment network to a destination address.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class CreateFulfillmentOrderExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var body = new CreateFulfillmentOrderRequest(); // CreateFulfillmentOrderRequest | CreateFulfillmentOrderRequest parameter

            try
            {
                CreateFulfillmentOrderResponse result = apiInstance.CreateFulfillmentOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.CreateFulfillmentOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateFulfillmentOrderRequest**](CreateFulfillmentOrderRequest.md)| CreateFulfillmentOrderRequest parameter | 

### Return type

[**CreateFulfillmentOrderResponse**](CreateFulfillmentOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfulfillmentreturn"></a>
# **CreateFulfillmentReturn**
> CreateFulfillmentReturnResponse CreateFulfillmentReturn (CreateFulfillmentReturnRequest body, string sellerFulfillmentOrderId)



Creates a fulfillment return.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class CreateFulfillmentReturnExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var body = new CreateFulfillmentReturnRequest(); // CreateFulfillmentReturnRequest | The request body of the `createFulfillmentReturn` operation.
            var sellerFulfillmentOrderId = sellerFulfillmentOrderId_example;  // string | An identifier the seller assigns to the fulfillment order at the time it was created. The seller uses their own records to find the correct `sellerFulfillmentOrderId` value based on the buyer's request to return items.

            try
            {
                CreateFulfillmentReturnResponse result = apiInstance.CreateFulfillmentReturn(body, sellerFulfillmentOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.CreateFulfillmentReturn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateFulfillmentReturnRequest**](CreateFulfillmentReturnRequest.md)| The request body of the &#x60;createFulfillmentReturn&#x60; operation. | 
 **sellerFulfillmentOrderId** | **string**| An identifier the seller assigns to the fulfillment order at the time it was created. The seller uses their own records to find the correct &#x60;sellerFulfillmentOrderId&#x60; value based on the buyer&#39;s request to return items. | 

### Return type

[**CreateFulfillmentReturnResponse**](CreateFulfillmentReturnResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deliveryoffers"></a>
# **DeliveryOffers**
> GetDeliveryOffersResponse DeliveryOffers (GetDeliveryOffersRequest body)



Returns delivery options that include an estimated delivery date and offer expiration, based on criteria that you specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class DeliveryOffersExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var body = new GetDeliveryOffersRequest(); // GetDeliveryOffersRequest | GetDeliveryOffersRequest parameter

            try
            {
                GetDeliveryOffersResponse result = apiInstance.DeliveryOffers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.DeliveryOffers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetDeliveryOffersRequest**](GetDeliveryOffersRequest.md)| GetDeliveryOffersRequest parameter | 

### Return type

[**GetDeliveryOffersResponse**](GetDeliveryOffersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureinventory"></a>
# **GetFeatureInventory**
> GetFeatureInventoryResponse GetFeatureInventory (string marketplaceId, string featureName, string nextToken = null, DateTime? queryStartDate = null)



Returns a list of inventory items that are eligible for the fulfillment feature you specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)..

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class GetFeatureInventoryExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var marketplaceId = marketplaceId_example;  // string | The marketplace for which to return a list of the inventory that is eligible for the specified feature.
            var featureName = featureName_example;  // string | The name of the feature for which to return a list of eligible inventory.
            var nextToken = nextToken_example;  // string | A string token returned in the response to your previous request that is used to return the next response page. A value of `null` will return the first page. (optional) 
            var queryStartDate = 2013-10-20T19:20:30+01:00;  // DateTime? | A date that you can use to select inventory that has been updated since a specified date. An update is defined as any change in feature-enabled inventory availability. The date must be in the format `yyyy-MM-ddTHH:mm:ss.sssZ` (optional) 

            try
            {
                GetFeatureInventoryResponse result = apiInstance.GetFeatureInventory(marketplaceId, featureName, nextToken, queryStartDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.GetFeatureInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| The marketplace for which to return a list of the inventory that is eligible for the specified feature. | 
 **featureName** | **string**| The name of the feature for which to return a list of eligible inventory. | 
 **nextToken** | **string**| A string token returned in the response to your previous request that is used to return the next response page. A value of &#x60;null&#x60; will return the first page. | [optional] 
 **queryStartDate** | **DateTime?**| A date that you can use to select inventory that has been updated since a specified date. An update is defined as any change in feature-enabled inventory availability. The date must be in the format &#x60;yyyy-MM-ddTHH:mm:ss.sssZ&#x60; | [optional] 

### Return type

[**GetFeatureInventoryResponse**](GetFeatureInventoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeaturesku"></a>
# **GetFeatureSKU**
> GetFeatureSkuResponse GetFeatureSKU (string marketplaceId, string featureName, string sellerSku)



Returns the number of items with the `sellerSku` you specify that can have orders fulfilled using the specified feature. Note that if the `sellerSku` isn't eligible, the response will contain an empty `skuInfo` object. The parameters for this operation may contain special characters that require URL encoding. To avoid errors with SKUs when encoding URLs, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class GetFeatureSKUExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var marketplaceId = marketplaceId_example;  // string | The marketplace for which to return the count.
            var featureName = featureName_example;  // string | The name of the feature.
            var sellerSku = sellerSku_example;  // string | Used to identify an item in the given marketplace. `sellerSku` is qualified by the seller's `sellerId`, which is included with every operation that you submit.

            try
            {
                GetFeatureSkuResponse result = apiInstance.GetFeatureSKU(marketplaceId, featureName, sellerSku);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.GetFeatureSKU: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| The marketplace for which to return the count. | 
 **featureName** | **string**| The name of the feature. | 
 **sellerSku** | **string**| Used to identify an item in the given marketplace. &#x60;sellerSku&#x60; is qualified by the seller&#39;s &#x60;sellerId&#x60;, which is included with every operation that you submit. | 

### Return type

[**GetFeatureSkuResponse**](GetFeatureSkuResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatures"></a>
# **GetFeatures**
> GetFeaturesResponse GetFeatures (string marketplaceId)



Returns a list of features available for Multi-Channel Fulfillment orders in the marketplace you specify, and whether the seller for which you made the call is enrolled for each feature.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class GetFeaturesExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var marketplaceId = marketplaceId_example;  // string | The marketplace for which to return the list of features.

            try
            {
                GetFeaturesResponse result = apiInstance.GetFeatures(marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.GetFeatures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| The marketplace for which to return the list of features. | 

### Return type

[**GetFeaturesResponse**](GetFeaturesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentorder"></a>
# **GetFulfillmentOrder**
> GetFulfillmentOrderResponse GetFulfillmentOrder (string sellerFulfillmentOrderId)



Returns the fulfillment order indicated by the specified order identifier.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class GetFulfillmentOrderExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var sellerFulfillmentOrderId = sellerFulfillmentOrderId_example;  // string | The identifier assigned to the item by the seller when the fulfillment order was created.

            try
            {
                GetFulfillmentOrderResponse result = apiInstance.GetFulfillmentOrder(sellerFulfillmentOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.GetFulfillmentOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sellerFulfillmentOrderId** | **string**| The identifier assigned to the item by the seller when the fulfillment order was created. | 

### Return type

[**GetFulfillmentOrderResponse**](GetFulfillmentOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentpreview"></a>
# **GetFulfillmentPreview**
> GetFulfillmentPreviewResponse GetFulfillmentPreview (GetFulfillmentPreviewRequest body)



Returns a list of fulfillment order previews based on shipping criteria that you specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class GetFulfillmentPreviewExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var body = new GetFulfillmentPreviewRequest(); // GetFulfillmentPreviewRequest | GetFulfillmentPreviewRequest parameter

            try
            {
                GetFulfillmentPreviewResponse result = apiInstance.GetFulfillmentPreview(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.GetFulfillmentPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetFulfillmentPreviewRequest**](GetFulfillmentPreviewRequest.md)| GetFulfillmentPreviewRequest parameter | 

### Return type

[**GetFulfillmentPreviewResponse**](GetFulfillmentPreviewResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackagetrackingdetails"></a>
# **GetPackageTrackingDetails**
> GetPackageTrackingDetailsResponse GetPackageTrackingDetails (int? packageNumber)



Returns delivery tracking information for a package in an outbound shipment for a Multi-Channel Fulfillment order.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class GetPackageTrackingDetailsExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var packageNumber = 56;  // int? | The unencrypted package identifier. You can obtain this value from the `getFulfillmentOrder` operation.

            try
            {
                GetPackageTrackingDetailsResponse result = apiInstance.GetPackageTrackingDetails(packageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.GetPackageTrackingDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageNumber** | **int?**| The unencrypted package identifier. You can obtain this value from the &#x60;getFulfillmentOrder&#x60; operation. | 

### Return type

[**GetPackageTrackingDetailsResponse**](GetPackageTrackingDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallfulfillmentorders"></a>
# **ListAllFulfillmentOrders**
> ListAllFulfillmentOrdersResponse ListAllFulfillmentOrders (DateTime? queryStartDate = null, string nextToken = null)



Returns a list of fulfillment orders fulfilled after (or at) a specified date-time, or indicated by the `nextToken` parameter.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class ListAllFulfillmentOrdersExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var queryStartDate = 2013-10-20T19:20:30+01:00;  // DateTime? | A date used to select fulfillment orders that were last updated after (or at) a specified time. An update is defined as any change in fulfillment order status, including the creation of a new fulfillment order. (optional) 
            var nextToken = nextToken_example;  // string | A string token returned in the response to your previous request. (optional) 

            try
            {
                ListAllFulfillmentOrdersResponse result = apiInstance.ListAllFulfillmentOrders(queryStartDate, nextToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.ListAllFulfillmentOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryStartDate** | **DateTime?**| A date used to select fulfillment orders that were last updated after (or at) a specified time. An update is defined as any change in fulfillment order status, including the creation of a new fulfillment order. | [optional] 
 **nextToken** | **string**| A string token returned in the response to your previous request. | [optional] 

### Return type

[**ListAllFulfillmentOrdersResponse**](ListAllFulfillmentOrdersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listreturnreasoncodes"></a>
# **ListReturnReasonCodes**
> ListReturnReasonCodesResponse ListReturnReasonCodes (string sellerSku, string marketplaceId = null, string sellerFulfillmentOrderId = null, string language = null)



Returns a list of return reason codes for a seller SKU in a given marketplace. The parameters for this operation may contain special characters that require URL encoding. To avoid errors with SKUs when encoding URLs, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class ListReturnReasonCodesExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var sellerSku = sellerSku_example;  // string | The seller SKU for which return reason codes are required.
            var marketplaceId = marketplaceId_example;  // string | The marketplace for which the seller wants return reason codes. (optional) 
            var sellerFulfillmentOrderId = sellerFulfillmentOrderId_example;  // string | The identifier assigned to the item by the seller when the fulfillment order was created. The service uses this value to determine the marketplace for which the seller wants return reason codes. (optional) 
            var language = language_example;  // string | The language that the `TranslatedDescription` property of the `ReasonCodeDetails` response object should be translated into. (optional) 

            try
            {
                ListReturnReasonCodesResponse result = apiInstance.ListReturnReasonCodes(sellerSku, marketplaceId, sellerFulfillmentOrderId, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.ListReturnReasonCodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sellerSku** | **string**| The seller SKU for which return reason codes are required. | 
 **marketplaceId** | **string**| The marketplace for which the seller wants return reason codes. | [optional] 
 **sellerFulfillmentOrderId** | **string**| The identifier assigned to the item by the seller when the fulfillment order was created. The service uses this value to determine the marketplace for which the seller wants return reason codes. | [optional] 
 **language** | **string**| The language that the &#x60;TranslatedDescription&#x60; property of the &#x60;ReasonCodeDetails&#x60; response object should be translated into. | [optional] 

### Return type

[**ListReturnReasonCodesResponse**](ListReturnReasonCodesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitfulfillmentorderstatusupdate"></a>
# **SubmitFulfillmentOrderStatusUpdate**
> SubmitFulfillmentOrderStatusUpdateResponse SubmitFulfillmentOrderStatusUpdate (string sellerFulfillmentOrderId, SubmitFulfillmentOrderStatusUpdateRequest body)



Requests that Amazon update the status of an order in the sandbox testing environment. This is a sandbox-only operation and must be directed to a sandbox endpoint. Refer to [Fulfillment Outbound Dynamic Sandbox Guide](https://developer-docs.amazon.com/sp-api/docs/fulfillment-outbound-dynamic-sandbox-guide) and [Selling Partner API sandbox](https://developer-docs.amazon.com/sp-api/docs/the-selling-partner-api-sandbox) for more information.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class SubmitFulfillmentOrderStatusUpdateExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var sellerFulfillmentOrderId = sellerFulfillmentOrderId_example;  // string | The identifier assigned to the item by the seller when the fulfillment order was created.
            var body = new SubmitFulfillmentOrderStatusUpdateRequest(); // SubmitFulfillmentOrderStatusUpdateRequest | The identifier assigned to the item by the seller when the fulfillment order was created.

            try
            {
                SubmitFulfillmentOrderStatusUpdateResponse result = apiInstance.SubmitFulfillmentOrderStatusUpdate(sellerFulfillmentOrderId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.SubmitFulfillmentOrderStatusUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sellerFulfillmentOrderId** | **string**| The identifier assigned to the item by the seller when the fulfillment order was created. | 
 **body** | [**SubmitFulfillmentOrderStatusUpdateRequest**](SubmitFulfillmentOrderStatusUpdateRequest.md)| The identifier assigned to the item by the seller when the fulfillment order was created. | 

### Return type

[**SubmitFulfillmentOrderStatusUpdateResponse**](SubmitFulfillmentOrderStatusUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefulfillmentorder"></a>
# **UpdateFulfillmentOrder**
> UpdateFulfillmentOrderResponse UpdateFulfillmentOrder (UpdateFulfillmentOrderRequest body, string sellerFulfillmentOrderId)



Updates and/or requests shipment for a fulfillment order with an order hold on it.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Example
{
    public class UpdateFulfillmentOrderExample
    {
        public void main()
        {
            var apiInstance = new FbaOutboundApi();
            var body = new UpdateFulfillmentOrderRequest(); // UpdateFulfillmentOrderRequest | The request body of the `updateFulfillmentOrder` operation.
            var sellerFulfillmentOrderId = sellerFulfillmentOrderId_example;  // string | The identifier assigned to the item by the seller when the fulfillment order was created.

            try
            {
                UpdateFulfillmentOrderResponse result = apiInstance.UpdateFulfillmentOrder(body, sellerFulfillmentOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaOutboundApi.UpdateFulfillmentOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateFulfillmentOrderRequest**](UpdateFulfillmentOrderRequest.md)| The request body of the &#x60;updateFulfillmentOrder&#x60; operation. | 
 **sellerFulfillmentOrderId** | **string**| The identifier assigned to the item by the seller when the fulfillment order was created. | 

### Return type

[**UpdateFulfillmentOrderResponse**](UpdateFulfillmentOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

