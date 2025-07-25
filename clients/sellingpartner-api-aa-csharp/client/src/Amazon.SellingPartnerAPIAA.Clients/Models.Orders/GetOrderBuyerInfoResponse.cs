/* 
 * Selling Partner API for Orders
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Orders
{
    /// <summary>
    /// The response schema for the &#x60;getOrderBuyerInfo&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class GetOrderBuyerInfoResponse : IEquatable<GetOrderBuyerInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderBuyerInfoResponse" /> class.
        /// </summary>
        /// <param name="payload">The payload for the &#x60;getOrderBuyerInfo&#x60; operation..</param>
        /// <param name="errors">One or more unexpected errors occurred during the &#x60;getOrderBuyerInfo&#x60; operation..</param>
        public GetOrderBuyerInfoResponse(OrderBuyerInfo payload = default, ErrorList errors = default)
        {
            this.Payload = payload;
            this.Errors = errors;
        }

        /// <summary>
        /// The payload for the &#x60;getOrderBuyerInfo&#x60; operation.
        /// </summary>
        /// <value>The payload for the &#x60;getOrderBuyerInfo&#x60; operation.</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public OrderBuyerInfo Payload { get; set; }

        /// <summary>
        /// One or more unexpected errors occurred during the &#x60;getOrderBuyerInfo&#x60; operation.
        /// </summary>
        /// <value>One or more unexpected errors occurred during the &#x60;getOrderBuyerInfo&#x60; operation.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOrderBuyerInfoResponse {\n");
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
            return this.Equals(input as GetOrderBuyerInfoResponse);
        }

        /// <summary>
        /// Returns true if GetOrderBuyerInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetOrderBuyerInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOrderBuyerInfoResponse input)
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
