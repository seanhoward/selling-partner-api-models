//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications.ListingsItemMfnQuantityChange
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// To be delivered when the inventory quantity of a MFN Seller listing changes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ListingsItemMfnQuantityChange
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
        public ListingsItemMfnQuantityChangeNotificationType NotificationType { get; set; }

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
        public static ListingsItemMfnQuantityChange FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<ListingsItemMfnQuantityChange>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum ListingsItemMfnQuantityChangeNotificationType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"LISTINGS_ITEM_MFN_QUANTITY_CHANGE")]
        LISTINGS_ITEM_MFN_QUANTITY_CHANGE = 0,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Payload
    {
        /// <summary>
        /// Selling partner identifier, such as a merchant ID, of the affected listings item.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SellerId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string SellerId { get; set; }

        /// <summary>
        /// The Fulfillment channel code representing the MFN (seller-fulfilled) fulfillment program, network, or channel where the quantity is applicable.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FulfillmentChannelCode", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string FulfillmentChannelCode { get; set; }

        /// <summary>
        /// A selling partner provided identifier for an Amazon listing.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Sku", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Sku { get; set; }

        /// <summary>
        /// The available quantity for MFN (seller-fulfillment) with the fulfillment program, network, or channel.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Quantity", Required = Newtonsoft.Json.Required.Always)]
        public int Quantity { get; set; }



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
        /// An identifier of the application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ApplicationId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// An identifier of the subscription.
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
        /// An identifier of the notification.
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
}