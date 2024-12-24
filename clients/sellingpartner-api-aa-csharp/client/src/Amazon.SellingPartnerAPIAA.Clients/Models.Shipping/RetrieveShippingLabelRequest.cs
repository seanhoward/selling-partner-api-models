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
    /// The request schema for the retrieveShippingLabel operation.
    /// </summary>
    [DataContract]
    public partial class RetrieveShippingLabelRequest :  IEquatable<RetrieveShippingLabelRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveShippingLabelRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RetrieveShippingLabelRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveShippingLabelRequest" /> class.
        /// </summary>
        /// <param name="labelSpecification">labelSpecification (required).</param>
        public RetrieveShippingLabelRequest(LabelSpecification labelSpecification = default(LabelSpecification))
        {
            // to ensure "labelSpecification" is required (not null)
            if (labelSpecification == null)
            {
                throw new InvalidDataException("labelSpecification is a required property for RetrieveShippingLabelRequest and cannot be null");
            }
            else
            {
                this.LabelSpecification = labelSpecification;
            }
        }
        
        /// <summary>
        /// Gets or Sets LabelSpecification
        /// </summary>
        [DataMember(Name="labelSpecification", EmitDefaultValue=false)]
        public LabelSpecification LabelSpecification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveShippingLabelRequest {\n");
            sb.Append("  LabelSpecification: ").Append(LabelSpecification).Append("\n");
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
            return this.Equals(input as RetrieveShippingLabelRequest);
        }

        /// <summary>
        /// Returns true if RetrieveShippingLabelRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveShippingLabelRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveShippingLabelRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LabelSpecification == input.LabelSpecification ||
                    (this.LabelSpecification != null &&
                    this.LabelSpecification.Equals(input.LabelSpecification))
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
                if (this.LabelSpecification != null)
                    hashCode = hashCode * 59 + this.LabelSpecification.GetHashCode();
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