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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorShipments
{
    /// <summary>
    /// Provide these fields only if this shipment is a direct import.
    /// </summary>
    [DataContract]
    public partial class ImportDetails :  IEquatable<ImportDetails>, IValidatableObject
    {
        /// <summary>
        /// This is used for import purchase orders only. If the recipient requests, this field will contain the shipment method of payment.
        /// </summary>
        /// <value>This is used for import purchase orders only. If the recipient requests, this field will contain the shipment method of payment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodOfPaymentEnum
        {
            
            /// <summary>
            /// Enum PaidByBuyer for value: PaidByBuyer
            /// </summary>
            [EnumMember(Value = "PaidByBuyer")]
            PaidByBuyer = 1,
            
            /// <summary>
            /// Enum CollectOnDelivery for value: CollectOnDelivery
            /// </summary>
            [EnumMember(Value = "CollectOnDelivery")]
            CollectOnDelivery = 2,
            
            /// <summary>
            /// Enum DefinedByBuyerAndSeller for value: DefinedByBuyerAndSeller
            /// </summary>
            [EnumMember(Value = "DefinedByBuyerAndSeller")]
            DefinedByBuyerAndSeller = 3,
            
            /// <summary>
            /// Enum FOBPortOfCall for value: FOBPortOfCall
            /// </summary>
            [EnumMember(Value = "FOBPortOfCall")]
            FOBPortOfCall = 4,
            
            /// <summary>
            /// Enum PrepaidBySeller for value: PrepaidBySeller
            /// </summary>
            [EnumMember(Value = "PrepaidBySeller")]
            PrepaidBySeller = 5,
            
            /// <summary>
            /// Enum PaidBySeller for value: PaidBySeller
            /// </summary>
            [EnumMember(Value = "PaidBySeller")]
            PaidBySeller = 6
        }

        /// <summary>
        /// This is used for import purchase orders only. If the recipient requests, this field will contain the shipment method of payment.
        /// </summary>
        /// <value>This is used for import purchase orders only. If the recipient requests, this field will contain the shipment method of payment.</value>
        [DataMember(Name="methodOfPayment", EmitDefaultValue=false)]
        public MethodOfPaymentEnum? MethodOfPayment { get; set; }
        /// <summary>
        /// Identification of the instructions on how specified item/carton/pallet should be handled.
        /// </summary>
        /// <value>Identification of the instructions on how specified item/carton/pallet should be handled.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HandlingInstructionsEnum
        {
            
            /// <summary>
            /// Enum Oversized for value: Oversized
            /// </summary>
            [EnumMember(Value = "Oversized")]
            Oversized = 1,
            
            /// <summary>
            /// Enum Fragile for value: Fragile
            /// </summary>
            [EnumMember(Value = "Fragile")]
            Fragile = 2,
            
            /// <summary>
            /// Enum Food for value: Food
            /// </summary>
            [EnumMember(Value = "Food")]
            Food = 3,
            
            /// <summary>
            /// Enum HandleWithCare for value: HandleWithCare
            /// </summary>
            [EnumMember(Value = "HandleWithCare")]
            HandleWithCare = 4
        }

        /// <summary>
        /// Identification of the instructions on how specified item/carton/pallet should be handled.
        /// </summary>
        /// <value>Identification of the instructions on how specified item/carton/pallet should be handled.</value>
        [DataMember(Name="handlingInstructions", EmitDefaultValue=false)]
        public HandlingInstructionsEnum? HandlingInstructions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportDetails" /> class.
        /// </summary>
        /// <param name="methodOfPayment">This is used for import purchase orders only. If the recipient requests, this field will contain the shipment method of payment..</param>
        /// <param name="sealNumber">The container&#39;s seal number..</param>
        /// <param name="route">The route and stop details for this shipment..</param>
        /// <param name="importContainers">Types and numbers of container(s) for import purchase orders. Can be a comma-separated list if shipment has multiple containers..</param>
        /// <param name="billableWeight">Billable weight of the direct imports shipment..</param>
        /// <param name="estimatedShipByDate">Date on which the shipment is expected to be shipped. This value should not be in the past and not more than 60 days out in the future..</param>
        /// <param name="handlingInstructions">Identification of the instructions on how specified item/carton/pallet should be handled..</param>
        public ImportDetails(MethodOfPaymentEnum? methodOfPayment = default(MethodOfPaymentEnum?), string sealNumber = default(string), Route route = default(Route), string importContainers = default(string), Weight billableWeight = default(Weight), DateTime? estimatedShipByDate = default(DateTime?), HandlingInstructionsEnum? handlingInstructions = default(HandlingInstructionsEnum?))
        {
            this.MethodOfPayment = methodOfPayment;
            this.SealNumber = sealNumber;
            this.Route = route;
            this.ImportContainers = importContainers;
            this.BillableWeight = billableWeight;
            this.EstimatedShipByDate = estimatedShipByDate;
            this.HandlingInstructions = handlingInstructions;
        }
        

        /// <summary>
        /// The container&#39;s seal number.
        /// </summary>
        /// <value>The container&#39;s seal number.</value>
        [DataMember(Name="sealNumber", EmitDefaultValue=false)]
        public string SealNumber { get; set; }

        /// <summary>
        /// The route and stop details for this shipment.
        /// </summary>
        /// <value>The route and stop details for this shipment.</value>
        [DataMember(Name="route", EmitDefaultValue=false)]
        public Route Route { get; set; }

        /// <summary>
        /// Types and numbers of container(s) for import purchase orders. Can be a comma-separated list if shipment has multiple containers.
        /// </summary>
        /// <value>Types and numbers of container(s) for import purchase orders. Can be a comma-separated list if shipment has multiple containers.</value>
        [DataMember(Name="importContainers", EmitDefaultValue=false)]
        public string ImportContainers { get; set; }

        /// <summary>
        /// Billable weight of the direct imports shipment.
        /// </summary>
        /// <value>Billable weight of the direct imports shipment.</value>
        [DataMember(Name="billableWeight", EmitDefaultValue=false)]
        public Weight BillableWeight { get; set; }

        /// <summary>
        /// Date on which the shipment is expected to be shipped. This value should not be in the past and not more than 60 days out in the future.
        /// </summary>
        /// <value>Date on which the shipment is expected to be shipped. This value should not be in the past and not more than 60 days out in the future.</value>
        [DataMember(Name="estimatedShipByDate", EmitDefaultValue=false)]
        public DateTime? EstimatedShipByDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportDetails {\n");
            sb.Append("  MethodOfPayment: ").Append(MethodOfPayment).Append("\n");
            sb.Append("  SealNumber: ").Append(SealNumber).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
            sb.Append("  ImportContainers: ").Append(ImportContainers).Append("\n");
            sb.Append("  BillableWeight: ").Append(BillableWeight).Append("\n");
            sb.Append("  EstimatedShipByDate: ").Append(EstimatedShipByDate).Append("\n");
            sb.Append("  HandlingInstructions: ").Append(HandlingInstructions).Append("\n");
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
            return this.Equals(input as ImportDetails);
        }

        /// <summary>
        /// Returns true if ImportDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MethodOfPayment == input.MethodOfPayment ||
                    (this.MethodOfPayment != null &&
                    this.MethodOfPayment.Equals(input.MethodOfPayment))
                ) && 
                (
                    this.SealNumber == input.SealNumber ||
                    (this.SealNumber != null &&
                    this.SealNumber.Equals(input.SealNumber))
                ) && 
                (
                    this.Route == input.Route ||
                    (this.Route != null &&
                    this.Route.Equals(input.Route))
                ) && 
                (
                    this.ImportContainers == input.ImportContainers ||
                    (this.ImportContainers != null &&
                    this.ImportContainers.Equals(input.ImportContainers))
                ) && 
                (
                    this.BillableWeight == input.BillableWeight ||
                    (this.BillableWeight != null &&
                    this.BillableWeight.Equals(input.BillableWeight))
                ) && 
                (
                    this.EstimatedShipByDate == input.EstimatedShipByDate ||
                    (this.EstimatedShipByDate != null &&
                    this.EstimatedShipByDate.Equals(input.EstimatedShipByDate))
                ) && 
                (
                    this.HandlingInstructions == input.HandlingInstructions ||
                    (this.HandlingInstructions != null &&
                    this.HandlingInstructions.Equals(input.HandlingInstructions))
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
                if (this.MethodOfPayment != null)
                    hashCode = hashCode * 59 + this.MethodOfPayment.GetHashCode();
                if (this.SealNumber != null)
                    hashCode = hashCode * 59 + this.SealNumber.GetHashCode();
                if (this.Route != null)
                    hashCode = hashCode * 59 + this.Route.GetHashCode();
                if (this.ImportContainers != null)
                    hashCode = hashCode * 59 + this.ImportContainers.GetHashCode();
                if (this.BillableWeight != null)
                    hashCode = hashCode * 59 + this.BillableWeight.GetHashCode();
                if (this.EstimatedShipByDate != null)
                    hashCode = hashCode * 59 + this.EstimatedShipByDate.GetHashCode();
                if (this.HandlingInstructions != null)
                    hashCode = hashCode * 59 + this.HandlingInstructions.GetHashCode();
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
            // ImportContainers (string) maxLength
            if(this.ImportContainers != null && this.ImportContainers.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImportContainers, length must be less than 64.", new [] { "ImportContainers" });
            }

            yield break;
        }
    }

}
