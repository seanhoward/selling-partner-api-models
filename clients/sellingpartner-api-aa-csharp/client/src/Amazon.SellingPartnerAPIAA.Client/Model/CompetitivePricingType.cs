/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Amazon.SellingPartnerAPIAA.Client.Model
{
    /// <summary>
    /// Competitive pricing information for the item.
    /// </summary>
    [DataContract]
    public partial class CompetitivePricingType : IEquatable<CompetitivePricingType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitivePricingType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompetitivePricingType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitivePricingType" /> class.
        /// </summary>
        /// <param name="competitivePrices">competitivePrices (required).</param>
        /// <param name="numberOfOfferListings">numberOfOfferListings (required).</param>
        /// <param name="tradeInValue">The trade-in value of the item in the trade-in program..</param>
        public CompetitivePricingType(CompetitivePriceList competitivePrices = default(CompetitivePriceList), NumberOfOfferListingsList numberOfOfferListings = default(NumberOfOfferListingsList), MoneyType tradeInValue = default(MoneyType))
        {
            // to ensure "competitivePrices" is required (not null)
            if (competitivePrices == null)
            {
                throw new InvalidDataException("competitivePrices is a required property for CompetitivePricingType and cannot be null");
            }
            else
            {
                this.CompetitivePrices = competitivePrices;
            }
            // to ensure "numberOfOfferListings" is required (not null)
            if (numberOfOfferListings == null)
            {
                throw new InvalidDataException("numberOfOfferListings is a required property for CompetitivePricingType and cannot be null");
            }
            else
            {
                this.NumberOfOfferListings = numberOfOfferListings;
            }
            this.TradeInValue = tradeInValue;
        }

        /// <summary>
        /// Gets or Sets CompetitivePrices
        /// </summary>
        [DataMember(Name = "CompetitivePrices", EmitDefaultValue = false)]
        public CompetitivePriceList CompetitivePrices { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfOfferListings
        /// </summary>
        [DataMember(Name = "NumberOfOfferListings", EmitDefaultValue = false)]
        public NumberOfOfferListingsList NumberOfOfferListings { get; set; }

        /// <summary>
        /// The trade-in value of the item in the trade-in program.
        /// </summary>
        /// <value>The trade-in value of the item in the trade-in program.</value>
        [DataMember(Name = "TradeInValue", EmitDefaultValue = false)]
        public MoneyType TradeInValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompetitivePricingType {\n");
            sb.Append("  CompetitivePrices: ").Append(CompetitivePrices).Append("\n");
            sb.Append("  NumberOfOfferListings: ").Append(NumberOfOfferListings).Append("\n");
            sb.Append("  TradeInValue: ").Append(TradeInValue).Append("\n");
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
            return this.Equals(input as CompetitivePricingType);
        }

        /// <summary>
        /// Returns true if CompetitivePricingType instances are equal
        /// </summary>
        /// <param name="input">Instance of CompetitivePricingType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompetitivePricingType input)
        {
            if (input == null)
                return false;

            return
                (
                    this.CompetitivePrices == input.CompetitivePrices ||
                    (this.CompetitivePrices != null &&
                    this.CompetitivePrices.Equals(input.CompetitivePrices))
                ) &&
                (
                    this.NumberOfOfferListings == input.NumberOfOfferListings ||
                    (this.NumberOfOfferListings != null &&
                    this.NumberOfOfferListings.Equals(input.NumberOfOfferListings))
                ) &&
                (
                    this.TradeInValue == input.TradeInValue ||
                    (this.TradeInValue != null &&
                    this.TradeInValue.Equals(input.TradeInValue))
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
                if (this.CompetitivePrices != null)
                    hashCode = hashCode * 59 + this.CompetitivePrices.GetHashCode();
                if (this.NumberOfOfferListings != null)
                    hashCode = hashCode * 59 + this.NumberOfOfferListings.GetHashCode();
                if (this.TradeInValue != null)
                    hashCode = hashCode * 59 + this.TradeInValue.GetHashCode();
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
