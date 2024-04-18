/* 
 * Selling Partner API for Notifications
 *
 * The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.  For more information, refer to the [Notifications Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/notifications-api-v1-use-case-guide).
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Notifications
{
    /// <summary>
    /// The response schema for the &#x60;getSubscription&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class GetSubscriptionResponse :  IEquatable<GetSubscriptionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="payload">The payload for the &#x60;getSubscription&#x60; operation..</param>
        /// <param name="errors">One or more unexpected errors occurred during the &#x60;getSubscription&#x60; operation..</param>
        public GetSubscriptionResponse(Subscription payload = default(Subscription), ErrorList errors = default(ErrorList))
        {
            this.Payload = payload;
            this.Errors = errors;
        }
        
        /// <summary>
        /// The payload for the &#x60;getSubscription&#x60; operation.
        /// </summary>
        /// <value>The payload for the &#x60;getSubscription&#x60; operation.</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public Subscription Payload { get; set; }

        /// <summary>
        /// One or more unexpected errors occurred during the &#x60;getSubscription&#x60; operation.
        /// </summary>
        /// <value>One or more unexpected errors occurred during the &#x60;getSubscription&#x60; operation.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSubscriptionResponse {\n");
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
            return this.Equals(input as GetSubscriptionResponse);
        }

        /// <summary>
        /// Returns true if GetSubscriptionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSubscriptionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSubscriptionResponse input)
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
