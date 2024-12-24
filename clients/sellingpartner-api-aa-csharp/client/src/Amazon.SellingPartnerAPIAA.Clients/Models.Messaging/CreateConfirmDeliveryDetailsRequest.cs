/* 
 * Selling Partner API for Messaging
 *
 * With the Messaging API you can build applications that send messages to buyers. You can get a list of message types that are available for an order that you specify, then call an operation that sends a message to the buyer for that order. The Messaging API returns responses that are formed according to the <a href=https://tools.ietf.org/html/draft-kelly-json-hal-08>JSON Hypertext Application Language</a> (HAL) standard.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Messaging
{
    /// <summary>
    /// The request schema for the createConfirmDeliveryDetails operation.
    /// </summary>
    [DataContract]
    public partial class CreateConfirmDeliveryDetailsRequest :  IEquatable<CreateConfirmDeliveryDetailsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConfirmDeliveryDetailsRequest" /> class.
        /// </summary>
        /// <param name="text">The text to be sent to the buyer. Only links related to order delivery are allowed. Do not include HTML or email addresses. The text must be written in the buyer&#39;s language of preference, which can be retrieved from the GetAttributes operation..</param>
        public CreateConfirmDeliveryDetailsRequest(string text = default(string))
        {
            this.Text = text;
        }
        
        /// <summary>
        /// The text to be sent to the buyer. Only links related to order delivery are allowed. Do not include HTML or email addresses. The text must be written in the buyer&#39;s language of preference, which can be retrieved from the GetAttributes operation.
        /// </summary>
        /// <value>The text to be sent to the buyer. Only links related to order delivery are allowed. Do not include HTML or email addresses. The text must be written in the buyer&#39;s language of preference, which can be retrieved from the GetAttributes operation.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateConfirmDeliveryDetailsRequest {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as CreateConfirmDeliveryDetailsRequest);
        }

        /// <summary>
        /// Returns true if CreateConfirmDeliveryDetailsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateConfirmDeliveryDetailsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateConfirmDeliveryDetailsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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
            // Text (string) maxLength
            if(this.Text != null && this.Text.Length > 2000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, length must be less than 2000.", new [] { "Text" });
            }

            // Text (string) minLength
            if(this.Text != null && this.Text.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, length must be greater than 1.", new [] { "Text" });
            }

            yield break;
        }
    }

}
