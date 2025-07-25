/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound
{
    /// <summary>
    /// Small Parcel Delivery (SPD) tracking items input information.
    /// </summary>
    [DataContract]
    public partial class SpdTrackingItemInput : IEquatable<SpdTrackingItemInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpdTrackingItemInput" /> class.
        /// </summary>
        [JsonConstructor]
        protected SpdTrackingItemInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpdTrackingItemInput" /> class.
        /// </summary>
        /// <param name="boxId">The ID provided by Amazon that identifies a given box. This ID is comprised of the external shipment ID (which is generated after transportation has been confirmed) and the index of the box. (required).</param>
        /// <param name="trackingId">The tracking Id associated with each box in a non-Amazon partnered Small Parcel Delivery (SPD) shipment. The seller must provide this information. (required).</param>
        public SpdTrackingItemInput(string boxId = default, string trackingId = default)
        {
            // to ensure "boxId" is required (not null)
            if (boxId == null)
            {
                throw new InvalidDataException("boxId is a required property for SpdTrackingItemInput and cannot be null");
            }
            else
            {
                this.BoxId = boxId;
            }
            // to ensure "trackingId" is required (not null)
            if (trackingId == null)
            {
                throw new InvalidDataException("trackingId is a required property for SpdTrackingItemInput and cannot be null");
            }
            else
            {
                this.TrackingId = trackingId;
            }
        }

        /// <summary>
        /// The ID provided by Amazon that identifies a given box. This ID is comprised of the external shipment ID (which is generated after transportation has been confirmed) and the index of the box.
        /// </summary>
        /// <value>The ID provided by Amazon that identifies a given box. This ID is comprised of the external shipment ID (which is generated after transportation has been confirmed) and the index of the box.</value>
        [DataMember(Name = "boxId", EmitDefaultValue = false)]
        public string BoxId { get; set; }

        /// <summary>
        /// The tracking Id associated with each box in a non-Amazon partnered Small Parcel Delivery (SPD) shipment. The seller must provide this information.
        /// </summary>
        /// <value>The tracking Id associated with each box in a non-Amazon partnered Small Parcel Delivery (SPD) shipment. The seller must provide this information.</value>
        [DataMember(Name = "trackingId", EmitDefaultValue = false)]
        public string TrackingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpdTrackingItemInput {\n");
            sb.Append("  BoxId: ").Append(BoxId).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
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
            return this.Equals(input as SpdTrackingItemInput);
        }

        /// <summary>
        /// Returns true if SpdTrackingItemInput instances are equal
        /// </summary>
        /// <param name="input">Instance of SpdTrackingItemInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpdTrackingItemInput input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BoxId == input.BoxId ||
                    (this.BoxId != null &&
                    this.BoxId.Equals(input.BoxId))
                ) &&
                (
                    this.TrackingId == input.TrackingId ||
                    (this.TrackingId != null &&
                    this.TrackingId.Equals(input.TrackingId))
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
                if (this.BoxId != null)
                    hashCode = hashCode * 59 + this.BoxId.GetHashCode();
                if (this.TrackingId != null)
                    hashCode = hashCode * 59 + this.TrackingId.GetHashCode();
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
            // BoxId (string) maxLength
            if (this.BoxId != null && this.BoxId.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for BoxId, length must be less than 1024.", new[] { "BoxId" });
            }

            // BoxId (string) minLength
            if (this.BoxId != null && this.BoxId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for BoxId, length must be greater than 1.", new[] { "BoxId" });
            }

            // TrackingId (string) maxLength
            if (this.TrackingId != null && this.TrackingId.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for TrackingId, length must be less than 1024.", new[] { "TrackingId" });
            }

            // TrackingId (string) minLength
            if (this.TrackingId != null && this.TrackingId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for TrackingId, length must be greater than 1.", new[] { "TrackingId" });
            }

            yield break;
        }
    }

}
