# Amazon.SellingPartnerAPIAA.Clients.API.FeesApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMyFeesEstimateForASIN**](FeesApi.md#getmyfeesestimateforasin) | **POST** /products/fees/v0/items/{Asin}/feesEstimate | 
[**GetMyFeesEstimateForSKU**](FeesApi.md#getmyfeesestimateforsku) | **POST** /products/fees/v0/listings/{SellerSKU}/feesEstimate | 
[**GetMyFeesEstimates**](FeesApi.md#getmyfeesestimates) | **POST** /products/fees/v0/feesEstimate | 


<a name="getmyfeesestimateforasin"></a>
# **GetMyFeesEstimateForASIN**
> GetMyFeesEstimateResponse GetMyFeesEstimateForASIN (GetMyFeesEstimateRequest body, string asin)



Returns the estimated fees for the item indicated by the specified ASIN in the marketplace specified in the request body.  You can call `getMyFeesEstimateForASIN` for an item on behalf of a selling partner before the selling partner sets the item's price. The selling partner can then take estimated fees into account. Each fees request must include an original identifier. This identifier is included in the fees estimate so you can correlate a fees estimate with the original request.  **Note:** This identifier value is used to identify an estimate. Actual costs may vary. Search \"fees\" in [Seller Central](https://sellercentral.amazon.com/) and consult the store-specific fee schedule for the most up-to-date information.  **Note:** When using the `getMyFeesEstimateForASIN` operation with an ASIN, the fee estimates might be different. This is because these estimates use the item's catalog size, which might not always match the actual size of the item sent to Amazon.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ProductFees;

namespace Example
{
    public class GetMyFeesEstimateForASINExample
    {
        public void main()
        {
            var apiInstance = new FeesApi();
            var body = new GetMyFeesEstimateRequest(); // GetMyFeesEstimateRequest | The request body schema for the getMyFeesEstimates operation
            var asin = asin_example;  // string | The Amazon Standard Identification Number (ASIN) of the item.

            try
            {
                GetMyFeesEstimateResponse result = apiInstance.GetMyFeesEstimateForASIN(body, asin);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GetMyFeesEstimateForASIN: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetMyFeesEstimateRequest**](GetMyFeesEstimateRequest.md)| The request body schema for the getMyFeesEstimates operation | 
 **asin** | **string**| The Amazon Standard Identification Number (ASIN) of the item. | 

### Return type

[**GetMyFeesEstimateResponse**](GetMyFeesEstimateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmyfeesestimateforsku"></a>
# **GetMyFeesEstimateForSKU**
> GetMyFeesEstimateResponse GetMyFeesEstimateForSKU (GetMyFeesEstimateRequest body, string sellerSKU)



Returns the estimated fees for the item indicated by the specified seller SKU in the marketplace specified in the request body.  **Note:** The parameters associated with this operation may contain special characters that require URL encoding to call the API. To avoid errors with SKUs when encoding URLs, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).  You can call `getMyFeesEstimateForSKU` for an item on behalf of a selling partner before the selling partner sets the item's price. The selling partner can then take any estimated fees into account. Each fees estimate request must include an original identifier. This identifier is included in the fees estimate so that you can correlate a fees estimate with the original request.  **Note:** This identifier value is used to identify an estimate. Actual costs may vary. Search \"fees\" in [Seller Central](https://sellercentral.amazon.com/) and consult the store-specific fee schedule for the most up-to-date information.  **Note:** When sellers use the `getMyFeesEstimateForSKU` operation with their `SellerSKU`, they get accurate fees based on real item measurements, but only after they've sent their items to Amazon.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ProductFees;

namespace Example
{
    public class GetMyFeesEstimateForSKUExample
    {
        public void main()
        {
            var apiInstance = new FeesApi();
            var body = new GetMyFeesEstimateRequest(); // GetMyFeesEstimateRequest | The request body schema for the getMyFeesEstimates operation
            var sellerSKU = sellerSKU_example;  // string | Used to identify an item in the given marketplace. SellerSKU is qualified by the seller's SellerId, which is included with every operation that you submit.

            try
            {
                GetMyFeesEstimateResponse result = apiInstance.GetMyFeesEstimateForSKU(body, sellerSKU);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GetMyFeesEstimateForSKU: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetMyFeesEstimateRequest**](GetMyFeesEstimateRequest.md)| The request body schema for the getMyFeesEstimates operation | 
 **sellerSKU** | **string**| Used to identify an item in the given marketplace. SellerSKU is qualified by the seller&#39;s SellerId, which is included with every operation that you submit. | 

### Return type

[**GetMyFeesEstimateResponse**](GetMyFeesEstimateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmyfeesestimates"></a>
# **GetMyFeesEstimates**
> GetMyFeesEstimatesResponse GetMyFeesEstimates (GetMyFeesEstimatesRequest body)



Returns the estimated fees for a list of products.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 0.5 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ProductFees;

namespace Example
{
    public class GetMyFeesEstimatesExample
    {
        public void main()
        {
            var apiInstance = new FeesApi();
            var body = new GetMyFeesEstimatesRequest(); // GetMyFeesEstimatesRequest | The request body schema for the getMyFeesEstimates operation

            try
            {
                GetMyFeesEstimatesResponse result = apiInstance.GetMyFeesEstimates(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GetMyFeesEstimates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetMyFeesEstimatesRequest**](GetMyFeesEstimatesRequest.md)| The request body schema for the getMyFeesEstimates operation | 

### Return type

[**GetMyFeesEstimatesResponse**](GetMyFeesEstimatesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

