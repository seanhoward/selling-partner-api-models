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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping
{
    /// <summary>
    /// Represents the request payload for creating a shipping label, containing the purchase order number, selling party, ship from party, and a list of containers or packages in the shipment.
    /// </summary>
    [DataContract]
    public partial class ShippingLabelRequest :  IEquatable<ShippingLabelRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingLabelRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShippingLabelRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingLabelRequest" /> class.
        /// </summary>
        /// <param name="purchaseOrderNumber">The purchase order number of the order for which to create a shipping label. (required).</param>
        /// <param name="sellingParty">The ID of the selling party or vendor. (required).</param>
        /// <param name="shipFromParty">The warehouse code of the vendor. (required).</param>
        /// <param name="containers">A list of the packages in this shipment..</param>
        public ShippingLabelRequest(string purchaseOrderNumber = default(string), PartyIdentification sellingParty = default(PartyIdentification), PartyIdentification shipFromParty = default(PartyIdentification), List<Container> containers = default(List<Container>))
        {
            // to ensure "purchaseOrderNumber" is required (not null)
            if (purchaseOrderNumber == null)
            {
                throw new InvalidDataException("purchaseOrderNumber is a required property for ShippingLabelRequest and cannot be null");
            }
            else
            {
                this.PurchaseOrderNumber = purchaseOrderNumber;
            }
            // to ensure "sellingParty" is required (not null)
            if (sellingParty == null)
            {
                throw new InvalidDataException("sellingParty is a required property for ShippingLabelRequest and cannot be null");
            }
            else
            {
                this.SellingParty = sellingParty;
            }
            // to ensure "shipFromParty" is required (not null)
            if (shipFromParty == null)
            {
                throw new InvalidDataException("shipFromParty is a required property for ShippingLabelRequest and cannot be null");
            }
            else
            {
                this.ShipFromParty = shipFromParty;
            }
            this.Containers = containers;
        }
        
        /// <summary>
        /// The purchase order number of the order for which to create a shipping label.
        /// </summary>
        /// <value>The purchase order number of the order for which to create a shipping label.</value>
        [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The ID of the selling party or vendor.
        /// </summary>
        /// <value>The ID of the selling party or vendor.</value>
        [DataMember(Name="sellingParty", EmitDefaultValue=false)]
        public PartyIdentification SellingParty { get; set; }

        /// <summary>
        /// The warehouse code of the vendor.
        /// </summary>
        /// <value>The warehouse code of the vendor.</value>
        [DataMember(Name="shipFromParty", EmitDefaultValue=false)]
        public PartyIdentification ShipFromParty { get; set; }

        /// <summary>
        /// A list of the packages in this shipment.
        /// </summary>
        /// <value>A list of the packages in this shipment.</value>
        [DataMember(Name="containers", EmitDefaultValue=false)]
        public List<Container> Containers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingLabelRequest {\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  ShipFromParty: ").Append(ShipFromParty).Append("\n");
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
            return this.Equals(input as ShippingLabelRequest);
        }

        /// <summary>
        /// Returns true if ShippingLabelRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingLabelRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingLabelRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) && 
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
                    this.Containers == input.Containers ||
                    this.Containers != null &&
                    this.Containers.SequenceEqual(input.Containers)
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
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.SellingParty != null)
                    hashCode = hashCode * 59 + this.SellingParty.GetHashCode();
                if (this.ShipFromParty != null)
                    hashCode = hashCode * 59 + this.ShipFromParty.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PurchaseOrderNumber (string) pattern
            Regex regexPurchaseOrderNumber = new Regex(@"^[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexPurchaseOrderNumber.Match(this.PurchaseOrderNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PurchaseOrderNumber, must match a pattern of " + regexPurchaseOrderNumber, new [] { "PurchaseOrderNumber" });
            }

            yield break;
        }
    }

}
