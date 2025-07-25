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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Messaging
{
    /// <summary>
    /// The request schema for the createAmazonMotors operation.
    /// </summary>
    [DataContract]
    public partial class CreateAmazonMotorsRequest : IEquatable<CreateAmazonMotorsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAmazonMotorsRequest" /> class.
        /// </summary>
        /// <param name="attachments">Attachments to include in the message to the buyer. If any text is included in the attachment, the text must be written in the buyer&#39;s language of preference, which can be retrieved from the GetAttributes operation..</param>
        public CreateAmazonMotorsRequest(List<Attachment> attachments = default)
        {
            this.Attachments = attachments;
        }

        /// <summary>
        /// Attachments to include in the message to the buyer. If any text is included in the attachment, the text must be written in the buyer&#39;s language of preference, which can be retrieved from the GetAttributes operation.
        /// </summary>
        /// <value>Attachments to include in the message to the buyer. If any text is included in the attachment, the text must be written in the buyer&#39;s language of preference, which can be retrieved from the GetAttributes operation.</value>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAmazonMotorsRequest {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as CreateAmazonMotorsRequest);
        }

        /// <summary>
        /// Returns true if CreateAmazonMotorsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAmazonMotorsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAmazonMotorsRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
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
