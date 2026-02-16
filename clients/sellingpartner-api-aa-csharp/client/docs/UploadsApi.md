# Amazon.SellingPartnerAPIAA.Clients.API.UploadsApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUploadDestinationForResource**](UploadsApi.md#createuploaddestinationforresource) | **POST** /uploads/2020-11-01/uploadDestinations/{resource} | 


<a name="createuploaddestinationforresource"></a>
# **CreateUploadDestinationForResource**
> CreateUploadDestinationResponse CreateUploadDestinationForResource (List<string> marketplaceIds, string contentMD5, string resource, string contentType = null)



Creates an upload destination, returning the information required to upload a file to the destination and to programmatically access the file.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Uploads;

namespace Example
{
    public class CreateUploadDestinationForResourceExample
    {
        public void main()
        {
            var apiInstance = new UploadsApi();
            var marketplaceIds = new List<string>(); // List<string> | The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var contentMD5 = contentMD5_example;  // string | An MD5 hash of the content to be submitted to the upload destination. This value is used to determine if the data has been corrupted or tampered with during transit.
            var resource = resource_example;  // string | The upload destination for your resource. For example, if you create an upload destination for the `createLegalDisclosure` operation of the Messaging API, the `{resource}` would be `/messaging/v1/orders/{amazonOrderId}/messages/legalDisclosure`, and the entire path would be `/uploads/2020-11-01/uploadDestinations/messaging/v1/orders/{amazonOrderId}/messages/legalDisclosure`. If you create an upload destination for an Aplus content document, the `{resource}` would be `aplus/2020-11-01/contentDocuments` and the path would be `/uploads/2020-11-01/uploadDestinations/aplus/2020-11-01/contentDocuments`.
            var contentType = contentType_example;  // string | The content type of the file you upload. (optional) 

            try
            {
                CreateUploadDestinationResponse result = apiInstance.CreateUploadDestinationForResource(marketplaceIds, contentMD5, resource, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.CreateUploadDestinationForResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **contentMD5** | **string**| An MD5 hash of the content to be submitted to the upload destination. This value is used to determine if the data has been corrupted or tampered with during transit. | 
 **resource** | **string**| The upload destination for your resource. For example, if you create an upload destination for the &#x60;createLegalDisclosure&#x60; operation of the Messaging API, the &#x60;{resource}&#x60; would be &#x60;/messaging/v1/orders/{amazonOrderId}/messages/legalDisclosure&#x60;, and the entire path would be &#x60;/uploads/2020-11-01/uploadDestinations/messaging/v1/orders/{amazonOrderId}/messages/legalDisclosure&#x60;. If you create an upload destination for an Aplus content document, the &#x60;{resource}&#x60; would be &#x60;aplus/2020-11-01/contentDocuments&#x60; and the path would be &#x60;/uploads/2020-11-01/uploadDestinations/aplus/2020-11-01/contentDocuments&#x60;. | 
 **contentType** | **string**| The content type of the file you upload. | [optional] 

### Return type

[**CreateUploadDestinationResponse**](CreateUploadDestinationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

