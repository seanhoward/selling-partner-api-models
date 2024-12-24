/* 
 * Selling Partner API for A+ Content Management
 *
 * With the A+ Content API, you can build applications that help selling partners add rich marketing content to their Amazon product detail pages. A+ content helps selling partners share their brand and product story, which helps buyers make informed purchasing decisions. Selling partners assemble content by choosing from content modules and adding images and text.
 *
 * OpenAPI spec version: 2020-11-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent
{
    /// <summary>
    /// The A+ Content standard fixed length list of text, usually presented as bullet points.
    /// </summary>
    [DataContract]
    public partial class StandardTextListBlock :  IEquatable<StandardTextListBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardTextListBlock" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StandardTextListBlock() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardTextListBlock" /> class.
        /// </summary>
        /// <param name="textList">textList (required).</param>
        public StandardTextListBlock(List<TextItem> textList = default(List<TextItem>))
        {
            // to ensure "textList" is required (not null)
            if (textList == null)
            {
                throw new InvalidDataException("textList is a required property for StandardTextListBlock and cannot be null");
            }
            else
            {
                this.TextList = textList;
            }
        }
        
        /// <summary>
        /// Gets or Sets TextList
        /// </summary>
        [DataMember(Name="textList", EmitDefaultValue=false)]
        public List<TextItem> TextList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardTextListBlock {\n");
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
            return this.Equals(input as StandardTextListBlock);
        }

        /// <summary>
        /// Returns true if StandardTextListBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of StandardTextListBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandardTextListBlock input)
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
