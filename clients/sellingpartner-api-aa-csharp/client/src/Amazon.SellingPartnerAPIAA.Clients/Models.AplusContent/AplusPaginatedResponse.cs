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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent
{
    /// <summary>
    /// A token that you use to retrieve the next page of results. To get the next page of results, call the operation with this token and include the same arguments as the call that produced the token. To get a complete list, call this operation until &#x60;nextPageToken&#x60; is null. Note that this operation can return empty pages.
    /// </summary>
    [DataContract]
    public partial class AplusPaginatedResponse : AplusResponse, IEquatable<AplusPaginatedResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AplusPaginatedResponse" /> class.
        /// </summary>
        /// <param name="nextPageToken">nextPageToken.</param>
        public AplusPaginatedResponse(string nextPageToken = default, MessageSet warnings = default) : base(warnings)
        {
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Gets or Sets NextPageToken
        /// </summary>
        [DataMember(Name = "nextPageToken", EmitDefaultValue = false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AplusPaginatedResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  NextPageToken: ").Append(NextPageToken).Append("\n");
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
            return this.Equals(input as AplusPaginatedResponse);
        }

        /// <summary>
        /// Returns true if AplusPaginatedResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AplusPaginatedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AplusPaginatedResponse input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.NextPageToken == input.NextPageToken ||
                    (this.NextPageToken != null &&
                    this.NextPageToken.Equals(input.NextPageToken))
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
                if (this.NextPageToken != null)
                    hashCode = hashCode * 59 + this.NextPageToken.GetHashCode();
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
