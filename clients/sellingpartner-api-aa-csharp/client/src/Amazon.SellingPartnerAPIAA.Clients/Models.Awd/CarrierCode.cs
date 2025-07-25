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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Awd
{
    /// <summary>
    /// Identifies the carrier that will deliver the shipment.
    /// </summary>
    [DataContract]
    public partial class CarrierCode : IEquatable<CarrierCode>, IValidatableObject
    {
        /// <summary>
        /// Denotes the carrier type.
        /// </summary>
        /// <value>Denotes the carrier type.</value>
        [DataMember(Name = "carrierCodeType", EmitDefaultValue = false)]
        public CarrierCodeType? CarrierCodeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierCode" /> class.
        /// </summary>
        /// <param name="carrierCodeType">Denotes the carrier type..</param>
        /// <param name="carrierCodeValue">Value of the carrier code..</param>
        public CarrierCode(CarrierCodeType? carrierCodeType = default, string carrierCodeValue = default)
        {
            this.CarrierCodeType = carrierCodeType;
            this.CarrierCodeValue = carrierCodeValue;
        }


        /// <summary>
        /// Value of the carrier code.
        /// </summary>
        /// <value>Value of the carrier code.</value>
        [DataMember(Name = "carrierCodeValue", EmitDefaultValue = false)]
        public string CarrierCodeValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CarrierCode {\n");
            sb.Append("  CarrierCodeType: ").Append(CarrierCodeType).Append("\n");
            sb.Append("  CarrierCodeValue: ").Append(CarrierCodeValue).Append("\n");
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
            return this.Equals(input as CarrierCode);
        }

        /// <summary>
        /// Returns true if CarrierCode instances are equal
        /// </summary>
        /// <param name="input">Instance of CarrierCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CarrierCode input)
        {
            if (input == null)
                return false;

            return
                (
                    this.CarrierCodeType == input.CarrierCodeType ||
                    (this.CarrierCodeType != null &&
                    this.CarrierCodeType.Equals(input.CarrierCodeType))
                ) &&
                (
                    this.CarrierCodeValue == input.CarrierCodeValue ||
                    (this.CarrierCodeValue != null &&
                    this.CarrierCodeValue.Equals(input.CarrierCodeValue))
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
                if (this.CarrierCodeType != null)
                    hashCode = hashCode * 59 + this.CarrierCodeType.GetHashCode();
                if (this.CarrierCodeValue != null)
                    hashCode = hashCode * 59 + this.CarrierCodeValue.GetHashCode();
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
