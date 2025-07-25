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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping
{
    /// <summary>
    /// Details about a shipment.
    /// </summary>
    [DataContract]
    public partial class ShipmentDetails : IEquatable<ShipmentDetails>, IValidatableObject
    {
        /// <summary>
        /// The shipment status.
        /// </summary>
        /// <value>The shipment status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShipmentStatusEnum
        {

            /// <summary>
            /// Enum SHIPPED for value: SHIPPED
            /// </summary>
            [EnumMember(Value = "SHIPPED")]
            SHIPPED = 1,

            /// <summary>
            /// Enum FLOORDENIAL for value: FLOOR_DENIAL
            /// </summary>
            [EnumMember(Value = "FLOOR_DENIAL")]
            FLOORDENIAL = 2
        }

        /// <summary>
        /// The shipment status.
        /// </summary>
        /// <value>The shipment status.</value>
        [DataMember(Name = "shipmentStatus", EmitDefaultValue = false)]
        public ShipmentStatusEnum ShipmentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDetails" /> class.
        /// </summary>
        [JsonConstructor]
        protected ShipmentDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDetails" /> class.
        /// </summary>
        /// <param name="shippedDate">The date of the shipment&#39;s departure from vendor&#39;s location. Vendors send ASNs within 30 minutes of departure from their warehouse/distribution center or six hours prior to the appointment time at the Amazon destination warehouse. The shipped date mentioned in the shipment confirmation cannot be in the future. (required).</param>
        /// <param name="shipmentStatus">The shipment status. (required).</param>
        /// <param name="isPriorityShipment">Provide the priority of the shipment..</param>
        /// <param name="vendorOrderNumber">The vendor order number is a unique identifier generated by a vendor for their reference..</param>
        /// <param name="estimatedDeliveryDate">The date on which the shipment is expected to reach the buyer&#39;s warehouse. The date is estimated based on the average transit time between the ship-from location and the destination. Usually, the exact appointment time is unknown when creating the shipment confirmation and is later provided by the buyer..</param>
        public ShipmentDetails(DateTime? shippedDate = default, ShipmentStatusEnum shipmentStatus = default, bool? isPriorityShipment = default, string vendorOrderNumber = default, DateTime? estimatedDeliveryDate = default)
        {
            // to ensure "shippedDate" is required (not null)
            if (shippedDate == null)
            {
                throw new InvalidDataException("shippedDate is a required property for ShipmentDetails and cannot be null");
            }
            else
            {
                this.ShippedDate = shippedDate;
            }
            // to ensure "shipmentStatus" is required (not null)
            if (shipmentStatus == null)
            {
                throw new InvalidDataException("shipmentStatus is a required property for ShipmentDetails and cannot be null");
            }
            else
            {
                this.ShipmentStatus = shipmentStatus;
            }
            this.IsPriorityShipment = isPriorityShipment;
            this.VendorOrderNumber = vendorOrderNumber;
            this.EstimatedDeliveryDate = estimatedDeliveryDate;
        }

        /// <summary>
        /// The date of the shipment&#39;s departure from vendor&#39;s location. Vendors send ASNs within 30 minutes of departure from their warehouse/distribution center or six hours prior to the appointment time at the Amazon destination warehouse. The shipped date mentioned in the shipment confirmation cannot be in the future.
        /// </summary>
        /// <value>The date of the shipment&#39;s departure from vendor&#39;s location. Vendors send ASNs within 30 minutes of departure from their warehouse/distribution center or six hours prior to the appointment time at the Amazon destination warehouse. The shipped date mentioned in the shipment confirmation cannot be in the future.</value>
        [DataMember(Name = "shippedDate", EmitDefaultValue = false)]
        public DateTime? ShippedDate { get; set; }


        /// <summary>
        /// Provide the priority of the shipment.
        /// </summary>
        /// <value>Provide the priority of the shipment.</value>
        [DataMember(Name = "isPriorityShipment", EmitDefaultValue = false)]
        public bool? IsPriorityShipment { get; set; }

        /// <summary>
        /// The vendor order number is a unique identifier generated by a vendor for their reference.
        /// </summary>
        /// <value>The vendor order number is a unique identifier generated by a vendor for their reference.</value>
        [DataMember(Name = "vendorOrderNumber", EmitDefaultValue = false)]
        public string VendorOrderNumber { get; set; }

        /// <summary>
        /// The date on which the shipment is expected to reach the buyer&#39;s warehouse. The date is estimated based on the average transit time between the ship-from location and the destination. Usually, the exact appointment time is unknown when creating the shipment confirmation and is later provided by the buyer.
        /// </summary>
        /// <value>The date on which the shipment is expected to reach the buyer&#39;s warehouse. The date is estimated based on the average transit time between the ship-from location and the destination. Usually, the exact appointment time is unknown when creating the shipment confirmation and is later provided by the buyer.</value>
        [DataMember(Name = "estimatedDeliveryDate", EmitDefaultValue = false)]
        public DateTime? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentDetails {\n");
            sb.Append("  ShippedDate: ").Append(ShippedDate).Append("\n");
            sb.Append("  ShipmentStatus: ").Append(ShipmentStatus).Append("\n");
            sb.Append("  IsPriorityShipment: ").Append(IsPriorityShipment).Append("\n");
            sb.Append("  VendorOrderNumber: ").Append(VendorOrderNumber).Append("\n");
            sb.Append("  EstimatedDeliveryDate: ").Append(EstimatedDeliveryDate).Append("\n");
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
            return this.Equals(input as ShipmentDetails);
        }

        /// <summary>
        /// Returns true if ShipmentDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ShippedDate == input.ShippedDate ||
                    (this.ShippedDate != null &&
                    this.ShippedDate.Equals(input.ShippedDate))
                ) &&
                (
                    this.ShipmentStatus == input.ShipmentStatus ||
                    (this.ShipmentStatus != null &&
                    this.ShipmentStatus.Equals(input.ShipmentStatus))
                ) &&
                (
                    this.IsPriorityShipment == input.IsPriorityShipment ||
                    (this.IsPriorityShipment != null &&
                    this.IsPriorityShipment.Equals(input.IsPriorityShipment))
                ) &&
                (
                    this.VendorOrderNumber == input.VendorOrderNumber ||
                    (this.VendorOrderNumber != null &&
                    this.VendorOrderNumber.Equals(input.VendorOrderNumber))
                ) &&
                (
                    this.EstimatedDeliveryDate == input.EstimatedDeliveryDate ||
                    (this.EstimatedDeliveryDate != null &&
                    this.EstimatedDeliveryDate.Equals(input.EstimatedDeliveryDate))
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
                if (this.ShippedDate != null)
                    hashCode = hashCode * 59 + this.ShippedDate.GetHashCode();
                if (this.ShipmentStatus != null)
                    hashCode = hashCode * 59 + this.ShipmentStatus.GetHashCode();
                if (this.IsPriorityShipment != null)
                    hashCode = hashCode * 59 + this.IsPriorityShipment.GetHashCode();
                if (this.VendorOrderNumber != null)
                    hashCode = hashCode * 59 + this.VendorOrderNumber.GetHashCode();
                if (this.EstimatedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.EstimatedDeliveryDate.GetHashCode();
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
