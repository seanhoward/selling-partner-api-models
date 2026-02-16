# Amazon.SellingPartnerAPIAA.Clients.API.SupplySourcesApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveSupplySource**](SupplySourcesApi.md#archivesupplysource) | **DELETE** /supplySources/2020-07-01/supplySources/{supplySourceId} | 
[**CreateSupplySource**](SupplySourcesApi.md#createsupplysource) | **POST** /supplySources/2020-07-01/supplySources | 
[**GetSupplySource**](SupplySourcesApi.md#getsupplysource) | **GET** /supplySources/2020-07-01/supplySources/{supplySourceId} | 
[**GetSupplySources**](SupplySourcesApi.md#getsupplysources) | **GET** /supplySources/2020-07-01/supplySources | 
[**UpdateSupplySource**](SupplySourcesApi.md#updatesupplysource) | **PUT** /supplySources/2020-07-01/supplySources/{supplySourceId} | 
[**UpdateSupplySourceStatus**](SupplySourcesApi.md#updatesupplysourcestatus) | **PUT** /supplySources/2020-07-01/supplySources/{supplySourceId}/status | 


<a name="archivesupplysource"></a>
# **ArchiveSupplySource**
> ErrorList ArchiveSupplySource (string supplySourceId)



Archive a supply source, making it inactive. Cannot be undone.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources;

namespace Example
{
    public class ArchiveSupplySourceExample
    {
        public void main()
        {
            var apiInstance = new SupplySourcesApi();
            var supplySourceId = supplySourceId_example;  // string | The unique identifier of a supply source.

            try
            {
                ErrorList result = apiInstance.ArchiveSupplySource(supplySourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplySourcesApi.ArchiveSupplySource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplySourceId** | **string**| The unique identifier of a supply source. | 

### Return type

[**ErrorList**](ErrorList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsupplysource"></a>
# **CreateSupplySource**
> CreateSupplySourceResponse CreateSupplySource (CreateSupplySourceRequest payload)



Create a new supply source.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources;

namespace Example
{
    public class CreateSupplySourceExample
    {
        public void main()
        {
            var apiInstance = new SupplySourcesApi();
            var payload = new CreateSupplySourceRequest(); // CreateSupplySourceRequest | A request to create a supply source.

            try
            {
                CreateSupplySourceResponse result = apiInstance.CreateSupplySource(payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplySourcesApi.CreateSupplySource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payload** | [**CreateSupplySourceRequest**](CreateSupplySourceRequest.md)| A request to create a supply source. | 

### Return type

[**CreateSupplySourceResponse**](CreateSupplySourceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsupplysource"></a>
# **GetSupplySource**
> SupplySource GetSupplySource (string supplySourceId)



Retrieve a supply source.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources;

namespace Example
{
    public class GetSupplySourceExample
    {
        public void main()
        {
            var apiInstance = new SupplySourcesApi();
            var supplySourceId = supplySourceId_example;  // string | The unique identifier of a supply source.

            try
            {
                SupplySource result = apiInstance.GetSupplySource(supplySourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplySourcesApi.GetSupplySource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplySourceId** | **string**| The unique identifier of a supply source. | 

### Return type

[**SupplySource**](SupplySource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsupplysources"></a>
# **GetSupplySources**
> GetSupplySourcesResponse GetSupplySources (string nextPageToken = null, decimal? pageSize = null)



The path to retrieve paginated supply sources.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources;

namespace Example
{
    public class GetSupplySourcesExample
    {
        public void main()
        {
            var apiInstance = new SupplySourcesApi();
            var nextPageToken = nextPageToken_example;  // string | The pagination token to retrieve a specific page of results. (optional) 
            var pageSize = 8.14;  // decimal? | The number of supply sources to return per paginated request. (optional)  (default to 10)

            try
            {
                GetSupplySourcesResponse result = apiInstance.GetSupplySources(nextPageToken, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplySourcesApi.GetSupplySources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nextPageToken** | **string**| The pagination token to retrieve a specific page of results. | [optional] 
 **pageSize** | **decimal?**| The number of supply sources to return per paginated request. | [optional] [default to 10]

### Return type

[**GetSupplySourcesResponse**](GetSupplySourcesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesupplysource"></a>
# **UpdateSupplySource**
> ErrorList UpdateSupplySource (string supplySourceId, UpdateSupplySourceRequest payload = null)



Update the configuration and capabilities of a supply source.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources;

namespace Example
{
    public class UpdateSupplySourceExample
    {
        public void main()
        {
            var apiInstance = new SupplySourcesApi();
            var supplySourceId = supplySourceId_example;  // string | The unique identitier of a supply source.
            var payload = new UpdateSupplySourceRequest(); // UpdateSupplySourceRequest |  (optional) 

            try
            {
                ErrorList result = apiInstance.UpdateSupplySource(supplySourceId, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplySourcesApi.UpdateSupplySource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplySourceId** | **string**| The unique identitier of a supply source. | 
 **payload** | [**UpdateSupplySourceRequest**](UpdateSupplySourceRequest.md)|  | [optional] 

### Return type

[**ErrorList**](ErrorList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesupplysourcestatus"></a>
# **UpdateSupplySourceStatus**
> ErrorList UpdateSupplySourceStatus (string supplySourceId, UpdateSupplySourceStatusRequest payload = null)



Update the status of a supply source.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources;

namespace Example
{
    public class UpdateSupplySourceStatusExample
    {
        public void main()
        {
            var apiInstance = new SupplySourcesApi();
            var supplySourceId = supplySourceId_example;  // string | The unique identifier of a supply source.
            var payload = new UpdateSupplySourceStatusRequest(); // UpdateSupplySourceStatusRequest |  (optional) 

            try
            {
                ErrorList result = apiInstance.UpdateSupplySourceStatus(supplySourceId, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplySourcesApi.UpdateSupplySourceStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplySourceId** | **string**| The unique identifier of a supply source. | 
 **payload** | [**UpdateSupplySourceStatusRequest**](UpdateSupplySourceStatusRequest.md)|  | [optional] 

### Return type

[**ErrorList**](ErrorList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

