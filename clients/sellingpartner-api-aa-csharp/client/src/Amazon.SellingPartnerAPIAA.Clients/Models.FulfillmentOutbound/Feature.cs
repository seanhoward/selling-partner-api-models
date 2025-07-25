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
    /// A Multi-Channel Fulfillment feature.
    /// </summary>
    [DataContract]
    public partial class Feature : IEquatable<Feature>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Feature" /> class.
        /// </summary>
        [JsonConstructor]
        protected Feature() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Feature" /> class.
        /// </summary>
        /// <param name="featureName">The feature name. (required).</param>
        /// <param name="featureDescription">The feature description. (required).</param>
        /// <param name="sellerEligible">When true, indicates that the seller is eligible to use the feature..</param>
        public Feature(string featureName = default, string featureDescription = default, bool? sellerEligible = default)
        {
            // to ensure "featureName" is required (not null)
            if (featureName == null)
            {
                throw new InvalidDataException("featureName is a required property for Feature and cannot be null");
            }
            else
            {
                this.FeatureName = featureName;
            }
            // to ensure "featureDescription" is required (not null)
            if (featureDescription == null)
            {
                throw new InvalidDataException("featureDescription is a required property for Feature and cannot be null");
            }
            else
            {
                this.FeatureDescription = featureDescription;
            }
            this.SellerEligible = sellerEligible;
        }

        /// <summary>
        /// The feature name.
        /// </summary>
        /// <value>The feature name.</value>
        [DataMember(Name = "featureName", EmitDefaultValue = false)]
        public string FeatureName { get; set; }

        /// <summary>
        /// The feature description.
        /// </summary>
        /// <value>The feature description.</value>
        [DataMember(Name = "featureDescription", EmitDefaultValue = false)]
        public string FeatureDescription { get; set; }

        /// <summary>
        /// When true, indicates that the seller is eligible to use the feature.
        /// </summary>
        /// <value>When true, indicates that the seller is eligible to use the feature.</value>
        [DataMember(Name = "sellerEligible", EmitDefaultValue = false)]
        public bool? SellerEligible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Feature {\n");
            sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
            sb.Append("  FeatureDescription: ").Append(FeatureDescription).Append("\n");
            sb.Append("  SellerEligible: ").Append(SellerEligible).Append("\n");
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
            return this.Equals(input as Feature);
        }

        /// <summary>
        /// Returns true if Feature instances are equal
        /// </summary>
        /// <param name="input">Instance of Feature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Feature input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FeatureName == input.FeatureName ||
                    (this.FeatureName != null &&
                    this.FeatureName.Equals(input.FeatureName))
                ) &&
                (
                    this.FeatureDescription == input.FeatureDescription ||
                    (this.FeatureDescription != null &&
                    this.FeatureDescription.Equals(input.FeatureDescription))
                ) &&
                (
                    this.SellerEligible == input.SellerEligible ||
                    (this.SellerEligible != null &&
                    this.SellerEligible.Equals(input.SellerEligible))
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
                if (this.FeatureName != null)
                    hashCode = hashCode * 59 + this.FeatureName.GetHashCode();
                if (this.FeatureDescription != null)
                    hashCode = hashCode * 59 + this.FeatureDescription.GetHashCode();
                if (this.SellerEligible != null)
                    hashCode = hashCode * 59 + this.SellerEligible.GetHashCode();
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
