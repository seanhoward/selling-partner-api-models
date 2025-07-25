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
    /// The FOEP response data for a requested SKU.
    /// </summary>
    [DataContract]
    public partial class FeaturedOfferExpectedPriceResponseBody : IEquatable<FeaturedOfferExpectedPriceResponseBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturedOfferExpectedPriceResponseBody" /> class.
        /// </summary>
        /// <param name="offerIdentifier">Metadata that identifies the target offer for which the FOEP result data was computed..</param>
        /// <param name="featuredOfferExpectedPriceResults">The FOEP results for the requested target offer..</param>
        /// <param name="errors">The errors that occurred if the operation wasn&#39;t successful (HTTP status code non-200)..</param>
        public FeaturedOfferExpectedPriceResponseBody(OfferIdentifier offerIdentifier = default, FeaturedOfferExpectedPriceResultList featuredOfferExpectedPriceResults = default, ErrorList errors = default)
        {
            this.OfferIdentifier = offerIdentifier;
            this.FeaturedOfferExpectedPriceResults = featuredOfferExpectedPriceResults;
            this.Errors = errors;
        }

        /// <summary>
        /// Metadata that identifies the target offer for which the FOEP result data was computed.
        /// </summary>
        /// <value>Metadata that identifies the target offer for which the FOEP result data was computed.</value>
        [DataMember(Name = "offerIdentifier", EmitDefaultValue = false)]
        public OfferIdentifier OfferIdentifier { get; set; }

        /// <summary>
        /// The FOEP results for the requested target offer.
        /// </summary>
        /// <value>The FOEP results for the requested target offer.</value>
        [DataMember(Name = "featuredOfferExpectedPriceResults", EmitDefaultValue = false)]
        public FeaturedOfferExpectedPriceResultList FeaturedOfferExpectedPriceResults { get; set; }

        /// <summary>
        /// The errors that occurred if the operation wasn&#39;t successful (HTTP status code non-200).
        /// </summary>
        /// <value>The errors that occurred if the operation wasn&#39;t successful (HTTP status code non-200).</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeaturedOfferExpectedPriceResponseBody {\n");
            sb.Append("  OfferIdentifier: ").Append(OfferIdentifier).Append("\n");
            sb.Append("  FeaturedOfferExpectedPriceResults: ").Append(FeaturedOfferExpectedPriceResults).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as FeaturedOfferExpectedPriceResponseBody);
        }

        /// <summary>
        /// Returns true if FeaturedOfferExpectedPriceResponseBody instances are equal
        /// </summary>
        /// <param name="input">Instance of FeaturedOfferExpectedPriceResponseBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeaturedOfferExpectedPriceResponseBody input)
        {
            if (input == null)
                return false;

            return
                (
                    this.OfferIdentifier == input.OfferIdentifier ||
                    (this.OfferIdentifier != null &&
                    this.OfferIdentifier.Equals(input.OfferIdentifier))
                ) &&
                (
                    this.FeaturedOfferExpectedPriceResults == input.FeaturedOfferExpectedPriceResults ||
                    (this.FeaturedOfferExpectedPriceResults != null &&
                    this.FeaturedOfferExpectedPriceResults.Equals(input.FeaturedOfferExpectedPriceResults))
                ) &&
                (
                    this.Errors == input.Errors ||
                    (this.Errors != null &&
                    this.Errors.Equals(input.Errors))
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
                if (this.OfferIdentifier != null)
                    hashCode = hashCode * 59 + this.OfferIdentifier.GetHashCode();
                if (this.FeaturedOfferExpectedPriceResults != null)
                    hashCode = hashCode * 59 + this.FeaturedOfferExpectedPriceResults.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
