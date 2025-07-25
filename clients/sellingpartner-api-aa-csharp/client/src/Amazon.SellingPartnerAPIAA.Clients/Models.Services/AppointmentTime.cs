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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Services
{
    /// <summary>
    /// The time of the appointment window.
    /// </summary>
    [DataContract]
    public partial class AppointmentTime : IEquatable<AppointmentTime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentTime" /> class.
        /// </summary>
        [JsonConstructor]
        protected AppointmentTime() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentTime" /> class.
        /// </summary>
        /// <param name="startTime">The date and time of the start of the appointment window in ISO 8601 format. (required).</param>
        /// <param name="durationInMinutes">The duration of the appointment window, in minutes. (required).</param>
        public AppointmentTime(DateTime? startTime = default, int? durationInMinutes = default)
        {
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new InvalidDataException("startTime is a required property for AppointmentTime and cannot be null");
            }
            else
            {
                this.StartTime = startTime;
            }
            // to ensure "durationInMinutes" is required (not null)
            if (durationInMinutes == null)
            {
                throw new InvalidDataException("durationInMinutes is a required property for AppointmentTime and cannot be null");
            }
            else
            {
                this.DurationInMinutes = durationInMinutes;
            }
        }

        /// <summary>
        /// The date and time of the start of the appointment window in ISO 8601 format.
        /// </summary>
        /// <value>The date and time of the start of the appointment window in ISO 8601 format.</value>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The duration of the appointment window, in minutes.
        /// </summary>
        /// <value>The duration of the appointment window, in minutes.</value>
        [DataMember(Name = "durationInMinutes", EmitDefaultValue = false)]
        public int? DurationInMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppointmentTime {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  DurationInMinutes: ").Append(DurationInMinutes).Append("\n");
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
            return this.Equals(input as AppointmentTime);
        }

        /// <summary>
        /// Returns true if AppointmentTime instances are equal
        /// </summary>
        /// <param name="input">Instance of AppointmentTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppointmentTime input)
        {
            if (input == null)
                return false;

            return
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) &&
                (
                    this.DurationInMinutes == input.DurationInMinutes ||
                    (this.DurationInMinutes != null &&
                    this.DurationInMinutes.Equals(input.DurationInMinutes))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.DurationInMinutes != null)
                    hashCode = hashCode * 59 + this.DurationInMinutes.GetHashCode();
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
            // DurationInMinutes (int?) minimum
            if (this.DurationInMinutes < (int?)1)
            {
                yield return new ValidationResult("Invalid value for DurationInMinutes, must be a value greater than or equal to 1.", new[] { "DurationInMinutes" });
            }

            yield break;
        }
    }

}
