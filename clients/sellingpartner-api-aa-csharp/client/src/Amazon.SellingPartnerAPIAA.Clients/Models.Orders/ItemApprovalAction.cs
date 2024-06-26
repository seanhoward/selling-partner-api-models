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
using SwaggerDateConverter = Amazon.SellingPartnerAPIAA.Clients.Client.SwaggerDateConverter;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Orders
{
    /// <summary>
    /// This object represents an approval action used by the actors in the order item approval process. Check the applicable restrictions at the specific approval type schemas.
    /// </summary>
    [DataContract]
    public partial class ItemApprovalAction :  IEquatable<ItemApprovalAction>, IValidatableObject
    {
        /// <summary>
        /// Defines the type of action for the approval.
        /// </summary>
        /// <value>Defines the type of action for the approval.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionTypeEnum
        {
            
            /// <summary>
            /// Enum APPROVE for value: APPROVE
            /// </summary>
            [EnumMember(Value = "APPROVE")]
            APPROVE = 1,
            
            /// <summary>
            /// Enum DECLINE for value: DECLINE
            /// </summary>
            [EnumMember(Value = "DECLINE")]
            DECLINE = 2,
            
            /// <summary>
            /// Enum APPROVEWITHCHANGES for value: APPROVE_WITH_CHANGES
            /// </summary>
            [EnumMember(Value = "APPROVE_WITH_CHANGES")]
            APPROVEWITHCHANGES = 3
        }

        /// <summary>
        /// Defines the type of action for the approval.
        /// </summary>
        /// <value>Defines the type of action for the approval.</value>
        [DataMember(Name="ActionType", EmitDefaultValue=false)]
        public ActionTypeEnum ActionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemApprovalAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemApprovalAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemApprovalAction" /> class.
        /// </summary>
        /// <param name="actionType">Defines the type of action for the approval. (required).</param>
        /// <param name="comment">Comment message to provide optional additional context on the approval action..</param>
        /// <param name="changes">changes.</param>
        public ItemApprovalAction(ActionTypeEnum actionType = default(ActionTypeEnum), string comment = default(string), ItemApprovalActionChanges changes = default(ItemApprovalActionChanges))
        {
            // to ensure "actionType" is required (not null)
            if (actionType == null)
            {
                throw new InvalidDataException("actionType is a required property for ItemApprovalAction and cannot be null");
            }
            else
            {
                this.ActionType = actionType;
            }
            this.Comment = comment;
            this.Changes = changes;
        }
        

        /// <summary>
        /// Comment message to provide optional additional context on the approval action.
        /// </summary>
        /// <value>Comment message to provide optional additional context on the approval action.</value>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Changes
        /// </summary>
        [DataMember(Name="Changes", EmitDefaultValue=false)]
        public ItemApprovalActionChanges Changes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemApprovalAction {\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
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
            return this.Equals(input as ItemApprovalAction);
        }

        /// <summary>
        /// Returns true if ItemApprovalAction instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemApprovalAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemApprovalAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionType == input.ActionType ||
                    (this.ActionType != null &&
                    this.ActionType.Equals(input.ActionType))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Changes == input.Changes ||
                    (this.Changes != null &&
                    this.Changes.Equals(input.Changes))
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
                if (this.ActionType != null)
                    hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Changes != null)
                    hashCode = hashCode * 59 + this.Changes.GetHashCode();
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
