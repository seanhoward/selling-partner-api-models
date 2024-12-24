/* 
 * Vendor Shipments v1
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
    /// Item details for be provided for every item in shipment at either the item or carton or pallet level, whichever is appropriate.
    /// </summary>
    [DataContract]
    public partial class ItemDetails :  IEquatable<ItemDetails>, IValidatableObject
    {
        /// <summary>
        /// Identification of the instructions on how specified item/carton/pallet should be handled.
        /// </summary>
        /// <value>Identification of the instructions on how specified item/carton/pallet should be handled.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HandlingCodeEnum
        {
            
            /// <summary>
            /// Enum Oversized for value: Oversized
            /// </summary>
            [EnumMember(Value = "Oversized")]
            Oversized = 1,
            
            /// <summary>
            /// Enum Fragile for value: Fragile
            /// </summary>
            [EnumMember(Value = "Fragile")]
            Fragile = 2,
            
            /// <summary>
            /// Enum Food for value: Food
            /// </summary>
            [EnumMember(Value = "Food")]
            Food = 3,
            
            /// <summary>
            /// Enum HandleWithCare for value: HandleWithCare
            /// </summary>
            [EnumMember(Value = "HandleWithCare")]
            HandleWithCare = 4
        }

        /// <summary>
        /// Identification of the instructions on how specified item/carton/pallet should be handled.
        /// </summary>
        /// <value>Identification of the instructions on how specified item/carton/pallet should be handled.</value>
        [DataMember(Name="handlingCode", EmitDefaultValue=false)]
        public HandlingCodeEnum? HandlingCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDetails" /> class.
        /// </summary>
        /// <param name="purchaseOrderNumber">The purchase order number for the shipment being confirmed. If the items in this shipment belong to multiple purchase order numbers that are in particular carton or pallet within the shipment, then provide the purchaseOrderNumber at the appropriate carton or pallet level. Formatting Notes: 8-character alpha-numeric code..</param>
        /// <param name="lotNumber">The batch or lot number associates an item with information the manufacturer considers relevant for traceability of the trade item to which the Element String is applied. The data may refer to the trade item itself or to items contained. This field is mandatory for all perishable items..</param>
        /// <param name="expiry">Expiry refers to the collection of dates required  for certain items. These could be either expiryDate or mfgDate and expiryAfterDuration. These are mandatory for perishable items..</param>
        /// <param name="maximumRetailPrice">Maximum retail price of the item being shipped..</param>
        /// <param name="handlingCode">Identification of the instructions on how specified item/carton/pallet should be handled..</param>
        public ItemDetails(string purchaseOrderNumber = default(string), string lotNumber = default(string), Expiry expiry = default(Expiry), Money maximumRetailPrice = default(Money), HandlingCodeEnum? handlingCode = default(HandlingCodeEnum?))
        {
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.LotNumber = lotNumber;
            this.Expiry = expiry;
            this.MaximumRetailPrice = maximumRetailPrice;
            this.HandlingCode = handlingCode;
        }
        
        /// <summary>
        /// The purchase order number for the shipment being confirmed. If the items in this shipment belong to multiple purchase order numbers that are in particular carton or pallet within the shipment, then provide the purchaseOrderNumber at the appropriate carton or pallet level. Formatting Notes: 8-character alpha-numeric code.
        /// </summary>
        /// <value>The purchase order number for the shipment being confirmed. If the items in this shipment belong to multiple purchase order numbers that are in particular carton or pallet within the shipment, then provide the purchaseOrderNumber at the appropriate carton or pallet level. Formatting Notes: 8-character alpha-numeric code.</value>
        [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The batch or lot number associates an item with information the manufacturer considers relevant for traceability of the trade item to which the Element String is applied. The data may refer to the trade item itself or to items contained. This field is mandatory for all perishable items.
        /// </summary>
        /// <value>The batch or lot number associates an item with information the manufacturer considers relevant for traceability of the trade item to which the Element String is applied. The data may refer to the trade item itself or to items contained. This field is mandatory for all perishable items.</value>
        [DataMember(Name="lotNumber", EmitDefaultValue=false)]
        public string LotNumber { get; set; }

        /// <summary>
        /// Expiry refers to the collection of dates required  for certain items. These could be either expiryDate or mfgDate and expiryAfterDuration. These are mandatory for perishable items.
        /// </summary>
        /// <value>Expiry refers to the collection of dates required  for certain items. These could be either expiryDate or mfgDate and expiryAfterDuration. These are mandatory for perishable items.</value>
        [DataMember(Name="expiry", EmitDefaultValue=false)]
        public Expiry Expiry { get; set; }

        /// <summary>
        /// Maximum retail price of the item being shipped.
        /// </summary>
        /// <value>Maximum retail price of the item being shipped.</value>
        [DataMember(Name="maximumRetailPrice", EmitDefaultValue=false)]
        public Money MaximumRetailPrice { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemDetails {\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  LotNumber: ").Append(LotNumber).Append("\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
            sb.Append("  MaximumRetailPrice: ").Append(MaximumRetailPrice).Append("\n");
            sb.Append("  HandlingCode: ").Append(HandlingCode).Append("\n");
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
            return this.Equals(input as ItemDetails);
        }

        /// <summary>
        /// Returns true if ItemDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) && 
                (
                    this.LotNumber == input.LotNumber ||
                    (this.LotNumber != null &&
                    this.LotNumber.Equals(input.LotNumber))
                ) && 
                (
                    this.Expiry == input.Expiry ||
                    (this.Expiry != null &&
                    this.Expiry.Equals(input.Expiry))
                ) && 
                (
                    this.MaximumRetailPrice == input.MaximumRetailPrice ||
                    (this.MaximumRetailPrice != null &&
                    this.MaximumRetailPrice.Equals(input.MaximumRetailPrice))
                ) && 
                (
                    this.HandlingCode == input.HandlingCode ||
                    (this.HandlingCode != null &&
                    this.HandlingCode.Equals(input.HandlingCode))
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
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.LotNumber != null)
                    hashCode = hashCode * 59 + this.LotNumber.GetHashCode();
                if (this.Expiry != null)
                    hashCode = hashCode * 59 + this.Expiry.GetHashCode();
                if (this.MaximumRetailPrice != null)
                    hashCode = hashCode * 59 + this.MaximumRetailPrice.GetHashCode();
                if (this.HandlingCode != null)
                    hashCode = hashCode * 59 + this.HandlingCode.GetHashCode();
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
