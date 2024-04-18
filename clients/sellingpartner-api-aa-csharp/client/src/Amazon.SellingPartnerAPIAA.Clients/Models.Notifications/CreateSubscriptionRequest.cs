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
    /// The request schema for the &#x60;createSubscription&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class CreateSubscriptionRequest :  IEquatable<CreateSubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSubscriptionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="payloadVersion">The version of the payload object to be used in the notification. (required).</param>
        /// <param name="destinationId">The identifier for the destination where notifications will be delivered. (required).</param>
        /// <param name="processingDirective">processingDirective.</param>
        public CreateSubscriptionRequest(string payloadVersion = default(string), string destinationId = default(string), ProcessingDirective processingDirective = default(ProcessingDirective))
        {
            // to ensure "payloadVersion" is required (not null)
            if (payloadVersion == null)
            {
                throw new InvalidDataException("payloadVersion is a required property for CreateSubscriptionRequest and cannot be null");
            }
            else
            {
                this.PayloadVersion = payloadVersion;
            }
            // to ensure "destinationId" is required (not null)
            if (destinationId == null)
            {
                throw new InvalidDataException("destinationId is a required property for CreateSubscriptionRequest and cannot be null");
            }
            else
            {
                this.DestinationId = destinationId;
            }
            this.ProcessingDirective = processingDirective;
        }
        
        /// <summary>
        /// The version of the payload object to be used in the notification.
        /// </summary>
        /// <value>The version of the payload object to be used in the notification.</value>
        [DataMember(Name="payloadVersion", EmitDefaultValue=false)]
        public string PayloadVersion { get; set; }

        /// <summary>
        /// The identifier for the destination where notifications will be delivered.
        /// </summary>
        /// <value>The identifier for the destination where notifications will be delivered.</value>
        [DataMember(Name="destinationId", EmitDefaultValue=false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingDirective
        /// </summary>
        [DataMember(Name="processingDirective", EmitDefaultValue=false)]
        public ProcessingDirective ProcessingDirective { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionRequest {\n");
            sb.Append("  PayloadVersion: ").Append(PayloadVersion).Append("\n");
            sb.Append("  DestinationId: ").Append(DestinationId).Append("\n");
            sb.Append("  ProcessingDirective: ").Append(ProcessingDirective).Append("\n");
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
            return this.Equals(input as CreateSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayloadVersion == input.PayloadVersion ||
                    (this.PayloadVersion != null &&
                    this.PayloadVersion.Equals(input.PayloadVersion))
                ) && 
                (
                    this.DestinationId == input.DestinationId ||
                    (this.DestinationId != null &&
                    this.DestinationId.Equals(input.DestinationId))
                ) && 
                (
                    this.ProcessingDirective == input.ProcessingDirective ||
                    (this.ProcessingDirective != null &&
                    this.ProcessingDirective.Equals(input.ProcessingDirective))
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
                if (this.PayloadVersion != null)
                    hashCode = hashCode * 59 + this.PayloadVersion.GetHashCode();
                if (this.DestinationId != null)
                    hashCode = hashCode * 59 + this.DestinationId.GetHashCode();
                if (this.ProcessingDirective != null)
                    hashCode = hashCode * 59 + this.ProcessingDirective.GetHashCode();
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
