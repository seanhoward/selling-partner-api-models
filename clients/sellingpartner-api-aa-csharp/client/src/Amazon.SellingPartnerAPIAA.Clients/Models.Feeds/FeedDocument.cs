/* 
 * Selling Partner API for Feeds
 *
 * The Selling Partner API for Feeds lets you upload data to Amazon on behalf of a selling partner.
 *
 * OpenAPI spec version: 2021-06-30
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Feeds
{
    /// <summary>
    /// Information required for the feed document.
    /// </summary>
    [DataContract]
    public partial class FeedDocument : IEquatable<FeedDocument>, IValidatableObject
    {
        /// <summary>
        /// If the feed document contents have been compressed, the compression algorithm used is returned in this property and you must decompress the feed when you download. Otherwise, you can download the feed directly. Refer to [Step 7. Download the feed processing report](doc:feeds-api-v2021-06-30-use-case-guide#step-7-download-the-feed-processing-report) in the use case guide, where sample code is provided.
        /// </summary>
        /// <value>If the feed document contents have been compressed, the compression algorithm used is returned in this property and you must decompress the feed when you download. Otherwise, you can download the feed directly. Refer to [Step 7. Download the feed processing report](doc:feeds-api-v2021-06-30-use-case-guide#step-7-download-the-feed-processing-report) in the use case guide, where sample code is provided.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionAlgorithmEnum
        {

            /// <summary>
            /// Enum GZIP for value: GZIP
            /// </summary>
            [EnumMember(Value = "GZIP")]
            GZIP = 1
        }

        /// <summary>
        /// If the feed document contents have been compressed, the compression algorithm used is returned in this property and you must decompress the feed when you download. Otherwise, you can download the feed directly. Refer to [Step 7. Download the feed processing report](doc:feeds-api-v2021-06-30-use-case-guide#step-7-download-the-feed-processing-report) in the use case guide, where sample code is provided.
        /// </summary>
        /// <value>If the feed document contents have been compressed, the compression algorithm used is returned in this property and you must decompress the feed when you download. Otherwise, you can download the feed directly. Refer to [Step 7. Download the feed processing report](doc:feeds-api-v2021-06-30-use-case-guide#step-7-download-the-feed-processing-report) in the use case guide, where sample code is provided.</value>
        [DataMember(Name = "compressionAlgorithm", EmitDefaultValue = false)]
        public CompressionAlgorithmEnum? CompressionAlgorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedDocument" /> class.
        /// </summary>
        [JsonConstructor]
        protected FeedDocument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedDocument" /> class.
        /// </summary>
        /// <param name="feedDocumentId">The identifier for the feed document. This identifier is unique only in combination with a seller ID. (required).</param>
        /// <param name="url">A presigned URL for the feed document. If &#x60;compressionAlgorithm&#x60; is not returned, you can download the feed directly from this URL. This URL expires after 5 minutes. (required).</param>
        /// <param name="compressionAlgorithm">If the feed document contents have been compressed, the compression algorithm used is returned in this property and you must decompress the feed when you download. Otherwise, you can download the feed directly. Refer to [Step 7. Download the feed processing report](doc:feeds-api-v2021-06-30-use-case-guide#step-7-download-the-feed-processing-report) in the use case guide, where sample code is provided..</param>
        public FeedDocument(string feedDocumentId = default, string url = default, CompressionAlgorithmEnum? compressionAlgorithm = default)
        {
            // to ensure "feedDocumentId" is required (not null)
            if (feedDocumentId == null)
            {
                throw new InvalidDataException("feedDocumentId is a required property for FeedDocument and cannot be null");
            }
            else
            {
                this.FeedDocumentId = feedDocumentId;
            }
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for FeedDocument and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            this.CompressionAlgorithm = compressionAlgorithm;
        }

        /// <summary>
        /// The identifier for the feed document. This identifier is unique only in combination with a seller ID.
        /// </summary>
        /// <value>The identifier for the feed document. This identifier is unique only in combination with a seller ID.</value>
        [DataMember(Name = "feedDocumentId", EmitDefaultValue = false)]
        public string FeedDocumentId { get; set; }

        /// <summary>
        /// A presigned URL for the feed document. If &#x60;compressionAlgorithm&#x60; is not returned, you can download the feed directly from this URL. This URL expires after 5 minutes.
        /// </summary>
        /// <value>A presigned URL for the feed document. If &#x60;compressionAlgorithm&#x60; is not returned, you can download the feed directly from this URL. This URL expires after 5 minutes.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeedDocument {\n");
            sb.Append("  FeedDocumentId: ").Append(FeedDocumentId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  CompressionAlgorithm: ").Append(CompressionAlgorithm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FeedDocument);
        }

        /// <summary>
        /// Returns true if FeedDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of FeedDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeedDocument input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FeedDocumentId == input.FeedDocumentId ||
                    (this.FeedDocumentId != null &&
                    this.FeedDocumentId.Equals(input.FeedDocumentId))
                ) &&
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) &&
                (
                    this.CompressionAlgorithm == input.CompressionAlgorithm ||
                    (this.CompressionAlgorithm != null &&
                    this.CompressionAlgorithm.Equals(input.CompressionAlgorithm))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FeedDocumentId != null)
                    hashCode = hashCode * 59 + this.FeedDocumentId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.CompressionAlgorithm != null)
                    hashCode = hashCode * 59 + this.CompressionAlgorithm.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
