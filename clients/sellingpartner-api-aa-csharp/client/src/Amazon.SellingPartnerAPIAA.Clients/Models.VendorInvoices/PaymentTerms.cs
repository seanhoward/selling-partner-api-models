/* 
 * Vendor Invoices v1
 *
 * The Selling Partner API for Retail Procurement Payments provides programmatic access to vendors payments data.
 *
 * OpenAPI spec version: v1
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorInvoices
{
    /// <summary>
    /// Terms of the payment for the invoice. The basis of the payment terms is the invoice date.
    /// </summary>
    [DataContract]
    public partial class PaymentTerms :  IEquatable<PaymentTerms>, IValidatableObject
    {
        /// <summary>
        /// The payment term type for the invoice.
        /// </summary>
        /// <value>The payment term type for the invoice.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Basic for value: Basic
            /// </summary>
            [EnumMember(Value = "Basic")]
            Basic = 1,
            
            /// <summary>
            /// Enum EndOfMonth for value: EndOfMonth
            /// </summary>
            [EnumMember(Value = "EndOfMonth")]
            EndOfMonth = 2,
            
            /// <summary>
            /// Enum FixedDate for value: FixedDate
            /// </summary>
            [EnumMember(Value = "FixedDate")]
            FixedDate = 3,
            
            /// <summary>
            /// Enum Proximo for value: Proximo
            /// </summary>
            [EnumMember(Value = "Proximo")]
            Proximo = 4,
            
            /// <summary>
            /// Enum PaymentDueUponReceiptOfInvoice for value: PaymentDueUponReceiptOfInvoice
            /// </summary>
            [EnumMember(Value = "PaymentDueUponReceiptOfInvoice")]
            PaymentDueUponReceiptOfInvoice = 5,
            
            /// <summary>
            /// Enum LetterofCredit for value: LetterofCredit
            /// </summary>
            [EnumMember(Value = "LetterofCredit")]
            LetterofCredit = 6
        }

        /// <summary>
        /// The payment term type for the invoice.
        /// </summary>
        /// <value>The payment term type for the invoice.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerms" /> class.
        /// </summary>
        /// <param name="type">The payment term type for the invoice..</param>
        /// <param name="discountPercent">The discount percent value, which is good until the discount due date..</param>
        /// <param name="discountDueDays">The number of calendar days from the Base date (Invoice date) until the discount is no longer valid..</param>
        /// <param name="netDueDays">The number of calendar days from the base date (invoice date) until the total amount on the invoice is due..</param>
        public PaymentTerms(TypeEnum? type = default(TypeEnum?), string discountPercent = default(string), decimal? discountDueDays = default(decimal?), decimal? netDueDays = default(decimal?))
        {
            this.Type = type;
            this.DiscountPercent = discountPercent;
            this.DiscountDueDays = discountDueDays;
            this.NetDueDays = netDueDays;
        }
        

        /// <summary>
        /// The discount percent value, which is good until the discount due date.
        /// </summary>
        /// <value>The discount percent value, which is good until the discount due date.</value>
        [DataMember(Name="discountPercent", EmitDefaultValue=false)]
        public string DiscountPercent { get; set; }

        /// <summary>
        /// The number of calendar days from the Base date (Invoice date) until the discount is no longer valid.
        /// </summary>
        /// <value>The number of calendar days from the Base date (Invoice date) until the discount is no longer valid.</value>
        [DataMember(Name="discountDueDays", EmitDefaultValue=false)]
        public decimal? DiscountDueDays { get; set; }

        /// <summary>
        /// The number of calendar days from the base date (invoice date) until the total amount on the invoice is due.
        /// </summary>
        /// <value>The number of calendar days from the base date (invoice date) until the total amount on the invoice is due.</value>
        [DataMember(Name="netDueDays", EmitDefaultValue=false)]
        public decimal? NetDueDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTerms {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  DiscountDueDays: ").Append(DiscountDueDays).Append("\n");
            sb.Append("  NetDueDays: ").Append(NetDueDays).Append("\n");
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
            return this.Equals(input as PaymentTerms);
        }

        /// <summary>
        /// Returns true if PaymentTerms instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DiscountPercent == input.DiscountPercent ||
                    (this.DiscountPercent != null &&
                    this.DiscountPercent.Equals(input.DiscountPercent))
                ) && 
                (
                    this.DiscountDueDays == input.DiscountDueDays ||
                    (this.DiscountDueDays != null &&
                    this.DiscountDueDays.Equals(input.DiscountDueDays))
                ) && 
                (
                    this.NetDueDays == input.NetDueDays ||
                    (this.NetDueDays != null &&
                    this.NetDueDays.Equals(input.NetDueDays))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DiscountPercent != null)
                    hashCode = hashCode * 59 + this.DiscountPercent.GetHashCode();
                if (this.DiscountDueDays != null)
                    hashCode = hashCode * 59 + this.DiscountDueDays.GetHashCode();
                if (this.NetDueDays != null)
                    hashCode = hashCode * 59 + this.NetDueDays.GetHashCode();
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
