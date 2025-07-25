/* 
 * Selling Partner API for Retail Procurement Payments
 *
 * The Selling Partner API for Retail Procurement Payments provides programmatic access to vendors payments data.
 *
 * OpenAPI spec version: v1
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
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorInvoices
{
    /// <summary>
    /// Monetary and tax details of the charge.
    /// </summary>
    [DataContract]
    public partial class ChargeDetails : IEquatable<ChargeDetails>, IValidatableObject
    {
        /// <summary>
        /// Type of the charge applied.
        /// </summary>
        /// <value>Type of the charge applied.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {

            /// <summary>
            /// Enum Freight for value: Freight
            /// </summary>
            [EnumMember(Value = "Freight")]
            Freight = 1,

            /// <summary>
            /// Enum Packing for value: Packing
            /// </summary>
            [EnumMember(Value = "Packing")]
            Packing = 2,

            /// <summary>
            /// Enum Duty for value: Duty
            /// </summary>
            [EnumMember(Value = "Duty")]
            Duty = 3,

            /// <summary>
            /// Enum Service for value: Service
            /// </summary>
            [EnumMember(Value = "Service")]
            Service = 4,

            /// <summary>
            /// Enum SmallOrder for value: SmallOrder
            /// </summary>
            [EnumMember(Value = "SmallOrder")]
            SmallOrder = 5,

            /// <summary>
            /// Enum InsurancePlacementCost for value: InsurancePlacementCost
            /// </summary>
            [EnumMember(Value = "InsurancePlacementCost")]
            InsurancePlacementCost = 6,

            /// <summary>
            /// Enum InsuranceFee for value: InsuranceFee
            /// </summary>
            [EnumMember(Value = "InsuranceFee")]
            InsuranceFee = 7,

            /// <summary>
            /// Enum SpecialHandlingService for value: SpecialHandlingService
            /// </summary>
            [EnumMember(Value = "SpecialHandlingService")]
            SpecialHandlingService = 8,

            /// <summary>
            /// Enum CollectionAndRecyclingService for value: CollectionAndRecyclingService
            /// </summary>
            [EnumMember(Value = "CollectionAndRecyclingService")]
            CollectionAndRecyclingService = 9,

            /// <summary>
            /// Enum EnvironmentalProtectionService for value: EnvironmentalProtectionService
            /// </summary>
            [EnumMember(Value = "EnvironmentalProtectionService")]
            EnvironmentalProtectionService = 10,

            /// <summary>
            /// Enum TaxCollectedAtSource for value: TaxCollectedAtSource
            /// </summary>
            [EnumMember(Value = "TaxCollectedAtSource")]
            TaxCollectedAtSource = 11
        }

        /// <summary>
        /// Type of the charge applied.
        /// </summary>
        /// <value>Type of the charge applied.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeDetails" /> class.
        /// </summary>
        [JsonConstructor]
        protected ChargeDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeDetails" /> class.
        /// </summary>
        /// <param name="type">Type of the charge applied. (required).</param>
        /// <param name="description">Description of the charge..</param>
        /// <param name="chargeAmount">Total monetary amount related to this charge. (required).</param>
        /// <param name="taxDetails">Tax amount details applied on this charge..</param>
        public ChargeDetails(TypeEnum type = default, string description = default, Money chargeAmount = default, List<TaxDetails> taxDetails = default)
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ChargeDetails and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "chargeAmount" is required (not null)
            if (chargeAmount == null)
            {
                throw new InvalidDataException("chargeAmount is a required property for ChargeDetails and cannot be null");
            }
            else
            {
                this.ChargeAmount = chargeAmount;
            }
            this.Description = description;
            this.TaxDetails = taxDetails;
        }


        /// <summary>
        /// Description of the charge.
        /// </summary>
        /// <value>Description of the charge.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Total monetary amount related to this charge.
        /// </summary>
        /// <value>Total monetary amount related to this charge.</value>
        [DataMember(Name = "chargeAmount", EmitDefaultValue = false)]
        public Money ChargeAmount { get; set; }

        /// <summary>
        /// Tax amount details applied on this charge.
        /// </summary>
        /// <value>Tax amount details applied on this charge.</value>
        [DataMember(Name = "taxDetails", EmitDefaultValue = false)]
        public List<TaxDetails> TaxDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeDetails {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ChargeAmount: ").Append(ChargeAmount).Append("\n");
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
            return this.Equals(input as ChargeDetails);
        }

        /// <summary>
        /// Returns true if ChargeDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeDetails input)
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
                    this.ChargeAmount == input.ChargeAmount ||
                    (this.ChargeAmount != null &&
                    this.ChargeAmount.Equals(input.ChargeAmount))
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
                if (this.ChargeAmount != null)
                    hashCode = hashCode * 59 + this.ChargeAmount.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
