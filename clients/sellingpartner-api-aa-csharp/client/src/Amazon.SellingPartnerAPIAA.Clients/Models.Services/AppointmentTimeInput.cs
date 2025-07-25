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
    /// The input appointment time details.
    /// </summary>
    [DataContract]
    public partial class AppointmentTimeInput : IEquatable<AppointmentTimeInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentTimeInput" /> class.
        /// </summary>
        [JsonConstructor]
        protected AppointmentTimeInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentTimeInput" /> class.
        /// </summary>
        /// <param name="startTime">The date, time in UTC for the start time of an appointment in ISO 8601 format. (required).</param>
        /// <param name="durationInMinutes">The duration of an appointment in minutes..</param>
        public AppointmentTimeInput(DateTime? startTime = default, int? durationInMinutes = default)
        {
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new InvalidDataException("startTime is a required property for AppointmentTimeInput and cannot be null");
            }
            else
            {
                this.StartTime = startTime;
            }
            this.DurationInMinutes = durationInMinutes;
        }

        /// <summary>
        /// The date, time in UTC for the start time of an appointment in ISO 8601 format.
        /// </summary>
        /// <value>The date, time in UTC for the start time of an appointment in ISO 8601 format.</value>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The duration of an appointment in minutes.
        /// </summary>
        /// <value>The duration of an appointment in minutes.</value>
        [DataMember(Name = "durationInMinutes", EmitDefaultValue = false)]
        public int? DurationInMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppointmentTimeInput {\n");
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
            return this.Equals(input as AppointmentTimeInput);
        }

        /// <summary>
        /// Returns true if AppointmentTimeInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AppointmentTimeInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppointmentTimeInput input)
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
            yield break;
        }
    }

}
