# Amazon.SellingPartnerAPIAA.Clients.API.FeedsApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelFeed**](FeedsApi.md#cancelfeed) | **DELETE** /feeds/2021-06-30/feeds/{feedId} | cancelFeed
[**CreateFeed**](FeedsApi.md#createfeed) | **POST** /feeds/2021-06-30/feeds | createFeed
[**CreateFeedDocument**](FeedsApi.md#createfeeddocument) | **POST** /feeds/2021-06-30/documents | createFeedDocument
[**GetFeed**](FeedsApi.md#getfeed) | **GET** /feeds/2021-06-30/feeds/{feedId} | getFeed
[**GetFeedDocument**](FeedsApi.md#getfeeddocument) | **GET** /feeds/2021-06-30/documents/{feedDocumentId} | getFeedDocument
[**GetFeeds**](FeedsApi.md#getfeeds) | **GET** /feeds/2021-06-30/feeds | getFeeds


<a name="cancelfeed"></a>
# **CancelFeed**
> void CancelFeed (string feedId)

cancelFeed

Cancels the feed that you specify. Only feeds with `processingStatus=IN_QUEUE` can be cancelled. Cancelled feeds are returned in subsequent calls to the [`getFeed`](https://developer-docs.amazon.com/sp-api/docs/feeds-api-v2021-06-30-reference#getfeed) and [`getFeeds`](https://developer-docs.amazon.com/sp-api/docs/feeds-api-v2021-06-30-reference#getfeeds) operations.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Feeds;

namespace Example
{
    public class CancelFeedExample
    {
        public void main()
        {
            var apiInstance = new FeedsApi();
            var feedId = feedId_example;  // string | The identifier for the feed. This identifier is unique only in combination with a seller ID.

            try
            {
                // cancelFeed
                apiInstance.CancelFeed(feedId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedsApi.CancelFeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **feedId** | **string**| The identifier for the feed. This identifier is unique only in combination with a seller ID. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfeed"></a>
# **CreateFeed**
> CreateFeedResponse CreateFeed (CreateFeedSpecification body)

createFeed

Creates a feed. Upload the contents of the feed document before calling this operation.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 0.0083 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).  The rate limit for the [`JSON_LISTINGS_FEED`](https://developer-docs.amazon.com/sp-api/docs/listings-feed-type-values#listings-feed) feed type differs from the rate limit for the [`createFeed`](https://developer-docs.amazon.com/sp-api/docs/feeds-api-v2021-06-30-reference#post-feeds2021-06-30feeds) operation. For more information, refer to the [Building Listings Management Workflows Guide](https://developer-docs.amazon.com/sp-api/docs/building-listings-management-workflows-guide#should-i-submit-in-bulk-using-the-json_listings_feed-or-individually-with-the-listings-items-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Feeds;

namespace Example
{
    public class CreateFeedExample
    {
        public void main()
        {
            var apiInstance = new FeedsApi();
            var body = new CreateFeedSpecification(); // CreateFeedSpecification | Information required to create the feed.

            try
            {
                // createFeed
                CreateFeedResponse result = apiInstance.CreateFeed(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedsApi.CreateFeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateFeedSpecification**](CreateFeedSpecification.md)| Information required to create the feed. | 

### Return type

[**CreateFeedResponse**](CreateFeedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfeeddocument"></a>
# **CreateFeedDocument**
> CreateFeedDocumentResponse CreateFeedDocument (CreateFeedDocumentSpecification body)

createFeedDocument

Creates a feed document for the feed type that you specify. This operation returns a presigned URL for uploading the feed document contents. It also returns a `feedDocumentId` value that you can pass in with a subsequent call to the [`createFeed`](https://developer-docs.amazon.com/sp-api/docs/feeds-api-v2021-06-30-reference#createfeed) operation.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 0.5 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Feeds;

namespace Example
{
    public class CreateFeedDocumentExample
    {
        public void main()
        {
            var apiInstance = new FeedsApi();
            var body = new CreateFeedDocumentSpecification(); // CreateFeedDocumentSpecification | Specifies the content type for the createFeedDocument operation.

            try
            {
                // createFeedDocument
                CreateFeedDocumentResponse result = apiInstance.CreateFeedDocument(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedsApi.CreateFeedDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateFeedDocumentSpecification**](CreateFeedDocumentSpecification.md)| Specifies the content type for the createFeedDocument operation. | 

### Return type

[**CreateFeedDocumentResponse**](CreateFeedDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeed"></a>
# **GetFeed**
> Feed GetFeed (string feedId)

getFeed

Returns feed details (including the `resultDocumentId`, if available) for the feed that you specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Feeds;

namespace Example
{
    public class GetFeedExample
    {
        public void main()
        {
            var apiInstance = new FeedsApi();
            var feedId = feedId_example;  // string | The identifier for the feed. This identifier is unique only in combination with a seller ID.

            try
            {
                // getFeed
                Feed result = apiInstance.GetFeed(feedId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedsApi.GetFeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **feedId** | **string**| The identifier for the feed. This identifier is unique only in combination with a seller ID. | 

### Return type

[**Feed**](Feed.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeeddocument"></a>
# **GetFeedDocument**
> FeedDocument GetFeedDocument (string feedDocumentId)

getFeedDocument

Returns the information required for retrieving a feed document's contents.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Feeds;

namespace Example
{
    public class GetFeedDocumentExample
    {
        public void main()
        {
            var apiInstance = new FeedsApi();
            var feedDocumentId = feedDocumentId_example;  // string | The identifier of the feed document.

            try
            {
                // getFeedDocument
                FeedDocument result = apiInstance.GetFeedDocument(feedDocumentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedsApi.GetFeedDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **feedDocumentId** | **string**| The identifier of the feed document. | 

### Return type

[**FeedDocument**](FeedDocument.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeeds"></a>
# **GetFeeds**
> GetFeedsResponse GetFeeds (List<string> feedTypes = null, List<string> marketplaceIds = null, int? pageSize = null, List<string> processingStatuses = null, DateTime? createdSince = null, DateTime? createdUntil = null, string nextToken = null)

getFeeds

Returns feed details for the feeds that match the filters that you specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Feeds;

namespace Example
{
    public class GetFeedsExample
    {
        public void main()
        {
            var apiInstance = new FeedsApi();
            var feedTypes = new List<string>(); // List<string> | A list of feed types used to filter feeds. When feedTypes is provided, the other filter parameters (processingStatuses, marketplaceIds, createdSince, createdUntil) and pageSize may also be provided. Either feedTypes or nextToken is required. (optional) 
            var marketplaceIds = new List<string>(); // List<string> | A list of marketplace identifiers used to filter feeds. The feeds returned will match at least one of the marketplaces that you specify. (optional) 
            var pageSize = 56;  // int? | The maximum number of feeds to return in a single call. (optional)  (default to 10)
            var processingStatuses = processingStatuses_example;  // List<string> | A list of processing statuses used to filter feeds. (optional) 
            var createdSince = 2013-10-20T19:20:30+01:00;  // DateTime? | The earliest feed creation date and time for feeds included in the response, in ISO 8601 format. The default is 90 days ago. Feeds are retained for a maximum of 90 days. (optional) 
            var createdUntil = 2013-10-20T19:20:30+01:00;  // DateTime? | The latest feed creation date and time for feeds included in the response, in ISO 8601 format. The default is now. (optional) 
            var nextToken = nextToken_example;  // string | A string token returned in the response to your previous request. nextToken is returned when the number of results exceeds the specified pageSize value. To get the next page of results, call the getFeeds operation and include this token as the only parameter. Specifying nextToken with any other parameters will cause the request to fail. (optional) 

            try
            {
                // getFeeds
                GetFeedsResponse result = apiInstance.GetFeeds(feedTypes, marketplaceIds, pageSize, processingStatuses, createdSince, createdUntil, nextToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedsApi.GetFeeds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **feedTypes** | [**List&lt;string&gt;**](string.md)| A list of feed types used to filter feeds. When feedTypes is provided, the other filter parameters (processingStatuses, marketplaceIds, createdSince, createdUntil) and pageSize may also be provided. Either feedTypes or nextToken is required. | [optional] 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A list of marketplace identifiers used to filter feeds. The feeds returned will match at least one of the marketplaces that you specify. | [optional] 
 **pageSize** | **int?**| The maximum number of feeds to return in a single call. | [optional] [default to 10]
 **processingStatuses** | **List&lt;string&gt;**| A list of processing statuses used to filter feeds. | [optional] 
 **createdSince** | **DateTime?**| The earliest feed creation date and time for feeds included in the response, in ISO 8601 format. The default is 90 days ago. Feeds are retained for a maximum of 90 days. | [optional] 
 **createdUntil** | **DateTime?**| The latest feed creation date and time for feeds included in the response, in ISO 8601 format. The default is now. | [optional] 
 **nextToken** | **string**| A string token returned in the response to your previous request. nextToken is returned when the number of results exceeds the specified pageSize value. To get the next page of results, call the getFeeds operation and include this token as the only parameter. Specifying nextToken with any other parameters will cause the request to fail. | [optional] 

### Return type

[**GetFeedsResponse**](GetFeedsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

