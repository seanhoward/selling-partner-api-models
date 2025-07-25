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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent
{
    /// <summary>
    /// PostContentDocumentAsinRelationsRequest
    /// </summary>
    [DataContract]
    public partial class PostContentDocumentAsinRelationsRequest : IEquatable<PostContentDocumentAsinRelationsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostContentDocumentAsinRelationsRequest" /> class.
        /// </summary>
        [JsonConstructor]
        protected PostContentDocumentAsinRelationsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostContentDocumentAsinRelationsRequest" /> class.
        /// </summary>
        /// <param name="asinSet">asinSet (required).</param>
        public PostContentDocumentAsinRelationsRequest(AsinSet asinSet = default)
        {
            // to ensure "asinSet" is required (not null)
            if (asinSet == null)
            {
                throw new InvalidDataException("asinSet is a required property for PostContentDocumentAsinRelationsRequest and cannot be null");
            }
            else
            {
                this.AsinSet = asinSet;
            }
        }

        /// <summary>
        /// Gets or Sets AsinSet
        /// </summary>
        [DataMember(Name = "asinSet", EmitDefaultValue = false)]
        public AsinSet AsinSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostContentDocumentAsinRelationsRequest {\n");
            sb.Append("  AsinSet: ").Append(AsinSet).Append("\n");
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
            return this.Equals(input as PostContentDocumentAsinRelationsRequest);
        }

        /// <summary>
        /// Returns true if PostContentDocumentAsinRelationsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostContentDocumentAsinRelationsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostContentDocumentAsinRelationsRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AsinSet == input.AsinSet ||
                    (this.AsinSet != null &&
                    this.AsinSet.Equals(input.AsinSet))
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
                if (this.AsinSet != null)
                    hashCode = hashCode * 59 + this.AsinSet.GetHashCode();
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
