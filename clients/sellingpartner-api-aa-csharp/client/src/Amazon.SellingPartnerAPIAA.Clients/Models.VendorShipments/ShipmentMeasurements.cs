/* 
 * Vendor Shipments v1
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
    /// Shipment measurement details.
    /// </summary>
    [DataContract]
    public partial class ShipmentMeasurements :  IEquatable<ShipmentMeasurements>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentMeasurements" /> class.
        /// </summary>
        /// <param name="grossShipmentWeight">Gross weight of the shipment..</param>
        /// <param name="shipmentVolume">Gross Volume of the shipment..</param>
        /// <param name="cartonCount">Number of cartons present in the shipment. Provide the cartonCount only for non-palletized shipments..</param>
        /// <param name="palletCount">Number of pallets present in the shipment. Provide the palletCount only for palletized shipments..</param>
        public ShipmentMeasurements(Weight grossShipmentWeight = default(Weight), Volume shipmentVolume = default(Volume), int? cartonCount = default(int?), int? palletCount = default(int?))
        {
            this.GrossShipmentWeight = grossShipmentWeight;
            this.ShipmentVolume = shipmentVolume;
            this.CartonCount = cartonCount;
            this.PalletCount = palletCount;
        }
        
        /// <summary>
        /// Gross weight of the shipment.
        /// </summary>
        /// <value>Gross weight of the shipment.</value>
        [DataMember(Name="grossShipmentWeight", EmitDefaultValue=false)]
        public Weight GrossShipmentWeight { get; set; }

        /// <summary>
        /// Gross Volume of the shipment.
        /// </summary>
        /// <value>Gross Volume of the shipment.</value>
        [DataMember(Name="shipmentVolume", EmitDefaultValue=false)]
        public Volume ShipmentVolume { get; set; }

        /// <summary>
        /// Number of cartons present in the shipment. Provide the cartonCount only for non-palletized shipments.
        /// </summary>
        /// <value>Number of cartons present in the shipment. Provide the cartonCount only for non-palletized shipments.</value>
        [DataMember(Name="cartonCount", EmitDefaultValue=false)]
        public int? CartonCount { get; set; }

        /// <summary>
        /// Number of pallets present in the shipment. Provide the palletCount only for palletized shipments.
        /// </summary>
        /// <value>Number of pallets present in the shipment. Provide the palletCount only for palletized shipments.</value>
        [DataMember(Name="palletCount", EmitDefaultValue=false)]
        public int? PalletCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentMeasurements {\n");
            sb.Append("  GrossShipmentWeight: ").Append(GrossShipmentWeight).Append("\n");
            sb.Append("  ShipmentVolume: ").Append(ShipmentVolume).Append("\n");
            sb.Append("  CartonCount: ").Append(CartonCount).Append("\n");
            sb.Append("  PalletCount: ").Append(PalletCount).Append("\n");
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
            return this.Equals(input as ShipmentMeasurements);
        }

        /// <summary>
        /// Returns true if ShipmentMeasurements instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentMeasurements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentMeasurements input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GrossShipmentWeight == input.GrossShipmentWeight ||
                    (this.GrossShipmentWeight != null &&
                    this.GrossShipmentWeight.Equals(input.GrossShipmentWeight))
                ) && 
                (
                    this.ShipmentVolume == input.ShipmentVolume ||
                    (this.ShipmentVolume != null &&
                    this.ShipmentVolume.Equals(input.ShipmentVolume))
                ) && 
                (
                    this.CartonCount == input.CartonCount ||
                    (this.CartonCount != null &&
                    this.CartonCount.Equals(input.CartonCount))
                ) && 
                (
                    this.PalletCount == input.PalletCount ||
                    (this.PalletCount != null &&
                    this.PalletCount.Equals(input.PalletCount))
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
                if (this.GrossShipmentWeight != null)
                    hashCode = hashCode * 59 + this.GrossShipmentWeight.GetHashCode();
                if (this.ShipmentVolume != null)
                    hashCode = hashCode * 59 + this.ShipmentVolume.GetHashCode();
                if (this.CartonCount != null)
                    hashCode = hashCode * 59 + this.CartonCount.GetHashCode();
                if (this.PalletCount != null)
                    hashCode = hashCode * 59 + this.PalletCount.GetHashCode();
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
            yield break;
        }
    }

}
