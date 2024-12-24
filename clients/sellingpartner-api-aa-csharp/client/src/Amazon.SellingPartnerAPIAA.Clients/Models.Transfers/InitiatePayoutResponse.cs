/* 
 * The Selling Partner API for Transfers.
 *
 * The Selling Partner API for Transfers enables selling partners to retrieve payment methods and initiate payouts for their seller accounts. This API supports the following marketplaces: DE, FR, IT, ES, SE, NL, PL, and BE.
 *
 * OpenAPI spec version: 2024-06-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Transfers
{
    /// <summary>
    /// The response schema for the &#x60;initiatePayout&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class InitiatePayoutResponse :  IEquatable<InitiatePayoutResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiatePayoutResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InitiatePayoutResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiatePayoutResponse" /> class.
        /// </summary>
        /// <param name="payoutReferenceId">The financial event group ID for a successfully initiated payout. You can use this ID to track payout information. (required).</param>
        public InitiatePayoutResponse(string payoutReferenceId = default(string))
        {
            // to ensure "payoutReferenceId" is required (not null)
            if (payoutReferenceId == null)
            {
                throw new InvalidDataException("payoutReferenceId is a required property for InitiatePayoutResponse and cannot be null");
            }
            else
            {
                this.PayoutReferenceId = payoutReferenceId;
            }
        }
        
        /// <summary>
        /// The financial event group ID for a successfully initiated payout. You can use this ID to track payout information.
        /// </summary>
        /// <value>The financial event group ID for a successfully initiated payout. You can use this ID to track payout information.</value>
        [DataMember(Name="payoutReferenceId", EmitDefaultValue=false)]
        public string PayoutReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitiatePayoutResponse {\n");
            sb.Append("  PayoutReferenceId: ").Append(PayoutReferenceId).Append("\n");
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
            return this.Equals(input as InitiatePayoutResponse);
        }

        /// <summary>
        /// Returns true if InitiatePayoutResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InitiatePayoutResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiatePayoutResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayoutReferenceId == input.PayoutReferenceId ||
                    (this.PayoutReferenceId != null &&
                    this.PayoutReferenceId.Equals(input.PayoutReferenceId))
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
                if (this.PayoutReferenceId != null)
                    hashCode = hashCode * 59 + this.PayoutReferenceId.GetHashCode();
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