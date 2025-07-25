/* 
 * Selling Partner API for Retail Procurement Orders
 *
 * The Selling Partner API for Retail Procurement Orders provides programmatic access to vendor orders data.
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
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorOrders
{
    /// <summary>
    /// Acknowledgement status information.
    /// </summary>
    [DataContract]
    public partial class OrderItemStatusAcknowledgementStatus : IEquatable<OrderItemStatusAcknowledgementStatus>, IValidatableObject
    {
        /// <summary>
        /// Confirmation status of line item.
        /// </summary>
        /// <value>Confirmation status of line item.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConfirmationStatusEnum
        {

            /// <summary>
            /// Enum ACCEPTED for value: ACCEPTED
            /// </summary>
            [EnumMember(Value = "ACCEPTED")]
            ACCEPTED = 1,

            /// <summary>
            /// Enum PARTIALLYACCEPTED for value: PARTIALLY_ACCEPTED
            /// </summary>
            [EnumMember(Value = "PARTIALLY_ACCEPTED")]
            PARTIALLYACCEPTED = 2,

            /// <summary>
            /// Enum REJECTED for value: REJECTED
            /// </summary>
            [EnumMember(Value = "REJECTED")]
            REJECTED = 3,

            /// <summary>
            /// Enum UNCONFIRMED for value: UNCONFIRMED
            /// </summary>
            [EnumMember(Value = "UNCONFIRMED")]
            UNCONFIRMED = 4
        }

        /// <summary>
        /// Confirmation status of line item.
        /// </summary>
        /// <value>Confirmation status of line item.</value>
        [DataMember(Name = "confirmationStatus", EmitDefaultValue = false)]
        public ConfirmationStatusEnum? ConfirmationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemStatusAcknowledgementStatus" /> class.
        /// </summary>
        /// <param name="confirmationStatus">Confirmation status of line item..</param>
        /// <param name="acceptedQuantity">Item quantities accepted by vendor to be shipped..</param>
        /// <param name="rejectedQuantity">Item quantities rejected by vendor..</param>
        /// <param name="acknowledgementStatusDetails">Details of item quantity confirmed..</param>
        public OrderItemStatusAcknowledgementStatus(ConfirmationStatusEnum? confirmationStatus = default, ItemQuantity acceptedQuantity = default, ItemQuantity rejectedQuantity = default, List<AcknowledgementStatusDetails> acknowledgementStatusDetails = default)
        {
            this.ConfirmationStatus = confirmationStatus;
            this.AcceptedQuantity = acceptedQuantity;
            this.RejectedQuantity = rejectedQuantity;
            this.AcknowledgementStatusDetails = acknowledgementStatusDetails;
        }


        /// <summary>
        /// Item quantities accepted by vendor to be shipped.
        /// </summary>
        /// <value>Item quantities accepted by vendor to be shipped.</value>
        [DataMember(Name = "acceptedQuantity", EmitDefaultValue = false)]
        public ItemQuantity AcceptedQuantity { get; set; }

        /// <summary>
        /// Item quantities rejected by vendor.
        /// </summary>
        /// <value>Item quantities rejected by vendor.</value>
        [DataMember(Name = "rejectedQuantity", EmitDefaultValue = false)]
        public ItemQuantity RejectedQuantity { get; set; }

        /// <summary>
        /// Details of item quantity confirmed.
        /// </summary>
        /// <value>Details of item quantity confirmed.</value>
        [DataMember(Name = "acknowledgementStatusDetails", EmitDefaultValue = false)]
        public List<AcknowledgementStatusDetails> AcknowledgementStatusDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderItemStatusAcknowledgementStatus {\n");
            sb.Append("  ConfirmationStatus: ").Append(ConfirmationStatus).Append("\n");
            sb.Append("  AcceptedQuantity: ").Append(AcceptedQuantity).Append("\n");
            sb.Append("  RejectedQuantity: ").Append(RejectedQuantity).Append("\n");
            sb.Append("  AcknowledgementStatusDetails: ").Append(AcknowledgementStatusDetails).Append("\n");
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
            return this.Equals(input as OrderItemStatusAcknowledgementStatus);
        }

        /// <summary>
        /// Returns true if OrderItemStatusAcknowledgementStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItemStatusAcknowledgementStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemStatusAcknowledgementStatus input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ConfirmationStatus == input.ConfirmationStatus ||
                    (this.ConfirmationStatus != null &&
                    this.ConfirmationStatus.Equals(input.ConfirmationStatus))
                ) &&
                (
                    this.AcceptedQuantity == input.AcceptedQuantity ||
                    (this.AcceptedQuantity != null &&
                    this.AcceptedQuantity.Equals(input.AcceptedQuantity))
                ) &&
                (
                    this.RejectedQuantity == input.RejectedQuantity ||
                    (this.RejectedQuantity != null &&
                    this.RejectedQuantity.Equals(input.RejectedQuantity))
                ) &&
                (
                    this.AcknowledgementStatusDetails == input.AcknowledgementStatusDetails ||
                    this.AcknowledgementStatusDetails != null &&
                    this.AcknowledgementStatusDetails.SequenceEqual(input.AcknowledgementStatusDetails)
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
                if (this.ConfirmationStatus != null)
                    hashCode = hashCode * 59 + this.ConfirmationStatus.GetHashCode();
                if (this.AcceptedQuantity != null)
                    hashCode = hashCode * 59 + this.AcceptedQuantity.GetHashCode();
                if (this.RejectedQuantity != null)
                    hashCode = hashCode * 59 + this.RejectedQuantity.GetHashCode();
                if (this.AcknowledgementStatusDetails != null)
                    hashCode = hashCode * 59 + this.AcknowledgementStatusDetails.GetHashCode();
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
