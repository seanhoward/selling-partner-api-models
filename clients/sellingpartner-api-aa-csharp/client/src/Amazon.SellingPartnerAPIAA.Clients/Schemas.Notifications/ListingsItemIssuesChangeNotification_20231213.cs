//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications.ListingsItemIssuesChange_20231213
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// To be delivered when issues are created, changed, or resolved for a listings item.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ListingsItemIssuesChangeNotification_20231213
    {
        /// <summary>
        /// The version of the notification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NotificationVersion", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string NotificationVersion { get; set; }

        /// <summary>
        /// The type of the notification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NotificationType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ListingsItemIssuesChangeNotification_20231213NotificationType NotificationType { get; set; }

        /// <summary>
        /// The version of the payload.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PayloadVersion", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PayloadVersion { get; set; }

        /// <summary>
        /// Timestamp of the event, formatted as ISO8601 date-time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset EventTime { get; set; }

        /// <summary>
        /// The details of this notification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload Payload { get; set; } = new Payload();

        /// <summary>
        /// The metadata of the notification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NotificationMetadata", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public NotificationMetadata NotificationMetadata { get; set; } = new NotificationMetadata();



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
        public static ListingsItemIssuesChangeNotification_20231213 FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<ListingsItemIssuesChangeNotification_20231213>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum ListingsItemIssuesChangeNotification_20231213NotificationType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"LISTINGS_ITEM_ISSUES_CHANGE")]
        LISTINGS_ITEM_ISSUES_CHANGE = 0,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Payload
    {
        /// <summary>
        /// Selling partner identifier, such as a merchant account or vendor code, of the affected listings item.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SellerId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string SellerId { get; set; }

        /// <summary>
        /// Amazon marketplace identifier of the affected listings item.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MarketplaceId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) identifier of the catalog item associated with the listings item.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Asin", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Asin { get; set; }

        /// <summary>
        /// Identifier of the affected listings item.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Sku", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Sku { get; set; }

        /// <summary>
        /// Array of severities for the issues currently associated with the affected listings item. When no issues are affecting the listings item, "NONE" is provided instead.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Severities", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Severities> Severities { get; set; } = new System.Collections.ObjectModel.Collection<Severities>();

        /// <summary>
        /// Array of enforcement actions taken by Amazon for the issues associated with the affected listings item. Possible values: 'LISTING_SUPPRESSED' - This enforcement takes down the current listing item's buyability. 'ATTRIBUTE_SUPPRESSED' - An attribute's value on the listing item is invalid, which causes it to be rejected by Amazon. 'CATALOG_ITEM_REMOVED' - This catalog item is inactive on Amazon, and all offers against it in the applicable marketplace are non-buyable. 'SEARCH_SUPPRESSED' - This value indicates that the catalog item is hidden from search results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EnforcementActions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> EnforcementActions { get; set; }



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
    public partial class NotificationMetadata
    {
        /// <summary>
        /// Identifies the application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ApplicationId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Identifies the subscription.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SubscriptionId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Timestamp of when the notification was published, formatted as ISO8601 date-time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PublishTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset PublishTime { get; set; }

        /// <summary>
        /// Identifies the notification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NotificationId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string NotificationId { get; set; }



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
    public enum Severities
    {

        [System.Runtime.Serialization.EnumMember(Value = @"NONE")]
        NONE = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"ERROR")]
        ERROR = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"WARNING")]
        WARNING = 2,


    }
}