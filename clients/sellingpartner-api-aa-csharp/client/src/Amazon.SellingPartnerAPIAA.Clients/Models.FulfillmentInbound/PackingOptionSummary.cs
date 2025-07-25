/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound
{
    /// <summary>
    /// Summary information about a packing option.
    /// </summary>
    [DataContract]
    public partial class PackingOptionSummary : IEquatable<PackingOptionSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackingOptionSummary" /> class.
        /// </summary>
        [JsonConstructor]
        protected PackingOptionSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackingOptionSummary" /> class.
        /// </summary>
        /// <param name="packingOptionId">Identifier of a packing option. (required).</param>
        /// <param name="status">The status of a packing option. Possible values: &#39;OFFERED&#39;, &#39;ACCEPTED&#39;, &#39;EXPIRED&#39;. (required).</param>
        public PackingOptionSummary(string packingOptionId = default, string status = default)
        {
            // to ensure "packingOptionId" is required (not null)
            if (packingOptionId == null)
            {
                throw new InvalidDataException("packingOptionId is a required property for PackingOptionSummary and cannot be null");
            }
            else
            {
                this.PackingOptionId = packingOptionId;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for PackingOptionSummary and cannot be null");
            }
            else
            {
                this.Status = status;
            }
        }

        /// <summary>
        /// Identifier of a packing option.
        /// </summary>
        /// <value>Identifier of a packing option.</value>
        [DataMember(Name = "packingOptionId", EmitDefaultValue = false)]
        public string PackingOptionId { get; set; }

        /// <summary>
        /// The status of a packing option. Possible values: &#39;OFFERED&#39;, &#39;ACCEPTED&#39;, &#39;EXPIRED&#39;.
        /// </summary>
        /// <value>The status of a packing option. Possible values: &#39;OFFERED&#39;, &#39;ACCEPTED&#39;, &#39;EXPIRED&#39;.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackingOptionSummary {\n");
            sb.Append("  PackingOptionId: ").Append(PackingOptionId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as PackingOptionSummary);
        }

        /// <summary>
        /// Returns true if PackingOptionSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of PackingOptionSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackingOptionSummary input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PackingOptionId == input.PackingOptionId ||
                    (this.PackingOptionId != null &&
                    this.PackingOptionId.Equals(input.PackingOptionId))
                ) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.PackingOptionId != null)
                    hashCode = hashCode * 59 + this.PackingOptionId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
            // PackingOptionId (string) maxLength
            if (this.PackingOptionId != null && this.PackingOptionId.Length > 38)
            {
                yield return new ValidationResult("Invalid value for PackingOptionId, length must be less than 38.", new[] { "PackingOptionId" });
            }

            // PackingOptionId (string) minLength
            if (this.PackingOptionId != null && this.PackingOptionId.Length < 38)
            {
                yield return new ValidationResult("Invalid value for PackingOptionId, length must be greater than 38.", new[] { "PackingOptionId" });
            }

            // PackingOptionId (string) pattern
            Regex regexPackingOptionId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
            if (false == regexPackingOptionId.Match(this.PackingOptionId).Success)
            {
                yield return new ValidationResult("Invalid value for PackingOptionId, must match a pattern of " + regexPackingOptionId, new[] { "PackingOptionId" });
            }

            // Status (string) maxLength
            if (this.Status != null && this.Status.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for Status, length must be less than 1024.", new[] { "Status" });
            }

            // Status (string) minLength
            if (this.Status != null && this.Status.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Status, length must be greater than 1.", new[] { "Status" });
            }

            yield break;
        }
    }

}
