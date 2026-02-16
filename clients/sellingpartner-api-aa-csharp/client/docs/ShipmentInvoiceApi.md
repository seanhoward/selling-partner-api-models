# Amazon.SellingPartnerAPIAA.Clients.API.ShipmentInvoiceApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInvoiceStatus**](ShipmentInvoiceApi.md#getinvoicestatus) | **GET** /fba/outbound/brazil/v0/shipments/{shipmentId}/invoice/status | 
[**GetShipmentDetails**](ShipmentInvoiceApi.md#getshipmentdetails) | **GET** /fba/outbound/brazil/v0/shipments/{shipmentId} | 
[**SubmitInvoice**](ShipmentInvoiceApi.md#submitinvoice) | **POST** /fba/outbound/brazil/v0/shipments/{shipmentId}/invoice | 


<a name="getinvoicestatus"></a>
# **GetInvoiceStatus**
> GetInvoiceStatusResponse GetInvoiceStatus (string shipmentId)



Returns the invoice status for the shipment you specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1.133 | 25 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ShipmentInvoicing;

namespace Example
{
    public class GetInvoiceStatusExample
    {
        public void main()
        {
            var apiInstance = new ShipmentInvoiceApi();
            var shipmentId = shipmentId_example;  // string | The shipment identifier for the shipment.

            try
            {
                GetInvoiceStatusResponse result = apiInstance.GetInvoiceStatus(shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentInvoiceApi.GetInvoiceStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The shipment identifier for the shipment. | 

### Return type

[**GetInvoiceStatusResponse**](GetInvoiceStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipmentdetails"></a>
# **GetShipmentDetails**
> GetShipmentDetailsResponse GetShipmentDetails (string shipmentId)



Returns the shipment details required to issue an invoice for the specified shipment.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1.133 | 25 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ShipmentInvoicing;

namespace Example
{
    public class GetShipmentDetailsExample
    {
        public void main()
        {
            var apiInstance = new ShipmentInvoiceApi();
            var shipmentId = shipmentId_example;  // string | The identifier for the shipment. Get this value from the FBAOutboundShipmentStatus notification. For information about subscribing to notifications, see the [Notifications API Use Case Guide](doc:notifications-api-v1-use-case-guide).

            try
            {
                GetShipmentDetailsResponse result = apiInstance.GetShipmentDetails(shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentInvoiceApi.GetShipmentDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The identifier for the shipment. Get this value from the FBAOutboundShipmentStatus notification. For information about subscribing to notifications, see the [Notifications API Use Case Guide](doc:notifications-api-v1-use-case-guide). | 

### Return type

[**GetShipmentDetailsResponse**](GetShipmentDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitinvoice"></a>
# **SubmitInvoice**
> SubmitInvoiceResponse SubmitInvoice (string shipmentId, SubmitInvoiceRequest body)



Submits a shipment invoice document for a given shipment.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1.133 | 25 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ShipmentInvoicing;

namespace Example
{
    public class SubmitInvoiceExample
    {
        public void main()
        {
            var apiInstance = new ShipmentInvoiceApi();
            var shipmentId = shipmentId_example;  // string | The identifier for the shipment.
            var body = new SubmitInvoiceRequest(); // SubmitInvoiceRequest | 

            try
            {
                SubmitInvoiceResponse result = apiInstance.SubmitInvoice(shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentInvoiceApi.SubmitInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The identifier for the shipment. | 
 **body** | [**SubmitInvoiceRequest**](SubmitInvoiceRequest.md)|  | 

### Return type

[**SubmitInvoiceResponse**](SubmitInvoiceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

