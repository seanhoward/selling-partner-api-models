# Amazon.SellingPartnerAPIAA.Clients.API.CreateContainerLabelApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateContainerLabel**](CreateContainerLabelApi.md#createcontainerlabel) | **POST** /vendor/directFulfillment/shipping/2021-12-28/containerLabel | createContainerLabel


<a name="createcontainerlabel"></a>
# **CreateContainerLabel**
> CreateContainerLabelResponse CreateContainerLabel (CreateContainerLabelRequest body)

createContainerLabel

Creates a container (pallet) label for the associated shipment package.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping;

namespace Example
{
    public class CreateContainerLabelExample
    {
        public void main()
        {
            var apiInstance = new CreateContainerLabelApi();
            var body = new CreateContainerLabelRequest(); // CreateContainerLabelRequest | Request body containing the container label data.

            try
            {
                // createContainerLabel
                CreateContainerLabelResponse result = apiInstance.CreateContainerLabel(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreateContainerLabelApi.CreateContainerLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateContainerLabelRequest**](CreateContainerLabelRequest.md)| Request body containing the container label data. | 

### Return type

[**CreateContainerLabelResponse**](CreateContainerLabelResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

