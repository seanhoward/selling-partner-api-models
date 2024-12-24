/* 
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: 2020-07-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// The result for the createFulfillmentReturn operation.
    /// </summary>
    [DataContract]
    public partial class CreateFulfillmentReturnResult :  IEquatable<CreateFulfillmentReturnResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFulfillmentReturnResult" /> class.
        /// </summary>
        /// <param name="returnItems">returnItems.</param>
        /// <param name="invalidReturnItems">invalidReturnItems.</param>
        /// <param name="returnAuthorizations">returnAuthorizations.</param>
        public CreateFulfillmentReturnResult(ReturnItemList returnItems = default(ReturnItemList), InvalidReturnItemList invalidReturnItems = default(InvalidReturnItemList), ReturnAuthorizationList returnAuthorizations = default(ReturnAuthorizationList))
        {
            this.ReturnItems = returnItems;
            this.InvalidReturnItems = invalidReturnItems;
            this.ReturnAuthorizations = returnAuthorizations;
        }
        
        /// <summary>
        /// Gets or Sets ReturnItems
        /// </summary>
        [DataMember(Name="returnItems", EmitDefaultValue=false)]
        public ReturnItemList ReturnItems { get; set; }

        /// <summary>
        /// Gets or Sets InvalidReturnItems
        /// </summary>
        [DataMember(Name="invalidReturnItems", EmitDefaultValue=false)]
        public InvalidReturnItemList InvalidReturnItems { get; set; }

        /// <summary>
        /// Gets or Sets ReturnAuthorizations
        /// </summary>
        [DataMember(Name="returnAuthorizations", EmitDefaultValue=false)]
        public ReturnAuthorizationList ReturnAuthorizations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFulfillmentReturnResult {\n");
            sb.Append("  ReturnItems: ").Append(ReturnItems).Append("\n");
            sb.Append("  InvalidReturnItems: ").Append(InvalidReturnItems).Append("\n");
            sb.Append("  ReturnAuthorizations: ").Append(ReturnAuthorizations).Append("\n");
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
            return this.Equals(input as CreateFulfillmentReturnResult);
        }

        /// <summary>
        /// Returns true if CreateFulfillmentReturnResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFulfillmentReturnResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFulfillmentReturnResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReturnItems == input.ReturnItems ||
                    (this.ReturnItems != null &&
                    this.ReturnItems.Equals(input.ReturnItems))
                ) && 
                (
                    this.InvalidReturnItems == input.InvalidReturnItems ||
                    (this.InvalidReturnItems != null &&
                    this.InvalidReturnItems.Equals(input.InvalidReturnItems))
                ) && 
                (
                    this.ReturnAuthorizations == input.ReturnAuthorizations ||
                    (this.ReturnAuthorizations != null &&
                    this.ReturnAuthorizations.Equals(input.ReturnAuthorizations))
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
                if (this.ReturnItems != null)
                    hashCode = hashCode * 59 + this.ReturnItems.GetHashCode();
                if (this.InvalidReturnItems != null)
                    hashCode = hashCode * 59 + this.InvalidReturnItems.GetHashCode();
                if (this.ReturnAuthorizations != null)
                    hashCode = hashCode * 59 + this.ReturnAuthorizations.GetHashCode();
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
