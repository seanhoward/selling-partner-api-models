# Amazon.SellingPartnerAPIAA.Clients.API.CustomerFeedbackApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBrowseNodeReturnTopics**](CustomerFeedbackApi.md#getbrowsenodereturntopics) | **GET** /customerFeedback/2024-06-01/browseNodes/{browseNodeId}/returns/topics | 
[**GetBrowseNodeReturnTrends**](CustomerFeedbackApi.md#getbrowsenodereturntrends) | **GET** /customerFeedback/2024-06-01/browseNodes/{browseNodeId}/returns/trends | 
[**GetBrowseNodeReviewTopics**](CustomerFeedbackApi.md#getbrowsenodereviewtopics) | **GET** /customerFeedback/2024-06-01/browseNodes/{browseNodeId}/reviews/topics | 
[**GetBrowseNodeReviewTrends**](CustomerFeedbackApi.md#getbrowsenodereviewtrends) | **GET** /customerFeedback/2024-06-01/browseNodes/{browseNodeId}/reviews/trends | 
[**GetItemBrowseNode**](CustomerFeedbackApi.md#getitembrowsenode) | **GET** /customerFeedback/2024-06-01/items/{asin}/browseNode | 
[**GetItemReviewTopics**](CustomerFeedbackApi.md#getitemreviewtopics) | **GET** /customerFeedback/2024-06-01/items/{asin}/reviews/topics | 
[**GetItemReviewTrends**](CustomerFeedbackApi.md#getitemreviewtrends) | **GET** /customerFeedback/2024-06-01/items/{asin}/reviews/trends | 


<a name="getbrowsenodereturntopics"></a>
# **GetBrowseNodeReturnTopics**
> BrowseNodeReturnTopicsResponse GetBrowseNodeReturnTopics (string browseNodeId, string marketplaceId)



Retrieve the topics that customers mention when they return items in a browse node.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.CustomerFeedback;

namespace Example
{
    public class GetBrowseNodeReturnTopicsExample
    {
        public void main()
        {
            var apiInstance = new CustomerFeedbackApi();
            var browseNodeId = browseNodeId_example;  // string | A browse node ID is a unique identifier for a browse node. A browse node is a named location in a browse tree that is used for navigation, product classification, and website content.
            var marketplaceId = marketplaceId_example;  // string | The MarketplaceId is the globally unique identifier of a marketplace, you can refer to the marketplaceId here : https://developer-docs.amazon.com/sp-api/docs/marketplace-ids.

            try
            {
                BrowseNodeReturnTopicsResponse result = apiInstance.GetBrowseNodeReturnTopics(browseNodeId, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerFeedbackApi.GetBrowseNodeReturnTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **browseNodeId** | **string**| A browse node ID is a unique identifier for a browse node. A browse node is a named location in a browse tree that is used for navigation, product classification, and website content. | 
 **marketplaceId** | **string**| The MarketplaceId is the globally unique identifier of a marketplace, you can refer to the marketplaceId here : https://developer-docs.amazon.com/sp-api/docs/marketplace-ids. | 

### Return type

[**BrowseNodeReturnTopicsResponse**](BrowseNodeReturnTopicsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrowsenodereturntrends"></a>
# **GetBrowseNodeReturnTrends**
> BrowseNodeReturnTrendsResponse GetBrowseNodeReturnTrends (string browseNodeId, string marketplaceId)



Retrieve the trends of topics that customers mention when they return items in a browse node.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.CustomerFeedback;

namespace Example
{
    public class GetBrowseNodeReturnTrendsExample
    {
        public void main()
        {
            var apiInstance = new CustomerFeedbackApi();
            var browseNodeId = browseNodeId_example;  // string | A browse node ID is a unique identifier of a browse node. A browse node is a named location in a browse tree that is used for navigation, product classification, and website content.
            var marketplaceId = marketplaceId_example;  // string | The MarketplaceId is the globally unique identifier of a marketplace, you can refer to the marketplaceId here : https://developer-docs.amazon.com/sp-api/docs/marketplace-ids.

            try
            {
                BrowseNodeReturnTrendsResponse result = apiInstance.GetBrowseNodeReturnTrends(browseNodeId, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerFeedbackApi.GetBrowseNodeReturnTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **browseNodeId** | **string**| A browse node ID is a unique identifier of a browse node. A browse node is a named location in a browse tree that is used for navigation, product classification, and website content. | 
 **marketplaceId** | **string**| The MarketplaceId is the globally unique identifier of a marketplace, you can refer to the marketplaceId here : https://developer-docs.amazon.com/sp-api/docs/marketplace-ids. | 

### Return type

[**BrowseNodeReturnTrendsResponse**](BrowseNodeReturnTrendsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrowsenodereviewtopics"></a>
# **GetBrowseNodeReviewTopics**
> BrowseNodeReviewTopicsResponse GetBrowseNodeReviewTopics (string browseNodeId, string marketplaceId, string sortBy)



Retrieve a browse node's ten most positive and ten most negative review topics.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.CustomerFeedback;

namespace Example
{
    public class GetBrowseNodeReviewTopicsExample
    {
        public void main()
        {
            var apiInstance = new CustomerFeedbackApi();
            var browseNodeId = browseNodeId_example;  // string | The ID of a browse node. A browse node is a named location in a browse tree that is used for navigation, product classification, and website content.
            var marketplaceId = marketplaceId_example;  // string | The MarketplaceId is the globally unique identifier of a marketplace, you can refer to the marketplaceId here : https://developer-docs.amazon.com/sp-api/docs/marketplace-ids.
            var sortBy = MENTIONS;  // string | The metric by which to sort the data in the response.

            try
            {
                BrowseNodeReviewTopicsResponse result = apiInstance.GetBrowseNodeReviewTopics(browseNodeId, marketplaceId, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerFeedbackApi.GetBrowseNodeReviewTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **browseNodeId** | **string**| The ID of a browse node. A browse node is a named location in a browse tree that is used for navigation, product classification, and website content. | 
 **marketplaceId** | **string**| The MarketplaceId is the globally unique identifier of a marketplace, you can refer to the marketplaceId here : https://developer-docs.amazon.com/sp-api/docs/marketplace-ids. | 
 **sortBy** | **string**| The metric by which to sort the data in the response. | 

### Return type

[**BrowseNodeReviewTopicsResponse**](BrowseNodeReviewTopicsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrowsenodereviewtrends"></a>
# **GetBrowseNodeReviewTrends**
> BrowseNodeReviewTrendsResponse GetBrowseNodeReviewTrends (string browseNodeId, string marketplaceId)



Retrieve the positive and negative review trends of items in a browse node for the past six months.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.CustomerFeedback;

namespace Example
{
    public class GetBrowseNodeReviewTrendsExample
    {
        public void main()
        {
            var apiInstance = new CustomerFeedbackApi();
            var browseNodeId = browseNodeId_example;  // string | A browse node ID is a unique identifier of a browse node. A browse node is a named location in a browse tree that is used for navigation, product classification, and website content.
            var marketplaceId = marketplaceId_example;  // string | The marketplace ID is the globally unique identifier of a marketplace. For more information, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                BrowseNodeReviewTrendsResponse result = apiInstance.GetBrowseNodeReviewTrends(browseNodeId, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerFeedbackApi.GetBrowseNodeReviewTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **browseNodeId** | **string**| A browse node ID is a unique identifier of a browse node. A browse node is a named location in a browse tree that is used for navigation, product classification, and website content. | 
 **marketplaceId** | **string**| The marketplace ID is the globally unique identifier of a marketplace. For more information, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 

### Return type

[**BrowseNodeReviewTrendsResponse**](BrowseNodeReviewTrendsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitembrowsenode"></a>
# **GetItemBrowseNode**
> BrowseNodeResponse GetItemBrowseNode (string asin, string marketplaceId)



This API returns the associated browse node of the requested ASIN. A browse node is a location in a browse tree that is used for navigation, product classification, and website content on the Amazon retail website.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.CustomerFeedback;

namespace Example
{
    public class GetItemBrowseNodeExample
    {
        public void main()
        {
            var apiInstance = new CustomerFeedbackApi();
            var asin = asin_example;  // string | The Amazon Standard Identification Number (ASIN) is the unique identifier of a product within a marketplace.
            var marketplaceId = marketplaceId_example;  // string | The MarketplaceId is the globally unique identifier of a marketplace, you can refer to the marketplaceId here : https://developer-docs.amazon.com/sp-api/docs/marketplace-ids.

            try
            {
                BrowseNodeResponse result = apiInstance.GetItemBrowseNode(asin, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerFeedbackApi.GetItemBrowseNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asin** | **string**| The Amazon Standard Identification Number (ASIN) is the unique identifier of a product within a marketplace. | 
 **marketplaceId** | **string**| The MarketplaceId is the globally unique identifier of a marketplace, you can refer to the marketplaceId here : https://developer-docs.amazon.com/sp-api/docs/marketplace-ids. | 

### Return type

[**BrowseNodeResponse**](BrowseNodeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemreviewtopics"></a>
# **GetItemReviewTopics**
> ItemReviewTopicsResponse GetItemReviewTopics (string asin, string marketplaceId, string sortBy)



Retrieve an item's ten most positive and ten most negative review topics.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.CustomerFeedback;

namespace Example
{
    public class GetItemReviewTopicsExample
    {
        public void main()
        {
            var apiInstance = new CustomerFeedbackApi();
            var asin = asin_example;  // string | The Amazon Standard Identification Number (ASIN) is the unique identifier of a product within a marketplace. The value must be a child ASIN.
            var marketplaceId = marketplaceId_example;  // string | The MarketplaceId is the globally unique identifier of a marketplace, you can refer to the marketplaceId here : https://developer-docs.amazon.com/sp-api/docs/marketplace-ids.
            var sortBy = MENTIONS;  // string | The metric by which to sort data in the response.

            try
            {
                ItemReviewTopicsResponse result = apiInstance.GetItemReviewTopics(asin, marketplaceId, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerFeedbackApi.GetItemReviewTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asin** | **string**| The Amazon Standard Identification Number (ASIN) is the unique identifier of a product within a marketplace. The value must be a child ASIN. | 
 **marketplaceId** | **string**| The MarketplaceId is the globally unique identifier of a marketplace, you can refer to the marketplaceId here : https://developer-docs.amazon.com/sp-api/docs/marketplace-ids. | 
 **sortBy** | **string**| The metric by which to sort data in the response. | 

### Return type

[**ItemReviewTopicsResponse**](ItemReviewTopicsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemreviewtrends"></a>
# **GetItemReviewTrends**
> ItemReviewTrendsResponse GetItemReviewTrends (string asin, string marketplaceId)



Retrieve an item's positive and negative review trends for the past six months.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.CustomerFeedback;

namespace Example
{
    public class GetItemReviewTrendsExample
    {
        public void main()
        {
            var apiInstance = new CustomerFeedbackApi();
            var asin = asin_example;  // string | The Amazon Standard Identification Number (ASIN) is the unique identifier of a product within a marketplace. This API takes child ASIN as an input.
            var marketplaceId = marketplaceId_example;  // string | The MarketplaceId is the globally unique identifier of a marketplace, you can refer to the marketplaceId here : https://developer-docs.amazon.com/sp-api/docs/marketplace-ids.

            try
            {
                ItemReviewTrendsResponse result = apiInstance.GetItemReviewTrends(asin, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerFeedbackApi.GetItemReviewTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asin** | **string**| The Amazon Standard Identification Number (ASIN) is the unique identifier of a product within a marketplace. This API takes child ASIN as an input. | 
 **marketplaceId** | **string**| The MarketplaceId is the globally unique identifier of a marketplace, you can refer to the marketplaceId here : https://developer-docs.amazon.com/sp-api/docs/marketplace-ids. | 

### Return type

[**ItemReviewTrendsResponse**](ItemReviewTrendsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

