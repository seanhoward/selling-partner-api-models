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
    public partial class GetInvoicesAttributesResponse :  IEquatable<GetInvoicesAttributesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoicesAttributesResponse" /> class.
        /// </summary>
        /// <param name="invoicesAttributes">invoicesAttributes.</param>
        public GetInvoicesAttributesResponse(InvoicesAttributes invoicesAttributes = default(InvoicesAttributes))
        {
            this.InvoicesAttributes = invoicesAttributes;
        }
        
        /// <summary>
        /// Gets or Sets InvoicesAttributes
        /// </summary>
        [DataMember(Name="invoicesAttributes", EmitDefaultValue=false)]
        public InvoicesAttributes InvoicesAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetInvoicesAttributesResponse {\n");
            sb.Append("  InvoicesAttributes: ").Append(InvoicesAttributes).Append("\n");
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
            return this.Equals(input as GetInvoicesAttributesResponse);
        }

        /// <summary>
        /// Returns true if GetInvoicesAttributesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetInvoicesAttributesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetInvoicesAttributesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvoicesAttributes == input.InvoicesAttributes ||
                    (this.InvoicesAttributes != null &&
                    this.InvoicesAttributes.Equals(input.InvoicesAttributes))
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
                if (this.InvoicesAttributes != null)
                    hashCode = hashCode * 59 + this.InvoicesAttributes.GetHashCode();
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
