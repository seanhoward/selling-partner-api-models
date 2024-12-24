/* 
 * Selling Partner API for Direct Fulfillment Inventory Updates
 *
 * The Selling Partner API for Direct Fulfillment Inventory Updates provides programmatic access to a direct fulfillment vendor's inventory updates.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentInventory
{
    /// <summary>
    /// Inventory details required to update some or all items for the requested warehouse.
    /// </summary>
    [DataContract]
    public partial class InventoryUpdate :  IEquatable<InventoryUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InventoryUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryUpdate" /> class.
        /// </summary>
        /// <param name="sellingParty">ID of the selling party or vendor. (required).</param>
        /// <param name="isFullUpdate">When true, this request contains a full feed. Otherwise, this request contains a partial feed. When sending a full feed, you must send information about all items in the warehouse. Any items not in the full feed are updated as not available. When sending a partial feed, only include the items that need an update to inventory. The status of other items will remain unchanged. (required).</param>
        /// <param name="items">A list of inventory items with updated details, including quantity available. (required).</param>
        public InventoryUpdate(PartyIdentification sellingParty = default(PartyIdentification), bool? isFullUpdate = default(bool?), List<ItemDetails> items = default(List<ItemDetails>))
        {
            // to ensure "sellingParty" is required (not null)
            if (sellingParty == null)
            {
                throw new InvalidDataException("sellingParty is a required property for InventoryUpdate and cannot be null");
            }
            else
            {
                this.SellingParty = sellingParty;
            }
            // to ensure "isFullUpdate" is required (not null)
            if (isFullUpdate == null)
            {
                throw new InvalidDataException("isFullUpdate is a required property for InventoryUpdate and cannot be null");
            }
            else
            {
                this.IsFullUpdate = isFullUpdate;
            }
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new InvalidDataException("items is a required property for InventoryUpdate and cannot be null");
            }
            else
            {
                this.Items = items;
            }
        }
        
        /// <summary>
        /// ID of the selling party or vendor.
        /// </summary>
        /// <value>ID of the selling party or vendor.</value>
        [DataMember(Name="sellingParty", EmitDefaultValue=false)]
        public PartyIdentification SellingParty { get; set; }

        /// <summary>
        /// When true, this request contains a full feed. Otherwise, this request contains a partial feed. When sending a full feed, you must send information about all items in the warehouse. Any items not in the full feed are updated as not available. When sending a partial feed, only include the items that need an update to inventory. The status of other items will remain unchanged.
        /// </summary>
        /// <value>When true, this request contains a full feed. Otherwise, this request contains a partial feed. When sending a full feed, you must send information about all items in the warehouse. Any items not in the full feed are updated as not available. When sending a partial feed, only include the items that need an update to inventory. The status of other items will remain unchanged.</value>
        [DataMember(Name="isFullUpdate", EmitDefaultValue=false)]
        public bool? IsFullUpdate { get; set; }

        /// <summary>
        /// A list of inventory items with updated details, including quantity available.
        /// </summary>
        /// <value>A list of inventory items with updated details, including quantity available.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ItemDetails> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryUpdate {\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  IsFullUpdate: ").Append(IsFullUpdate).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as InventoryUpdate);
        }

        /// <summary>
        /// Returns true if InventoryUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SellingParty == input.SellingParty ||
                    (this.SellingParty != null &&
                    this.SellingParty.Equals(input.SellingParty))
                ) && 
                (
                    this.IsFullUpdate == input.IsFullUpdate ||
                    (this.IsFullUpdate != null &&
                    this.IsFullUpdate.Equals(input.IsFullUpdate))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.SellingParty != null)
                    hashCode = hashCode * 59 + this.SellingParty.GetHashCode();
                if (this.IsFullUpdate != null)
                    hashCode = hashCode * 59 + this.IsFullUpdate.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
