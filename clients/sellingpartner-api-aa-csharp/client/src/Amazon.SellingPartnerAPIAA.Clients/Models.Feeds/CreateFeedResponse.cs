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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Feeds
{
    /// <summary>
    /// Response schema.
    /// </summary>
    [DataContract]
    public partial class CreateFeedResponse : IEquatable<CreateFeedResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedResponse" /> class.
        /// </summary>
        [JsonConstructor]
        protected CreateFeedResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedResponse" /> class.
        /// </summary>
        /// <param name="feedId">The identifier for the feed. This identifier is unique only in combination with a seller ID. (required).</param>
        public CreateFeedResponse(string feedId = default)
        {
            // to ensure "feedId" is required (not null)
            if (feedId == null)
            {
                throw new InvalidDataException("feedId is a required property for CreateFeedResponse and cannot be null");
            }
            else
            {
                this.FeedId = feedId;
            }
        }

        /// <summary>
        /// The identifier for the feed. This identifier is unique only in combination with a seller ID.
        /// </summary>
        /// <value>The identifier for the feed. This identifier is unique only in combination with a seller ID.</value>
        [DataMember(Name = "feedId", EmitDefaultValue = false)]
        public string FeedId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFeedResponse {\n");
            sb.Append("  FeedId: ").Append(FeedId).Append("\n");
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
            return this.Equals(input as CreateFeedResponse);
        }

        /// <summary>
        /// Returns true if CreateFeedResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFeedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFeedResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FeedId == input.FeedId ||
                    (this.FeedId != null &&
                    this.FeedId.Equals(input.FeedId))
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
                if (this.FeedId != null)
                    hashCode = hashCode * 59 + this.FeedId.GetHashCode();
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
