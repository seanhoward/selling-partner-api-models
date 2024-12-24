/* 
 * The Selling Partner API for third party application integrations.
 *
 * With the AppIntegrations API v2024-04-01, you can send notifications to Amazon Selling Partners and display the notifications in Seller Central.
 *
 * OpenAPI spec version: 2024-04-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.AppIntegrations
{
    /// <summary>
    /// The request for the &#x60;deleteNotifications&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class DeleteNotificationsRequest :  IEquatable<DeleteNotificationsRequest>, IValidatableObject
    {
        /// <summary>
        /// The unique identifier that maps each notification status to a reason code.
        /// </summary>
        /// <value>The unique identifier that maps each notification status to a reason code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeletionReasonEnum
        {
            
            /// <summary>
            /// Enum CONTENT for value: INCORRECT_CONTENT
            /// </summary>
            [EnumMember(Value = "INCORRECT_CONTENT")]
            CONTENT = 1,
            
            /// <summary>
            /// Enum RECIPIENT for value: INCORRECT_RECIPIENT
            /// </summary>
            [EnumMember(Value = "INCORRECT_RECIPIENT")]
            RECIPIENT = 2
        }

        /// <summary>
        /// The unique identifier that maps each notification status to a reason code.
        /// </summary>
        /// <value>The unique identifier that maps each notification status to a reason code.</value>
        [DataMember(Name="deletionReason", EmitDefaultValue=false)]
        public DeletionReasonEnum DeletionReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteNotificationsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteNotificationsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteNotificationsRequest" /> class.
        /// </summary>
        /// <param name="templateId">The unique identifier of the notification template you used to onboard your application. (required).</param>
        /// <param name="deletionReason">The unique identifier that maps each notification status to a reason code. (required).</param>
        public DeleteNotificationsRequest(string templateId = default(string), DeletionReasonEnum deletionReason = default(DeletionReasonEnum))
        {
            // to ensure "templateId" is required (not null)
            if (templateId == null)
            {
                throw new InvalidDataException("templateId is a required property for DeleteNotificationsRequest and cannot be null");
            }
            else
            {
                this.TemplateId = templateId;
            }
            // to ensure "deletionReason" is required (not null)
            if (deletionReason == null)
            {
                throw new InvalidDataException("deletionReason is a required property for DeleteNotificationsRequest and cannot be null");
            }
            else
            {
                this.DeletionReason = deletionReason;
            }
        }
        
        /// <summary>
        /// The unique identifier of the notification template you used to onboard your application.
        /// </summary>
        /// <value>The unique identifier of the notification template you used to onboard your application.</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteNotificationsRequest {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  DeletionReason: ").Append(DeletionReason).Append("\n");
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
            return this.Equals(input as DeleteNotificationsRequest);
        }

        /// <summary>
        /// Returns true if DeleteNotificationsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteNotificationsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteNotificationsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.DeletionReason == input.DeletionReason ||
                    (this.DeletionReason != null &&
                    this.DeletionReason.Equals(input.DeletionReason))
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
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.DeletionReason != null)
                    hashCode = hashCode * 59 + this.DeletionReason.GetHashCode();
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
