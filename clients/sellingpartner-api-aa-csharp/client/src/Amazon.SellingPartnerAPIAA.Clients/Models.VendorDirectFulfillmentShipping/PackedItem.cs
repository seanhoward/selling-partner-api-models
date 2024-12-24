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
    /// An item that has been packed into a container for shipping.
    /// </summary>
    [DataContract]
    public partial class PackedItem :  IEquatable<PackedItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackedItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PackedItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackedItem" /> class.
        /// </summary>
        /// <param name="itemSequenceNumber">The sequence number of the item. The number must be the same as the order number of the item. (required).</param>
        /// <param name="buyerProductIdentifier">The buyer&#39;s Amazon Standard Identification Number (ASIN) of an item. Either &#x60;buyerProductIdentifier&#x60; or &#x60;vendorProductIdentifier&#x60; is required..</param>
        /// <param name="pieceNumber">The piece number of the item in this container. This is required when the item is split across different containers..</param>
        /// <param name="vendorProductIdentifier">An item&#39;s product identifier, which the vendor selects. This identifier should be the same as the identifier, such as a SKU, in the purchase order..</param>
        /// <param name="packedQuantity">The total quantity of items that are packed in the shipment. (required).</param>
        public PackedItem(int? itemSequenceNumber = default(int?), string buyerProductIdentifier = default(string), int? pieceNumber = default(int?), string vendorProductIdentifier = default(string), ItemQuantity packedQuantity = default(ItemQuantity))
        {
            // to ensure "itemSequenceNumber" is required (not null)
            if (itemSequenceNumber == null)
            {
                throw new InvalidDataException("itemSequenceNumber is a required property for PackedItem and cannot be null");
            }
            else
            {
                this.ItemSequenceNumber = itemSequenceNumber;
            }
            // to ensure "packedQuantity" is required (not null)
            if (packedQuantity == null)
            {
                throw new InvalidDataException("packedQuantity is a required property for PackedItem and cannot be null");
            }
            else
            {
                this.PackedQuantity = packedQuantity;
            }
            this.BuyerProductIdentifier = buyerProductIdentifier;
            this.PieceNumber = pieceNumber;
            this.VendorProductIdentifier = vendorProductIdentifier;
        }
        
        /// <summary>
        /// The sequence number of the item. The number must be the same as the order number of the item.
        /// </summary>
        /// <value>The sequence number of the item. The number must be the same as the order number of the item.</value>
        [DataMember(Name="itemSequenceNumber", EmitDefaultValue=false)]
        public int? ItemSequenceNumber { get; set; }

        /// <summary>
        /// The buyer&#39;s Amazon Standard Identification Number (ASIN) of an item. Either &#x60;buyerProductIdentifier&#x60; or &#x60;vendorProductIdentifier&#x60; is required.
        /// </summary>
        /// <value>The buyer&#39;s Amazon Standard Identification Number (ASIN) of an item. Either &#x60;buyerProductIdentifier&#x60; or &#x60;vendorProductIdentifier&#x60; is required.</value>
        [DataMember(Name="buyerProductIdentifier", EmitDefaultValue=false)]
        public string BuyerProductIdentifier { get; set; }

        /// <summary>
        /// The piece number of the item in this container. This is required when the item is split across different containers.
        /// </summary>
        /// <value>The piece number of the item in this container. This is required when the item is split across different containers.</value>
        [DataMember(Name="pieceNumber", EmitDefaultValue=false)]
        public int? PieceNumber { get; set; }

        /// <summary>
        /// An item&#39;s product identifier, which the vendor selects. This identifier should be the same as the identifier, such as a SKU, in the purchase order.
        /// </summary>
        /// <value>An item&#39;s product identifier, which the vendor selects. This identifier should be the same as the identifier, such as a SKU, in the purchase order.</value>
        [DataMember(Name="vendorProductIdentifier", EmitDefaultValue=false)]
        public string VendorProductIdentifier { get; set; }

        /// <summary>
        /// The total quantity of items that are packed in the shipment.
        /// </summary>
        /// <value>The total quantity of items that are packed in the shipment.</value>
        [DataMember(Name="packedQuantity", EmitDefaultValue=false)]
        public ItemQuantity PackedQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackedItem {\n");
            sb.Append("  ItemSequenceNumber: ").Append(ItemSequenceNumber).Append("\n");
            sb.Append("  BuyerProductIdentifier: ").Append(BuyerProductIdentifier).Append("\n");
            sb.Append("  PieceNumber: ").Append(PieceNumber).Append("\n");
            sb.Append("  VendorProductIdentifier: ").Append(VendorProductIdentifier).Append("\n");
            sb.Append("  PackedQuantity: ").Append(PackedQuantity).Append("\n");
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
            return this.Equals(input as PackedItem);
        }

        /// <summary>
        /// Returns true if PackedItem instances are equal
        /// </summary>
        /// <param name="input">Instance of PackedItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackedItem input)
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
                    this.BuyerProductIdentifier == input.BuyerProductIdentifier ||
                    (this.BuyerProductIdentifier != null &&
                    this.BuyerProductIdentifier.Equals(input.BuyerProductIdentifier))
                ) && 
                (
                    this.PieceNumber == input.PieceNumber ||
                    (this.PieceNumber != null &&
                    this.PieceNumber.Equals(input.PieceNumber))
                ) && 
                (
                    this.VendorProductIdentifier == input.VendorProductIdentifier ||
                    (this.VendorProductIdentifier != null &&
                    this.VendorProductIdentifier.Equals(input.VendorProductIdentifier))
                ) && 
                (
                    this.PackedQuantity == input.PackedQuantity ||
                    (this.PackedQuantity != null &&
                    this.PackedQuantity.Equals(input.PackedQuantity))
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
                if (this.BuyerProductIdentifier != null)
                    hashCode = hashCode * 59 + this.BuyerProductIdentifier.GetHashCode();
                if (this.PieceNumber != null)
                    hashCode = hashCode * 59 + this.PieceNumber.GetHashCode();
                if (this.VendorProductIdentifier != null)
                    hashCode = hashCode * 59 + this.VendorProductIdentifier.GetHashCode();
                if (this.PackedQuantity != null)
                    hashCode = hashCode * 59 + this.PackedQuantity.GetHashCode();
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
