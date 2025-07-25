/* 
 * Selling Partner API for Direct Fulfillment Payments
 *
 * The Selling Partner API for Direct Fulfillment Payments provides programmatic access to a direct fulfillment vendor's invoice data.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentPayments
{
    /// <summary>
    /// Provides the details of the items in this invoice.
    /// </summary>
    [DataContract]
    public partial class InvoiceItem : IEquatable<InvoiceItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceItem" /> class.
        /// </summary>
        [JsonConstructor]
        protected InvoiceItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceItem" /> class.
        /// </summary>
        /// <param name="itemSequenceNumber">Numbering of the item on the purchase order. The first item will be 1, the second 2, and so on. (required).</param>
        /// <param name="buyerProductIdentifier">Buyer&#39;s standard identification number (ASIN) of an item..</param>
        /// <param name="vendorProductIdentifier">The vendor selected product identification of the item..</param>
        /// <param name="invoicedQuantity">Item quantity invoiced. (required).</param>
        /// <param name="netCost">Net price (before tax) to vendor with currency details. (required).</param>
        /// <param name="purchaseOrderNumber">The purchase order number for this order. Formatting Notes: 8-character alpha-numeric code. (required).</param>
        /// <param name="vendorOrderNumber">The vendor&#39;s order number for this order..</param>
        /// <param name="hsnCode">Harmonized System of Nomenclature (HSN) tax code. The HSN number cannot contain alphabets..</param>
        /// <param name="taxDetails">Individual tax details per line item..</param>
        /// <param name="chargeDetails">Individual charge details per line item..</param>
        public InvoiceItem(string itemSequenceNumber = default, string buyerProductIdentifier = default, string vendorProductIdentifier = default, ItemQuantity invoicedQuantity = default, Money netCost = default, string purchaseOrderNumber = default, string vendorOrderNumber = default, string hsnCode = default, List<TaxDetail> taxDetails = default, List<ChargeDetails> chargeDetails = default)
        {
            // to ensure "itemSequenceNumber" is required (not null)
            if (itemSequenceNumber == null)
            {
                throw new InvalidDataException("itemSequenceNumber is a required property for InvoiceItem and cannot be null");
            }
            else
            {
                this.ItemSequenceNumber = itemSequenceNumber;
            }
            // to ensure "invoicedQuantity" is required (not null)
            if (invoicedQuantity == null)
            {
                throw new InvalidDataException("invoicedQuantity is a required property for InvoiceItem and cannot be null");
            }
            else
            {
                this.InvoicedQuantity = invoicedQuantity;
            }
            // to ensure "netCost" is required (not null)
            if (netCost == null)
            {
                throw new InvalidDataException("netCost is a required property for InvoiceItem and cannot be null");
            }
            else
            {
                this.NetCost = netCost;
            }
            // to ensure "purchaseOrderNumber" is required (not null)
            if (purchaseOrderNumber == null)
            {
                throw new InvalidDataException("purchaseOrderNumber is a required property for InvoiceItem and cannot be null");
            }
            else
            {
                this.PurchaseOrderNumber = purchaseOrderNumber;
            }
            this.BuyerProductIdentifier = buyerProductIdentifier;
            this.VendorProductIdentifier = vendorProductIdentifier;
            this.VendorOrderNumber = vendorOrderNumber;
            this.HsnCode = hsnCode;
            this.TaxDetails = taxDetails;
            this.ChargeDetails = chargeDetails;
        }

        /// <summary>
        /// Numbering of the item on the purchase order. The first item will be 1, the second 2, and so on.
        /// </summary>
        /// <value>Numbering of the item on the purchase order. The first item will be 1, the second 2, and so on.</value>
        [DataMember(Name = "itemSequenceNumber", EmitDefaultValue = false)]
        public string ItemSequenceNumber { get; set; }

        /// <summary>
        /// Buyer&#39;s standard identification number (ASIN) of an item.
        /// </summary>
        /// <value>Buyer&#39;s standard identification number (ASIN) of an item.</value>
        [DataMember(Name = "buyerProductIdentifier", EmitDefaultValue = false)]
        public string BuyerProductIdentifier { get; set; }

        /// <summary>
        /// The vendor selected product identification of the item.
        /// </summary>
        /// <value>The vendor selected product identification of the item.</value>
        [DataMember(Name = "vendorProductIdentifier", EmitDefaultValue = false)]
        public string VendorProductIdentifier { get; set; }

        /// <summary>
        /// Item quantity invoiced.
        /// </summary>
        /// <value>Item quantity invoiced.</value>
        [DataMember(Name = "invoicedQuantity", EmitDefaultValue = false)]
        public ItemQuantity InvoicedQuantity { get; set; }

        /// <summary>
        /// Net price (before tax) to vendor with currency details.
        /// </summary>
        /// <value>Net price (before tax) to vendor with currency details.</value>
        [DataMember(Name = "netCost", EmitDefaultValue = false)]
        public Money NetCost { get; set; }

        /// <summary>
        /// The purchase order number for this order. Formatting Notes: 8-character alpha-numeric code.
        /// </summary>
        /// <value>The purchase order number for this order. Formatting Notes: 8-character alpha-numeric code.</value>
        [DataMember(Name = "purchaseOrderNumber", EmitDefaultValue = false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The vendor&#39;s order number for this order.
        /// </summary>
        /// <value>The vendor&#39;s order number for this order.</value>
        [DataMember(Name = "vendorOrderNumber", EmitDefaultValue = false)]
        public string VendorOrderNumber { get; set; }

        /// <summary>
        /// Harmonized System of Nomenclature (HSN) tax code. The HSN number cannot contain alphabets.
        /// </summary>
        /// <value>Harmonized System of Nomenclature (HSN) tax code. The HSN number cannot contain alphabets.</value>
        [DataMember(Name = "hsnCode", EmitDefaultValue = false)]
        public string HsnCode { get; set; }

        /// <summary>
        /// Individual tax details per line item.
        /// </summary>
        /// <value>Individual tax details per line item.</value>
        [DataMember(Name = "taxDetails", EmitDefaultValue = false)]
        public List<TaxDetail> TaxDetails { get; set; }

        /// <summary>
        /// Individual charge details per line item.
        /// </summary>
        /// <value>Individual charge details per line item.</value>
        [DataMember(Name = "chargeDetails", EmitDefaultValue = false)]
        public List<ChargeDetails> ChargeDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceItem {\n");
            sb.Append("  ItemSequenceNumber: ").Append(ItemSequenceNumber).Append("\n");
            sb.Append("  BuyerProductIdentifier: ").Append(BuyerProductIdentifier).Append("\n");
            sb.Append("  VendorProductIdentifier: ").Append(VendorProductIdentifier).Append("\n");
            sb.Append("  InvoicedQuantity: ").Append(InvoicedQuantity).Append("\n");
            sb.Append("  NetCost: ").Append(NetCost).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  VendorOrderNumber: ").Append(VendorOrderNumber).Append("\n");
            sb.Append("  HsnCode: ").Append(HsnCode).Append("\n");
            sb.Append("  TaxDetails: ").Append(TaxDetails).Append("\n");
            sb.Append("  ChargeDetails: ").Append(ChargeDetails).Append("\n");
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
            return this.Equals(input as InvoiceItem);
        }

        /// <summary>
        /// Returns true if InvoiceItem instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceItem input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ItemSequenceNumber == input.ItemSequenceNumber ||
                    (this.ItemSequenceNumber != null &&
                    this.ItemSequenceNumber.Equals(input.ItemSequenceNumber))
                ) &&
                (
                    this.BuyerProductIdentifier == input.BuyerProductIdentifier ||
                    (this.BuyerProductIdentifier != null &&
                    this.BuyerProductIdentifier.Equals(input.BuyerProductIdentifier))
                ) &&
                (
                    this.VendorProductIdentifier == input.VendorProductIdentifier ||
                    (this.VendorProductIdentifier != null &&
                    this.VendorProductIdentifier.Equals(input.VendorProductIdentifier))
                ) &&
                (
                    this.InvoicedQuantity == input.InvoicedQuantity ||
                    (this.InvoicedQuantity != null &&
                    this.InvoicedQuantity.Equals(input.InvoicedQuantity))
                ) &&
                (
                    this.NetCost == input.NetCost ||
                    (this.NetCost != null &&
                    this.NetCost.Equals(input.NetCost))
                ) &&
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) &&
                (
                    this.VendorOrderNumber == input.VendorOrderNumber ||
                    (this.VendorOrderNumber != null &&
                    this.VendorOrderNumber.Equals(input.VendorOrderNumber))
                ) &&
                (
                    this.HsnCode == input.HsnCode ||
                    (this.HsnCode != null &&
                    this.HsnCode.Equals(input.HsnCode))
                ) &&
                (
                    this.TaxDetails == input.TaxDetails ||
                    this.TaxDetails != null &&
                    this.TaxDetails.SequenceEqual(input.TaxDetails)
                ) &&
                (
                    this.ChargeDetails == input.ChargeDetails ||
                    this.ChargeDetails != null &&
                    this.ChargeDetails.SequenceEqual(input.ChargeDetails)
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
                if (this.ItemSequenceNumber != null)
                    hashCode = hashCode * 59 + this.ItemSequenceNumber.GetHashCode();
                if (this.BuyerProductIdentifier != null)
                    hashCode = hashCode * 59 + this.BuyerProductIdentifier.GetHashCode();
                if (this.VendorProductIdentifier != null)
                    hashCode = hashCode * 59 + this.VendorProductIdentifier.GetHashCode();
                if (this.InvoicedQuantity != null)
                    hashCode = hashCode * 59 + this.InvoicedQuantity.GetHashCode();
                if (this.NetCost != null)
                    hashCode = hashCode * 59 + this.NetCost.GetHashCode();
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.VendorOrderNumber != null)
                    hashCode = hashCode * 59 + this.VendorOrderNumber.GetHashCode();
                if (this.HsnCode != null)
                    hashCode = hashCode * 59 + this.HsnCode.GetHashCode();
                if (this.TaxDetails != null)
                    hashCode = hashCode * 59 + this.TaxDetails.GetHashCode();
                if (this.ChargeDetails != null)
                    hashCode = hashCode * 59 + this.ChargeDetails.GetHashCode();
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
