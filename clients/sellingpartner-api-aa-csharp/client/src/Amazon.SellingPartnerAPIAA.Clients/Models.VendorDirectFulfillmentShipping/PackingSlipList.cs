/* 
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * Use the Selling Partner API for Direct Fulfillment Shipping to access a direct fulfillment vendor's shipping data.
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
    /// A list of packing slips.
    /// </summary>
    [DataContract]
    public partial class PackingSlipList :  IEquatable<PackingSlipList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackingSlipList" /> class.
        /// </summary>
        /// <param name="pagination">The pagination elements required to retrieve the remaining data..</param>
        /// <param name="packingSlips">An array of packing slip objects..</param>
        public PackingSlipList(Pagination pagination = default(Pagination), List<PackingSlip> packingSlips = default(List<PackingSlip>))
        {
            this.Pagination = pagination;
            this.PackingSlips = packingSlips;
        }
        
        /// <summary>
        /// The pagination elements required to retrieve the remaining data.
        /// </summary>
        /// <value>The pagination elements required to retrieve the remaining data.</value>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// An array of packing slip objects.
        /// </summary>
        /// <value>An array of packing slip objects.</value>
        [DataMember(Name="packingSlips", EmitDefaultValue=false)]
        public List<PackingSlip> PackingSlips { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackingSlipList {\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  PackingSlips: ").Append(PackingSlips).Append("\n");
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
            return this.Equals(input as PackingSlipList);
        }

        /// <summary>
        /// Returns true if PackingSlipList instances are equal
        /// </summary>
        /// <param name="input">Instance of PackingSlipList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackingSlipList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.PackingSlips == input.PackingSlips ||
                    this.PackingSlips != null &&
                    this.PackingSlips.SequenceEqual(input.PackingSlips)
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
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
                if (this.PackingSlips != null)
                    hashCode = hashCode * 59 + this.PackingSlips.GetHashCode();
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
