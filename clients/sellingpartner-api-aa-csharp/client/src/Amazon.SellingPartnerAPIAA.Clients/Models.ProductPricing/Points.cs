/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer pricing information for Amazon Marketplace products.  For more information, refer to the [Product Pricing v2022-05-01 Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/product-pricing-api-v2022-05-01-use-case-guide).
 *
 * OpenAPI spec version: 2022-05-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.ProductPricing
{
    /// <summary>
    /// The number of Amazon Points that are offered with the purchase of an item and the monetary value of these points.
    /// </summary>
    [DataContract]
    public partial class Points : IEquatable<Points>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Points" /> class.
        /// </summary>
        /// <param name="pointsNumber">The number of Amazon Points..</param>
        /// <param name="pointsMonetaryValue">The monetary value of the Amazon Points..</param>
        public Points(int? pointsNumber = default, MoneyType pointsMonetaryValue = default)
        {
            this.PointsNumber = pointsNumber;
            this.PointsMonetaryValue = pointsMonetaryValue;
        }

        /// <summary>
        /// The number of Amazon Points.
        /// </summary>
        /// <value>The number of Amazon Points.</value>
        [DataMember(Name = "pointsNumber", EmitDefaultValue = false)]
        public int? PointsNumber { get; set; }

        /// <summary>
        /// The monetary value of the Amazon Points.
        /// </summary>
        /// <value>The monetary value of the Amazon Points.</value>
        [DataMember(Name = "pointsMonetaryValue", EmitDefaultValue = false)]
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
