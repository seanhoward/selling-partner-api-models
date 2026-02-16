# Amazon.SellingPartnerAPIAA.Clients.API.VendorDFSandboxtransactionstatusApi

All URIs are relative to *https://sandbox.sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrderScenarios**](VendorDFSandboxtransactionstatusApi.md#getorderscenarios) | **GET** /vendor/directFulfillment/sandbox/2021-10-28/transactions/{transactionId} | 


<a name="getorderscenarios"></a>
# **GetOrderScenarios**
> TransactionStatus GetOrderScenarios (string transactionId)



Returns the status of the transaction indicated by the specified transactionId. If the transaction was successful, also returns the requested test order data.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentSandboxData;

namespace Example
{
    public class GetOrderScenariosExample
    {
        public void main()
        {
            var apiInstance = new VendorDFSandboxtransactionstatusApi();
            var transactionId = transactionId_example;  // string | The transaction identifier returned in the response to the generateOrderScenarios operation.

            try
            {
                TransactionStatus result = apiInstance.GetOrderScenarios(transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorDFSandboxtransactionstatusApi.GetOrderScenarios: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionId** | **string**| The transaction identifier returned in the response to the generateOrderScenarios operation. | 

### Return type

[**TransactionStatus**](TransactionStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

