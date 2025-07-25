/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * With the Selling Partner API for Merchant Fulfillment, you can build applications that sellers can use to purchase shipping for non-Prime and Prime orders using Amazon's Buy Shipping Services.
 *
 * OpenAPI spec version: v0
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment
{
    /// <summary>
    /// An Amazon order item identifier and a quantity.
    /// </summary>
    [DataContract]
    public partial class Item : IEquatable<Item>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        [JsonConstructor]
        protected Item() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="orderItemId">orderItemId (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="itemWeight">itemWeight.</param>
        /// <param name="itemDescription">itemDescription.</param>
        /// <param name="transparencyCodeList">transparencyCodeList.</param>
        /// <param name="itemLevelSellerInputsList">A list of additional seller inputs required to ship this item using the chosen shipping service..</param>
        /// <param name="liquidVolume">liquidVolume.</param>
        /// <param name="isHazmat">When true, the item qualifies as hazardous materials (hazmat). Defaults to false..</param>
        /// <param name="dangerousGoodsDetails">dangerousGoodsDetails.</param>
        public Item(string orderItemId = default, int? quantity = default, Weight itemWeight = default, string itemDescription = default, TransparencyCodeList transparencyCodeList = default, AdditionalSellerInputsList itemLevelSellerInputsList = default, LiquidVolume liquidVolume = default, bool? isHazmat = default, DangerousGoodsDetails dangerousGoodsDetails = default)
        {
            // to ensure "orderItemId" is required (not null)
            if (orderItemId == null)
            {
                throw new InvalidDataException("orderItemId is a required property for Item and cannot be null");
            }
            else
            {
                this.OrderItemId = orderItemId;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for Item and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            this.ItemWeight = itemWeight;
            this.ItemDescription = itemDescription;
            this.TransparencyCodeList = transparencyCodeList;
            this.ItemLevelSellerInputsList = itemLevelSellerInputsList;
            this.LiquidVolume = liquidVolume;
            this.IsHazmat = isHazmat;
            this.DangerousGoodsDetails = dangerousGoodsDetails;
        }

        /// <summary>
        /// Gets or Sets OrderItemId
        /// </summary>
        [DataMember(Name = "OrderItemId", EmitDefaultValue = false)]
        public string OrderItemId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets ItemWeight
        /// </summary>
        [DataMember(Name = "ItemWeight", EmitDefaultValue = false)]
        public Weight ItemWeight { get; set; }

        /// <summary>
        /// Gets or Sets ItemDescription
        /// </summary>
        [DataMember(Name = "ItemDescription", EmitDefaultValue = false)]
        public string ItemDescription { get; set; }

        /// <summary>
        /// Gets or Sets TransparencyCodeList
        /// </summary>
        [DataMember(Name = "TransparencyCodeList", EmitDefaultValue = false)]
        public TransparencyCodeList TransparencyCodeList { get; set; }

        /// <summary>
        /// A list of additional seller inputs required to ship this item using the chosen shipping service.
        /// </summary>
        /// <value>A list of additional seller inputs required to ship this item using the chosen shipping service.</value>
        [DataMember(Name = "ItemLevelSellerInputsList", EmitDefaultValue = false)]
        public AdditionalSellerInputsList ItemLevelSellerInputsList { get; set; }

        /// <summary>
        /// Gets or Sets LiquidVolume
        /// </summary>
        [DataMember(Name = "LiquidVolume", EmitDefaultValue = false)]
        public LiquidVolume LiquidVolume { get; set; }

        /// <summary>
        /// When true, the item qualifies as hazardous materials (hazmat). Defaults to false.
        /// </summary>
        /// <value>When true, the item qualifies as hazardous materials (hazmat). Defaults to false.</value>
        [DataMember(Name = "IsHazmat", EmitDefaultValue = false)]
        public bool? IsHazmat { get; set; }

        /// <summary>
        /// Gets or Sets DangerousGoodsDetails
        /// </summary>
        [DataMember(Name = "DangerousGoodsDetails", EmitDefaultValue = false)]
        public DangerousGoodsDetails DangerousGoodsDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  OrderItemId: ").Append(OrderItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ItemWeight: ").Append(ItemWeight).Append("\n");
            sb.Append("  ItemDescription: ").Append(ItemDescription).Append("\n");
            sb.Append("  TransparencyCodeList: ").Append(TransparencyCodeList).Append("\n");
            sb.Append("  ItemLevelSellerInputsList: ").Append(ItemLevelSellerInputsList).Append("\n");
            sb.Append("  LiquidVolume: ").Append(LiquidVolume).Append("\n");
            sb.Append("  IsHazmat: ").Append(IsHazmat).Append("\n");
            sb.Append("  DangerousGoodsDetails: ").Append(DangerousGoodsDetails).Append("\n");
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
            return this.Equals(input as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="input">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item input)
        {
            if (input == null)
                return false;

            return
                (
                    this.OrderItemId == input.OrderItemId ||
                    (this.OrderItemId != null &&
                    this.OrderItemId.Equals(input.OrderItemId))
                ) &&
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) &&
                (
                    this.ItemWeight == input.ItemWeight ||
                    (this.ItemWeight != null &&
                    this.ItemWeight.Equals(input.ItemWeight))
                ) &&
                (
                    this.ItemDescription == input.ItemDescription ||
                    (this.ItemDescription != null &&
                    this.ItemDescription.Equals(input.ItemDescription))
                ) &&
                (
                    this.TransparencyCodeList == input.TransparencyCodeList ||
                    (this.TransparencyCodeList != null &&
                    this.TransparencyCodeList.Equals(input.TransparencyCodeList))
                ) &&
                (
                    this.ItemLevelSellerInputsList == input.ItemLevelSellerInputsList ||
                    (this.ItemLevelSellerInputsList != null &&
                    this.ItemLevelSellerInputsList.Equals(input.ItemLevelSellerInputsList))
                ) &&
                (
                    this.LiquidVolume == input.LiquidVolume ||
                    (this.LiquidVolume != null &&
                    this.LiquidVolume.Equals(input.LiquidVolume))
                ) &&
                (
                    this.IsHazmat == input.IsHazmat ||
                    (this.IsHazmat != null &&
                    this.IsHazmat.Equals(input.IsHazmat))
                ) &&
                (
                    this.DangerousGoodsDetails == input.DangerousGoodsDetails ||
                    (this.DangerousGoodsDetails != null &&
                    this.DangerousGoodsDetails.Equals(input.DangerousGoodsDetails))
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
                if (this.OrderItemId != null)
                    hashCode = hashCode * 59 + this.OrderItemId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.ItemWeight != null)
                    hashCode = hashCode * 59 + this.ItemWeight.GetHashCode();
                if (this.ItemDescription != null)
                    hashCode = hashCode * 59 + this.ItemDescription.GetHashCode();
                if (this.TransparencyCodeList != null)
                    hashCode = hashCode * 59 + this.TransparencyCodeList.GetHashCode();
                if (this.ItemLevelSellerInputsList != null)
                    hashCode = hashCode * 59 + this.ItemLevelSellerInputsList.GetHashCode();
                if (this.LiquidVolume != null)
                    hashCode = hashCode * 59 + this.LiquidVolume.GetHashCode();
                if (this.IsHazmat != null)
                    hashCode = hashCode * 59 + this.IsHazmat.GetHashCode();
                if (this.DangerousGoodsDetails != null)
                    hashCode = hashCode * 59 + this.DangerousGoodsDetails.GetHashCode();
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
