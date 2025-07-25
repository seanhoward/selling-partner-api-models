/* 
 * The Selling Partner API for Amazon Warehousing and Distribution
 *
 * The Selling Partner API for Amazon Warehousing and Distribution (AWD) provides programmatic access to information about AWD shipments and inventory. 
 *
 * OpenAPI spec version: 2024-05-09
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Awd
{
    /// <summary>
    /// Information pertaining to the preparation of inbound products.
    /// </summary>
    [DataContract]
    public partial class PrepInstruction : IEquatable<PrepInstruction>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets PrepOwner
        /// </summary>
        [DataMember(Name = "prepOwner", EmitDefaultValue = false)]
        public PrepOwner? PrepOwner { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepInstruction" /> class.
        /// </summary>
        /// <param name="prepOwner">prepOwner.</param>
        /// <param name="prepType">The type of preparation to be done. For more information about preparing items, refer to [Prep guidance](https://sellercentral.amazon.com/help/hub/reference/external/GF4G7547KSLDX2KC) on Seller Central..</param>
        public PrepInstruction(PrepOwner? prepOwner = default, string prepType = default)
        {
            this.PrepOwner = prepOwner;
            this.PrepType = prepType;
        }


        /// <summary>
        /// The type of preparation to be done. For more information about preparing items, refer to [Prep guidance](https://sellercentral.amazon.com/help/hub/reference/external/GF4G7547KSLDX2KC) on Seller Central.
        /// </summary>
        /// <value>The type of preparation to be done. For more information about preparing items, refer to [Prep guidance](https://sellercentral.amazon.com/help/hub/reference/external/GF4G7547KSLDX2KC) on Seller Central.</value>
        [DataMember(Name = "prepType", EmitDefaultValue = false)]
        public string PrepType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrepInstruction {\n");
            sb.Append("  PrepOwner: ").Append(PrepOwner).Append("\n");
            sb.Append("  PrepType: ").Append(PrepType).Append("\n");
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
            return this.Equals(input as PrepInstruction);
        }

        /// <summary>
        /// Returns true if PrepInstruction instances are equal
        /// </summary>
        /// <param name="input">Instance of PrepInstruction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrepInstruction input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PrepOwner == input.PrepOwner ||
                    (this.PrepOwner != null &&
                    this.PrepOwner.Equals(input.PrepOwner))
                ) &&
                (
                    this.PrepType == input.PrepType ||
                    (this.PrepType != null &&
                    this.PrepType.Equals(input.PrepType))
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
                if (this.PrepOwner != null)
                    hashCode = hashCode * 59 + this.PrepOwner.GetHashCode();
                if (this.PrepType != null)
                    hashCode = hashCode * 59 + this.PrepType.GetHashCode();
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
