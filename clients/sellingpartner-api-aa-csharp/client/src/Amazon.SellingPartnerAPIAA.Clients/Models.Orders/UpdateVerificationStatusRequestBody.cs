/* 
 * Selling Partner API for Orders
 *
 * The Selling Partner API for Orders helps you programmatically retrieve order information. These APIs let you develop fast, flexible, custom applications in areas like order synchronization, order research, and demand-based decision support tools. The Orders API supports orders that are two years old or less. Orders more than two years old will not show in the API response.  _Note:_ The Orders API supports orders from 2016 and after for the JP, AU, and SG marketplaces.
 *
 * OpenAPI spec version: v0
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Orders
{
    /// <summary>
    /// The updated values of the VerificationStatus field.
    /// </summary>
    [DataContract]
    public partial class UpdateVerificationStatusRequestBody :  IEquatable<UpdateVerificationStatusRequestBody>, IValidatableObject
    {
        /// <summary>
        /// The new verification status of the order.
        /// </summary>
        /// <value>The new verification status of the order.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public VerificationStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVerificationStatusRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateVerificationStatusRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVerificationStatusRequestBody" /> class.
        /// </summary>
        /// <param name="status">The new verification status of the order. (required).</param>
        /// <param name="externalReviewerId">The identifier for the order&#39;s regulated information reviewer. (required).</param>
        /// <param name="rejectionReasonId">The unique identifier for the rejection reason used for rejecting the order&#39;s regulated information. Only required if the new status is rejected..</param>
        public UpdateVerificationStatusRequestBody(VerificationStatus status = default(VerificationStatus), string externalReviewerId = default(string), string rejectionReasonId = default(string))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for UpdateVerificationStatusRequestBody and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "externalReviewerId" is required (not null)
            if (externalReviewerId == null)
            {
                throw new InvalidDataException("externalReviewerId is a required property for UpdateVerificationStatusRequestBody and cannot be null");
            }
            else
            {
                this.ExternalReviewerId = externalReviewerId;
            }
            this.RejectionReasonId = rejectionReasonId;
        }
        

        /// <summary>
        /// The identifier for the order&#39;s regulated information reviewer.
        /// </summary>
        /// <value>The identifier for the order&#39;s regulated information reviewer.</value>
        [DataMember(Name="externalReviewerId", EmitDefaultValue=false)]
        public string ExternalReviewerId { get; set; }

        /// <summary>
        /// The unique identifier for the rejection reason used for rejecting the order&#39;s regulated information. Only required if the new status is rejected.
        /// </summary>
        /// <value>The unique identifier for the rejection reason used for rejecting the order&#39;s regulated information. Only required if the new status is rejected.</value>
        [DataMember(Name="rejectionReasonId", EmitDefaultValue=false)]
        public string RejectionReasonId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateVerificationStatusRequestBody {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExternalReviewerId: ").Append(ExternalReviewerId).Append("\n");
            sb.Append("  RejectionReasonId: ").Append(RejectionReasonId).Append("\n");
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
            return this.Equals(input as UpdateVerificationStatusRequestBody);
        }

        /// <summary>
        /// Returns true if UpdateVerificationStatusRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateVerificationStatusRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateVerificationStatusRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ExternalReviewerId == input.ExternalReviewerId ||
                    (this.ExternalReviewerId != null &&
                    this.ExternalReviewerId.Equals(input.ExternalReviewerId))
                ) && 
                (
                    this.RejectionReasonId == input.RejectionReasonId ||
                    (this.RejectionReasonId != null &&
                    this.RejectionReasonId.Equals(input.RejectionReasonId))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExternalReviewerId != null)
                    hashCode = hashCode * 59 + this.ExternalReviewerId.GetHashCode();
                if (this.RejectionReasonId != null)
                    hashCode = hashCode * 59 + this.RejectionReasonId.GetHashCode();
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
