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
    /// The in-store pickup configuration of a supply source.
    /// </summary>
    [DataContract]
    public partial class InStorePickupConfiguration : IEquatable<InStorePickupConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InStorePickupConfiguration" /> class.
        /// </summary>
        /// <param name="isSupported">When true, in-store pickup is supported by the supply source (default: &#x60;isSupported&#x60; value in &#x60;PickupChannel&#x60;)..</param>
        /// <param name="parkingConfiguration">The parking configuration for in-store pickup..</param>
        public InStorePickupConfiguration(bool? isSupported = default, ParkingConfiguration parkingConfiguration = default)
        {
            this.IsSupported = isSupported;
            this.ParkingConfiguration = parkingConfiguration;
        }

        /// <summary>
        /// When true, in-store pickup is supported by the supply source (default: &#x60;isSupported&#x60; value in &#x60;PickupChannel&#x60;).
        /// </summary>
        /// <value>When true, in-store pickup is supported by the supply source (default: &#x60;isSupported&#x60; value in &#x60;PickupChannel&#x60;).</value>
        [DataMember(Name = "isSupported", EmitDefaultValue = false)]
        public bool? IsSupported { get; set; }

        /// <summary>
        /// The parking configuration for in-store pickup.
        /// </summary>
        /// <value>The parking configuration for in-store pickup.</value>
        [DataMember(Name = "parkingConfiguration", EmitDefaultValue = false)]
        public ParkingConfiguration ParkingConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InStorePickupConfiguration {\n");
            sb.Append("  IsSupported: ").Append(IsSupported).Append("\n");
            sb.Append("  ParkingConfiguration: ").Append(ParkingConfiguration).Append("\n");
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
            return this.Equals(input as InStorePickupConfiguration);
        }

        /// <summary>
        /// Returns true if InStorePickupConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of InStorePickupConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InStorePickupConfiguration input)
        {
            if (input == null)
                return false;

            return
                (
                    this.IsSupported == input.IsSupported ||
                    (this.IsSupported != null &&
                    this.IsSupported.Equals(input.IsSupported))
                ) &&
                (
                    this.ParkingConfiguration == input.ParkingConfiguration ||
                    (this.ParkingConfiguration != null &&
                    this.ParkingConfiguration.Equals(input.ParkingConfiguration))
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
                if (this.IsSupported != null)
                    hashCode = hashCode * 59 + this.IsSupported.GetHashCode();
                if (this.ParkingConfiguration != null)
                    hashCode = hashCode * 59 + this.ParkingConfiguration.GetHashCode();
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
