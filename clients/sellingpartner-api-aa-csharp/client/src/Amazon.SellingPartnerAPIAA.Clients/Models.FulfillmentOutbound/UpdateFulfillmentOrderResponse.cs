/* 
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: 2020-07-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// The response schema for the &#x60;updateFulfillmentOrder&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class UpdateFulfillmentOrderResponse :  IEquatable<UpdateFulfillmentOrderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFulfillmentOrderResponse" /> class.
        /// </summary>
        /// <param name="errors">One or more unexpected errors occurred during the &#x60;updateFulfillmentOrder&#x60; operation..</param>
        public UpdateFulfillmentOrderResponse(ErrorList errors = default(ErrorList))
        {
            this.Errors = errors;
        }
        
        /// <summary>
        /// One or more unexpected errors occurred during the &#x60;updateFulfillmentOrder&#x60; operation.
        /// </summary>
        /// <value>One or more unexpected errors occurred during the &#x60;updateFulfillmentOrder&#x60; operation.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFulfillmentOrderResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as UpdateFulfillmentOrderResponse);
        }

        /// <summary>
        /// Returns true if UpdateFulfillmentOrderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateFulfillmentOrderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateFulfillmentOrderResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    (this.Errors != null &&
                    this.Errors.Equals(input.Errors))
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
