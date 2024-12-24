//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Reports.MarketplaceAsinPageViewMetrics
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// Contains aggregate ASIN page view metrics.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class MarketplaceAsinPageViewMetrics
    {
        /// <summary>
        /// Start time of the aggregation window in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// End time of the aggregation window in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Marketplace for which the page view metrics are provided.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marketplaceId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// ASIN for which the page view metrics are provided.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asin", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Asin { get; set; }

        /// <summary>
        /// Total page views (count).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pageViews", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int PageViews { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

        public string ToJson()
        {

            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public static MarketplaceAsinPageViewMetrics FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<MarketplaceAsinPageViewMetrics>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    /// <summary>
    /// Provides information on the ASIN page view (glance view) metrics for the DE, FR, IT, ES, NL, PL, SE, BE (EU-8) and UK marketplaces, with data available up to the last seven days. A page view is a customer view of the product's detail page for a given ASIN. Developers have the option to specify a start and end date to retrieve data within that range. If no dates are specified, the report will provide the data for the latest available day. For marketplaces and product categories where the seller does not have a meaningful presence (40 units sold), the report will not return any data.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class MarketplaceAsinPageViewMetrics2
    {
        /// <summary>
        /// Summarizes the report request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportSpecification", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ReportSpecification ReportSpecification { get; set; } = new ReportSpecification();

        /// <summary>
        /// A list of ASIN page view metrics.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marketplaceAsinPageViewMetrics", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<MarketplaceAsinPageViewMetrics> MarketplaceAsinPageViewMetrics { get; set; } = new System.Collections.ObjectModel.Collection<MarketplaceAsinPageViewMetrics>();



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

        public string ToJson()
        {

            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public static MarketplaceAsinPageViewMetrics2 FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<MarketplaceAsinPageViewMetrics2>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ReportSpecification
    {
        /// <summary>
        /// The report type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ReportType { get; set; }

        /// <summary>
        /// Specifies the product type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportOptions", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ReportOptions ReportOptions { get; set; } = new ReportOptions();

        /// <summary>
        /// Determines the start date of the report - the time component is ignored. If the start date of the report is more than seven days ago, the report will be cancelled. If the start date of the report is not provided, it will default to the start date of the most recently available daily data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataStartTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset DataStartTime { get; set; }

        /// <summary>
        /// Determines the end date of the report - the time component is ignored. If the end date of the report is not within the seven days from start date, the report will be cancelled. If the end date of the report is not provided, it will default to the end date of the most recently available daily date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataEndTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset DataEndTime { get; set; }

        /// <summary>
        /// Any of the EU(8) or UK marketplaces. DE, FR, IT, ES, NL, PL, SE, BE and UK
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marketplaceIds", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<string> MarketplaceIds { get; set; } = new System.Collections.ObjectModel.Collection<string>();



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

        public string ToJson()
        {

            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public static ReportSpecification FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<ReportSpecification>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ReportOptions
    {
        /// <summary>
        /// The Amazon product type of the ASINs for which the report is being requested. All ASINs with the productType will be included. The value for the product type can be found by following instructions on Seller Central's Help page. - https://developer-docs.amazon.com/sp-api/docs/seller-central-urls
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ProductType { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

        public string ToJson()
        {

            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public static ReportOptions FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<ReportOptions>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    internal class DateFormatConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public DateFormatConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}