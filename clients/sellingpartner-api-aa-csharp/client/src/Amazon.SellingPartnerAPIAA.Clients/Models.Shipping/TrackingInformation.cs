/* 
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.   **Note:** If you are new to the Amazon Shipping API, refer to the latest version of <a href=\"https://developer-docs.amazon.com/amazon-shipping/docs/shipping-api-v2-reference\">Amazon Shipping API (v2)</a> on the <a href=\"https://developer-docs.amazon.com/amazon-shipping/\">Amazon Shipping Developer Documentation</a> site.
 *
 * OpenAPI spec version: v1
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Shipping
{
    /// <summary>
    /// The payload schema for the getTrackingInformation operation.
    /// </summary>
    [DataContract]
    public partial class TrackingInformation : IEquatable<TrackingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingInformation" /> class.
        /// </summary>
        [JsonConstructor]
        protected TrackingInformation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingInformation" /> class.
        /// </summary>
        /// <param name="trackingId">trackingId (required).</param>
        /// <param name="summary">summary (required).</param>
        /// <param name="promisedDeliveryDate">promisedDeliveryDate (required).</param>
        /// <param name="eventHistory">eventHistory (required).</param>
        public TrackingInformation(string trackingId = default, TrackingSummary summary = default, DateTime? promisedDeliveryDate = default, EventList eventHistory = default)
        {
            // to ensure "trackingId" is required (not null)
            if (trackingId == null)
            {
                throw new InvalidDataException("trackingId is a required property for TrackingInformation and cannot be null");
            }
            else
            {
                this.TrackingId = trackingId;
            }
            // to ensure "summary" is required (not null)
            if (summary == null)
            {
                throw new InvalidDataException("summary is a required property for TrackingInformation and cannot be null");
            }
            else
            {
                this.Summary = summary;
            }
            // to ensure "promisedDeliveryDate" is required (not null)
            if (promisedDeliveryDate == null)
            {
                throw new InvalidDataException("promisedDeliveryDate is a required property for TrackingInformation and cannot be null");
            }
            else
            {
                this.PromisedDeliveryDate = promisedDeliveryDate;
            }
            // to ensure "eventHistory" is required (not null)
            if (eventHistory == null)
            {
                throw new InvalidDataException("eventHistory is a required property for TrackingInformation and cannot be null");
            }
            else
            {
                this.EventHistory = eventHistory;
            }
        }

        /// <summary>
        /// Gets or Sets TrackingId
        /// </summary>
        [DataMember(Name = "trackingId", EmitDefaultValue = false)]
        public string TrackingId { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public TrackingSummary Summary { get; set; }

        /// <summary>
        /// Gets or Sets PromisedDeliveryDate
        /// </summary>
        [DataMember(Name = "promisedDeliveryDate", EmitDefaultValue = false)]
        public DateTime? PromisedDeliveryDate { get; set; }

        /// <summary>
        /// Gets or Sets EventHistory
        /// </summary>
        [DataMember(Name = "eventHistory", EmitDefaultValue = false)]
        public EventList EventHistory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingInformation {\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  PromisedDeliveryDate: ").Append(PromisedDeliveryDate).Append("\n");
            sb.Append("  EventHistory: ").Append(EventHistory).Append("\n");
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
            return this.Equals(input as TrackingInformation);
        }

        /// <summary>
        /// Returns true if TrackingInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingInformation input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TrackingId == input.TrackingId ||
                    (this.TrackingId != null &&
                    this.TrackingId.Equals(input.TrackingId))
                ) &&
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) &&
                (
                    this.PromisedDeliveryDate == input.PromisedDeliveryDate ||
                    (this.PromisedDeliveryDate != null &&
                    this.PromisedDeliveryDate.Equals(input.PromisedDeliveryDate))
                ) &&
                (
                    this.EventHistory == input.EventHistory ||
                    (this.EventHistory != null &&
                    this.EventHistory.Equals(input.EventHistory))
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
                if (this.TrackingId != null)
                    hashCode = hashCode * 59 + this.TrackingId.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.PromisedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.PromisedDeliveryDate.GetHashCode();
                if (this.EventHistory != null)
                    hashCode = hashCode * 59 + this.EventHistory.GetHashCode();
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
