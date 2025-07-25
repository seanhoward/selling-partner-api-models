/* 
 * The Selling Partner API for CustomerFeedback
 *
 * The Selling Partner API for Customer Feedback (Customer Feedback API) provides information about customer reviews and returns at both the item and browse node level.
 *
 * OpenAPI spec version: 2024-06-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.CustomerFeedback
{
    /// <summary>
    /// The effects of a topic on a browse node&#39;s star rating.
    /// </summary>
    [DataContract]
    public partial class BrowseNodeStarRatingImpact : IEquatable<BrowseNodeStarRatingImpact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowseNodeStarRatingImpact" /> class.
        /// </summary>
        [JsonConstructor]
        protected BrowseNodeStarRatingImpact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowseNodeStarRatingImpact" /> class.
        /// </summary>
        /// <param name="allProducts">The effect of the topic on the star rating for all products in this browse node. This value can be positive or negative. (required).</param>
        public BrowseNodeStarRatingImpact(float? allProducts = default)
        {
            // to ensure "allProducts" is required (not null)
            if (allProducts == null)
            {
                throw new InvalidDataException("allProducts is a required property for BrowseNodeStarRatingImpact and cannot be null");
            }
            else
            {
                this.AllProducts = allProducts;
            }
        }

        /// <summary>
        /// The effect of the topic on the star rating for all products in this browse node. This value can be positive or negative.
        /// </summary>
        /// <value>The effect of the topic on the star rating for all products in this browse node. This value can be positive or negative.</value>
        [DataMember(Name = "allProducts", EmitDefaultValue = false)]
        public float? AllProducts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrowseNodeStarRatingImpact {\n");
            sb.Append("  AllProducts: ").Append(AllProducts).Append("\n");
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
            return this.Equals(input as BrowseNodeStarRatingImpact);
        }

        /// <summary>
        /// Returns true if BrowseNodeStarRatingImpact instances are equal
        /// </summary>
        /// <param name="input">Instance of BrowseNodeStarRatingImpact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrowseNodeStarRatingImpact input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AllProducts == input.AllProducts ||
                    (this.AllProducts != null &&
                    this.AllProducts.Equals(input.AllProducts))
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
                if (this.AllProducts != null)
                    hashCode = hashCode * 59 + this.AllProducts.GetHashCode();
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
