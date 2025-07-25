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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources
{
    /// <summary>
    /// Includes configuration and timezone of a supply source.
    /// </summary>
    [DataContract]
    public partial class SupplySourceConfiguration : IEquatable<SupplySourceConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplySourceConfiguration" /> class.
        /// </summary>
        /// <param name="operationalConfiguration">operationalConfiguration.</param>
        /// <param name="timezone">Please see RFC 6557, should be a canonical time zone ID as listed here: https://www.joda.org/joda-time/timezones.html..</param>
        public SupplySourceConfiguration(OperationalConfiguration operationalConfiguration = default, string timezone = default)
        {
            this.OperationalConfiguration = operationalConfiguration;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Gets or Sets OperationalConfiguration
        /// </summary>
        [DataMember(Name = "operationalConfiguration", EmitDefaultValue = false)]
        public OperationalConfiguration OperationalConfiguration { get; set; }

        /// <summary>
        /// Please see RFC 6557, should be a canonical time zone ID as listed here: https://www.joda.org/joda-time/timezones.html.
        /// </summary>
        /// <value>Please see RFC 6557, should be a canonical time zone ID as listed here: https://www.joda.org/joda-time/timezones.html.</value>
        [DataMember(Name = "timezone", EmitDefaultValue = false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupplySourceConfiguration {\n");
            sb.Append("  OperationalConfiguration: ").Append(OperationalConfiguration).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(input as SupplySourceConfiguration);
        }

        /// <summary>
        /// Returns true if SupplySourceConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of SupplySourceConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupplySourceConfiguration input)
        {
            if (input == null)
                return false;

            return
                (
                    this.OperationalConfiguration == input.OperationalConfiguration ||
                    (this.OperationalConfiguration != null &&
                    this.OperationalConfiguration.Equals(input.OperationalConfiguration))
                ) &&
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
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
                if (this.OperationalConfiguration != null)
                    hashCode = hashCode * 59 + this.OperationalConfiguration.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
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
