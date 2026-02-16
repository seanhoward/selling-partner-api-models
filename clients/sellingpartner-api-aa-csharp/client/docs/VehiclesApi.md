# Amazon.SellingPartnerAPIAA.Clients.API.VehiclesApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetVehicles**](VehiclesApi.md#getvehicles) | **GET** /catalog/2024-11-01/automotive/vehicles | 


<a name="getvehicles"></a>
# **GetVehicles**
> VehiclesResponse GetVehicles (string marketplaceId, string vehicleType, string pageToken = null, string updatedAfter = null)



Get the latest collection of vehicles

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Vehicles;

namespace Example
{
    public class GetVehiclesExample
    {
        public void main()
        {
            var apiInstance = new VehiclesApi();
            var marketplaceId = A1PA6795UKMFR9;  // string | An identifier for the marketplace in which the resource operates.
            var vehicleType = CAR;  // string | An identifier for vehicle type.
            var pageToken = sdlkj234lkj234lksjdflkjwdflkjsfdlkj234234234234;  // string | A token to fetch a certain page when there are multiple pages worth of results. (optional) 
            var updatedAfter = 2024-01-05T18:00:03+00:00;  // string | Date in ISO 8601 format, if provided only vehicles which are modified/added to Amazon's catalog after this date will be returned. (optional) 

            try
            {
                VehiclesResponse result = apiInstance.GetVehicles(marketplaceId, vehicleType, pageToken, updatedAfter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VehiclesApi.GetVehicles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| An identifier for the marketplace in which the resource operates. | 
 **vehicleType** | **string**| An identifier for vehicle type. | 
 **pageToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. | [optional] 
 **updatedAfter** | **string**| Date in ISO 8601 format, if provided only vehicles which are modified/added to Amazon&#39;s catalog after this date will be returned. | [optional] 

### Return type

[**VehiclesResponse**](VehiclesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

