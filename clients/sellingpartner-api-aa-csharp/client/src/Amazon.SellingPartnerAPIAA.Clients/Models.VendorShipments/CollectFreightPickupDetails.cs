/* 
 * Selling Partner API for Retail Procurement Shipments
 *
 * The Selling Partner API for Retail Procurement Shipments provides programmatic access to retail shipping data for vendors.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorShipments
{
    /// <summary>
    /// Transport Request pickup date from Vendor Warehouse by Buyer
    /// </summary>
    [DataContract]
    public partial class CollectFreightPickupDetails : IEquatable<CollectFreightPickupDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectFreightPickupDetails" /> class.
        /// </summary>
        /// <param name="requestedPickUp">Date on which the items can be picked up from vendor warehouse by Buyer used for WePay/Collect vendors..</param>
        /// <param name="scheduledPickUp">Date on which the items are scheduled to be picked from vendor warehouse by Buyer used for WePay/Collect vendors..</param>
        /// <param name="carrierAssignmentDate">Date on which the carrier is being scheduled to pickup items from vendor warehouse by Byer used for WePay/Collect vendors..</param>
        public CollectFreightPickupDetails(DateTime? requestedPickUp = default, DateTime? scheduledPickUp = default, DateTime? carrierAssignmentDate = default)
        {
            this.RequestedPickUp = requestedPickUp;
            this.ScheduledPickUp = scheduledPickUp;
            this.CarrierAssignmentDate = carrierAssignmentDate;
        }

        /// <summary>
        /// Date on which the items can be picked up from vendor warehouse by Buyer used for WePay/Collect vendors.
        /// </summary>
        /// <value>Date on which the items can be picked up from vendor warehouse by Buyer used for WePay/Collect vendors.</value>
        [DataMember(Name = "requestedPickUp", EmitDefaultValue = false)]
        public DateTime? RequestedPickUp { get; set; }

        /// <summary>
        /// Date on which the items are scheduled to be picked from vendor warehouse by Buyer used for WePay/Collect vendors.
        /// </summary>
        /// <value>Date on which the items are scheduled to be picked from vendor warehouse by Buyer used for WePay/Collect vendors.</value>
        [DataMember(Name = "scheduledPickUp", EmitDefaultValue = false)]
        public DateTime? ScheduledPickUp { get; set; }

        /// <summary>
        /// Date on which the carrier is being scheduled to pickup items from vendor warehouse by Byer used for WePay/Collect vendors.
        /// </summary>
        /// <value>Date on which the carrier is being scheduled to pickup items from vendor warehouse by Byer used for WePay/Collect vendors.</value>
        [DataMember(Name = "carrierAssignmentDate", EmitDefaultValue = false)]
        public DateTime? CarrierAssignmentDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectFreightPickupDetails {\n");
            sb.Append("  RequestedPickUp: ").Append(RequestedPickUp).Append("\n");
            sb.Append("  ScheduledPickUp: ").Append(ScheduledPickUp).Append("\n");
            sb.Append("  CarrierAssignmentDate: ").Append(CarrierAssignmentDate).Append("\n");
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
            return this.Equals(input as CollectFreightPickupDetails);
        }

        /// <summary>
        /// Returns true if CollectFreightPickupDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectFreightPickupDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectFreightPickupDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.RequestedPickUp == input.RequestedPickUp ||
                    (this.RequestedPickUp != null &&
                    this.RequestedPickUp.Equals(input.RequestedPickUp))
                ) &&
                (
                    this.ScheduledPickUp == input.ScheduledPickUp ||
                    (this.ScheduledPickUp != null &&
                    this.ScheduledPickUp.Equals(input.ScheduledPickUp))
                ) &&
                (
                    this.CarrierAssignmentDate == input.CarrierAssignmentDate ||
                    (this.CarrierAssignmentDate != null &&
                    this.CarrierAssignmentDate.Equals(input.CarrierAssignmentDate))
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
                if (this.RequestedPickUp != null)
                    hashCode = hashCode * 59 + this.RequestedPickUp.GetHashCode();
                if (this.ScheduledPickUp != null)
                    hashCode = hashCode * 59 + this.ScheduledPickUp.GetHashCode();
                if (this.CarrierAssignmentDate != null)
                    hashCode = hashCode * 59 + this.CarrierAssignmentDate.GetHashCode();
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
