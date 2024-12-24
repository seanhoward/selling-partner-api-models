/* 
 * Vendor Shipments v1
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
    /// The volume of the shipment.
    /// </summary>
    [DataContract]
    public partial class Volume :  IEquatable<Volume>, IValidatableObject
    {
        /// <summary>
        /// The unit of measurement.
        /// </summary>
        /// <value>The unit of measurement.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitOfMeasureEnum
        {
            
            /// <summary>
            /// Enum CuFt for value: CuFt
            /// </summary>
            [EnumMember(Value = "CuFt")]
            CuFt = 1,
            
            /// <summary>
            /// Enum CuIn for value: CuIn
            /// </summary>
            [EnumMember(Value = "CuIn")]
            CuIn = 2,
            
            /// <summary>
            /// Enum CuM for value: CuM
            /// </summary>
            [EnumMember(Value = "CuM")]
            CuM = 3,
            
            /// <summary>
            /// Enum CuY for value: CuY
            /// </summary>
            [EnumMember(Value = "CuY")]
            CuY = 4
        }

        /// <summary>
        /// The unit of measurement.
        /// </summary>
        /// <value>The unit of measurement.</value>
        [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
        public UnitOfMeasureEnum UnitOfMeasure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Volume" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Volume() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Volume" /> class.
        /// </summary>
        /// <param name="unitOfMeasure">The unit of measurement. (required).</param>
        /// <param name="value">The measurement value. (required).</param>
        public Volume(UnitOfMeasureEnum unitOfMeasure = default(UnitOfMeasureEnum), string value = default(string))
        {
            // to ensure "unitOfMeasure" is required (not null)
            if (unitOfMeasure == null)
            {
                throw new InvalidDataException("unitOfMeasure is a required property for Volume and cannot be null");
            }
            else
            {
                this.UnitOfMeasure = unitOfMeasure;
            }
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for Volume and cannot be null");
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
            sb.Append("class Volume {\n");
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
            return this.Equals(input as Volume);
        }

        /// <summary>
        /// Returns true if Volume instances are equal
        /// </summary>
        /// <param name="input">Instance of Volume to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Volume input)
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
