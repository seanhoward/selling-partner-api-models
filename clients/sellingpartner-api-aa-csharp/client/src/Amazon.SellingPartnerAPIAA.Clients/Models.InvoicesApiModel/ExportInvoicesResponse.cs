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
    public partial class ExportInvoicesResponse :  IEquatable<ExportInvoicesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportInvoicesResponse" /> class.
        /// </summary>
        /// <param name="exportId">The export identifier..</param>
        public ExportInvoicesResponse(string exportId = default(string))
        {
            this.ExportId = exportId;
        }
        
        /// <summary>
        /// The export identifier.
        /// </summary>
        /// <value>The export identifier.</value>
        [DataMember(Name="exportId", EmitDefaultValue=false)]
        public string ExportId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportInvoicesResponse {\n");
            sb.Append("  ExportId: ").Append(ExportId).Append("\n");
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
            return this.Equals(input as ExportInvoicesResponse);
        }

        /// <summary>
        /// Returns true if ExportInvoicesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportInvoicesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportInvoicesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExportId == input.ExportId ||
                    (this.ExportId != null &&
                    this.ExportId.Equals(input.ExportId))
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
                if (this.ExportId != null)
                    hashCode = hashCode * 59 + this.ExportId.GetHashCode();
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
