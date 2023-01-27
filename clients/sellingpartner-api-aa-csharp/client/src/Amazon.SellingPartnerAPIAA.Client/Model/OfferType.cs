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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Amazon.SellingPartnerAPIAA.Client.Model
{
    /// <summary>
    /// OfferType
    /// </summary>
    [DataContract]
    public partial class OfferType : IEquatable<OfferType>, IValidatableObject
    {
        /// <summary>
        /// Indicates the type of customer that the offer is valid for.
        /// </summary>
        /// <value>Indicates the type of customer that the offer is valid for.</value>
        [DataMember(Name = "offerType", EmitDefaultValue = false)]
        public OfferCustomerType? _OfferType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OfferType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferType" /> class.
        /// </summary>
        /// <param name="offerType">Indicates the type of customer that the offer is valid for..</param>
        /// <param name="buyingPrice">Contains pricing information that includes promotions and contains the shipping cost. (required).</param>
        /// <param name="regularPrice">The current price excluding any promotions that apply to the product. Excludes the shipping cost. (required).</param>
        /// <param name="businessPrice">The current listing price for Business buyers..</param>
        /// <param name="quantityDiscountPrices">quantityDiscountPrices.</param>
        /// <param name="fulfillmentChannel">The fulfillment channel for the offer listing. Possible values:  * Amazon - Fulfilled by Amazon. * Merchant - Fulfilled by the seller. (required).</param>
        /// <param name="itemCondition">The item condition for the offer listing. Possible values: New, Used, Collectible, Refurbished, or Club. (required).</param>
        /// <param name="itemSubCondition">The item subcondition for the offer listing. Possible values: New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box, or Other. (required).</param>
        /// <param name="sellerSKU">The seller stock keeping unit (SKU) of the item. (required).</param>
        public OfferType(OfferCustomerType? offerType = default(OfferCustomerType?), PriceType buyingPrice = default(PriceType), MoneyType regularPrice = default(MoneyType), MoneyType businessPrice = default(MoneyType), List<QuantityDiscountPriceType> quantityDiscountPrices = default(List<QuantityDiscountPriceType>), string fulfillmentChannel = default(string), string itemCondition = default(string), string itemSubCondition = default(string), string sellerSKU = default(string))
        {
            // to ensure "buyingPrice" is required (not null)
            if (buyingPrice == null)
            {
                throw new InvalidDataException("buyingPrice is a required property for OfferType and cannot be null");
            }
            else
            {
                this.BuyingPrice = buyingPrice;
            }
            // to ensure "regularPrice" is required (not null)
            if (regularPrice == null)
            {
                throw new InvalidDataException("regularPrice is a required property for OfferType and cannot be null");
            }
            else
            {
                this.RegularPrice = regularPrice;
            }
            // to ensure "fulfillmentChannel" is required (not null)
            if (fulfillmentChannel == null)
            {
                throw new InvalidDataException("fulfillmentChannel is a required property for OfferType and cannot be null");
            }
            else
            {
                this.FulfillmentChannel = fulfillmentChannel;
            }
            // to ensure "itemCondition" is required (not null)
            if (itemCondition == null)
            {
                throw new InvalidDataException("itemCondition is a required property for OfferType and cannot be null");
            }
            else
            {
                this.ItemCondition = itemCondition;
            }
            // to ensure "itemSubCondition" is required (not null)
            if (itemSubCondition == null)
            {
                throw new InvalidDataException("itemSubCondition is a required property for OfferType and cannot be null");
            }
            else
            {
                this.ItemSubCondition = itemSubCondition;
            }
            // to ensure "sellerSKU" is required (not null)
            if (sellerSKU == null)
            {
                throw new InvalidDataException("sellerSKU is a required property for OfferType and cannot be null");
            }
            else
            {
                this.SellerSKU = sellerSKU;
            }
            this._OfferType = offerType;
            this.BusinessPrice = businessPrice;
            this.QuantityDiscountPrices = quantityDiscountPrices;
        }


        /// <summary>
        /// Contains pricing information that includes promotions and contains the shipping cost.
        /// </summary>
        /// <value>Contains pricing information that includes promotions and contains the shipping cost.</value>
        [DataMember(Name = "BuyingPrice", EmitDefaultValue = false)]
        public PriceType BuyingPrice { get; set; }

        /// <summary>
        /// The current price excluding any promotions that apply to the product. Excludes the shipping cost.
        /// </summary>
        /// <value>The current price excluding any promotions that apply to the product. Excludes the shipping cost.</value>
        [DataMember(Name = "RegularPrice", EmitDefaultValue = false)]
        public MoneyType RegularPrice { get; set; }

        /// <summary>
        /// The current listing price for Business buyers.
        /// </summary>
        /// <value>The current listing price for Business buyers.</value>
        [DataMember(Name = "businessPrice", EmitDefaultValue = false)]
        public MoneyType BusinessPrice { get; set; }

        /// <summary>
        /// Gets or Sets QuantityDiscountPrices
        /// </summary>
        [DataMember(Name = "quantityDiscountPrices", EmitDefaultValue = false)]
        public List<QuantityDiscountPriceType> QuantityDiscountPrices { get; set; }

        /// <summary>
        /// The fulfillment channel for the offer listing. Possible values:  * Amazon - Fulfilled by Amazon. * Merchant - Fulfilled by the seller.
        /// </summary>
        /// <value>The fulfillment channel for the offer listing. Possible values:  * Amazon - Fulfilled by Amazon. * Merchant - Fulfilled by the seller.</value>
        [DataMember(Name = "FulfillmentChannel", EmitDefaultValue = false)]
        public string FulfillmentChannel { get; set; }

        /// <summary>
        /// The item condition for the offer listing. Possible values: New, Used, Collectible, Refurbished, or Club.
        /// </summary>
        /// <value>The item condition for the offer listing. Possible values: New, Used, Collectible, Refurbished, or Club.</value>
        [DataMember(Name = "ItemCondition", EmitDefaultValue = false)]
        public string ItemCondition { get; set; }

        /// <summary>
        /// The item subcondition for the offer listing. Possible values: New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box, or Other.
        /// </summary>
        /// <value>The item subcondition for the offer listing. Possible values: New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box, or Other.</value>
        [DataMember(Name = "ItemSubCondition", EmitDefaultValue = false)]
        public string ItemSubCondition { get; set; }

        /// <summary>
        /// The seller stock keeping unit (SKU) of the item.
        /// </summary>
        /// <value>The seller stock keeping unit (SKU) of the item.</value>
        [DataMember(Name = "SellerSKU", EmitDefaultValue = false)]
        public string SellerSKU { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferType {\n");
            sb.Append("  _OfferType: ").Append(_OfferType).Append("\n");
            sb.Append("  BuyingPrice: ").Append(BuyingPrice).Append("\n");
            sb.Append("  RegularPrice: ").Append(RegularPrice).Append("\n");
            sb.Append("  BusinessPrice: ").Append(BusinessPrice).Append("\n");
            sb.Append("  QuantityDiscountPrices: ").Append(QuantityDiscountPrices).Append("\n");
            sb.Append("  FulfillmentChannel: ").Append(FulfillmentChannel).Append("\n");
            sb.Append("  ItemCondition: ").Append(ItemCondition).Append("\n");
            sb.Append("  ItemSubCondition: ").Append(ItemSubCondition).Append("\n");
            sb.Append("  SellerSKU: ").Append(SellerSKU).Append("\n");
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
            return this.Equals(input as OfferType);
        }

        /// <summary>
        /// Returns true if OfferType instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferType input)
        {
            if (input == null)
                return false;

            return
                (
                    this._OfferType == input._OfferType ||
                    (this._OfferType != null &&
                    this._OfferType.Equals(input._OfferType))
                ) &&
                (
                    this.BuyingPrice == input.BuyingPrice ||
                    (this.BuyingPrice != null &&
                    this.BuyingPrice.Equals(input.BuyingPrice))
                ) &&
                (
                    this.RegularPrice == input.RegularPrice ||
                    (this.RegularPrice != null &&
                    this.RegularPrice.Equals(input.RegularPrice))
                ) &&
                (
                    this.BusinessPrice == input.BusinessPrice ||
                    (this.BusinessPrice != null &&
                    this.BusinessPrice.Equals(input.BusinessPrice))
                ) &&
                (
                    this.QuantityDiscountPrices == input.QuantityDiscountPrices ||
                    this.QuantityDiscountPrices != null &&
                    this.QuantityDiscountPrices.SequenceEqual(input.QuantityDiscountPrices)
                ) &&
                (
                    this.FulfillmentChannel == input.FulfillmentChannel ||
                    (this.FulfillmentChannel != null &&
                    this.FulfillmentChannel.Equals(input.FulfillmentChannel))
                ) &&
                (
                    this.ItemCondition == input.ItemCondition ||
                    (this.ItemCondition != null &&
                    this.ItemCondition.Equals(input.ItemCondition))
                ) &&
                (
                    this.ItemSubCondition == input.ItemSubCondition ||
                    (this.ItemSubCondition != null &&
                    this.ItemSubCondition.Equals(input.ItemSubCondition))
                ) &&
                (
                    this.SellerSKU == input.SellerSKU ||
                    (this.SellerSKU != null &&
                    this.SellerSKU.Equals(input.SellerSKU))
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
                if (this._OfferType != null)
                    hashCode = hashCode * 59 + this._OfferType.GetHashCode();
                if (this.BuyingPrice != null)
                    hashCode = hashCode * 59 + this.BuyingPrice.GetHashCode();
                if (this.RegularPrice != null)
                    hashCode = hashCode * 59 + this.RegularPrice.GetHashCode();
                if (this.BusinessPrice != null)
                    hashCode = hashCode * 59 + this.BusinessPrice.GetHashCode();
                if (this.QuantityDiscountPrices != null)
                    hashCode = hashCode * 59 + this.QuantityDiscountPrices.GetHashCode();
                if (this.FulfillmentChannel != null)
                    hashCode = hashCode * 59 + this.FulfillmentChannel.GetHashCode();
                if (this.ItemCondition != null)
                    hashCode = hashCode * 59 + this.ItemCondition.GetHashCode();
                if (this.ItemSubCondition != null)
                    hashCode = hashCode * 59 + this.ItemSubCondition.GetHashCode();
                if (this.SellerSKU != null)
                    hashCode = hashCode * 59 + this.SellerSKU.GetHashCode();
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
