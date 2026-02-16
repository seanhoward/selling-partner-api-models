# Amazon.SellingPartnerAPIAA.Clients.API.AwdApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelInbound**](AwdApi.md#cancelinbound) | **POST** /awd/2024-05-09/inboundOrders/{orderId}/cancellation | 
[**CheckInboundEligibility**](AwdApi.md#checkinboundeligibility) | **POST** /awd/2024-05-09/inboundEligibility | 
[**ConfirmInbound**](AwdApi.md#confirminbound) | **POST** /awd/2024-05-09/inboundOrders/{orderId}/confirmation | 
[**ConfirmReplenishmentOrder**](AwdApi.md#confirmreplenishmentorder) | **POST** /awd/2024-05-09/replenishmentOrders/{orderId}/confirmation | 
[**CreateInbound**](AwdApi.md#createinbound) | **POST** /awd/2024-05-09/inboundOrders | 
[**CreateReplenishmentOrder**](AwdApi.md#createreplenishmentorder) | **POST** /awd/2024-05-09/replenishmentOrders | 
[**GetInbound**](AwdApi.md#getinbound) | **GET** /awd/2024-05-09/inboundOrders/{orderId} | 
[**GetInboundShipment**](AwdApi.md#getinboundshipment) | **GET** /awd/2024-05-09/inboundShipments/{shipmentId} | 
[**GetInboundShipmentLabels**](AwdApi.md#getinboundshipmentlabels) | **GET** /awd/2024-05-09/inboundShipments/{shipmentId}/labels | 
[**GetReplenishmentOrder**](AwdApi.md#getreplenishmentorder) | **GET** /awd/2024-05-09/replenishmentOrders/{orderId} | 
[**ListInboundShipments**](AwdApi.md#listinboundshipments) | **GET** /awd/2024-05-09/inboundShipments | 
[**ListInventory**](AwdApi.md#listinventory) | **GET** /awd/2024-05-09/inventory | 
[**ListReplenishmentOrders**](AwdApi.md#listreplenishmentorders) | **GET** /awd/2024-05-09/replenishmentOrders | 
[**UpdateInbound**](AwdApi.md#updateinbound) | **PUT** /awd/2024-05-09/inboundOrders/{orderId} | 
[**UpdateInboundShipmentTransportDetails**](AwdApi.md#updateinboundshipmenttransportdetails) | **PUT** /awd/2024-05-09/inboundShipments/{shipmentId}/transport | 


<a name="cancelinbound"></a>
# **CancelInbound**
> void CancelInbound (string orderId)



Cancels an AWD Inbound order and its associated shipment.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class CancelInboundExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var orderId = orderId_example;  // string | The ID of the inbound order you want to cancel.

            try
            {
                apiInstance.CancelInbound(orderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.CancelInbound: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The ID of the inbound order you want to cancel. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkinboundeligibility"></a>
# **CheckInboundEligibility**
> InboundEligibility CheckInboundEligibility (InboundPackages body)



Determines if the packages you specify are eligible for an AWD inbound order and contains error details for ineligible packages.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class CheckInboundEligibilityExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var body = new InboundPackages(); // InboundPackages | Represents the packages you want to inbound.

            try
            {
                InboundEligibility result = apiInstance.CheckInboundEligibility(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.CheckInboundEligibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InboundPackages**](InboundPackages.md)| Represents the packages you want to inbound. | 

### Return type

[**InboundEligibility**](InboundEligibility.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirminbound"></a>
# **ConfirmInbound**
> void ConfirmInbound (string orderId)



Confirms an AWD inbound order in `DRAFT` status.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class ConfirmInboundExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var orderId = orderId_example;  // string | The ID of the inbound order that you want to confirm.

            try
            {
                apiInstance.ConfirmInbound(orderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.ConfirmInbound: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The ID of the inbound order that you want to confirm. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmreplenishmentorder"></a>
# **ConfirmReplenishmentOrder**
> void ConfirmReplenishmentOrder (string orderId)



Confirms an AWD replenishment order in ELIGIBLE state with a set of shipments containing items that are needed to be replenished to an FBA node. Order can only be confirmed in ELIGIBLE state.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class ConfirmReplenishmentOrderExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var orderId = orderId_example;  // string | ID of the replenishment order to be confirmed.

            try
            {
                apiInstance.ConfirmReplenishmentOrder(orderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.ConfirmReplenishmentOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| ID of the replenishment order to be confirmed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinbound"></a>
# **CreateInbound**
> InboundOrderReference CreateInbound (InboundOrderCreationData body)



Creates a draft AWD inbound order with a list of packages for inbound shipment. The operation creates one shipment per order.   **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class CreateInboundExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var body = new InboundOrderCreationData(); // InboundOrderCreationData | Payload for creating an inbound order.

            try
            {
                InboundOrderReference result = apiInstance.CreateInbound(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.CreateInbound: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InboundOrderCreationData**](InboundOrderCreationData.md)| Payload for creating an inbound order. | 

### Return type

[**InboundOrderReference**](InboundOrderReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createreplenishmentorder"></a>
# **CreateReplenishmentOrder**
> ReplenishmentOrderReference CreateReplenishmentOrder (ReplenishmentOrderCreationData body)



Creates an AWD replenishment order with given products to replenish. The API will return the order ID of the newly created order and also start an async validation check on the products to e. The order status will transition to ELIGIBLE/INELIGIBLE status from VALIDATING post validation check

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class CreateReplenishmentOrderExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var body = new ReplenishmentOrderCreationData(); // ReplenishmentOrderCreationData | Payload for creating a replenishment order.

            try
            {
                ReplenishmentOrderReference result = apiInstance.CreateReplenishmentOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.CreateReplenishmentOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReplenishmentOrderCreationData**](ReplenishmentOrderCreationData.md)| Payload for creating a replenishment order. | 

### Return type

[**ReplenishmentOrderReference**](ReplenishmentOrderReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinbound"></a>
# **GetInbound**
> InboundOrder GetInbound (string orderId)



Retrieves an AWD inbound order.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class GetInboundExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var orderId = orderId_example;  // string | The ID of the inbound order that you want to retrieve.

            try
            {
                InboundOrder result = apiInstance.GetInbound(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.GetInbound: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The ID of the inbound order that you want to retrieve. | 

### Return type

[**InboundOrder**](InboundOrder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinboundshipment"></a>
# **GetInboundShipment**
> InboundShipment GetInboundShipment (string shipmentId, string skuQuantities = null)



Retrieves an AWD inbound shipment.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class GetInboundShipmentExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var shipmentId = shipmentId_example;  // string | ID for the shipment. A shipment contains the cases being inbounded.
            var skuQuantities = SHOW;  // string | If equal to `SHOW`, the response includes the shipment SKU quantity details.  Defaults to `HIDE`, in which case the response does not contain SKU quantities (optional) 

            try
            {
                InboundShipment result = apiInstance.GetInboundShipment(shipmentId, skuQuantities);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.GetInboundShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| ID for the shipment. A shipment contains the cases being inbounded. | 
 **skuQuantities** | **string**| If equal to &#x60;SHOW&#x60;, the response includes the shipment SKU quantity details.  Defaults to &#x60;HIDE&#x60;, in which case the response does not contain SKU quantities | [optional] 

### Return type

[**InboundShipment**](InboundShipment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinboundshipmentlabels"></a>
# **GetInboundShipmentLabels**
> ShipmentLabels GetInboundShipmentLabels (string shipmentId, string pageType = null, string formatType = null)



Retrieves the box labels for a shipment ID that you specify. This is an asynchronous operation. If the label status is `GENERATED`, then the label URL is available.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class GetInboundShipmentLabelsExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var shipmentId = shipmentId_example;  // string | ID for the shipment.
            var pageType = PLAIN_PAPER;  // string | Page type for the generated labels. The default is `PLAIN_PAPER`. (optional) 
            var formatType = PDF;  // string | The format type of the output file that contains your labels. The default format type is `PDF`. (optional) 

            try
            {
                ShipmentLabels result = apiInstance.GetInboundShipmentLabels(shipmentId, pageType, formatType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.GetInboundShipmentLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| ID for the shipment. | 
 **pageType** | **string**| Page type for the generated labels. The default is &#x60;PLAIN_PAPER&#x60;. | [optional] 
 **formatType** | **string**| The format type of the output file that contains your labels. The default format type is &#x60;PDF&#x60;. | [optional] 

### Return type

[**ShipmentLabels**](ShipmentLabels.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplenishmentorder"></a>
# **GetReplenishmentOrder**
> ReplenishmentOrder GetReplenishmentOrder (string orderId)



Retrieves an AWD Replenishment order with a set of shipments containing items that is/was planned to be replenished into an FBA node.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class GetReplenishmentOrderExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var orderId = orderId_example;  // string | ID of the replenishment order to be retrieved.

            try
            {
                ReplenishmentOrder result = apiInstance.GetReplenishmentOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.GetReplenishmentOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| ID of the replenishment order to be retrieved. | 

### Return type

[**ReplenishmentOrder**](ReplenishmentOrder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinboundshipments"></a>
# **ListInboundShipments**
> ShipmentListing ListInboundShipments (string sortBy = null, string sortOrder = null, string shipmentStatus = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, int? maxResults = null, string nextToken = null)



Retrieves a summary of all the inbound AWD shipments associated with a merchant, with the ability to apply optional filters.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class ListInboundShipmentsExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var sortBy = sortBy_example;  // string | Field to sort results by. By default, the response will be sorted by UPDATED_AT. (optional) 
            var sortOrder = ASCENDING;  // string | Sort the response in ASCENDING or DESCENDING order. By default, the response will be sorted in DESCENDING order. (optional) 
            var shipmentStatus = CREATED;  // string | Filter by inbound shipment status. (optional) 
            var updatedAfter = 2023-01-12T10:00:00.000Z;  // DateTime? | List the inbound shipments that were updated after a certain time (inclusive). The date must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO 8601</a> format. (optional) 
            var updatedBefore = 2023-01-12T10:00:00.000Z;  // DateTime? | List the inbound shipments that were updated before a certain time (inclusive). The date must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO 8601</a> format. (optional) 
            var maxResults = 10;  // int? | Maximum number of results to return. (optional)  (default to 25)
            var nextToken = SampleToken;  // string | A token that is used to retrieve the next page of results. The response includes `nextToken` when the number of results exceeds the specified `maxResults` value. To get the next page of results, call the operation with this token and include the same arguments as the call that produced the token. To get a complete list, call this operation until `nextToken` is null. Note that this operation can return empty pages. (optional) 

            try
            {
                ShipmentListing result = apiInstance.ListInboundShipments(sortBy, sortOrder, shipmentStatus, updatedAfter, updatedBefore, maxResults, nextToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.ListInboundShipments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sortBy** | **string**| Field to sort results by. By default, the response will be sorted by UPDATED_AT. | [optional] 
 **sortOrder** | **string**| Sort the response in ASCENDING or DESCENDING order. By default, the response will be sorted in DESCENDING order. | [optional] 
 **shipmentStatus** | **string**| Filter by inbound shipment status. | [optional] 
 **updatedAfter** | **DateTime?**| List the inbound shipments that were updated after a certain time (inclusive). The date must be in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format. | [optional] 
 **updatedBefore** | **DateTime?**| List the inbound shipments that were updated before a certain time (inclusive). The date must be in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format. | [optional] 
 **maxResults** | **int?**| Maximum number of results to return. | [optional] [default to 25]
 **nextToken** | **string**| A token that is used to retrieve the next page of results. The response includes &#x60;nextToken&#x60; when the number of results exceeds the specified &#x60;maxResults&#x60; value. To get the next page of results, call the operation with this token and include the same arguments as the call that produced the token. To get a complete list, call this operation until &#x60;nextToken&#x60; is null. Note that this operation can return empty pages. | [optional] 

### Return type

[**ShipmentListing**](ShipmentListing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinventory"></a>
# **ListInventory**
> InventoryListing ListInventory (string sku = null, string sortOrder = null, string details = null, string nextToken = null, int? maxResults = null)



Lists AWD inventory associated with a merchant with the ability to apply optional filters.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class ListInventoryExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var sku = TestSKU;  // string | Filter by seller or merchant SKU for the item. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort the response in `ASCENDING` or `DESCENDING` order. (optional) 
            var details = SHOW;  // string | Set to `SHOW` to return summaries with additional inventory details. Defaults to `HIDE,` which returns only inventory summary totals. (optional) 
            var nextToken = SampleToken;  // string | A token that is used to retrieve the next page of results. The response includes `nextToken` when the number of results exceeds the specified `maxResults` value. To get the next page of results, call the operation with this token and include the same arguments as the call that produced the token. To get a complete list, call this operation until `nextToken` is null. Note that this operation can return empty pages. (optional) 
            var maxResults = 10;  // int? | Maximum number of results to return. (optional)  (default to 25)

            try
            {
                InventoryListing result = apiInstance.ListInventory(sku, sortOrder, details, nextToken, maxResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.ListInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sku** | **string**| Filter by seller or merchant SKU for the item. | [optional] 
 **sortOrder** | **string**| Sort the response in &#x60;ASCENDING&#x60; or &#x60;DESCENDING&#x60; order. | [optional] 
 **details** | **string**| Set to &#x60;SHOW&#x60; to return summaries with additional inventory details. Defaults to &#x60;HIDE,&#x60; which returns only inventory summary totals. | [optional] 
 **nextToken** | **string**| A token that is used to retrieve the next page of results. The response includes &#x60;nextToken&#x60; when the number of results exceeds the specified &#x60;maxResults&#x60; value. To get the next page of results, call the operation with this token and include the same arguments as the call that produced the token. To get a complete list, call this operation until &#x60;nextToken&#x60; is null. Note that this operation can return empty pages. | [optional] 
 **maxResults** | **int?**| Maximum number of results to return. | [optional] [default to 25]

### Return type

[**InventoryListing**](InventoryListing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listreplenishmentorders"></a>
# **ListReplenishmentOrders**
> ReplenishmentOrderListing ListReplenishmentOrders (DateTime? updatedAfter = null, DateTime? updatedBefore = null, string sortOrder = null, int? maxResults = null, string nextToken = null)



Retrieves all the AWD replenishment orders pertaining to a merchant with optional filters. API by default will sort orders by updatedAt attribute in descending order.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class ListReplenishmentOrdersExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var updatedAfter = 2023-01-12T10:00:00.000Z;  // DateTime? | Get the replenishment orders updated after certain time (Inclusive) Date should be in ISO 8601 format as defined by date-time in - https://www.rfc-editor.org/rfc/rfc3339. (optional) 
            var updatedBefore = 2023-01-12T10:00:00.000Z;  // DateTime? | Get the replenishment orders updated before certain time (Inclusive) Date should be in ISO 8601 format as defined by date-time in - https://www.rfc-editor.org/rfc/rfc3339. (optional) 
            var sortOrder = ASCENDING;  // string | Sort the response in ASCENDING or DESCENDING order. The default sort order is DESCENDING. (optional) 
            var maxResults = 10;  // int? | Maximum results to be returned in a single response. (optional)  (default to 25)
            var nextToken = SampleToken;  // string | A token that is used to retrieve the next page of results. The response includes `nextToken` when the number of results exceeds the specified `maxResults` value. To get the next page of results, call the operation with this token and include the same arguments as the call that produced the token. To get a complete list, call this operation until `nextToken` is null. Note that this operation can return empty pages. (optional) 

            try
            {
                ReplenishmentOrderListing result = apiInstance.ListReplenishmentOrders(updatedAfter, updatedBefore, sortOrder, maxResults, nextToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.ListReplenishmentOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updatedAfter** | **DateTime?**| Get the replenishment orders updated after certain time (Inclusive) Date should be in ISO 8601 format as defined by date-time in - https://www.rfc-editor.org/rfc/rfc3339. | [optional] 
 **updatedBefore** | **DateTime?**| Get the replenishment orders updated before certain time (Inclusive) Date should be in ISO 8601 format as defined by date-time in - https://www.rfc-editor.org/rfc/rfc3339. | [optional] 
 **sortOrder** | **string**| Sort the response in ASCENDING or DESCENDING order. The default sort order is DESCENDING. | [optional] 
 **maxResults** | **int?**| Maximum results to be returned in a single response. | [optional] [default to 25]
 **nextToken** | **string**| A token that is used to retrieve the next page of results. The response includes &#x60;nextToken&#x60; when the number of results exceeds the specified &#x60;maxResults&#x60; value. To get the next page of results, call the operation with this token and include the same arguments as the call that produced the token. To get a complete list, call this operation until &#x60;nextToken&#x60; is null. Note that this operation can return empty pages. | [optional] 

### Return type

[**ReplenishmentOrderListing**](ReplenishmentOrderListing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinbound"></a>
# **UpdateInbound**
> void UpdateInbound (string orderId, InboundOrder body)



Updates an AWD inbound order that is in `DRAFT` status and not yet confirmed. Use this operation to update the `packagesToInbound`, `originAddress` and `preferences` attributes.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class UpdateInboundExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var orderId = orderId_example;  // string | The ID of the inbound order that you want to update.
            var body = new InboundOrder(); // InboundOrder | Represents an AWD inbound order.

            try
            {
                apiInstance.UpdateInbound(orderId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.UpdateInbound: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The ID of the inbound order that you want to update. | 
 **body** | [**InboundOrder**](InboundOrder.md)| Represents an AWD inbound order. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinboundshipmenttransportdetails"></a>
# **UpdateInboundShipmentTransportDetails**
> void UpdateInboundShipmentTransportDetails (string shipmentId, TransportationDetails body)



Updates transport details for an AWD shipment.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Awd;

namespace Example
{
    public class UpdateInboundShipmentTransportDetailsExample
    {
        public void main()
        {
            var apiInstance = new AwdApi();
            var shipmentId = shipmentId_example;  // string | The shipment ID.
            var body = new TransportationDetails(); // TransportationDetails | Transportation details for the shipment.

            try
            {
                apiInstance.UpdateInboundShipmentTransportDetails(shipmentId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AwdApi.UpdateInboundShipmentTransportDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The shipment ID. | 
 **body** | [**TransportationDetails**](TransportationDetails.md)| Transportation details for the shipment. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

