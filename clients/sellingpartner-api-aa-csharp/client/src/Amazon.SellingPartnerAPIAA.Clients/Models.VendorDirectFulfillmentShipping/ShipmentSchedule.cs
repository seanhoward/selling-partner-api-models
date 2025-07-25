/* 
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * Use the Selling Partner API for Direct Fulfillment Shipping to access a direct fulfillment vendor's shipping data.
 *
 * OpenAPI spec version: 2021-12-28
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping
{
    /// <summary>
    /// Details about the estimated delivery window.
    /// </summary>
    [DataContract]
    public partial class ShipmentSchedule : IEquatable<ShipmentSchedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentSchedule" /> class.
        /// </summary>
        /// <param name="estimatedDeliveryDateTime">Date on which the shipment is expected to reach the customer delivery location. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format, with UTC time zone or UTC offset. For example, 2020-07-16T23:00:00Z or 2020-07-16T23:00:00+01:00..</param>
        /// <param name="apptWindowStartDateTime">The date and time at the start of the appointment window when the shipment is expected to be delivered. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format, with UTC time zone or UTC offset. For example, 2020-07-16T23:00:00Z or 2020-07-16T23:00:00+01:00..</param>
        /// <param name="apptWindowEndDateTime">The date and time at the end of the appointment window when the shipment is expected to be delivered. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format, with UTC time zone or UTC offset. For example, 2020-07-16T23:00:00Z or 2020-07-16T23:00:00+01:00..</param>
        public ShipmentSchedule(DateTime? estimatedDeliveryDateTime = default, DateTime? apptWindowStartDateTime = default, DateTime? apptWindowEndDateTime = default)
        {
            this.EstimatedDeliveryDateTime = estimatedDeliveryDateTime;
            this.ApptWindowStartDateTime = apptWindowStartDateTime;
            this.ApptWindowEndDateTime = apptWindowEndDateTime;
        }

        /// <summary>
        /// Date on which the shipment is expected to reach the customer delivery location. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format, with UTC time zone or UTC offset. For example, 2020-07-16T23:00:00Z or 2020-07-16T23:00:00+01:00.
        /// </summary>
        /// <value>Date on which the shipment is expected to reach the customer delivery location. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format, with UTC time zone or UTC offset. For example, 2020-07-16T23:00:00Z or 2020-07-16T23:00:00+01:00.</value>
        [DataMember(Name = "estimatedDeliveryDateTime", EmitDefaultValue = false)]
        public DateTime? EstimatedDeliveryDateTime { get; set; }

        /// <summary>
        /// The date and time at the start of the appointment window when the shipment is expected to be delivered. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format, with UTC time zone or UTC offset. For example, 2020-07-16T23:00:00Z or 2020-07-16T23:00:00+01:00.
        /// </summary>
        /// <value>The date and time at the start of the appointment window when the shipment is expected to be delivered. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format, with UTC time zone or UTC offset. For example, 2020-07-16T23:00:00Z or 2020-07-16T23:00:00+01:00.</value>
        [DataMember(Name = "apptWindowStartDateTime", EmitDefaultValue = false)]
        public DateTime? ApptWindowStartDateTime { get; set; }

        /// <summary>
        /// The date and time at the end of the appointment window when the shipment is expected to be delivered. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format, with UTC time zone or UTC offset. For example, 2020-07-16T23:00:00Z or 2020-07-16T23:00:00+01:00.
        /// </summary>
        /// <value>The date and time at the end of the appointment window when the shipment is expected to be delivered. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format, with UTC time zone or UTC offset. For example, 2020-07-16T23:00:00Z or 2020-07-16T23:00:00+01:00.</value>
        [DataMember(Name = "apptWindowEndDateTime", EmitDefaultValue = false)]
        public DateTime? ApptWindowEndDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentSchedule {\n");
            sb.Append("  EstimatedDeliveryDateTime: ").Append(EstimatedDeliveryDateTime).Append("\n");
            sb.Append("  ApptWindowStartDateTime: ").Append(ApptWindowStartDateTime).Append("\n");
            sb.Append("  ApptWindowEndDateTime: ").Append(ApptWindowEndDateTime).Append("\n");
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
            return this.Equals(input as ShipmentSchedule);
        }

        /// <summary>
        /// Returns true if ShipmentSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentSchedule input)
        {
            if (input == null)
                return false;

            return
                (
                    this.EstimatedDeliveryDateTime == input.EstimatedDeliveryDateTime ||
                    (this.EstimatedDeliveryDateTime != null &&
                    this.EstimatedDeliveryDateTime.Equals(input.EstimatedDeliveryDateTime))
                ) &&
                (
                    this.ApptWindowStartDateTime == input.ApptWindowStartDateTime ||
                    (this.ApptWindowStartDateTime != null &&
                    this.ApptWindowStartDateTime.Equals(input.ApptWindowStartDateTime))
                ) &&
                (
                    this.ApptWindowEndDateTime == input.ApptWindowEndDateTime ||
                    (this.ApptWindowEndDateTime != null &&
                    this.ApptWindowEndDateTime.Equals(input.ApptWindowEndDateTime))
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
                if (this.EstimatedDeliveryDateTime != null)
                    hashCode = hashCode * 59 + this.EstimatedDeliveryDateTime.GetHashCode();
                if (this.ApptWindowStartDateTime != null)
                    hashCode = hashCode * 59 + this.ApptWindowStartDateTime.GetHashCode();
                if (this.ApptWindowEndDateTime != null)
                    hashCode = hashCode * 59 + this.ApptWindowEndDateTime.GetHashCode();
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
