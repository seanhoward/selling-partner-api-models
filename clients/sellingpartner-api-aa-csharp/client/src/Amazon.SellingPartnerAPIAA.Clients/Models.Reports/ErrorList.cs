/* 
 * Report v2021-06-30
 *
 * The Selling Partner API for Reports lets you retrieve and manage a variety of reports that can help selling partners manage their businesses.
 *
 * OpenAPI spec version: 2021-06-30
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Reports
{
    /// <summary>
    /// A list of error responses returned when a request is unsuccessful.
    /// </summary>
    [DataContract]
    public partial class ErrorList :  IEquatable<ErrorList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorList" /> class.
        /// </summary>
        /// <param name="errors">Error response returned when the request is unsuccessful. (required).</param>
        public ErrorList(List<Error> errors = default(List<Error>))
        {
            // to ensure "errors" is required (not null)
            if (errors == null)
            {
                throw new InvalidDataException("errors is a required property for ErrorList and cannot be null");
            }
            else
            {
                this.Errors = errors;
            }
        }
        
        /// <summary>
        /// Error response returned when the request is unsuccessful.
        /// </summary>
        /// <value>Error response returned when the request is unsuccessful.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorList {\n");
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
            return this.Equals(input as ErrorList);
        }

        /// <summary>
        /// Returns true if ErrorList instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
