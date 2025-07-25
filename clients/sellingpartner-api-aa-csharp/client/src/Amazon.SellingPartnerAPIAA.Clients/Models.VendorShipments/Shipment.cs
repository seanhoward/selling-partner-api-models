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
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorShipments
{
    /// <summary>
    /// A list of one or more shipments with respective details.
    /// </summary>
    [DataContract]
    public partial class Shipment : IEquatable<Shipment>, IValidatableObject
    {
        /// <summary>
        /// Indicates the type of transportation request (for example, &#x60;New&#x60; or &#x60;Cancel&#x60;). Each &#x60;transactionType&#x60; has a unique set of operations and there are corresponding details to be populated for each operation.
        /// </summary>
        /// <value>Indicates the type of transportation request (for example, &#x60;New&#x60; or &#x60;Cancel&#x60;). Each &#x60;transactionType&#x60; has a unique set of operations and there are corresponding details to be populated for each operation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionTypeEnum
        {

            /// <summary>
            /// Enum New for value: New
            /// </summary>
            [EnumMember(Value = "New")]
            New = 1,

            /// <summary>
            /// Enum Cancel for value: Cancel
            /// </summary>
            [EnumMember(Value = "Cancel")]
            Cancel = 2
        }

        /// <summary>
        /// Indicates the type of transportation request (for example, &#x60;New&#x60; or &#x60;Cancel&#x60;). Each &#x60;transactionType&#x60; has a unique set of operations and there are corresponding details to be populated for each operation.
        /// </summary>
        /// <value>Indicates the type of transportation request (for example, &#x60;New&#x60; or &#x60;Cancel&#x60;). Each &#x60;transactionType&#x60; has a unique set of operations and there are corresponding details to be populated for each operation.</value>
        [DataMember(Name = "transactionType", EmitDefaultValue = false)]
        public TransactionTypeEnum TransactionType { get; set; }
        /// <summary>
        /// Indicates the current shipment status.
        /// </summary>
        /// <value>Indicates the current shipment status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrentShipmentStatusEnum
        {

            /// <summary>
            /// Enum Created for value: Created
            /// </summary>
            [EnumMember(Value = "Created")]
            Created = 1,

            /// <summary>
            /// Enum TransportationRequested for value: TransportationRequested
            /// </summary>
            [EnumMember(Value = "TransportationRequested")]
            TransportationRequested = 2,

            /// <summary>
            /// Enum CarrierAssigned for value: CarrierAssigned
            /// </summary>
            [EnumMember(Value = "CarrierAssigned")]
            CarrierAssigned = 3,

            /// <summary>
            /// Enum Shipped for value: Shipped
            /// </summary>
            [EnumMember(Value = "Shipped")]
            Shipped = 4
        }

        /// <summary>
        /// Indicates the current shipment status.
        /// </summary>
        /// <value>Indicates the current shipment status.</value>
        [DataMember(Name = "currentShipmentStatus", EmitDefaultValue = false)]
        public CurrentShipmentStatusEnum? CurrentShipmentStatus { get; set; }
        /// <summary>
        /// Specifies if payment is Collect (WePay) or Prepaid (TheyPay). Required.
        /// </summary>
        /// <value>Specifies if payment is Collect (WePay) or Prepaid (TheyPay). Required.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShipmentFreightTermEnum
        {

            /// <summary>
            /// Enum Collect for value: Collect
            /// </summary>
            [EnumMember(Value = "Collect")]
            Collect = 1,

            /// <summary>
            /// Enum Prepaid for value: Prepaid
            /// </summary>
            [EnumMember(Value = "Prepaid")]
            Prepaid = 2
        }

        /// <summary>
        /// Specifies if payment is Collect (WePay) or Prepaid (TheyPay). Required.
        /// </summary>
        /// <value>Specifies if payment is Collect (WePay) or Prepaid (TheyPay). Required.</value>
        [DataMember(Name = "shipmentFreightTerm", EmitDefaultValue = false)]
        public ShipmentFreightTermEnum? ShipmentFreightTerm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipment" /> class.
        /// </summary>
        [JsonConstructor]
        protected Shipment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipment" /> class.
        /// </summary>
        /// <param name="vendorShipmentIdentifier">Unique Transportation ID created by Vendor (Should not be used over the last 365 days). (required).</param>
        /// <param name="transactionType">Indicates the type of transportation request (for example, &#x60;New&#x60; or &#x60;Cancel&#x60;). Each &#x60;transactionType&#x60; has a unique set of operations and there are corresponding details to be populated for each operation. (required).</param>
        /// <param name="buyerReferenceNumber">The buyer Reference Number is a unique identifier generated by buyer for all Collect/WePay shipments when you submit a transportation request. This field is mandatory for Collect/WePay shipments..</param>
        /// <param name="transactionDate">Date on which the transportation request was submitted. (required).</param>
        /// <param name="currentShipmentStatus">Indicates the current shipment status..</param>
        /// <param name="currentshipmentStatusDate">Date and time when the last status was updated..</param>
        /// <param name="shipmentStatusDetails">Indicates the list of current shipment status details and when the last update was received from carrier this is available on shipment Details response..</param>
        /// <param name="shipmentCreateDate">The date and time of the shipment request created by vendor..</param>
        /// <param name="shipmentConfirmDate">The date and time of the departure of the shipment from the vendor&#39;s location. Vendors are requested to send ASNs within 30 minutes of departure from their warehouse/distribution center or at least 6 hours prior to the appointment time at the Buyer destination warehouse, whichever is sooner. Shipped date mentioned in the shipment confirmation should not be in the future..</param>
        /// <param name="packageLabelCreateDate">The date and time of the package label created for the shipment by buyer..</param>
        /// <param name="shipmentFreightTerm">Specifies if payment is Collect (WePay) or Prepaid (TheyPay). Required..</param>
        /// <param name="sellingParty">Name/Address and tax details of the selling party. (required).</param>
        /// <param name="shipFromParty">Name/Address and tax details of the ship from party. (required).</param>
        /// <param name="shipToParty">Name/Address of the destination warehouse where the shipment is being shipped to. (required).</param>
        /// <param name="shipmentMeasurements">Indicates the shipment measurement details on how many cartons and pallets and the total transportation weight and volume as part of this request. This is a mandatory detail which will help determining the transportation cost, truck allocations and route determination efficiently..</param>
        /// <param name="collectFreightPickupDetails">Indicates the earliest pickup date for the transportation from vendor warehouse. This information is mandatory to be filled for requesting transportation from Buyer (WePay/Collect)..</param>
        /// <param name="purchaseOrders">Indicates the purchase orders involved for the transportation request. This group is an array create 1 for each PO and list their corresponding items. This information is used for deciding the route,truck allocation and storage efficiently. This is a mandatory information for Buyer performing transportation from vendor warehouse (WePay/Collect).</param>
        /// <param name="importDetails">Provide these fields only if this shipment is a direct import..</param>
        /// <param name="containers">A list of the items in this transportation and their associated inner container details. If any of the item detail fields are common at a carton or a pallet level, provide them at the corresponding carton or pallet level..</param>
        /// <param name="transportationDetails">Transportation details this a mandatory information which states delivery date, shipping date and carrier details..</param>
        public Shipment(string vendorShipmentIdentifier = default, TransactionTypeEnum transactionType = default, string buyerReferenceNumber = default, DateTime? transactionDate = default, CurrentShipmentStatusEnum? currentShipmentStatus = default, DateTime? currentshipmentStatusDate = default, List<ShipmentStatusDetails> shipmentStatusDetails = default, DateTime? shipmentCreateDate = default, DateTime? shipmentConfirmDate = default, DateTime? packageLabelCreateDate = default, ShipmentFreightTermEnum? shipmentFreightTerm = default, PartyIdentification sellingParty = default, PartyIdentification shipFromParty = default, PartyIdentification shipToParty = default, TransportShipmentMeasurements shipmentMeasurements = default, CollectFreightPickupDetails collectFreightPickupDetails = default, List<PurchaseOrders> purchaseOrders = default, ImportDetails importDetails = default, List<Containers> containers = default, TransportationDetails transportationDetails = default)
        {
            // to ensure "vendorShipmentIdentifier" is required (not null)
            if (vendorShipmentIdentifier == null)
            {
                throw new InvalidDataException("vendorShipmentIdentifier is a required property for Shipment and cannot be null");
            }
            else
            {
                this.VendorShipmentIdentifier = vendorShipmentIdentifier;
            }
            // to ensure "transactionType" is required (not null)
            if (transactionType == null)
            {
                throw new InvalidDataException("transactionType is a required property for Shipment and cannot be null");
            }
            else
            {
                this.TransactionType = transactionType;
            }
            // to ensure "transactionDate" is required (not null)
            if (transactionDate == null)
            {
                throw new InvalidDataException("transactionDate is a required property for Shipment and cannot be null");
            }
            else
            {
                this.TransactionDate = transactionDate;
            }
            // to ensure "sellingParty" is required (not null)
            if (sellingParty == null)
            {
                throw new InvalidDataException("sellingParty is a required property for Shipment and cannot be null");
            }
            else
            {
                this.SellingParty = sellingParty;
            }
            // to ensure "shipFromParty" is required (not null)
            if (shipFromParty == null)
            {
                throw new InvalidDataException("shipFromParty is a required property for Shipment and cannot be null");
            }
            else
            {
                this.ShipFromParty = shipFromParty;
            }
            // to ensure "shipToParty" is required (not null)
            if (shipToParty == null)
            {
                throw new InvalidDataException("shipToParty is a required property for Shipment and cannot be null");
            }
            else
            {
                this.ShipToParty = shipToParty;
            }
            this.BuyerReferenceNumber = buyerReferenceNumber;
            this.CurrentShipmentStatus = currentShipmentStatus;
            this.CurrentshipmentStatusDate = currentshipmentStatusDate;
            this.ShipmentStatusDetails = shipmentStatusDetails;
            this.ShipmentCreateDate = shipmentCreateDate;
            this.ShipmentConfirmDate = shipmentConfirmDate;
            this.PackageLabelCreateDate = packageLabelCreateDate;
            this.ShipmentFreightTerm = shipmentFreightTerm;
            this.ShipmentMeasurements = shipmentMeasurements;
            this.CollectFreightPickupDetails = collectFreightPickupDetails;
            this.PurchaseOrders = purchaseOrders;
            this.ImportDetails = importDetails;
            this.Containers = containers;
            this.TransportationDetails = transportationDetails;
        }

        /// <summary>
        /// Unique Transportation ID created by Vendor (Should not be used over the last 365 days).
        /// </summary>
        /// <value>Unique Transportation ID created by Vendor (Should not be used over the last 365 days).</value>
        [DataMember(Name = "vendorShipmentIdentifier", EmitDefaultValue = false)]
        public string VendorShipmentIdentifier { get; set; }


        /// <summary>
        /// The buyer Reference Number is a unique identifier generated by buyer for all Collect/WePay shipments when you submit a transportation request. This field is mandatory for Collect/WePay shipments.
        /// </summary>
        /// <value>The buyer Reference Number is a unique identifier generated by buyer for all Collect/WePay shipments when you submit a transportation request. This field is mandatory for Collect/WePay shipments.</value>
        [DataMember(Name = "buyerReferenceNumber", EmitDefaultValue = false)]
        public string BuyerReferenceNumber { get; set; }

        /// <summary>
        /// Date on which the transportation request was submitted.
        /// </summary>
        /// <value>Date on which the transportation request was submitted.</value>
        [DataMember(Name = "transactionDate", EmitDefaultValue = false)]
        public DateTime? TransactionDate { get; set; }


        /// <summary>
        /// Date and time when the last status was updated.
        /// </summary>
        /// <value>Date and time when the last status was updated.</value>
        [DataMember(Name = "currentshipmentStatusDate", EmitDefaultValue = false)]
        public DateTime? CurrentshipmentStatusDate { get; set; }

        /// <summary>
        /// Indicates the list of current shipment status details and when the last update was received from carrier this is available on shipment Details response.
        /// </summary>
        /// <value>Indicates the list of current shipment status details and when the last update was received from carrier this is available on shipment Details response.</value>
        [DataMember(Name = "shipmentStatusDetails", EmitDefaultValue = false)]
        public List<ShipmentStatusDetails> ShipmentStatusDetails { get; set; }

        /// <summary>
        /// The date and time of the shipment request created by vendor.
        /// </summary>
        /// <value>The date and time of the shipment request created by vendor.</value>
        [DataMember(Name = "shipmentCreateDate", EmitDefaultValue = false)]
        public DateTime? ShipmentCreateDate { get; set; }

        /// <summary>
        /// The date and time of the departure of the shipment from the vendor&#39;s location. Vendors are requested to send ASNs within 30 minutes of departure from their warehouse/distribution center or at least 6 hours prior to the appointment time at the Buyer destination warehouse, whichever is sooner. Shipped date mentioned in the shipment confirmation should not be in the future.
        /// </summary>
        /// <value>The date and time of the departure of the shipment from the vendor&#39;s location. Vendors are requested to send ASNs within 30 minutes of departure from their warehouse/distribution center or at least 6 hours prior to the appointment time at the Buyer destination warehouse, whichever is sooner. Shipped date mentioned in the shipment confirmation should not be in the future.</value>
        [DataMember(Name = "shipmentConfirmDate", EmitDefaultValue = false)]
        public DateTime? ShipmentConfirmDate { get; set; }

        /// <summary>
        /// The date and time of the package label created for the shipment by buyer.
        /// </summary>
        /// <value>The date and time of the package label created for the shipment by buyer.</value>
        [DataMember(Name = "packageLabelCreateDate", EmitDefaultValue = false)]
        public DateTime? PackageLabelCreateDate { get; set; }


        /// <summary>
        /// Name/Address and tax details of the selling party.
        /// </summary>
        /// <value>Name/Address and tax details of the selling party.</value>
        [DataMember(Name = "sellingParty", EmitDefaultValue = false)]
        public PartyIdentification SellingParty { get; set; }

        /// <summary>
        /// Name/Address and tax details of the ship from party.
        /// </summary>
        /// <value>Name/Address and tax details of the ship from party.</value>
        [DataMember(Name = "shipFromParty", EmitDefaultValue = false)]
        public PartyIdentification ShipFromParty { get; set; }

        /// <summary>
        /// Name/Address of the destination warehouse where the shipment is being shipped to.
        /// </summary>
        /// <value>Name/Address of the destination warehouse where the shipment is being shipped to.</value>
        [DataMember(Name = "shipToParty", EmitDefaultValue = false)]
        public PartyIdentification ShipToParty { get; set; }

        /// <summary>
        /// Indicates the shipment measurement details on how many cartons and pallets and the total transportation weight and volume as part of this request. This is a mandatory detail which will help determining the transportation cost, truck allocations and route determination efficiently.
        /// </summary>
        /// <value>Indicates the shipment measurement details on how many cartons and pallets and the total transportation weight and volume as part of this request. This is a mandatory detail which will help determining the transportation cost, truck allocations and route determination efficiently.</value>
        [DataMember(Name = "shipmentMeasurements", EmitDefaultValue = false)]
        public TransportShipmentMeasurements ShipmentMeasurements { get; set; }

        /// <summary>
        /// Indicates the earliest pickup date for the transportation from vendor warehouse. This information is mandatory to be filled for requesting transportation from Buyer (WePay/Collect).
        /// </summary>
        /// <value>Indicates the earliest pickup date for the transportation from vendor warehouse. This information is mandatory to be filled for requesting transportation from Buyer (WePay/Collect).</value>
        [DataMember(Name = "collectFreightPickupDetails", EmitDefaultValue = false)]
        public CollectFreightPickupDetails CollectFreightPickupDetails { get; set; }

        /// <summary>
        /// Indicates the purchase orders involved for the transportation request. This group is an array create 1 for each PO and list their corresponding items. This information is used for deciding the route,truck allocation and storage efficiently. This is a mandatory information for Buyer performing transportation from vendor warehouse (WePay/Collect)
        /// </summary>
        /// <value>Indicates the purchase orders involved for the transportation request. This group is an array create 1 for each PO and list their corresponding items. This information is used for deciding the route,truck allocation and storage efficiently. This is a mandatory information for Buyer performing transportation from vendor warehouse (WePay/Collect)</value>
        [DataMember(Name = "purchaseOrders", EmitDefaultValue = false)]
        public List<PurchaseOrders> PurchaseOrders { get; set; }

        /// <summary>
        /// Provide these fields only if this shipment is a direct import.
        /// </summary>
        /// <value>Provide these fields only if this shipment is a direct import.</value>
        [DataMember(Name = "importDetails", EmitDefaultValue = false)]
        public ImportDetails ImportDetails { get; set; }

        /// <summary>
        /// A list of the items in this transportation and their associated inner container details. If any of the item detail fields are common at a carton or a pallet level, provide them at the corresponding carton or pallet level.
        /// </summary>
        /// <value>A list of the items in this transportation and their associated inner container details. If any of the item detail fields are common at a carton or a pallet level, provide them at the corresponding carton or pallet level.</value>
        [DataMember(Name = "containers", EmitDefaultValue = false)]
        public List<Containers> Containers { get; set; }

        /// <summary>
        /// Transportation details this a mandatory information which states delivery date, shipping date and carrier details.
        /// </summary>
        /// <value>Transportation details this a mandatory information which states delivery date, shipping date and carrier details.</value>
        [DataMember(Name = "transportationDetails", EmitDefaultValue = false)]
        public TransportationDetails TransportationDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Shipment {\n");
            sb.Append("  VendorShipmentIdentifier: ").Append(VendorShipmentIdentifier).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  BuyerReferenceNumber: ").Append(BuyerReferenceNumber).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  CurrentShipmentStatus: ").Append(CurrentShipmentStatus).Append("\n");
            sb.Append("  CurrentshipmentStatusDate: ").Append(CurrentshipmentStatusDate).Append("\n");
            sb.Append("  ShipmentStatusDetails: ").Append(ShipmentStatusDetails).Append("\n");
            sb.Append("  ShipmentCreateDate: ").Append(ShipmentCreateDate).Append("\n");
            sb.Append("  ShipmentConfirmDate: ").Append(ShipmentConfirmDate).Append("\n");
            sb.Append("  PackageLabelCreateDate: ").Append(PackageLabelCreateDate).Append("\n");
            sb.Append("  ShipmentFreightTerm: ").Append(ShipmentFreightTerm).Append("\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  ShipFromParty: ").Append(ShipFromParty).Append("\n");
            sb.Append("  ShipToParty: ").Append(ShipToParty).Append("\n");
            sb.Append("  ShipmentMeasurements: ").Append(ShipmentMeasurements).Append("\n");
            sb.Append("  CollectFreightPickupDetails: ").Append(CollectFreightPickupDetails).Append("\n");
            sb.Append("  PurchaseOrders: ").Append(PurchaseOrders).Append("\n");
            sb.Append("  ImportDetails: ").Append(ImportDetails).Append("\n");
            sb.Append("  Containers: ").Append(Containers).Append("\n");
            sb.Append("  TransportationDetails: ").Append(TransportationDetails).Append("\n");
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
                    this.VendorShipmentIdentifier == input.VendorShipmentIdentifier ||
                    (this.VendorShipmentIdentifier != null &&
                    this.VendorShipmentIdentifier.Equals(input.VendorShipmentIdentifier))
                ) &&
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) &&
                (
                    this.BuyerReferenceNumber == input.BuyerReferenceNumber ||
                    (this.BuyerReferenceNumber != null &&
                    this.BuyerReferenceNumber.Equals(input.BuyerReferenceNumber))
                ) &&
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) &&
                (
                    this.CurrentShipmentStatus == input.CurrentShipmentStatus ||
                    (this.CurrentShipmentStatus != null &&
                    this.CurrentShipmentStatus.Equals(input.CurrentShipmentStatus))
                ) &&
                (
                    this.CurrentshipmentStatusDate == input.CurrentshipmentStatusDate ||
                    (this.CurrentshipmentStatusDate != null &&
                    this.CurrentshipmentStatusDate.Equals(input.CurrentshipmentStatusDate))
                ) &&
                (
                    this.ShipmentStatusDetails == input.ShipmentStatusDetails ||
                    this.ShipmentStatusDetails != null &&
                    this.ShipmentStatusDetails.SequenceEqual(input.ShipmentStatusDetails)
                ) &&
                (
                    this.ShipmentCreateDate == input.ShipmentCreateDate ||
                    (this.ShipmentCreateDate != null &&
                    this.ShipmentCreateDate.Equals(input.ShipmentCreateDate))
                ) &&
                (
                    this.ShipmentConfirmDate == input.ShipmentConfirmDate ||
                    (this.ShipmentConfirmDate != null &&
                    this.ShipmentConfirmDate.Equals(input.ShipmentConfirmDate))
                ) &&
                (
                    this.PackageLabelCreateDate == input.PackageLabelCreateDate ||
                    (this.PackageLabelCreateDate != null &&
                    this.PackageLabelCreateDate.Equals(input.PackageLabelCreateDate))
                ) &&
                (
                    this.ShipmentFreightTerm == input.ShipmentFreightTerm ||
                    (this.ShipmentFreightTerm != null &&
                    this.ShipmentFreightTerm.Equals(input.ShipmentFreightTerm))
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
                    this.ShipToParty == input.ShipToParty ||
                    (this.ShipToParty != null &&
                    this.ShipToParty.Equals(input.ShipToParty))
                ) &&
                (
                    this.ShipmentMeasurements == input.ShipmentMeasurements ||
                    (this.ShipmentMeasurements != null &&
                    this.ShipmentMeasurements.Equals(input.ShipmentMeasurements))
                ) &&
                (
                    this.CollectFreightPickupDetails == input.CollectFreightPickupDetails ||
                    (this.CollectFreightPickupDetails != null &&
                    this.CollectFreightPickupDetails.Equals(input.CollectFreightPickupDetails))
                ) &&
                (
                    this.PurchaseOrders == input.PurchaseOrders ||
                    this.PurchaseOrders != null &&
                    this.PurchaseOrders.SequenceEqual(input.PurchaseOrders)
                ) &&
                (
                    this.ImportDetails == input.ImportDetails ||
                    (this.ImportDetails != null &&
                    this.ImportDetails.Equals(input.ImportDetails))
                ) &&
                (
                    this.Containers == input.Containers ||
                    this.Containers != null &&
                    this.Containers.SequenceEqual(input.Containers)
                ) &&
                (
                    this.TransportationDetails == input.TransportationDetails ||
                    (this.TransportationDetails != null &&
                    this.TransportationDetails.Equals(input.TransportationDetails))
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
                if (this.VendorShipmentIdentifier != null)
                    hashCode = hashCode * 59 + this.VendorShipmentIdentifier.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.BuyerReferenceNumber != null)
                    hashCode = hashCode * 59 + this.BuyerReferenceNumber.GetHashCode();
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                if (this.CurrentShipmentStatus != null)
                    hashCode = hashCode * 59 + this.CurrentShipmentStatus.GetHashCode();
                if (this.CurrentshipmentStatusDate != null)
                    hashCode = hashCode * 59 + this.CurrentshipmentStatusDate.GetHashCode();
                if (this.ShipmentStatusDetails != null)
                    hashCode = hashCode * 59 + this.ShipmentStatusDetails.GetHashCode();
                if (this.ShipmentCreateDate != null)
                    hashCode = hashCode * 59 + this.ShipmentCreateDate.GetHashCode();
                if (this.ShipmentConfirmDate != null)
                    hashCode = hashCode * 59 + this.ShipmentConfirmDate.GetHashCode();
                if (this.PackageLabelCreateDate != null)
                    hashCode = hashCode * 59 + this.PackageLabelCreateDate.GetHashCode();
                if (this.ShipmentFreightTerm != null)
                    hashCode = hashCode * 59 + this.ShipmentFreightTerm.GetHashCode();
                if (this.SellingParty != null)
                    hashCode = hashCode * 59 + this.SellingParty.GetHashCode();
                if (this.ShipFromParty != null)
                    hashCode = hashCode * 59 + this.ShipFromParty.GetHashCode();
                if (this.ShipToParty != null)
                    hashCode = hashCode * 59 + this.ShipToParty.GetHashCode();
                if (this.ShipmentMeasurements != null)
                    hashCode = hashCode * 59 + this.ShipmentMeasurements.GetHashCode();
                if (this.CollectFreightPickupDetails != null)
                    hashCode = hashCode * 59 + this.CollectFreightPickupDetails.GetHashCode();
                if (this.PurchaseOrders != null)
                    hashCode = hashCode * 59 + this.PurchaseOrders.GetHashCode();
                if (this.ImportDetails != null)
                    hashCode = hashCode * 59 + this.ImportDetails.GetHashCode();
                if (this.Containers != null)
                    hashCode = hashCode * 59 + this.Containers.GetHashCode();
                if (this.TransportationDetails != null)
                    hashCode = hashCode * 59 + this.TransportationDetails.GetHashCode();
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
