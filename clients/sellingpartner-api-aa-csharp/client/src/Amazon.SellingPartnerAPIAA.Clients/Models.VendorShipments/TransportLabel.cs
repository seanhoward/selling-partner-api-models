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
    /// A list of one or more ShipmentLabels.
    /// </summary>
    [DataContract]
    public partial class TransportLabel :  IEquatable<TransportLabel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportLabel" /> class.
        /// </summary>
        /// <param name="labelCreateDateTime">Date on which label is created..</param>
        /// <param name="shipmentInformation">Indicates the shipment Information details like warehouse and business reference details like ARN, Selling Party detail and Vendor Warehouse details.</param>
        /// <param name="labelData">Indicates the label data,format and type associated ..</param>
        public TransportLabel(DateTime? labelCreateDateTime = default(DateTime?), ShipmentInformation shipmentInformation = default(ShipmentInformation), List<LabelData> labelData = default(List<LabelData>))
        {
            this.LabelCreateDateTime = labelCreateDateTime;
            this.ShipmentInformation = shipmentInformation;
            this.LabelData = labelData;
        }
        
        /// <summary>
        /// Date on which label is created.
        /// </summary>
        /// <value>Date on which label is created.</value>
        [DataMember(Name="labelCreateDateTime", EmitDefaultValue=false)]
        public DateTime? LabelCreateDateTime { get; set; }

        /// <summary>
        /// Indicates the shipment Information details like warehouse and business reference details like ARN, Selling Party detail and Vendor Warehouse details
        /// </summary>
        /// <value>Indicates the shipment Information details like warehouse and business reference details like ARN, Selling Party detail and Vendor Warehouse details</value>
        [DataMember(Name="shipmentInformation", EmitDefaultValue=false)]
        public ShipmentInformation ShipmentInformation { get; set; }

        /// <summary>
        /// Indicates the label data,format and type associated .
        /// </summary>
        /// <value>Indicates the label data,format and type associated .</value>
        [DataMember(Name="labelData", EmitDefaultValue=false)]
        public List<LabelData> LabelData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransportLabel {\n");
            sb.Append("  LabelCreateDateTime: ").Append(LabelCreateDateTime).Append("\n");
            sb.Append("  ShipmentInformation: ").Append(ShipmentInformation).Append("\n");
            sb.Append("  LabelData: ").Append(LabelData).Append("\n");
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
            return this.Equals(input as TransportLabel);
        }

        /// <summary>
        /// Returns true if TransportLabel instances are equal
        /// </summary>
        /// <param name="input">Instance of TransportLabel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransportLabel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LabelCreateDateTime == input.LabelCreateDateTime ||
                    (this.LabelCreateDateTime != null &&
                    this.LabelCreateDateTime.Equals(input.LabelCreateDateTime))
                ) && 
                (
                    this.ShipmentInformation == input.ShipmentInformation ||
                    (this.ShipmentInformation != null &&
                    this.ShipmentInformation.Equals(input.ShipmentInformation))
                ) && 
                (
                    this.LabelData == input.LabelData ||
                    this.LabelData != null &&
                    this.LabelData.SequenceEqual(input.LabelData)
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
                if (this.LabelCreateDateTime != null)
                    hashCode = hashCode * 59 + this.LabelCreateDateTime.GetHashCode();
                if (this.ShipmentInformation != null)
                    hashCode = hashCode * 59 + this.ShipmentInformation.GetHashCode();
                if (this.LabelData != null)
                    hashCode = hashCode * 59 + this.LabelData.GetHashCode();
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
