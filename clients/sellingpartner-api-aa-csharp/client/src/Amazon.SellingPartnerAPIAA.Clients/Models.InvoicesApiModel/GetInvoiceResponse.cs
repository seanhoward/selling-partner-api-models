/* 
 * The Selling Partner API for Invoices.
 *
 * Use the Selling Partner API for Invoices to retrieve and manage invoice-related operations, which can help selling partners manage their bookkeeping processes.
 *
 * OpenAPI spec version: 2024-06-19
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.InvoicesApiModel
{
    /// <summary>
    /// Success.
    /// </summary>
    [DataContract]
    public partial class GetInvoiceResponse :  IEquatable<GetInvoiceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceResponse" /> class.
        /// </summary>
        /// <param name="invoice">invoice.</param>
        public GetInvoiceResponse(Invoice invoice = default(Invoice))
        {
            this.Invoice = invoice;
        }
        
        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public Invoice Invoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetInvoiceResponse {\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
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
            return this.Equals(input as GetInvoiceResponse);
        }

        /// <summary>
        /// Returns true if GetInvoiceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetInvoiceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetInvoiceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
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
                if (this.Invoice != null)
                    hashCode = hashCode * 59 + this.Invoice.GetHashCode();
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
