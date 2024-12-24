/* 
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: 2020-07-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// Item information for creating a fulfillment order.
    /// </summary>
    [DataContract]
    public partial class CreateFulfillmentOrderItem :  IEquatable<CreateFulfillmentOrderItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFulfillmentOrderItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFulfillmentOrderItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFulfillmentOrderItem" /> class.
        /// </summary>
        /// <param name="sellerSku">The seller SKU of the item. (required).</param>
        /// <param name="sellerFulfillmentOrderItemId">A fulfillment order item identifier that the seller creates to track fulfillment order items. Used to disambiguate multiple fulfillment items that have the same &#x60;SellerSKU&#x60;. For example, the seller might assign different &#x60;SellerFulfillmentOrderItemId&#x60; values to two items in a fulfillment order that share the same &#x60;SellerSKU&#x60; but have different &#x60;GiftMessage&#x60; values. (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="giftMessage">A message to the gift recipient, if applicable..</param>
        /// <param name="displayableComment">Item-specific text that displays in recipient-facing materials such as the outbound shipment packing slip..</param>
        /// <param name="fulfillmentNetworkSku">Amazon&#39;s fulfillment network SKU of the item..</param>
        /// <param name="perUnitDeclaredValue">The monetary value assigned by the seller to this item. This is a required field for India MCF orders..</param>
        /// <param name="perUnitPrice">The amount to be collected from the recipient for this item in a COD (Cash On Delivery) order..</param>
        /// <param name="perUnitTax">The tax on the amount to be collected from the recipient for this item in a COD (Cash On Delivery) order..</param>
        public CreateFulfillmentOrderItem(string sellerSku = default(string), string sellerFulfillmentOrderItemId = default(string), int? quantity = default(int?), string giftMessage = default(string), string displayableComment = default(string), string fulfillmentNetworkSku = default(string), Money perUnitDeclaredValue = default(Money), Money perUnitPrice = default(Money), Money perUnitTax = default(Money))
        {
            // to ensure "sellerSku" is required (not null)
            if (sellerSku == null)
            {
                throw new InvalidDataException("sellerSku is a required property for CreateFulfillmentOrderItem and cannot be null");
            }
            else
            {
                this.SellerSku = sellerSku;
            }
            // to ensure "sellerFulfillmentOrderItemId" is required (not null)
            if (sellerFulfillmentOrderItemId == null)
            {
                throw new InvalidDataException("sellerFulfillmentOrderItemId is a required property for CreateFulfillmentOrderItem and cannot be null");
            }
            else
            {
                this.SellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for CreateFulfillmentOrderItem and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            this.GiftMessage = giftMessage;
            this.DisplayableComment = displayableComment;
            this.FulfillmentNetworkSku = fulfillmentNetworkSku;
            this.PerUnitDeclaredValue = perUnitDeclaredValue;
            this.PerUnitPrice = perUnitPrice;
            this.PerUnitTax = perUnitTax;
        }
        
        /// <summary>
        /// The seller SKU of the item.
        /// </summary>
        /// <value>The seller SKU of the item.</value>
        [DataMember(Name="sellerSku", EmitDefaultValue=false)]
        public string SellerSku { get; set; }

        /// <summary>
        /// A fulfillment order item identifier that the seller creates to track fulfillment order items. Used to disambiguate multiple fulfillment items that have the same &#x60;SellerSKU&#x60;. For example, the seller might assign different &#x60;SellerFulfillmentOrderItemId&#x60; values to two items in a fulfillment order that share the same &#x60;SellerSKU&#x60; but have different &#x60;GiftMessage&#x60; values.
        /// </summary>
        /// <value>A fulfillment order item identifier that the seller creates to track fulfillment order items. Used to disambiguate multiple fulfillment items that have the same &#x60;SellerSKU&#x60;. For example, the seller might assign different &#x60;SellerFulfillmentOrderItemId&#x60; values to two items in a fulfillment order that share the same &#x60;SellerSKU&#x60; but have different &#x60;GiftMessage&#x60; values.</value>
        [DataMember(Name="sellerFulfillmentOrderItemId", EmitDefaultValue=false)]
        public string SellerFulfillmentOrderItemId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// A message to the gift recipient, if applicable.
        /// </summary>
        /// <value>A message to the gift recipient, if applicable.</value>
        [DataMember(Name="giftMessage", EmitDefaultValue=false)]
        public string GiftMessage { get; set; }

        /// <summary>
        /// Item-specific text that displays in recipient-facing materials such as the outbound shipment packing slip.
        /// </summary>
        /// <value>Item-specific text that displays in recipient-facing materials such as the outbound shipment packing slip.</value>
        [DataMember(Name="displayableComment", EmitDefaultValue=false)]
        public string DisplayableComment { get; set; }

        /// <summary>
        /// Amazon&#39;s fulfillment network SKU of the item.
        /// </summary>
        /// <value>Amazon&#39;s fulfillment network SKU of the item.</value>
        [DataMember(Name="fulfillmentNetworkSku", EmitDefaultValue=false)]
        public string FulfillmentNetworkSku { get; set; }

        /// <summary>
        /// The monetary value assigned by the seller to this item. This is a required field for India MCF orders.
        /// </summary>
        /// <value>The monetary value assigned by the seller to this item. This is a required field for India MCF orders.</value>
        [DataMember(Name="perUnitDeclaredValue", EmitDefaultValue=false)]
        public Money PerUnitDeclaredValue { get; set; }

        /// <summary>
        /// The amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.
        /// </summary>
        /// <value>The amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.</value>
        [DataMember(Name="perUnitPrice", EmitDefaultValue=false)]
        public Money PerUnitPrice { get; set; }

        /// <summary>
        /// The tax on the amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.
        /// </summary>
        /// <value>The tax on the amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.</value>
        [DataMember(Name="perUnitTax", EmitDefaultValue=false)]
        public Money PerUnitTax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFulfillmentOrderItem {\n");
            sb.Append("  SellerSku: ").Append(SellerSku).Append("\n");
            sb.Append("  SellerFulfillmentOrderItemId: ").Append(SellerFulfillmentOrderItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  GiftMessage: ").Append(GiftMessage).Append("\n");
            sb.Append("  DisplayableComment: ").Append(DisplayableComment).Append("\n");
            sb.Append("  FulfillmentNetworkSku: ").Append(FulfillmentNetworkSku).Append("\n");
            sb.Append("  PerUnitDeclaredValue: ").Append(PerUnitDeclaredValue).Append("\n");
            sb.Append("  PerUnitPrice: ").Append(PerUnitPrice).Append("\n");
            sb.Append("  PerUnitTax: ").Append(PerUnitTax).Append("\n");
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
            return this.Equals(input as CreateFulfillmentOrderItem);
        }

        /// <summary>
        /// Returns true if CreateFulfillmentOrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFulfillmentOrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFulfillmentOrderItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SellerSku == input.SellerSku ||
                    (this.SellerSku != null &&
                    this.SellerSku.Equals(input.SellerSku))
                ) && 
                (
                    this.SellerFulfillmentOrderItemId == input.SellerFulfillmentOrderItemId ||
                    (this.SellerFulfillmentOrderItemId != null &&
                    this.SellerFulfillmentOrderItemId.Equals(input.SellerFulfillmentOrderItemId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.GiftMessage == input.GiftMessage ||
                    (this.GiftMessage != null &&
                    this.GiftMessage.Equals(input.GiftMessage))
                ) && 
                (
                    this.DisplayableComment == input.DisplayableComment ||
                    (this.DisplayableComment != null &&
                    this.DisplayableComment.Equals(input.DisplayableComment))
                ) && 
                (
                    this.FulfillmentNetworkSku == input.FulfillmentNetworkSku ||
                    (this.FulfillmentNetworkSku != null &&
                    this.FulfillmentNetworkSku.Equals(input.FulfillmentNetworkSku))
                ) && 
                (
                    this.PerUnitDeclaredValue == input.PerUnitDeclaredValue ||
                    (this.PerUnitDeclaredValue != null &&
                    this.PerUnitDeclaredValue.Equals(input.PerUnitDeclaredValue))
                ) && 
                (
                    this.PerUnitPrice == input.PerUnitPrice ||
                    (this.PerUnitPrice != null &&
                    this.PerUnitPrice.Equals(input.PerUnitPrice))
                ) && 
                (
                    this.PerUnitTax == input.PerUnitTax ||
                    (this.PerUnitTax != null &&
                    this.PerUnitTax.Equals(input.PerUnitTax))
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
                if (this.SellerSku != null)
                    hashCode = hashCode * 59 + this.SellerSku.GetHashCode();
                if (this.SellerFulfillmentOrderItemId != null)
                    hashCode = hashCode * 59 + this.SellerFulfillmentOrderItemId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.GiftMessage != null)
                    hashCode = hashCode * 59 + this.GiftMessage.GetHashCode();
                if (this.DisplayableComment != null)
                    hashCode = hashCode * 59 + this.DisplayableComment.GetHashCode();
                if (this.FulfillmentNetworkSku != null)
                    hashCode = hashCode * 59 + this.FulfillmentNetworkSku.GetHashCode();
                if (this.PerUnitDeclaredValue != null)
                    hashCode = hashCode * 59 + this.PerUnitDeclaredValue.GetHashCode();
                if (this.PerUnitPrice != null)
                    hashCode = hashCode * 59 + this.PerUnitPrice.GetHashCode();
                if (this.PerUnitTax != null)
                    hashCode = hashCode * 59 + this.PerUnitTax.GetHashCode();
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
            // SellerSku (string) maxLength
            if(this.SellerSku != null && this.SellerSku.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SellerSku, length must be less than 50.", new [] { "SellerSku" });
            }

            // SellerFulfillmentOrderItemId (string) maxLength
            if(this.SellerFulfillmentOrderItemId != null && this.SellerFulfillmentOrderItemId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SellerFulfillmentOrderItemId, length must be less than 50.", new [] { "SellerFulfillmentOrderItemId" });
            }

            // GiftMessage (string) maxLength
            if(this.GiftMessage != null && this.GiftMessage.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GiftMessage, length must be less than 512.", new [] { "GiftMessage" });
            }

            // DisplayableComment (string) maxLength
            if(this.DisplayableComment != null && this.DisplayableComment.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayableComment, length must be less than 250.", new [] { "DisplayableComment" });
            }

            yield break;
        }
    }

}
