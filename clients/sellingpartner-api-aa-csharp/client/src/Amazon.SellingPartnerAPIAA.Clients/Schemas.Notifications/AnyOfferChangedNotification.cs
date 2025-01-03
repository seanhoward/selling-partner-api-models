//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications.AnyOfferChanged
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// The root schema comprises the entire JSON document.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AnyOfferChangedNotification
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NotificationVersion", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string NotificationVersion { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NotificationType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string NotificationType { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PayloadVersion", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PayloadVersion { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string EventTime { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NotificationMetadata", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public NotificationMetadata NotificationMetadata { get; set; } = new NotificationMetadata();

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload Payload { get; set; } = new Payload();



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
        public static AnyOfferChangedNotification FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<AnyOfferChangedNotification>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class NotificationMetadata
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ApplicationId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ApplicationId { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SubscriptionId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string SubscriptionId { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PublishTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PublishTime { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NotificationId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string NotificationId { get; set; } = "";



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
        public static NotificationMetadata FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<NotificationMetadata>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Payload
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AnyOfferChangedNotification", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public AnyOfferChangedNotification2 AnyOfferChangedNotification { get; set; } = new AnyOfferChangedNotification2();



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
        public static Payload FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Payload>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AnyOfferChangedNotification2
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SellerId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string SellerId { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OfferChangeTrigger", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public OfferChangeTrigger OfferChangeTrigger { get; set; } = new OfferChangeTrigger();

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Summary", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Summary Summary { get; set; } = new Summary();

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Offers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Offers> Offers { get; set; } = new System.Collections.ObjectModel.Collection<Offers>();



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
        public static AnyOfferChangedNotification2 FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<AnyOfferChangedNotification2>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class OfferChangeTrigger
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MarketplaceId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string MarketplaceId { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ASIN", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ASIN { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ItemCondition", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ItemCondition { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TimeOfOfferChange", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string TimeOfOfferChange { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OfferChangeType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string OfferChangeType { get; set; } = "";



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
        public static OfferChangeTrigger FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<OfferChangeTrigger>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Summary
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NumberOfOffers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<NumberOfOffers> NumberOfOffers { get; set; } = new System.Collections.ObjectModel.Collection<NumberOfOffers>();

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("LowestPrices", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<LowestPrices> LowestPrices { get; set; } = new System.Collections.ObjectModel.Collection<LowestPrices>();

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BuyBoxPrices", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<BuyBoxPrices> BuyBoxPrices { get; set; } = new System.Collections.ObjectModel.Collection<BuyBoxPrices>();

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ListPrice", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ListPrice ListPrice { get; set; } = new ListPrice();

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MinimumAdvertisedPrice", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public MinimumAdvertisedPrice MinimumAdvertisedPrice { get; set; } = new MinimumAdvertisedPrice();

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuggestedLowerPricePlusShipping", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public SuggestedLowerPricePlusShipping SuggestedLowerPricePlusShipping { get; set; } = new SuggestedLowerPricePlusShipping();

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TotalBuyBoxEligibleOffers", Required = Newtonsoft.Json.Required.Always)]
        public int TotalBuyBoxEligibleOffers { get; set; } = 0;

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SalesRankings", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<SalesRankings> SalesRankings { get; set; } = new System.Collections.ObjectModel.Collection<SalesRankings>();

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NumberOfBuyBoxEligibleOffers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<NumberOfBuyBoxEligibleOffers> NumberOfBuyBoxEligibleOffers { get; set; } = new System.Collections.ObjectModel.Collection<NumberOfBuyBoxEligibleOffers>();

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CompetitivePriceThreshold", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public CompetitivePriceThreshold CompetitivePriceThreshold { get; set; } = new CompetitivePriceThreshold();



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
        public static Summary FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Summary>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Offers
    {


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
        public static Offers FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Offers>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class NumberOfOffers
    {


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
        public static NumberOfOffers FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<NumberOfOffers>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class LowestPrices
    {


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
        public static LowestPrices FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<LowestPrices>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class BuyBoxPrices
    {


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
        public static BuyBoxPrices FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<BuyBoxPrices>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ListPrice
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; } = 0D;

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CurrencyCode", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string CurrencyCode { get; set; } = "";



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
        public static ListPrice FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<ListPrice>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class MinimumAdvertisedPrice
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; } = 0D;

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CurrencyCode", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string CurrencyCode { get; set; } = "";



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
        public static MinimumAdvertisedPrice FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<MinimumAdvertisedPrice>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SuggestedLowerPricePlusShipping
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; } = 0D;

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CurrencyCode", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string CurrencyCode { get; set; } = "";



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
        public static SuggestedLowerPricePlusShipping FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<SuggestedLowerPricePlusShipping>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SalesRankings
    {


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
        public static SalesRankings FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<SalesRankings>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class NumberOfBuyBoxEligibleOffers
    {


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
        public static NumberOfBuyBoxEligibleOffers FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<NumberOfBuyBoxEligibleOffers>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CompetitivePriceThreshold
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; } = 0D;

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CurrencyCode", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string CurrencyCode { get; set; } = "";



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
        public static CompetitivePriceThreshold FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<CompetitivePriceThreshold>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }
}