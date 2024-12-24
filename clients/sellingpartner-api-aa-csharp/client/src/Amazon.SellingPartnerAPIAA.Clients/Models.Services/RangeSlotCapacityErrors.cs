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
    /// The error response schema for the &#x60;getRangeSlotCapacity&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class RangeSlotCapacityErrors :  IEquatable<RangeSlotCapacityErrors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeSlotCapacityErrors" /> class.
        /// </summary>
        /// <param name="errors">Errors encountered during the &#x60;getRangeSlotCapacity&#x60; operation..</param>
        public RangeSlotCapacityErrors(ErrorList errors = default(ErrorList))
        {
            this.Errors = errors;
        }
        
        /// <summary>
        /// Errors encountered during the &#x60;getRangeSlotCapacity&#x60; operation.
        /// </summary>
        /// <value>Errors encountered during the &#x60;getRangeSlotCapacity&#x60; operation.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RangeSlotCapacityErrors {\n");
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
            return this.Equals(input as RangeSlotCapacityErrors);
        }

        /// <summary>
        /// Returns true if RangeSlotCapacityErrors instances are equal
        /// </summary>
        /// <param name="input">Instance of RangeSlotCapacityErrors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RangeSlotCapacityErrors input)
        {
            if (input == null)
                return false;

            return 
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
