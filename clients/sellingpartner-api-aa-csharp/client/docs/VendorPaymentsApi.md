# Amazon.SellingPartnerAPIAA.Clients.API.VendorPaymentsApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubmitInvoices**](VendorPaymentsApi.md#submitinvoices) | **POST** /vendor/payments/v1/invoices | 


<a name="submitinvoices"></a>
# **SubmitInvoices**
> SubmitInvoicesResponse SubmitInvoices (SubmitInvoicesRequest body)



Submit new invoices to Amazon.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorInvoices;

namespace Example
{
    public class SubmitInvoicesExample
    {
        public void main()
        {
            var apiInstance = new VendorPaymentsApi();
            var body = new SubmitInvoicesRequest(); // SubmitInvoicesRequest | The request body containing the invoice data to submit.

            try
            {
                SubmitInvoicesResponse result = apiInstance.SubmitInvoices(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorPaymentsApi.SubmitInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmitInvoicesRequest**](SubmitInvoicesRequest.md)| The request body containing the invoice data to submit. | 

### Return type

[**SubmitInvoicesResponse**](SubmitInvoicesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

