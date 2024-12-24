//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications.DetailPageTrafficEvent
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Payload
    {
        [Newtonsoft.Json.JsonProperty("detailPageTrafficEvents", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public DetailPageTrafficEvents DetailPageTrafficEvents { get; set; } = new DetailPageTrafficEvents();



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
    public partial class DetailPageTrafficEvents : System.Collections.ObjectModel.Collection<DetailPageTrafficEvent>
    {

        public string ToJson()
        {

            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public static DetailPageTrafficEvents FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<DetailPageTrafficEvents>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DetailPageTrafficEvent
    {
        /// <summary>
        /// The merchant customer ID or vendor group ID of the partner account this notification is sent to.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accountId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// The marketplace identifier of the traffic data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marketplaceId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The start of the date-time range of the traffic data in ISO 8601 format in UTC time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// The end of the date-time range of the traffic data in ISO 8601 format in UTC time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// The Amazon Standard Identification Number of the product.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asin", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Asin { get; set; }

        /// <summary>
        /// The number of customer views of the product detail page for this ASIN.
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
        public static DetailPageTrafficEvent FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<DetailPageTrafficEvent>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class NotificationMetadata
    {
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ApplicationId { get; set; }

        [Newtonsoft.Json.JsonProperty("subscriptionId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string SubscriptionId { get; set; }

        [Newtonsoft.Json.JsonProperty("publishTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PublishTime { get; set; }

        [Newtonsoft.Json.JsonProperty("notificationId", Required = Newtonsoft.Json.Required.Always)]
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

    /// <summary>
    /// The root schema comprises the entire JSON document.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DetailPageTrafficEventNotification
    {
        [Newtonsoft.Json.JsonProperty("notificationVersion", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string NotificationVersion { get; set; }

        [Newtonsoft.Json.JsonProperty("notificationType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string NotificationType { get; set; }

        [Newtonsoft.Json.JsonProperty("payloadVersion", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PayloadVersion { get; set; }

        [Newtonsoft.Json.JsonProperty("eventTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string EventTime { get; set; }

        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload Payload { get; set; } = new Payload();

        [Newtonsoft.Json.JsonProperty("notificationMetadata", Required = Newtonsoft.Json.Required.Always)]
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
        public static DetailPageTrafficEventNotification FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<DetailPageTrafficEventNotification>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }
}