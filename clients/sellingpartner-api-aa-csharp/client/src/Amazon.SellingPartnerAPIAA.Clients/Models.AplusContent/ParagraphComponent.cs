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
    /// A list of rich text content that is typically presented in a text box.
    /// </summary>
    [DataContract]
    public partial class ParagraphComponent : IEquatable<ParagraphComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphComponent" /> class.
        /// </summary>
        [JsonConstructor]
        protected ParagraphComponent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphComponent" /> class.
        /// </summary>
        /// <param name="textList">textList (required).</param>
        public ParagraphComponent(List<TextComponent> textList = default)
        {
            // to ensure "textList" is required (not null)
            if (textList == null)
            {
                throw new InvalidDataException("textList is a required property for ParagraphComponent and cannot be null");
            }
            else
            {
                this.TextList = textList;
            }
        }

        /// <summary>
        /// Gets or Sets TextList
        /// </summary>
        [DataMember(Name = "textList", EmitDefaultValue = false)]
        public List<TextComponent> TextList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParagraphComponent {\n");
            sb.Append("  TextList: ").Append(TextList).Append("\n");
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
            return this.Equals(input as ParagraphComponent);
        }

        /// <summary>
        /// Returns true if ParagraphComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of ParagraphComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParagraphComponent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TextList == input.TextList ||
                    this.TextList != null &&
                    this.TextList.SequenceEqual(input.TextList)
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
                if (this.TextList != null)
                    hashCode = hashCode * 59 + this.TextList.GetHashCode();
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
