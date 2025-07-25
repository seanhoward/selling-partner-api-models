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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping
{
    /// <summary>
    /// The request body schema for the &#x60;createContainerLabel&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class CreateContainerLabelRequest : IEquatable<CreateContainerLabelRequest>, IValidatableObject
    {
        /// <summary>
        /// The container (pallet) label&#39;s carrier.
        /// </summary>
        /// <value>The container (pallet) label&#39;s carrier.</value>
        [DataMember(Name = "carrierId", EmitDefaultValue = false)]
        public CarrierId CarrierId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerLabelRequest" /> class.
        /// </summary>
        [JsonConstructor]
        protected CreateContainerLabelRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerLabelRequest" /> class.
        /// </summary>
        /// <param name="sellingParty">The ID of the selling party or vendor. (required).</param>
        /// <param name="shipFromParty">The warehouse code of the vendor. (required).</param>
        /// <param name="carrierId">The container (pallet) label&#39;s carrier. (required).</param>
        /// <param name="vendorContainerId">The vendor&#39;s unique identifier for the container. (required).</param>
        /// <param name="packages">An array of package objects that associate shipment packages with a container. (required).</param>
        public CreateContainerLabelRequest(PartyIdentification sellingParty = default, PartyIdentification shipFromParty = default, CarrierId carrierId = default, string vendorContainerId = default, Packages packages = default)
        {
            // to ensure "sellingParty" is required (not null)
            if (sellingParty == null)
            {
                throw new InvalidDataException("sellingParty is a required property for CreateContainerLabelRequest and cannot be null");
            }
            else
            {
                this.SellingParty = sellingParty;
            }
            // to ensure "shipFromParty" is required (not null)
            if (shipFromParty == null)
            {
                throw new InvalidDataException("shipFromParty is a required property for CreateContainerLabelRequest and cannot be null");
            }
            else
            {
                this.ShipFromParty = shipFromParty;
            }
            // to ensure "carrierId" is required (not null)
            if (carrierId == null)
            {
                throw new InvalidDataException("carrierId is a required property for CreateContainerLabelRequest and cannot be null");
            }
            else
            {
                this.CarrierId = carrierId;
            }
            // to ensure "vendorContainerId" is required (not null)
            if (vendorContainerId == null)
            {
                throw new InvalidDataException("vendorContainerId is a required property for CreateContainerLabelRequest and cannot be null");
            }
            else
            {
                this.VendorContainerId = vendorContainerId;
            }
            // to ensure "packages" is required (not null)
            if (packages == null)
            {
                throw new InvalidDataException("packages is a required property for CreateContainerLabelRequest and cannot be null");
            }
            else
            {
                this.Packages = packages;
            }
        }

        /// <summary>
        /// The ID of the selling party or vendor.
        /// </summary>
        /// <value>The ID of the selling party or vendor.</value>
        [DataMember(Name = "sellingParty", EmitDefaultValue = false)]
        public PartyIdentification SellingParty { get; set; }

        /// <summary>
        /// The warehouse code of the vendor.
        /// </summary>
        /// <value>The warehouse code of the vendor.</value>
        [DataMember(Name = "shipFromParty", EmitDefaultValue = false)]
        public PartyIdentification ShipFromParty { get; set; }


        /// <summary>
        /// The vendor&#39;s unique identifier for the container.
        /// </summary>
        /// <value>The vendor&#39;s unique identifier for the container.</value>
        [DataMember(Name = "vendorContainerId", EmitDefaultValue = false)]
        public string VendorContainerId { get; set; }

        /// <summary>
        /// An array of package objects that associate shipment packages with a container.
        /// </summary>
        /// <value>An array of package objects that associate shipment packages with a container.</value>
        [DataMember(Name = "packages", EmitDefaultValue = false)]
        public Packages Packages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateContainerLabelRequest {\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  ShipFromParty: ").Append(ShipFromParty).Append("\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            sb.Append("  VendorContainerId: ").Append(VendorContainerId).Append("\n");
            sb.Append("  Packages: ").Append(Packages).Append("\n");
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
            return this.Equals(input as CreateContainerLabelRequest);
        }

        /// <summary>
        /// Returns true if CreateContainerLabelRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateContainerLabelRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateContainerLabelRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SellingParty == input.SellingParty ||
                    (this.SellingParty != null &&
                    this.SellingParty.Equals(input.SellingParty))
                ) &&
                (
                    this.ShipFromParty == input.ShipFromParty ||
                    (this.ShipFromParty != null &&
                    this.ShipFromParty.Equals(input.ShipFromParty))
                ) &&
                (
                    this.CarrierId == input.CarrierId ||
                    (this.CarrierId != null &&
                    this.CarrierId.Equals(input.CarrierId))
                ) &&
                (
                    this.VendorContainerId == input.VendorContainerId ||
                    (this.VendorContainerId != null &&
                    this.VendorContainerId.Equals(input.VendorContainerId))
                ) &&
                (
                    this.Packages == input.Packages ||
                    (this.Packages != null &&
                    this.Packages.Equals(input.Packages))
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
                if (this.SellingParty != null)
                    hashCode = hashCode * 59 + this.SellingParty.GetHashCode();
                if (this.ShipFromParty != null)
                    hashCode = hashCode * 59 + this.ShipFromParty.GetHashCode();
                if (this.CarrierId != null)
                    hashCode = hashCode * 59 + this.CarrierId.GetHashCode();
                if (this.VendorContainerId != null)
                    hashCode = hashCode * 59 + this.VendorContainerId.GetHashCode();
                if (this.Packages != null)
                    hashCode = hashCode * 59 + this.Packages.GetHashCode();
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
