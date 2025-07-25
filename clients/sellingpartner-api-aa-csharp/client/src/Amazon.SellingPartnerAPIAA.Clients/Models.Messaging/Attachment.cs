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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Messaging
{
    /// <summary>
    /// Represents a file that was uploaded to a destination that was created by the Uploads API [&#x60;createUploadDestinationForResource&#x60;](https://developer-docs.amazon.com/sp-api/docs/uploads-api-reference#post-uploads2020-11-01uploaddestinationsresource) operation.
    /// </summary>
    [DataContract]
    public partial class Attachment : IEquatable<Attachment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        [JsonConstructor]
        protected Attachment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        /// <param name="uploadDestinationId">The identifier for the upload destination. To retrieve this value, call the Uploads API [&#x60;createUploadDestinationForResource&#x60;](https://developer-docs.amazon.com/sp-api/docs/uploads-api-reference#post-uploads2020-11-01uploaddestinationsresource) operation. (required).</param>
        /// <param name="fileName">The name of the file, including the extension. This is the file name that will appear in the message. This does not need to match the file name of the file that you uploaded. (required).</param>
        public Attachment(string uploadDestinationId = default, string fileName = default)
        {
            // to ensure "uploadDestinationId" is required (not null)
            if (uploadDestinationId == null)
            {
                throw new InvalidDataException("uploadDestinationId is a required property for Attachment and cannot be null");
            }
            else
            {
                this.UploadDestinationId = uploadDestinationId;
            }
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new InvalidDataException("fileName is a required property for Attachment and cannot be null");
            }
            else
            {
                this.FileName = fileName;
            }
        }

        /// <summary>
        /// The identifier for the upload destination. To retrieve this value, call the Uploads API [&#x60;createUploadDestinationForResource&#x60;](https://developer-docs.amazon.com/sp-api/docs/uploads-api-reference#post-uploads2020-11-01uploaddestinationsresource) operation.
        /// </summary>
        /// <value>The identifier for the upload destination. To retrieve this value, call the Uploads API [&#x60;createUploadDestinationForResource&#x60;](https://developer-docs.amazon.com/sp-api/docs/uploads-api-reference#post-uploads2020-11-01uploaddestinationsresource) operation.</value>
        [DataMember(Name = "uploadDestinationId", EmitDefaultValue = false)]
        public string UploadDestinationId { get; set; }

        /// <summary>
        /// The name of the file, including the extension. This is the file name that will appear in the message. This does not need to match the file name of the file that you uploaded.
        /// </summary>
        /// <value>The name of the file, including the extension. This is the file name that will appear in the message. This does not need to match the file name of the file that you uploaded.</value>
        [DataMember(Name = "fileName", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attachment {\n");
            sb.Append("  UploadDestinationId: ").Append(UploadDestinationId).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
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
            return this.Equals(input as Attachment);
        }

        /// <summary>
        /// Returns true if Attachment instances are equal
        /// </summary>
        /// <param name="input">Instance of Attachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attachment input)
        {
            if (input == null)
                return false;

            return
                (
                    this.UploadDestinationId == input.UploadDestinationId ||
                    (this.UploadDestinationId != null &&
                    this.UploadDestinationId.Equals(input.UploadDestinationId))
                ) &&
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
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
                if (this.UploadDestinationId != null)
                    hashCode = hashCode * 59 + this.UploadDestinationId.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
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
