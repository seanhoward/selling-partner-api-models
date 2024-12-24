/* 
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * The Selling Partner API for Direct Fulfillment Shipping provides programmatic access to a direct fulfillment vendor's shipping data.
 *
 * OpenAPI spec version: 2021-12-28
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping
{
    /// <summary>
    /// Physical dimensional measurements of a container.
    /// </summary>
    [DataContract]
    public partial class Dimensions :  IEquatable<Dimensions>, IValidatableObject
    {
        /// <summary>
        /// The unit of measure for dimensions.
        /// </summary>
        /// <value>The unit of measure for dimensions.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitOfMeasureEnum
        {
            
            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 1,
            
            /// <summary>
            /// Enum CM for value: CM
            /// </summary>
            [EnumMember(Value = "CM")]
            CM = 2
        }

        /// <summary>
        /// The unit of measure for dimensions.
        /// </summary>
        /// <value>The unit of measure for dimensions.</value>
        [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
        public UnitOfMeasureEnum UnitOfMeasure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dimensions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Dimensions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dimensions" /> class.
        /// </summary>
        /// <param name="length">The length of the container. (required).</param>
        /// <param name="width">The width of the container. (required).</param>
        /// <param name="height">The height of the container. (required).</param>
        /// <param name="unitOfMeasure">The unit of measure for dimensions. (required).</param>
        public Dimensions(string length = default(string), string width = default(string), string height = default(string), UnitOfMeasureEnum unitOfMeasure = default(UnitOfMeasureEnum))
        {
            // to ensure "length" is required (not null)
            if (length == null)
            {
                throw new InvalidDataException("length is a required property for Dimensions and cannot be null");
            }
            else
            {
                this.Length = length;
            }
            // to ensure "width" is required (not null)
            if (width == null)
            {
                throw new InvalidDataException("width is a required property for Dimensions and cannot be null");
            }
            else
            {
                this.Width = width;
            }
            // to ensure "height" is required (not null)
            if (height == null)
            {
                throw new InvalidDataException("height is a required property for Dimensions and cannot be null");
            }
            else
            {
                this.Height = height;
            }
            // to ensure "unitOfMeasure" is required (not null)
            if (unitOfMeasure == null)
            {
                throw new InvalidDataException("unitOfMeasure is a required property for Dimensions and cannot be null");
            }
            else
            {
                this.UnitOfMeasure = unitOfMeasure;
            }
        }
        
        /// <summary>
        /// The length of the container.
        /// </summary>
        /// <value>The length of the container.</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public string Length { get; set; }

        /// <summary>
        /// The width of the container.
        /// </summary>
        /// <value>The width of the container.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public string Width { get; set; }

        /// <summary>
        /// The height of the container.
        /// </summary>
        /// <value>The height of the container.</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public string Height { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dimensions {\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
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
            return this.Equals(input as Dimensions);
        }

        /// <summary>
        /// Returns true if Dimensions instances are equal
        /// </summary>
        /// <param name="input">Instance of Dimensions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dimensions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    (this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure))
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
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.UnitOfMeasure != null)
                    hashCode = hashCode * 59 + this.UnitOfMeasure.GetHashCode();
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
