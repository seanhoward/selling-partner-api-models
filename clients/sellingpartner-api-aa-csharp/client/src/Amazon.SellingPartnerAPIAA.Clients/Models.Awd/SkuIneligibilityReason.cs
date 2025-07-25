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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Awd
{
    /// <summary>
    /// Represents the ineligibility reason for one SKU.
    /// </summary>
    [DataContract]
    public partial class SkuIneligibilityReason : IEquatable<SkuIneligibilityReason>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkuIneligibilityReason" /> class.
        /// </summary>
        [JsonConstructor]
        protected SkuIneligibilityReason() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SkuIneligibilityReason" /> class.
        /// </summary>
        /// <param name="code">Code for the SKU ineligibility. (required).</param>
        /// <param name="description">Detailed description of the SKU ineligibility. (required).</param>
        public SkuIneligibilityReason(string code = default, string description = default)
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for SkuIneligibilityReason and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for SkuIneligibilityReason and cannot be null");
            }
            else
            {
                this.Description = description;
            }
        }

        /// <summary>
        /// Code for the SKU ineligibility.
        /// </summary>
        /// <value>Code for the SKU ineligibility.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Detailed description of the SKU ineligibility.
        /// </summary>
        /// <value>Detailed description of the SKU ineligibility.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkuIneligibilityReason {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as SkuIneligibilityReason);
        }

        /// <summary>
        /// Returns true if SkuIneligibilityReason instances are equal
        /// </summary>
        /// <param name="input">Instance of SkuIneligibilityReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SkuIneligibilityReason input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
