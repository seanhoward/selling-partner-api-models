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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorOrders
{
    /// <summary>
    /// Details of item quantity ordered
    /// </summary>
    [DataContract]
    public partial class AcknowledgementStatusDetails : IEquatable<AcknowledgementStatusDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcknowledgementStatusDetails" /> class.
        /// </summary>
        /// <param name="acknowledgementDate">The date when the line item was confirmed by vendor. Must be in ISO-8601 date/time format..</param>
        /// <param name="acceptedQuantity">Item quantity accepted by vendor to be shipped..</param>
        /// <param name="rejectedQuantity">Item quantity rejected by vendor..</param>
        public AcknowledgementStatusDetails(DateTime? acknowledgementDate = default, ItemQuantity acceptedQuantity = default, ItemQuantity rejectedQuantity = default)
        {
            this.AcknowledgementDate = acknowledgementDate;
            this.AcceptedQuantity = acceptedQuantity;
            this.RejectedQuantity = rejectedQuantity;
        }

        /// <summary>
        /// The date when the line item was confirmed by vendor. Must be in ISO-8601 date/time format.
        /// </summary>
        /// <value>The date when the line item was confirmed by vendor. Must be in ISO-8601 date/time format.</value>
        [DataMember(Name = "acknowledgementDate", EmitDefaultValue = false)]
        public DateTime? AcknowledgementDate { get; set; }

        /// <summary>
        /// Item quantity accepted by vendor to be shipped.
        /// </summary>
        /// <value>Item quantity accepted by vendor to be shipped.</value>
        [DataMember(Name = "acceptedQuantity", EmitDefaultValue = false)]
        public ItemQuantity AcceptedQuantity { get; set; }

        /// <summary>
        /// Item quantity rejected by vendor.
        /// </summary>
        /// <value>Item quantity rejected by vendor.</value>
        [DataMember(Name = "rejectedQuantity", EmitDefaultValue = false)]
        public ItemQuantity RejectedQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcknowledgementStatusDetails {\n");
            sb.Append("  AcknowledgementDate: ").Append(AcknowledgementDate).Append("\n");
            sb.Append("  AcceptedQuantity: ").Append(AcceptedQuantity).Append("\n");
            sb.Append("  RejectedQuantity: ").Append(RejectedQuantity).Append("\n");
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
            return this.Equals(input as AcknowledgementStatusDetails);
        }

        /// <summary>
        /// Returns true if AcknowledgementStatusDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AcknowledgementStatusDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcknowledgementStatusDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AcknowledgementDate == input.AcknowledgementDate ||
                    (this.AcknowledgementDate != null &&
                    this.AcknowledgementDate.Equals(input.AcknowledgementDate))
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
                if (this.AcknowledgementDate != null)
                    hashCode = hashCode * 59 + this.AcknowledgementDate.GetHashCode();
                if (this.AcceptedQuantity != null)
                    hashCode = hashCode * 59 + this.AcceptedQuantity.GetHashCode();
                if (this.RejectedQuantity != null)
                    hashCode = hashCode * 59 + this.RejectedQuantity.GetHashCode();
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
