/* 
 * Selling Partner API for Orders
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Orders
{
    /// <summary>
    /// Business days and hours when the destination is open for deliveries.
    /// </summary>
    [DataContract]
    public partial class BusinessHours : IEquatable<BusinessHours>, IValidatableObject
    {
        /// <summary>
        /// Day of the week.
        /// </summary>
        /// <value>Day of the week.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayOfWeekEnum
        {

            /// <summary>
            /// Enum SUN for value: SUN
            /// </summary>
            [EnumMember(Value = "SUN")]
            SUN = 1,

            /// <summary>
            /// Enum MON for value: MON
            /// </summary>
            [EnumMember(Value = "MON")]
            MON = 2,

            /// <summary>
            /// Enum TUE for value: TUE
            /// </summary>
            [EnumMember(Value = "TUE")]
            TUE = 3,

            /// <summary>
            /// Enum WED for value: WED
            /// </summary>
            [EnumMember(Value = "WED")]
            WED = 4,

            /// <summary>
            /// Enum THU for value: THU
            /// </summary>
            [EnumMember(Value = "THU")]
            THU = 5,

            /// <summary>
            /// Enum FRI for value: FRI
            /// </summary>
            [EnumMember(Value = "FRI")]
            FRI = 6,

            /// <summary>
            /// Enum SAT for value: SAT
            /// </summary>
            [EnumMember(Value = "SAT")]
            SAT = 7
        }

        /// <summary>
        /// Day of the week.
        /// </summary>
        /// <value>Day of the week.</value>
        [DataMember(Name = "DayOfWeek", EmitDefaultValue = false)]
        public DayOfWeekEnum? DayOfWeek { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessHours" /> class.
        /// </summary>
        /// <param name="dayOfWeek">Day of the week..</param>
        /// <param name="openIntervals">Time window during the day when the business is open..</param>
        public BusinessHours(DayOfWeekEnum? dayOfWeek = default, List<OpenInterval> openIntervals = default)
        {
            this.DayOfWeek = dayOfWeek;
            this.OpenIntervals = openIntervals;
        }


        /// <summary>
        /// Time window during the day when the business is open.
        /// </summary>
        /// <value>Time window during the day when the business is open.</value>
        [DataMember(Name = "OpenIntervals", EmitDefaultValue = false)]
        public List<OpenInterval> OpenIntervals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessHours {\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  OpenIntervals: ").Append(OpenIntervals).Append("\n");
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
            return this.Equals(input as BusinessHours);
        }

        /// <summary>
        /// Returns true if BusinessHours instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessHours to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessHours input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DayOfWeek == input.DayOfWeek ||
                    (this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(input.DayOfWeek))
                ) &&
                (
                    this.OpenIntervals == input.OpenIntervals ||
                    this.OpenIntervals != null &&
                    this.OpenIntervals.SequenceEqual(input.OpenIntervals)
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
                if (this.DayOfWeek != null)
                    hashCode = hashCode * 59 + this.DayOfWeek.GetHashCode();
                if (this.OpenIntervals != null)
                    hashCode = hashCode * 59 + this.OpenIntervals.GetHashCode();
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
