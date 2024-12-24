/* 
 * Selling Partner API for Supply Sources
 *
 * Manage configurations and capabilities of seller supply sources.
 *
 * OpenAPI spec version: 2020-07-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources
{
    /// <summary>
    /// The operating hours per day
    /// </summary>
    [DataContract]
    public partial class OperatingHoursByDay :  IEquatable<OperatingHoursByDay>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperatingHoursByDay" /> class.
        /// </summary>
        /// <param name="monday">monday.</param>
        /// <param name="tuesday">tuesday.</param>
        /// <param name="wednesday">wednesday.</param>
        /// <param name="thursday">thursday.</param>
        /// <param name="friday">friday.</param>
        /// <param name="saturday">saturday.</param>
        /// <param name="sunday">sunday.</param>
        public OperatingHoursByDay(OperatingHours monday = default(OperatingHours), OperatingHours tuesday = default(OperatingHours), OperatingHours wednesday = default(OperatingHours), OperatingHours thursday = default(OperatingHours), OperatingHours friday = default(OperatingHours), OperatingHours saturday = default(OperatingHours), OperatingHours sunday = default(OperatingHours))
        {
            this.Monday = monday;
            this.Tuesday = tuesday;
            this.Wednesday = wednesday;
            this.Thursday = thursday;
            this.Friday = friday;
            this.Saturday = saturday;
            this.Sunday = sunday;
        }
        
        /// <summary>
        /// Gets or Sets Monday
        /// </summary>
        [DataMember(Name="monday", EmitDefaultValue=false)]
        public OperatingHours Monday { get; set; }

        /// <summary>
        /// Gets or Sets Tuesday
        /// </summary>
        [DataMember(Name="tuesday", EmitDefaultValue=false)]
        public OperatingHours Tuesday { get; set; }

        /// <summary>
        /// Gets or Sets Wednesday
        /// </summary>
        [DataMember(Name="wednesday", EmitDefaultValue=false)]
        public OperatingHours Wednesday { get; set; }

        /// <summary>
        /// Gets or Sets Thursday
        /// </summary>
        [DataMember(Name="thursday", EmitDefaultValue=false)]
        public OperatingHours Thursday { get; set; }

        /// <summary>
        /// Gets or Sets Friday
        /// </summary>
        [DataMember(Name="friday", EmitDefaultValue=false)]
        public OperatingHours Friday { get; set; }

        /// <summary>
        /// Gets or Sets Saturday
        /// </summary>
        [DataMember(Name="saturday", EmitDefaultValue=false)]
        public OperatingHours Saturday { get; set; }

        /// <summary>
        /// Gets or Sets Sunday
        /// </summary>
        [DataMember(Name="sunday", EmitDefaultValue=false)]
        public OperatingHours Sunday { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperatingHoursByDay {\n");
            sb.Append("  Monday: ").Append(Monday).Append("\n");
            sb.Append("  Tuesday: ").Append(Tuesday).Append("\n");
            sb.Append("  Wednesday: ").Append(Wednesday).Append("\n");
            sb.Append("  Thursday: ").Append(Thursday).Append("\n");
            sb.Append("  Friday: ").Append(Friday).Append("\n");
            sb.Append("  Saturday: ").Append(Saturday).Append("\n");
            sb.Append("  Sunday: ").Append(Sunday).Append("\n");
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
            return this.Equals(input as OperatingHoursByDay);
        }

        /// <summary>
        /// Returns true if OperatingHoursByDay instances are equal
        /// </summary>
        /// <param name="input">Instance of OperatingHoursByDay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperatingHoursByDay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Monday == input.Monday ||
                    (this.Monday != null &&
                    this.Monday.Equals(input.Monday))
                ) && 
                (
                    this.Tuesday == input.Tuesday ||
                    (this.Tuesday != null &&
                    this.Tuesday.Equals(input.Tuesday))
                ) && 
                (
                    this.Wednesday == input.Wednesday ||
                    (this.Wednesday != null &&
                    this.Wednesday.Equals(input.Wednesday))
                ) && 
                (
                    this.Thursday == input.Thursday ||
                    (this.Thursday != null &&
                    this.Thursday.Equals(input.Thursday))
                ) && 
                (
                    this.Friday == input.Friday ||
                    (this.Friday != null &&
                    this.Friday.Equals(input.Friday))
                ) && 
                (
                    this.Saturday == input.Saturday ||
                    (this.Saturday != null &&
                    this.Saturday.Equals(input.Saturday))
                ) && 
                (
                    this.Sunday == input.Sunday ||
                    (this.Sunday != null &&
                    this.Sunday.Equals(input.Sunday))
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
                if (this.Monday != null)
                    hashCode = hashCode * 59 + this.Monday.GetHashCode();
                if (this.Tuesday != null)
                    hashCode = hashCode * 59 + this.Tuesday.GetHashCode();
                if (this.Wednesday != null)
                    hashCode = hashCode * 59 + this.Wednesday.GetHashCode();
                if (this.Thursday != null)
                    hashCode = hashCode * 59 + this.Thursday.GetHashCode();
                if (this.Friday != null)
                    hashCode = hashCode * 59 + this.Friday.GetHashCode();
                if (this.Saturday != null)
                    hashCode = hashCode * 59 + this.Saturday.GetHashCode();
                if (this.Sunday != null)
                    hashCode = hashCode * 59 + this.Sunday.GetHashCode();
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
