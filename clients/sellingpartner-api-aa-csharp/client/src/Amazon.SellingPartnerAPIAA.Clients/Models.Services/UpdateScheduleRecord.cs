/* 
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders and manage their resources.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Services
{
    /// <summary>
    /// &#x60;UpdateScheduleRecord&#x60; entity contains the &#x60;AvailabilityRecord&#x60; if there is an error/warning while performing the requested operation on it.
    /// </summary>
    [DataContract]
    public partial class UpdateScheduleRecord : IEquatable<UpdateScheduleRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateScheduleRecord" /> class.
        /// </summary>
        /// <param name="availability">Availability record if the operation failed..</param>
        /// <param name="warnings">Warnings encountered, if any..</param>
        /// <param name="errors">Errors encountered, if any..</param>
        public UpdateScheduleRecord(AvailabilityRecord availability = default, WarningList warnings = default, ErrorList errors = default)
        {
            this.Availability = availability;
            this.Warnings = warnings;
            this.Errors = errors;
        }

        /// <summary>
        /// Availability record if the operation failed.
        /// </summary>
        /// <value>Availability record if the operation failed.</value>
        [DataMember(Name = "availability", EmitDefaultValue = false)]
        public AvailabilityRecord Availability { get; set; }

        /// <summary>
        /// Warnings encountered, if any.
        /// </summary>
        /// <value>Warnings encountered, if any.</value>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        public WarningList Warnings { get; set; }

        /// <summary>
        /// Errors encountered, if any.
        /// </summary>
        /// <value>Errors encountered, if any.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateScheduleRecord {\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as UpdateScheduleRecord);
        }

        /// <summary>
        /// Returns true if UpdateScheduleRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateScheduleRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateScheduleRecord input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
                ) &&
                (
                    this.Warnings == input.Warnings ||
                    (this.Warnings != null &&
                    this.Warnings.Equals(input.Warnings))
                ) &&
                (
                    this.Errors == input.Errors ||
                    (this.Errors != null &&
                    this.Errors.Equals(input.Errors))
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
                if (this.Availability != null)
                    hashCode = hashCode * 59 + this.Availability.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
