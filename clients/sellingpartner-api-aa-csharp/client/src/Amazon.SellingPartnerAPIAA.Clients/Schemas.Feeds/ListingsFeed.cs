//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Feeds.ListingsSchema
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ListingsFeed
    {
        /// <summary>
        /// Header information about the feed submission.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Header Header { get; set; } = new Header();

        /// <summary>
        /// Messages containing listings data submissions for the Selling Partner.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("messages", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(10000)]
        public System.Collections.Generic.ICollection<Message> Messages { get; set; } = new System.Collections.ObjectModel.Collection<Message>();



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
        public static ListingsFeed FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<ListingsFeed>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Header
    {
        /// <summary>
        /// Identifier for the Selling Partner, such as the Merchant Account or Vendor Code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sellerId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string SellerId { get; set; }

        /// <summary>
        /// Version of the JSON Selling Partner Listings Feeds specification used for the feed submission.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Version { get; set; }

        /// <summary>
        /// Locale for issue localization. When not provided, the default language code of the first marketplace is used. Examples: "en_US", "fr_CA", "fr_FR". Localized messages default to "en_US" when a localization is not available in the specified locale.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("issueLocale", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IssueLocale { get; set; }



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
        public static Header FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Header>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    /// <summary>
    /// Message containing an individual listings data submission.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Message
    {
        /// <summary>
        /// Identifier for the message that is unique within this feed submission. Response messages are correlated to this identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("messageId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(1, 2147483647)]
        public int MessageId { get; set; }

        /// <summary>
        /// Selling Partner SKU (stock keeping unit) identifier for the listing. SKU uniquely identifies a listing for a Selling Partner.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Sku { get; set; }

        /// <summary>
        /// Type of operation to perform for the listings data submission in this message. "UPDATE" indicates the full set of item attributes are provided and any existing attributes data will be replaced with the provided attributes. "PARTIAL_UPDATE" indicates only the provided item attributes will be updated with the provided attribute data. "PATCH" indicates the provided JSON Patch operations will be used to update the applicable attributes. "DELETE" indicates the listings item will be deleted. "PARTIAL_UPDATE" is equivalent to using "PATCH" with the "replace" op.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operationType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessagesOperationType OperationType { get; set; }

        /// <summary>
        /// Amazon product type of the listings data submission in this message.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 1)]
        public string ProductType { get; set; }

        /// <summary>
        /// Name of the requirements type for the listings data submission in this message. "LISTING" indicates requirements inclusive of product facts and sales terms. "LISTING_PRODUCT_ONLY" indicates requirements inclusive of product facts only. "LISTING_OFFER_ONLY" indicates requirements inclusive of sales terms only.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requirements", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessagesRequirements Requirements { get; set; } = Amazon.SellingPartnerAPIAA.Clients.Schemas.Feeds.ListingsSchema.MessagesRequirements.LISTING;

        /// <summary>
        /// Attributes data for the listings data submission.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attributes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Attributes { get; set; }

        /// <summary>
        /// Attributes data in the form of JSON Patch operations to update or delete.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("patches", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.Generic.ICollection<Patches> Patches { get; set; }



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
        public static Message FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Message>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum MessagesOperationType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"UPDATE")]
        UPDATE = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"PARTIAL_UPDATE")]
        PARTIAL_UPDATE = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"PATCH")]
        PATCH = 2,


        [System.Runtime.Serialization.EnumMember(Value = @"DELETE")]
        DELETE = 3,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum MessagesRequirements
    {

        [System.Runtime.Serialization.EnumMember(Value = @"LISTING")]
        LISTING = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"LISTING_PRODUCT_ONLY")]
        LISTING_PRODUCT_ONLY = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"LISTING_OFFER_ONLY")]
        LISTING_OFFER_ONLY = 2,


    }

    /// <summary>
    /// Individual JSON Patch operation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Patches
    {
        /// <summary>
        /// Type of JSON Patch operation. Supported JSON Patch operations include add, replace, and delete. See https://tools.ietf.org/html/rfc6902.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("op", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PatchesOp Op { get; set; }

        /// <summary>
        /// JSON Pointer path of the attribute to patch. See https://tools.ietf.org/html/rfc6902.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Path { get; set; }

        /// <summary>
        /// JSON value to add, replace, or delete.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<object> Value { get; set; }



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
        public static Patches FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Patches>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.1.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum PatchesOp
    {

        [System.Runtime.Serialization.EnumMember(Value = @"add")]
        Add = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"replace")]
        Replace = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"delete")]
        Delete = 2,


    }
}