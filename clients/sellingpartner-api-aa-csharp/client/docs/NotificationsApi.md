# Amazon.SellingPartnerAPIAA.Clients.API.NotificationsApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDestination**](NotificationsApi.md#createdestination) | **POST** /notifications/v1/destinations | 
[**CreateSubscription**](NotificationsApi.md#createsubscription) | **POST** /notifications/v1/subscriptions/{notificationType} | 
[**DeleteDestination**](NotificationsApi.md#deletedestination) | **DELETE** /notifications/v1/destinations/{destinationId} | 
[**DeleteSubscriptionById**](NotificationsApi.md#deletesubscriptionbyid) | **DELETE** /notifications/v1/subscriptions/{notificationType}/{subscriptionId} | 
[**GetDestination**](NotificationsApi.md#getdestination) | **GET** /notifications/v1/destinations/{destinationId} | 
[**GetDestinations**](NotificationsApi.md#getdestinations) | **GET** /notifications/v1/destinations | 
[**GetSubscription**](NotificationsApi.md#getsubscription) | **GET** /notifications/v1/subscriptions/{notificationType} | 
[**GetSubscriptionById**](NotificationsApi.md#getsubscriptionbyid) | **GET** /notifications/v1/subscriptions/{notificationType}/{subscriptionId} | 


<a name="createdestination"></a>
# **CreateDestination**
> CreateDestinationResponse CreateDestination (CreateDestinationRequest body)



Creates a destination resource to receive notifications. The `createDestination` operation is grantless. For more information, refer to [Grantless operations](https://developer-docs.amazon.com/sp-api/docs/grantless-operations).  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may observe higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Notifications;

namespace Example
{
    public class CreateDestinationExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var body = new CreateDestinationRequest(); // CreateDestinationRequest | 

            try
            {
                CreateDestinationResponse result = apiInstance.CreateDestination(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateDestination: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateDestinationRequest**](CreateDestinationRequest.md)|  | 

### Return type

[**CreateDestinationResponse**](CreateDestinationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubscription"></a>
# **CreateSubscription**
> CreateSubscriptionResponse CreateSubscription (CreateSubscriptionRequest body, string notificationType)



Creates a subscription for the specified notification type to be delivered to the specified destination. Before you can subscribe, you must first create the destination by calling the `createDestination` operation. In cases where the specified notification type supports multiple payload versions, you can utilize this API to subscribe to a different payload version if you already have an existing subscription for a different payload version.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may observe higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Notifications;

namespace Example
{
    public class CreateSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var body = new CreateSubscriptionRequest(); // CreateSubscriptionRequest | 
            var notificationType = notificationType_example;  // string | The type of notification.   For more information about notification types, refer to [Notification Type Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values).

            try
            {
                CreateSubscriptionResponse result = apiInstance.CreateSubscription(body, notificationType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateSubscriptionRequest**](CreateSubscriptionRequest.md)|  | 
 **notificationType** | **string**| The type of notification.   For more information about notification types, refer to [Notification Type Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values). | 

### Return type

[**CreateSubscriptionResponse**](CreateSubscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedestination"></a>
# **DeleteDestination**
> DeleteDestinationResponse DeleteDestination (string destinationId)



Deletes the destination that you specify. The `deleteDestination` operation is grantless. For more information, refer to [Grantless operations](https://developer-docs.amazon.com/sp-api/docs/grantless-operations).  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may observe higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Notifications;

namespace Example
{
    public class DeleteDestinationExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var destinationId = destinationId_example;  // string | The identifier for the destination that you want to delete.

            try
            {
                DeleteDestinationResponse result = apiInstance.DeleteDestination(destinationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteDestination: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinationId** | **string**| The identifier for the destination that you want to delete. | 

### Return type

[**DeleteDestinationResponse**](DeleteDestinationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscriptionbyid"></a>
# **DeleteSubscriptionById**
> DeleteSubscriptionByIdResponse DeleteSubscriptionById (string subscriptionId, string notificationType)



Deletes the subscription indicated by the subscription identifier and notification type that you specify. The subscription identifier can be for any subscription associated with your application. After you successfully call this operation, notifications will stop being sent for the associated subscription. The `deleteSubscriptionById` operation is grantless. For more information, refer to [Grantless operations](https://developer-docs.amazon.com/sp-api/docs/grantless-operations).  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may observe higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Notifications;

namespace Example
{
    public class DeleteSubscriptionByIdExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var subscriptionId = subscriptionId_example;  // string | The identifier for the subscription that you want to delete.
            var notificationType = notificationType_example;  // string | The type of notification.   For more information about notification types, refer to [Notification Type Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values).

            try
            {
                DeleteSubscriptionByIdResponse result = apiInstance.DeleteSubscriptionById(subscriptionId, notificationType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteSubscriptionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **string**| The identifier for the subscription that you want to delete. | 
 **notificationType** | **string**| The type of notification.   For more information about notification types, refer to [Notification Type Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values). | 

### Return type

[**DeleteSubscriptionByIdResponse**](DeleteSubscriptionByIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdestination"></a>
# **GetDestination**
> GetDestinationResponse GetDestination (string destinationId)



Returns information about the destination that you specify. The `getDestination` operation is grantless. For more information, refer to [Grantless operations](https://developer-docs.amazon.com/sp-api/docs/grantless-operations).  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may observe higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Notifications;

namespace Example
{
    public class GetDestinationExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var destinationId = destinationId_example;  // string | The identifier generated when you created the destination.

            try
            {
                GetDestinationResponse result = apiInstance.GetDestination(destinationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetDestination: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinationId** | **string**| The identifier generated when you created the destination. | 

### Return type

[**GetDestinationResponse**](GetDestinationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdestinations"></a>
# **GetDestinations**
> GetDestinationsResponse GetDestinations ()



Returns information about all destinations. The `getDestinations` operation is grantless. For more information, refer to [Grantless operations](https://developer-docs.amazon.com/sp-api/docs/grantless-operations).  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may observe higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Notifications;

namespace Example
{
    public class GetDestinationsExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();

            try
            {
                GetDestinationsResponse result = apiInstance.GetDestinations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetDestinations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetDestinationsResponse**](GetDestinationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscription"></a>
# **GetSubscription**
> GetSubscriptionResponse GetSubscription (string notificationType, string payloadVersion = null)



Returns information about subscription of the specified notification type and payload version. `payloadVersion` is an optional parameter. When `payloadVersion` is not provided, it will return latest payload version subscription's information. You can use this API to get subscription information when you do not have a subscription identifier.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may observe higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Notifications;

namespace Example
{
    public class GetSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var notificationType = notificationType_example;  // string | The type of notification.   For more information about notification types, refer to [Notification Type Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values).
            var payloadVersion = payloadVersion_example;  // string | The version of the payload object to be used in the notification. (optional) 

            try
            {
                GetSubscriptionResponse result = apiInstance.GetSubscription(notificationType, payloadVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationType** | **string**| The type of notification.   For more information about notification types, refer to [Notification Type Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values). | 
 **payloadVersion** | **string**| The version of the payload object to be used in the notification. | [optional] 

### Return type

[**GetSubscriptionResponse**](GetSubscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionbyid"></a>
# **GetSubscriptionById**
> GetSubscriptionByIdResponse GetSubscriptionById (string subscriptionId, string notificationType)



Returns information about a subscription for the specified notification type. The `getSubscriptionById` operation is grantless. For more information, refer to [Grantless operations](https://developer-docs.amazon.com/sp-api/docs/grantless-operations).  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may observe higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Notifications;

namespace Example
{
    public class GetSubscriptionByIdExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var subscriptionId = subscriptionId_example;  // string | The identifier for the subscription that you want to get.
            var notificationType = notificationType_example;  // string | The type of notification.   For more information about notification types, refer to [Notification Type Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values).

            try
            {
                GetSubscriptionByIdResponse result = apiInstance.GetSubscriptionById(subscriptionId, notificationType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetSubscriptionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **string**| The identifier for the subscription that you want to get. | 
 **notificationType** | **string**| The type of notification.   For more information about notification types, refer to [Notification Type Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values). | 

### Return type

[**GetSubscriptionByIdResponse**](GetSubscriptionByIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

