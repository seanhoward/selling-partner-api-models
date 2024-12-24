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
    /// Duration after manufacturing date during which the product is valid for consumption.
    /// </summary>
    [DataContract]
    public partial class Duration :  IEquatable<Duration>, IValidatableObject
    {
        /// <summary>
        /// Unit for duration.
        /// </summary>
        /// <value>Unit for duration.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DurationUnitEnum
        {
            
            /// <summary>
            /// Enum Days for value: Days
            /// </summary>
            [EnumMember(Value = "Days")]
            Days = 1,
            
            /// <summary>
            /// Enum Months for value: Months
            /// </summary>
            [EnumMember(Value = "Months")]
            Months = 2
        }

        /// <summary>
        /// Unit for duration.
        /// </summary>
        /// <value>Unit for duration.</value>
        [DataMember(Name="durationUnit", EmitDefaultValue=false)]
        public DurationUnitEnum DurationUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Duration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Duration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Duration" /> class.
        /// </summary>
        /// <param name="durationUnit">Unit for duration. (required).</param>
        /// <param name="durationValue">Value for the duration in terms of the durationUnit. (required).</param>
        public Duration(DurationUnitEnum durationUnit = default(DurationUnitEnum), int? durationValue = default(int?))
        {
            // to ensure "durationUnit" is required (not null)
            if (durationUnit == null)
            {
                throw new InvalidDataException("durationUnit is a required property for Duration and cannot be null");
            }
            else
            {
                this.DurationUnit = durationUnit;
            }
            // to ensure "durationValue" is required (not null)
            if (durationValue == null)
            {
                throw new InvalidDataException("durationValue is a required property for Duration and cannot be null");
            }
            else
            {
                this.DurationValue = durationValue;
            }
        }
        

        /// <summary>
        /// Value for the duration in terms of the durationUnit.
        /// </summary>
        /// <value>Value for the duration in terms of the durationUnit.</value>
        [DataMember(Name="durationValue", EmitDefaultValue=false)]
        public int? DurationValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Duration {\n");
            sb.Append("  DurationUnit: ").Append(DurationUnit).Append("\n");
            sb.Append("  DurationValue: ").Append(DurationValue).Append("\n");
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
            return this.Equals(input as Duration);
        }

        /// <summary>
        /// Returns true if Duration instances are equal
        /// </summary>
        /// <param name="input">Instance of Duration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Duration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DurationUnit == input.DurationUnit ||
                    (this.DurationUnit != null &&
                    this.DurationUnit.Equals(input.DurationUnit))
                ) && 
                (
                    this.DurationValue == input.DurationValue ||
                    (this.DurationValue != null &&
                    this.DurationValue.Equals(input.DurationValue))
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
                if (this.DurationUnit != null)
                    hashCode = hashCode * 59 + this.DurationUnit.GetHashCode();
                if (this.DurationValue != null)
                    hashCode = hashCode * 59 + this.DurationValue.GetHashCode();
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
