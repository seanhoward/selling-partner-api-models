# Amazon.SellingPartnerAPIAA.Clients.Models.Awd.ReplenishmentOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfirmedOn** | **DateTime?** | Date on which this replenishment order was confirmed. | [optional] 
**CreatedAt** | **DateTime?** | Date on which this replenishment order was created. | [optional] 
**DistributionIneligibleReasons** | [**List&lt;DistributionIneligibleReason&gt;**](DistributionIneligibleReason.md) | Distribution errors associated with the order related to the products or packages to replenish. This field will be populated if the order has products or packages which failed validation. | [optional] 
**EligibleProducts** | [**List&lt;DistributionProduct&gt;**](DistributionProduct.md) | List of product units that are eligible for replenishment. | [optional] 
**OrderId** | **string** | Order Id of the replenishment order. | 
**Status** | **ReplenishmentOrderStatus** |  | 
**OutboundShipments** | [**List&lt;OutboundShipmentSummary&gt;**](OutboundShipmentSummary.md) | List of outbound shipments that are part of this order. | 
**Products** | [**List&lt;DistributionProduct&gt;**](DistributionProduct.md) | Requested amount of single product units to be replenished. | [optional] 
**ShippedProducts** | [**List&lt;DistributionProduct&gt;**](DistributionProduct.md) | Outbound product units that are shipped after the execution has completed post confirmation. | [optional] 
**UpdatedAt** | **DateTime?** | Date on which this replenishment order was last updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

