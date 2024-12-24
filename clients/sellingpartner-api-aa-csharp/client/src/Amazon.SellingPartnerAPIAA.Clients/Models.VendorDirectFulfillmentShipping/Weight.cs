/* 
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * The Selling Partner API for Direct Fulfillment Shipping provides programmatic access to a direct fulfillment vendor's shipping data.
 *
 * OpenAPI spec version: 2021-12-28
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping
{
    /// <summary>
    /// The weight.
    /// </summary>
    [DataContract]
    public partial class Weight :  IEquatable<Weight>, IValidatableObject
    {
        /// <summary>
        /// The unit of measurement.
        /// </summary>
        /// <value>The unit of measurement.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitOfMeasureEnum
        {
            
            /// <summary>
            /// Enum KG for value: KG
            /// </summary>
            [EnumMember(Value = "KG")]
            KG = 1,
            
            /// <summary>
            /// Enum LB for value: LB
            /// </summary>
            [EnumMember(Value = "LB")]
            LB = 2
        }

        /// <summary>
        /// The unit of measurement.
        /// </summary>
        /// <value>The unit of measurement.</value>
        [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
        public UnitOfMeasureEnum UnitOfMeasure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Weight" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Weight() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Weight" /> class.
        /// </summary>
        /// <param name="unitOfMeasure">The unit of measurement. (required).</param>
        /// <param name="value">The measurement value. (required).</param>
        public Weight(UnitOfMeasureEnum unitOfMeasure = default(UnitOfMeasureEnum), string value = default(string))
        {
            // to ensure "unitOfMeasure" is required (not null)
            if (unitOfMeasure == null)
            {
                throw new InvalidDataException("unitOfMeasure is a required property for Weight and cannot be null");
            }
            else
            {
                this.UnitOfMeasure = unitOfMeasure;
            }
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for Weight and cannot be null");
            }
            else
            {
                this.Value = value;
            }
        }
        

        /// <summary>
        /// The measurement value.
        /// </summary>
        /// <value>The measurement value.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Weight {\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as Weight);
        }

        /// <summary>
        /// Returns true if Weight instances are equal
        /// </summary>
        /// <param name="input">Instance of Weight to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Weight input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    (this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.UnitOfMeasure != null)
                    hashCode = hashCode * 59 + this.UnitOfMeasure.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
