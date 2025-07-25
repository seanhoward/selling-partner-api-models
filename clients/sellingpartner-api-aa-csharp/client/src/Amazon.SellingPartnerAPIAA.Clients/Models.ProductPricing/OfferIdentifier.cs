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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.ProductPricing
{
    /// <summary>
    /// Identifies an offer from a particular seller for a specified ASIN.
    /// </summary>
    [DataContract]
    public partial class OfferIdentifier : IEquatable<OfferIdentifier>, IValidatableObject
    {
        /// <summary>
        /// The fulfillment type for the offer.
        /// </summary>
        /// <value>The fulfillment type for the offer.</value>
        [DataMember(Name = "fulfillmentType", EmitDefaultValue = false)]
        public FulfillmentType? FulfillmentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferIdentifier" /> class.
        /// </summary>
        [JsonConstructor]
        protected OfferIdentifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferIdentifier" /> class.
        /// </summary>
        /// <param name="marketplaceId">A marketplace identifier. (required).</param>
        /// <param name="sellerId">The seller identifier for the offer..</param>
        /// <param name="sku">The seller SKU of the item. This will only be present for the target offer, which belongs to the requesting seller..</param>
        /// <param name="asin">The Amazon identifier for the item. (required).</param>
        /// <param name="fulfillmentType">The fulfillment type for the offer..</param>
        public OfferIdentifier(string marketplaceId = default, string sellerId = default, string sku = default, string asin = default, FulfillmentType? fulfillmentType = default)
        {
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for OfferIdentifier and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            // to ensure "asin" is required (not null)
            if (asin == null)
            {
                throw new InvalidDataException("asin is a required property for OfferIdentifier and cannot be null");
            }
            else
            {
                this.Asin = asin;
            }
            this.SellerId = sellerId;
            this.Sku = sku;
            this.FulfillmentType = fulfillmentType;
        }

        /// <summary>
        /// A marketplace identifier.
        /// </summary>
        /// <value>A marketplace identifier.</value>
        [DataMember(Name = "marketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The seller identifier for the offer.
        /// </summary>
        /// <value>The seller identifier for the offer.</value>
        [DataMember(Name = "sellerId", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// The seller SKU of the item. This will only be present for the target offer, which belongs to the requesting seller.
        /// </summary>
        /// <value>The seller SKU of the item. This will only be present for the target offer, which belongs to the requesting seller.</value>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// The Amazon identifier for the item.
        /// </summary>
        /// <value>The Amazon identifier for the item.</value>
        [DataMember(Name = "asin", EmitDefaultValue = false)]
        public string Asin { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferIdentifier {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Asin: ").Append(Asin).Append("\n");
            sb.Append("  FulfillmentType: ").Append(FulfillmentType).Append("\n");
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
            return this.Equals(input as OfferIdentifier);
        }

        /// <summary>
        /// Returns true if OfferIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferIdentifier input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) &&
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) &&
                (
                    this.Asin == input.Asin ||
                    (this.Asin != null &&
                    this.Asin.Equals(input.Asin))
                ) &&
                (
                    this.FulfillmentType == input.FulfillmentType ||
                    (this.FulfillmentType != null &&
                    this.FulfillmentType.Equals(input.FulfillmentType))
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
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.SellerId != null)
                    hashCode = hashCode * 59 + this.SellerId.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Asin != null)
                    hashCode = hashCode * 59 + this.Asin.GetHashCode();
                if (this.FulfillmentType != null)
                    hashCode = hashCode * 59 + this.FulfillmentType.GetHashCode();
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
