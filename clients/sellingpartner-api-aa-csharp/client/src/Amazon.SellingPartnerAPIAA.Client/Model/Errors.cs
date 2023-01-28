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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Amazon.SellingPartnerAPIAA.Client.Model
{
    /// <summary>
    /// A list of error responses returned when a request is unsuccessful.
    /// </summary>
    [DataContract]
    public partial class Errors : IEquatable<Errors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Errors" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Errors() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Errors" /> class.
        /// </summary>
        /// <param name="errors">One or more unexpected errors occurred during the operation. (required).</param>
        public Errors(ErrorList errors = default(ErrorList))
        {
            // to ensure "errors" is required (not null)
            if (errors == null)
            {
                throw new InvalidDataException("errors is a required property for Errors and cannot be null");
            }
            else
            {
                this._Errors = errors;
            }
        }

        /// <summary>
        /// One or more unexpected errors occurred during the operation.
        /// </summary>
        /// <value>One or more unexpected errors occurred during the operation.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList _Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Errors {\n");
            sb.Append("  _Errors: ").Append(_Errors).Append("\n");
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
            return this.Equals(input as Errors);
        }

        /// <summary>
        /// Returns true if Errors instances are equal
        /// </summary>
        /// <param name="input">Instance of Errors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Errors input)
        {
            if (input == null)
                return false;

            return
                (
                    this._Errors == input._Errors ||
                    (this._Errors != null &&
                    this._Errors.Equals(input._Errors))
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
                if (this._Errors != null)
                    hashCode = hashCode * 59 + this._Errors.GetHashCode();
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