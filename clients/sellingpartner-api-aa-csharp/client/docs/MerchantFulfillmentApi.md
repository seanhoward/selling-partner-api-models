# Amazon.SellingPartnerAPIAA.Clients.API.MerchantFulfillmentApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelShipment**](MerchantFulfillmentApi.md#cancelshipment) | **DELETE** /mfn/v0/shipments/{shipmentId} | 
[**CreateShipment**](MerchantFulfillmentApi.md#createshipment) | **POST** /mfn/v0/shipments | 
[**GetAdditionalSellerInputs**](MerchantFulfillmentApi.md#getadditionalsellerinputs) | **POST** /mfn/v0/additionalSellerInputs | 
[**GetEligibleShipmentServices**](MerchantFulfillmentApi.md#geteligibleshipmentservices) | **POST** /mfn/v0/eligibleShippingServices | 
[**GetShipment**](MerchantFulfillmentApi.md#getshipment) | **GET** /mfn/v0/shipments/{shipmentId} | 


<a name="cancelshipment"></a>
# **CancelShipment**
> CancelShipmentResponse CancelShipment (string shipmentId)



Cancel the shipment indicated by the specified shipment identifier.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that are applied to the requested operation when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the SP-API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment;

namespace Example
{
    public class CancelShipmentExample
    {
        public void main()
        {
            var apiInstance = new MerchantFulfillmentApi();
            var shipmentId = shipmentId_example;  // string | The Amazon-defined shipment identifier for the shipment to cancel.

            try
            {
                CancelShipmentResponse result = apiInstance.CancelShipment(shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantFulfillmentApi.CancelShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The Amazon-defined shipment identifier for the shipment to cancel. | 

### Return type

[**CancelShipmentResponse**](CancelShipmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createshipment"></a>
# **CreateShipment**
> CreateShipmentResponse CreateShipment (CreateShipmentRequest body)



Create a shipment with the information provided.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that are applied to the requested operation when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the SP-API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment;

namespace Example
{
    public class CreateShipmentExample
    {
        public void main()
        {
            var apiInstance = new MerchantFulfillmentApi();
            var body = new CreateShipmentRequest(); // CreateShipmentRequest | The request schema for the `CreateShipment` operation.

            try
            {
                CreateShipmentResponse result = apiInstance.CreateShipment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantFulfillmentApi.CreateShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateShipmentRequest**](CreateShipmentRequest.md)| The request schema for the &#x60;CreateShipment&#x60; operation. | 

### Return type

[**CreateShipmentResponse**](CreateShipmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getadditionalsellerinputs"></a>
# **GetAdditionalSellerInputs**
> GetAdditionalSellerInputsResponse GetAdditionalSellerInputs (GetAdditionalSellerInputsRequest body)



Gets a list of additional seller inputs required for a ship method. This is generally used for international shipping.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that are applied to the requested operation when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the SP-API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment;

namespace Example
{
    public class GetAdditionalSellerInputsExample
    {
        public void main()
        {
            var apiInstance = new MerchantFulfillmentApi();
            var body = new GetAdditionalSellerInputsRequest(); // GetAdditionalSellerInputsRequest | The request schema for the `GetAdditionalSellerInputs` operation.

            try
            {
                GetAdditionalSellerInputsResponse result = apiInstance.GetAdditionalSellerInputs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantFulfillmentApi.GetAdditionalSellerInputs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetAdditionalSellerInputsRequest**](GetAdditionalSellerInputsRequest.md)| The request schema for the &#x60;GetAdditionalSellerInputs&#x60; operation. | 

### Return type

[**GetAdditionalSellerInputsResponse**](GetAdditionalSellerInputsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteligibleshipmentservices"></a>
# **GetEligibleShipmentServices**
> GetEligibleShipmentServicesResponse GetEligibleShipmentServices (GetEligibleShipmentServicesRequest body)



Returns a list of shipping service offers that satisfy the specified shipment request details.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 6 | 12 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that are applied to the requested operation when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the SP-API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment;

namespace Example
{
    public class GetEligibleShipmentServicesExample
    {
        public void main()
        {
            var apiInstance = new MerchantFulfillmentApi();
            var body = new GetEligibleShipmentServicesRequest(); // GetEligibleShipmentServicesRequest | The request schema for the `GetEligibleShipmentServices` operation.

            try
            {
                GetEligibleShipmentServicesResponse result = apiInstance.GetEligibleShipmentServices(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantFulfillmentApi.GetEligibleShipmentServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetEligibleShipmentServicesRequest**](GetEligibleShipmentServicesRequest.md)| The request schema for the &#x60;GetEligibleShipmentServices&#x60; operation. | 

### Return type

[**GetEligibleShipmentServicesResponse**](GetEligibleShipmentServicesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipment"></a>
# **GetShipment**
> GetShipmentResponse GetShipment (string shipmentId)



Returns the shipment information for an existing shipment.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that are applied to the requested operation when available. The preceding table indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the SP-API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment;

namespace Example
{
    public class GetShipmentExample
    {
        public void main()
        {
            var apiInstance = new MerchantFulfillmentApi();
            var shipmentId = shipmentId_example;  // string | The Amazon-defined shipment identifier for the shipment.

            try
            {
                GetShipmentResponse result = apiInstance.GetShipment(shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantFulfillmentApi.GetShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The Amazon-defined shipment identifier for the shipment. | 

### Return type

[**GetShipmentResponse**](GetShipmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

