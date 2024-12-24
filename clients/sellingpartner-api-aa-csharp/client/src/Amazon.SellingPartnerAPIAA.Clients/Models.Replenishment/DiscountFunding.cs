/* 
 * Selling Partner API for Replenishment
 *
 * The Selling Partner API for Replenishment (Replenishment API) provides programmatic access to replenishment program metrics and offers. These programs provide recurring delivery of any replenishable item at a frequency chosen by the customer.  The Replenishment API is available worldwide wherever Amazon Subscribe & Save is available or is supported. The API is available to vendors and FBA selling partners.
 *
 * OpenAPI spec version: 2022-11-07
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Replenishment
{
    /// <summary>
    /// The discount funding on the offer.
    /// </summary>
    [DataContract]
    public partial class DiscountFunding :  IEquatable<DiscountFunding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountFunding" /> class.
        /// </summary>
        /// <param name="percentage">Filters the results to only include offers with the percentage specified..</param>
        public DiscountFunding(List<decimal?> percentage = default(List<decimal?>))
        {
            this.Percentage = percentage;
        }
        
        /// <summary>
        /// Filters the results to only include offers with the percentage specified.
        /// </summary>
        /// <value>Filters the results to only include offers with the percentage specified.</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public List<decimal?> Percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscountFunding {\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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
            return this.Equals(input as DiscountFunding);
        }

        /// <summary>
        /// Returns true if DiscountFunding instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscountFunding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscountFunding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage != null &&
                    this.Percentage.SequenceEqual(input.Percentage)
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
                if (this.Percentage != null)
                    hashCode = hashCode * 59 + this.Percentage.GetHashCode();
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