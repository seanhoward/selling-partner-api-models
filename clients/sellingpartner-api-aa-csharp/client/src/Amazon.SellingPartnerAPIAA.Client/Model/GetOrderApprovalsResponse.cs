/* 
 * Selling Partner API for Orders
 *
 * The Selling Partner API for Orders helps you programmatically retrieve order information. These APIs let you develop fast, flexible, custom applications in areas like order synchronization, order research, and demand-based decision support tools.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Amazon.SellingPartnerAPIAA.Client.Model
{
    /// <summary>
    /// The response schema for the getOrderApprovalsItems operation.
    /// </summary>
    [DataContract]
    public partial class GetOrderApprovalsResponse : IEquatable<GetOrderApprovalsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderApprovalsResponse" /> class.
        /// </summary>
        /// <param name="payload">The payload for the getOrderItemsApprovals operation..</param>
        /// <param name="errors">One or more unexpected errors occurred during the getOrderItemsApprovals operation..</param>
        public GetOrderApprovalsResponse(OrderApprovalsResponse payload = default(OrderApprovalsResponse), ErrorList errors = default(ErrorList))
        {
            this.Payload = payload;
            this.Errors = errors;
        }

        /// <summary>
        /// The payload for the getOrderItemsApprovals operation.
        /// </summary>
        /// <value>The payload for the getOrderItemsApprovals operation.</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public OrderApprovalsResponse Payload { get; set; }

        /// <summary>
        /// One or more unexpected errors occurred during the getOrderItemsApprovals operation.
        /// </summary>
        /// <value>One or more unexpected errors occurred during the getOrderItemsApprovals operation.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOrderApprovalsResponse {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            return this.Equals(input as GetOrderApprovalsResponse);
        }

        /// <summary>
        /// Returns true if GetOrderApprovalsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetOrderApprovalsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOrderApprovalsResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) &&
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
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
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
