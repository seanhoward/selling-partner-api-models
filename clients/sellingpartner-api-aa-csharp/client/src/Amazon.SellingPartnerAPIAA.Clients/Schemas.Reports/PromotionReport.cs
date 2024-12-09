//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Reports.Promotion
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// An object that contains details about a promotion and every included product.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DetailsByPromotion
    {
        /// <summary>
        /// The unique identifier of the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotionId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PromotionId { get; set; }

        /// <summary>
        /// The customer facing name of the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotionName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PromotionName { get; set; }

        /// <summary>
        /// The vendor code associated with the promotion funding agreement. For vendors only.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendorCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VendorCode { get; set; }

        /// <summary>
        /// The merchant customer ID associated with the promotion funding agreement. For sellers only.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchantId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MerchantId { get; set; }

        /// <summary>
        /// The number of units sold across all ASINs in the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unitsSold", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int UnitsSold { get; set; }

        /// <summary>
        /// Total funding provided across all ASINs in the promotion. For vendors only.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amountSpent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double AmountSpent { get; set; }

        /// <summary>
        /// The ISO 4217 currency code of amountSpent.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amountSpentCurrencyCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmountSpentCurrencyCode { get; set; }

        /// <summary>
        /// The total revenue generated across all ASINs in the promotion. For sellers, this is equivalent to "sales" in the Seller Central UI.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("revenue", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Revenue { get; set; }

        /// <summary>
        /// The ISO 4217 currency code of revenue.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("revenueCurrencyCode", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string RevenueCurrencyCode { get; set; }

        /// <summary>
        /// Promotion start date-time in ISO 8601 format in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset StartDateTime { get; set; }

        /// <summary>
        /// Promotion end date-time in ISO 8601 format in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset EndDateTime { get; set; }

        /// <summary>
        /// The type of the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DetailsByPromotionType Type { get; set; }

        /// <summary>
        /// The state that the promotion is in.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DetailsByPromotionStatus Status { get; set; }

        /// <summary>
        /// The mode of creation for the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creationChannel", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DetailsByPromotionCreationChannel CreationChannel { get; set; }

        /// <summary>
        /// The marketplace the promotion is running in.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marketplaceId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The ID for the funding agreement. For vendors only.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundingAgreementId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FundingAgreementId { get; set; }

        /// <summary>
        /// The total customer views for all product detail pages.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("glanceViews", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int GlanceViews { get; set; }

        /// <summary>
        /// The promotion creation date-time in ISO 8601 format in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createdDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        /// The promotion last updated date-time in ISO 8601 format in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastUpdatedDateTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset LastUpdatedDateTime { get; set; }

        /// <summary>
        /// List of included products and their details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("includedProducts", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<DetailsByProduct> IncludedProducts { get; set; } = new System.Collections.ObjectModel.Collection<DetailsByProduct>();



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
        public static DetailsByPromotion FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<DetailsByPromotion>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    /// <summary>
    /// An object that contains details about a product.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DetailsByProduct
    {
        /// <summary>
        /// The product ASIN.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asin", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Asin { get; set; }

        /// <summary>
        /// The product name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ProductName { get; set; }

        /// <summary>
        /// The number of customer views of the product detail page.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productGlanceViews", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int ProductGlanceViews { get; set; }

        /// <summary>
        /// The number of units sold at the promotional price.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productUnitsSold", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int ProductUnitsSold { get; set; }

        /// <summary>
        /// Total funding provided by the vendor at the ASIN level. For vendors only.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productAmountSpent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double ProductAmountSpent { get; set; }

        /// <summary>
        /// ISO 4217 currency code of productAmountSpent.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productAmountSpentCurrencyCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProductAmountSpentCurrencyCode { get; set; }

        /// <summary>
        /// The total revenue generated at the ASIN level. For sellers, this is equivalent to "sales" in the Seller Central UI.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productRevenue", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double ProductRevenue { get; set; }

        /// <summary>
        /// ISO 4217 currency code of productRevenue.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productRevenueCurrencyCode", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ProductRevenueCurrencyCode { get; set; }



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
        public static DetailsByProduct FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<DetailsByProduct>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    /// <summary>
    /// The Promotion Performance report contains data to help vendors optimize their promotions and adjust their advertising strategies. Currently three promotion types are supported: Best Deal, Lightning Deal, and Price Discount. This report supports start dates up to two years before the current date.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PromotionReport
    {
        /// <summary>
        /// Summarizes the original report request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportSpecification", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ReportSpecification ReportSpecification { get; set; } = new ReportSpecification();

        /// <summary>
        /// The list of included promotions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotions", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<DetailsByPromotion> Promotions { get; set; } = new System.Collections.ObjectModel.Collection<DetailsByPromotion>();



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
        public static PromotionReport FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<PromotionReport>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum DetailsByPromotionType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"BEST_DEAL")]
        BEST_DEAL = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"DEAL_OF_THE_DAY")]
        DEAL_OF_THE_DAY = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"LIGHTNING_DEAL")]
        LIGHTNING_DEAL = 2,


        [System.Runtime.Serialization.EnumMember(Value = @"PRICE_DISCOUNT")]
        PRICE_DISCOUNT = 3,


        [System.Runtime.Serialization.EnumMember(Value = @"SALES_DISCOUNT")]
        SALES_DISCOUNT = 4,


        [System.Runtime.Serialization.EnumMember(Value = @"COUPON")]
        COUPON = 5,


        [System.Runtime.Serialization.EnumMember(Value = @"PROMO_CODE")]
        PROMO_CODE = 6,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum DetailsByPromotionStatus
    {

        [System.Runtime.Serialization.EnumMember(Value = @"APPROVED")]
        APPROVED = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"PENDING_APPROVAL")]
        PENDING_APPROVAL = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"NEEDS_YOUR_ATTENTION")]
        NEEDS_YOUR_ATTENTION = 2,


        [System.Runtime.Serialization.EnumMember(Value = @"CANCELED")]
        CANCELED = 3,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum DetailsByPromotionCreationChannel
    {

        [System.Runtime.Serialization.EnumMember(Value = @"SELF-SERVICE")]
        SELFSERVICE = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"FULL-SERVICE")]
        FULLSERVICE = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"AUTOMATED")]
        AUTOMATED = 2,


        [System.Runtime.Serialization.EnumMember(Value = @"MANUAL")]
        MANUAL = 3,


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
        /// Report options specifying the parameters promotionStartDateFrom and promotionStartDateTo.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportOptions", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ReportOptions ReportOptions { get; set; } = new ReportOptions();

        /// <summary>
        /// The marketplace IDs specified in the report request.
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
        /// The start of a date and time range in ISO 8601 format used for selecting promotions to report on. All promotions with a start date-time that falls within the range will be included.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotionStartDateFrom", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset PromotionStartDateFrom { get; set; }

        /// <summary>
        /// The end of a date and time range in ISO 8601 format used for selecting promotions to report on. All promotions with a start date-time that falls within the range will be included.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotionStartDateTo", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset PromotionStartDateTo { get; set; }



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
}