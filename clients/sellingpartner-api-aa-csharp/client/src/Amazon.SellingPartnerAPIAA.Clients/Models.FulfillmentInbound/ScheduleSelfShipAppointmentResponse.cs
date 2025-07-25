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
    /// The &#x60;scheduleSelfShipAppointment&#x60; response.
    /// </summary>
    [DataContract]
    public partial class ScheduleSelfShipAppointmentResponse : IEquatable<ScheduleSelfShipAppointmentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleSelfShipAppointmentResponse" /> class.
        /// </summary>
        [JsonConstructor]
        protected ScheduleSelfShipAppointmentResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleSelfShipAppointmentResponse" /> class.
        /// </summary>
        /// <param name="selfShipAppointmentDetails">selfShipAppointmentDetails (required).</param>
        public ScheduleSelfShipAppointmentResponse(SelfShipAppointmentDetails selfShipAppointmentDetails = default)
        {
            // to ensure "selfShipAppointmentDetails" is required (not null)
            if (selfShipAppointmentDetails == null)
            {
                throw new InvalidDataException("selfShipAppointmentDetails is a required property for ScheduleSelfShipAppointmentResponse and cannot be null");
            }
            else
            {
                this.SelfShipAppointmentDetails = selfShipAppointmentDetails;
            }
        }

        /// <summary>
        /// Gets or Sets SelfShipAppointmentDetails
        /// </summary>
        [DataMember(Name = "selfShipAppointmentDetails", EmitDefaultValue = false)]
        public SelfShipAppointmentDetails SelfShipAppointmentDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleSelfShipAppointmentResponse {\n");
            sb.Append("  SelfShipAppointmentDetails: ").Append(SelfShipAppointmentDetails).Append("\n");
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
            return this.Equals(input as ScheduleSelfShipAppointmentResponse);
        }

        /// <summary>
        /// Returns true if ScheduleSelfShipAppointmentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleSelfShipAppointmentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleSelfShipAppointmentResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SelfShipAppointmentDetails == input.SelfShipAppointmentDetails ||
                    (this.SelfShipAppointmentDetails != null &&
                    this.SelfShipAppointmentDetails.Equals(input.SelfShipAppointmentDetails))
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
                if (this.SelfShipAppointmentDetails != null)
                    hashCode = hashCode * 59 + this.SelfShipAppointmentDetails.GetHashCode();
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
