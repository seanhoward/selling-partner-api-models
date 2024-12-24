/* 
 * Vendor Invoices v1
 *
 * The Selling Partner API for Retail Procurement Payments provides programmatic access to vendors payments data.
 *
 * OpenAPI spec version: v1
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorInvoices
{
    /// <summary>
    /// Monetary and tax details of the allowance.
    /// </summary>
    [DataContract]
    public partial class AllowanceDetails :  IEquatable<AllowanceDetails>, IValidatableObject
    {
        /// <summary>
        /// Type of the allowance applied.
        /// </summary>
        /// <value>Type of the allowance applied.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Discount for value: Discount
            /// </summary>
            [EnumMember(Value = "Discount")]
            Discount = 1,
            
            /// <summary>
            /// Enum DiscountIncentive for value: DiscountIncentive
            /// </summary>
            [EnumMember(Value = "DiscountIncentive")]
            DiscountIncentive = 2,
            
            /// <summary>
            /// Enum Defective for value: Defective
            /// </summary>
            [EnumMember(Value = "Defective")]
            Defective = 3,
            
            /// <summary>
            /// Enum Promotional for value: Promotional
            /// </summary>
            [EnumMember(Value = "Promotional")]
            Promotional = 4,
            
            /// <summary>
            /// Enum UnsaleableMerchandise for value: UnsaleableMerchandise
            /// </summary>
            [EnumMember(Value = "UnsaleableMerchandise")]
            UnsaleableMerchandise = 5,
            
            /// <summary>
            /// Enum Special for value: Special
            /// </summary>
            [EnumMember(Value = "Special")]
            Special = 6
        }

        /// <summary>
        /// Type of the allowance applied.
        /// </summary>
        /// <value>Type of the allowance applied.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllowanceDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AllowanceDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllowanceDetails" /> class.
        /// </summary>
        /// <param name="type">Type of the allowance applied. (required).</param>
        /// <param name="description">Description of the allowance..</param>
        /// <param name="allowanceAmount">Total monetary amount related to this allowance. (required).</param>
        /// <param name="taxDetails">Tax amount details applied on this allowance..</param>
        public AllowanceDetails(TypeEnum type = default(TypeEnum), string description = default(string), Money allowanceAmount = default(Money), List<TaxDetails> taxDetails = default(List<TaxDetails>))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for AllowanceDetails and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "allowanceAmount" is required (not null)
            if (allowanceAmount == null)
            {
                throw new InvalidDataException("allowanceAmount is a required property for AllowanceDetails and cannot be null");
            }
            else
            {
                this.AllowanceAmount = allowanceAmount;
            }
            this.Description = description;
            this.TaxDetails = taxDetails;
        }
        

        /// <summary>
        /// Description of the allowance.
        /// </summary>
        /// <value>Description of the allowance.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Total monetary amount related to this allowance.
        /// </summary>
        /// <value>Total monetary amount related to this allowance.</value>
        [DataMember(Name="allowanceAmount", EmitDefaultValue=false)]
        public Money AllowanceAmount { get; set; }

        /// <summary>
        /// Tax amount details applied on this allowance.
        /// </summary>
        /// <value>Tax amount details applied on this allowance.</value>
        [DataMember(Name="taxDetails", EmitDefaultValue=false)]
        public List<TaxDetails> TaxDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllowanceDetails {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AllowanceAmount: ").Append(AllowanceAmount).Append("\n");
            sb.Append("  TaxDetails: ").Append(TaxDetails).Append("\n");
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
            return this.Equals(input as AllowanceDetails);
        }

        /// <summary>
        /// Returns true if AllowanceDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AllowanceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllowanceDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AllowanceAmount == input.AllowanceAmount ||
                    (this.AllowanceAmount != null &&
                    this.AllowanceAmount.Equals(input.AllowanceAmount))
                ) && 
                (
                    this.TaxDetails == input.TaxDetails ||
                    this.TaxDetails != null &&
                    this.TaxDetails.SequenceEqual(input.TaxDetails)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AllowanceAmount != null)
                    hashCode = hashCode * 59 + this.AllowanceAmount.GetHashCode();
                if (this.TaxDetails != null)
                    hashCode = hashCode * 59 + this.TaxDetails.GetHashCode();
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
