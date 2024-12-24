/* 
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.   **Note:** If you are new to the Amazon Shipping API, refer to the latest version of <a href=\"https://developer-docs.amazon.com/amazon-shipping/docs/shipping-api-v2-reference\">Amazon Shipping API (v2)</a> on the <a href=\"https://developer-docs.amazon.com/amazon-shipping/\">Amazon Shipping Developer Documentation</a> site.
 *
 * OpenAPI spec version: v1
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Shipping
{
    /// <summary>
    /// Container in the shipment.
    /// </summary>
    [DataContract]
    public partial class Container :  IEquatable<Container>, IValidatableObject
    {
        /// <summary>
        /// The type of physical container being used. (always &#39;PACKAGE&#39;)
        /// </summary>
        /// <value>The type of physical container being used. (always &#39;PACKAGE&#39;)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContainerTypeEnum
        {
            
            /// <summary>
            /// Enum PACKAGE for value: PACKAGE
            /// </summary>
            [EnumMember(Value = "PACKAGE")]
            PACKAGE = 1
        }

        /// <summary>
        /// The type of physical container being used. (always &#39;PACKAGE&#39;)
        /// </summary>
        /// <value>The type of physical container being used. (always &#39;PACKAGE&#39;)</value>
        [DataMember(Name="containerType", EmitDefaultValue=false)]
        public ContainerTypeEnum? ContainerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Container" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Container() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Container" /> class.
        /// </summary>
        /// <param name="containerType">The type of physical container being used. (always &#39;PACKAGE&#39;).</param>
        /// <param name="containerReferenceId">containerReferenceId (required).</param>
        /// <param name="value">The total value of all items in the container. (required).</param>
        /// <param name="dimensions">The length, width, height, and weight of the container. (required).</param>
        /// <param name="items">A list of the items in the container. (required).</param>
        /// <param name="weight">The weight of the container. (required).</param>
        public Container(ContainerTypeEnum? containerType = default(ContainerTypeEnum?), string containerReferenceId = default(string), Currency value = default(Currency), Dimensions dimensions = default(Dimensions), List<ContainerItem> items = default(List<ContainerItem>), Weight weight = default(Weight))
        {
            // to ensure "containerReferenceId" is required (not null)
            if (containerReferenceId == null)
            {
                throw new InvalidDataException("containerReferenceId is a required property for Container and cannot be null");
            }
            else
            {
                this.ContainerReferenceId = containerReferenceId;
            }
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for Container and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            // to ensure "dimensions" is required (not null)
            if (dimensions == null)
            {
                throw new InvalidDataException("dimensions is a required property for Container and cannot be null");
            }
            else
            {
                this.Dimensions = dimensions;
            }
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new InvalidDataException("items is a required property for Container and cannot be null");
            }
            else
            {
                this.Items = items;
            }
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new InvalidDataException("weight is a required property for Container and cannot be null");
            }
            else
            {
                this.Weight = weight;
            }
            this.ContainerType = containerType;
        }
        

        /// <summary>
        /// Gets or Sets ContainerReferenceId
        /// </summary>
        [DataMember(Name="containerReferenceId", EmitDefaultValue=false)]
        public string ContainerReferenceId { get; set; }

        /// <summary>
        /// The total value of all items in the container.
        /// </summary>
        /// <value>The total value of all items in the container.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Currency Value { get; set; }

        /// <summary>
        /// The length, width, height, and weight of the container.
        /// </summary>
        /// <value>The length, width, height, and weight of the container.</value>
        [DataMember(Name="dimensions", EmitDefaultValue=false)]
        public Dimensions Dimensions { get; set; }

        /// <summary>
        /// A list of the items in the container.
        /// </summary>
        /// <value>A list of the items in the container.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ContainerItem> Items { get; set; }

        /// <summary>
        /// The weight of the container.
        /// </summary>
        /// <value>The weight of the container.</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public Weight Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Container {\n");
            sb.Append("  ContainerType: ").Append(ContainerType).Append("\n");
            sb.Append("  ContainerReferenceId: ").Append(ContainerReferenceId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as Container);
        }

        /// <summary>
        /// Returns true if Container instances are equal
        /// </summary>
        /// <param name="input">Instance of Container to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Container input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContainerType == input.ContainerType ||
                    (this.ContainerType != null &&
                    this.ContainerType.Equals(input.ContainerType))
                ) && 
                (
                    this.ContainerReferenceId == input.ContainerReferenceId ||
                    (this.ContainerReferenceId != null &&
                    this.ContainerReferenceId.Equals(input.ContainerReferenceId))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Dimensions == input.Dimensions ||
                    (this.Dimensions != null &&
                    this.Dimensions.Equals(input.Dimensions))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.ContainerType != null)
                    hashCode = hashCode * 59 + this.ContainerType.GetHashCode();
                if (this.ContainerReferenceId != null)
                    hashCode = hashCode * 59 + this.ContainerReferenceId.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
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