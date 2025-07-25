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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound
{
    /// <summary>
    /// The &#x60;generateSelfShipAppointmentSlots&#x60; request.
    /// </summary>
    [DataContract]
    public partial class GenerateSelfShipAppointmentSlotsRequest : IEquatable<GenerateSelfShipAppointmentSlotsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSelfShipAppointmentSlotsRequest" /> class.
        /// </summary>
        /// <param name="desiredEndDate">The desired end date. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format..</param>
        /// <param name="desiredStartDate">The desired start date. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format..</param>
        public GenerateSelfShipAppointmentSlotsRequest(DateTime? desiredEndDate = default, DateTime? desiredStartDate = default)
        {
            this.DesiredEndDate = desiredEndDate;
            this.DesiredStartDate = desiredStartDate;
        }

        /// <summary>
        /// The desired end date. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format.
        /// </summary>
        /// <value>The desired end date. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format.</value>
        [DataMember(Name = "desiredEndDate", EmitDefaultValue = false)]
        public DateTime? DesiredEndDate { get; set; }

        /// <summary>
        /// The desired start date. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format.
        /// </summary>
        /// <value>The desired start date. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format.</value>
        [DataMember(Name = "desiredStartDate", EmitDefaultValue = false)]
        public DateTime? DesiredStartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateSelfShipAppointmentSlotsRequest {\n");
            sb.Append("  DesiredEndDate: ").Append(DesiredEndDate).Append("\n");
            sb.Append("  DesiredStartDate: ").Append(DesiredStartDate).Append("\n");
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
            return this.Equals(input as GenerateSelfShipAppointmentSlotsRequest);
        }

        /// <summary>
        /// Returns true if GenerateSelfShipAppointmentSlotsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateSelfShipAppointmentSlotsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateSelfShipAppointmentSlotsRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DesiredEndDate == input.DesiredEndDate ||
                    (this.DesiredEndDate != null &&
                    this.DesiredEndDate.Equals(input.DesiredEndDate))
                ) &&
                (
                    this.DesiredStartDate == input.DesiredStartDate ||
                    (this.DesiredStartDate != null &&
                    this.DesiredStartDate.Equals(input.DesiredStartDate))
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
                if (this.DesiredEndDate != null)
                    hashCode = hashCode * 59 + this.DesiredEndDate.GetHashCode();
                if (this.DesiredStartDate != null)
                    hashCode = hashCode * 59 + this.DesiredStartDate.GetHashCode();
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
