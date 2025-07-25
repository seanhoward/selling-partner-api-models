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
    /// A list of one or more shipment confirmations.
    /// </summary>
    [DataContract]
    public partial class ShipmentConfirmation : IEquatable<ShipmentConfirmation>, IValidatableObject
    {
        /// <summary>
        /// Indicates if this shipment confirmation is the initial confirmation, or intended to replace an already posted shipment confirmation. If replacing an existing shipment confirmation, be sure to provide the identical shipmentIdentifier and sellingParty information as in the previous confirmation.
        /// </summary>
        /// <value>Indicates if this shipment confirmation is the initial confirmation, or intended to replace an already posted shipment confirmation. If replacing an existing shipment confirmation, be sure to provide the identical shipmentIdentifier and sellingParty information as in the previous confirmation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShipmentConfirmationTypeEnum
        {

            /// <summary>
            /// Enum Original for value: Original
            /// </summary>
            [EnumMember(Value = "Original")]
            Original = 1,

            /// <summary>
            /// Enum Replace for value: Replace
            /// </summary>
            [EnumMember(Value = "Replace")]
            Replace = 2
        }

        /// <summary>
        /// Indicates if this shipment confirmation is the initial confirmation, or intended to replace an already posted shipment confirmation. If replacing an existing shipment confirmation, be sure to provide the identical shipmentIdentifier and sellingParty information as in the previous confirmation.
        /// </summary>
        /// <value>Indicates if this shipment confirmation is the initial confirmation, or intended to replace an already posted shipment confirmation. If replacing an existing shipment confirmation, be sure to provide the identical shipmentIdentifier and sellingParty information as in the previous confirmation.</value>
        [DataMember(Name = "shipmentConfirmationType", EmitDefaultValue = false)]
        public ShipmentConfirmationTypeEnum ShipmentConfirmationType { get; set; }
        /// <summary>
        /// The type of shipment.
        /// </summary>
        /// <value>The type of shipment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShipmentTypeEnum
        {

            /// <summary>
            /// Enum TruckLoad for value: TruckLoad
            /// </summary>
            [EnumMember(Value = "TruckLoad")]
            TruckLoad = 1,

            /// <summary>
            /// Enum LessThanTruckLoad for value: LessThanTruckLoad
            /// </summary>
            [EnumMember(Value = "LessThanTruckLoad")]
            LessThanTruckLoad = 2,

            /// <summary>
            /// Enum SmallParcel for value: SmallParcel
            /// </summary>
            [EnumMember(Value = "SmallParcel")]
            SmallParcel = 3
        }

        /// <summary>
        /// The type of shipment.
        /// </summary>
        /// <value>The type of shipment.</value>
        [DataMember(Name = "shipmentType", EmitDefaultValue = false)]
        public ShipmentTypeEnum? ShipmentType { get; set; }
        /// <summary>
        /// Shipment hierarchical structure.
        /// </summary>
        /// <value>Shipment hierarchical structure.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShipmentStructureEnum
        {

            /// <summary>
            /// Enum PalletizedAssortmentCase for value: PalletizedAssortmentCase
            /// </summary>
            [EnumMember(Value = "PalletizedAssortmentCase")]
            PalletizedAssortmentCase = 1,

            /// <summary>
            /// Enum LooseAssortmentCase for value: LooseAssortmentCase
            /// </summary>
            [EnumMember(Value = "LooseAssortmentCase")]
            LooseAssortmentCase = 2,

            /// <summary>
            /// Enum PalletOfItems for value: PalletOfItems
            /// </summary>
            [EnumMember(Value = "PalletOfItems")]
            PalletOfItems = 3,

            /// <summary>
            /// Enum PalletizedStandardCase for value: PalletizedStandardCase
            /// </summary>
            [EnumMember(Value = "PalletizedStandardCase")]
            PalletizedStandardCase = 4,

            /// <summary>
            /// Enum LooseStandardCase for value: LooseStandardCase
            /// </summary>
            [EnumMember(Value = "LooseStandardCase")]
            LooseStandardCase = 5,

            /// <summary>
            /// Enum MasterPallet for value: MasterPallet
            /// </summary>
            [EnumMember(Value = "MasterPallet")]
            MasterPallet = 6,

            /// <summary>
            /// Enum MasterCase for value: MasterCase
            /// </summary>
            [EnumMember(Value = "MasterCase")]
            MasterCase = 7
        }

        /// <summary>
        /// Shipment hierarchical structure.
        /// </summary>
        /// <value>Shipment hierarchical structure.</value>
        [DataMember(Name = "shipmentStructure", EmitDefaultValue = false)]
        public ShipmentStructureEnum? ShipmentStructure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentConfirmation" /> class.
        /// </summary>
        [JsonConstructor]
        protected ShipmentConfirmation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentConfirmation" /> class.
        /// </summary>
        /// <param name="shipmentIdentifier">Unique shipment ID (not used over the last 365 days). (required).</param>
        /// <param name="shipmentConfirmationType">Indicates if this shipment confirmation is the initial confirmation, or intended to replace an already posted shipment confirmation. If replacing an existing shipment confirmation, be sure to provide the identical shipmentIdentifier and sellingParty information as in the previous confirmation. (required).</param>
        /// <param name="shipmentType">The type of shipment..</param>
        /// <param name="shipmentStructure">Shipment hierarchical structure..</param>
        /// <param name="transportationDetails">Transportation details for this shipment..</param>
        /// <param name="amazonReferenceNumber">The Amazon Reference Number is a unique identifier generated by Amazon for all Collect/WePay shipments when you submit  a routing request. This field is mandatory for Collect/WePay shipments..</param>
        /// <param name="shipmentConfirmationDate">Date on which the shipment confirmation was submitted. (required).</param>
        /// <param name="shippedDate">The date and time of the departure of the shipment from the vendor&#39;s location. Vendors are requested to send ASNs within 30 minutes of departure from their warehouse/distribution center or at least 6 hours prior to the appointment time at the buyer destination warehouse, whichever is sooner. Shipped date mentioned in the shipment confirmation should not be in the future..</param>
        /// <param name="estimatedDeliveryDate">The date and time on which the shipment is estimated to reach buyer&#39;s warehouse. It needs to be an estimate based on the average transit time between ship from location and the destination. The exact appointment time will be provided by the buyer and is potentially not known when creating the shipment confirmation..</param>
        /// <param name="sellingParty">Name/Address and tax details of the selling party. (required).</param>
        /// <param name="shipFromParty">Name/Address and tax details of the ship from party. (required).</param>
        /// <param name="shipToParty">Name/Address of the destination warehouse where the shipment is being shipped to. (required).</param>
        /// <param name="shipmentMeasurements">shipmentMeasurements.</param>
        /// <param name="importDetails">Provide these fields only if this shipment is a direct import..</param>
        /// <param name="shippedItems">A list of the items in this shipment and their associated details. If any of the item detail fields are common at a carton or a pallet level, provide them at the corresponding carton or pallet level. (required).</param>
        /// <param name="cartons">A list of the cartons in this shipment..</param>
        /// <param name="pallets">A list of the pallets in this shipment..</param>
        public ShipmentConfirmation(string shipmentIdentifier = default, ShipmentConfirmationTypeEnum shipmentConfirmationType = default, ShipmentTypeEnum? shipmentType = default, ShipmentStructureEnum? shipmentStructure = default, TransportationDetailsForShipmentConfirmation transportationDetails = default, string amazonReferenceNumber = default, DateTime? shipmentConfirmationDate = default, DateTime? shippedDate = default, DateTime? estimatedDeliveryDate = default, PartyIdentification sellingParty = default, PartyIdentification shipFromParty = default, PartyIdentification shipToParty = default, ShipmentMeasurements shipmentMeasurements = default, ImportDetails importDetails = default, List<Item> shippedItems = default, List<Carton> cartons = default, List<Pallet> pallets = default)
        {
            // to ensure "shipmentIdentifier" is required (not null)
            if (shipmentIdentifier == null)
            {
                throw new InvalidDataException("shipmentIdentifier is a required property for ShipmentConfirmation and cannot be null");
            }
            else
            {
                this.ShipmentIdentifier = shipmentIdentifier;
            }
            // to ensure "shipmentConfirmationType" is required (not null)
            if (shipmentConfirmationType == null)
            {
                throw new InvalidDataException("shipmentConfirmationType is a required property for ShipmentConfirmation and cannot be null");
            }
            else
            {
                this.ShipmentConfirmationType = shipmentConfirmationType;
            }
            // to ensure "shipmentConfirmationDate" is required (not null)
            if (shipmentConfirmationDate == null)
            {
                throw new InvalidDataException("shipmentConfirmationDate is a required property for ShipmentConfirmation and cannot be null");
            }
            else
            {
                this.ShipmentConfirmationDate = shipmentConfirmationDate;
            }
            // to ensure "sellingParty" is required (not null)
            if (sellingParty == null)
            {
                throw new InvalidDataException("sellingParty is a required property for ShipmentConfirmation and cannot be null");
            }
            else
            {
                this.SellingParty = sellingParty;
            }
            // to ensure "shipFromParty" is required (not null)
            if (shipFromParty == null)
            {
                throw new InvalidDataException("shipFromParty is a required property for ShipmentConfirmation and cannot be null");
            }
            else
            {
                this.ShipFromParty = shipFromParty;
            }
            // to ensure "shipToParty" is required (not null)
            if (shipToParty == null)
            {
                throw new InvalidDataException("shipToParty is a required property for ShipmentConfirmation and cannot be null");
            }
            else
            {
                this.ShipToParty = shipToParty;
            }
            // to ensure "shippedItems" is required (not null)
            if (shippedItems == null)
            {
                throw new InvalidDataException("shippedItems is a required property for ShipmentConfirmation and cannot be null");
            }
            else
            {
                this.ShippedItems = shippedItems;
            }
            this.ShipmentType = shipmentType;
            this.ShipmentStructure = shipmentStructure;
            this.TransportationDetails = transportationDetails;
            this.AmazonReferenceNumber = amazonReferenceNumber;
            this.ShippedDate = shippedDate;
            this.EstimatedDeliveryDate = estimatedDeliveryDate;
            this.ShipmentMeasurements = shipmentMeasurements;
            this.ImportDetails = importDetails;
            this.Cartons = cartons;
            this.Pallets = pallets;
        }

        /// <summary>
        /// Unique shipment ID (not used over the last 365 days).
        /// </summary>
        /// <value>Unique shipment ID (not used over the last 365 days).</value>
        [DataMember(Name = "shipmentIdentifier", EmitDefaultValue = false)]
        public string ShipmentIdentifier { get; set; }




        /// <summary>
        /// Transportation details for this shipment.
        /// </summary>
        /// <value>Transportation details for this shipment.</value>
        [DataMember(Name = "transportationDetails", EmitDefaultValue = false)]
        public TransportationDetailsForShipmentConfirmation TransportationDetails { get; set; }

        /// <summary>
        /// The Amazon Reference Number is a unique identifier generated by Amazon for all Collect/WePay shipments when you submit  a routing request. This field is mandatory for Collect/WePay shipments.
        /// </summary>
        /// <value>The Amazon Reference Number is a unique identifier generated by Amazon for all Collect/WePay shipments when you submit  a routing request. This field is mandatory for Collect/WePay shipments.</value>
        [DataMember(Name = "amazonReferenceNumber", EmitDefaultValue = false)]
        public string AmazonReferenceNumber { get; set; }

        /// <summary>
        /// Date on which the shipment confirmation was submitted.
        /// </summary>
        /// <value>Date on which the shipment confirmation was submitted.</value>
        [DataMember(Name = "shipmentConfirmationDate", EmitDefaultValue = false)]
        public DateTime? ShipmentConfirmationDate { get; set; }

        /// <summary>
        /// The date and time of the departure of the shipment from the vendor&#39;s location. Vendors are requested to send ASNs within 30 minutes of departure from their warehouse/distribution center or at least 6 hours prior to the appointment time at the buyer destination warehouse, whichever is sooner. Shipped date mentioned in the shipment confirmation should not be in the future.
        /// </summary>
        /// <value>The date and time of the departure of the shipment from the vendor&#39;s location. Vendors are requested to send ASNs within 30 minutes of departure from their warehouse/distribution center or at least 6 hours prior to the appointment time at the buyer destination warehouse, whichever is sooner. Shipped date mentioned in the shipment confirmation should not be in the future.</value>
        [DataMember(Name = "shippedDate", EmitDefaultValue = false)]
        public DateTime? ShippedDate { get; set; }

        /// <summary>
        /// The date and time on which the shipment is estimated to reach buyer&#39;s warehouse. It needs to be an estimate based on the average transit time between ship from location and the destination. The exact appointment time will be provided by the buyer and is potentially not known when creating the shipment confirmation.
        /// </summary>
        /// <value>The date and time on which the shipment is estimated to reach buyer&#39;s warehouse. It needs to be an estimate based on the average transit time between ship from location and the destination. The exact appointment time will be provided by the buyer and is potentially not known when creating the shipment confirmation.</value>
        [DataMember(Name = "estimatedDeliveryDate", EmitDefaultValue = false)]
        public DateTime? EstimatedDeliveryDate { get; set; }

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
        /// Gets or Sets ShipmentMeasurements
        /// </summary>
        [DataMember(Name = "shipmentMeasurements", EmitDefaultValue = false)]
        public ShipmentMeasurements ShipmentMeasurements { get; set; }

        /// <summary>
        /// Provide these fields only if this shipment is a direct import.
        /// </summary>
        /// <value>Provide these fields only if this shipment is a direct import.</value>
        [DataMember(Name = "importDetails", EmitDefaultValue = false)]
        public ImportDetails ImportDetails { get; set; }

        /// <summary>
        /// A list of the items in this shipment and their associated details. If any of the item detail fields are common at a carton or a pallet level, provide them at the corresponding carton or pallet level.
        /// </summary>
        /// <value>A list of the items in this shipment and their associated details. If any of the item detail fields are common at a carton or a pallet level, provide them at the corresponding carton or pallet level.</value>
        [DataMember(Name = "shippedItems", EmitDefaultValue = false)]
        public List<Item> ShippedItems { get; set; }

        /// <summary>
        /// A list of the cartons in this shipment.
        /// </summary>
        /// <value>A list of the cartons in this shipment.</value>
        [DataMember(Name = "cartons", EmitDefaultValue = false)]
        public List<Carton> Cartons { get; set; }

        /// <summary>
        /// A list of the pallets in this shipment.
        /// </summary>
        /// <value>A list of the pallets in this shipment.</value>
        [DataMember(Name = "pallets", EmitDefaultValue = false)]
        public List<Pallet> Pallets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentConfirmation {\n");
            sb.Append("  ShipmentIdentifier: ").Append(ShipmentIdentifier).Append("\n");
            sb.Append("  ShipmentConfirmationType: ").Append(ShipmentConfirmationType).Append("\n");
            sb.Append("  ShipmentType: ").Append(ShipmentType).Append("\n");
            sb.Append("  ShipmentStructure: ").Append(ShipmentStructure).Append("\n");
            sb.Append("  TransportationDetails: ").Append(TransportationDetails).Append("\n");
            sb.Append("  AmazonReferenceNumber: ").Append(AmazonReferenceNumber).Append("\n");
            sb.Append("  ShipmentConfirmationDate: ").Append(ShipmentConfirmationDate).Append("\n");
            sb.Append("  ShippedDate: ").Append(ShippedDate).Append("\n");
            sb.Append("  EstimatedDeliveryDate: ").Append(EstimatedDeliveryDate).Append("\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  ShipFromParty: ").Append(ShipFromParty).Append("\n");
            sb.Append("  ShipToParty: ").Append(ShipToParty).Append("\n");
            sb.Append("  ShipmentMeasurements: ").Append(ShipmentMeasurements).Append("\n");
            sb.Append("  ImportDetails: ").Append(ImportDetails).Append("\n");
            sb.Append("  ShippedItems: ").Append(ShippedItems).Append("\n");
            sb.Append("  Cartons: ").Append(Cartons).Append("\n");
            sb.Append("  Pallets: ").Append(Pallets).Append("\n");
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
            return this.Equals(input as ShipmentConfirmation);
        }

        /// <summary>
        /// Returns true if ShipmentConfirmation instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentConfirmation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentConfirmation input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ShipmentIdentifier == input.ShipmentIdentifier ||
                    (this.ShipmentIdentifier != null &&
                    this.ShipmentIdentifier.Equals(input.ShipmentIdentifier))
                ) &&
                (
                    this.ShipmentConfirmationType == input.ShipmentConfirmationType ||
                    (this.ShipmentConfirmationType != null &&
                    this.ShipmentConfirmationType.Equals(input.ShipmentConfirmationType))
                ) &&
                (
                    this.ShipmentType == input.ShipmentType ||
                    (this.ShipmentType != null &&
                    this.ShipmentType.Equals(input.ShipmentType))
                ) &&
                (
                    this.ShipmentStructure == input.ShipmentStructure ||
                    (this.ShipmentStructure != null &&
                    this.ShipmentStructure.Equals(input.ShipmentStructure))
                ) &&
                (
                    this.TransportationDetails == input.TransportationDetails ||
                    (this.TransportationDetails != null &&
                    this.TransportationDetails.Equals(input.TransportationDetails))
                ) &&
                (
                    this.AmazonReferenceNumber == input.AmazonReferenceNumber ||
                    (this.AmazonReferenceNumber != null &&
                    this.AmazonReferenceNumber.Equals(input.AmazonReferenceNumber))
                ) &&
                (
                    this.ShipmentConfirmationDate == input.ShipmentConfirmationDate ||
                    (this.ShipmentConfirmationDate != null &&
                    this.ShipmentConfirmationDate.Equals(input.ShipmentConfirmationDate))
                ) &&
                (
                    this.ShippedDate == input.ShippedDate ||
                    (this.ShippedDate != null &&
                    this.ShippedDate.Equals(input.ShippedDate))
                ) &&
                (
                    this.EstimatedDeliveryDate == input.EstimatedDeliveryDate ||
                    (this.EstimatedDeliveryDate != null &&
                    this.EstimatedDeliveryDate.Equals(input.EstimatedDeliveryDate))
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
                    this.ImportDetails == input.ImportDetails ||
                    (this.ImportDetails != null &&
                    this.ImportDetails.Equals(input.ImportDetails))
                ) &&
                (
                    this.ShippedItems == input.ShippedItems ||
                    this.ShippedItems != null &&
                    this.ShippedItems.SequenceEqual(input.ShippedItems)
                ) &&
                (
                    this.Cartons == input.Cartons ||
                    this.Cartons != null &&
                    this.Cartons.SequenceEqual(input.Cartons)
                ) &&
                (
                    this.Pallets == input.Pallets ||
                    this.Pallets != null &&
                    this.Pallets.SequenceEqual(input.Pallets)
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
                if (this.ShipmentIdentifier != null)
                    hashCode = hashCode * 59 + this.ShipmentIdentifier.GetHashCode();
                if (this.ShipmentConfirmationType != null)
                    hashCode = hashCode * 59 + this.ShipmentConfirmationType.GetHashCode();
                if (this.ShipmentType != null)
                    hashCode = hashCode * 59 + this.ShipmentType.GetHashCode();
                if (this.ShipmentStructure != null)
                    hashCode = hashCode * 59 + this.ShipmentStructure.GetHashCode();
                if (this.TransportationDetails != null)
                    hashCode = hashCode * 59 + this.TransportationDetails.GetHashCode();
                if (this.AmazonReferenceNumber != null)
                    hashCode = hashCode * 59 + this.AmazonReferenceNumber.GetHashCode();
                if (this.ShipmentConfirmationDate != null)
                    hashCode = hashCode * 59 + this.ShipmentConfirmationDate.GetHashCode();
                if (this.ShippedDate != null)
                    hashCode = hashCode * 59 + this.ShippedDate.GetHashCode();
                if (this.EstimatedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.EstimatedDeliveryDate.GetHashCode();
                if (this.SellingParty != null)
                    hashCode = hashCode * 59 + this.SellingParty.GetHashCode();
                if (this.ShipFromParty != null)
                    hashCode = hashCode * 59 + this.ShipFromParty.GetHashCode();
                if (this.ShipToParty != null)
                    hashCode = hashCode * 59 + this.ShipToParty.GetHashCode();
                if (this.ShipmentMeasurements != null)
                    hashCode = hashCode * 59 + this.ShipmentMeasurements.GetHashCode();
                if (this.ImportDetails != null)
                    hashCode = hashCode * 59 + this.ImportDetails.GetHashCode();
                if (this.ShippedItems != null)
                    hashCode = hashCode * 59 + this.ShippedItems.GetHashCode();
                if (this.Cartons != null)
                    hashCode = hashCode * 59 + this.Cartons.GetHashCode();
                if (this.Pallets != null)
                    hashCode = hashCode * 59 + this.Pallets.GetHashCode();
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
