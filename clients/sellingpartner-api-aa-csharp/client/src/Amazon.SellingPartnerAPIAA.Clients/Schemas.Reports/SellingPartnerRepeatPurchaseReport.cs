//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Reports.SellingPartnerRepeatPurchase
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// Contains repeat purchase analytics data for each ASIN in the selling partner's catalog
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DataByAsin
    {
        /// <summary>
        /// The start date of the data contained within the object. If the request spans multiple reportPeriods, byAsin data will be shared for each of these reportPeriods.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The end date of the data contained within the object.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// Amazon Standard Identification Number.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asin", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Asin { get; set; }

        /// <summary>
        /// The number of orders. An order may include multiple quantities of a product and differs from ordered units.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orders", Required = Newtonsoft.Json.Required.Always)]
        public int Orders { get; set; }

        /// <summary>
        /// Number of unique customers who placed an order containing the asin.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uniqueCustomers", Required = Newtonsoft.Json.Required.Always)]
        public int UniqueCustomers { get; set; }

        /// <summary>
        /// Fraction of unique customers that are repeat customers.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repeatCustomersPctTotal", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, 1D)]
        public double RepeatCustomersPctTotal { get; set; }

        /// <summary>
        /// Ordered revenue from repeat customers. Returns are not reflected.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repeatPurchaseRevenue", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public RepeatPurchaseRevenue RepeatPurchaseRevenue { get; set; } = new RepeatPurchaseRevenue();

        /// <summary>
        /// Fraction of repeatPurchaseRevenue versus total revenue.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repeatPurchaseRevenuePctTotal", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, 1D)]
        public double RepeatPurchaseRevenuePctTotal { get; set; }



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
        public static DataByAsin FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<DataByAsin>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    /// <summary>
    /// The Repeat Purchase report shares data on the quantity of repeated purchases of the selling partner's items. Data is available at different date range aggregation levels: WEEK, MONTH, QUARTER. Requests can span multiple reporting periods. In this report, "asin" is an ASIN in the selling partner's catalog.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SellingPartnerRepeatPurchaseReport
    {
        /// <summary>
        /// Summarizes the original report request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportSpecification", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ReportSpecification ReportSpecification { get; set; } = new ReportSpecification();

        [Newtonsoft.Json.JsonProperty("dataByAsin", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<DataByAsin> DataByAsin { get; set; } = new System.Collections.ObjectModel.Collection<DataByAsin>();



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
        public static SellingPartnerRepeatPurchaseReport FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<SellingPartnerRepeatPurchaseReport>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class RepeatPurchaseRevenue
    {
        /// <summary>
        /// The amount.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; }

        /// <summary>
        /// The currency code of the amount.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currencyCode", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"[A-Z]{3}")]
        public string CurrencyCode { get; set; }



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
        public static RepeatPurchaseRevenue FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<RepeatPurchaseRevenue>(data, new Newtonsoft.Json.JsonSerializerSettings());

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReportSpecificationReportType ReportType { get; set; }

        /// <summary>
        /// Report options specifying parameters such as reportPeriod.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportOptions", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ReportOptions ReportOptions { get; set; } = new ReportOptions();

        /// <summary>
        /// Determines the start date of the report - the time component is ignored. For WEEK, MONTH and QUARTER reportPeriods, this value must correspond to the first day in the specified reportPeriod. For example, dataStartTime must be a Sunday for the WEEK reportPeriod.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataStartTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset DataStartTime { get; set; }

        /// <summary>
        /// Determines the end date of the report - the time component is ignored. For WEEK, MONTH and QUARTER reportPeriods, this value must correspond to the last day in the specified reportPeriod. For example, dataEndTime must be a Saturday for the WEEK reportPeriod.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataEndTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset DataEndTime { get; set; }

        /// <summary>
        /// This parameter must match the marketplaceId of the selling partner account. This report type supports only one marketplaceId per report. Specifying multiple marketplaces will result in failure to generate the report.
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

        [System.Runtime.Serialization.EnumMember(Value = @"GET_BRAND_ANALYTICS_REPEAT_PURCHASE_REPORT")]
        GET_BRAND_ANALYTICS_REPEAT_PURCHASE_REPORT = 0,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ReportOptions
    {
        /// <summary>
        /// Determines what granularity of data is expected in the report. Valid values are: WEEK, MONTH, QUARTER.
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

        [System.Runtime.Serialization.EnumMember(Value = @"WEEK")]
        WEEK = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"MONTH")]
        MONTH = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"QUARTER")]
        QUARTER = 2,


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