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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Awd
{
    /// <summary>
    /// Represents the packages to inbound.
    /// </summary>
    [DataContract]
    public partial class InboundPackages : IEquatable<InboundPackages>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundPackages" /> class.
        /// </summary>
        [JsonConstructor]
        protected InboundPackages() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundPackages" /> class.
        /// </summary>
        /// <param name="packagesToInbound">List of packages to be inbounded. (required).</param>
        public InboundPackages(List<DistributionPackageQuantity> packagesToInbound = default)
        {
            // to ensure "packagesToInbound" is required (not null)
            if (packagesToInbound == null)
            {
                throw new InvalidDataException("packagesToInbound is a required property for InboundPackages and cannot be null");
            }
            else
            {
                this.PackagesToInbound = packagesToInbound;
            }
        }

        /// <summary>
        /// List of packages to be inbounded.
        /// </summary>
        /// <value>List of packages to be inbounded.</value>
        [DataMember(Name = "packagesToInbound", EmitDefaultValue = false)]
        public List<DistributionPackageQuantity> PackagesToInbound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundPackages {\n");
            sb.Append("  PackagesToInbound: ").Append(PackagesToInbound).Append("\n");
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
            return this.Equals(input as InboundPackages);
        }

        /// <summary>
        /// Returns true if InboundPackages instances are equal
        /// </summary>
        /// <param name="input">Instance of InboundPackages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundPackages input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PackagesToInbound == input.PackagesToInbound ||
                    this.PackagesToInbound != null &&
                    this.PackagesToInbound.SequenceEqual(input.PackagesToInbound)
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
                if (this.PackagesToInbound != null)
                    hashCode = hashCode * 59 + this.PackagesToInbound.GetHashCode();
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
