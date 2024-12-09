//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications.ItemProductTypeChange
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// The root schema comprises the entire JSON document.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ItemProductTypeChangeNotification
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
        [Newtonsoft.Json.JsonProperty("Payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload Payload { get; set; } = new Payload();

        /// <summary>
        /// An explanation about the purpose of this instance.
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
        public static ItemProductTypeChangeNotification FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<ItemProductTypeChangeNotification>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Payload
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
        [Newtonsoft.Json.JsonProperty("Asin", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Asin { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PreviousProductType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PreviousProductType { get; set; } = "";

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CurrentProductType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string CurrentProductType { get; set; } = "";



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
}