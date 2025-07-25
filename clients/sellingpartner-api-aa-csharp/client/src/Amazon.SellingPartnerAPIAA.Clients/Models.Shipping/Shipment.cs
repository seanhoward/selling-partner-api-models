/* 
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.   **Note:** If you are new to the Amazon Shipping API, refer to the latest version of <a href=\"https://developer-docs.amazon.com/amazon-shipping/docs/shipping-api-v2-reference\">Amazon Shipping API (v2)</a> on the <a href=\"https://developer-docs.amazon.com/amazon-shipping/\">Amazon Shipping Developer Documentation</a> site.
 *
 * OpenAPI spec version: v1
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Shipping
{
    /// <summary>
    /// The shipment related data.
    /// </summary>
    [DataContract]
    public partial class Shipment : IEquatable<Shipment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipment" /> class.
        /// </summary>
        [JsonConstructor]
        protected Shipment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipment" /> class.
        /// </summary>
        /// <param name="shipmentId">shipmentId (required).</param>
        /// <param name="clientReferenceId">clientReferenceId (required).</param>
        /// <param name="shipFrom">shipFrom (required).</param>
        /// <param name="shipTo">shipTo (required).</param>
        /// <param name="acceptedRate">acceptedRate.</param>
        /// <param name="shipper">shipper.</param>
        /// <param name="containers">containers (required).</param>
        public Shipment(string shipmentId = default, string clientReferenceId = default, Address shipFrom = default, Address shipTo = default, AcceptedRate acceptedRate = default, Party shipper = default, ContainerList containers = default)
        {
            // to ensure "shipmentId" is required (not null)
            if (shipmentId == null)
            {
                throw new InvalidDataException("shipmentId is a required property for Shipment and cannot be null");
            }
            else
            {
                this.ShipmentId = shipmentId;
            }
            // to ensure "clientReferenceId" is required (not null)
            if (clientReferenceId == null)
            {
                throw new InvalidDataException("clientReferenceId is a required property for Shipment and cannot be null");
            }
            else
            {
                this.ClientReferenceId = clientReferenceId;
            }
            // to ensure "shipFrom" is required (not null)
            if (shipFrom == null)
            {
                throw new InvalidDataException("shipFrom is a required property for Shipment and cannot be null");
            }
            else
            {
                this.ShipFrom = shipFrom;
            }
            // to ensure "shipTo" is required (not null)
            if (shipTo == null)
            {
                throw new InvalidDataException("shipTo is a required property for Shipment and cannot be null");
            }
            else
            {
                this.ShipTo = shipTo;
            }
            // to ensure "containers" is required (not null)
            if (containers == null)
            {
                throw new InvalidDataException("containers is a required property for Shipment and cannot be null");
            }
            else
            {
                this.Containers = containers;
            }
            this.AcceptedRate = acceptedRate;
            this.Shipper = shipper;
        }

        /// <summary>
        /// Gets or Sets ShipmentId
        /// </summary>
        [DataMember(Name = "shipmentId", EmitDefaultValue = false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Gets or Sets ClientReferenceId
        /// </summary>
        [DataMember(Name = "clientReferenceId", EmitDefaultValue = false)]
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets ShipFrom
        /// </summary>
        [DataMember(Name = "shipFrom", EmitDefaultValue = false)]
        public Address ShipFrom { get; set; }

        /// <summary>
        /// Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name = "shipTo", EmitDefaultValue = false)]
        public Address ShipTo { get; set; }

        /// <summary>
        /// Gets or Sets AcceptedRate
        /// </summary>
        [DataMember(Name = "acceptedRate", EmitDefaultValue = false)]
        public AcceptedRate AcceptedRate { get; set; }

        /// <summary>
        /// Gets or Sets Shipper
        /// </summary>
        [DataMember(Name = "shipper", EmitDefaultValue = false)]
        public Party Shipper { get; set; }

        /// <summary>
        /// Gets or Sets Containers
        /// </summary>
        [DataMember(Name = "containers", EmitDefaultValue = false)]
        public ContainerList Containers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Shipment {\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  ClientReferenceId: ").Append(ClientReferenceId).Append("\n");
            sb.Append("  ShipFrom: ").Append(ShipFrom).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  AcceptedRate: ").Append(AcceptedRate).Append("\n");
            sb.Append("  Shipper: ").Append(Shipper).Append("\n");
            sb.Append("  Containers: ").Append(Containers).Append("\n");
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
            return this.Equals(input as Shipment);
        }

        /// <summary>
        /// Returns true if Shipment instances are equal
        /// </summary>
        /// <param name="input">Instance of Shipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Shipment input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ShipmentId == input.ShipmentId ||
                    (this.ShipmentId != null &&
                    this.ShipmentId.Equals(input.ShipmentId))
                ) &&
                (
                    this.ClientReferenceId == input.ClientReferenceId ||
                    (this.ClientReferenceId != null &&
                    this.ClientReferenceId.Equals(input.ClientReferenceId))
                ) &&
                (
                    this.ShipFrom == input.ShipFrom ||
                    (this.ShipFrom != null &&
                    this.ShipFrom.Equals(input.ShipFrom))
                ) &&
                (
                    this.ShipTo == input.ShipTo ||
                    (this.ShipTo != null &&
                    this.ShipTo.Equals(input.ShipTo))
                ) &&
                (
                    this.AcceptedRate == input.AcceptedRate ||
                    (this.AcceptedRate != null &&
                    this.AcceptedRate.Equals(input.AcceptedRate))
                ) &&
                (
                    this.Shipper == input.Shipper ||
                    (this.Shipper != null &&
                    this.Shipper.Equals(input.Shipper))
                ) &&
                (
                    this.Containers == input.Containers ||
                    (this.Containers != null &&
                    this.Containers.Equals(input.Containers))
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
                if (this.ShipmentId != null)
                    hashCode = hashCode * 59 + this.ShipmentId.GetHashCode();
                if (this.ClientReferenceId != null)
                    hashCode = hashCode * 59 + this.ClientReferenceId.GetHashCode();
                if (this.ShipFrom != null)
                    hashCode = hashCode * 59 + this.ShipFrom.GetHashCode();
                if (this.ShipTo != null)
                    hashCode = hashCode * 59 + this.ShipTo.GetHashCode();
                if (this.AcceptedRate != null)
                    hashCode = hashCode * 59 + this.AcceptedRate.GetHashCode();
                if (this.Shipper != null)
                    hashCode = hashCode * 59 + this.Shipper.GetHashCode();
                if (this.Containers != null)
                    hashCode = hashCode * 59 + this.Containers.GetHashCode();
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
