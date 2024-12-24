/* 
 * Selling Partner API for Product Fees
 *
 * The Selling Partner API for Product Fees lets you programmatically retrieve estimated fees for a product. You can then account for those fees in your pricing.
 *
 * OpenAPI spec version: v0
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.ProductFees
{
    /// <summary>
    /// Points
    /// </summary>
    [DataContract]
    public partial class Points :  IEquatable<Points>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Points" /> class.
        /// </summary>
        /// <param name="pointsNumber">pointsNumber.</param>
        /// <param name="pointsMonetaryValue">pointsMonetaryValue.</param>
        public Points(int? pointsNumber = default(int?), MoneyType pointsMonetaryValue = default(MoneyType))
        {
            this.PointsNumber = pointsNumber;
            this.PointsMonetaryValue = pointsMonetaryValue;
        }
        
        /// <summary>
        /// Gets or Sets PointsNumber
        /// </summary>
        [DataMember(Name="PointsNumber", EmitDefaultValue=false)]
        public int? PointsNumber { get; set; }

        /// <summary>
        /// Gets or Sets PointsMonetaryValue
        /// </summary>
        [DataMember(Name="PointsMonetaryValue", EmitDefaultValue=false)]
        public MoneyType PointsMonetaryValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Points {\n");
            sb.Append("  PointsNumber: ").Append(PointsNumber).Append("\n");
            sb.Append("  PointsMonetaryValue: ").Append(PointsMonetaryValue).Append("\n");
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
            return this.Equals(input as Points);
        }

        /// <summary>
        /// Returns true if Points instances are equal
        /// </summary>
        /// <param name="input">Instance of Points to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Points input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PointsNumber == input.PointsNumber ||
                    (this.PointsNumber != null &&
                    this.PointsNumber.Equals(input.PointsNumber))
                ) && 
                (
                    this.PointsMonetaryValue == input.PointsMonetaryValue ||
                    (this.PointsMonetaryValue != null &&
                    this.PointsMonetaryValue.Equals(input.PointsMonetaryValue))
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
                if (this.PointsNumber != null)
                    hashCode = hashCode * 59 + this.PointsNumber.GetHashCode();
                if (this.PointsMonetaryValue != null)
                    hashCode = hashCode * 59 + this.PointsMonetaryValue.GetHashCode();
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