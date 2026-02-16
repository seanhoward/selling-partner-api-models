# Amazon.SellingPartnerAPIAA.Clients.API.AplusContentApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateContentDocument**](AplusContentApi.md#createcontentdocument) | **POST** /aplus/2020-11-01/contentDocuments | 
[**GetContentDocument**](AplusContentApi.md#getcontentdocument) | **GET** /aplus/2020-11-01/contentDocuments/{contentReferenceKey} | 
[**ListContentDocumentAsinRelations**](AplusContentApi.md#listcontentdocumentasinrelations) | **GET** /aplus/2020-11-01/contentDocuments/{contentReferenceKey}/asins | 
[**PostContentDocumentApprovalSubmission**](AplusContentApi.md#postcontentdocumentapprovalsubmission) | **POST** /aplus/2020-11-01/contentDocuments/{contentReferenceKey}/approvalSubmissions | 
[**PostContentDocumentAsinRelations**](AplusContentApi.md#postcontentdocumentasinrelations) | **POST** /aplus/2020-11-01/contentDocuments/{contentReferenceKey}/asins | 
[**PostContentDocumentSuspendSubmission**](AplusContentApi.md#postcontentdocumentsuspendsubmission) | **POST** /aplus/2020-11-01/contentDocuments/{contentReferenceKey}/suspendSubmissions | 
[**SearchContentDocuments**](AplusContentApi.md#searchcontentdocuments) | **GET** /aplus/2020-11-01/contentDocuments | 
[**SearchContentPublishRecords**](AplusContentApi.md#searchcontentpublishrecords) | **GET** /aplus/2020-11-01/contentPublishRecords | 
[**UpdateContentDocument**](AplusContentApi.md#updatecontentdocument) | **POST** /aplus/2020-11-01/contentDocuments/{contentReferenceKey} | 
[**ValidateContentDocumentAsinRelations**](AplusContentApi.md#validatecontentdocumentasinrelations) | **POST** /aplus/2020-11-01/contentAsinValidations | 


<a name="createcontentdocument"></a>
# **CreateContentDocument**
> PostContentDocumentResponse CreateContentDocument (string marketplaceId, PostContentDocumentRequest postContentDocumentRequest)



Creates a new A+ Content document.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent;

namespace Example
{
    public class CreateContentDocumentExample
    {
        public void main()
        {
            var apiInstance = new AplusContentApi();
            var marketplaceId = marketplaceId_example;  // string | The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var postContentDocumentRequest = new PostContentDocumentRequest(); // PostContentDocumentRequest | The content document request details.

            try
            {
                PostContentDocumentResponse result = apiInstance.CreateContentDocument(marketplaceId, postContentDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AplusContentApi.CreateContentDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **postContentDocumentRequest** | [**PostContentDocumentRequest**](PostContentDocumentRequest.md)| The content document request details. | 

### Return type

[**PostContentDocumentResponse**](PostContentDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentdocument"></a>
# **GetContentDocument**
> GetContentDocumentResponse GetContentDocument (string contentReferenceKey, string marketplaceId, List<string> includedDataSet)



Returns an A+ Content document, if available.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent;

namespace Example
{
    public class GetContentDocumentExample
    {
        public void main()
        {
            var apiInstance = new AplusContentApi();
            var contentReferenceKey = contentReferenceKey_example;  // string | The unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ Content identifier.
            var marketplaceId = marketplaceId_example;  // string | The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var includedDataSet = includedDataSet_example;  // List<string> | The set of A+ Content data types to include in the response.

            try
            {
                GetContentDocumentResponse result = apiInstance.GetContentDocument(contentReferenceKey, marketplaceId, includedDataSet);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AplusContentApi.GetContentDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentReferenceKey** | **string**| The unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ Content identifier. | 
 **marketplaceId** | **string**| The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **includedDataSet** | **List&lt;string&gt;**| The set of A+ Content data types to include in the response. | 

### Return type

[**GetContentDocumentResponse**](GetContentDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcontentdocumentasinrelations"></a>
# **ListContentDocumentAsinRelations**
> ListContentDocumentAsinRelationsResponse ListContentDocumentAsinRelations (string contentReferenceKey, string marketplaceId, List<string> includedDataSet = null, List<string> asinSet = null, string pageToken = null)



Returns a list of ASINs that are related to the specified A+ Content document, if available. If you don't include the `asinSet` parameter, this operation returns all ASINs related to the content document.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent;

namespace Example
{
    public class ListContentDocumentAsinRelationsExample
    {
        public void main()
        {
            var apiInstance = new AplusContentApi();
            var contentReferenceKey = contentReferenceKey_example;  // string | The unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ Content identifier.
            var marketplaceId = marketplaceId_example;  // string | The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var includedDataSet = includedDataSet_example;  // List<string> | The set of A+ Content data types to include in the response. If you don't include this parameter, the operation returns the related ASINs without metadata. (optional) 
            var asinSet = new List<string>(); // List<string> | The set of ASINs. (optional) 
            var pageToken = pageToken_example;  // string | A token that you use to fetch a specific page when there are multiple pages of results. (optional) 

            try
            {
                ListContentDocumentAsinRelationsResponse result = apiInstance.ListContentDocumentAsinRelations(contentReferenceKey, marketplaceId, includedDataSet, asinSet, pageToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AplusContentApi.ListContentDocumentAsinRelations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentReferenceKey** | **string**| The unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ Content identifier. | 
 **marketplaceId** | **string**| The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **includedDataSet** | **List&lt;string&gt;**| The set of A+ Content data types to include in the response. If you don&#39;t include this parameter, the operation returns the related ASINs without metadata. | [optional] 
 **asinSet** | [**List&lt;string&gt;**](string.md)| The set of ASINs. | [optional] 
 **pageToken** | **string**| A token that you use to fetch a specific page when there are multiple pages of results. | [optional] 

### Return type

[**ListContentDocumentAsinRelationsResponse**](ListContentDocumentAsinRelationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcontentdocumentapprovalsubmission"></a>
# **PostContentDocumentApprovalSubmission**
> PostContentDocumentApprovalSubmissionResponse PostContentDocumentApprovalSubmission (string contentReferenceKey, string marketplaceId)



Submits an A+ Content document for review, approval, and publishing.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent;

namespace Example
{
    public class PostContentDocumentApprovalSubmissionExample
    {
        public void main()
        {
            var apiInstance = new AplusContentApi();
            var contentReferenceKey = contentReferenceKey_example;  // string | The unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ content identifier.
            var marketplaceId = marketplaceId_example;  // string | The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                PostContentDocumentApprovalSubmissionResponse result = apiInstance.PostContentDocumentApprovalSubmission(contentReferenceKey, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AplusContentApi.PostContentDocumentApprovalSubmission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentReferenceKey** | **string**| The unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ content identifier. | 
 **marketplaceId** | **string**| The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 

### Return type

[**PostContentDocumentApprovalSubmissionResponse**](PostContentDocumentApprovalSubmissionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcontentdocumentasinrelations"></a>
# **PostContentDocumentAsinRelations**
> PostContentDocumentAsinRelationsResponse PostContentDocumentAsinRelations (string contentReferenceKey, string marketplaceId, PostContentDocumentAsinRelationsRequest postContentDocumentAsinRelationsRequest)



Replaces all ASINs related to the specified A+ Content document, if available. This operation can add or remove ASINs, depending on the current set of related ASINs. Removing an ASIN will suspend the content document from that ASIN.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent;

namespace Example
{
    public class PostContentDocumentAsinRelationsExample
    {
        public void main()
        {
            var apiInstance = new AplusContentApi();
            var contentReferenceKey = contentReferenceKey_example;  // string | The unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ content identifier.
            var marketplaceId = marketplaceId_example;  // string | The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var postContentDocumentAsinRelationsRequest = new PostContentDocumentAsinRelationsRequest(); // PostContentDocumentAsinRelationsRequest | The request details for the content document ASIN relations.

            try
            {
                PostContentDocumentAsinRelationsResponse result = apiInstance.PostContentDocumentAsinRelations(contentReferenceKey, marketplaceId, postContentDocumentAsinRelationsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AplusContentApi.PostContentDocumentAsinRelations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentReferenceKey** | **string**| The unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ content identifier. | 
 **marketplaceId** | **string**| The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **postContentDocumentAsinRelationsRequest** | [**PostContentDocumentAsinRelationsRequest**](PostContentDocumentAsinRelationsRequest.md)| The request details for the content document ASIN relations. | 

### Return type

[**PostContentDocumentAsinRelationsResponse**](PostContentDocumentAsinRelationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcontentdocumentsuspendsubmission"></a>
# **PostContentDocumentSuspendSubmission**
> PostContentDocumentSuspendSubmissionResponse PostContentDocumentSuspendSubmission (string contentReferenceKey, string marketplaceId)



Submits a request to suspend visible A+ Content. This doesn't delete the content document or the ASIN relations.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent;

namespace Example
{
    public class PostContentDocumentSuspendSubmissionExample
    {
        public void main()
        {
            var apiInstance = new AplusContentApi();
            var contentReferenceKey = contentReferenceKey_example;  // string | The unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ content identifier.
            var marketplaceId = marketplaceId_example;  // string | The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                PostContentDocumentSuspendSubmissionResponse result = apiInstance.PostContentDocumentSuspendSubmission(contentReferenceKey, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AplusContentApi.PostContentDocumentSuspendSubmission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentReferenceKey** | **string**| The unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ content identifier. | 
 **marketplaceId** | **string**| The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 

### Return type

[**PostContentDocumentSuspendSubmissionResponse**](PostContentDocumentSuspendSubmissionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcontentdocuments"></a>
# **SearchContentDocuments**
> SearchContentDocumentsResponse SearchContentDocuments (string marketplaceId, string pageToken = null)



Returns a list of all A+ Content documents, including metadata, that are assigned to a selling partner. To get the actual contents of the A+ Content documents, call the `getContentDocument` operation.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent;

namespace Example
{
    public class SearchContentDocumentsExample
    {
        public void main()
        {
            var apiInstance = new AplusContentApi();
            var marketplaceId = marketplaceId_example;  // string | The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var pageToken = pageToken_example;  // string | A token that you use to fetch a specific page when there are multiple pages of results. (optional) 

            try
            {
                SearchContentDocumentsResponse result = apiInstance.SearchContentDocuments(marketplaceId, pageToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AplusContentApi.SearchContentDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **pageToken** | **string**| A token that you use to fetch a specific page when there are multiple pages of results. | [optional] 

### Return type

[**SearchContentDocumentsResponse**](SearchContentDocumentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcontentpublishrecords"></a>
# **SearchContentPublishRecords**
> SearchContentPublishRecordsResponse SearchContentPublishRecords (string marketplaceId, string asin, string pageToken = null)



Searches for A+ Content publishing records, if available.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent;

namespace Example
{
    public class SearchContentPublishRecordsExample
    {
        public void main()
        {
            var apiInstance = new AplusContentApi();
            var marketplaceId = marketplaceId_example;  // string | The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var asin = asin_example;  // string | The Amazon Standard Identification Number (ASIN) is the unique identifier of a product within a marketplace.
            var pageToken = pageToken_example;  // string | A token that you use to fetch a specific page when there are multiple pages of results. (optional) 

            try
            {
                SearchContentPublishRecordsResponse result = apiInstance.SearchContentPublishRecords(marketplaceId, asin, pageToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AplusContentApi.SearchContentPublishRecords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **asin** | **string**| The Amazon Standard Identification Number (ASIN) is the unique identifier of a product within a marketplace. | 
 **pageToken** | **string**| A token that you use to fetch a specific page when there are multiple pages of results. | [optional] 

### Return type

[**SearchContentPublishRecordsResponse**](SearchContentPublishRecordsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontentdocument"></a>
# **UpdateContentDocument**
> PostContentDocumentResponse UpdateContentDocument (string contentReferenceKey, string marketplaceId, PostContentDocumentRequest postContentDocumentRequest)



Updates an existing A+ Content document.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent;

namespace Example
{
    public class UpdateContentDocumentExample
    {
        public void main()
        {
            var apiInstance = new AplusContentApi();
            var contentReferenceKey = contentReferenceKey_example;  // string | The unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ Content identifier.
            var marketplaceId = marketplaceId_example;  // string | The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var postContentDocumentRequest = new PostContentDocumentRequest(); // PostContentDocumentRequest | The content document request details.

            try
            {
                PostContentDocumentResponse result = apiInstance.UpdateContentDocument(contentReferenceKey, marketplaceId, postContentDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AplusContentApi.UpdateContentDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentReferenceKey** | **string**| The unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ Content identifier. | 
 **marketplaceId** | **string**| The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **postContentDocumentRequest** | [**PostContentDocumentRequest**](PostContentDocumentRequest.md)| The content document request details. | 

### Return type

[**PostContentDocumentResponse**](PostContentDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatecontentdocumentasinrelations"></a>
# **ValidateContentDocumentAsinRelations**
> ValidateContentDocumentAsinRelationsResponse ValidateContentDocumentAsinRelations (string marketplaceId, PostContentDocumentRequest postContentDocumentRequest, List<string> asinSet = null)



Checks if the A+ Content document is valid for use on a set of ASINs.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent;

namespace Example
{
    public class ValidateContentDocumentAsinRelationsExample
    {
        public void main()
        {
            var apiInstance = new AplusContentApi();
            var marketplaceId = marketplaceId_example;  // string | The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var postContentDocumentRequest = new PostContentDocumentRequest(); // PostContentDocumentRequest | The content document request details.
            var asinSet = new List<string>(); // List<string> | The set of ASINs. (optional) 

            try
            {
                ValidateContentDocumentAsinRelationsResponse result = apiInstance.ValidateContentDocumentAsinRelations(marketplaceId, postContentDocumentRequest, asinSet);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AplusContentApi.ValidateContentDocumentAsinRelations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| The marketplace ID is the globally unique identifier of a marketplace. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **postContentDocumentRequest** | [**PostContentDocumentRequest**](PostContentDocumentRequest.md)| The content document request details. | 
 **asinSet** | [**List&lt;string&gt;**](string.md)| The set of ASINs. | [optional] 

### Return type

[**ValidateContentDocumentAsinRelationsResponse**](ValidateContentDocumentAsinRelationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

