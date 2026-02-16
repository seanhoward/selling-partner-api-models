# Amazon.SellingPartnerAPIAA.Clients.API.VendorOrdersApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPurchaseOrder**](VendorOrdersApi.md#getpurchaseorder) | **GET** /vendor/orders/v1/purchaseOrders/{purchaseOrderNumber} | 
[**GetPurchaseOrders**](VendorOrdersApi.md#getpurchaseorders) | **GET** /vendor/orders/v1/purchaseOrders | 
[**GetPurchaseOrdersStatus**](VendorOrdersApi.md#getpurchaseordersstatus) | **GET** /vendor/orders/v1/purchaseOrdersStatus | 
[**SubmitAcknowledgement**](VendorOrdersApi.md#submitacknowledgement) | **POST** /vendor/orders/v1/acknowledgements | 


<a name="getpurchaseorder"></a>
# **GetPurchaseOrder**
> GetPurchaseOrderResponse GetPurchaseOrder (string purchaseOrderNumber)



Returns a purchase order based on the `purchaseOrderNumber` value that you specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorOrders;

namespace Example
{
    public class GetPurchaseOrderExample
    {
        public void main()
        {
            var apiInstance = new VendorOrdersApi();
            var purchaseOrderNumber = purchaseOrderNumber_example;  // string | The purchase order identifier for the order that you want. Formatting Notes: 8-character alpha-numeric code.

            try
            {
                GetPurchaseOrderResponse result = apiInstance.GetPurchaseOrder(purchaseOrderNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorOrdersApi.GetPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchaseOrderNumber** | **string**| The purchase order identifier for the order that you want. Formatting Notes: 8-character alpha-numeric code. | 

### Return type

[**GetPurchaseOrderResponse**](GetPurchaseOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpurchaseorders"></a>
# **GetPurchaseOrders**
> GetPurchaseOrdersResponse GetPurchaseOrders (long? limit = null, DateTime? createdAfter = null, DateTime? createdBefore = null, string sortOrder = null, string nextToken = null, string includeDetails = null, DateTime? changedAfter = null, DateTime? changedBefore = null, string poItemState = null, string isPOChanged = null, string purchaseOrderState = null, string orderingVendorCode = null)



Returns a list of purchase orders created or changed during the time frame that you specify. You define the time frame using the `createdAfter`, `createdBefore`, `changedAfter` and `changedBefore` parameters. The date range to search must not be more than 7 days. You can choose to get only the purchase order numbers by setting `includeDetails` to false. You can then use the `getPurchaseOrder` operation to receive details for a specific purchase order.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorOrders;

namespace Example
{
    public class GetPurchaseOrdersExample
    {
        public void main()
        {
            var apiInstance = new VendorOrdersApi();
            var limit = 789;  // long? | The limit to the number of records returned. Default value is 100 records. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Purchase orders that became available after this time will be included in the result. Must be in ISO-8601 date/time format. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Purchase orders that became available before this time will be included in the result. Must be in ISO-8601 date/time format. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort in ascending or descending order by purchase order creation date. (optional) 
            var nextToken = nextToken_example;  // string | Used for pagination when there is more purchase orders than the specified result size limit. The token value is returned in the previous API call (optional) 
            var includeDetails = includeDetails_example;  // string | When true, returns purchase orders with complete details. Otherwise, only purchase order numbers are returned. Default value is true. (optional) 
            var changedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Purchase orders that changed after this timestamp will be included in the result. Must be in ISO-8601 date/time format. (optional) 
            var changedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Purchase orders that changed before this timestamp will be included in the result. Must be in ISO-8601 date/time format. (optional) 
            var poItemState = poItemState_example;  // string | Current state of the purchase order item. If this value is Cancelled, this API will return purchase orders which have one or more items cancelled by Amazon with updated item quantity as zero. (optional) 
            var isPOChanged = isPOChanged_example;  // string | When true, returns purchase orders which were modified after the order was placed. Vendors are required to pull the changed purchase order and fulfill the updated purchase order and not the original one. Default value is false. (optional) 
            var purchaseOrderState = purchaseOrderState_example;  // string | Filters purchase orders based on the purchase order state. (optional) 
            var orderingVendorCode = orderingVendorCode_example;  // string | Filters purchase orders based on the specified ordering vendor code. This value should be same as 'sellingParty.partyId' in the purchase order. If not included in the filter, all purchase orders for all of the vendor codes that exist in the vendor group used to authorize the API client application are returned. (optional) 

            try
            {
                GetPurchaseOrdersResponse result = apiInstance.GetPurchaseOrders(limit, createdAfter, createdBefore, sortOrder, nextToken, includeDetails, changedAfter, changedBefore, poItemState, isPOChanged, purchaseOrderState, orderingVendorCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorOrdersApi.GetPurchaseOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| The limit to the number of records returned. Default value is 100 records. | [optional] 
 **createdAfter** | **DateTime?**| Purchase orders that became available after this time will be included in the result. Must be in ISO-8601 date/time format. | [optional] 
 **createdBefore** | **DateTime?**| Purchase orders that became available before this time will be included in the result. Must be in ISO-8601 date/time format. | [optional] 
 **sortOrder** | **string**| Sort in ascending or descending order by purchase order creation date. | [optional] 
 **nextToken** | **string**| Used for pagination when there is more purchase orders than the specified result size limit. The token value is returned in the previous API call | [optional] 
 **includeDetails** | **string**| When true, returns purchase orders with complete details. Otherwise, only purchase order numbers are returned. Default value is true. | [optional] 
 **changedAfter** | **DateTime?**| Purchase orders that changed after this timestamp will be included in the result. Must be in ISO-8601 date/time format. | [optional] 
 **changedBefore** | **DateTime?**| Purchase orders that changed before this timestamp will be included in the result. Must be in ISO-8601 date/time format. | [optional] 
 **poItemState** | **string**| Current state of the purchase order item. If this value is Cancelled, this API will return purchase orders which have one or more items cancelled by Amazon with updated item quantity as zero. | [optional] 
 **isPOChanged** | **string**| When true, returns purchase orders which were modified after the order was placed. Vendors are required to pull the changed purchase order and fulfill the updated purchase order and not the original one. Default value is false. | [optional] 
 **purchaseOrderState** | **string**| Filters purchase orders based on the purchase order state. | [optional] 
 **orderingVendorCode** | **string**| Filters purchase orders based on the specified ordering vendor code. This value should be same as &#39;sellingParty.partyId&#39; in the purchase order. If not included in the filter, all purchase orders for all of the vendor codes that exist in the vendor group used to authorize the API client application are returned. | [optional] 

### Return type

[**GetPurchaseOrdersResponse**](GetPurchaseOrdersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpurchaseordersstatus"></a>
# **GetPurchaseOrdersStatus**
> GetPurchaseOrdersStatusResponse GetPurchaseOrdersStatus (long? limit = null, string sortOrder = null, string nextToken = null, DateTime? createdAfter = null, DateTime? createdBefore = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, string purchaseOrderNumber = null, string purchaseOrderStatus = null, string itemConfirmationStatus = null, string itemReceiveStatus = null, string orderingVendorCode = null, string shipToPartyId = null)



Returns purchase order statuses based on the filters that you specify. Date range to search must not be more than 7 days. You can return a list of purchase order statuses using the available filters, or a single purchase order status by providing the purchase order number.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorOrders;

namespace Example
{
    public class GetPurchaseOrdersStatusExample
    {
        public void main()
        {
            var apiInstance = new VendorOrdersApi();
            var limit = 789;  // long? | The limit to the number of records returned. Default value is 100 records. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort in ascending or descending order by purchase order creation date. (optional) 
            var nextToken = nextToken_example;  // string | Used for pagination when there are more purchase orders than the specified result size limit. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Purchase orders that became available after this timestamp will be included in the result. Must be in ISO-8601 date/time format. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Purchase orders that became available before this timestamp will be included in the result. Must be in ISO-8601 date/time format. (optional) 
            var updatedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Purchase orders for which the last purchase order update happened after this timestamp will be included in the result. Must be in ISO-8601 date/time format. (optional) 
            var updatedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Purchase orders for which the last purchase order update happened before this timestamp will be included in the result. Must be in ISO-8601 date/time format. (optional) 
            var purchaseOrderNumber = purchaseOrderNumber_example;  // string | Provides purchase order status for the specified purchase order number. (optional) 
            var purchaseOrderStatus = purchaseOrderStatus_example;  // string | Filters purchase orders based on the specified purchase order status. If not included in filter, this will return purchase orders for all statuses. (optional) 
            var itemConfirmationStatus = itemConfirmationStatus_example;  // string | Filters purchase orders based on their item confirmation status. If the item confirmation status is not included in the filter, purchase orders for all confirmation statuses are included. (optional) 
            var itemReceiveStatus = itemReceiveStatus_example;  // string | Filters purchase orders based on the purchase order's item receive status. If the item receive status is not included in the filter, purchase orders for all receive statuses are included. (optional) 
            var orderingVendorCode = orderingVendorCode_example;  // string | Filters purchase orders based on the specified ordering vendor code. This value should be same as 'sellingParty.partyId' in the purchase order. If not included in filter, all purchase orders for all the vendor codes that exist in the vendor group used to authorize API client application are returned. (optional) 
            var shipToPartyId = shipToPartyId_example;  // string | Filters purchase orders for a specific buyer's Fulfillment Center/warehouse by providing ship to location id here. This value should be same as 'shipToParty.partyId' in the purchase order. If not included in filter, this will return purchase orders for all the buyer's warehouses used for vendor group purchase orders. (optional) 

            try
            {
                GetPurchaseOrdersStatusResponse result = apiInstance.GetPurchaseOrdersStatus(limit, sortOrder, nextToken, createdAfter, createdBefore, updatedAfter, updatedBefore, purchaseOrderNumber, purchaseOrderStatus, itemConfirmationStatus, itemReceiveStatus, orderingVendorCode, shipToPartyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorOrdersApi.GetPurchaseOrdersStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| The limit to the number of records returned. Default value is 100 records. | [optional] 
 **sortOrder** | **string**| Sort in ascending or descending order by purchase order creation date. | [optional] 
 **nextToken** | **string**| Used for pagination when there are more purchase orders than the specified result size limit. | [optional] 
 **createdAfter** | **DateTime?**| Purchase orders that became available after this timestamp will be included in the result. Must be in ISO-8601 date/time format. | [optional] 
 **createdBefore** | **DateTime?**| Purchase orders that became available before this timestamp will be included in the result. Must be in ISO-8601 date/time format. | [optional] 
 **updatedAfter** | **DateTime?**| Purchase orders for which the last purchase order update happened after this timestamp will be included in the result. Must be in ISO-8601 date/time format. | [optional] 
 **updatedBefore** | **DateTime?**| Purchase orders for which the last purchase order update happened before this timestamp will be included in the result. Must be in ISO-8601 date/time format. | [optional] 
 **purchaseOrderNumber** | **string**| Provides purchase order status for the specified purchase order number. | [optional] 
 **purchaseOrderStatus** | **string**| Filters purchase orders based on the specified purchase order status. If not included in filter, this will return purchase orders for all statuses. | [optional] 
 **itemConfirmationStatus** | **string**| Filters purchase orders based on their item confirmation status. If the item confirmation status is not included in the filter, purchase orders for all confirmation statuses are included. | [optional] 
 **itemReceiveStatus** | **string**| Filters purchase orders based on the purchase order&#39;s item receive status. If the item receive status is not included in the filter, purchase orders for all receive statuses are included. | [optional] 
 **orderingVendorCode** | **string**| Filters purchase orders based on the specified ordering vendor code. This value should be same as &#39;sellingParty.partyId&#39; in the purchase order. If not included in filter, all purchase orders for all the vendor codes that exist in the vendor group used to authorize API client application are returned. | [optional] 
 **shipToPartyId** | **string**| Filters purchase orders for a specific buyer&#39;s Fulfillment Center/warehouse by providing ship to location id here. This value should be same as &#39;shipToParty.partyId&#39; in the purchase order. If not included in filter, this will return purchase orders for all the buyer&#39;s warehouses used for vendor group purchase orders. | [optional] 

### Return type

[**GetPurchaseOrdersStatusResponse**](GetPurchaseOrdersStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitacknowledgement"></a>
# **SubmitAcknowledgement**
> SubmitAcknowledgementResponse SubmitAcknowledgement (SubmitAcknowledgementRequest body)



Submits acknowledgements for one or more purchase orders.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorOrders;

namespace Example
{
    public class SubmitAcknowledgementExample
    {
        public void main()
        {
            var apiInstance = new VendorOrdersApi();
            var body = new SubmitAcknowledgementRequest(); // SubmitAcknowledgementRequest | Submits acknowledgements for one or more purchase orders from a vendor.

            try
            {
                SubmitAcknowledgementResponse result = apiInstance.SubmitAcknowledgement(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorOrdersApi.SubmitAcknowledgement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmitAcknowledgementRequest**](SubmitAcknowledgementRequest.md)| Submits acknowledgements for one or more purchase orders from a vendor. | 

### Return type

[**SubmitAcknowledgementResponse**](SubmitAcknowledgementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

