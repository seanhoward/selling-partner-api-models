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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.InvoicesApiModel
{
    /// <summary>
    /// An object that contains the &#x60;documentId&#x60; and an S3 pre-signed URL that you can use to download the specified file.
    /// </summary>
    [DataContract]
    public partial class InvoicesDocument : IEquatable<InvoicesDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesDocument" /> class.
        /// </summary>
        /// <param name="invoicesDocumentId">The identifier of the export document..</param>
        /// <param name="invoicesDocumentUrl">A pre-signed URL that you can use to download the invoices document in zip format. This URL expires after 30 seconds..</param>
        public InvoicesDocument(string invoicesDocumentId = default, string invoicesDocumentUrl = default)
        {
            this.InvoicesDocumentId = invoicesDocumentId;
            this.InvoicesDocumentUrl = invoicesDocumentUrl;
        }

        /// <summary>
        /// The identifier of the export document.
        /// </summary>
        /// <value>The identifier of the export document.</value>
        [DataMember(Name = "invoicesDocumentId", EmitDefaultValue = false)]
        public string InvoicesDocumentId { get; set; }

        /// <summary>
        /// A pre-signed URL that you can use to download the invoices document in zip format. This URL expires after 30 seconds.
        /// </summary>
        /// <value>A pre-signed URL that you can use to download the invoices document in zip format. This URL expires after 30 seconds.</value>
        [DataMember(Name = "invoicesDocumentUrl", EmitDefaultValue = false)]
        public string InvoicesDocumentUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoicesDocument {\n");
            sb.Append("  InvoicesDocumentId: ").Append(InvoicesDocumentId).Append("\n");
            sb.Append("  InvoicesDocumentUrl: ").Append(InvoicesDocumentUrl).Append("\n");
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
            return this.Equals(input as InvoicesDocument);
        }

        /// <summary>
        /// Returns true if InvoicesDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoicesDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoicesDocument input)
        {
            if (input == null)
                return false;

            return
                (
                    this.InvoicesDocumentId == input.InvoicesDocumentId ||
                    (this.InvoicesDocumentId != null &&
                    this.InvoicesDocumentId.Equals(input.InvoicesDocumentId))
                ) &&
                (
                    this.InvoicesDocumentUrl == input.InvoicesDocumentUrl ||
                    (this.InvoicesDocumentUrl != null &&
                    this.InvoicesDocumentUrl.Equals(input.InvoicesDocumentUrl))
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
                if (this.InvoicesDocumentId != null)
                    hashCode = hashCode * 59 + this.InvoicesDocumentId.GetHashCode();
                if (this.InvoicesDocumentUrl != null)
                    hashCode = hashCode * 59 + this.InvoicesDocumentUrl.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
