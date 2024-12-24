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
    /// The attributes related to the payment made from customer to seller for this order.
    /// </summary>
    [DataContract]
    public partial class PaymentInformation :  IEquatable<PaymentInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInformation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentInformation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInformation" /> class.
        /// </summary>
        /// <param name="paymentTransactionId">The transaction identifier of this payment. (required).</param>
        /// <param name="paymentMode">The transaction mode of this payment. (required).</param>
        /// <param name="paymentDate">The transaction date of this payment. (required).</param>
        public PaymentInformation(string paymentTransactionId = default(string), string paymentMode = default(string), DateTime? paymentDate = default(DateTime?))
        {
            // to ensure "paymentTransactionId" is required (not null)
            if (paymentTransactionId == null)
            {
                throw new InvalidDataException("paymentTransactionId is a required property for PaymentInformation and cannot be null");
            }
            else
            {
                this.PaymentTransactionId = paymentTransactionId;
            }
            // to ensure "paymentMode" is required (not null)
            if (paymentMode == null)
            {
                throw new InvalidDataException("paymentMode is a required property for PaymentInformation and cannot be null");
            }
            else
            {
                this.PaymentMode = paymentMode;
            }
            // to ensure "paymentDate" is required (not null)
            if (paymentDate == null)
            {
                throw new InvalidDataException("paymentDate is a required property for PaymentInformation and cannot be null");
            }
            else
            {
                this.PaymentDate = paymentDate;
            }
        }
        
        /// <summary>
        /// The transaction identifier of this payment.
        /// </summary>
        /// <value>The transaction identifier of this payment.</value>
        [DataMember(Name="paymentTransactionId", EmitDefaultValue=false)]
        public string PaymentTransactionId { get; set; }

        /// <summary>
        /// The transaction mode of this payment.
        /// </summary>
        /// <value>The transaction mode of this payment.</value>
        [DataMember(Name="paymentMode", EmitDefaultValue=false)]
        public string PaymentMode { get; set; }

        /// <summary>
        /// The transaction date of this payment.
        /// </summary>
        /// <value>The transaction date of this payment.</value>
        [DataMember(Name="paymentDate", EmitDefaultValue=false)]
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentInformation {\n");
            sb.Append("  PaymentTransactionId: ").Append(PaymentTransactionId).Append("\n");
            sb.Append("  PaymentMode: ").Append(PaymentMode).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
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
            return this.Equals(input as PaymentInformation);
        }

        /// <summary>
        /// Returns true if PaymentInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentTransactionId == input.PaymentTransactionId ||
                    (this.PaymentTransactionId != null &&
                    this.PaymentTransactionId.Equals(input.PaymentTransactionId))
                ) && 
                (
                    this.PaymentMode == input.PaymentMode ||
                    (this.PaymentMode != null &&
                    this.PaymentMode.Equals(input.PaymentMode))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
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
                if (this.PaymentTransactionId != null)
                    hashCode = hashCode * 59 + this.PaymentTransactionId.GetHashCode();
                if (this.PaymentMode != null)
                    hashCode = hashCode * 59 + this.PaymentMode.GetHashCode();
                if (this.PaymentDate != null)
                    hashCode = hashCode * 59 + this.PaymentDate.GetHashCode();
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