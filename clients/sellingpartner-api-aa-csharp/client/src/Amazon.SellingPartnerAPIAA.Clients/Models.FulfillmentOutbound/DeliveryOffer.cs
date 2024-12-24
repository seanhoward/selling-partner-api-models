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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Amazon.SellingPartnerAPIAA.Clients.Client.SwaggerDateConverter;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// An available offer for delivery of a product.
    /// </summary>
    [DataContract]
    public partial class DeliveryOffer :  IEquatable<DeliveryOffer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryOffer" /> class.
        /// </summary>
        /// <param name="expiresAt">The timestamp at which a delivery offer expires..</param>
        /// <param name="dateRange">The range between which delivery is expected..</param>
        /// <param name="policy">The policy for a delivery offer, including localized messaging..</param>
        public DeliveryOffer(DateTime? expiresAt = default(DateTime?), DateRange dateRange = default(DateRange), DeliveryPolicy policy = default(DeliveryPolicy))
        {
            this.ExpiresAt = expiresAt;
            this.DateRange = dateRange;
            this.Policy = policy;
        }
        
        /// <summary>
        /// The timestamp at which a delivery offer expires.
        /// </summary>
        /// <value>The timestamp at which a delivery offer expires.</value>
        [DataMember(Name="expiresAt", EmitDefaultValue=false)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The range between which delivery is expected.
        /// </summary>
        /// <value>The range between which delivery is expected.</value>
        [DataMember(Name="dateRange", EmitDefaultValue=false)]
        public DateRange DateRange { get; set; }

        /// <summary>
        /// The policy for a delivery offer, including localized messaging.
        /// </summary>
        /// <value>The policy for a delivery offer, including localized messaging.</value>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public DeliveryPolicy Policy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryOffer {\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  DateRange: ").Append(DateRange).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
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
            return this.Equals(input as DeliveryOffer);
        }

        /// <summary>
        /// Returns true if DeliveryOffer instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryOffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryOffer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.DateRange == input.DateRange ||
                    (this.DateRange != null &&
                    this.DateRange.Equals(input.DateRange))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
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
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.DateRange != null)
                    hashCode = hashCode * 59 + this.DateRange.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}