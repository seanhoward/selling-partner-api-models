# Amazon.SellingPartnerAPIAA.Clients.Models.CustomerFeedback.ItemReviewTopic
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Topic** | **string** | The name of the item review topic. | 
**AsinMetrics** | [**ItemReviewTopicMetrics**](ItemReviewTopicMetrics.md) | The ASIN&#39;s review topic metrics. | 
**ParentAsinMetrics** | [**ItemReviewTopicMetrics**](ItemReviewTopicMetrics.md) | The parent ASIN&#39;s review topic metrics. This value is &#x60;null&#x60; if there isn&#39;t enough topic data for the parent ASIN. | [optional] 
**BrowseNodeMetrics** | [**ItemReviewBrowseNodeMetrics**](ItemReviewBrowseNodeMetrics.md) | The browse node&#39;s review topic metrics. This value is &#x60;null&#x60; if there isn&#39;t enough topic data for the browse node. | [optional] 
**ChildAsinMetrics** | [**ChildAsinMetrics**](ChildAsinMetrics.md) | The review topic metrics for other child ASINs that have the same parent ASIN. This value is &#x60;null&#x60; if there isn&#39;t any child ASIN metric data. | [optional] 
**ReviewSnippets** | **List&lt;string&gt;** | A list of up to three snippets from reviews that contain the topic. This value is &#x60;null&#x60; if there aren&#39;t enough review snippets for the topic. | [optional] 
**Subtopics** | [**List&lt;ItemReviewSubtopic&gt;**](ItemReviewSubtopic.md) | A list of up to five top subtopics for the topic. The percentage of customer reviews that mention the subtopic determine the topic&#39;s placement in the list. This value is &#x60;null&#x60; if there are no subtopics. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

