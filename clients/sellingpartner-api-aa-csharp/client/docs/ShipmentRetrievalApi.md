# Amazon.SellingPartnerAPIAA.Clients.API.ShipmentRetrievalApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetShipment**](ShipmentRetrievalApi.md#getshipment) | **GET** /externalFulfillment/2024-09-11/shipments/{shipmentId} | 
[**GetShipments**](ShipmentRetrievalApi.md#getshipments) | **GET** /externalFulfillment/2024-09-11/shipments | 


<a name="getshipment"></a>
# **GetShipment**
> Shipment GetShipment (string shipmentId)



Get a single shipment with the ID you specify.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments;

namespace Example
{
    public class GetShipmentExample
    {
        public void main()
        {
            var apiInstance = new ShipmentRetrievalApi();
            var shipmentId = D1px1063T;  // string | The ID of the shipment you want to retrieve.

            try
            {
                Shipment result = apiInstance.GetShipment(shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentRetrievalApi.GetShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**| The ID of the shipment you want to retrieve. | 

### Return type

[**Shipment**](Shipment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipments"></a>
# **GetShipments**
> ShipmentsResponse GetShipments (string status, string locationId = null, string marketplaceId = null, string channelName = null, DateTime? lastUpdatedAfter = null, DateTime? lastUpdatedBefore = null, int? maxResults = null, string paginationToken = null)



Get a list of shipments created for the seller in the status you specify. Shipments can be further filtered based on the fulfillment node or the time of the shipments' last update.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.ExternalFulfillmentShipments;

namespace Example
{
    public class GetShipmentsExample
    {
        public void main()
        {
            var apiInstance = new ShipmentRetrievalApi();
            var status = CONFIRMED;  // string | The status of shipment you want to include in the response. To retrieve all new shipments, set this value to `ACCEPTED`.
            var locationId = ABCD;  // string | The Amazon channel location identifier for the shipments you want to retrieve. (optional) 
            var marketplaceId = A21TJRUUN4KGV;  // string | The marketplace ID associated with the location. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). (optional) 
            var channelName = FBA;  // string | The channel name associated with the location. (optional) 
            var lastUpdatedAfter = 2020-06-08T17:23:58Z;  // DateTime? | The response includes shipments whose latest update is after the specified time. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. (optional) 
            var lastUpdatedBefore = 2020-06-08T17:23:58Z;  // DateTime? | The response includes shipments whose latest update is before the specified time. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. (optional) 
            var maxResults = 10;  // int? | The maximum number of shipments to include in the response. (optional) 
            var paginationToken = eyJsYXN0VXBkYXRlZFRpbWVzdGFtcCI6eyJzIjpLL;  // string | A token that you use to retrieve the next page of results. The response includes `nextToken` when there are multiple pages of results. To get the next page of results, call the operation with this token and include the same arguments as the call that produced the token. To get a complete list, call this operation until `nextToken` is null. Note that this operation can return empty pages. (optional) 

            try
            {
                ShipmentsResponse result = apiInstance.GetShipments(status, locationId, marketplaceId, channelName, lastUpdatedAfter, lastUpdatedBefore, maxResults, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentRetrievalApi.GetShipments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**| The status of shipment you want to include in the response. To retrieve all new shipments, set this value to &#x60;ACCEPTED&#x60;. | 
 **locationId** | **string**| The Amazon channel location identifier for the shipments you want to retrieve. | [optional] 
 **marketplaceId** | **string**| The marketplace ID associated with the location. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | [optional] 
 **channelName** | **string**| The channel name associated with the location. | [optional] 
 **lastUpdatedAfter** | **DateTime?**| The response includes shipments whose latest update is after the specified time. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. | [optional] 
 **lastUpdatedBefore** | **DateTime?**| The response includes shipments whose latest update is before the specified time. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. | [optional] 
 **maxResults** | **int?**| The maximum number of shipments to include in the response. | [optional] 
 **paginationToken** | **string**| A token that you use to retrieve the next page of results. The response includes &#x60;nextToken&#x60; when there are multiple pages of results. To get the next page of results, call the operation with this token and include the same arguments as the call that produced the token. To get a complete list, call this operation until &#x60;nextToken&#x60; is null. Note that this operation can return empty pages. | [optional] 

### Return type

[**ShipmentsResponse**](ShipmentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

