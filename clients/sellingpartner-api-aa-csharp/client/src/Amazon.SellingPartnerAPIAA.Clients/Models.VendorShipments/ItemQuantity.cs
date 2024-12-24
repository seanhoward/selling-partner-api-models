/* 
 * Selling Partner API for Retail Procurement Shipments
 *
 * The Selling Partner API for Retail Procurement Shipments provides programmatic access to retail shipping data for vendors.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorShipments
{
    /// <summary>
    /// Details of item quantity.
    /// </summary>
    [DataContract]
    public partial class ItemQuantity :  IEquatable<ItemQuantity>, IValidatableObject
    {
        /// <summary>
        /// Unit of measure for the shipped quantity.
        /// </summary>
        /// <value>Unit of measure for the shipped quantity.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitOfMeasureEnum
        {
            
            /// <summary>
            /// Enum Cases for value: Cases
            /// </summary>
            [EnumMember(Value = "Cases")]
            Cases = 1,
            
            /// <summary>
            /// Enum Eaches for value: Eaches
            /// </summary>
            [EnumMember(Value = "Eaches")]
            Eaches = 2
        }

        /// <summary>
        /// Unit of measure for the shipped quantity.
        /// </summary>
        /// <value>Unit of measure for the shipped quantity.</value>
        [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
        public UnitOfMeasureEnum UnitOfMeasure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemQuantity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemQuantity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemQuantity" /> class.
        /// </summary>
        /// <param name="amount">Amount of units shipped for a specific item at a shipment level. If the item is present only in certain cartons or pallets within the shipment, please provide this at the appropriate carton or pallet level. (required).</param>
        /// <param name="unitOfMeasure">Unit of measure for the shipped quantity. (required).</param>
        /// <param name="unitSize">The case size, in the event that we ordered using cases. Otherwise, 1..</param>
        /// <param name="totalWeight">totalWeight.</param>
        public ItemQuantity(int? amount = default(int?), UnitOfMeasureEnum unitOfMeasure = default(UnitOfMeasureEnum), int? unitSize = default(int?), TotalWeight totalWeight = default(TotalWeight))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for ItemQuantity and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "unitOfMeasure" is required (not null)
            if (unitOfMeasure == null)
            {
                throw new InvalidDataException("unitOfMeasure is a required property for ItemQuantity and cannot be null");
            }
            else
            {
                this.UnitOfMeasure = unitOfMeasure;
            }
            this.UnitSize = unitSize;
            this.TotalWeight = totalWeight;
        }
        
        /// <summary>
        /// Amount of units shipped for a specific item at a shipment level. If the item is present only in certain cartons or pallets within the shipment, please provide this at the appropriate carton or pallet level.
        /// </summary>
        /// <value>Amount of units shipped for a specific item at a shipment level. If the item is present only in certain cartons or pallets within the shipment, please provide this at the appropriate carton or pallet level.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }


        /// <summary>
        /// The case size, in the event that we ordered using cases. Otherwise, 1.
        /// </summary>
        /// <value>The case size, in the event that we ordered using cases. Otherwise, 1.</value>
        [DataMember(Name="unitSize", EmitDefaultValue=false)]
        public int? UnitSize { get; set; }

        /// <summary>
        /// Gets or Sets TotalWeight
        /// </summary>
        [DataMember(Name="totalWeight", EmitDefaultValue=false)]
        public TotalWeight TotalWeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemQuantity {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  UnitSize: ").Append(UnitSize).Append("\n");
            sb.Append("  TotalWeight: ").Append(TotalWeight).Append("\n");
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
            return this.Equals(input as ItemQuantity);
        }

        /// <summary>
        /// Returns true if ItemQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemQuantity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    (this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure))
                ) && 
                (
                    this.UnitSize == input.UnitSize ||
                    (this.UnitSize != null &&
                    this.UnitSize.Equals(input.UnitSize))
                ) && 
                (
                    this.TotalWeight == input.TotalWeight ||
                    (this.TotalWeight != null &&
                    this.TotalWeight.Equals(input.TotalWeight))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.UnitOfMeasure != null)
                    hashCode = hashCode * 59 + this.UnitOfMeasure.GetHashCode();
                if (this.UnitSize != null)
                    hashCode = hashCode * 59 + this.UnitSize.GetHashCode();
                if (this.TotalWeight != null)
                    hashCode = hashCode * 59 + this.TotalWeight.GetHashCode();
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