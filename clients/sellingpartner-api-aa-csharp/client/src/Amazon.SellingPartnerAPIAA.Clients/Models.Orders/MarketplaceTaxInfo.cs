/* 
 * Orders v0
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Orders
{
    /// <summary>
    /// Tax information about the marketplace.
    /// </summary>
    [DataContract]
    public partial class MarketplaceTaxInfo :  IEquatable<MarketplaceTaxInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceTaxInfo" /> class.
        /// </summary>
        /// <param name="taxClassifications">A list of tax classifications that apply to the order..</param>
        public MarketplaceTaxInfo(List<TaxClassification> taxClassifications = default(List<TaxClassification>))
        {
            this.TaxClassifications = taxClassifications;
        }
        
        /// <summary>
        /// A list of tax classifications that apply to the order.
        /// </summary>
        /// <value>A list of tax classifications that apply to the order.</value>
        [DataMember(Name="TaxClassifications", EmitDefaultValue=false)]
        public List<TaxClassification> TaxClassifications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketplaceTaxInfo {\n");
            sb.Append("  TaxClassifications: ").Append(TaxClassifications).Append("\n");
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
            return this.Equals(input as MarketplaceTaxInfo);
        }

        /// <summary>
        /// Returns true if MarketplaceTaxInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketplaceTaxInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketplaceTaxInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaxClassifications == input.TaxClassifications ||
                    this.TaxClassifications != null &&
                    this.TaxClassifications.SequenceEqual(input.TaxClassifications)
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
                if (this.TaxClassifications != null)
                    hashCode = hashCode * 59 + this.TaxClassifications.GetHashCode();
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
