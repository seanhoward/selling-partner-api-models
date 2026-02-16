# Amazon.SellingPartnerAPIAA.Clients.API.CustomerInvoicesApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCustomerInvoice**](CustomerInvoicesApi.md#getcustomerinvoice) | **GET** /vendor/directFulfillment/shipping/2021-12-28/customerInvoices/{purchaseOrderNumber} | getCustomerInvoice
[**GetCustomerInvoices**](CustomerInvoicesApi.md#getcustomerinvoices) | **GET** /vendor/directFulfillment/shipping/2021-12-28/customerInvoices | getCustomerInvoices


<a name="getcustomerinvoice"></a>
# **GetCustomerInvoice**
> CustomerInvoice GetCustomerInvoice (string purchaseOrderNumber)

getCustomerInvoice

Returns a customer invoice based on the purchaseOrderNumber that you specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values then those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping;

namespace Example
{
    public class GetCustomerInvoiceExample
    {
        public void main()
        {
            var apiInstance = new CustomerInvoicesApi();
            var purchaseOrderNumber = purchaseOrderNumber_example;  // string | Purchase order number of the shipment for which to return the invoice.

            try
            {
                // getCustomerInvoice
                CustomerInvoice result = apiInstance.GetCustomerInvoice(purchaseOrderNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoicesApi.GetCustomerInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchaseOrderNumber** | **string**| Purchase order number of the shipment for which to return the invoice. | 

### Return type

[**CustomerInvoice**](CustomerInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerinvoices"></a>
# **GetCustomerInvoices**
> CustomerInvoiceList GetCustomerInvoices (DateTime? createdAfter, DateTime? createdBefore, string shipFromPartyId = null, int? limit = null, string sortOrder = null, string nextToken = null)

getCustomerInvoices

Returns a list of customer invoices created during a time frame that you specify. You define the time frame using the createdAfter and createdBefore parameters. You must use both of these parameters. The date range to search must be no more than 7 days.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values then those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping;

namespace Example
{
    public class GetCustomerInvoicesExample
    {
        public void main()
        {
            var apiInstance = new CustomerInvoicesApi();
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | Orders that became available after this date and time will be included in the result. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | Orders that became available before this date and time will be included in the result. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.
            var shipFromPartyId = shipFromPartyId_example;  // string | The vendor warehouseId for order fulfillment. If not specified, the result will contain orders for all warehouses. (optional) 
            var limit = 56;  // int? | The limit to the number of records returned (optional) 
            var sortOrder = sortOrder_example;  // string | Sort ASC or DESC by order creation date. (optional) 
            var nextToken = nextToken_example;  // string | Used for pagination when there are more orders than the specified result size limit. The token value is returned in the previous API call. (optional) 

            try
            {
                // getCustomerInvoices
                CustomerInvoiceList result = apiInstance.GetCustomerInvoices(createdAfter, createdBefore, shipFromPartyId, limit, sortOrder, nextToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoicesApi.GetCustomerInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createdAfter** | **DateTime?**| Orders that became available after this date and time will be included in the result. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. | 
 **createdBefore** | **DateTime?**| Orders that became available before this date and time will be included in the result. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. | 
 **shipFromPartyId** | **string**| The vendor warehouseId for order fulfillment. If not specified, the result will contain orders for all warehouses. | [optional] 
 **limit** | **int?**| The limit to the number of records returned | [optional] 
 **sortOrder** | **string**| Sort ASC or DESC by order creation date. | [optional] 
 **nextToken** | **string**| Used for pagination when there are more orders than the specified result size limit. The token value is returned in the previous API call. | [optional] 

### Return type

[**CustomerInvoiceList**](CustomerInvoiceList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

