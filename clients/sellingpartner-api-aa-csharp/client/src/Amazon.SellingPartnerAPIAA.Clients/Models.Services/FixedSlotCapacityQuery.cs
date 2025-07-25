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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Services
{
    /// <summary>
    /// Request schema for the &#x60;getFixedSlotCapacity&#x60; operation. This schema is used to define the time range, capacity types and slot duration which are being queried.
    /// </summary>
    [DataContract]
    public partial class FixedSlotCapacityQuery : IEquatable<FixedSlotCapacityQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedSlotCapacityQuery" /> class.
        /// </summary>
        [JsonConstructor]
        protected FixedSlotCapacityQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedSlotCapacityQuery" /> class.
        /// </summary>
        /// <param name="capacityTypes">An array of capacity types which are being requested. Default value is &#x60;[SCHEDULED_CAPACITY]&#x60;..</param>
        /// <param name="slotDuration">Size in which slots are being requested. This value should be a multiple of 5 and fall in the range: 5 &lt;&#x3D; &#x60;slotDuration&#x60; &lt;&#x3D; 360..</param>
        /// <param name="startDateTime">Start date time from which the capacity slots are being requested in ISO 8601 format. (required).</param>
        /// <param name="endDateTime">End date time up to which the capacity slots are being requested in ISO 8601 format. (required).</param>
        public FixedSlotCapacityQuery(List<CapacityType> capacityTypes = default, decimal? slotDuration = default, DateTime? startDateTime = default, DateTime? endDateTime = default)
        {
            // to ensure "startDateTime" is required (not null)
            if (startDateTime == null)
            {
                throw new InvalidDataException("startDateTime is a required property for FixedSlotCapacityQuery and cannot be null");
            }
            else
            {
                this.StartDateTime = startDateTime;
            }
            // to ensure "endDateTime" is required (not null)
            if (endDateTime == null)
            {
                throw new InvalidDataException("endDateTime is a required property for FixedSlotCapacityQuery and cannot be null");
            }
            else
            {
                this.EndDateTime = endDateTime;
            }
            this.CapacityTypes = capacityTypes;
            this.SlotDuration = slotDuration;
        }

        /// <summary>
        /// An array of capacity types which are being requested. Default value is &#x60;[SCHEDULED_CAPACITY]&#x60;.
        /// </summary>
        /// <value>An array of capacity types which are being requested. Default value is &#x60;[SCHEDULED_CAPACITY]&#x60;.</value>
        [DataMember(Name = "capacityTypes", EmitDefaultValue = false)]
        public List<CapacityType> CapacityTypes { get; set; }

        /// <summary>
        /// Size in which slots are being requested. This value should be a multiple of 5 and fall in the range: 5 &lt;&#x3D; &#x60;slotDuration&#x60; &lt;&#x3D; 360.
        /// </summary>
        /// <value>Size in which slots are being requested. This value should be a multiple of 5 and fall in the range: 5 &lt;&#x3D; &#x60;slotDuration&#x60; &lt;&#x3D; 360.</value>
        [DataMember(Name = "slotDuration", EmitDefaultValue = false)]
        public decimal? SlotDuration { get; set; }

        /// <summary>
        /// Start date time from which the capacity slots are being requested in ISO 8601 format.
        /// </summary>
        /// <value>Start date time from which the capacity slots are being requested in ISO 8601 format.</value>
        [DataMember(Name = "startDateTime", EmitDefaultValue = false)]
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// End date time up to which the capacity slots are being requested in ISO 8601 format.
        /// </summary>
        /// <value>End date time up to which the capacity slots are being requested in ISO 8601 format.</value>
        [DataMember(Name = "endDateTime", EmitDefaultValue = false)]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedSlotCapacityQuery {\n");
            sb.Append("  CapacityTypes: ").Append(CapacityTypes).Append("\n");
            sb.Append("  SlotDuration: ").Append(SlotDuration).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
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
            return this.Equals(input as FixedSlotCapacityQuery);
        }

        /// <summary>
        /// Returns true if FixedSlotCapacityQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedSlotCapacityQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedSlotCapacityQuery input)
        {
            if (input == null)
                return false;

            return
                (
                    this.CapacityTypes == input.CapacityTypes ||
                    this.CapacityTypes != null &&
                    this.CapacityTypes.SequenceEqual(input.CapacityTypes)
                ) &&
                (
                    this.SlotDuration == input.SlotDuration ||
                    (this.SlotDuration != null &&
                    this.SlotDuration.Equals(input.SlotDuration))
                ) &&
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) &&
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
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
                if (this.CapacityTypes != null)
                    hashCode = hashCode * 59 + this.CapacityTypes.GetHashCode();
                if (this.SlotDuration != null)
                    hashCode = hashCode * 59 + this.SlotDuration.GetHashCode();
                if (this.StartDateTime != null)
                    hashCode = hashCode * 59 + this.StartDateTime.GetHashCode();
                if (this.EndDateTime != null)
                    hashCode = hashCode * 59 + this.EndDateTime.GetHashCode();
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
