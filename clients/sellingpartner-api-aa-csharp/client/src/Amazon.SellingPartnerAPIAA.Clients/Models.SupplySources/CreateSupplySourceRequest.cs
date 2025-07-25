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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources
{
    /// <summary>
    /// A request to create a supply source.
    /// </summary>
    [DataContract]
    public partial class CreateSupplySourceRequest : IEquatable<CreateSupplySourceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSupplySourceRequest" /> class.
        /// </summary>
        [JsonConstructor]
        protected CreateSupplySourceRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSupplySourceRequest" /> class.
        /// </summary>
        /// <param name="supplySourceCode">supplySourceCode (required).</param>
        /// <param name="alias">alias (required).</param>
        /// <param name="address">address (required).</param>
        public CreateSupplySourceRequest(string supplySourceCode = default, string alias = default, Address address = default)
        {
            // to ensure "supplySourceCode" is required (not null)
            if (supplySourceCode == null)
            {
                throw new InvalidDataException("supplySourceCode is a required property for CreateSupplySourceRequest and cannot be null");
            }
            else
            {
                this.SupplySourceCode = supplySourceCode;
            }
            // to ensure "alias" is required (not null)
            if (alias == null)
            {
                throw new InvalidDataException("alias is a required property for CreateSupplySourceRequest and cannot be null");
            }
            else
            {
                this.Alias = alias;
            }
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for CreateSupplySourceRequest and cannot be null");
            }
            else
            {
                this.Address = address;
            }
        }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSupplySourceRequest {\n");
            sb.Append("  SupplySourceCode: ").Append(SupplySourceCode).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as CreateSupplySourceRequest);
        }

        /// <summary>
        /// Returns true if CreateSupplySourceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSupplySourceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSupplySourceRequest input)
        {
            if (input == null)
                return false;

            return
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.SupplySourceCode != null)
                    hashCode = hashCode * 59 + this.SupplySourceCode.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
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
