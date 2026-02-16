# Amazon.SellingPartnerAPIAA.Clients.Models.Replenishment.GetSellingPartnerMetricsRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AggregationFrequency** | **AggregationFrequency** |  | [optional] 
**TimeInterval** | [**TimeInterval**](TimeInterval.md) | A time interval used to compute metrics. | 
**Metrics** | [**List&lt;Metric&gt;**](Metric.md) | The list of metrics requested. If no metric value is provided, data for all of the metrics will be returned. | [optional] 
**TimePeriodType** | **TimePeriodType** |  | 
**MarketplaceId** | **string** | The marketplace identifier. The supported marketplaces for both sellers and vendors are US, CA, ES, UK, FR, IT, IN, DE and JP. The supported marketplaces for vendors only are BR, AU, MX, AE and NL.  Refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids) to find the identifier for the marketplace. | 
**ProgramTypes** | [**ProgramTypes**](ProgramTypes.md) | The list of replenishment program types for which to return metrics. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

