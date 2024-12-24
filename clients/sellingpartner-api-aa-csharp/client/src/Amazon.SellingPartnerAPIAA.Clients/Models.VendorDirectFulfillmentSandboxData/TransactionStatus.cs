/* 
 * Selling Partner API for Vendor Direct Fulfillment Sandbox Test Data
 *
 * The Selling Partner API for Vendor Direct Fulfillment Sandbox Test Data provides programmatic access to vendor direct fulfillment sandbox test data.
 *
 * OpenAPI spec version: 2021-10-28
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentSandboxData
{
    /// <summary>
    /// The payload for the getOrderScenarios operation.
    /// </summary>
    [DataContract]
    public partial class TransactionStatus :  IEquatable<TransactionStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatus" /> class.
        /// </summary>
        /// <param name="transactionStatus">transactionStatus.</param>
        public TransactionStatus(Transaction transactionStatus = default(Transaction))
        {
            this._TransactionStatus = transactionStatus;
        }
        
        /// <summary>
        /// Gets or Sets _TransactionStatus
        /// </summary>
        [DataMember(Name="transactionStatus", EmitDefaultValue=false)]
        public Transaction _TransactionStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionStatus {\n");
            sb.Append("  _TransactionStatus: ").Append(_TransactionStatus).Append("\n");
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
            return this.Equals(input as TransactionStatus);
        }

        /// <summary>
        /// Returns true if TransactionStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._TransactionStatus == input._TransactionStatus ||
                    (this._TransactionStatus != null &&
                    this._TransactionStatus.Equals(input._TransactionStatus))
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
                if (this._TransactionStatus != null)
                    hashCode = hashCode * 59 + this._TransactionStatus.GetHashCode();
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
