/* 
 * Selling Partner API for A+ Content Management
 *
 * Use the A+ Content API to build applications that help selling partners add rich marketing content to their Amazon product detail pages. Selling partners can use A+ content to share their brand and product story, which helps buyers make informed purchasing decisions. Selling partners use content modules to add images and text.
 *
 * OpenAPI spec version: 2020-11-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent
{
    /// <summary>
    /// ValidateContentDocumentAsinRelationsResponse
    /// </summary>
    [DataContract]
    public partial class ValidateContentDocumentAsinRelationsResponse : AplusResponse, IEquatable<ValidateContentDocumentAsinRelationsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateContentDocumentAsinRelationsResponse" /> class.
        /// </summary>
        [JsonConstructor]
        protected ValidateContentDocumentAsinRelationsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateContentDocumentAsinRelationsResponse" /> class.
        /// </summary>
        /// <param name="errors">A list of error responses that are returned when a request is unsuccessful. (required).</param>
        public ValidateContentDocumentAsinRelationsResponse(List<Error> errors = default, MessageSet warnings = default) : base(warnings)
        {
            // to ensure "errors" is required (not null)
            if (errors == null)
            {
                throw new InvalidDataException("errors is a required property for ValidateContentDocumentAsinRelationsResponse and cannot be null");
            }
            else
            {
                this.Errors = errors;
            }
        }

        /// <summary>
        /// A list of error responses that are returned when a request is unsuccessful.
        /// </summary>
        /// <value>A list of error responses that are returned when a request is unsuccessful.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateContentDocumentAsinRelationsResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ValidateContentDocumentAsinRelationsResponse);
        }

        /// <summary>
        /// Returns true if ValidateContentDocumentAsinRelationsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateContentDocumentAsinRelationsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateContentDocumentAsinRelationsResponse input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
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
                int hashCode = base.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            //foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
