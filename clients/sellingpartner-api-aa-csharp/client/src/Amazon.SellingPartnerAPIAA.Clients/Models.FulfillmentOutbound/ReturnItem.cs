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
    /// An item that Amazon accepted for return.
    /// </summary>
    [DataContract]
    public partial class ReturnItem :  IEquatable<ReturnItem>, IValidatableObject
    {
        /// <summary>
        /// Indicates if the return item has been processed by an Amazon fulfillment center.
        /// </summary>
        /// <value>Indicates if the return item has been processed by an Amazon fulfillment center.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public FulfillmentReturnItemStatus Status { get; set; }
        /// <summary>
        /// Gets or Sets ReturnReceivedCondition
        /// </summary>
        [DataMember(Name="returnReceivedCondition", EmitDefaultValue=false)]
        public ReturnItemDisposition? ReturnReceivedCondition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReturnItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnItem" /> class.
        /// </summary>
        /// <param name="sellerReturnItemId">An identifier assigned by the seller to the return item. (required).</param>
        /// <param name="sellerFulfillmentOrderItemId">The identifier assigned to the item by the seller when the fulfillment order was created. (required).</param>
        /// <param name="amazonShipmentId">The identifier for the shipment that is associated with the return item. (required).</param>
        /// <param name="sellerReturnReasonCode">The return reason code assigned to the return item by the seller. (required).</param>
        /// <param name="returnComment">An optional comment about the return item..</param>
        /// <param name="amazonReturnReasonCode">The return reason code that the Amazon fulfillment center assigned to the return item..</param>
        /// <param name="status">Indicates if the return item has been processed by an Amazon fulfillment center. (required).</param>
        /// <param name="statusChangedDate">Indicates when the status last changed. (required).</param>
        /// <param name="returnAuthorizationId">Identifies the return authorization used to return this item. Refer to &#x60;ReturnAuthorization&#x60;..</param>
        /// <param name="returnReceivedCondition">returnReceivedCondition.</param>
        /// <param name="fulfillmentCenterId">The identifier for the Amazon fulfillment center that processed the return item..</param>
        public ReturnItem(string sellerReturnItemId = default(string), string sellerFulfillmentOrderItemId = default(string), string amazonShipmentId = default(string), string sellerReturnReasonCode = default(string), string returnComment = default(string), string amazonReturnReasonCode = default(string), FulfillmentReturnItemStatus status = default(FulfillmentReturnItemStatus), DateTime? statusChangedDate = default(DateTime?), string returnAuthorizationId = default(string), ReturnItemDisposition? returnReceivedCondition = default(ReturnItemDisposition?), string fulfillmentCenterId = default(string))
        {
            // to ensure "sellerReturnItemId" is required (not null)
            if (sellerReturnItemId == null)
            {
                throw new InvalidDataException("sellerReturnItemId is a required property for ReturnItem and cannot be null");
            }
            else
            {
                this.SellerReturnItemId = sellerReturnItemId;
            }
            // to ensure "sellerFulfillmentOrderItemId" is required (not null)
            if (sellerFulfillmentOrderItemId == null)
            {
                throw new InvalidDataException("sellerFulfillmentOrderItemId is a required property for ReturnItem and cannot be null");
            }
            else
            {
                this.SellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
            }
            // to ensure "amazonShipmentId" is required (not null)
            if (amazonShipmentId == null)
            {
                throw new InvalidDataException("amazonShipmentId is a required property for ReturnItem and cannot be null");
            }
            else
            {
                this.AmazonShipmentId = amazonShipmentId;
            }
            // to ensure "sellerReturnReasonCode" is required (not null)
            if (sellerReturnReasonCode == null)
            {
                throw new InvalidDataException("sellerReturnReasonCode is a required property for ReturnItem and cannot be null");
            }
            else
            {
                this.SellerReturnReasonCode = sellerReturnReasonCode;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for ReturnItem and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "statusChangedDate" is required (not null)
            if (statusChangedDate == null)
            {
                throw new InvalidDataException("statusChangedDate is a required property for ReturnItem and cannot be null");
            }
            else
            {
                this.StatusChangedDate = statusChangedDate;
            }
            this.ReturnComment = returnComment;
            this.AmazonReturnReasonCode = amazonReturnReasonCode;
            this.ReturnAuthorizationId = returnAuthorizationId;
            this.ReturnReceivedCondition = returnReceivedCondition;
            this.FulfillmentCenterId = fulfillmentCenterId;
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
        /// The identifier for the shipment that is associated with the return item.
        /// </summary>
        /// <value>The identifier for the shipment that is associated with the return item.</value>
        [DataMember(Name="amazonShipmentId", EmitDefaultValue=false)]
        public string AmazonShipmentId { get; set; }

        /// <summary>
        /// The return reason code assigned to the return item by the seller.
        /// </summary>
        /// <value>The return reason code assigned to the return item by the seller.</value>
        [DataMember(Name="sellerReturnReasonCode", EmitDefaultValue=false)]
        public string SellerReturnReasonCode { get; set; }

        /// <summary>
        /// An optional comment about the return item.
        /// </summary>
        /// <value>An optional comment about the return item.</value>
        [DataMember(Name="returnComment", EmitDefaultValue=false)]
        public string ReturnComment { get; set; }

        /// <summary>
        /// The return reason code that the Amazon fulfillment center assigned to the return item.
        /// </summary>
        /// <value>The return reason code that the Amazon fulfillment center assigned to the return item.</value>
        [DataMember(Name="amazonReturnReasonCode", EmitDefaultValue=false)]
        public string AmazonReturnReasonCode { get; set; }


        /// <summary>
        /// Indicates when the status last changed.
        /// </summary>
        /// <value>Indicates when the status last changed.</value>
        [DataMember(Name="statusChangedDate", EmitDefaultValue=false)]
        public DateTime? StatusChangedDate { get; set; }

        /// <summary>
        /// Identifies the return authorization used to return this item. Refer to &#x60;ReturnAuthorization&#x60;.
        /// </summary>
        /// <value>Identifies the return authorization used to return this item. Refer to &#x60;ReturnAuthorization&#x60;.</value>
        [DataMember(Name="returnAuthorizationId", EmitDefaultValue=false)]
        public string ReturnAuthorizationId { get; set; }


        /// <summary>
        /// The identifier for the Amazon fulfillment center that processed the return item.
        /// </summary>
        /// <value>The identifier for the Amazon fulfillment center that processed the return item.</value>
        [DataMember(Name="fulfillmentCenterId", EmitDefaultValue=false)]
        public string FulfillmentCenterId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReturnItem {\n");
            sb.Append("  SellerReturnItemId: ").Append(SellerReturnItemId).Append("\n");
            sb.Append("  SellerFulfillmentOrderItemId: ").Append(SellerFulfillmentOrderItemId).Append("\n");
            sb.Append("  AmazonShipmentId: ").Append(AmazonShipmentId).Append("\n");
            sb.Append("  SellerReturnReasonCode: ").Append(SellerReturnReasonCode).Append("\n");
            sb.Append("  ReturnComment: ").Append(ReturnComment).Append("\n");
            sb.Append("  AmazonReturnReasonCode: ").Append(AmazonReturnReasonCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusChangedDate: ").Append(StatusChangedDate).Append("\n");
            sb.Append("  ReturnAuthorizationId: ").Append(ReturnAuthorizationId).Append("\n");
            sb.Append("  ReturnReceivedCondition: ").Append(ReturnReceivedCondition).Append("\n");
            sb.Append("  FulfillmentCenterId: ").Append(FulfillmentCenterId).Append("\n");
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
            return this.Equals(input as ReturnItem);
        }

        /// <summary>
        /// Returns true if ReturnItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ReturnItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReturnItem input)
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
                    this.AmazonShipmentId == input.AmazonShipmentId ||
                    (this.AmazonShipmentId != null &&
                    this.AmazonShipmentId.Equals(input.AmazonShipmentId))
                ) && 
                (
                    this.SellerReturnReasonCode == input.SellerReturnReasonCode ||
                    (this.SellerReturnReasonCode != null &&
                    this.SellerReturnReasonCode.Equals(input.SellerReturnReasonCode))
                ) && 
                (
                    this.ReturnComment == input.ReturnComment ||
                    (this.ReturnComment != null &&
                    this.ReturnComment.Equals(input.ReturnComment))
                ) && 
                (
                    this.AmazonReturnReasonCode == input.AmazonReturnReasonCode ||
                    (this.AmazonReturnReasonCode != null &&
                    this.AmazonReturnReasonCode.Equals(input.AmazonReturnReasonCode))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusChangedDate == input.StatusChangedDate ||
                    (this.StatusChangedDate != null &&
                    this.StatusChangedDate.Equals(input.StatusChangedDate))
                ) && 
                (
                    this.ReturnAuthorizationId == input.ReturnAuthorizationId ||
                    (this.ReturnAuthorizationId != null &&
                    this.ReturnAuthorizationId.Equals(input.ReturnAuthorizationId))
                ) && 
                (
                    this.ReturnReceivedCondition == input.ReturnReceivedCondition ||
                    (this.ReturnReceivedCondition != null &&
                    this.ReturnReceivedCondition.Equals(input.ReturnReceivedCondition))
                ) && 
                (
                    this.FulfillmentCenterId == input.FulfillmentCenterId ||
                    (this.FulfillmentCenterId != null &&
                    this.FulfillmentCenterId.Equals(input.FulfillmentCenterId))
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
                if (this.AmazonShipmentId != null)
                    hashCode = hashCode * 59 + this.AmazonShipmentId.GetHashCode();
                if (this.SellerReturnReasonCode != null)
                    hashCode = hashCode * 59 + this.SellerReturnReasonCode.GetHashCode();
                if (this.ReturnComment != null)
                    hashCode = hashCode * 59 + this.ReturnComment.GetHashCode();
                if (this.AmazonReturnReasonCode != null)
                    hashCode = hashCode * 59 + this.AmazonReturnReasonCode.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusChangedDate != null)
                    hashCode = hashCode * 59 + this.StatusChangedDate.GetHashCode();
                if (this.ReturnAuthorizationId != null)
                    hashCode = hashCode * 59 + this.ReturnAuthorizationId.GetHashCode();
                if (this.ReturnReceivedCondition != null)
                    hashCode = hashCode * 59 + this.ReturnReceivedCondition.GetHashCode();
                if (this.FulfillmentCenterId != null)
                    hashCode = hashCode * 59 + this.FulfillmentCenterId.GetHashCode();
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
