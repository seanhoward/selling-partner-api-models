/* 
 * Selling Partner API for Retail Procurement Orders
 *
 * The Selling Partner API for Retail Procurement Orders provides programmatic access to vendor orders data.
 *
 * OpenAPI spec version: v1
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorOrders
{
    /// <summary>
    /// Details of the item being acknowledged.
    /// </summary>
    [DataContract]
    public partial class OrderAcknowledgementItem :  IEquatable<OrderAcknowledgementItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAcknowledgementItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderAcknowledgementItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAcknowledgementItem" /> class.
        /// </summary>
        /// <param name="itemSequenceNumber">Line item sequence number for the item..</param>
        /// <param name="amazonProductIdentifier">Amazon Standard Identification Number (ASIN) of an item..</param>
        /// <param name="vendorProductIdentifier">The vendor selected product identification of the item. Should be the same as was sent in the purchase order..</param>
        /// <param name="orderedQuantity">The quantity of this item ordered. (required).</param>
        /// <param name="netCost">The net cost of an item per each or weight unit that must match the cost on the invoice. This is a required field. If left blank, Amazon systems will reject the file. Price information must not be zero or negative..</param>
        /// <param name="listPrice">The list price of an item per each or weight unit. Required only if a vendor sells books at list price..</param>
        /// <param name="discountMultiplier">The discount multiplier that should be applied to the price if a vendor sells books with a list price. This is a multiplier factor to arrive at a final discounted price. A multiplier of .90 would be the factor if a 10% discount is given..</param>
        /// <param name="itemAcknowledgements">This is used to indicate acknowledged quantity. (required).</param>
        public OrderAcknowledgementItem(string itemSequenceNumber = default(string), string amazonProductIdentifier = default(string), string vendorProductIdentifier = default(string), ItemQuantity orderedQuantity = default(ItemQuantity), Money netCost = default(Money), Money listPrice = default(Money), string discountMultiplier = default(string), List<OrderItemAcknowledgement> itemAcknowledgements = default(List<OrderItemAcknowledgement>))
        {
            // to ensure "orderedQuantity" is required (not null)
            if (orderedQuantity == null)
            {
                throw new InvalidDataException("orderedQuantity is a required property for OrderAcknowledgementItem and cannot be null");
            }
            else
            {
                this.OrderedQuantity = orderedQuantity;
            }
            // to ensure "itemAcknowledgements" is required (not null)
            if (itemAcknowledgements == null)
            {
                throw new InvalidDataException("itemAcknowledgements is a required property for OrderAcknowledgementItem and cannot be null");
            }
            else
            {
                this.ItemAcknowledgements = itemAcknowledgements;
            }
            this.ItemSequenceNumber = itemSequenceNumber;
            this.AmazonProductIdentifier = amazonProductIdentifier;
            this.VendorProductIdentifier = vendorProductIdentifier;
            this.NetCost = netCost;
            this.ListPrice = listPrice;
            this.DiscountMultiplier = discountMultiplier;
        }
        
        /// <summary>
        /// Line item sequence number for the item.
        /// </summary>
        /// <value>Line item sequence number for the item.</value>
        [DataMember(Name="itemSequenceNumber", EmitDefaultValue=false)]
        public string ItemSequenceNumber { get; set; }

        /// <summary>
        /// Amazon Standard Identification Number (ASIN) of an item.
        /// </summary>
        /// <value>Amazon Standard Identification Number (ASIN) of an item.</value>
        [DataMember(Name="amazonProductIdentifier", EmitDefaultValue=false)]
        public string AmazonProductIdentifier { get; set; }

        /// <summary>
        /// The vendor selected product identification of the item. Should be the same as was sent in the purchase order.
        /// </summary>
        /// <value>The vendor selected product identification of the item. Should be the same as was sent in the purchase order.</value>
        [DataMember(Name="vendorProductIdentifier", EmitDefaultValue=false)]
        public string VendorProductIdentifier { get; set; }

        /// <summary>
        /// The quantity of this item ordered.
        /// </summary>
        /// <value>The quantity of this item ordered.</value>
        [DataMember(Name="orderedQuantity", EmitDefaultValue=false)]
        public ItemQuantity OrderedQuantity { get; set; }

        /// <summary>
        /// The net cost of an item per each or weight unit that must match the cost on the invoice. This is a required field. If left blank, Amazon systems will reject the file. Price information must not be zero or negative.
        /// </summary>
        /// <value>The net cost of an item per each or weight unit that must match the cost on the invoice. This is a required field. If left blank, Amazon systems will reject the file. Price information must not be zero or negative.</value>
        [DataMember(Name="netCost", EmitDefaultValue=false)]
        public Money NetCost { get; set; }

        /// <summary>
        /// The list price of an item per each or weight unit. Required only if a vendor sells books at list price.
        /// </summary>
        /// <value>The list price of an item per each or weight unit. Required only if a vendor sells books at list price.</value>
        [DataMember(Name="listPrice", EmitDefaultValue=false)]
        public Money ListPrice { get; set; }

        /// <summary>
        /// The discount multiplier that should be applied to the price if a vendor sells books with a list price. This is a multiplier factor to arrive at a final discounted price. A multiplier of .90 would be the factor if a 10% discount is given.
        /// </summary>
        /// <value>The discount multiplier that should be applied to the price if a vendor sells books with a list price. This is a multiplier factor to arrive at a final discounted price. A multiplier of .90 would be the factor if a 10% discount is given.</value>
        [DataMember(Name="discountMultiplier", EmitDefaultValue=false)]
        public string DiscountMultiplier { get; set; }

        /// <summary>
        /// This is used to indicate acknowledged quantity.
        /// </summary>
        /// <value>This is used to indicate acknowledged quantity.</value>
        [DataMember(Name="itemAcknowledgements", EmitDefaultValue=false)]
        public List<OrderItemAcknowledgement> ItemAcknowledgements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderAcknowledgementItem {\n");
            sb.Append("  ItemSequenceNumber: ").Append(ItemSequenceNumber).Append("\n");
            sb.Append("  AmazonProductIdentifier: ").Append(AmazonProductIdentifier).Append("\n");
            sb.Append("  VendorProductIdentifier: ").Append(VendorProductIdentifier).Append("\n");
            sb.Append("  OrderedQuantity: ").Append(OrderedQuantity).Append("\n");
            sb.Append("  NetCost: ").Append(NetCost).Append("\n");
            sb.Append("  ListPrice: ").Append(ListPrice).Append("\n");
            sb.Append("  DiscountMultiplier: ").Append(DiscountMultiplier).Append("\n");
            sb.Append("  ItemAcknowledgements: ").Append(ItemAcknowledgements).Append("\n");
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
            return this.Equals(input as OrderAcknowledgementItem);
        }

        /// <summary>
        /// Returns true if OrderAcknowledgementItem instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderAcknowledgementItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderAcknowledgementItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemSequenceNumber == input.ItemSequenceNumber ||
                    (this.ItemSequenceNumber != null &&
                    this.ItemSequenceNumber.Equals(input.ItemSequenceNumber))
                ) && 
                (
                    this.AmazonProductIdentifier == input.AmazonProductIdentifier ||
                    (this.AmazonProductIdentifier != null &&
                    this.AmazonProductIdentifier.Equals(input.AmazonProductIdentifier))
                ) && 
                (
                    this.VendorProductIdentifier == input.VendorProductIdentifier ||
                    (this.VendorProductIdentifier != null &&
                    this.VendorProductIdentifier.Equals(input.VendorProductIdentifier))
                ) && 
                (
                    this.OrderedQuantity == input.OrderedQuantity ||
                    (this.OrderedQuantity != null &&
                    this.OrderedQuantity.Equals(input.OrderedQuantity))
                ) && 
                (
                    this.NetCost == input.NetCost ||
                    (this.NetCost != null &&
                    this.NetCost.Equals(input.NetCost))
                ) && 
                (
                    this.ListPrice == input.ListPrice ||
                    (this.ListPrice != null &&
                    this.ListPrice.Equals(input.ListPrice))
                ) && 
                (
                    this.DiscountMultiplier == input.DiscountMultiplier ||
                    (this.DiscountMultiplier != null &&
                    this.DiscountMultiplier.Equals(input.DiscountMultiplier))
                ) && 
                (
                    this.ItemAcknowledgements == input.ItemAcknowledgements ||
                    this.ItemAcknowledgements != null &&
                    this.ItemAcknowledgements.SequenceEqual(input.ItemAcknowledgements)
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
                if (this.ItemSequenceNumber != null)
                    hashCode = hashCode * 59 + this.ItemSequenceNumber.GetHashCode();
                if (this.AmazonProductIdentifier != null)
                    hashCode = hashCode * 59 + this.AmazonProductIdentifier.GetHashCode();
                if (this.VendorProductIdentifier != null)
                    hashCode = hashCode * 59 + this.VendorProductIdentifier.GetHashCode();
                if (this.OrderedQuantity != null)
                    hashCode = hashCode * 59 + this.OrderedQuantity.GetHashCode();
                if (this.NetCost != null)
                    hashCode = hashCode * 59 + this.NetCost.GetHashCode();
                if (this.ListPrice != null)
                    hashCode = hashCode * 59 + this.ListPrice.GetHashCode();
                if (this.DiscountMultiplier != null)
                    hashCode = hashCode * 59 + this.DiscountMultiplier.GetHashCode();
                if (this.ItemAcknowledgements != null)
                    hashCode = hashCode * 59 + this.ItemAcknowledgements.GetHashCode();
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
