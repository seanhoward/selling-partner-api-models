/* 
 * Selling Partner API for Retail Procurement Shipments
 *
 * The Selling Partner API for Retail Procurement Shipments provides programmatic access to retail shipping data for vendors.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorShipments
{
    /// <summary>
    /// Details of the item being shipped.
    /// </summary>
    [DataContract]
    public partial class PackedItems :  IEquatable<PackedItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackedItems" /> class.
        /// </summary>
        /// <param name="itemSequenceNumber">Item sequence number for the item. The first item will be 001, the second 002, and so on. This number is used as a reference to refer to this item from the carton or pallet level..</param>
        /// <param name="buyerProductIdentifier">Buyer Standard Identification Number (ASIN) of an item..</param>
        /// <param name="vendorProductIdentifier">The vendor selected product identification of the item. Should be the same as was sent in the purchase order..</param>
        /// <param name="packedQuantity">Total item quantity shipped in this shipment..</param>
        /// <param name="itemDetails">itemDetails.</param>
        public PackedItems(string itemSequenceNumber = default(string), string buyerProductIdentifier = default(string), string vendorProductIdentifier = default(string), ItemQuantity packedQuantity = default(ItemQuantity), PackageItemDetails itemDetails = default(PackageItemDetails))
        {
            this.ItemSequenceNumber = itemSequenceNumber;
            this.BuyerProductIdentifier = buyerProductIdentifier;
            this.VendorProductIdentifier = vendorProductIdentifier;
            this.PackedQuantity = packedQuantity;
            this.ItemDetails = itemDetails;
        }
        
        /// <summary>
        /// Item sequence number for the item. The first item will be 001, the second 002, and so on. This number is used as a reference to refer to this item from the carton or pallet level.
        /// </summary>
        /// <value>Item sequence number for the item. The first item will be 001, the second 002, and so on. This number is used as a reference to refer to this item from the carton or pallet level.</value>
        [DataMember(Name="itemSequenceNumber", EmitDefaultValue=false)]
        public string ItemSequenceNumber { get; set; }

        /// <summary>
        /// Buyer Standard Identification Number (ASIN) of an item.
        /// </summary>
        /// <value>Buyer Standard Identification Number (ASIN) of an item.</value>
        [DataMember(Name="buyerProductIdentifier", EmitDefaultValue=false)]
        public string BuyerProductIdentifier { get; set; }

        /// <summary>
        /// The vendor selected product identification of the item. Should be the same as was sent in the purchase order.
        /// </summary>
        /// <value>The vendor selected product identification of the item. Should be the same as was sent in the purchase order.</value>
        [DataMember(Name="vendorProductIdentifier", EmitDefaultValue=false)]
        public string VendorProductIdentifier { get; set; }

        /// <summary>
        /// Total item quantity shipped in this shipment.
        /// </summary>
        /// <value>Total item quantity shipped in this shipment.</value>
        [DataMember(Name="packedQuantity", EmitDefaultValue=false)]
        public ItemQuantity PackedQuantity { get; set; }

        /// <summary>
        /// Gets or Sets ItemDetails
        /// </summary>
        [DataMember(Name="itemDetails", EmitDefaultValue=false)]
        public PackageItemDetails ItemDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackedItems {\n");
            sb.Append("  ItemSequenceNumber: ").Append(ItemSequenceNumber).Append("\n");
            sb.Append("  BuyerProductIdentifier: ").Append(BuyerProductIdentifier).Append("\n");
            sb.Append("  VendorProductIdentifier: ").Append(VendorProductIdentifier).Append("\n");
            sb.Append("  PackedQuantity: ").Append(PackedQuantity).Append("\n");
            sb.Append("  ItemDetails: ").Append(ItemDetails).Append("\n");
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
            return this.Equals(input as PackedItems);
        }

        /// <summary>
        /// Returns true if PackedItems instances are equal
        /// </summary>
        /// <param name="input">Instance of PackedItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackedItems input)
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
                    this.VendorProductIdentifier == input.VendorProductIdentifier ||
                    (this.VendorProductIdentifier != null &&
                    this.VendorProductIdentifier.Equals(input.VendorProductIdentifier))
                ) && 
                (
                    this.PackedQuantity == input.PackedQuantity ||
                    (this.PackedQuantity != null &&
                    this.PackedQuantity.Equals(input.PackedQuantity))
                ) && 
                (
                    this.ItemDetails == input.ItemDetails ||
                    (this.ItemDetails != null &&
                    this.ItemDetails.Equals(input.ItemDetails))
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
                if (this.VendorProductIdentifier != null)
                    hashCode = hashCode * 59 + this.VendorProductIdentifier.GetHashCode();
                if (this.PackedQuantity != null)
                    hashCode = hashCode * 59 + this.PackedQuantity.GetHashCode();
                if (this.ItemDetails != null)
                    hashCode = hashCode * 59 + this.ItemDetails.GetHashCode();
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