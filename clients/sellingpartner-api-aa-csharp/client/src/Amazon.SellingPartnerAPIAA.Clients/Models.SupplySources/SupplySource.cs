/* 
 * Selling Partner API for Supply Sources
 *
 * Manage configurations and capabilities of seller supply sources.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources
{
    /// <summary>
    /// The supply source details, including configurations and capabilities.
    /// </summary>
    [DataContract]
    public partial class SupplySource : IEquatable<SupplySource>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public SupplySourceStatusReadOnly? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplySource" /> class.
        /// </summary>
        /// <param name="supplySourceId">supplySourceId.</param>
        /// <param name="supplySourceCode">supplySourceCode.</param>
        /// <param name="alias">alias.</param>
        /// <param name="status">status.</param>
        /// <param name="address">address.</param>
        /// <param name="configuration">configuration.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public SupplySource(string supplySourceId = default, string supplySourceCode = default, string alias = default, SupplySourceStatusReadOnly? status = default, Address address = default, SupplySourceConfiguration configuration = default, SupplySourceCapabilities capabilities = default, DateTime? createdAt = default, DateTime? updatedAt = default)
        {
            this.SupplySourceId = supplySourceId;
            this.SupplySourceCode = supplySourceCode;
            this.Alias = alias;
            this.Status = status;
            this.Address = address;
            this.Configuration = configuration;
            this.Capabilities = capabilities;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets SupplySourceId
        /// </summary>
        [DataMember(Name = "supplySourceId", EmitDefaultValue = false)]
        public string SupplySourceId { get; set; }

        /// <summary>
        /// Gets or Sets SupplySourceCode
        /// </summary>
        [DataMember(Name = "supplySourceCode", EmitDefaultValue = false)]
        public string SupplySourceCode { get; set; }

        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public string Alias { get; set; }


        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public SupplySourceConfiguration Configuration { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public SupplySourceCapabilities Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupplySource {\n");
            sb.Append("  SupplySourceId: ").Append(SupplySourceId).Append("\n");
            sb.Append("  SupplySourceCode: ").Append(SupplySourceCode).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as SupplySource);
        }

        /// <summary>
        /// Returns true if SupplySource instances are equal
        /// </summary>
        /// <param name="input">Instance of SupplySource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupplySource input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SupplySourceId == input.SupplySourceId ||
                    (this.SupplySourceId != null &&
                    this.SupplySourceId.Equals(input.SupplySourceId))
                ) &&
                (
                    this.SupplySourceCode == input.SupplySourceCode ||
                    (this.SupplySourceCode != null &&
                    this.SupplySourceCode.Equals(input.SupplySourceCode))
                ) &&
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) &&
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) &&
                (
                    this.Configuration == input.Configuration ||
                    (this.Configuration != null &&
                    this.Configuration.Equals(input.Configuration))
                ) &&
                (
                    this.Capabilities == input.Capabilities ||
                    (this.Capabilities != null &&
                    this.Capabilities.Equals(input.Capabilities))
                ) &&
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) &&
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.SupplySourceId != null)
                    hashCode = hashCode * 59 + this.SupplySourceId.GetHashCode();
                if (this.SupplySourceCode != null)
                    hashCode = hashCode * 59 + this.SupplySourceCode.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                if (this.Capabilities != null)
                    hashCode = hashCode * 59 + this.Capabilities.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
