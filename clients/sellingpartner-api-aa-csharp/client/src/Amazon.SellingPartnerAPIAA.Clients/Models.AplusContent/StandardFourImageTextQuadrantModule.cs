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
    /// Four standard images with text, presented on a grid of four quadrants.
    /// </summary>
    [DataContract]
    public partial class StandardFourImageTextQuadrantModule :  IEquatable<StandardFourImageTextQuadrantModule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardFourImageTextQuadrantModule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StandardFourImageTextQuadrantModule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardFourImageTextQuadrantModule" /> class.
        /// </summary>
        /// <param name="block1">block1 (required).</param>
        /// <param name="block2">block2 (required).</param>
        /// <param name="block3">block3 (required).</param>
        /// <param name="block4">block4 (required).</param>
        public StandardFourImageTextQuadrantModule(StandardImageTextBlock block1 = default(StandardImageTextBlock), StandardImageTextBlock block2 = default(StandardImageTextBlock), StandardImageTextBlock block3 = default(StandardImageTextBlock), StandardImageTextBlock block4 = default(StandardImageTextBlock))
        {
            // to ensure "block1" is required (not null)
            if (block1 == null)
            {
                throw new InvalidDataException("block1 is a required property for StandardFourImageTextQuadrantModule and cannot be null");
            }
            else
            {
                this.Block1 = block1;
            }
            // to ensure "block2" is required (not null)
            if (block2 == null)
            {
                throw new InvalidDataException("block2 is a required property for StandardFourImageTextQuadrantModule and cannot be null");
            }
            else
            {
                this.Block2 = block2;
            }
            // to ensure "block3" is required (not null)
            if (block3 == null)
            {
                throw new InvalidDataException("block3 is a required property for StandardFourImageTextQuadrantModule and cannot be null");
            }
            else
            {
                this.Block3 = block3;
            }
            // to ensure "block4" is required (not null)
            if (block4 == null)
            {
                throw new InvalidDataException("block4 is a required property for StandardFourImageTextQuadrantModule and cannot be null");
            }
            else
            {
                this.Block4 = block4;
            }
        }
        
        /// <summary>
        /// Gets or Sets Block1
        /// </summary>
        [DataMember(Name="block1", EmitDefaultValue=false)]
        public StandardImageTextBlock Block1 { get; set; }

        /// <summary>
        /// Gets or Sets Block2
        /// </summary>
        [DataMember(Name="block2", EmitDefaultValue=false)]
        public StandardImageTextBlock Block2 { get; set; }

        /// <summary>
        /// Gets or Sets Block3
        /// </summary>
        [DataMember(Name="block3", EmitDefaultValue=false)]
        public StandardImageTextBlock Block3 { get; set; }

        /// <summary>
        /// Gets or Sets Block4
        /// </summary>
        [DataMember(Name="block4", EmitDefaultValue=false)]
        public StandardImageTextBlock Block4 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardFourImageTextQuadrantModule {\n");
            sb.Append("  Block1: ").Append(Block1).Append("\n");
            sb.Append("  Block2: ").Append(Block2).Append("\n");
            sb.Append("  Block3: ").Append(Block3).Append("\n");
            sb.Append("  Block4: ").Append(Block4).Append("\n");
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
            return this.Equals(input as StandardFourImageTextQuadrantModule);
        }

        /// <summary>
        /// Returns true if StandardFourImageTextQuadrantModule instances are equal
        /// </summary>
        /// <param name="input">Instance of StandardFourImageTextQuadrantModule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandardFourImageTextQuadrantModule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Block1 == input.Block1 ||
                    (this.Block1 != null &&
                    this.Block1.Equals(input.Block1))
                ) && 
                (
                    this.Block2 == input.Block2 ||
                    (this.Block2 != null &&
                    this.Block2.Equals(input.Block2))
                ) && 
                (
                    this.Block3 == input.Block3 ||
                    (this.Block3 != null &&
                    this.Block3.Equals(input.Block3))
                ) && 
                (
                    this.Block4 == input.Block4 ||
                    (this.Block4 != null &&
                    this.Block4.Equals(input.Block4))
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
                if (this.Block1 != null)
                    hashCode = hashCode * 59 + this.Block1.GetHashCode();
                if (this.Block2 != null)
                    hashCode = hashCode * 59 + this.Block2.GetHashCode();
                if (this.Block3 != null)
                    hashCode = hashCode * 59 + this.Block3.GetHashCode();
                if (this.Block4 != null)
                    hashCode = hashCode * 59 + this.Block4.GetHashCode();
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
