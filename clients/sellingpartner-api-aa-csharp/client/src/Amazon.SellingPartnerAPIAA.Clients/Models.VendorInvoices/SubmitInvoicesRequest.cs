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
    /// The request schema for the submitInvoices operation.
    /// </summary>
    [DataContract]
    public partial class SubmitInvoicesRequest :  IEquatable<SubmitInvoicesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitInvoicesRequest" /> class.
        /// </summary>
        /// <param name="invoices">An array of Invoice objects representing the invoices or credit notes to be submitted..</param>
        public SubmitInvoicesRequest(List<Invoice> invoices = default(List<Invoice>))
        {
            this.Invoices = invoices;
        }
        
        /// <summary>
        /// An array of Invoice objects representing the invoices or credit notes to be submitted.
        /// </summary>
        /// <value>An array of Invoice objects representing the invoices or credit notes to be submitted.</value>
        [DataMember(Name="invoices", EmitDefaultValue=false)]
        public List<Invoice> Invoices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmitInvoicesRequest {\n");
            sb.Append("  Invoices: ").Append(Invoices).Append("\n");
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
            return this.Equals(input as SubmitInvoicesRequest);
        }

        /// <summary>
        /// Returns true if SubmitInvoicesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmitInvoicesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmitInvoicesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Invoices == input.Invoices ||
                    this.Invoices != null &&
                    this.Invoices.SequenceEqual(input.Invoices)
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
                if (this.Invoices != null)
                    hashCode = hashCode * 59 + this.Invoices.GetHashCode();
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
