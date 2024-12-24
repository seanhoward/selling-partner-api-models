/* 
 * Selling Partner API for Easy Ship
 *
 * The Selling Partner API for Easy Ship helps you build applications that help sellers manage and ship Amazon Easy Ship orders.  Your Easy Ship applications can:  * Get available time slots for packages to be scheduled for delivery.  * Schedule, reschedule, and cancel Easy Ship orders.  * Print labels, invoices, and warranties.  See the [Marketplace Support Table](doc:easyship-api-v2022-03-23-use-case-guide#marketplace-support-table) for the differences in Easy Ship operations by marketplace.
 *
 * OpenAPI spec version: 2022-03-23
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.EasyShip
{
    /// <summary>
    /// Invoice number and date.
    /// </summary>
    [DataContract]
    public partial class InvoiceData :  IEquatable<InvoiceData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceData" /> class.
        /// </summary>
        /// <param name="invoiceNumber">The invoice number. (required).</param>
        /// <param name="invoiceDate">The date that the invoice was generated..</param>
        public InvoiceData(string invoiceNumber = default(string), DateTime? invoiceDate = default(DateTime?))
        {
            // to ensure "invoiceNumber" is required (not null)
            if (invoiceNumber == null)
            {
                throw new InvalidDataException("invoiceNumber is a required property for InvoiceData and cannot be null");
            }
            else
            {
                this.InvoiceNumber = invoiceNumber;
            }
            this.InvoiceDate = invoiceDate;
        }
        
        /// <summary>
        /// The invoice number.
        /// </summary>
        /// <value>The invoice number.</value>
        [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// The date that the invoice was generated.
        /// </summary>
        /// <value>The date that the invoice was generated.</value>
        [DataMember(Name="invoiceDate", EmitDefaultValue=false)]
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceData {\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
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
            return this.Equals(input as InvoiceData);
        }

        /// <summary>
        /// Returns true if InvoiceData instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
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
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.InvoiceDate != null)
                    hashCode = hashCode * 59 + this.InvoiceDate.GetHashCode();
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
