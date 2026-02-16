# Amazon.SellingPartnerAPIAA.Clients.API.MessagingApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfirmCustomizationDetails**](MessagingApi.md#confirmcustomizationdetails) | **POST** /messaging/v1/orders/{amazonOrderId}/messages/confirmCustomizationDetails | 
[**CreateConfirmDeliveryDetails**](MessagingApi.md#createconfirmdeliverydetails) | **POST** /messaging/v1/orders/{amazonOrderId}/messages/confirmDeliveryDetails | 
[**CreateConfirmOrderDetails**](MessagingApi.md#createconfirmorderdetails) | **POST** /messaging/v1/orders/{amazonOrderId}/messages/confirmOrderDetails | 
[**CreateConfirmServiceDetails**](MessagingApi.md#createconfirmservicedetails) | **POST** /messaging/v1/orders/{amazonOrderId}/messages/confirmServiceDetails | 
[**CreateDigitalAccessKey**](MessagingApi.md#createdigitalaccesskey) | **POST** /messaging/v1/orders/{amazonOrderId}/messages/digitalAccessKey | 
[**CreateLegalDisclosure**](MessagingApi.md#createlegaldisclosure) | **POST** /messaging/v1/orders/{amazonOrderId}/messages/legalDisclosure | 
[**CreateUnexpectedProblem**](MessagingApi.md#createunexpectedproblem) | **POST** /messaging/v1/orders/{amazonOrderId}/messages/unexpectedProblem | 
[**CreateWarranty**](MessagingApi.md#createwarranty) | **POST** /messaging/v1/orders/{amazonOrderId}/messages/warranty | 
[**GetAttributes**](MessagingApi.md#getattributes) | **GET** /messaging/v1/orders/{amazonOrderId}/attributes | 
[**GetMessagingActionsForOrder**](MessagingApi.md#getmessagingactionsfororder) | **GET** /messaging/v1/orders/{amazonOrderId} | 
[**SendInvoice**](MessagingApi.md#sendinvoice) | **POST** /messaging/v1/orders/{amazonOrderId}/messages/invoice | 


<a name="confirmcustomizationdetails"></a>
# **ConfirmCustomizationDetails**
> CreateConfirmCustomizationDetailsResponse ConfirmCustomizationDetails (string amazonOrderId, List<string> marketplaceIds, CreateConfirmCustomizationDetailsRequest body)



Sends a message asking a buyer to provide or verify customization details such as name spelling, images, initials, etc.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;

namespace Example
{
    public class ConfirmCustomizationDetailsExample
    {
        public void main()
        {
            var apiInstance = new MessagingApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This identifies the order for which a message is sent.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace.
            var body = new CreateConfirmCustomizationDetailsRequest(); // CreateConfirmCustomizationDetailsRequest | This contains the message body for a message.

            try
            {
                CreateConfirmCustomizationDetailsResponse result = apiInstance.ConfirmCustomizationDetails(amazonOrderId, marketplaceIds, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.ConfirmCustomizationDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This identifies the order for which a message is sent. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace. | 
 **body** | [**CreateConfirmCustomizationDetailsRequest**](CreateConfirmCustomizationDetailsRequest.md)| This contains the message body for a message. | 

### Return type

[**CreateConfirmCustomizationDetailsResponse**](CreateConfirmCustomizationDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createconfirmdeliverydetails"></a>
# **CreateConfirmDeliveryDetails**
> CreateConfirmDeliveryDetailsResponse CreateConfirmDeliveryDetails (string amazonOrderId, List<string> marketplaceIds, CreateConfirmDeliveryDetailsRequest body)



Sends a message to a buyer to arrange a delivery or to confirm contact information for making a delivery.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;

namespace Example
{
    public class CreateConfirmDeliveryDetailsExample
    {
        public void main()
        {
            var apiInstance = new MessagingApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This identifies the order for which a message is sent.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace.
            var body = new CreateConfirmDeliveryDetailsRequest(); // CreateConfirmDeliveryDetailsRequest | This contains the message body for a message.

            try
            {
                CreateConfirmDeliveryDetailsResponse result = apiInstance.CreateConfirmDeliveryDetails(amazonOrderId, marketplaceIds, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.CreateConfirmDeliveryDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This identifies the order for which a message is sent. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace. | 
 **body** | [**CreateConfirmDeliveryDetailsRequest**](CreateConfirmDeliveryDetailsRequest.md)| This contains the message body for a message. | 

### Return type

[**CreateConfirmDeliveryDetailsResponse**](CreateConfirmDeliveryDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createconfirmorderdetails"></a>
# **CreateConfirmOrderDetails**
> CreateConfirmOrderDetailsResponse CreateConfirmOrderDetails (string amazonOrderId, List<string> marketplaceIds, CreateConfirmOrderDetailsRequest body)



Sends a message to ask a buyer an order-related question prior to shipping their order.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;

namespace Example
{
    public class CreateConfirmOrderDetailsExample
    {
        public void main()
        {
            var apiInstance = new MessagingApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This identifies the order for which a message is sent.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace.
            var body = new CreateConfirmOrderDetailsRequest(); // CreateConfirmOrderDetailsRequest | This contains the message body for a message.

            try
            {
                CreateConfirmOrderDetailsResponse result = apiInstance.CreateConfirmOrderDetails(amazonOrderId, marketplaceIds, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.CreateConfirmOrderDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This identifies the order for which a message is sent. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace. | 
 **body** | [**CreateConfirmOrderDetailsRequest**](CreateConfirmOrderDetailsRequest.md)| This contains the message body for a message. | 

### Return type

[**CreateConfirmOrderDetailsResponse**](CreateConfirmOrderDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createconfirmservicedetails"></a>
# **CreateConfirmServiceDetails**
> CreateConfirmServiceDetailsResponse CreateConfirmServiceDetails (string amazonOrderId, List<string> marketplaceIds, CreateConfirmServiceDetailsRequest body)



Sends a message to contact a Home Service customer to arrange a service call or to gather information prior to a service call.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;

namespace Example
{
    public class CreateConfirmServiceDetailsExample
    {
        public void main()
        {
            var apiInstance = new MessagingApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This identifies the order for which a message is sent.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace.
            var body = new CreateConfirmServiceDetailsRequest(); // CreateConfirmServiceDetailsRequest | This contains the message body for a message.

            try
            {
                CreateConfirmServiceDetailsResponse result = apiInstance.CreateConfirmServiceDetails(amazonOrderId, marketplaceIds, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.CreateConfirmServiceDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This identifies the order for which a message is sent. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace. | 
 **body** | [**CreateConfirmServiceDetailsRequest**](CreateConfirmServiceDetailsRequest.md)| This contains the message body for a message. | 

### Return type

[**CreateConfirmServiceDetailsResponse**](CreateConfirmServiceDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdigitalaccesskey"></a>
# **CreateDigitalAccessKey**
> CreateDigitalAccessKeyResponse CreateDigitalAccessKey (string amazonOrderId, List<string> marketplaceIds, CreateDigitalAccessKeyRequest body)



Sends a buyer a message to share a digital access key that is required to utilize digital content in their order.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;

namespace Example
{
    public class CreateDigitalAccessKeyExample
    {
        public void main()
        {
            var apiInstance = new MessagingApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This identifies the order for which a message is sent.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace.
            var body = new CreateDigitalAccessKeyRequest(); // CreateDigitalAccessKeyRequest | This contains the message body for a message.

            try
            {
                CreateDigitalAccessKeyResponse result = apiInstance.CreateDigitalAccessKey(amazonOrderId, marketplaceIds, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.CreateDigitalAccessKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This identifies the order for which a message is sent. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace. | 
 **body** | [**CreateDigitalAccessKeyRequest**](CreateDigitalAccessKeyRequest.md)| This contains the message body for a message. | 

### Return type

[**CreateDigitalAccessKeyResponse**](CreateDigitalAccessKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlegaldisclosure"></a>
# **CreateLegalDisclosure**
> CreateLegalDisclosureResponse CreateLegalDisclosure (string amazonOrderId, List<string> marketplaceIds, CreateLegalDisclosureRequest body)



Sends a critical message that contains documents that a seller is legally obligated to provide to the buyer. This message should only be used to deliver documents that are required by law.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;

namespace Example
{
    public class CreateLegalDisclosureExample
    {
        public void main()
        {
            var apiInstance = new MessagingApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This identifies the order for which a message is sent.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace.
            var body = new CreateLegalDisclosureRequest(); // CreateLegalDisclosureRequest | This contains the message body for a message.

            try
            {
                CreateLegalDisclosureResponse result = apiInstance.CreateLegalDisclosure(amazonOrderId, marketplaceIds, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.CreateLegalDisclosure: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This identifies the order for which a message is sent. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace. | 
 **body** | [**CreateLegalDisclosureRequest**](CreateLegalDisclosureRequest.md)| This contains the message body for a message. | 

### Return type

[**CreateLegalDisclosureResponse**](CreateLegalDisclosureResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createunexpectedproblem"></a>
# **CreateUnexpectedProblem**
> CreateUnexpectedProblemResponse CreateUnexpectedProblem (string amazonOrderId, List<string> marketplaceIds, CreateUnexpectedProblemRequest body)



Sends a critical message to a buyer that an unexpected problem was encountered affecting the completion of the order.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;

namespace Example
{
    public class CreateUnexpectedProblemExample
    {
        public void main()
        {
            var apiInstance = new MessagingApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This identifies the order for which a message is sent.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace.
            var body = new CreateUnexpectedProblemRequest(); // CreateUnexpectedProblemRequest | This contains the message body for a message.

            try
            {
                CreateUnexpectedProblemResponse result = apiInstance.CreateUnexpectedProblem(amazonOrderId, marketplaceIds, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.CreateUnexpectedProblem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This identifies the order for which a message is sent. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace. | 
 **body** | [**CreateUnexpectedProblemRequest**](CreateUnexpectedProblemRequest.md)| This contains the message body for a message. | 

### Return type

[**CreateUnexpectedProblemResponse**](CreateUnexpectedProblemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createwarranty"></a>
# **CreateWarranty**
> CreateWarrantyResponse CreateWarranty (string amazonOrderId, List<string> marketplaceIds, CreateWarrantyRequest body)



Sends a message to a buyer to provide details about warranty information on a purchase in their order.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;

namespace Example
{
    public class CreateWarrantyExample
    {
        public void main()
        {
            var apiInstance = new MessagingApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This identifies the order for which a message is sent.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace.
            var body = new CreateWarrantyRequest(); // CreateWarrantyRequest | This contains the message body for a message.

            try
            {
                CreateWarrantyResponse result = apiInstance.CreateWarranty(amazonOrderId, marketplaceIds, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.CreateWarranty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This identifies the order for which a message is sent. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace. | 
 **body** | [**CreateWarrantyRequest**](CreateWarrantyRequest.md)| This contains the message body for a message. | 

### Return type

[**CreateWarrantyResponse**](CreateWarrantyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattributes"></a>
# **GetAttributes**
> GetAttributesResponse GetAttributes (string amazonOrderId, List<string> marketplaceIds)



Returns a response containing attributes related to an order. This includes buyer preferences.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;

namespace Example
{
    public class GetAttributesExample
    {
        public void main()
        {
            var apiInstance = new MessagingApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This identifies the order for which a message is sent.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace.

            try
            {
                GetAttributesResponse result = apiInstance.GetAttributes(amazonOrderId, marketplaceIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This identifies the order for which a message is sent. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace. | 

### Return type

[**GetAttributesResponse**](GetAttributesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagingactionsfororder"></a>
# **GetMessagingActionsForOrder**
> GetMessagingActionsForOrderResponse GetMessagingActionsForOrder (string amazonOrderId, List<string> marketplaceIds)



Returns a list of message types that are available for an order that you specify. A message type is represented by an actions object, which contains a path and query parameter(s). You can use the path and parameter(s) to call an operation that sends a message.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput might have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;

namespace Example
{
    public class GetMessagingActionsForOrderExample
    {
        public void main()
        {
            var apiInstance = new MessagingApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This specifies the order for which you want a list of available message types.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace.

            try
            {
                GetMessagingActionsForOrderResponse result = apiInstance.GetMessagingActionsForOrder(amazonOrderId, marketplaceIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingActionsForOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This specifies the order for which you want a list of available message types. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace. | 

### Return type

[**GetMessagingActionsForOrderResponse**](GetMessagingActionsForOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendinvoice"></a>
# **SendInvoice**
> InvoiceResponse SendInvoice (string amazonOrderId, List<string> marketplaceIds, InvoiceRequest body)



Sends a message providing the buyer an invoice

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;

namespace Example
{
    public class SendInvoiceExample
    {
        public void main()
        {
            var apiInstance = new MessagingApi();
            var amazonOrderId = amazonOrderId_example;  // string | An Amazon order identifier. This identifies the order for which a message is sent.
            var marketplaceIds = new List<string>(); // List<string> | A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace.
            var body = new InvoiceRequest(); // InvoiceRequest | This contains the message body for a message.

            try
            {
                InvoiceResponse result = apiInstance.SendInvoice(amazonOrderId, marketplaceIds, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amazonOrderId** | **string**| An Amazon order identifier. This identifies the order for which a message is sent. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| A marketplace identifier. This identifies the marketplace in which the order was placed. You can only specify one marketplace. | 
 **body** | [**InvoiceRequest**](InvoiceRequest.md)| This contains the message body for a message. | 

### Return type

[**InvoiceResponse**](InvoiceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

