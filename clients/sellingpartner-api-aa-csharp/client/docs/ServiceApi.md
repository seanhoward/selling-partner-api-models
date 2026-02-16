# Amazon.SellingPartnerAPIAA.Clients.API.ServiceApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAppointmentForServiceJobByServiceJobId**](ServiceApi.md#addappointmentforservicejobbyservicejobid) | **POST** /service/v1/serviceJobs/{serviceJobId}/appointments | 
[**AssignAppointmentResources**](ServiceApi.md#assignappointmentresources) | **PUT** /service/v1/serviceJobs/{serviceJobId}/appointments/{appointmentId}/resources | 
[**CancelReservation**](ServiceApi.md#cancelreservation) | **DELETE** /service/v1/reservation/{reservationId} | 
[**CancelServiceJobByServiceJobId**](ServiceApi.md#cancelservicejobbyservicejobid) | **PUT** /service/v1/serviceJobs/{serviceJobId}/cancellations | 
[**CompleteServiceJobByServiceJobId**](ServiceApi.md#completeservicejobbyservicejobid) | **PUT** /service/v1/serviceJobs/{serviceJobId}/completions | 
[**CreateReservation**](ServiceApi.md#createreservation) | **POST** /service/v1/reservation | 
[**CreateServiceDocumentUploadDestination**](ServiceApi.md#createservicedocumentuploaddestination) | **POST** /service/v1/documents | 
[**GetAppointmentSlots**](ServiceApi.md#getappointmentslots) | **GET** /service/v1/appointmentSlots | 
[**GetAppointmmentSlotsByJobId**](ServiceApi.md#getappointmmentslotsbyjobid) | **GET** /service/v1/serviceJobs/{serviceJobId}/appointmentSlots | 
[**GetFixedSlotCapacity**](ServiceApi.md#getfixedslotcapacity) | **POST** /service/v1/serviceResources/{resourceId}/capacity/fixed | 
[**GetRangeSlotCapacity**](ServiceApi.md#getrangeslotcapacity) | **POST** /service/v1/serviceResources/{resourceId}/capacity/range | 
[**GetServiceJobByServiceJobId**](ServiceApi.md#getservicejobbyservicejobid) | **GET** /service/v1/serviceJobs/{serviceJobId} | 
[**GetServiceJobs**](ServiceApi.md#getservicejobs) | **GET** /service/v1/serviceJobs | 
[**RescheduleAppointmentForServiceJobByServiceJobId**](ServiceApi.md#rescheduleappointmentforservicejobbyservicejobid) | **POST** /service/v1/serviceJobs/{serviceJobId}/appointments/{appointmentId} | 
[**SetAppointmentFulfillmentData**](ServiceApi.md#setappointmentfulfillmentdata) | **PUT** /service/v1/serviceJobs/{serviceJobId}/appointments/{appointmentId}/fulfillment | 
[**UpdateReservation**](ServiceApi.md#updatereservation) | **PUT** /service/v1/reservation/{reservationId} | 
[**UpdateSchedule**](ServiceApi.md#updateschedule) | **PUT** /service/v1/serviceResources/{resourceId}/schedules | 


<a name="addappointmentforservicejobbyservicejobid"></a>
# **AddAppointmentForServiceJobByServiceJobId**
> SetAppointmentResponse AddAppointmentForServiceJobByServiceJobId (string serviceJobId, AddAppointmentRequest body)



Adds an appointment to the service job indicated by the service job identifier specified.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class AddAppointmentForServiceJobByServiceJobIdExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var serviceJobId = serviceJobId_example;  // string | An Amazon defined service job identifier.
            var body = new AddAppointmentRequest(); // AddAppointmentRequest | Add appointment operation input details.

            try
            {
                SetAppointmentResponse result = apiInstance.AddAppointmentForServiceJobByServiceJobId(serviceJobId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.AddAppointmentForServiceJobByServiceJobId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceJobId** | **string**| An Amazon defined service job identifier. | 
 **body** | [**AddAppointmentRequest**](AddAppointmentRequest.md)| Add appointment operation input details. | 

### Return type

[**SetAppointmentResponse**](SetAppointmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignappointmentresources"></a>
# **AssignAppointmentResources**
> AssignAppointmentResourcesResponse AssignAppointmentResources (string serviceJobId, string appointmentId, AssignAppointmentResourcesRequest body)



Assigns new resource(s) or overwrite/update the existing one(s) to a service job appointment.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class AssignAppointmentResourcesExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var serviceJobId = serviceJobId_example;  // string | An Amazon-defined service job identifier. Get this value by calling the `getServiceJobs` operation of the Services API.
            var appointmentId = appointmentId_example;  // string | An Amazon-defined identifier of active service job appointment.
            var body = new AssignAppointmentResourcesRequest(); // AssignAppointmentResourcesRequest | 

            try
            {
                AssignAppointmentResourcesResponse result = apiInstance.AssignAppointmentResources(serviceJobId, appointmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.AssignAppointmentResources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceJobId** | **string**| An Amazon-defined service job identifier. Get this value by calling the &#x60;getServiceJobs&#x60; operation of the Services API. | 
 **appointmentId** | **string**| An Amazon-defined identifier of active service job appointment. | 
 **body** | [**AssignAppointmentResourcesRequest**](AssignAppointmentResourcesRequest.md)|  | 

### Return type

[**AssignAppointmentResourcesResponse**](AssignAppointmentResourcesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelreservation"></a>
# **CancelReservation**
> CancelReservationResponse CancelReservation (string reservationId, List<string> marketplaceIds)



Cancel a reservation.   **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class CancelReservationExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var reservationId = reservationId_example;  // string | Reservation Identifier
            var marketplaceIds = new List<string>(); // List<string> | An identifier for the marketplace in which the resource operates.

            try
            {
                CancelReservationResponse result = apiInstance.CancelReservation(reservationId, marketplaceIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.CancelReservation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reservationId** | **string**| Reservation Identifier | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| An identifier for the marketplace in which the resource operates. | 

### Return type

[**CancelReservationResponse**](CancelReservationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelservicejobbyservicejobid"></a>
# **CancelServiceJobByServiceJobId**
> CancelServiceJobByServiceJobIdResponse CancelServiceJobByServiceJobId (string serviceJobId, string cancellationReasonCode)



Cancels the service job indicated by the service job identifier specified.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class CancelServiceJobByServiceJobIdExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var serviceJobId = serviceJobId_example;  // string | An Amazon defined service job identifier.
            var cancellationReasonCode = cancellationReasonCode_example;  // string | A cancel reason code that specifies the reason for cancelling a service job.

            try
            {
                CancelServiceJobByServiceJobIdResponse result = apiInstance.CancelServiceJobByServiceJobId(serviceJobId, cancellationReasonCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.CancelServiceJobByServiceJobId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceJobId** | **string**| An Amazon defined service job identifier. | 
 **cancellationReasonCode** | **string**| A cancel reason code that specifies the reason for cancelling a service job. | 

### Return type

[**CancelServiceJobByServiceJobIdResponse**](CancelServiceJobByServiceJobIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="completeservicejobbyservicejobid"></a>
# **CompleteServiceJobByServiceJobId**
> CompleteServiceJobByServiceJobIdResponse CompleteServiceJobByServiceJobId (string serviceJobId)



Completes the service job indicated by the service job identifier specified.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class CompleteServiceJobByServiceJobIdExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var serviceJobId = serviceJobId_example;  // string | An Amazon defined service job identifier.

            try
            {
                CompleteServiceJobByServiceJobIdResponse result = apiInstance.CompleteServiceJobByServiceJobId(serviceJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.CompleteServiceJobByServiceJobId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceJobId** | **string**| An Amazon defined service job identifier. | 

### Return type

[**CompleteServiceJobByServiceJobIdResponse**](CompleteServiceJobByServiceJobIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createreservation"></a>
# **CreateReservation**
> CreateReservationResponse CreateReservation (CreateReservationRequest body, List<string> marketplaceIds)



Create a reservation.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class CreateReservationExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var body = new CreateReservationRequest(); // CreateReservationRequest | Reservation details
            var marketplaceIds = new List<string>(); // List<string> | An identifier for the marketplace in which the resource operates.

            try
            {
                CreateReservationResponse result = apiInstance.CreateReservation(body, marketplaceIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.CreateReservation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateReservationRequest**](CreateReservationRequest.md)| Reservation details | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| An identifier for the marketplace in which the resource operates. | 

### Return type

[**CreateReservationResponse**](CreateReservationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createservicedocumentuploaddestination"></a>
# **CreateServiceDocumentUploadDestination**
> CreateServiceDocumentUploadDestination CreateServiceDocumentUploadDestination (ServiceUploadDocument body)



Creates an upload destination.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class CreateServiceDocumentUploadDestinationExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var body = new ServiceUploadDocument(); // ServiceUploadDocument | Upload document operation input details.

            try
            {
                CreateServiceDocumentUploadDestination result = apiInstance.CreateServiceDocumentUploadDestination(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.CreateServiceDocumentUploadDestination: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ServiceUploadDocument**](ServiceUploadDocument.md)| Upload document operation input details. | 

### Return type

[**CreateServiceDocumentUploadDestination**](CreateServiceDocumentUploadDestination.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappointmentslots"></a>
# **GetAppointmentSlots**
> GetAppointmentSlotsResponse GetAppointmentSlots (string asin, string storeId, List<string> marketplaceIds, string startTime = null, string endTime = null)



Gets appointment slots as per the service context specified.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 20 | 40 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class GetAppointmentSlotsExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var asin = asin_example;  // string | ASIN associated with the service.
            var storeId = storeId_example;  // string | Store identifier defining the region scope to retrive appointment slots.
            var marketplaceIds = new List<string>(); // List<string> | An identifier for the marketplace for which appointment slots are queried
            var startTime = startTime_example;  // string | A time from which the appointment slots will be retrieved. The specified time must be in ISO 8601 format. If `startTime` is provided, `endTime` should also be provided. Default value is as per business configuration. (optional) 
            var endTime = endTime_example;  // string | A time up to which the appointment slots will be retrieved. The specified time must be in ISO 8601 format. If `endTime` is provided, `startTime` should also be provided. Default value is as per business configuration. Maximum range of appointment slots can be 90 days. (optional) 

            try
            {
                GetAppointmentSlotsResponse result = apiInstance.GetAppointmentSlots(asin, storeId, marketplaceIds, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.GetAppointmentSlots: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asin** | **string**| ASIN associated with the service. | 
 **storeId** | **string**| Store identifier defining the region scope to retrive appointment slots. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| An identifier for the marketplace for which appointment slots are queried | 
 **startTime** | **string**| A time from which the appointment slots will be retrieved. The specified time must be in ISO 8601 format. If &#x60;startTime&#x60; is provided, &#x60;endTime&#x60; should also be provided. Default value is as per business configuration. | [optional] 
 **endTime** | **string**| A time up to which the appointment slots will be retrieved. The specified time must be in ISO 8601 format. If &#x60;endTime&#x60; is provided, &#x60;startTime&#x60; should also be provided. Default value is as per business configuration. Maximum range of appointment slots can be 90 days. | [optional] 

### Return type

[**GetAppointmentSlotsResponse**](GetAppointmentSlotsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappointmmentslotsbyjobid"></a>
# **GetAppointmmentSlotsByJobId**
> GetAppointmentSlotsResponse GetAppointmmentSlotsByJobId (string serviceJobId, List<string> marketplaceIds, string startTime = null, string endTime = null)



Gets appointment slots for the service associated with the service job id specified.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class GetAppointmmentSlotsByJobIdExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var serviceJobId = serviceJobId_example;  // string | A service job identifier to retrive appointment slots for associated service.
            var marketplaceIds = new List<string>(); // List<string> | An identifier for the marketplace in which the resource operates.
            var startTime = startTime_example;  // string | A time from which the appointment slots will be retrieved. The specified time must be in ISO 8601 format. If `startTime` is provided, `endTime` should also be provided. Default value is as per business configuration. (optional) 
            var endTime = endTime_example;  // string | A time up to which the appointment slots will be retrieved. The specified time must be in ISO 8601 format. If `endTime` is provided, `startTime` should also be provided. Default value is as per business configuration. Maximum range of appointment slots can be 90 days. (optional) 

            try
            {
                GetAppointmentSlotsResponse result = apiInstance.GetAppointmmentSlotsByJobId(serviceJobId, marketplaceIds, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.GetAppointmmentSlotsByJobId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceJobId** | **string**| A service job identifier to retrive appointment slots for associated service. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| An identifier for the marketplace in which the resource operates. | 
 **startTime** | **string**| A time from which the appointment slots will be retrieved. The specified time must be in ISO 8601 format. If &#x60;startTime&#x60; is provided, &#x60;endTime&#x60; should also be provided. Default value is as per business configuration. | [optional] 
 **endTime** | **string**| A time up to which the appointment slots will be retrieved. The specified time must be in ISO 8601 format. If &#x60;endTime&#x60; is provided, &#x60;startTime&#x60; should also be provided. Default value is as per business configuration. Maximum range of appointment slots can be 90 days. | [optional] 

### Return type

[**GetAppointmentSlotsResponse**](GetAppointmentSlotsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfixedslotcapacity"></a>
# **GetFixedSlotCapacity**
> FixedSlotCapacity GetFixedSlotCapacity (string resourceId, FixedSlotCapacityQuery body, List<string> marketplaceIds, string nextPageToken = null)



Provides capacity in fixed-size slots.   **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class GetFixedSlotCapacityExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var resourceId = resourceId_example;  // string | Resource Identifier.
            var body = new FixedSlotCapacityQuery(); // FixedSlotCapacityQuery | Request body.
            var marketplaceIds = new List<string>(); // List<string> | An identifier for the marketplace in which the resource operates.
            var nextPageToken = nextPageToken_example;  // string | Next page token returned in the response of your previous request. (optional) 

            try
            {
                FixedSlotCapacity result = apiInstance.GetFixedSlotCapacity(resourceId, body, marketplaceIds, nextPageToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.GetFixedSlotCapacity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resourceId** | **string**| Resource Identifier. | 
 **body** | [**FixedSlotCapacityQuery**](FixedSlotCapacityQuery.md)| Request body. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| An identifier for the marketplace in which the resource operates. | 
 **nextPageToken** | **string**| Next page token returned in the response of your previous request. | [optional] 

### Return type

[**FixedSlotCapacity**](FixedSlotCapacity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrangeslotcapacity"></a>
# **GetRangeSlotCapacity**
> RangeSlotCapacity GetRangeSlotCapacity (string resourceId, RangeSlotCapacityQuery body, List<string> marketplaceIds, string nextPageToken = null)



Provides capacity slots in a format similar to availability records.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class GetRangeSlotCapacityExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var resourceId = resourceId_example;  // string | Resource Identifier.
            var body = new RangeSlotCapacityQuery(); // RangeSlotCapacityQuery | Request body.
            var marketplaceIds = new List<string>(); // List<string> | An identifier for the marketplace in which the resource operates.
            var nextPageToken = nextPageToken_example;  // string | Next page token returned in the response of your previous request. (optional) 

            try
            {
                RangeSlotCapacity result = apiInstance.GetRangeSlotCapacity(resourceId, body, marketplaceIds, nextPageToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.GetRangeSlotCapacity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resourceId** | **string**| Resource Identifier. | 
 **body** | [**RangeSlotCapacityQuery**](RangeSlotCapacityQuery.md)| Request body. | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| An identifier for the marketplace in which the resource operates. | 
 **nextPageToken** | **string**| Next page token returned in the response of your previous request. | [optional] 

### Return type

[**RangeSlotCapacity**](RangeSlotCapacity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getservicejobbyservicejobid"></a>
# **GetServiceJobByServiceJobId**
> GetServiceJobByServiceJobIdResponse GetServiceJobByServiceJobId (string serviceJobId)



Gets details of service job indicated by the provided `serviceJobID`.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 20 | 40 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class GetServiceJobByServiceJobIdExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var serviceJobId = serviceJobId_example;  // string | A service job identifier.

            try
            {
                GetServiceJobByServiceJobIdResponse result = apiInstance.GetServiceJobByServiceJobId(serviceJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.GetServiceJobByServiceJobId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceJobId** | **string**| A service job identifier. | 

### Return type

[**GetServiceJobByServiceJobIdResponse**](GetServiceJobByServiceJobIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getservicejobs"></a>
# **GetServiceJobs**
> GetServiceJobsResponse GetServiceJobs (List<string> marketplaceIds, List<string> serviceOrderIds = null, List<string> serviceJobStatus = null, string pageToken = null, int? pageSize = null, string sortField = null, string sortOrder = null, string createdAfter = null, string createdBefore = null, string lastUpdatedAfter = null, string lastUpdatedBefore = null, string scheduleStartDate = null, string scheduleEndDate = null, List<string> asins = null, List<string> requiredSkills = null, List<string> storeIds = null)



Gets service job details for the specified filter query.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 40 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class GetServiceJobsExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var marketplaceIds = new List<string>(); // List<string> | Used to select jobs that were placed in the specified marketplaces.
            var serviceOrderIds = new List<string>(); // List<string> | List of service order ids for the query you want to perform.Max values supported 20. (optional) 
            var serviceJobStatus = serviceJobStatus_example;  // List<string> | A list of one or more job status by which to filter the list of jobs. (optional) 
            var pageToken = pageToken_example;  // string | String returned in the response of your previous request. (optional) 
            var pageSize = 56;  // int? | A non-negative integer that indicates the maximum number of jobs to return in the list, Value must be 1 - 20. Default 20. (optional)  (default to 20)
            var sortField = sortField_example;  // string | Sort fields on which you want to sort the output. (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order for the query you want to perform. (optional) 
            var createdAfter = createdAfter_example;  // string | A date used for selecting jobs created at or after a specified time. Must be in ISO 8601 format. Required if `LastUpdatedAfter` is not specified. Specifying both `CreatedAfter` and `LastUpdatedAfter` returns an error. (optional) 
            var createdBefore = createdBefore_example;  // string | A date used for selecting jobs created at or before a specified time. Must be in ISO 8601 format. (optional) 
            var lastUpdatedAfter = lastUpdatedAfter_example;  // string | A date used for selecting jobs updated at or after a specified time. Must be in ISO 8601 format. Required if `createdAfter` is not specified. Specifying both `CreatedAfter` and `LastUpdatedAfter` returns an error. (optional) 
            var lastUpdatedBefore = lastUpdatedBefore_example;  // string | A date used for selecting jobs updated at or before a specified time. Must be in ISO 8601 format. (optional) 
            var scheduleStartDate = scheduleStartDate_example;  // string | A date used for filtering jobs schedules at or after a specified time. Must be in ISO 8601 format. Schedule end date should not be earlier than schedule start date. (optional) 
            var scheduleEndDate = scheduleEndDate_example;  // string | A date used for filtering jobs schedules at or before a specified time. Must be in ISO 8601 format. Schedule end date should not be earlier than schedule start date. (optional) 
            var asins = new List<string>(); // List<string> | List of Amazon Standard Identification Numbers (ASIN) of the items. Max values supported is 20. (optional) 
            var requiredSkills = new List<string>(); // List<string> | A defined set of related knowledge, skills, experience, tools, materials, and work processes common to service delivery for a set of products and/or service scenarios. Max values supported is 20. (optional) 
            var storeIds = new List<string>(); // List<string> | List of Amazon-defined identifiers for the region scope. Max values supported is 50. (optional) 

            try
            {
                GetServiceJobsResponse result = apiInstance.GetServiceJobs(marketplaceIds, serviceOrderIds, serviceJobStatus, pageToken, pageSize, sortField, sortOrder, createdAfter, createdBefore, lastUpdatedAfter, lastUpdatedBefore, scheduleStartDate, scheduleEndDate, asins, requiredSkills, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.GetServiceJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| Used to select jobs that were placed in the specified marketplaces. | 
 **serviceOrderIds** | [**List&lt;string&gt;**](string.md)| List of service order ids for the query you want to perform.Max values supported 20. | [optional] 
 **serviceJobStatus** | **List&lt;string&gt;**| A list of one or more job status by which to filter the list of jobs. | [optional] 
 **pageToken** | **string**| String returned in the response of your previous request. | [optional] 
 **pageSize** | **int?**| A non-negative integer that indicates the maximum number of jobs to return in the list, Value must be 1 - 20. Default 20. | [optional] [default to 20]
 **sortField** | **string**| Sort fields on which you want to sort the output. | [optional] 
 **sortOrder** | **string**| Sort order for the query you want to perform. | [optional] 
 **createdAfter** | **string**| A date used for selecting jobs created at or after a specified time. Must be in ISO 8601 format. Required if &#x60;LastUpdatedAfter&#x60; is not specified. Specifying both &#x60;CreatedAfter&#x60; and &#x60;LastUpdatedAfter&#x60; returns an error. | [optional] 
 **createdBefore** | **string**| A date used for selecting jobs created at or before a specified time. Must be in ISO 8601 format. | [optional] 
 **lastUpdatedAfter** | **string**| A date used for selecting jobs updated at or after a specified time. Must be in ISO 8601 format. Required if &#x60;createdAfter&#x60; is not specified. Specifying both &#x60;CreatedAfter&#x60; and &#x60;LastUpdatedAfter&#x60; returns an error. | [optional] 
 **lastUpdatedBefore** | **string**| A date used for selecting jobs updated at or before a specified time. Must be in ISO 8601 format. | [optional] 
 **scheduleStartDate** | **string**| A date used for filtering jobs schedules at or after a specified time. Must be in ISO 8601 format. Schedule end date should not be earlier than schedule start date. | [optional] 
 **scheduleEndDate** | **string**| A date used for filtering jobs schedules at or before a specified time. Must be in ISO 8601 format. Schedule end date should not be earlier than schedule start date. | [optional] 
 **asins** | [**List&lt;string&gt;**](string.md)| List of Amazon Standard Identification Numbers (ASIN) of the items. Max values supported is 20. | [optional] 
 **requiredSkills** | [**List&lt;string&gt;**](string.md)| A defined set of related knowledge, skills, experience, tools, materials, and work processes common to service delivery for a set of products and/or service scenarios. Max values supported is 20. | [optional] 
 **storeIds** | [**List&lt;string&gt;**](string.md)| List of Amazon-defined identifiers for the region scope. Max values supported is 50. | [optional] 

### Return type

[**GetServiceJobsResponse**](GetServiceJobsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rescheduleappointmentforservicejobbyservicejobid"></a>
# **RescheduleAppointmentForServiceJobByServiceJobId**
> SetAppointmentResponse RescheduleAppointmentForServiceJobByServiceJobId (string serviceJobId, string appointmentId, RescheduleAppointmentRequest body)



Reschedules an appointment for the service job indicated by the service job identifier specified.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class RescheduleAppointmentForServiceJobByServiceJobIdExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var serviceJobId = serviceJobId_example;  // string | An Amazon defined service job identifier.
            var appointmentId = appointmentId_example;  // string | An existing appointment identifier for the Service Job.
            var body = new RescheduleAppointmentRequest(); // RescheduleAppointmentRequest | Reschedule appointment operation input details.

            try
            {
                SetAppointmentResponse result = apiInstance.RescheduleAppointmentForServiceJobByServiceJobId(serviceJobId, appointmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.RescheduleAppointmentForServiceJobByServiceJobId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceJobId** | **string**| An Amazon defined service job identifier. | 
 **appointmentId** | **string**| An existing appointment identifier for the Service Job. | 
 **body** | [**RescheduleAppointmentRequest**](RescheduleAppointmentRequest.md)| Reschedule appointment operation input details. | 

### Return type

[**SetAppointmentResponse**](SetAppointmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setappointmentfulfillmentdata"></a>
# **SetAppointmentFulfillmentData**
> string SetAppointmentFulfillmentData (string serviceJobId, string appointmentId, SetAppointmentFulfillmentDataRequest body)



Updates the appointment fulfillment data related to a given `jobID` and `appointmentID`.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class SetAppointmentFulfillmentDataExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var serviceJobId = serviceJobId_example;  // string | An Amazon-defined service job identifier. Get this value by calling the `getServiceJobs` operation of the Services API.
            var appointmentId = appointmentId_example;  // string | An Amazon-defined identifier of active service job appointment.
            var body = new SetAppointmentFulfillmentDataRequest(); // SetAppointmentFulfillmentDataRequest | Appointment fulfillment data collection details.

            try
            {
                string result = apiInstance.SetAppointmentFulfillmentData(serviceJobId, appointmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.SetAppointmentFulfillmentData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceJobId** | **string**| An Amazon-defined service job identifier. Get this value by calling the &#x60;getServiceJobs&#x60; operation of the Services API. | 
 **appointmentId** | **string**| An Amazon-defined identifier of active service job appointment. | 
 **body** | [**SetAppointmentFulfillmentDataRequest**](SetAppointmentFulfillmentDataRequest.md)| Appointment fulfillment data collection details. | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereservation"></a>
# **UpdateReservation**
> UpdateReservationResponse UpdateReservation (string reservationId, UpdateReservationRequest body, List<string> marketplaceIds)



Update a reservation.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class UpdateReservationExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var reservationId = reservationId_example;  // string | Reservation Identifier
            var body = new UpdateReservationRequest(); // UpdateReservationRequest | Reservation details
            var marketplaceIds = new List<string>(); // List<string> | An identifier for the marketplace in which the resource operates.

            try
            {
                UpdateReservationResponse result = apiInstance.UpdateReservation(reservationId, body, marketplaceIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.UpdateReservation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reservationId** | **string**| Reservation Identifier | 
 **body** | [**UpdateReservationRequest**](UpdateReservationRequest.md)| Reservation details | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| An identifier for the marketplace in which the resource operates. | 

### Return type

[**UpdateReservationResponse**](UpdateReservationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateschedule"></a>
# **UpdateSchedule**
> UpdateScheduleResponse UpdateSchedule (string resourceId, UpdateScheduleRequest body, List<string> marketplaceIds)



Update the schedule of the given resource.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.Services;

namespace Example
{
    public class UpdateScheduleExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var resourceId = resourceId_example;  // string | Resource (store) Identifier
            var body = new UpdateScheduleRequest(); // UpdateScheduleRequest | Schedule details
            var marketplaceIds = new List<string>(); // List<string> | An identifier for the marketplace in which the resource operates.

            try
            {
                UpdateScheduleResponse result = apiInstance.UpdateSchedule(resourceId, body, marketplaceIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.UpdateSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resourceId** | **string**| Resource (store) Identifier | 
 **body** | [**UpdateScheduleRequest**](UpdateScheduleRequest.md)| Schedule details | 
 **marketplaceIds** | [**List&lt;string&gt;**](string.md)| An identifier for the marketplace in which the resource operates. | 

### Return type

[**UpdateScheduleResponse**](UpdateScheduleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

