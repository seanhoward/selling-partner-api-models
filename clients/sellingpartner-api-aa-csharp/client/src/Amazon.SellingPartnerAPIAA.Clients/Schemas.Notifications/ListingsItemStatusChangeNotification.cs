//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications.ListingsItemStatusChange
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// To be delivered when the status (e.g. buyability, discoverability) of a listings item changes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ListingsItemStatusChangeNotification
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
        public ListingsItemStatusChangeNotificationNotificationType NotificationType { get; set; }

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
        public static ListingsItemStatusChangeNotification FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<ListingsItemStatusChangeNotification>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum ListingsItemStatusChangeNotificationNotificationType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"LISTINGS_ITEM_STATUS_CHANGED")]
        LISTINGS_ITEM_STATUS_CHANGED = 0,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Payload
    {
        /// <summary>
        /// Selling partner identifier, such as a merchant account, of the affected listings item.
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
        /// Timestamp of when the listings item was created, formatted as ISO8601 date-time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CreatedDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Array of status states currently associated with the affected listings item. The absence of a value indicates the status state is not currently applicable to the listings item. For example, if "BUYABLE" is not present, the listings item is not currently buyable.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Status> Status { get; set; } = new System.Collections.ObjectModel.Collection<Status>();



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
    public enum Status
    {

        [System.Runtime.Serialization.EnumMember(Value = @"BUYABLE")]
        BUYABLE = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"DISCOVERABLE")]
        DISCOVERABLE = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"DELETED")]
        DELETED = 2,


    }
}