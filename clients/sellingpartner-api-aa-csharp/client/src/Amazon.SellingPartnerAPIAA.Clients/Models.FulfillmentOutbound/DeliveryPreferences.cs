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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// The delivery preferences applied to the destination address. These preferences are applied when possible and are best effort. This feature is currently supported only in the JP marketplace and not applicable for other marketplaces. For eligible orders, the default delivery preference will be to deliver the package unattended at the front door, unless you specify otherwise.
    /// </summary>
    [DataContract]
    public partial class DeliveryPreferences : IEquatable<DeliveryPreferences>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryPreferences" /> class.
        /// </summary>
        /// <param name="deliveryInstructions">Additional delivery instructions. For example, this could be instructions on how to enter a building, nearby landmark or navigation instructions, &#39;Beware of dogs&#39;, etc..</param>
        /// <param name="dropOffLocation">The preferred location to leave packages at the destination address..</param>
        public DeliveryPreferences(string deliveryInstructions = default, DropOffLocation dropOffLocation = default)
        {
            this.DeliveryInstructions = deliveryInstructions;
            this.DropOffLocation = dropOffLocation;
        }

        /// <summary>
        /// Additional delivery instructions. For example, this could be instructions on how to enter a building, nearby landmark or navigation instructions, &#39;Beware of dogs&#39;, etc.
        /// </summary>
        /// <value>Additional delivery instructions. For example, this could be instructions on how to enter a building, nearby landmark or navigation instructions, &#39;Beware of dogs&#39;, etc.</value>
        [DataMember(Name = "deliveryInstructions", EmitDefaultValue = false)]
        public string DeliveryInstructions { get; set; }

        /// <summary>
        /// The preferred location to leave packages at the destination address.
        /// </summary>
        /// <value>The preferred location to leave packages at the destination address.</value>
        [DataMember(Name = "dropOffLocation", EmitDefaultValue = false)]
        public DropOffLocation DropOffLocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryPreferences {\n");
            sb.Append("  DeliveryInstructions: ").Append(DeliveryInstructions).Append("\n");
            sb.Append("  DropOffLocation: ").Append(DropOffLocation).Append("\n");
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
            return this.Equals(input as DeliveryPreferences);
        }

        /// <summary>
        /// Returns true if DeliveryPreferences instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryPreferences input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DeliveryInstructions == input.DeliveryInstructions ||
                    (this.DeliveryInstructions != null &&
                    this.DeliveryInstructions.Equals(input.DeliveryInstructions))
                ) &&
                (
                    this.DropOffLocation == input.DropOffLocation ||
                    (this.DropOffLocation != null &&
                    this.DropOffLocation.Equals(input.DropOffLocation))
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
                if (this.DeliveryInstructions != null)
                    hashCode = hashCode * 59 + this.DeliveryInstructions.GetHashCode();
                if (this.DropOffLocation != null)
                    hashCode = hashCode * 59 + this.DropOffLocation.GetHashCode();
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
            // DeliveryInstructions (string) maxLength
            if (this.DeliveryInstructions != null && this.DeliveryInstructions.Length > 250)
            {
                yield return new ValidationResult("Invalid value for DeliveryInstructions, length must be less than 250.", new[] { "DeliveryInstructions" });
            }

            yield break;
        }
    }

}
