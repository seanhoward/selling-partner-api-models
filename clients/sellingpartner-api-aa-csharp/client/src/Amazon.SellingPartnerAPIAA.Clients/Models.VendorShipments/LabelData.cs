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
    /// Label details as part of the transport label response
    /// </summary>
    [DataContract]
    public partial class LabelData :  IEquatable<LabelData>, IValidatableObject
    {
        /// <summary>
        /// Type of the label format like PDF
        /// </summary>
        /// <value>Type of the label format like PDF</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LabelFormatEnum
        {
            
            /// <summary>
            /// Enum PDF for value: PDF
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF = 1
        }

        /// <summary>
        /// Type of the label format like PDF
        /// </summary>
        /// <value>Type of the label format like PDF</value>
        [DataMember(Name="labelFormat", EmitDefaultValue=false)]
        public LabelFormatEnum? LabelFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelData" /> class.
        /// </summary>
        /// <param name="labelSequenceNumber">Label list sequence number.</param>
        /// <param name="labelFormat">Type of the label format like PDF.</param>
        /// <param name="carrierCode">Unique identification for  the carrier like UPS,DHL,USPS..etc.</param>
        /// <param name="trackingId">Tracking Id for the transportation..</param>
        /// <param name="label">Label created as part of the transportation and it is base64 encoded.</param>
        public LabelData(int? labelSequenceNumber = default(int?), LabelFormatEnum? labelFormat = default(LabelFormatEnum?), string carrierCode = default(string), string trackingId = default(string), string label = default(string))
        {
            this.LabelSequenceNumber = labelSequenceNumber;
            this.LabelFormat = labelFormat;
            this.CarrierCode = carrierCode;
            this.TrackingId = trackingId;
            this.Label = label;
        }
        
        /// <summary>
        /// Label list sequence number
        /// </summary>
        /// <value>Label list sequence number</value>
        [DataMember(Name="labelSequenceNumber", EmitDefaultValue=false)]
        public int? LabelSequenceNumber { get; set; }


        /// <summary>
        /// Unique identification for  the carrier like UPS,DHL,USPS..etc
        /// </summary>
        /// <value>Unique identification for  the carrier like UPS,DHL,USPS..etc</value>
        [DataMember(Name="carrierCode", EmitDefaultValue=false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Tracking Id for the transportation.
        /// </summary>
        /// <value>Tracking Id for the transportation.</value>
        [DataMember(Name="trackingId", EmitDefaultValue=false)]
        public string TrackingId { get; set; }

        /// <summary>
        /// Label created as part of the transportation and it is base64 encoded
        /// </summary>
        /// <value>Label created as part of the transportation and it is base64 encoded</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LabelData {\n");
            sb.Append("  LabelSequenceNumber: ").Append(LabelSequenceNumber).Append("\n");
            sb.Append("  LabelFormat: ").Append(LabelFormat).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as LabelData);
        }

        /// <summary>
        /// Returns true if LabelData instances are equal
        /// </summary>
        /// <param name="input">Instance of LabelData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LabelSequenceNumber == input.LabelSequenceNumber ||
                    (this.LabelSequenceNumber != null &&
                    this.LabelSequenceNumber.Equals(input.LabelSequenceNumber))
                ) && 
                (
                    this.LabelFormat == input.LabelFormat ||
                    (this.LabelFormat != null &&
                    this.LabelFormat.Equals(input.LabelFormat))
                ) && 
                (
                    this.CarrierCode == input.CarrierCode ||
                    (this.CarrierCode != null &&
                    this.CarrierCode.Equals(input.CarrierCode))
                ) && 
                (
                    this.TrackingId == input.TrackingId ||
                    (this.TrackingId != null &&
                    this.TrackingId.Equals(input.TrackingId))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.LabelSequenceNumber != null)
                    hashCode = hashCode * 59 + this.LabelSequenceNumber.GetHashCode();
                if (this.LabelFormat != null)
                    hashCode = hashCode * 59 + this.LabelFormat.GetHashCode();
                if (this.CarrierCode != null)
                    hashCode = hashCode * 59 + this.CarrierCode.GetHashCode();
                if (this.TrackingId != null)
                    hashCode = hashCode * 59 + this.TrackingId.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
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
