# Amazon.SellingPartnerAPIAA.Clients.API.UpdateInventoryApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubmitInventoryUpdate**](UpdateInventoryApi.md#submitinventoryupdate) | **POST** /vendor/directFulfillment/inventory/v1/warehouses/{warehouseId}/items | 


<a name="submitinventoryupdate"></a>
# **SubmitInventoryUpdate**
> SubmitInventoryUpdateResponse SubmitInventoryUpdate (SubmitInventoryUpdateRequest body, string warehouseId)



Submits inventory updates for the specified warehouse for either a partial or full feed of inventory items.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentInventory;

namespace Example
{
    public class SubmitInventoryUpdateExample
    {
        public void main()
        {
            var apiInstance = new UpdateInventoryApi();
            var body = new SubmitInventoryUpdateRequest(); // SubmitInventoryUpdateRequest | The request body containing the inventory update data to submit.
            var warehouseId = warehouseId_example;  // string | Identifier for the warehouse for which to update inventory.

            try
            {
                SubmitInventoryUpdateResponse result = apiInstance.SubmitInventoryUpdate(body, warehouseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdateInventoryApi.SubmitInventoryUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmitInventoryUpdateRequest**](SubmitInventoryUpdateRequest.md)| The request body containing the inventory update data to submit. | 
 **warehouseId** | **string**| Identifier for the warehouse for which to update inventory. | 

### Return type

[**SubmitInventoryUpdateResponse**](SubmitInventoryUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

