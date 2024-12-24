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
    /// An item that is invalid for return.
    /// </summary>
    [DataContract]
    public partial class InvalidReturnItem :  IEquatable<InvalidReturnItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidReturnItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvalidReturnItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidReturnItem" /> class.
        /// </summary>
        /// <param name="sellerReturnItemId">An identifier assigned by the seller to the return item. (required).</param>
        /// <param name="sellerFulfillmentOrderItemId">The identifier assigned to the item by the seller when the fulfillment order was created. (required).</param>
        /// <param name="invalidItemReason">invalidItemReason (required).</param>
        public InvalidReturnItem(string sellerReturnItemId = default(string), string sellerFulfillmentOrderItemId = default(string), InvalidItemReason invalidItemReason = default(InvalidItemReason))
        {
            // to ensure "sellerReturnItemId" is required (not null)
            if (sellerReturnItemId == null)
            {
                throw new InvalidDataException("sellerReturnItemId is a required property for InvalidReturnItem and cannot be null");
            }
            else
            {
                this.SellerReturnItemId = sellerReturnItemId;
            }
            // to ensure "sellerFulfillmentOrderItemId" is required (not null)
            if (sellerFulfillmentOrderItemId == null)
            {
                throw new InvalidDataException("sellerFulfillmentOrderItemId is a required property for InvalidReturnItem and cannot be null");
            }
            else
            {
                this.SellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
            }
            // to ensure "invalidItemReason" is required (not null)
            if (invalidItemReason == null)
            {
                throw new InvalidDataException("invalidItemReason is a required property for InvalidReturnItem and cannot be null");
            }
            else
            {
                this.InvalidItemReason = invalidItemReason;
            }
        }
        
        /// <summary>
        /// An identifier assigned by the seller to the return item.
        /// </summary>
        /// <value>An identifier assigned by the seller to the return item.</value>
        [DataMember(Name="sellerReturnItemId", EmitDefaultValue=false)]
        public string SellerReturnItemId { get; set; }

        /// <summary>
        /// The identifier assigned to the item by the seller when the fulfillment order was created.
        /// </summary>
        /// <value>The identifier assigned to the item by the seller when the fulfillment order was created.</value>
        [DataMember(Name="sellerFulfillmentOrderItemId", EmitDefaultValue=false)]
        public string SellerFulfillmentOrderItemId { get; set; }

        /// <summary>
        /// Gets or Sets InvalidItemReason
        /// </summary>
        [DataMember(Name="invalidItemReason", EmitDefaultValue=false)]
        public InvalidItemReason InvalidItemReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvalidReturnItem {\n");
            sb.Append("  SellerReturnItemId: ").Append(SellerReturnItemId).Append("\n");
            sb.Append("  SellerFulfillmentOrderItemId: ").Append(SellerFulfillmentOrderItemId).Append("\n");
            sb.Append("  InvalidItemReason: ").Append(InvalidItemReason).Append("\n");
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
            return this.Equals(input as InvalidReturnItem);
        }

        /// <summary>
        /// Returns true if InvalidReturnItem instances are equal
        /// </summary>
        /// <param name="input">Instance of InvalidReturnItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvalidReturnItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SellerReturnItemId == input.SellerReturnItemId ||
                    (this.SellerReturnItemId != null &&
                    this.SellerReturnItemId.Equals(input.SellerReturnItemId))
                ) && 
                (
                    this.SellerFulfillmentOrderItemId == input.SellerFulfillmentOrderItemId ||
                    (this.SellerFulfillmentOrderItemId != null &&
                    this.SellerFulfillmentOrderItemId.Equals(input.SellerFulfillmentOrderItemId))
                ) && 
                (
                    this.InvalidItemReason == input.InvalidItemReason ||
                    (this.InvalidItemReason != null &&
                    this.InvalidItemReason.Equals(input.InvalidItemReason))
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
                if (this.SellerReturnItemId != null)
                    hashCode = hashCode * 59 + this.SellerReturnItemId.GetHashCode();
                if (this.SellerFulfillmentOrderItemId != null)
                    hashCode = hashCode * 59 + this.SellerFulfillmentOrderItemId.GetHashCode();
                if (this.InvalidItemReason != null)
                    hashCode = hashCode * 59 + this.InvalidItemReason.GetHashCode();
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