# Amazon.SellingPartnerAPIAA.Clients.API.ShippingApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelShipment**](ShippingApi.md#cancelshipment) | **POST** /shipping/v1/shipments/{shipmentId}/cancel | 
[**CreateShipment**](ShippingApi.md#createshipment) | **POST** /shipping/v1/shipments | 
[**GetAccount**](ShippingApi.md#getaccount) | **GET** /shipping/v1/account | 
[**GetRates**](ShippingApi.md#getrates) | **POST** /shipping/v1/rates | 
[**GetShipment**](ShippingApi.md#getshipment) | **GET** /shipping/v1/shipments/{shipmentId} | 
[**GetTrackingInformation**](ShippingApi.md#gettrackinginformation) | **GET** /shipping/v1/tracking/{trackingId} | 
[**PurchaseLabels**](ShippingApi.md#purchaselabels) | **POST** /shipping/v1/shipments/{shipmentId}/purchaseLabels | 
[**PurchaseShipment**](ShippingApi.md#purchaseshipment) | **POST** /shipping/v1/purchaseShipment | 
[**RetrieveShippingLabel**](ShippingApi.md#retrieveshippinglabel) | **POST** /shipping/v1/shipments/{shipmentId}/containers/{trackingId}/label | 


<a name="cancelshipment"></a>
# **CancelShipment**
> CancelShipmentResponse CancelShipment (string shipmentId)



Cancel a shipment by the given shipmentId.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 15 |  For more information, see \"Usage Plans and Rate Limits\" in the Selling Partner API documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Shipping;

namespace Example
{
    public class CancelShipmentExample
    {
        public void main()
        {
            var apiInstance = new ShippingApi();
            var shipmentId = shipmentId_example;  // string | Shipment Id to cancel a shipment

            try
            {
                CancelShipmentResponse result = apiInstance.CancelShipment(shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingApi.CancelShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| Shipment Id to cancel a shipment | 

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



Create a new shipment.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Shipping;

namespace Example
{
    public class CreateShipmentExample
    {
        public void main()
        {
            var apiInstance = new ShippingApi();
            var body = new CreateShipmentRequest(); // CreateShipmentRequest | CreateShipmentRequest Body

            try
            {
                CreateShipmentResponse result = apiInstance.CreateShipment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingApi.CreateShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateShipmentRequest**](CreateShipmentRequest.md)| CreateShipmentRequest Body | 

### Return type

[**CreateShipmentResponse**](CreateShipmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccount"></a>
# **GetAccount**
> GetAccountResponse GetAccount ()



Verify if the current account is valid.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 15 |  For more information, see \"Usage Plans and Rate Limits\" in the Selling Partner API documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Shipping;

namespace Example
{
    public class GetAccountExample
    {
        public void main()
        {
            var apiInstance = new ShippingApi();

            try
            {
                GetAccountResponse result = apiInstance.GetAccount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingApi.GetAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetAccountResponse**](GetAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrates"></a>
# **GetRates**
> GetRatesResponse GetRates (GetRatesRequest body)



Get service rates.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 15 |  For more information, see \"Usage Plans and Rate Limits\" in the Selling Partner API documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Shipping;

namespace Example
{
    public class GetRatesExample
    {
        public void main()
        {
            var apiInstance = new ShippingApi();
            var body = new GetRatesRequest(); // GetRatesRequest | GetRatesRequest body

            try
            {
                GetRatesResponse result = apiInstance.GetRates(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingApi.GetRates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetRatesRequest**](GetRatesRequest.md)| GetRatesRequest body | 

### Return type

[**GetRatesResponse**](GetRatesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipment"></a>
# **GetShipment**
> GetShipmentResponse GetShipment (string shipmentId)



Return the entire shipment object for the shipmentId.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 15 |  For more information, see \"Usage Plans and Rate Limits\" in the Selling Partner API documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Shipping;

namespace Example
{
    public class GetShipmentExample
    {
        public void main()
        {
            var apiInstance = new ShippingApi();
            var shipmentId = shipmentId_example;  // string | Shipment id to return the entire shipment object

            try
            {
                GetShipmentResponse result = apiInstance.GetShipment(shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingApi.GetShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| Shipment id to return the entire shipment object | 

### Return type

[**GetShipmentResponse**](GetShipmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettrackinginformation"></a>
# **GetTrackingInformation**
> GetTrackingInformationResponse GetTrackingInformation (string trackingId)



Return the tracking information of a shipment.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  For more information, see \"Usage Plans and Rate Limits\" in the Selling Partner API documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Shipping;

namespace Example
{
    public class GetTrackingInformationExample
    {
        public void main()
        {
            var apiInstance = new ShippingApi();
            var trackingId = trackingId_example;  // string | Tracking Id

            try
            {
                GetTrackingInformationResponse result = apiInstance.GetTrackingInformation(trackingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingApi.GetTrackingInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **trackingId** | **string**| Tracking Id | 

### Return type

[**GetTrackingInformationResponse**](GetTrackingInformationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaselabels"></a>
# **PurchaseLabels**
> PurchaseLabelsResponse PurchaseLabels (string shipmentId, PurchaseLabelsRequest body)



Purchase shipping labels based on a given rate.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 15 |  For more information, see \"Usage Plans and Rate Limits\" in the Selling Partner API documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Shipping;

namespace Example
{
    public class PurchaseLabelsExample
    {
        public void main()
        {
            var apiInstance = new ShippingApi();
            var shipmentId = shipmentId_example;  // string | Shipment id for purchase shipping label
            var body = new PurchaseLabelsRequest(); // PurchaseLabelsRequest | PurchaseShippingLabelRequest body

            try
            {
                PurchaseLabelsResponse result = apiInstance.PurchaseLabels(shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingApi.PurchaseLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| Shipment id for purchase shipping label | 
 **body** | [**PurchaseLabelsRequest**](PurchaseLabelsRequest.md)| PurchaseShippingLabelRequest body | 

### Return type

[**PurchaseLabelsResponse**](PurchaseLabelsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseshipment"></a>
# **PurchaseShipment**
> PurchaseShipmentResponse PurchaseShipment (PurchaseShipmentRequest body)



Purchase shipping labels.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 15 |  For more information, see \"Usage Plans and Rate Limits\" in the Selling Partner API documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Shipping;

namespace Example
{
    public class PurchaseShipmentExample
    {
        public void main()
        {
            var apiInstance = new ShippingApi();
            var body = new PurchaseShipmentRequest(); // PurchaseShipmentRequest | PurchaseShipmentRequest body

            try
            {
                PurchaseShipmentResponse result = apiInstance.PurchaseShipment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingApi.PurchaseShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseShipmentRequest**](PurchaseShipmentRequest.md)| PurchaseShipmentRequest body | 

### Return type

[**PurchaseShipmentResponse**](PurchaseShipmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveshippinglabel"></a>
# **RetrieveShippingLabel**
> RetrieveShippingLabelResponse RetrieveShippingLabel (string shipmentId, string trackingId, RetrieveShippingLabelRequest body)



Retrieve shipping label based on the shipment id and tracking id.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 15 |  For more information, see \"Usage Plans and Rate Limits\" in the Selling Partner API documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Shipping;

namespace Example
{
    public class RetrieveShippingLabelExample
    {
        public void main()
        {
            var apiInstance = new ShippingApi();
            var shipmentId = shipmentId_example;  // string | Shipment Id to retreive label
            var trackingId = trackingId_example;  // string | Tracking Id
            var body = new RetrieveShippingLabelRequest(); // RetrieveShippingLabelRequest | RetrieveShippingLabelRequest body

            try
            {
                RetrieveShippingLabelResponse result = apiInstance.RetrieveShippingLabel(shipmentId, trackingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingApi.RetrieveShippingLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| Shipment Id to retreive label | 
 **trackingId** | **string**| Tracking Id | 
 **body** | [**RetrieveShippingLabelRequest**](RetrieveShippingLabelRequest.md)| RetrieveShippingLabelRequest body | 

### Return type

[**RetrieveShippingLabelResponse**](RetrieveShippingLabelResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

