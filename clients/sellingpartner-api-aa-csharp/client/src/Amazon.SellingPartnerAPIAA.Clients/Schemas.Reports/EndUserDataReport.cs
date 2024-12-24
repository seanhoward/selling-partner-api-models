//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Reports.EndUserData
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// Contains end user contact information, page view and GMS metrics.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class EndUserData
    {
        /// <summary>
        /// Full Name of the end user.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string FullName { get; set; }

        /// <summary>
        /// Mailing address of the end user.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mailingAddress", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public MailingAddress MailingAddress { get; set; } = new MailingAddress();

        /// <summary>
        /// Primary email of the end user.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("primaryEmail", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PrimaryEmail { get; set; }

        /// <summary>
        /// A list of Asin Page View and GMS metrics of an end user.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asinMetrics", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<AsinMetrics> AsinMetrics { get; set; } = new System.Collections.ObjectModel.Collection<AsinMetrics>();



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
        public static EndUserData FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<EndUserData>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    /// <summary>
    /// Page view and GMS metrics of the end user.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AsinMetrics
    {
        /// <summary>
        /// Start date of the aggregation window.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// End date of the aggregation window.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// Marketplace for which the metrics are provided.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marketplaceId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// ASIN for which the metrics are provided. Only ASINs with an active offer from the Seller are included.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asin", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Asin { get; set; }

        /// <summary>
        /// End user's page views (count) for the ASIN.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pageViews", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int PageViews { get; set; }

        /// <summary>
        /// End user's GMS for the ASIN. GMS = (Product Price * Quantity) + Shipping + Giftwrap - Returns - Promotional Discounts.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gms", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Gms { get; set; }

        /// <summary>
        /// The ISO 4217 currency code in which GMS is calculated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currencyCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
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
        public static AsinMetrics FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<AsinMetrics>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    /// <summary>
    /// Provides end user (customer) data to DE, FR, IT, ES, NL, PL, SE and BE (EU-8) Selling Partners. This data contains customer personal data, including contact information, page view (glance view), and order data for customers who have elected to share this data with specific sellers. This data is accessible across various reporting periods, including DAY, WEEK and MONTH. Developers can choose to define start and end dates, along with the desired reporting period for data retrieval and aggregation. Please note that the report will not generate any data if no customers have elected to share their data.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class EndUserDataReport
    {
        /// <summary>
        /// Summarizes the report request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportSpecification", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ReportSpecification ReportSpecification { get; set; } = new ReportSpecification();

        /// <summary>
        /// A list of consented end users (buyers) and their data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endUserData", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<EndUserData> EndUserData { get; set; } = new System.Collections.ObjectModel.Collection<EndUserData>();



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
        public static EndUserDataReport FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<EndUserDataReport>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class MailingAddress
    {
        /// <summary>
        /// The first line of the address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addressLine1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Additional address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addressLine2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Additional address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addressLine3", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// State or Region.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stateOrRegion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// District or County.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("districtOrCounty", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DistrictOrCounty { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("postalCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The two letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("countryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryCode { get; set; }



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
        public static MailingAddress FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<MailingAddress>(data, new Newtonsoft.Json.JsonSerializerSettings());

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
        /// Used to specify the report period.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportOptions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ReportOptions ReportOptions { get; set; }

        /// <summary>
        /// Determines the start date of the report - the time component is ignored. If the provided start date occurs mid-week or mid-month, the following Sunday for weekly reporting periods or the first day of the next month for monthly reporting periods will be used instead.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataStartTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset DataStartTime { get; set; }

        /// <summary>
        /// Determines the end date of the report - the time component is ignored. If the provided end date occurs mid-week or mid-month, the preceding Saturday for weekly reporting periods or the last day of the previous month for monthly reporting periods will be used instead. Additionally if the end date differs from the start date by more than 365 days, it will be adjusted to the closest end date with a maximum 365 day difference based on the selected reporting period.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataEndTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset DataEndTime { get; set; }

        /// <summary>
        /// Any of the EU(8) marketplaces. DE, FR, IT, ES, NL, PL, SE and BE
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
        /// The granularity of the data in the report. Valid values are: DAY, WEEK, and MONTH. If no granularity is specified, reportPeriod defaults to MONTH.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportPeriod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
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