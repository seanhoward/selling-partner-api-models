/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * With the Selling Partner API for Merchant Fulfillment, you can build applications that sellers can use to purchase shipping for non-Prime and Prime orders using Amazon's Buy Shipping Services.
 *
 * OpenAPI spec version: v0
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment
{
    /// <summary>
    /// Shipment information required for requesting shipping service offers or for creating a shipment.
    /// </summary>
    [DataContract]
    public partial class ShipmentRequestDetails : IEquatable<ShipmentRequestDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentRequestDetails" /> class.
        /// </summary>
        [JsonConstructor]
        protected ShipmentRequestDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentRequestDetails" /> class.
        /// </summary>
        /// <param name="amazonOrderId">An Amazon-defined order identifier in 3-7-7 format. (required).</param>
        /// <param name="sellerOrderId">A seller-defined order identifier..</param>
        /// <param name="itemList">itemList (required).</param>
        /// <param name="shipFromAddress">The address of the sender. (required).</param>
        /// <param name="packageDimensions">The package dimensions. (required).</param>
        /// <param name="weight">The package weight. (required).</param>
        /// <param name="mustArriveByDate">The date by which the package must arrive to keep the promise to the customer, in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. If &#x60;MustArriveByDate&#x60; is specified, only shipping service offers that can be delivered by that date are returned..</param>
        /// <param name="shipDate">When used in a request, this is the date and time that the seller wants to ship the package. When used in a response, this is the date and time that the package can be shipped by the indicated method..</param>
        /// <param name="shippingServiceOptions">Extra services offered by the carrier. (required).</param>
        /// <param name="labelCustomization">Label customization options..</param>
        public ShipmentRequestDetails(string amazonOrderId = default, string sellerOrderId = default, ItemList itemList = default, Address shipFromAddress = default, PackageDimensions packageDimensions = default, Weight weight = default, DateTime? mustArriveByDate = default, DateTime? shipDate = default, ShippingServiceOptions shippingServiceOptions = default, LabelCustomization labelCustomization = default)
        {
            // to ensure "amazonOrderId" is required (not null)
            if (amazonOrderId == null)
            {
                throw new InvalidDataException("amazonOrderId is a required property for ShipmentRequestDetails and cannot be null");
            }
            else
            {
                this.AmazonOrderId = amazonOrderId;
            }
            // to ensure "itemList" is required (not null)
            if (itemList == null)
            {
                throw new InvalidDataException("itemList is a required property for ShipmentRequestDetails and cannot be null");
            }
            else
            {
                this.ItemList = itemList;
            }
            // to ensure "shipFromAddress" is required (not null)
            if (shipFromAddress == null)
            {
                throw new InvalidDataException("shipFromAddress is a required property for ShipmentRequestDetails and cannot be null");
            }
            else
            {
                this.ShipFromAddress = shipFromAddress;
            }
            // to ensure "packageDimensions" is required (not null)
            if (packageDimensions == null)
            {
                throw new InvalidDataException("packageDimensions is a required property for ShipmentRequestDetails and cannot be null");
            }
            else
            {
                this.PackageDimensions = packageDimensions;
            }
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new InvalidDataException("weight is a required property for ShipmentRequestDetails and cannot be null");
            }
            else
            {
                this.Weight = weight;
            }
            // to ensure "shippingServiceOptions" is required (not null)
            if (shippingServiceOptions == null)
            {
                throw new InvalidDataException("shippingServiceOptions is a required property for ShipmentRequestDetails and cannot be null");
            }
            else
            {
                this.ShippingServiceOptions = shippingServiceOptions;
            }
            this.SellerOrderId = sellerOrderId;
            this.MustArriveByDate = mustArriveByDate;
            this.ShipDate = shipDate;
            this.LabelCustomization = labelCustomization;
        }

        /// <summary>
        /// An Amazon-defined order identifier in 3-7-7 format.
        /// </summary>
        /// <value>An Amazon-defined order identifier in 3-7-7 format.</value>
        [DataMember(Name = "AmazonOrderId", EmitDefaultValue = false)]
        public string AmazonOrderId { get; set; }

        /// <summary>
        /// A seller-defined order identifier.
        /// </summary>
        /// <value>A seller-defined order identifier.</value>
        [DataMember(Name = "SellerOrderId", EmitDefaultValue = false)]
        public string SellerOrderId { get; set; }

        /// <summary>
        /// Gets or Sets ItemList
        /// </summary>
        [DataMember(Name = "ItemList", EmitDefaultValue = false)]
        public ItemList ItemList { get; set; }

        /// <summary>
        /// The address of the sender.
        /// </summary>
        /// <value>The address of the sender.</value>
        [DataMember(Name = "ShipFromAddress", EmitDefaultValue = false)]
        public Address ShipFromAddress { get; set; }

        /// <summary>
        /// The package dimensions.
        /// </summary>
        /// <value>The package dimensions.</value>
        [DataMember(Name = "PackageDimensions", EmitDefaultValue = false)]
        public PackageDimensions PackageDimensions { get; set; }

        /// <summary>
        /// The package weight.
        /// </summary>
        /// <value>The package weight.</value>
        [DataMember(Name = "Weight", EmitDefaultValue = false)]
        public Weight Weight { get; set; }

        /// <summary>
        /// The date by which the package must arrive to keep the promise to the customer, in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. If &#x60;MustArriveByDate&#x60; is specified, only shipping service offers that can be delivered by that date are returned.
        /// </summary>
        /// <value>The date by which the package must arrive to keep the promise to the customer, in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. If &#x60;MustArriveByDate&#x60; is specified, only shipping service offers that can be delivered by that date are returned.</value>
        [DataMember(Name = "MustArriveByDate", EmitDefaultValue = false)]
        public DateTime? MustArriveByDate { get; set; }

        /// <summary>
        /// When used in a request, this is the date and time that the seller wants to ship the package. When used in a response, this is the date and time that the package can be shipped by the indicated method.
        /// </summary>
        /// <value>When used in a request, this is the date and time that the seller wants to ship the package. When used in a response, this is the date and time that the package can be shipped by the indicated method.</value>
        [DataMember(Name = "ShipDate", EmitDefaultValue = false)]
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// Extra services offered by the carrier.
        /// </summary>
        /// <value>Extra services offered by the carrier.</value>
        [DataMember(Name = "ShippingServiceOptions", EmitDefaultValue = false)]
        public ShippingServiceOptions ShippingServiceOptions { get; set; }

        /// <summary>
        /// Label customization options.
        /// </summary>
        /// <value>Label customization options.</value>
        [DataMember(Name = "LabelCustomization", EmitDefaultValue = false)]
        public LabelCustomization LabelCustomization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentRequestDetails {\n");
            sb.Append("  AmazonOrderId: ").Append(AmazonOrderId).Append("\n");
            sb.Append("  SellerOrderId: ").Append(SellerOrderId).Append("\n");
            sb.Append("  ItemList: ").Append(ItemList).Append("\n");
            sb.Append("  ShipFromAddress: ").Append(ShipFromAddress).Append("\n");
            sb.Append("  PackageDimensions: ").Append(PackageDimensions).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  MustArriveByDate: ").Append(MustArriveByDate).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  ShippingServiceOptions: ").Append(ShippingServiceOptions).Append("\n");
            sb.Append("  LabelCustomization: ").Append(LabelCustomization).Append("\n");
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
            return this.Equals(input as ShipmentRequestDetails);
        }

        /// <summary>
        /// Returns true if ShipmentRequestDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentRequestDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentRequestDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AmazonOrderId == input.AmazonOrderId ||
                    (this.AmazonOrderId != null &&
                    this.AmazonOrderId.Equals(input.AmazonOrderId))
                ) &&
                (
                    this.SellerOrderId == input.SellerOrderId ||
                    (this.SellerOrderId != null &&
                    this.SellerOrderId.Equals(input.SellerOrderId))
                ) &&
                (
                    this.ItemList == input.ItemList ||
                    (this.ItemList != null &&
                    this.ItemList.Equals(input.ItemList))
                ) &&
                (
                    this.ShipFromAddress == input.ShipFromAddress ||
                    (this.ShipFromAddress != null &&
                    this.ShipFromAddress.Equals(input.ShipFromAddress))
                ) &&
                (
                    this.PackageDimensions == input.PackageDimensions ||
                    (this.PackageDimensions != null &&
                    this.PackageDimensions.Equals(input.PackageDimensions))
                ) &&
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) &&
                (
                    this.MustArriveByDate == input.MustArriveByDate ||
                    (this.MustArriveByDate != null &&
                    this.MustArriveByDate.Equals(input.MustArriveByDate))
                ) &&
                (
                    this.ShipDate == input.ShipDate ||
                    (this.ShipDate != null &&
                    this.ShipDate.Equals(input.ShipDate))
                ) &&
                (
                    this.ShippingServiceOptions == input.ShippingServiceOptions ||
                    (this.ShippingServiceOptions != null &&
                    this.ShippingServiceOptions.Equals(input.ShippingServiceOptions))
                ) &&
                (
                    this.LabelCustomization == input.LabelCustomization ||
                    (this.LabelCustomization != null &&
                    this.LabelCustomization.Equals(input.LabelCustomization))
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
                if (this.AmazonOrderId != null)
                    hashCode = hashCode * 59 + this.AmazonOrderId.GetHashCode();
                if (this.SellerOrderId != null)
                    hashCode = hashCode * 59 + this.SellerOrderId.GetHashCode();
                if (this.ItemList != null)
                    hashCode = hashCode * 59 + this.ItemList.GetHashCode();
                if (this.ShipFromAddress != null)
                    hashCode = hashCode * 59 + this.ShipFromAddress.GetHashCode();
                if (this.PackageDimensions != null)
                    hashCode = hashCode * 59 + this.PackageDimensions.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.MustArriveByDate != null)
                    hashCode = hashCode * 59 + this.MustArriveByDate.GetHashCode();
                if (this.ShipDate != null)
                    hashCode = hashCode * 59 + this.ShipDate.GetHashCode();
                if (this.ShippingServiceOptions != null)
                    hashCode = hashCode * 59 + this.ShippingServiceOptions.GetHashCode();
                if (this.LabelCustomization != null)
                    hashCode = hashCode * 59 + this.LabelCustomization.GetHashCode();
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
