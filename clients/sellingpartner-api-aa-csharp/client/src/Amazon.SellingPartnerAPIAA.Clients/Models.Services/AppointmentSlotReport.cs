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
    /// Availability information as per the service context queried.
    /// </summary>
    [DataContract]
    public partial class AppointmentSlotReport :  IEquatable<AppointmentSlotReport>, IValidatableObject
    {
        /// <summary>
        /// Defines the type of slots.
        /// </summary>
        /// <value>Defines the type of slots.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SchedulingTypeEnum
        {
            
            /// <summary>
            /// Enum REALTIMESCHEDULING for value: REAL_TIME_SCHEDULING
            /// </summary>
            [EnumMember(Value = "REAL_TIME_SCHEDULING")]
            REALTIMESCHEDULING = 1,
            
            /// <summary>
            /// Enum NONREALTIMESCHEDULING for value: NON_REAL_TIME_SCHEDULING
            /// </summary>
            [EnumMember(Value = "NON_REAL_TIME_SCHEDULING")]
            NONREALTIMESCHEDULING = 2
        }

        /// <summary>
        /// Defines the type of slots.
        /// </summary>
        /// <value>Defines the type of slots.</value>
        [DataMember(Name="schedulingType", EmitDefaultValue=false)]
        public SchedulingTypeEnum? SchedulingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentSlotReport" /> class.
        /// </summary>
        /// <param name="schedulingType">Defines the type of slots..</param>
        /// <param name="startTime">Start Time from which the appointment slots are generated in ISO 8601 format..</param>
        /// <param name="endTime">End Time up to which the appointment slots are generated in ISO 8601 format..</param>
        /// <param name="appointmentSlots">A list of time windows along with associated capacity in which the service can be performed..</param>
        public AppointmentSlotReport(SchedulingTypeEnum? schedulingType = default(SchedulingTypeEnum?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), List<AppointmentSlot> appointmentSlots = default(List<AppointmentSlot>))
        {
            this.SchedulingType = schedulingType;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.AppointmentSlots = appointmentSlots;
        }
        

        /// <summary>
        /// Start Time from which the appointment slots are generated in ISO 8601 format.
        /// </summary>
        /// <value>Start Time from which the appointment slots are generated in ISO 8601 format.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// End Time up to which the appointment slots are generated in ISO 8601 format.
        /// </summary>
        /// <value>End Time up to which the appointment slots are generated in ISO 8601 format.</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// A list of time windows along with associated capacity in which the service can be performed.
        /// </summary>
        /// <value>A list of time windows along with associated capacity in which the service can be performed.</value>
        [DataMember(Name="appointmentSlots", EmitDefaultValue=false)]
        public List<AppointmentSlot> AppointmentSlots { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppointmentSlotReport {\n");
            sb.Append("  SchedulingType: ").Append(SchedulingType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  AppointmentSlots: ").Append(AppointmentSlots).Append("\n");
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
            return this.Equals(input as AppointmentSlotReport);
        }

        /// <summary>
        /// Returns true if AppointmentSlotReport instances are equal
        /// </summary>
        /// <param name="input">Instance of AppointmentSlotReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppointmentSlotReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchedulingType == input.SchedulingType ||
                    (this.SchedulingType != null &&
                    this.SchedulingType.Equals(input.SchedulingType))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.AppointmentSlots == input.AppointmentSlots ||
                    this.AppointmentSlots != null &&
                    this.AppointmentSlots.SequenceEqual(input.AppointmentSlots)
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
                if (this.SchedulingType != null)
                    hashCode = hashCode * 59 + this.SchedulingType.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.AppointmentSlots != null)
                    hashCode = hashCode * 59 + this.AppointmentSlots.GetHashCode();
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