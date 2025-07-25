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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Services
{
    /// <summary>
    /// Information about the location of the service job.
    /// </summary>
    [DataContract]
    public partial class ServiceLocation : IEquatable<ServiceLocation>, IValidatableObject
    {
        /// <summary>
        /// The location of the service job.
        /// </summary>
        /// <value>The location of the service job.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceLocationTypeEnum
        {

            /// <summary>
            /// Enum INHOME for value: IN_HOME
            /// </summary>
            [EnumMember(Value = "IN_HOME")]
            INHOME = 1,

            /// <summary>
            /// Enum INSTORE for value: IN_STORE
            /// </summary>
            [EnumMember(Value = "IN_STORE")]
            INSTORE = 2,

            /// <summary>
            /// Enum ONLINE for value: ONLINE
            /// </summary>
            [EnumMember(Value = "ONLINE")]
            ONLINE = 3
        }

        /// <summary>
        /// The location of the service job.
        /// </summary>
        /// <value>The location of the service job.</value>
        [DataMember(Name = "serviceLocationType", EmitDefaultValue = false)]
        public ServiceLocationTypeEnum? ServiceLocationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLocation" /> class.
        /// </summary>
        /// <param name="serviceLocationType">The location of the service job..</param>
        /// <param name="address">The shipping address for the service job..</param>
        public ServiceLocation(ServiceLocationTypeEnum? serviceLocationType = default, Address address = default)
        {
            this.ServiceLocationType = serviceLocationType;
            this.Address = address;
        }


        /// <summary>
        /// The shipping address for the service job.
        /// </summary>
        /// <value>The shipping address for the service job.</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceLocation {\n");
            sb.Append("  ServiceLocationType: ").Append(ServiceLocationType).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as ServiceLocation);
        }

        /// <summary>
        /// Returns true if ServiceLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceLocation input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ServiceLocationType == input.ServiceLocationType ||
                    (this.ServiceLocationType != null &&
                    this.ServiceLocationType.Equals(input.ServiceLocationType))
                ) &&
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.ServiceLocationType != null)
                    hashCode = hashCode * 59 + this.ServiceLocationType.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
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
