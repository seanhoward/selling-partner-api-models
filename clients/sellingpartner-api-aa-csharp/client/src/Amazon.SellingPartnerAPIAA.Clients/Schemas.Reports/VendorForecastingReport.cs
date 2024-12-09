//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Reports.VendorForecasting
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// Describes forecast units for a particular ASIN for a specific period of time in the future.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ForecastByAsin
    {
        /// <summary>
        /// The date that the forecast was generated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("forecastGenerationDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset ForecastGenerationDate { get; set; }

        /// <summary>
        /// The Amazon Standard Identification Number.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asin", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Asin { get; set; }

        /// <summary>
        /// The start date of the time period being forecasted. The forecasted time period includes this date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The end date of the time period being forecasted. The forecasted time period includes this date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// The average amount of forecast units that Amazon has predicted for this date range. This means that, on average, Amazon predicts that this many stock units will be purchased during this date range.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meanForecastUnits", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double MeanForecastUnits { get; set; }

        /// <summary>
        /// The 70th percentile of forecast units that Amazon has predicted for this date range. This means that Amazon has forecasted a 70% probability that the ASIN will not run out of stock during the date range if this many units of inventory are present at the start of the date range.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("p70ForecastUnits", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double P70ForecastUnits { get; set; }

        /// <summary>
        /// The 80th percentile of forecast units that Amazon has predicted for this date range. This means that Amazon has forecasted an 80% probability that the ASIN will not run out of stock during the date range if this many units of inventory are present at the start of the date range.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("p80ForecastUnits", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double P80ForecastUnits { get; set; }

        /// <summary>
        /// The 90th percentile of forecast units that Amazon has predicted for this date range. This means that Amazon has forecasted a 90% probability that the ASIN will not run out of stock during the date range if this many units of inventory are present at the start of the date range.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("p90ForecastUnits", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double P90ForecastUnits { get; set; }



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
        public static ForecastByAsin FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<ForecastByAsin>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    /// <summary>
    /// Forecast customer demand of your products for production and inventory planning purposes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class VendorForecastingReport
    {
        /// <summary>
        /// The report input summary which includes the marketplace, selling program, and last updated date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportSpecification", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ReportSpecification ReportSpecification { get; set; } = new ReportSpecification();

        [Newtonsoft.Json.JsonProperty("forecastByAsin", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<ForecastByAsin> ForecastByAsin { get; set; } = new System.Collections.ObjectModel.Collection<ForecastByAsin>();



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
        public static VendorForecastingReport FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<VendorForecastingReport>(data, new Newtonsoft.Json.JsonSerializerSettings());

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
        /// Report options specifying parameters such as sellingProgram.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportOptions", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ReportOptions ReportOptions { get; set; } = new ReportOptions();

        /// <summary>
        /// The date when the report was last updated. Follows the &lt;a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'&gt;ISO 8601&lt;/a&gt; Date format of YYYY-MM-DD.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastUpdatedDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset LastUpdatedDate { get; set; }

        /// <summary>
        /// This parameter must match the marketplaceId of the selling partner account. Each selling partner account belongs to only one marketplaceId.
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

        [System.Runtime.Serialization.EnumMember(Value = @"GET_VENDOR_FORECASTING_REPORT")]
        GET_VENDOR_FORECASTING_REPORT = 0,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ReportOptions
    {
        /// <summary>
        /// The selling program.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sellingProgram", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReportOptionsSellingProgram SellingProgram { get; set; }



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
    public enum ReportOptionsSellingProgram
    {

        [System.Runtime.Serialization.EnumMember(Value = @"RETAIL")]
        RETAIL = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"FRESH")]
        FRESH = 1,


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