/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Amazon.SellingPartnerAPIAA.Client.Model
{
    /// <summary>
    /// The time range in which an item will likely be shipped once an order has been placed.
    /// </summary>
    [DataContract]
    public partial class DetailedShippingTimeType : IEquatable<DetailedShippingTimeType>, IValidatableObject
    {
        /// <summary>
        /// Indicates whether the item is available for shipping now, or on a known or an unknown date in the future. If known, the availableDate property indicates the date that the item will be available for shipping. Possible values: NOW, FUTURE_WITHOUT_DATE, FUTURE_WITH_DATE.
        /// </summary>
        /// <value>Indicates whether the item is available for shipping now, or on a known or an unknown date in the future. If known, the availableDate property indicates the date that the item will be available for shipping. Possible values: NOW, FUTURE_WITHOUT_DATE, FUTURE_WITH_DATE.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailabilityTypeEnum
        {

            /// <summary>
            /// Enum NOW for value: NOW
            /// </summary>
            [EnumMember(Value = "NOW")]
            NOW = 1,

            /// <summary>
            /// Enum FUTUREWITHOUTDATE for value: FUTURE_WITHOUT_DATE
            /// </summary>
            [EnumMember(Value = "FUTURE_WITHOUT_DATE")]
            FUTUREWITHOUTDATE = 2,

            /// <summary>
            /// Enum FUTUREWITHDATE for value: FUTURE_WITH_DATE
            /// </summary>
            [EnumMember(Value = "FUTURE_WITH_DATE")]
            FUTUREWITHDATE = 3
        }

        /// <summary>
        /// Indicates whether the item is available for shipping now, or on a known or an unknown date in the future. If known, the availableDate property indicates the date that the item will be available for shipping. Possible values: NOW, FUTURE_WITHOUT_DATE, FUTURE_WITH_DATE.
        /// </summary>
        /// <value>Indicates whether the item is available for shipping now, or on a known or an unknown date in the future. If known, the availableDate property indicates the date that the item will be available for shipping. Possible values: NOW, FUTURE_WITHOUT_DATE, FUTURE_WITH_DATE.</value>
        [DataMember(Name = "availabilityType", EmitDefaultValue = false)]
        public AvailabilityTypeEnum? AvailabilityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedShippingTimeType" /> class.
        /// </summary>
        /// <param name="minimumHours">The minimum time, in hours, that the item will likely be shipped after the order has been placed..</param>
        /// <param name="maximumHours">The maximum time, in hours, that the item will likely be shipped after the order has been placed..</param>
        /// <param name="availableDate">The date when the item will be available for shipping. Only displayed for items that are not currently available for shipping..</param>
        /// <param name="availabilityType">Indicates whether the item is available for shipping now, or on a known or an unknown date in the future. If known, the availableDate property indicates the date that the item will be available for shipping. Possible values: NOW, FUTURE_WITHOUT_DATE, FUTURE_WITH_DATE..</param>
        public DetailedShippingTimeType(long? minimumHours = default(long?), long? maximumHours = default(long?), string availableDate = default(string), AvailabilityTypeEnum? availabilityType = default(AvailabilityTypeEnum?))
        {
            this.MinimumHours = minimumHours;
            this.MaximumHours = maximumHours;
            this.AvailableDate = availableDate;
            this.AvailabilityType = availabilityType;
        }

        /// <summary>
        /// The minimum time, in hours, that the item will likely be shipped after the order has been placed.
        /// </summary>
        /// <value>The minimum time, in hours, that the item will likely be shipped after the order has been placed.</value>
        [DataMember(Name = "minimumHours", EmitDefaultValue = false)]
        public long? MinimumHours { get; set; }

        /// <summary>
        /// The maximum time, in hours, that the item will likely be shipped after the order has been placed.
        /// </summary>
        /// <value>The maximum time, in hours, that the item will likely be shipped after the order has been placed.</value>
        [DataMember(Name = "maximumHours", EmitDefaultValue = false)]
        public long? MaximumHours { get; set; }

        /// <summary>
        /// The date when the item will be available for shipping. Only displayed for items that are not currently available for shipping.
        /// </summary>
        /// <value>The date when the item will be available for shipping. Only displayed for items that are not currently available for shipping.</value>
        [DataMember(Name = "availableDate", EmitDefaultValue = false)]
        public string AvailableDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedShippingTimeType {\n");
            sb.Append("  MinimumHours: ").Append(MinimumHours).Append("\n");
            sb.Append("  MaximumHours: ").Append(MaximumHours).Append("\n");
            sb.Append("  AvailableDate: ").Append(AvailableDate).Append("\n");
            sb.Append("  AvailabilityType: ").Append(AvailabilityType).Append("\n");
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
            return this.Equals(input as DetailedShippingTimeType);
        }

        /// <summary>
        /// Returns true if DetailedShippingTimeType instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedShippingTimeType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedShippingTimeType input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MinimumHours == input.MinimumHours ||
                    (this.MinimumHours != null &&
                    this.MinimumHours.Equals(input.MinimumHours))
                ) &&
                (
                    this.MaximumHours == input.MaximumHours ||
                    (this.MaximumHours != null &&
                    this.MaximumHours.Equals(input.MaximumHours))
                ) &&
                (
                    this.AvailableDate == input.AvailableDate ||
                    (this.AvailableDate != null &&
                    this.AvailableDate.Equals(input.AvailableDate))
                ) &&
                (
                    this.AvailabilityType == input.AvailabilityType ||
                    (this.AvailabilityType != null &&
                    this.AvailabilityType.Equals(input.AvailabilityType))
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
                if (this.MinimumHours != null)
                    hashCode = hashCode * 59 + this.MinimumHours.GetHashCode();
                if (this.MaximumHours != null)
                    hashCode = hashCode * 59 + this.MaximumHours.GetHashCode();
                if (this.AvailableDate != null)
                    hashCode = hashCode * 59 + this.AvailableDate.GetHashCode();
                if (this.AvailabilityType != null)
                    hashCode = hashCode * 59 + this.AvailabilityType.GetHashCode();
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
