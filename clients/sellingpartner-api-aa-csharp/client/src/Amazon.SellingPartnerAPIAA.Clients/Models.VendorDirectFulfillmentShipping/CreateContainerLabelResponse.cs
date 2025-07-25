/* 
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * Use the Selling Partner API for Direct Fulfillment Shipping to access a direct fulfillment vendor's shipping data.
 *
 * OpenAPI spec version: 2021-12-28
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping
{
    /// <summary>
    /// The response schema for the &#x60;createContainerLabel&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class CreateContainerLabelResponse : IEquatable<CreateContainerLabelResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerLabelResponse" /> class.
        /// </summary>
        [JsonConstructor]
        protected CreateContainerLabelResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerLabelResponse" /> class.
        /// </summary>
        /// <param name="containerLabel">The label data for the container label. (required).</param>
        public CreateContainerLabelResponse(ContainerLabel containerLabel = default)
        {
            // to ensure "containerLabel" is required (not null)
            if (containerLabel == null)
            {
                throw new InvalidDataException("containerLabel is a required property for CreateContainerLabelResponse and cannot be null");
            }
            else
            {
                this.ContainerLabel = containerLabel;
            }
        }

        /// <summary>
        /// The label data for the container label.
        /// </summary>
        /// <value>The label data for the container label.</value>
        [DataMember(Name = "containerLabel", EmitDefaultValue = false)]
        public ContainerLabel ContainerLabel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateContainerLabelResponse {\n");
            sb.Append("  ContainerLabel: ").Append(ContainerLabel).Append("\n");
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
            return this.Equals(input as CreateContainerLabelResponse);
        }

        /// <summary>
        /// Returns true if CreateContainerLabelResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateContainerLabelResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateContainerLabelResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ContainerLabel == input.ContainerLabel ||
                    (this.ContainerLabel != null &&
                    this.ContainerLabel.Equals(input.ContainerLabel))
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
                if (this.ContainerLabel != null)
                    hashCode = hashCode * 59 + this.ContainerLabel.GetHashCode();
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
