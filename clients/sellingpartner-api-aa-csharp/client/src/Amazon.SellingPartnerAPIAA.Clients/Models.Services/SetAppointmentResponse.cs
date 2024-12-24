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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Services
{
    /// <summary>
    /// Response schema for the &#x60;addAppointmentForServiceJobByServiceJobId&#x60; and &#x60;rescheduleAppointmentForServiceJobByServiceJobId&#x60; operations.
    /// </summary>
    [DataContract]
    public partial class SetAppointmentResponse :  IEquatable<SetAppointmentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetAppointmentResponse" /> class.
        /// </summary>
        /// <param name="appointmentId">New appointment identifier generated during the &#x60;addAppointmentForServiceJobByServiceJobId&#x60; or &#x60;rescheduleAppointmentForServiceJobByServiceJobId&#x60; operations..</param>
        /// <param name="warnings">Warnings generated during the &#x60;addAppointmentForServiceJobByServiceJobId&#x60; or &#x60;rescheduleAppointmentForServiceJobByServiceJobId&#x60; operations..</param>
        /// <param name="errors">Errors occurred during during the &#x60;addAppointmentForServiceJobByServiceJobId&#x60; or &#x60;rescheduleAppointmentForServiceJobByServiceJobId&#x60; operations..</param>
        public SetAppointmentResponse(string appointmentId = default(string), WarningList warnings = default(WarningList), ErrorList errors = default(ErrorList))
        {
            this.AppointmentId = appointmentId;
            this.Warnings = warnings;
            this.Errors = errors;
        }
        
        /// <summary>
        /// New appointment identifier generated during the &#x60;addAppointmentForServiceJobByServiceJobId&#x60; or &#x60;rescheduleAppointmentForServiceJobByServiceJobId&#x60; operations.
        /// </summary>
        /// <value>New appointment identifier generated during the &#x60;addAppointmentForServiceJobByServiceJobId&#x60; or &#x60;rescheduleAppointmentForServiceJobByServiceJobId&#x60; operations.</value>
        [DataMember(Name="appointmentId", EmitDefaultValue=false)]
        public string AppointmentId { get; set; }

        /// <summary>
        /// Warnings generated during the &#x60;addAppointmentForServiceJobByServiceJobId&#x60; or &#x60;rescheduleAppointmentForServiceJobByServiceJobId&#x60; operations.
        /// </summary>
        /// <value>Warnings generated during the &#x60;addAppointmentForServiceJobByServiceJobId&#x60; or &#x60;rescheduleAppointmentForServiceJobByServiceJobId&#x60; operations.</value>
        [DataMember(Name="warnings", EmitDefaultValue=false)]
        public WarningList Warnings { get; set; }

        /// <summary>
        /// Errors occurred during during the &#x60;addAppointmentForServiceJobByServiceJobId&#x60; or &#x60;rescheduleAppointmentForServiceJobByServiceJobId&#x60; operations.
        /// </summary>
        /// <value>Errors occurred during during the &#x60;addAppointmentForServiceJobByServiceJobId&#x60; or &#x60;rescheduleAppointmentForServiceJobByServiceJobId&#x60; operations.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetAppointmentResponse {\n");
            sb.Append("  AppointmentId: ").Append(AppointmentId).Append("\n");
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
            return this.Equals(input as SetAppointmentResponse);
        }

        /// <summary>
        /// Returns true if SetAppointmentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SetAppointmentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetAppointmentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppointmentId == input.AppointmentId ||
                    (this.AppointmentId != null &&
                    this.AppointmentId.Equals(input.AppointmentId))
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
                if (this.AppointmentId != null)
                    hashCode = hashCode * 59 + this.AppointmentId.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}