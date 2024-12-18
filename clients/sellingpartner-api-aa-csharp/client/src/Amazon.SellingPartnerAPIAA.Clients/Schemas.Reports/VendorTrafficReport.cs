//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Reports.VendorTraffic
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// Describes aggregated traffic metrics for ASINs in the vendor's account.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TrafficAggregate
    {
        /// <summary>
        /// The start date of the aggregated data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The end date of the aggregated data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// Customer views of the vendor's product detail pages.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("glanceViews", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int GlanceViews { get; set; }



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
        public static TrafficAggregate FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<TrafficAggregate>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    /// <summary>
    /// Describes aggregated ASIN-level traffic metrics for ASINs in the vendor's account.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TrafficByAsin
    {
        /// <summary>
        /// The start date of the aggregated ASIN-level data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string StartDate { get; set; }

        /// <summary>
        /// The end date of the aggregated ASIN-level data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string EndDate { get; set; }

        /// <summary>
        /// The Amazon Standard Identification Number.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asin", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Asin { get; set; }

        /// <summary>
        /// The number of customer views of the product detail page.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("glanceViews", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int GlanceViews { get; set; }



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
        public static TrafficByAsin FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<TrafficByAsin>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    /// <summary>
    /// This report shares data on the customer traffic to the detail pages of the vendor's items both at an aggregated level (across the vendor's entire catalog of items) and at a per-ASIN level. Data is available for different date range aggregation levels: DAY, WEEK, MONTH, QUARTER, YEAR. Requests can span multiple date range periods.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class VendorTrafficReport
    {
        /// <summary>
        /// The report summary including the specified reporting date range and the last updated date in the input.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportSpecification", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ReportSpecification ReportSpecification { get; set; } = new ReportSpecification();

        [Newtonsoft.Json.JsonProperty("trafficAggregate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<TrafficAggregate> TrafficAggregate { get; set; } = new System.Collections.ObjectModel.Collection<TrafficAggregate>();

        [Newtonsoft.Json.JsonProperty("trafficByAsin", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<TrafficByAsin> TrafficByAsin { get; set; } = new System.Collections.ObjectModel.Collection<TrafficByAsin>();



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
        public static VendorTrafficReport FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<VendorTrafficReport>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ReportSpecification
    {
        /// <summary>
        /// The type of report.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReportSpecificationReportType ReportType { get; set; }

        /// <summary>
        /// Report options specifying parameters such as reportPeriod.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportOptions", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ReportOptions ReportOptions { get; set; } = new ReportOptions();

        /// <summary>
        /// The date when the report was last updated. Follows the &lt;a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'&gt;ISO 8601&lt;/a&gt; date format of YYYY-MM-DD.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastUpdatedDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset LastUpdatedDate { get; set; }

        /// <summary>
        /// Determines the start date of the report - the time component is ignored. For WEEK, MONTH, QUARTER, and YEAR reportPeriods, this value must correspond to the first day in the specified reportPeriod or else a fatal error is returned. For example, dataStartTime must be a Sunday for the WEEK reportPeriod.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataStartTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset DataStartTime { get; set; }

        /// <summary>
        /// Determines the end date of the report - the time component is ignored. For WEEK, MONTH, QUARTER, and YEAR reportPeriods, this value must correspond to the last day in the specified reportPeriod or else a fatal error is returned. For example, dataEndTime must be a Saturday for the WEEK reportPeriod.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataEndTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset DataEndTime { get; set; }

        /// <summary>
        /// This parameter must match the marketplaceId of the selling partner account (each selling partner account belongs to one and only one marketplaceId).
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
    public enum ReportSpecificationReportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"GET_VENDOR_TRAFFIC_REPORT")]
        GET_VENDOR_TRAFFIC_REPORT = 0,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ReportOptions
    {
        /// <summary>
        /// The granularity of the data in the report. Valid values are: DAY, WEEK, MONTH, QUARTER, YEAR.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportPeriod", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReportOptionsReportPeriod ReportPeriod { get; set; }



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
    public enum ReportOptionsReportPeriod
    {

        [System.Runtime.Serialization.EnumMember(Value = @"DAY")]
        DAY = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"WEEK")]
        WEEK = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"MONTH")]
        MONTH = 2,


        [System.Runtime.Serialization.EnumMember(Value = @"QUARTER")]
        QUARTER = 3,


        [System.Runtime.Serialization.EnumMember(Value = @"YEAR")]
        YEAR = 4,


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