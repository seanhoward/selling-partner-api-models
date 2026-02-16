# Amazon.SellingPartnerAPIAA.Clients.API.VendorDFSandboxApi

All URIs are relative to *https://sandbox.sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateOrderScenarios**](VendorDFSandboxApi.md#generateorderscenarios) | **POST** /vendor/directFulfillment/sandbox/2021-10-28/orders | 


<a name="generateorderscenarios"></a>
# **GenerateOrderScenarios**
> TransactionReference GenerateOrderScenarios (GenerateOrderScenarioRequest body)



Submits a request to generate test order data for Vendor Direct Fulfillment API entities.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentSandboxData;

namespace Example
{
    public class GenerateOrderScenariosExample
    {
        public void main()
        {
            var apiInstance = new VendorDFSandboxApi();
            var body = new GenerateOrderScenarioRequest(); // GenerateOrderScenarioRequest | The request payload containing parameters for generating test order data scenarios.

            try
            {
                TransactionReference result = apiInstance.GenerateOrderScenarios(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorDFSandboxApi.GenerateOrderScenarios: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GenerateOrderScenarioRequest**](GenerateOrderScenarioRequest.md)| The request payload containing parameters for generating test order data scenarios. | 

### Return type

[**TransactionReference**](TransactionReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

