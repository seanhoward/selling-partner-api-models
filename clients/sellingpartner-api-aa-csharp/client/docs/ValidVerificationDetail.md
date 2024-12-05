# Amazon.SellingPartnerAPIAA.Clients.Models.Orders.ValidVerificationDetail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VerificationDetailType** | **string** | A supported type of verification detail. The type indicates which verification detail could be shared while updating the regulated order. Valid value: &#x60;prescriptionDetail&#x60;. | 
**ValidVerificationStatuses** | [**List&lt;VerificationStatus&gt;**](VerificationStatus.md) | A list of valid verification statuses where the associated verification detail type may be provided. For example, if the value of this field is [\&quot;Approved\&quot;], calls to provide the associated verification detail will fail for orders with a &#x60;VerificationStatus&#x60; of &#x60;Pending&#x60;, &#x60;Rejected&#x60;, &#x60;Expired&#x60;, or &#x60;Cancelled&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

