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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// &#x60;FeatureSettings&#x60; allows users to apply fulfillment features to an order. To block an order from being shipped using Amazon Logistics (AMZL) and an AMZL tracking number, use &#x60;featureName&#x60; as &#x60;BLOCK_AMZL&#x60; and &#x60;featureFulfillmentPolicy&#x60; as &#x60;Required&#x60;. Blocking AMZL will incur an additional fee surcharge on your MCF orders and increase the risk of some of your orders being unfulfilled or delivered late if there are no alternative carriers available. Using &#x60;BLOCK_AMZL&#x60; in an order request will take precedence over your Seller Central account setting. To ship in non-Amazon branded packaging (blank boxes), use featureName &#x60;BLANK_BOX&#x60;.
    /// </summary>
    [DataContract]
    public partial class FeatureSettings : IEquatable<FeatureSettings>, IValidatableObject
    {
        /// <summary>
        /// Specifies the policy to use when fulfilling an order.
        /// </summary>
        /// <value>Specifies the policy to use when fulfilling an order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeatureFulfillmentPolicyEnum
        {

            /// <summary>
            /// Enum Required for value: Required
            /// </summary>
            [EnumMember(Value = "Required")]
            Required = 1,

            /// <summary>
            /// Enum NotRequired for value: NotRequired
            /// </summary>
            [EnumMember(Value = "NotRequired")]
            NotRequired = 2
        }

        /// <summary>
        /// Specifies the policy to use when fulfilling an order.
        /// </summary>
        /// <value>Specifies the policy to use when fulfilling an order.</value>
        [DataMember(Name = "featureFulfillmentPolicy", EmitDefaultValue = false)]
        public FeatureFulfillmentPolicyEnum? FeatureFulfillmentPolicy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureSettings" /> class.
        /// </summary>
        /// <param name="featureName">The name of the feature..</param>
        /// <param name="featureFulfillmentPolicy">Specifies the policy to use when fulfilling an order..</param>
        public FeatureSettings(string featureName = default, FeatureFulfillmentPolicyEnum? featureFulfillmentPolicy = default)
        {
            this.FeatureName = featureName;
            this.FeatureFulfillmentPolicy = featureFulfillmentPolicy;
        }

        /// <summary>
        /// The name of the feature.
        /// </summary>
        /// <value>The name of the feature.</value>
        [DataMember(Name = "featureName", EmitDefaultValue = false)]
        public string FeatureName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeatureSettings {\n");
            sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
            sb.Append("  FeatureFulfillmentPolicy: ").Append(FeatureFulfillmentPolicy).Append("\n");
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
            return this.Equals(input as FeatureSettings);
        }

        /// <summary>
        /// Returns true if FeatureSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of FeatureSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureSettings input)
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
                    this.FeatureFulfillmentPolicy == input.FeatureFulfillmentPolicy ||
                    (this.FeatureFulfillmentPolicy != null &&
                    this.FeatureFulfillmentPolicy.Equals(input.FeatureFulfillmentPolicy))
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
                if (this.FeatureFulfillmentPolicy != null)
                    hashCode = hashCode * 59 + this.FeatureFulfillmentPolicy.GetHashCode();
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
