# Amazon.SellingPartnerAPIAA.Clients.Models.CustomerFeedback.BrowseNodeReviewTopic
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Topic** | **string** | The name browse node review topic. | 
**BrowseNodeMetrics** | [**BrowseNodeReviewTopicMetrics**](BrowseNodeReviewTopicMetrics.md) | The percentage of browse node reviews that mention the topic, and the effect the topic has on the star rating. | 
**ReviewSnippets** | **List&lt;string&gt;** | A list of up to three snippets from reviews that contain the topic. This value is &#x60;null&#x60; if there aren&#39;t enough review snippets for the topic. | [optional] 
**Subtopics** | [**List&lt;BrowseNodeSubtopic&gt;**](BrowseNodeSubtopic.md) | A list of the five subtopics that occur most frequently. This value is &#x60;null&#x60; if there are no subtopics. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

