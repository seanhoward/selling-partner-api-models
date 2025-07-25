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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// Item information for a shipment in a fulfillment order preview.
    /// </summary>
    [DataContract]
    public partial class FulfillmentPreviewItem : IEquatable<FulfillmentPreviewItem>, IValidatableObject
    {
        /// <summary>
        /// The method used to calculate the estimated shipping weight.
        /// </summary>
        /// <value>The method used to calculate the estimated shipping weight.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShippingWeightCalculationMethodEnum
        {

            /// <summary>
            /// Enum Package for value: Package
            /// </summary>
            [EnumMember(Value = "Package")]
            Package = 1,

            /// <summary>
            /// Enum Dimensional for value: Dimensional
            /// </summary>
            [EnumMember(Value = "Dimensional")]
            Dimensional = 2
        }

        /// <summary>
        /// The method used to calculate the estimated shipping weight.
        /// </summary>
        /// <value>The method used to calculate the estimated shipping weight.</value>
        [DataMember(Name = "shippingWeightCalculationMethod", EmitDefaultValue = false)]
        public ShippingWeightCalculationMethodEnum? ShippingWeightCalculationMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentPreviewItem" /> class.
        /// </summary>
        [JsonConstructor]
        protected FulfillmentPreviewItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentPreviewItem" /> class.
        /// </summary>
        /// <param name="sellerSku">The seller SKU of the item. (required).</param>
        /// <param name="quantity">The item quantity. (required).</param>
        /// <param name="sellerFulfillmentOrderItemId">A fulfillment order item identifier that the seller created with a call to the &#x60;createFulfillmentOrder&#x60; operation. (required).</param>
        /// <param name="estimatedShippingWeight">The estimated shipping weight of the item quantity for a single item, as identified by &#x60;sellerSku&#x60;, in a shipment..</param>
        /// <param name="shippingWeightCalculationMethod">The method used to calculate the estimated shipping weight..</param>
        public FulfillmentPreviewItem(string sellerSku = default, int? quantity = default, string sellerFulfillmentOrderItemId = default, Weight estimatedShippingWeight = default, ShippingWeightCalculationMethodEnum? shippingWeightCalculationMethod = default)
        {
            // to ensure "sellerSku" is required (not null)
            if (sellerSku == null)
            {
                throw new InvalidDataException("sellerSku is a required property for FulfillmentPreviewItem and cannot be null");
            }
            else
            {
                this.SellerSku = sellerSku;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for FulfillmentPreviewItem and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            // to ensure "sellerFulfillmentOrderItemId" is required (not null)
            if (sellerFulfillmentOrderItemId == null)
            {
                throw new InvalidDataException("sellerFulfillmentOrderItemId is a required property for FulfillmentPreviewItem and cannot be null");
            }
            else
            {
                this.SellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
            }
            this.EstimatedShippingWeight = estimatedShippingWeight;
            this.ShippingWeightCalculationMethod = shippingWeightCalculationMethod;
        }

        /// <summary>
        /// The seller SKU of the item.
        /// </summary>
        /// <value>The seller SKU of the item.</value>
        [DataMember(Name = "sellerSku", EmitDefaultValue = false)]
        public string SellerSku { get; set; }

        /// <summary>
        /// The item quantity.
        /// </summary>
        /// <value>The item quantity.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// A fulfillment order item identifier that the seller created with a call to the &#x60;createFulfillmentOrder&#x60; operation.
        /// </summary>
        /// <value>A fulfillment order item identifier that the seller created with a call to the &#x60;createFulfillmentOrder&#x60; operation.</value>
        [DataMember(Name = "sellerFulfillmentOrderItemId", EmitDefaultValue = false)]
        public string SellerFulfillmentOrderItemId { get; set; }

        /// <summary>
        /// The estimated shipping weight of the item quantity for a single item, as identified by &#x60;sellerSku&#x60;, in a shipment.
        /// </summary>
        /// <value>The estimated shipping weight of the item quantity for a single item, as identified by &#x60;sellerSku&#x60;, in a shipment.</value>
        [DataMember(Name = "estimatedShippingWeight", EmitDefaultValue = false)]
        public Weight EstimatedShippingWeight { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentPreviewItem {\n");
            sb.Append("  SellerSku: ").Append(SellerSku).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SellerFulfillmentOrderItemId: ").Append(SellerFulfillmentOrderItemId).Append("\n");
            sb.Append("  EstimatedShippingWeight: ").Append(EstimatedShippingWeight).Append("\n");
            sb.Append("  ShippingWeightCalculationMethod: ").Append(ShippingWeightCalculationMethod).Append("\n");
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
            return this.Equals(input as FulfillmentPreviewItem);
        }

        /// <summary>
        /// Returns true if FulfillmentPreviewItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentPreviewItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentPreviewItem input)
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
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) &&
                (
                    this.SellerFulfillmentOrderItemId == input.SellerFulfillmentOrderItemId ||
                    (this.SellerFulfillmentOrderItemId != null &&
                    this.SellerFulfillmentOrderItemId.Equals(input.SellerFulfillmentOrderItemId))
                ) &&
                (
                    this.EstimatedShippingWeight == input.EstimatedShippingWeight ||
                    (this.EstimatedShippingWeight != null &&
                    this.EstimatedShippingWeight.Equals(input.EstimatedShippingWeight))
                ) &&
                (
                    this.ShippingWeightCalculationMethod == input.ShippingWeightCalculationMethod ||
                    (this.ShippingWeightCalculationMethod != null &&
                    this.ShippingWeightCalculationMethod.Equals(input.ShippingWeightCalculationMethod))
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
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.SellerFulfillmentOrderItemId != null)
                    hashCode = hashCode * 59 + this.SellerFulfillmentOrderItemId.GetHashCode();
                if (this.EstimatedShippingWeight != null)
                    hashCode = hashCode * 59 + this.EstimatedShippingWeight.GetHashCode();
                if (this.ShippingWeightCalculationMethod != null)
                    hashCode = hashCode * 59 + this.ShippingWeightCalculationMethod.GetHashCode();
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
