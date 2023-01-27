/* 
 * Selling Partner API for Orders
 *
 * The Selling Partner API for Orders helps you programmatically retrieve order information. These APIs let you develop fast, flexible, custom applications in areas like order synchronization, order research, and demand-based decision support tools.
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Generic item approval context. Check the applicable restrictions at the specific approval type schemas.
    /// </summary>
    [DataContract]
    public partial class ItemApprovalContext :  IEquatable<ItemApprovalContext>, IValidatableObject
    {
        /// <summary>
        /// The approval process type required for the order item.
        /// </summary>
        /// <value>The approval process type required for the order item.</value>
        [DataMember(Name="ApprovalType", EmitDefaultValue=false)]
        public ItemApprovalType ApprovalType { get; set; }
        /// <summary>
        /// Current status of the order item approval.
        /// </summary>
        /// <value>Current status of the order item approval.</value>
        [DataMember(Name="ApprovalStatus", EmitDefaultValue=false)]
        public ItemApprovalStatus ApprovalStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemApprovalContext" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemApprovalContext() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemApprovalContext" /> class.
        /// </summary>
        /// <param name="approvalType">The approval process type required for the order item. (required).</param>
        /// <param name="approvalStatus">Current status of the order item approval. (required).</param>
        /// <param name="approvalSupportData">List of additional data elements supporting the approval process. Check the applicable restrictions at the specific approval type schemas..</param>
        public ItemApprovalContext(ItemApprovalType approvalType = default(ItemApprovalType), ItemApprovalStatus approvalStatus = default(ItemApprovalStatus), ApprovalSupportDataElementList approvalSupportData = default(ApprovalSupportDataElementList))
        {
            // to ensure "approvalType" is required (not null)
            if (approvalType == null)
            {
                throw new InvalidDataException("approvalType is a required property for ItemApprovalContext and cannot be null");
            }
            else
            {
                this.ApprovalType = approvalType;
            }
            // to ensure "approvalStatus" is required (not null)
            if (approvalStatus == null)
            {
                throw new InvalidDataException("approvalStatus is a required property for ItemApprovalContext and cannot be null");
            }
            else
            {
                this.ApprovalStatus = approvalStatus;
            }
            this.ApprovalSupportData = approvalSupportData;
        }
        


        /// <summary>
        /// List of additional data elements supporting the approval process. Check the applicable restrictions at the specific approval type schemas.
        /// </summary>
        /// <value>List of additional data elements supporting the approval process. Check the applicable restrictions at the specific approval type schemas.</value>
        [DataMember(Name="ApprovalSupportData", EmitDefaultValue=false)]
        public ApprovalSupportDataElementList ApprovalSupportData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemApprovalContext {\n");
            sb.Append("  ApprovalType: ").Append(ApprovalType).Append("\n");
            sb.Append("  ApprovalStatus: ").Append(ApprovalStatus).Append("\n");
            sb.Append("  ApprovalSupportData: ").Append(ApprovalSupportData).Append("\n");
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
            return this.Equals(input as ItemApprovalContext);
        }

        /// <summary>
        /// Returns true if ItemApprovalContext instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemApprovalContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemApprovalContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApprovalType == input.ApprovalType ||
                    (this.ApprovalType != null &&
                    this.ApprovalType.Equals(input.ApprovalType))
                ) && 
                (
                    this.ApprovalStatus == input.ApprovalStatus ||
                    (this.ApprovalStatus != null &&
                    this.ApprovalStatus.Equals(input.ApprovalStatus))
                ) && 
                (
                    this.ApprovalSupportData == input.ApprovalSupportData ||
                    (this.ApprovalSupportData != null &&
                    this.ApprovalSupportData.Equals(input.ApprovalSupportData))
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
                if (this.ApprovalType != null)
                    hashCode = hashCode * 59 + this.ApprovalType.GetHashCode();
                if (this.ApprovalStatus != null)
                    hashCode = hashCode * 59 + this.ApprovalStatus.GetHashCode();
                if (this.ApprovalSupportData != null)
                    hashCode = hashCode * 59 + this.ApprovalSupportData.GetHashCode();
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
