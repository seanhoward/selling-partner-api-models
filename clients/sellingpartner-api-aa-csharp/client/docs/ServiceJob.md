# Amazon.SellingPartnerAPIAA.Clients.Models.Services.ServiceJob
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreateTime** | **DateTime?** | The date and time of the creation of the job in ISO 8601 format. | [optional] 
**ServiceJobId** | **string** | The service job identifier. | [optional] 
**ServiceJobStatus** | **string** | The status of the service job. | [optional] 
**ScopeOfWork** | [**ScopeOfWork**](ScopeOfWork.md) | The scope of work for the order. | [optional] 
**Seller** | [**Seller**](Seller.md) | Information about the seller of the service job. | [optional] 
**ServiceJobProvider** | [**ServiceJobProvider**](ServiceJobProvider.md) | Information about the service job provider. | [optional] 
**PreferredAppointmentTimes** | [**List&lt;AppointmentTime&gt;**](AppointmentTime.md) | A list of appointment windows preferred by the buyer. Included only if the buyer selected appointment windows when creating the order. | [optional] 
**Appointments** | [**List&lt;Appointment&gt;**](Appointment.md) | A list of appointments. | [optional] 
**ServiceOrderId** | **string** | The Amazon-defined identifier for an order placed by the buyer in 3-7-7 format. | [optional] 
**MarketplaceId** | **string** | The marketplace identifier. | [optional] 
**StoreId** | **string** | The Amazon-defined identifier for the region scope. | [optional] 
**Buyer** | [**Buyer**](Buyer.md) | Information about the buyer. | [optional] 
**AssociatedItems** | [**List&lt;AssociatedItem&gt;**](AssociatedItem.md) | A list of items associated with the service job. | [optional] 
**ServiceLocation** | [**ServiceLocation**](ServiceLocation.md) | Information about the location of the service job. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

