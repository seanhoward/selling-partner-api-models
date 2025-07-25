/* 
 * Selling Partner API for FBA Inventory
 *
 * The Selling Partner API for FBA Inventory lets you programmatically retrieve information about inventory in Amazon's fulfillment network.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FbaInventory
{
    /// <summary>
    /// Inventory summary for a specific item.
    /// </summary>
    [DataContract]
    public partial class InventorySummary : IEquatable<InventorySummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventorySummary" /> class.
        /// </summary>
        /// <param name="asin">The Amazon Standard Identification Number (ASIN) of an item..</param>
        /// <param name="fnSku">Amazon&#39;s fulfillment network SKU identifier..</param>
        /// <param name="sellerSku">The seller SKU of the item..</param>
        /// <param name="condition">The condition of the item as described by the seller (for example, New Item)..</param>
        /// <param name="inventoryDetails">inventoryDetails.</param>
        /// <param name="lastUpdatedTime">The date and time that any quantity was last updated..</param>
        /// <param name="productName">The localized language product title of the item within the specific marketplace..</param>
        /// <param name="totalQuantity">The total number of units in an inbound shipment or in Amazon fulfillment centers..</param>
        /// <param name="stores">A list of seller-enrolled stores that apply to this seller SKU..</param>
        public InventorySummary(string asin = default, string fnSku = default, string sellerSku = default, string condition = default, InventoryDetails inventoryDetails = default, DateTime? lastUpdatedTime = default, string productName = default, int? totalQuantity = default, List<string> stores = default)
        {
            this.Asin = asin;
            this.FnSku = fnSku;
            this.SellerSku = sellerSku;
            this.Condition = condition;
            this.InventoryDetails = inventoryDetails;
            this.LastUpdatedTime = lastUpdatedTime;
            this.ProductName = productName;
            this.TotalQuantity = totalQuantity;
            this.Stores = stores;
        }

        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) of an item.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) of an item.</value>
        [DataMember(Name = "asin", EmitDefaultValue = false)]
        public string Asin { get; set; }

        /// <summary>
        /// Amazon&#39;s fulfillment network SKU identifier.
        /// </summary>
        /// <value>Amazon&#39;s fulfillment network SKU identifier.</value>
        [DataMember(Name = "fnSku", EmitDefaultValue = false)]
        public string FnSku { get; set; }

        /// <summary>
        /// The seller SKU of the item.
        /// </summary>
        /// <value>The seller SKU of the item.</value>
        [DataMember(Name = "sellerSku", EmitDefaultValue = false)]
        public string SellerSku { get; set; }

        /// <summary>
        /// The condition of the item as described by the seller (for example, New Item).
        /// </summary>
        /// <value>The condition of the item as described by the seller (for example, New Item).</value>
        [DataMember(Name = "condition", EmitDefaultValue = false)]
        public string Condition { get; set; }

        /// <summary>
        /// Gets or Sets InventoryDetails
        /// </summary>
        [DataMember(Name = "inventoryDetails", EmitDefaultValue = false)]
        public InventoryDetails InventoryDetails { get; set; }

        /// <summary>
        /// The date and time that any quantity was last updated.
        /// </summary>
        /// <value>The date and time that any quantity was last updated.</value>
        [DataMember(Name = "lastUpdatedTime", EmitDefaultValue = false)]
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// The localized language product title of the item within the specific marketplace.
        /// </summary>
        /// <value>The localized language product title of the item within the specific marketplace.</value>
        [DataMember(Name = "productName", EmitDefaultValue = false)]
        public string ProductName { get; set; }

        /// <summary>
        /// The total number of units in an inbound shipment or in Amazon fulfillment centers.
        /// </summary>
        /// <value>The total number of units in an inbound shipment or in Amazon fulfillment centers.</value>
        [DataMember(Name = "totalQuantity", EmitDefaultValue = false)]
        public int? TotalQuantity { get; set; }

        /// <summary>
        /// A list of seller-enrolled stores that apply to this seller SKU.
        /// </summary>
        /// <value>A list of seller-enrolled stores that apply to this seller SKU.</value>
        [DataMember(Name = "stores", EmitDefaultValue = false)]
        public List<string> Stores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventorySummary {\n");
            sb.Append("  Asin: ").Append(Asin).Append("\n");
            sb.Append("  FnSku: ").Append(FnSku).Append("\n");
            sb.Append("  SellerSku: ").Append(SellerSku).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  InventoryDetails: ").Append(InventoryDetails).Append("\n");
            sb.Append("  LastUpdatedTime: ").Append(LastUpdatedTime).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
            sb.Append("  Stores: ").Append(Stores).Append("\n");
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
            return this.Equals(input as InventorySummary);
        }

        /// <summary>
        /// Returns true if InventorySummary instances are equal
        /// </summary>
        /// <param name="input">Instance of InventorySummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventorySummary input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Asin == input.Asin ||
                    (this.Asin != null &&
                    this.Asin.Equals(input.Asin))
                ) &&
                (
                    this.FnSku == input.FnSku ||
                    (this.FnSku != null &&
                    this.FnSku.Equals(input.FnSku))
                ) &&
                (
                    this.SellerSku == input.SellerSku ||
                    (this.SellerSku != null &&
                    this.SellerSku.Equals(input.SellerSku))
                ) &&
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) &&
                (
                    this.InventoryDetails == input.InventoryDetails ||
                    (this.InventoryDetails != null &&
                    this.InventoryDetails.Equals(input.InventoryDetails))
                ) &&
                (
                    this.LastUpdatedTime == input.LastUpdatedTime ||
                    (this.LastUpdatedTime != null &&
                    this.LastUpdatedTime.Equals(input.LastUpdatedTime))
                ) &&
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) &&
                (
                    this.TotalQuantity == input.TotalQuantity ||
                    (this.TotalQuantity != null &&
                    this.TotalQuantity.Equals(input.TotalQuantity))
                ) &&
                (
                    this.Stores == input.Stores ||
                    this.Stores != null &&
                    this.Stores.SequenceEqual(input.Stores)
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
                if (this.Asin != null)
                    hashCode = hashCode * 59 + this.Asin.GetHashCode();
                if (this.FnSku != null)
                    hashCode = hashCode * 59 + this.FnSku.GetHashCode();
                if (this.SellerSku != null)
                    hashCode = hashCode * 59 + this.SellerSku.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.InventoryDetails != null)
                    hashCode = hashCode * 59 + this.InventoryDetails.GetHashCode();
                if (this.LastUpdatedTime != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTime.GetHashCode();
                if (this.ProductName != null)
                    hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.TotalQuantity != null)
                    hashCode = hashCode * 59 + this.TotalQuantity.GetHashCode();
                if (this.Stores != null)
                    hashCode = hashCode * 59 + this.Stores.GetHashCode();
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
