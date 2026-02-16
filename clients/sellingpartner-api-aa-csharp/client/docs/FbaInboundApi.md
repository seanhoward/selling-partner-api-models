# Amazon.SellingPartnerAPIAA.Clients.API.FbaInboundApi

All URIs are relative to *https://sellingpartnerapi-na.amazon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelInboundPlan**](FbaInboundApi.md#cancelinboundplan) | **PUT** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/cancellation | 
[**CancelSelfShipAppointment**](FbaInboundApi.md#cancelselfshipappointment) | **PUT** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/selfShipAppointmentCancellation | 
[**ConfirmDeliveryWindowOptions**](FbaInboundApi.md#confirmdeliverywindowoptions) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/deliveryWindowOptions/{deliveryWindowOptionId}/confirmation | 
[**ConfirmPackingOption**](FbaInboundApi.md#confirmpackingoption) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/packingOptions/{packingOptionId}/confirmation | 
[**ConfirmPlacementOption**](FbaInboundApi.md#confirmplacementoption) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/placementOptions/{placementOptionId}/confirmation | 
[**ConfirmShipmentContentUpdatePreview**](FbaInboundApi.md#confirmshipmentcontentupdatepreview) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/contentUpdatePreviews/{contentUpdatePreviewId}/confirmation | 
[**ConfirmTransportationOptions**](FbaInboundApi.md#confirmtransportationoptions) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/transportationOptions/confirmation | 
[**CreateInboundPlan**](FbaInboundApi.md#createinboundplan) | **POST** /inbound/fba/2024-03-20/inboundPlans | 
[**CreateMarketplaceItemLabels**](FbaInboundApi.md#createmarketplaceitemlabels) | **POST** /inbound/fba/2024-03-20/items/labels | 
[**GenerateDeliveryWindowOptions**](FbaInboundApi.md#generatedeliverywindowoptions) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/deliveryWindowOptions | 
[**GeneratePackingOptions**](FbaInboundApi.md#generatepackingoptions) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/packingOptions | 
[**GeneratePlacementOptions**](FbaInboundApi.md#generateplacementoptions) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/placementOptions | 
[**GenerateSelfShipAppointmentSlots**](FbaInboundApi.md#generateselfshipappointmentslots) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/selfShipAppointmentSlots | 
[**GenerateShipmentContentUpdatePreviews**](FbaInboundApi.md#generateshipmentcontentupdatepreviews) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/contentUpdatePreviews | 
[**GenerateTransportationOptions**](FbaInboundApi.md#generatetransportationoptions) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/transportationOptions | 
[**GetDeliveryChallanDocument**](FbaInboundApi.md#getdeliverychallandocument) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/deliveryChallanDocument | 
[**GetInboundOperationStatus**](FbaInboundApi.md#getinboundoperationstatus) | **GET** /inbound/fba/2024-03-20/operations/{operationId} | 
[**GetInboundPlan**](FbaInboundApi.md#getinboundplan) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId} | 
[**GetSelfShipAppointmentSlots**](FbaInboundApi.md#getselfshipappointmentslots) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/selfShipAppointmentSlots | 
[**GetShipment**](FbaInboundApi.md#getshipment) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId} | 
[**GetShipmentContentUpdatePreview**](FbaInboundApi.md#getshipmentcontentupdatepreview) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/contentUpdatePreviews/{contentUpdatePreviewId} | 
[**ListDeliveryWindowOptions**](FbaInboundApi.md#listdeliverywindowoptions) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/deliveryWindowOptions | 
[**ListInboundPlanBoxes**](FbaInboundApi.md#listinboundplanboxes) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/boxes | 
[**ListInboundPlanItems**](FbaInboundApi.md#listinboundplanitems) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/items | 
[**ListInboundPlanPallets**](FbaInboundApi.md#listinboundplanpallets) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/pallets | 
[**ListInboundPlans**](FbaInboundApi.md#listinboundplans) | **GET** /inbound/fba/2024-03-20/inboundPlans | 
[**ListItemComplianceDetails**](FbaInboundApi.md#listitemcompliancedetails) | **GET** /inbound/fba/2024-03-20/items/compliance | 
[**ListPackingGroupBoxes**](FbaInboundApi.md#listpackinggroupboxes) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/packingGroups/{packingGroupId}/boxes | 
[**ListPackingGroupItems**](FbaInboundApi.md#listpackinggroupitems) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/packingGroups/{packingGroupId}/items | 
[**ListPackingOptions**](FbaInboundApi.md#listpackingoptions) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/packingOptions | 
[**ListPlacementOptions**](FbaInboundApi.md#listplacementoptions) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/placementOptions | 
[**ListPrepDetails**](FbaInboundApi.md#listprepdetails) | **GET** /inbound/fba/2024-03-20/items/prepDetails | 
[**ListShipmentBoxes**](FbaInboundApi.md#listshipmentboxes) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/boxes | 
[**ListShipmentContentUpdatePreviews**](FbaInboundApi.md#listshipmentcontentupdatepreviews) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/contentUpdatePreviews | 
[**ListShipmentItems**](FbaInboundApi.md#listshipmentitems) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/items | 
[**ListShipmentPallets**](FbaInboundApi.md#listshipmentpallets) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/pallets | 
[**ListTransportationOptions**](FbaInboundApi.md#listtransportationoptions) | **GET** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/transportationOptions | 
[**ScheduleSelfShipAppointment**](FbaInboundApi.md#scheduleselfshipappointment) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/selfShipAppointmentSlots/{slotId}/schedule | 
[**SetPackingInformation**](FbaInboundApi.md#setpackinginformation) | **POST** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/packingInformation | 
[**SetPrepDetails**](FbaInboundApi.md#setprepdetails) | **POST** /inbound/fba/2024-03-20/items/prepDetails | 
[**UpdateInboundPlanName**](FbaInboundApi.md#updateinboundplanname) | **PUT** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/name | 
[**UpdateItemComplianceDetails**](FbaInboundApi.md#updateitemcompliancedetails) | **PUT** /inbound/fba/2024-03-20/items/compliance | 
[**UpdateShipmentName**](FbaInboundApi.md#updateshipmentname) | **PUT** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/name | 
[**UpdateShipmentSourceAddress**](FbaInboundApi.md#updateshipmentsourceaddress) | **PUT** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/sourceAddress | 
[**UpdateShipmentTrackingDetails**](FbaInboundApi.md#updateshipmenttrackingdetails) | **PUT** /inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/trackingDetails | 


<a name="cancelinboundplan"></a>
# **CancelInboundPlan**
> CancelInboundPlanResponse CancelInboundPlan (string inboundPlanId)



Cancels an Inbound Plan. Charges may apply if the cancellation is performed outside of a void window. The window for Amazon Partnered Carriers is 24 hours for Small Parcel Delivery (SPD) and one hour for Less-Than-Truckload (LTL) carrier shipments.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class CancelInboundPlanExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.

            try
            {
                CancelInboundPlanResponse result = apiInstance.CancelInboundPlan(inboundPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.CancelInboundPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 

### Return type

[**CancelInboundPlanResponse**](CancelInboundPlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelselfshipappointment"></a>
# **CancelSelfShipAppointment**
> CancelSelfShipAppointmentResponse CancelSelfShipAppointment (string inboundPlanId, string shipmentId, CancelSelfShipAppointmentRequest body)



Cancels a self-ship appointment slot against a shipment. Only available in the following [marketplaces](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids): MX, BR, EG, SA, AE, IN. 

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class CancelSelfShipAppointmentExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var body = new CancelSelfShipAppointmentRequest(); // CancelSelfShipAppointmentRequest | The body of the request to `cancelSelfShipAppointment`.

            try
            {
                CancelSelfShipAppointmentResponse result = apiInstance.CancelSelfShipAppointment(inboundPlanId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.CancelSelfShipAppointment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **body** | [**CancelSelfShipAppointmentRequest**](CancelSelfShipAppointmentRequest.md)| The body of the request to &#x60;cancelSelfShipAppointment&#x60;. | 

### Return type

[**CancelSelfShipAppointmentResponse**](CancelSelfShipAppointmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmdeliverywindowoptions"></a>
# **ConfirmDeliveryWindowOptions**
> ConfirmDeliveryWindowOptionsResponse ConfirmDeliveryWindowOptions (string inboundPlanId, string shipmentId, string deliveryWindowOptionId)



Confirms the delivery window option for chosen shipment within an inbound plan. A placement option must be confirmed prior to use of this API. Once confirmed, new delivery window options cannot be generated, but the chosen delivery window option can be updated before shipment closure. The window is used to provide the expected time when a shipment will arrive at the warehouse. All transportation options which have the program `CONFIRMED_DELIVERY_WINDOW` require a delivery window to be confirmed prior to transportation option confirmation.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ConfirmDeliveryWindowOptionsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | The shipment to confirm the delivery window option for.
            var deliveryWindowOptionId = deliveryWindowOptionId_example;  // string | The id of the delivery window option to be confirmed.

            try
            {
                ConfirmDeliveryWindowOptionsResponse result = apiInstance.ConfirmDeliveryWindowOptions(inboundPlanId, shipmentId, deliveryWindowOptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ConfirmDeliveryWindowOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| The shipment to confirm the delivery window option for. | 
 **deliveryWindowOptionId** | **string**| The id of the delivery window option to be confirmed. | 

### Return type

[**ConfirmDeliveryWindowOptionsResponse**](ConfirmDeliveryWindowOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmpackingoption"></a>
# **ConfirmPackingOption**
> ConfirmPackingOptionResponse ConfirmPackingOption (string inboundPlanId, string packingOptionId)



Confirms the packing option for an inbound plan.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ConfirmPackingOptionExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var packingOptionId = packingOptionId_example;  // string | Identifier of a packing option.

            try
            {
                ConfirmPackingOptionResponse result = apiInstance.ConfirmPackingOption(inboundPlanId, packingOptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ConfirmPackingOption: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **packingOptionId** | **string**| Identifier of a packing option. | 

### Return type

[**ConfirmPackingOptionResponse**](ConfirmPackingOptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmplacementoption"></a>
# **ConfirmPlacementOption**
> ConfirmPlacementOptionResponse ConfirmPlacementOption (string inboundPlanId, string placementOptionId)



Confirms the placement option for an inbound plan. Once confirmed, it cannot be changed for the Inbound Plan.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ConfirmPlacementOptionExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var placementOptionId = placementOptionId_example;  // string | The identifier of a placement option. A placement option represents the shipment splits and destinations of SKUs.

            try
            {
                ConfirmPlacementOptionResponse result = apiInstance.ConfirmPlacementOption(inboundPlanId, placementOptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ConfirmPlacementOption: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **placementOptionId** | **string**| The identifier of a placement option. A placement option represents the shipment splits and destinations of SKUs. | 

### Return type

[**ConfirmPlacementOptionResponse**](ConfirmPlacementOptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmshipmentcontentupdatepreview"></a>
# **ConfirmShipmentContentUpdatePreview**
> ConfirmShipmentContentUpdatePreviewResponse ConfirmShipmentContentUpdatePreview (string inboundPlanId, string shipmentId, string contentUpdatePreviewId)



Confirm a shipment content update preview and accept the changes in transportation cost.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ConfirmShipmentContentUpdatePreviewExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var contentUpdatePreviewId = contentUpdatePreviewId_example;  // string | Identifier of a content update preview.

            try
            {
                ConfirmShipmentContentUpdatePreviewResponse result = apiInstance.ConfirmShipmentContentUpdatePreview(inboundPlanId, shipmentId, contentUpdatePreviewId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ConfirmShipmentContentUpdatePreview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **contentUpdatePreviewId** | **string**| Identifier of a content update preview. | 

### Return type

[**ConfirmShipmentContentUpdatePreviewResponse**](ConfirmShipmentContentUpdatePreviewResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmtransportationoptions"></a>
# **ConfirmTransportationOptions**
> ConfirmTransportationOptionsResponse ConfirmTransportationOptions (string inboundPlanId, ConfirmTransportationOptionsRequest body)



Confirms all the transportation options for an inbound plan. A placement option must be confirmed prior to use of this API. Once confirmed, new transportation options can not be generated or confirmed for the Inbound Plan.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ConfirmTransportationOptionsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var body = new ConfirmTransportationOptionsRequest(); // ConfirmTransportationOptionsRequest | The body of the request to `confirmTransportationOptions`.

            try
            {
                ConfirmTransportationOptionsResponse result = apiInstance.ConfirmTransportationOptions(inboundPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ConfirmTransportationOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **body** | [**ConfirmTransportationOptionsRequest**](ConfirmTransportationOptionsRequest.md)| The body of the request to &#x60;confirmTransportationOptions&#x60;. | 

### Return type

[**ConfirmTransportationOptionsResponse**](ConfirmTransportationOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinboundplan"></a>
# **CreateInboundPlan**
> CreateInboundPlanResponse CreateInboundPlan (CreateInboundPlanRequest body)



Creates an inbound plan. An inbound plan contains all the necessary information to send shipments into Amazon's fufillment network.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class CreateInboundPlanExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var body = new CreateInboundPlanRequest(); // CreateInboundPlanRequest | The body of the request to `createInboundPlan`.

            try
            {
                CreateInboundPlanResponse result = apiInstance.CreateInboundPlan(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.CreateInboundPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateInboundPlanRequest**](CreateInboundPlanRequest.md)| The body of the request to &#x60;createInboundPlan&#x60;. | 

### Return type

[**CreateInboundPlanResponse**](CreateInboundPlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmarketplaceitemlabels"></a>
# **CreateMarketplaceItemLabels**
> CreateMarketplaceItemLabelsResponse CreateMarketplaceItemLabels (CreateMarketplaceItemLabelsRequest body)



For a given marketplace - creates labels for a list of MSKUs.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class CreateMarketplaceItemLabelsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var body = new CreateMarketplaceItemLabelsRequest(); // CreateMarketplaceItemLabelsRequest | The body of the request to `createMarketplaceItemLabels`.

            try
            {
                CreateMarketplaceItemLabelsResponse result = apiInstance.CreateMarketplaceItemLabels(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.CreateMarketplaceItemLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateMarketplaceItemLabelsRequest**](CreateMarketplaceItemLabelsRequest.md)| The body of the request to &#x60;createMarketplaceItemLabels&#x60;. | 

### Return type

[**CreateMarketplaceItemLabelsResponse**](CreateMarketplaceItemLabelsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatedeliverywindowoptions"></a>
# **GenerateDeliveryWindowOptions**
> GenerateDeliveryWindowOptionsResponse GenerateDeliveryWindowOptions (string inboundPlanId, string shipmentId)



Generates available delivery window options for a given shipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class GenerateDeliveryWindowOptionsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | The shipment to generate delivery window options for.

            try
            {
                GenerateDeliveryWindowOptionsResponse result = apiInstance.GenerateDeliveryWindowOptions(inboundPlanId, shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.GenerateDeliveryWindowOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| The shipment to generate delivery window options for. | 

### Return type

[**GenerateDeliveryWindowOptionsResponse**](GenerateDeliveryWindowOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatepackingoptions"></a>
# **GeneratePackingOptions**
> GeneratePackingOptionsResponse GeneratePackingOptions (string inboundPlanId)



Generates available packing options for the inbound plan.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class GeneratePackingOptionsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.

            try
            {
                GeneratePackingOptionsResponse result = apiInstance.GeneratePackingOptions(inboundPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.GeneratePackingOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 

### Return type

[**GeneratePackingOptionsResponse**](GeneratePackingOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateplacementoptions"></a>
# **GeneratePlacementOptions**
> GeneratePlacementOptionsResponse GeneratePlacementOptions (string inboundPlanId, GeneratePlacementOptionsRequest body)



Generates placement options for the inbound plan.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class GeneratePlacementOptionsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var body = new GeneratePlacementOptionsRequest(); // GeneratePlacementOptionsRequest | The body of the request to `generatePlacementOptions`.

            try
            {
                GeneratePlacementOptionsResponse result = apiInstance.GeneratePlacementOptions(inboundPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.GeneratePlacementOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **body** | [**GeneratePlacementOptionsRequest**](GeneratePlacementOptionsRequest.md)| The body of the request to &#x60;generatePlacementOptions&#x60;. | 

### Return type

[**GeneratePlacementOptionsResponse**](GeneratePlacementOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateselfshipappointmentslots"></a>
# **GenerateSelfShipAppointmentSlots**
> GenerateSelfShipAppointmentSlotsResponse GenerateSelfShipAppointmentSlots (string inboundPlanId, string shipmentId, GenerateSelfShipAppointmentSlotsRequest body)



Initiates the process of generating the appointment slots list. Only available in the following [marketplaces](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids): MX, BR, EG, SA, AE, IN. 

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class GenerateSelfShipAppointmentSlotsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var body = new GenerateSelfShipAppointmentSlotsRequest(); // GenerateSelfShipAppointmentSlotsRequest | The body of the request to `generateSelfShipAppointmentSlots`.

            try
            {
                GenerateSelfShipAppointmentSlotsResponse result = apiInstance.GenerateSelfShipAppointmentSlots(inboundPlanId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.GenerateSelfShipAppointmentSlots: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **body** | [**GenerateSelfShipAppointmentSlotsRequest**](GenerateSelfShipAppointmentSlotsRequest.md)| The body of the request to &#x60;generateSelfShipAppointmentSlots&#x60;. | 

### Return type

[**GenerateSelfShipAppointmentSlotsResponse**](GenerateSelfShipAppointmentSlotsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateshipmentcontentupdatepreviews"></a>
# **GenerateShipmentContentUpdatePreviews**
> GenerateShipmentContentUpdatePreviewsResponse GenerateShipmentContentUpdatePreviews (string inboundPlanId, string shipmentId, GenerateShipmentContentUpdatePreviewsRequest body)



Generate a shipment content update preview given a set of intended boxes and/or items for a shipment with a confirmed carrier. The shipment content update preview will be viewable with the updated costs and contents prior to confirmation.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class GenerateShipmentContentUpdatePreviewsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var body = new GenerateShipmentContentUpdatePreviewsRequest(); // GenerateShipmentContentUpdatePreviewsRequest | The body of the request to `generateShipmentContentUpdatePreviews`.

            try
            {
                GenerateShipmentContentUpdatePreviewsResponse result = apiInstance.GenerateShipmentContentUpdatePreviews(inboundPlanId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.GenerateShipmentContentUpdatePreviews: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **body** | [**GenerateShipmentContentUpdatePreviewsRequest**](GenerateShipmentContentUpdatePreviewsRequest.md)| The body of the request to &#x60;generateShipmentContentUpdatePreviews&#x60;. | 

### Return type

[**GenerateShipmentContentUpdatePreviewsResponse**](GenerateShipmentContentUpdatePreviewsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatetransportationoptions"></a>
# **GenerateTransportationOptions**
> GenerateTransportationOptionsResponse GenerateTransportationOptions (string inboundPlanId, GenerateTransportationOptionsRequest body)



Generates available transportation options for a given placement option.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class GenerateTransportationOptionsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var body = new GenerateTransportationOptionsRequest(); // GenerateTransportationOptionsRequest | The body of the request to `generateTransportationOptions`.

            try
            {
                GenerateTransportationOptionsResponse result = apiInstance.GenerateTransportationOptions(inboundPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.GenerateTransportationOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **body** | [**GenerateTransportationOptionsRequest**](GenerateTransportationOptionsRequest.md)| The body of the request to &#x60;generateTransportationOptions&#x60;. | 

### Return type

[**GenerateTransportationOptionsResponse**](GenerateTransportationOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeliverychallandocument"></a>
# **GetDeliveryChallanDocument**
> GetDeliveryChallanDocumentResponse GetDeliveryChallanDocument (string inboundPlanId, string shipmentId)



Provide delivery challan document for PCP transportation in IN marketplace.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class GetDeliveryChallanDocumentExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.

            try
            {
                GetDeliveryChallanDocumentResponse result = apiInstance.GetDeliveryChallanDocument(inboundPlanId, shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.GetDeliveryChallanDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 

### Return type

[**GetDeliveryChallanDocumentResponse**](GetDeliveryChallanDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinboundoperationstatus"></a>
# **GetInboundOperationStatus**
> InboundOperationStatus GetInboundOperationStatus (string operationId)



Gets the status of the processing of an asynchronous API call.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class GetInboundOperationStatusExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var operationId = operationId_example;  // string | Identifier of an asynchronous operation.

            try
            {
                InboundOperationStatus result = apiInstance.GetInboundOperationStatus(operationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.GetInboundOperationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **operationId** | **string**| Identifier of an asynchronous operation. | 

### Return type

[**InboundOperationStatus**](InboundOperationStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinboundplan"></a>
# **GetInboundPlan**
> InboundPlan GetInboundPlan (string inboundPlanId)



Fetches the top level information about an inbound plan.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class GetInboundPlanExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.

            try
            {
                InboundPlan result = apiInstance.GetInboundPlan(inboundPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.GetInboundPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 

### Return type

[**InboundPlan**](InboundPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getselfshipappointmentslots"></a>
# **GetSelfShipAppointmentSlots**
> GetSelfShipAppointmentSlotsResponse GetSelfShipAppointmentSlots (string inboundPlanId, string shipmentId, int? pageSize = null, string paginationToken = null)



Retrieves a list of available self-ship appointment slots used to drop off a shipment at a warehouse. Only available in the following [marketplaces](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids): MX, BR, EG, SA, AE, IN. 

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class GetSelfShipAppointmentSlotsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var pageSize = 56;  // int? | The number of self ship appointment slots to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                GetSelfShipAppointmentSlotsResponse result = apiInstance.GetSelfShipAppointmentSlots(inboundPlanId, shipmentId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.GetSelfShipAppointmentSlots: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **pageSize** | **int?**| The number of self ship appointment slots to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**GetSelfShipAppointmentSlotsResponse**](GetSelfShipAppointmentSlotsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipment"></a>
# **GetShipment**
> Shipment GetShipment (string inboundPlanId, string shipmentId)



Provides the full details for a specific shipment within an inbound plan. The `transportationOptionId` inside `acceptedTransportationSelection` can be used to retrieve the transportation details for the shipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class GetShipmentExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.

            try
            {
                Shipment result = apiInstance.GetShipment(inboundPlanId, shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.GetShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 

### Return type

[**Shipment**](Shipment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipmentcontentupdatepreview"></a>
# **GetShipmentContentUpdatePreview**
> ContentUpdatePreview GetShipmentContentUpdatePreview (string inboundPlanId, string shipmentId, string contentUpdatePreviewId)



Retrieve a shipment content update preview which provides a summary of the requested shipment content changes along with the transportation cost implications of the change that can only be confirmed prior to the expiry date specified.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class GetShipmentContentUpdatePreviewExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var contentUpdatePreviewId = contentUpdatePreviewId_example;  // string | Identifier of a content update preview.

            try
            {
                ContentUpdatePreview result = apiInstance.GetShipmentContentUpdatePreview(inboundPlanId, shipmentId, contentUpdatePreviewId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.GetShipmentContentUpdatePreview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **contentUpdatePreviewId** | **string**| Identifier of a content update preview. | 

### Return type

[**ContentUpdatePreview**](ContentUpdatePreview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdeliverywindowoptions"></a>
# **ListDeliveryWindowOptions**
> ListDeliveryWindowOptionsResponse ListDeliveryWindowOptions (string inboundPlanId, string shipmentId, int? pageSize = null, string paginationToken = null)



Retrieves all delivery window options for a shipment. Delivery window options must first be generated by the `generateDeliveryWindowOptions` operation before becoming available.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListDeliveryWindowOptionsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | The shipment to get delivery window options for.
            var pageSize = 56;  // int? | The number of delivery window options to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                ListDeliveryWindowOptionsResponse result = apiInstance.ListDeliveryWindowOptions(inboundPlanId, shipmentId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListDeliveryWindowOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| The shipment to get delivery window options for. | 
 **pageSize** | **int?**| The number of delivery window options to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**ListDeliveryWindowOptionsResponse**](ListDeliveryWindowOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinboundplanboxes"></a>
# **ListInboundPlanBoxes**
> ListInboundPlanBoxesResponse ListInboundPlanBoxes (string inboundPlanId, int? pageSize = null, string paginationToken = null)



Provides a paginated list of box packages in an inbound plan.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListInboundPlanBoxesExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var pageSize = 56;  // int? | The number of boxes to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                ListInboundPlanBoxesResponse result = apiInstance.ListInboundPlanBoxes(inboundPlanId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListInboundPlanBoxes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **pageSize** | **int?**| The number of boxes to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**ListInboundPlanBoxesResponse**](ListInboundPlanBoxesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinboundplanitems"></a>
# **ListInboundPlanItems**
> ListInboundPlanItemsResponse ListInboundPlanItems (string inboundPlanId, int? pageSize = null, string paginationToken = null)



Provides a paginated list of item packages in an inbound plan.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListInboundPlanItemsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var pageSize = 56;  // int? | The number of items to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                ListInboundPlanItemsResponse result = apiInstance.ListInboundPlanItems(inboundPlanId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListInboundPlanItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **pageSize** | **int?**| The number of items to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**ListInboundPlanItemsResponse**](ListInboundPlanItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinboundplanpallets"></a>
# **ListInboundPlanPallets**
> ListInboundPlanPalletsResponse ListInboundPlanPallets (string inboundPlanId, int? pageSize = null, string paginationToken = null)



Provides a paginated list of pallet packages in an inbound plan. An inbound plan will have pallets when the related details are provided after generating Less-Than-Truckload (LTL) carrier shipments.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListInboundPlanPalletsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var pageSize = 56;  // int? | The number of pallets to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                ListInboundPlanPalletsResponse result = apiInstance.ListInboundPlanPallets(inboundPlanId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListInboundPlanPallets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **pageSize** | **int?**| The number of pallets to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**ListInboundPlanPalletsResponse**](ListInboundPlanPalletsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinboundplans"></a>
# **ListInboundPlans**
> ListInboundPlansResponse ListInboundPlans (int? pageSize = null, string paginationToken = null, string status = null, string sortBy = null, string sortOrder = null)



Provides a list of inbound plans with minimal information.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListInboundPlansExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var pageSize = 56;  // int? | The number of inbound plans to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 
            var status = status_example;  // string | The status of an inbound plan. (optional) 
            var sortBy = sortBy_example;  // string | Sort by field. (optional) 
            var sortOrder = sortOrder_example;  // string | The sort order. (optional) 

            try
            {
                ListInboundPlansResponse result = apiInstance.ListInboundPlans(pageSize, paginationToken, status, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListInboundPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageSize** | **int?**| The number of inbound plans to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 
 **status** | **string**| The status of an inbound plan. | [optional] 
 **sortBy** | **string**| Sort by field. | [optional] 
 **sortOrder** | **string**| The sort order. | [optional] 

### Return type

[**ListInboundPlansResponse**](ListInboundPlansResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listitemcompliancedetails"></a>
# **ListItemComplianceDetails**
> ListItemComplianceDetailsResponse ListItemComplianceDetails (List<string> mskus, string marketplaceId)



List the inbound compliance details for MSKUs in a given marketplace.  **Note:** MSKUs that contain certain characters must be encoded. For more information, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).  The following characters must be double percent encoded:  - `%` - `+` - `,`  **Examples:** An MSKU value of `test%msku` is encoded as `test%2525msku`. An MSKU value of `test,msku` is encoded as `test%252Cmsku`.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListItemComplianceDetailsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var mskus = new List<string>(); // List<string> | A list of merchant SKUs, a merchant-supplied identifier of a specific SKU.
            var marketplaceId = marketplaceId_example;  // string | The Marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).

            try
            {
                ListItemComplianceDetailsResponse result = apiInstance.ListItemComplianceDetails(mskus, marketplaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListItemComplianceDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mskus** | [**List&lt;string&gt;**](string.md)| A list of merchant SKUs, a merchant-supplied identifier of a specific SKU. | 
 **marketplaceId** | **string**| The Marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 

### Return type

[**ListItemComplianceDetailsResponse**](ListItemComplianceDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpackinggroupboxes"></a>
# **ListPackingGroupBoxes**
> ListPackingGroupBoxesResponse ListPackingGroupBoxes (string inboundPlanId, string packingGroupId, int? pageSize = null, string paginationToken = null)



Retrieves a page of boxes from a given packing group. These boxes were previously provided through the `setPackingInformation` operation. This API is used for workflows where boxes are packed before Amazon determines shipment splits.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListPackingGroupBoxesExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var packingGroupId = packingGroupId_example;  // string | Identifier of a packing group.
            var pageSize = 56;  // int? | The number of packing group boxes to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                ListPackingGroupBoxesResponse result = apiInstance.ListPackingGroupBoxes(inboundPlanId, packingGroupId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListPackingGroupBoxes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **packingGroupId** | **string**| Identifier of a packing group. | 
 **pageSize** | **int?**| The number of packing group boxes to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**ListPackingGroupBoxesResponse**](ListPackingGroupBoxesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpackinggroupitems"></a>
# **ListPackingGroupItems**
> ListPackingGroupItemsResponse ListPackingGroupItems (string inboundPlanId, string packingGroupId, int? pageSize = null, string paginationToken = null)



Retrieves a page of items in a given packing group. Packing options must first be generated by the corresponding operation before packing group items can be listed.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListPackingGroupItemsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var packingGroupId = packingGroupId_example;  // string | Identifier of a packing group.
            var pageSize = 56;  // int? | The number of packing group items to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                ListPackingGroupItemsResponse result = apiInstance.ListPackingGroupItems(inboundPlanId, packingGroupId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListPackingGroupItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **packingGroupId** | **string**| Identifier of a packing group. | 
 **pageSize** | **int?**| The number of packing group items to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**ListPackingGroupItemsResponse**](ListPackingGroupItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpackingoptions"></a>
# **ListPackingOptions**
> ListPackingOptionsResponse ListPackingOptions (string inboundPlanId, int? pageSize = null, string paginationToken = null)



Retrieves a list of all packing options for an inbound plan. Packing options must first be generated by the corresponding operation before becoming available.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListPackingOptionsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var pageSize = 56;  // int? | The number of packing options to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                ListPackingOptionsResponse result = apiInstance.ListPackingOptions(inboundPlanId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListPackingOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **pageSize** | **int?**| The number of packing options to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**ListPackingOptionsResponse**](ListPackingOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listplacementoptions"></a>
# **ListPlacementOptions**
> ListPlacementOptionsResponse ListPlacementOptions (string inboundPlanId, int? pageSize = null, string paginationToken = null)



Provides a list of all placement options for an inbound plan. Placement options must first be generated by the corresponding operation before becoming available.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListPlacementOptionsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var pageSize = 56;  // int? | The number of placement options to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                ListPlacementOptionsResponse result = apiInstance.ListPlacementOptions(inboundPlanId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListPlacementOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **pageSize** | **int?**| The number of placement options to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**ListPlacementOptionsResponse**](ListPlacementOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listprepdetails"></a>
# **ListPrepDetails**
> ListPrepDetailsResponse ListPrepDetails (string marketplaceId, List<string> mskus)



Get preparation details for a list of MSKUs in a specified marketplace.\\n\\n**Note:** MSKUs that contain certain characters must be encoded. For more information, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).\\n\\nThe following characters must be double percent encoded:\\n\\n- `%`\\n- `+`\\n- `,`\\n\\n**Examples:** An MSKU value of `test%msku` is encoded as `test%2525msku`. An MSKU value of `test,msku` is encoded as `test%252Cmsku`. 

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListPrepDetailsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var marketplaceId = marketplaceId_example;  // string | The marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var mskus = new List<string>(); // List<string> | A list of merchant SKUs, a merchant-supplied identifier of a specific SKU.

            try
            {
                ListPrepDetailsResponse result = apiInstance.ListPrepDetails(marketplaceId, mskus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListPrepDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| The marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **mskus** | [**List&lt;string&gt;**](string.md)| A list of merchant SKUs, a merchant-supplied identifier of a specific SKU. | 

### Return type

[**ListPrepDetailsResponse**](ListPrepDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listshipmentboxes"></a>
# **ListShipmentBoxes**
> ListShipmentBoxesResponse ListShipmentBoxes (string inboundPlanId, string shipmentId, int? pageSize = null, string paginationToken = null)



Provides a paginated list of box packages in a shipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListShipmentBoxesExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var pageSize = 56;  // int? | The number of boxes to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                ListShipmentBoxesResponse result = apiInstance.ListShipmentBoxes(inboundPlanId, shipmentId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListShipmentBoxes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **pageSize** | **int?**| The number of boxes to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**ListShipmentBoxesResponse**](ListShipmentBoxesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listshipmentcontentupdatepreviews"></a>
# **ListShipmentContentUpdatePreviews**
> ListShipmentContentUpdatePreviewsResponse ListShipmentContentUpdatePreviews (string inboundPlanId, string shipmentId, int? pageSize = null, string paginationToken = null)



Retrieve a paginated list of shipment content update previews for a given shipment. The shipment content update preview is a summary of the requested shipment content changes along with the transportation cost implications of the change that can only be confirmed prior to the expiry date specified.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListShipmentContentUpdatePreviewsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var pageSize = 56;  // int? | The number of content update previews to return. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                ListShipmentContentUpdatePreviewsResponse result = apiInstance.ListShipmentContentUpdatePreviews(inboundPlanId, shipmentId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListShipmentContentUpdatePreviews: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **pageSize** | **int?**| The number of content update previews to return. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**ListShipmentContentUpdatePreviewsResponse**](ListShipmentContentUpdatePreviewsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listshipmentitems"></a>
# **ListShipmentItems**
> ListShipmentItemsResponse ListShipmentItems (string inboundPlanId, string shipmentId, int? pageSize = null, string paginationToken = null)



Provides a paginated list of item packages in a shipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListShipmentItemsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var pageSize = 56;  // int? | The number of items to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                ListShipmentItemsResponse result = apiInstance.ListShipmentItems(inboundPlanId, shipmentId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListShipmentItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **pageSize** | **int?**| The number of items to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**ListShipmentItemsResponse**](ListShipmentItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listshipmentpallets"></a>
# **ListShipmentPallets**
> ListShipmentPalletsResponse ListShipmentPallets (string inboundPlanId, string shipmentId, int? pageSize = null, string paginationToken = null)



Provides a paginated list of pallet packages in a shipment. A palletized shipment will have pallets when the related details are provided after generating Less-Than-Truckload (LTL) carrier shipments.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListShipmentPalletsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var pageSize = 56;  // int? | The number of pallets to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 

            try
            {
                ListShipmentPalletsResponse result = apiInstance.ListShipmentPallets(inboundPlanId, shipmentId, pageSize, paginationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListShipmentPallets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **pageSize** | **int?**| The number of pallets to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 

### Return type

[**ListShipmentPalletsResponse**](ListShipmentPalletsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtransportationoptions"></a>
# **ListTransportationOptions**
> ListTransportationOptionsResponse ListTransportationOptions (string inboundPlanId, int? pageSize = null, string paginationToken = null, string placementOptionId = null, string shipmentId = null)



Retrieves all transportation options for a shipment. Transportation options must first be generated by the `generateTransportationOptions` operation before becoming available.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ListTransportationOptionsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var pageSize = 56;  // int? | The number of transportation options to return in the response matching the given query. (optional)  (default to 10)
            var paginationToken = paginationToken_example;  // string | A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the `pagination` returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. (optional) 
            var placementOptionId = placementOptionId_example;  // string | The placement option to get transportation options for. Either `placementOptionId` or `shipmentId` must be specified. (optional) 
            var shipmentId = shipmentId_example;  // string | The shipment to get transportation options for. Either `placementOptionId` or `shipmentId` must be specified. (optional) 

            try
            {
                ListTransportationOptionsResponse result = apiInstance.ListTransportationOptions(inboundPlanId, pageSize, paginationToken, placementOptionId, shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ListTransportationOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **pageSize** | **int?**| The number of transportation options to return in the response matching the given query. | [optional] [default to 10]
 **paginationToken** | **string**| A token to fetch a certain page when there are multiple pages worth of results. The value of this token is fetched from the &#x60;pagination&#x60; returned in the API response. In the absence of the token value from the query parameter the API returns the first page of the result. | [optional] 
 **placementOptionId** | **string**| The placement option to get transportation options for. Either &#x60;placementOptionId&#x60; or &#x60;shipmentId&#x60; must be specified. | [optional] 
 **shipmentId** | **string**| The shipment to get transportation options for. Either &#x60;placementOptionId&#x60; or &#x60;shipmentId&#x60; must be specified. | [optional] 

### Return type

[**ListTransportationOptionsResponse**](ListTransportationOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleselfshipappointment"></a>
# **ScheduleSelfShipAppointment**
> ScheduleSelfShipAppointmentResponse ScheduleSelfShipAppointment (string inboundPlanId, string shipmentId, string slotId, ScheduleSelfShipAppointmentRequest body)



Confirms or reschedules a self-ship appointment slot against a shipment. Only available in the following [marketplaces](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids): MX, BR, EG, SA, AE, IN. 

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class ScheduleSelfShipAppointmentExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var slotId = slotId_example;  // string | An identifier to a self-ship appointment slot.
            var body = new ScheduleSelfShipAppointmentRequest(); // ScheduleSelfShipAppointmentRequest | The body of the request to `scheduleSelfShipAppointment`.

            try
            {
                ScheduleSelfShipAppointmentResponse result = apiInstance.ScheduleSelfShipAppointment(inboundPlanId, shipmentId, slotId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.ScheduleSelfShipAppointment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **slotId** | **string**| An identifier to a self-ship appointment slot. | 
 **body** | [**ScheduleSelfShipAppointmentRequest**](ScheduleSelfShipAppointmentRequest.md)| The body of the request to &#x60;scheduleSelfShipAppointment&#x60;. | 

### Return type

[**ScheduleSelfShipAppointmentResponse**](ScheduleSelfShipAppointmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpackinginformation"></a>
# **SetPackingInformation**
> SetPackingInformationResponse SetPackingInformation (string inboundPlanId, SetPackingInformationRequest body)



Sets packing information for an inbound plan. This should be called after an inbound plan is created to populate the box level information required for planning and transportation estimates.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class SetPackingInformationExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var body = new SetPackingInformationRequest(); // SetPackingInformationRequest | The body of the request to `setPackingInformation`.

            try
            {
                SetPackingInformationResponse result = apiInstance.SetPackingInformation(inboundPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.SetPackingInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **body** | [**SetPackingInformationRequest**](SetPackingInformationRequest.md)| The body of the request to &#x60;setPackingInformation&#x60;. | 

### Return type

[**SetPackingInformationResponse**](SetPackingInformationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setprepdetails"></a>
# **SetPrepDetails**
> SetPrepDetailsResponse SetPrepDetails (SetPrepDetailsRequest body)



Set the preparation details for a list of MSKUs in a specified marketplace.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class SetPrepDetailsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var body = new SetPrepDetailsRequest(); // SetPrepDetailsRequest | The body of the request to `setPrepDetails`.

            try
            {
                SetPrepDetailsResponse result = apiInstance.SetPrepDetails(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.SetPrepDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SetPrepDetailsRequest**](SetPrepDetailsRequest.md)| The body of the request to &#x60;setPrepDetails&#x60;. | 

### Return type

[**SetPrepDetailsResponse**](SetPrepDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinboundplanname"></a>
# **UpdateInboundPlanName**
> void UpdateInboundPlanName (string inboundPlanId, UpdateInboundPlanNameRequest body)



Updates the name of an existing inbound plan.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class UpdateInboundPlanNameExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var body = new UpdateInboundPlanNameRequest(); // UpdateInboundPlanNameRequest | The body of the request to `updateInboundPlanName`.

            try
            {
                apiInstance.UpdateInboundPlanName(inboundPlanId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.UpdateInboundPlanName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **body** | [**UpdateInboundPlanNameRequest**](UpdateInboundPlanNameRequest.md)| The body of the request to &#x60;updateInboundPlanName&#x60;. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemcompliancedetails"></a>
# **UpdateItemComplianceDetails**
> UpdateItemComplianceDetailsResponse UpdateItemComplianceDetails (string marketplaceId, UpdateItemComplianceDetailsRequest body)



Update compliance details for a list of MSKUs. The details provided here are only used for the India (IN - A21TJRUUN4KGV) marketplace compliance validation.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class UpdateItemComplianceDetailsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var marketplaceId = marketplaceId_example;  // string | The Marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
            var body = new UpdateItemComplianceDetailsRequest(); // UpdateItemComplianceDetailsRequest | The body of the request to `updateItemComplianceDetails`.

            try
            {
                UpdateItemComplianceDetailsResponse result = apiInstance.UpdateItemComplianceDetails(marketplaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.UpdateItemComplianceDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceId** | **string**| The Marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). | 
 **body** | [**UpdateItemComplianceDetailsRequest**](UpdateItemComplianceDetailsRequest.md)| The body of the request to &#x60;updateItemComplianceDetails&#x60;. | 

### Return type

[**UpdateItemComplianceDetailsResponse**](UpdateItemComplianceDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshipmentname"></a>
# **UpdateShipmentName**
> void UpdateShipmentName (string inboundPlanId, string shipmentId, UpdateShipmentNameRequest body)



Updates the name of an existing shipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class UpdateShipmentNameExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var body = new UpdateShipmentNameRequest(); // UpdateShipmentNameRequest | The body of the request to `updateShipmentName`.

            try
            {
                apiInstance.UpdateShipmentName(inboundPlanId, shipmentId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.UpdateShipmentName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **body** | [**UpdateShipmentNameRequest**](UpdateShipmentNameRequest.md)| The body of the request to &#x60;updateShipmentName&#x60;. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshipmentsourceaddress"></a>
# **UpdateShipmentSourceAddress**
> UpdateShipmentSourceAddressResponse UpdateShipmentSourceAddress (string inboundPlanId, string shipmentId, UpdateShipmentSourceAddressRequest body)



Updates the source address of an existing shipment. The shipment source address can only be updated prior to the confirmation of the shipment carriers. As a result of the updated source address, existing transportation options will be invalidated and will need to be regenerated to capture the potential difference in transportation options and quotes due to the new source address.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class UpdateShipmentSourceAddressExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var body = new UpdateShipmentSourceAddressRequest(); // UpdateShipmentSourceAddressRequest | The body of the request to `updateShipmentSourceAddress`.

            try
            {
                UpdateShipmentSourceAddressResponse result = apiInstance.UpdateShipmentSourceAddress(inboundPlanId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.UpdateShipmentSourceAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **body** | [**UpdateShipmentSourceAddressRequest**](UpdateShipmentSourceAddressRequest.md)| The body of the request to &#x60;updateShipmentSourceAddress&#x60;. | 

### Return type

[**UpdateShipmentSourceAddressResponse**](UpdateShipmentSourceAddressResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshipmenttrackingdetails"></a>
# **UpdateShipmentTrackingDetails**
> UpdateShipmentTrackingDetailsResponse UpdateShipmentTrackingDetails (string inboundPlanId, string shipmentId, UpdateShipmentTrackingDetailsRequest body)



Updates a shipment's tracking details.

### Example
```csharp
using System;
using System.Diagnostics;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;

namespace Example
{
    public class UpdateShipmentTrackingDetailsExample
    {
        public void main()
        {
            var apiInstance = new FbaInboundApi();
            var inboundPlanId = inboundPlanId_example;  // string | Identifier of an inbound plan.
            var shipmentId = shipmentId_example;  // string | Identifier of a shipment. A shipment contains the boxes and units being inbounded.
            var body = new UpdateShipmentTrackingDetailsRequest(); // UpdateShipmentTrackingDetailsRequest | The body of the request to `updateShipmentTrackingDetails`.

            try
            {
                UpdateShipmentTrackingDetailsResponse result = apiInstance.UpdateShipmentTrackingDetails(inboundPlanId, shipmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FbaInboundApi.UpdateShipmentTrackingDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundPlanId** | **string**| Identifier of an inbound plan. | 
 **shipmentId** | **string**| Identifier of a shipment. A shipment contains the boxes and units being inbounded. | 
 **body** | [**UpdateShipmentTrackingDetailsRequest**](UpdateShipmentTrackingDetailsRequest.md)| The body of the request to &#x60;updateShipmentTrackingDetails&#x60;. | 

### Return type

[**UpdateShipmentTrackingDetailsResponse**](UpdateShipmentTrackingDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

