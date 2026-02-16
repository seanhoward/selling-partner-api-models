# Amazon.SellingPartnerAPIAA.Clients.API.ShipmentProcessingApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePackages**](ShipmentProcessingApi.md#createpackages) | **POST** /externalFulfillment/2024-09-11/shipments/{shipmentId}/packages | 
[**GenerateInvoice**](ShipmentProcessingApi.md#generateinvoice) | **POST** /externalFulfillment/2024-09-11/shipments/{shipmentId}/invoice | 
[**GenerateShipLabels**](ShipmentProcessingApi.md#generateshiplabels) | **PUT** /externalFulfillment/2024-09-11/shipments/{shipmentId}/shipLabels | 
[**ProcessShipment**](ShipmentProcessingApi.md#processshipment) | **POST** /externalFulfillment/2024-09-11/shipments/{shipmentId} | 
[**RetrieveInvoice**](ShipmentProcessingApi.md#retrieveinvoice) | **GET** /externalFulfillment/2024-09-11/shipments/{shipmentId}/invoice | 
[**RetrieveShippingOptions**](ShipmentProcessingApi.md#retrieveshippingoptions) | **GET** /externalFulfillment/2024-09-11/shipments/{shipmentId}/shippingOptions | 
[**UpdatePackage**](ShipmentProcessingApi.md#updatepackage) | **PUT** /externalFulfillment/2024-09-11/shipments/{shipmentId}/packages/{packageId} | 
[**UpdatePackageStatus**](ShipmentProcessingApi.md#updatepackagestatus) | **PATCH** /externalFulfillment/2024-09-11/shipments/{shipmentId}/packages/{packageId} | 


<a name="createpackages"></a>
# **CreatePackages**
> void CreatePackages (string shipmentId, Packages body)



Provide details about the packages in the specified shipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments;

namespace Example
{
    public class CreatePackagesExample
    {
        public void main()
        {
            var apiInstance = new ShipmentProcessingApi();
            var shipmentId = shipmentId_example;  // string | The ID of the shipment.
            var body = new Packages(); // Packages | A list of packages in the shipment.

            try
            {
                apiInstance.CreatePackages(shipmentId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentProcessingApi.CreatePackages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The ID of the shipment. | 
 **body** | [**Packages**](Packages.md)| A list of packages in the shipment. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateinvoice"></a>
# **GenerateInvoice**
> InvoiceResponse GenerateInvoice (string shipmentId)



Get invoices for the shipment you specify.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments;

namespace Example
{
    public class GenerateInvoiceExample
    {
        public void main()
        {
            var apiInstance = new ShipmentProcessingApi();
            var shipmentId = shipmentId_example;  // string | The ID of the shipment whose invoice you want.

            try
            {
                InvoiceResponse result = apiInstance.GenerateInvoice(shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentProcessingApi.GenerateInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The ID of the shipment whose invoice you want. | 

### Return type

[**InvoiceResponse**](InvoiceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateshiplabels"></a>
# **GenerateShipLabels**
> ShipLabelsResponse GenerateShipLabels (string shipmentId, string operation, string shippingOptionId = null, ShipLabelsInput body = null)



Generate and retrieve all shipping labels for one or more packages in the shipment you specify.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments;

namespace Example
{
    public class GenerateShipLabelsExample
    {
        public void main()
        {
            var apiInstance = new ShipmentProcessingApi();
            var shipmentId = shipmentId_example;  // string | The ID of the shipment whose shipping labels you want to generate and retrieve.
            var operation = operation_example;  // string | Specify whether you want to generate or regenerate a label.
            var shippingOptionId = shippingOptionId_example;  // string | The ID of the shipping option whose shipping labels you want. (optional) 
            var body = new ShipLabelsInput(); // ShipLabelsInput | Shipping details for when shipping is not done by the marketplace channel. (optional) 

            try
            {
                ShipLabelsResponse result = apiInstance.GenerateShipLabels(shipmentId, operation, shippingOptionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentProcessingApi.GenerateShipLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The ID of the shipment whose shipping labels you want to generate and retrieve. | 
 **operation** | **string**| Specify whether you want to generate or regenerate a label. | 
 **shippingOptionId** | **string**| The ID of the shipping option whose shipping labels you want. | [optional] 
 **body** | [**ShipLabelsInput**](ShipLabelsInput.md)| Shipping details for when shipping is not done by the marketplace channel. | [optional] 

### Return type

[**ShipLabelsResponse**](ShipLabelsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processshipment"></a>
# **ProcessShipment**
> void ProcessShipment (string shipmentId, string operation, ShipmentAcknowledgementRequest body = null)



Confirm or reject the specified shipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments;

namespace Example
{
    public class ProcessShipmentExample
    {
        public void main()
        {
            var apiInstance = new ShipmentProcessingApi();
            var shipmentId = shipmentId_example;  // string | The ID of the shipment you want to confirm or reject.
            var operation = operation_example;  // string | The status of the shipment.
            var body = new ShipmentAcknowledgementRequest(); // ShipmentAcknowledgementRequest | Information about the shipment and its line items. (optional) 

            try
            {
                apiInstance.ProcessShipment(shipmentId, operation, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentProcessingApi.ProcessShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The ID of the shipment you want to confirm or reject. | 
 **operation** | **string**| The status of the shipment. | 
 **body** | [**ShipmentAcknowledgementRequest**](ShipmentAcknowledgementRequest.md)| Information about the shipment and its line items. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveinvoice"></a>
# **RetrieveInvoice**
> InvoiceResponse RetrieveInvoice (string shipmentId)



Retrieve invoices for the shipment you specify.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments;

namespace Example
{
    public class RetrieveInvoiceExample
    {
        public void main()
        {
            var apiInstance = new ShipmentProcessingApi();
            var shipmentId = shipmentId_example;  // string | The ID of the shipment whose invoice you want to retrieve.

            try
            {
                InvoiceResponse result = apiInstance.RetrieveInvoice(shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentProcessingApi.RetrieveInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The ID of the shipment whose invoice you want to retrieve. | 

### Return type

[**InvoiceResponse**](InvoiceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveshippingoptions"></a>
# **RetrieveShippingOptions**
> ShippingOptionsResponse RetrieveShippingOptions (string shipmentId, string packageId)



Get a list of shipping options for a package in a shipment given the shipment's marketplace and channel. If the marketplace and channel have a pre-determined shipping option, then this operation returns an empty response.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments;

namespace Example
{
    public class RetrieveShippingOptionsExample
    {
        public void main()
        {
            var apiInstance = new ShipmentProcessingApi();
            var shipmentId = shipmentId_example;  // string | The ID of the shipment to which the package belongs.
            var packageId = packageId_example;  // string | The ID of the package for which you want to retrieve shipping options.

            try
            {
                ShippingOptionsResponse result = apiInstance.RetrieveShippingOptions(shipmentId, packageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentProcessingApi.RetrieveShippingOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The ID of the shipment to which the package belongs. | 
 **packageId** | **string**| The ID of the package for which you want to retrieve shipping options. | 

### Return type

[**ShippingOptionsResponse**](ShippingOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepackage"></a>
# **UpdatePackage**
> void UpdatePackage (string shipmentId, string packageId, Package body)



Updates the details about the packages that will be used to fulfill the specified shipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments;

namespace Example
{
    public class UpdatePackageExample
    {
        public void main()
        {
            var apiInstance = new ShipmentProcessingApi();
            var shipmentId = shipmentId_example;  // string | The ID of the shipment to which the package belongs.
            var packageId = packageId_example;  // string | The ID of the package whose information you want to update.
            var body = new Package(); // Package | The body of the request.

            try
            {
                apiInstance.UpdatePackage(shipmentId, packageId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentProcessingApi.UpdatePackage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The ID of the shipment to which the package belongs. | 
 **packageId** | **string**| The ID of the package whose information you want to update. | 
 **body** | [**Package**](Package.md)| The body of the request. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepackagestatus"></a>
# **UpdatePackageStatus**
> void UpdatePackageStatus (string shipmentId, string packageId, string status = null, PackageDeliveryStatus body = null)



Updates the status of the packages.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments;

namespace Example
{
    public class UpdatePackageStatusExample
    {
        public void main()
        {
            var apiInstance = new ShipmentProcessingApi();
            var shipmentId = shipmentId_example;  // string | The ID of the shipment to which the package belongs.
            var packageId = packageId_example;  // string | The ID of the package whose status you want to update.
            var status = status_example;  // string | **DEPRECATED**. Do not use. Package status is defined in the body parameter. (optional) 
            var body = new PackageDeliveryStatus(); // PackageDeliveryStatus | The body of the request. (optional) 

            try
            {
                apiInstance.UpdatePackageStatus(shipmentId, packageId, status, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentProcessingApi.UpdatePackageStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The ID of the shipment to which the package belongs. | 
 **packageId** | **string**| The ID of the package whose status you want to update. | 
 **status** | **string**| **DEPRECATED**. Do not use. Package status is defined in the body parameter. | [optional] 
 **body** | [**PackageDeliveryStatus**](PackageDeliveryStatus.md)| The body of the request. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

