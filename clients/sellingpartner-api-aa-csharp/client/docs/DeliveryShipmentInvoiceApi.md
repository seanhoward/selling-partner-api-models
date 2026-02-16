# Amazon.SellingPartnerAPIAA.Clients.API.DeliveryShipmentInvoiceApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInvoiceStatus**](DeliveryShipmentInvoiceApi.md#getinvoicestatus) | **GET** /delivery/2022-07-01/invoice/status | 
[**SubmitInvoice**](DeliveryShipmentInvoiceApi.md#submitinvoice) | **POST** /delivery/2022-07-01/invoice | 


<a name="getinvoicestatus"></a>
# **GetInvoiceStatus**
> GetInvoiceStatusResponse GetInvoiceStatus (string marketplaceId, string invoiceType, string programType, string orderId = null, string shipmentId = null)



Returns the invoice status for the order or shipment you specify. You must specify either an `orderId` or `shipmentId` as query parameter. If both parameters are supplied, `orderId` takes precedence over `shipmentId`.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1.133 | 25 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.DeliveryShipmentInvoice022-07-01;

namespace Example
{
    public class GetInvoiceStatusExample
    {
        public void main()
        {
            var apiInstance = new DeliveryShipmentInvoiceApi();
            var marketplaceId = A2Q3Y263D00KWC;  // string | The marketplace identifier.
            var invoiceType = Outbound;  // string | The invoice's type.
            var programType = EasyShip;  // string | The Amazon program that seller is currently enrolled.
            var orderId = 123-1234567-1234567;  // string | The order identifier. (optional) 
            var shipmentId = 1234567890123;  // string | The shipment identifier. (optional) 

            try
            {
                GetInvoiceStatusResponse result = apiInstance.GetInvoiceStatus(marketplaceId, invoiceType, programType, orderId, shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryShipmentInvoiceApi.GetInvoiceStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| The marketplace identifier. | 
 **invoiceType** | **string**| The invoice&#39;s type. | 
 **programType** | **string**| The Amazon program that seller is currently enrolled. | 
 **orderId** | **string**| The order identifier. | [optional] 
 **shipmentId** | **string**| The shipment identifier. | [optional] 

### Return type

[**GetInvoiceStatusResponse**](GetInvoiceStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitinvoice"></a>
# **SubmitInvoice**
> SubmitInvoiceResponse SubmitInvoice (SubmitInvoiceRequest body, string orderId = null, string shipmentId = null)



Submits a shipment invoice for a given order or shipment. You must specify either an `orderId` or `shipmentId` as query parameter. If both parameters are supplied, `orderId` takes precedence over `shipmentId`.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1.133 | 25 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.DeliveryShipmentInvoice022-07-01;

namespace Example
{
    public class SubmitInvoiceExample
    {
        public void main()
        {
            var apiInstance = new DeliveryShipmentInvoiceApi();
            var body = new SubmitInvoiceRequest(); // SubmitInvoiceRequest | The request body that specifies invoice, program and marketplace values.
            var orderId = 123-1234567-1234567;  // string | The identifier for the order. (optional) 
            var shipmentId = 1234567890123;  // string | The identifier for the shipment. (optional) 

            try
            {
                SubmitInvoiceResponse result = apiInstance.SubmitInvoice(body, orderId, shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryShipmentInvoiceApi.SubmitInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmitInvoiceRequest**](SubmitInvoiceRequest.md)| The request body that specifies invoice, program and marketplace values. | 
 **orderId** | **string**| The identifier for the order. | [optional] 
 **shipmentId** | **string**| The identifier for the shipment. | [optional] 

### Return type

[**SubmitInvoiceResponse**](SubmitInvoiceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

