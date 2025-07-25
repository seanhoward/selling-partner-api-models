/* 
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: 2020-07-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// The payload for the &#x60;getFeatures&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class GetFeaturesResult : IEquatable<GetFeaturesResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeaturesResult" /> class.
        /// </summary>
        [JsonConstructor]
        protected GetFeaturesResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeaturesResult" /> class.
        /// </summary>
        /// <param name="features">features (required).</param>
        public GetFeaturesResult(Features features = default)
        {
            // to ensure "features" is required (not null)
            if (features == null)
            {
                throw new InvalidDataException("features is a required property for GetFeaturesResult and cannot be null");
            }
            else
            {
                this.Features = features;
            }
        }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name = "features", EmitDefaultValue = false)]
        public Features Features { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFeaturesResult {\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
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
            return this.Equals(input as GetFeaturesResult);
        }

        /// <summary>
        /// Returns true if GetFeaturesResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFeaturesResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFeaturesResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Features == input.Features ||
                    (this.Features != null &&
                    this.Features.Equals(input.Features))
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
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
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
