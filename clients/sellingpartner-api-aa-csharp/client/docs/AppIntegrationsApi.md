# Amazon.SellingPartnerAPIAA.Clients.API.AppIntegrationsApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNotification**](AppIntegrationsApi.md#createnotification) | **POST** /appIntegrations/2024-04-01/notifications | 
[**DeleteNotifications**](AppIntegrationsApi.md#deletenotifications) | **POST** /appIntegrations/2024-04-01/notifications/deletion | 
[**RecordActionFeedback**](AppIntegrationsApi.md#recordactionfeedback) | **POST** /appIntegrations/2024-04-01/notifications/{notificationId}/feedback | 


<a name="createnotification"></a>
# **CreateNotification**
> CreateNotificationResponse CreateNotification (CreateNotificationRequest body)



Create a notification for sellers in Seller Central.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Sellers whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AppIntegrations;

namespace Example
{
    public class CreateNotificationExample
    {
        public void main()
        {
            var apiInstance = new AppIntegrationsApi();
            var body = new CreateNotificationRequest(); // CreateNotificationRequest | The request body for the `createNotification` operation.

            try
            {
                CreateNotificationResponse result = apiInstance.CreateNotification(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppIntegrationsApi.CreateNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateNotificationRequest**](CreateNotificationRequest.md)| The request body for the &#x60;createNotification&#x60; operation. | 

### Return type

[**CreateNotificationResponse**](CreateNotificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenotifications"></a>
# **DeleteNotifications**
> void DeleteNotifications (DeleteNotificationsRequest body)



Remove your application's notifications from the Appstore notifications dashboard.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Sellers whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AppIntegrations;

namespace Example
{
    public class DeleteNotificationsExample
    {
        public void main()
        {
            var apiInstance = new AppIntegrationsApi();
            var body = new DeleteNotificationsRequest(); // DeleteNotificationsRequest | The request body for the `deleteNotifications` operation.

            try
            {
                apiInstance.DeleteNotifications(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppIntegrationsApi.DeleteNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteNotificationsRequest**](DeleteNotificationsRequest.md)| The request body for the &#x60;deleteNotifications&#x60; operation. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recordactionfeedback"></a>
# **RecordActionFeedback**
> void RecordActionFeedback (string notificationId, RecordActionFeedbackRequest body)



Records the seller's response to a notification.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Sellers whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.AppIntegrations;

namespace Example
{
    public class RecordActionFeedbackExample
    {
        public void main()
        {
            var apiInstance = new AppIntegrationsApi();
            var notificationId = notificationId_example;  // string | A `notificationId` uniquely identifies a notification.
            var body = new RecordActionFeedbackRequest(); // RecordActionFeedbackRequest | The request body for the `recordActionFeedback` operation.

            try
            {
                apiInstance.RecordActionFeedback(notificationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppIntegrationsApi.RecordActionFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationId** | **string**| A &#x60;notificationId&#x60; uniquely identifies a notification. | 
 **body** | [**RecordActionFeedbackRequest**](RecordActionFeedbackRequest.md)| The request body for the &#x60;recordActionFeedback&#x60; operation. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

