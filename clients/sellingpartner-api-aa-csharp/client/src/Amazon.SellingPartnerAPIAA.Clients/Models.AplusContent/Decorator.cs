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
    /// A decorator applied to a content string value in order to create rich text.
    /// </summary>
    [DataContract]
    public partial class Decorator :  IEquatable<Decorator>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public DecoratorType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Decorator" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="offset">The starting character of this decorator within the content string. Use zero for the first character..</param>
        /// <param name="length">The number of content characters to alter with this decorator. Decorators such as line breaks can have zero length and fit between characters..</param>
        /// <param name="depth">The relative intensity or variation of this decorator. Decorators such as bullet-points, for example, can have multiple indentation depths..</param>
        public Decorator(DecoratorType? type = default(DecoratorType?), int? offset = default(int?), int? length = default(int?), int? depth = default(int?))
        {
            this.Type = type;
            this.Offset = offset;
            this.Length = length;
            this.Depth = depth;
        }
        

        /// <summary>
        /// The starting character of this decorator within the content string. Use zero for the first character.
        /// </summary>
        /// <value>The starting character of this decorator within the content string. Use zero for the first character.</value>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// The number of content characters to alter with this decorator. Decorators such as line breaks can have zero length and fit between characters.
        /// </summary>
        /// <value>The number of content characters to alter with this decorator. Decorators such as line breaks can have zero length and fit between characters.</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; set; }

        /// <summary>
        /// The relative intensity or variation of this decorator. Decorators such as bullet-points, for example, can have multiple indentation depths.
        /// </summary>
        /// <value>The relative intensity or variation of this decorator. Decorators such as bullet-points, for example, can have multiple indentation depths.</value>
        [DataMember(Name="depth", EmitDefaultValue=false)]
        public int? Depth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Decorator {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
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
            return this.Equals(input as Decorator);
        }

        /// <summary>
        /// Returns true if Decorator instances are equal
        /// </summary>
        /// <param name="input">Instance of Decorator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Decorator input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Depth != null)
                    hashCode = hashCode * 59 + this.Depth.GetHashCode();
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
            // Offset (int?) maximum
            if(this.Offset > (int?)10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Offset, must be a value less than or equal to 10000.", new [] { "Offset" });
            }

            // Offset (int?) minimum
            if(this.Offset < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Offset, must be a value greater than or equal to 0.", new [] { "Offset" });
            }

            // Length (int?) maximum
            if(this.Length > (int?)10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Length, must be a value less than or equal to 10000.", new [] { "Length" });
            }

            // Length (int?) minimum
            if(this.Length < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Length, must be a value greater than or equal to 0.", new [] { "Length" });
            }

            // Depth (int?) maximum
            if(this.Depth > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Depth, must be a value less than or equal to 100.", new [] { "Depth" });
            }

            // Depth (int?) minimum
            if(this.Depth < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Depth, must be a value greater than or equal to 0.", new [] { "Depth" });
            }

            yield break;
        }
    }

}
