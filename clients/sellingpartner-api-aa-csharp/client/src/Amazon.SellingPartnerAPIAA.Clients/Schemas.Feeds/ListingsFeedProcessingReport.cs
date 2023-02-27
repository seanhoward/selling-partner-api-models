//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.8.0.0 (Newtonsoft.Json v11.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Feeds.Processing
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ListingsFeedProcessingReport
    {
        /// <summary>
        /// Header information about the feed submission.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Header Header { get; set; } = new Header();

        /// <summary>
        /// Issues containing message processing information for the Selling Partner.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("issues", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Issues> Issues { get; set; } = new System.Collections.ObjectModel.Collection<Issues>();

        /// <summary>
        /// Aggregate Count of Errors, Warnings, and the status of message submissions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Summary Summary { get; set; } = new Summary();



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v11.0.0.0)")]
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
        /// The identifier for the feed. This identifier is unique only in combination with a seller ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feedId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string FeedId { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Issue containing message processing information corresponding to an individual listings data submission.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Issues
    {
        /// <summary>
        /// Identifier for the message that is unique within this feed submission. Correlated to Identifiers provided in the submitted feed. Not provided if the error is not related to a message (e.g. feed formatting issue).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("messageId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1, int.MaxValue)]
        public int MessageId { get; set; }

        /// <summary>
        /// An Optional error code that maps to documentation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 1)]
        public string Code { get; set; }

        /// <summary>
        /// The severity of the issue.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("severity", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IssuesSeverity Severity { get; set; }

        /// <summary>
        /// Localized Error Message Associated with the issue encountered.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Message { get; set; }

        /// <summary>
        /// Name of the attribute associated with the issue, if applicable.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attributeName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AttributeName { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Summary
    {
        /// <summary>
        /// Number of errors encountered processing the feed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int Errors { get; set; }

        /// <summary>
        /// Number of warnings encountered processing the feed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warnings", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int Warnings { get; set; }

        /// <summary>
        /// Number of messages processed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("messagesProcessed", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int MessagesProcessed { get; set; }

        /// <summary>
        /// Number of messages that were accepted, the associated updates are being applied.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("messagesAccepted", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int MessagesAccepted { get; set; }

        /// <summary>
        /// Number of messages that were invalid, the associated updates will not be applied.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("messagesInvalid", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int MessagesInvalid { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum IssuesSeverity
    {

        [System.Runtime.Serialization.EnumMember(Value = @"ERROR")]
        ERROR = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"WARNING")]
        WARNING = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"INFO")]
        INFO = 2,


    }
}