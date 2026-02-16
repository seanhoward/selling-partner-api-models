# Amazon.SellingPartnerAPIAA.Clients.API.VendorInvoiceApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubmitInvoice**](VendorInvoiceApi.md#submitinvoice) | **POST** /vendor/directFulfillment/payments/v1/invoices | 


<a name="submitinvoice"></a>
# **SubmitInvoice**
> SubmitInvoiceResponse SubmitInvoice (SubmitInvoiceRequest body)



Submits one or more invoices for a vendor's direct fulfillment orders.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentPayments;

namespace Example
{
    public class SubmitInvoiceExample
    {
        public void main()
        {
            var apiInstance = new VendorInvoiceApi();
            var body = new SubmitInvoiceRequest(); // SubmitInvoiceRequest | The request body containing one or more invoices for vendor orders.

            try
            {
                SubmitInvoiceResponse result = apiInstance.SubmitInvoice(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorInvoiceApi.SubmitInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmitInvoiceRequest**](SubmitInvoiceRequest.md)| The request body containing one or more invoices for vendor orders. | 

### Return type

[**SubmitInvoiceResponse**](SubmitInvoiceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

