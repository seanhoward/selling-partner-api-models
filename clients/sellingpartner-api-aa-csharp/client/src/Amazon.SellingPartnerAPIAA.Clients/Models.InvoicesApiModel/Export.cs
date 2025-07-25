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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.InvoicesApiModel
{
    /// <summary>
    /// Detailed information about the export.
    /// </summary>
    [DataContract]
    public partial class Export : IEquatable<Export>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ExportStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Export" /> class.
        /// </summary>
        /// <param name="errorMessage">When the export generation fails, this attribute contains a description of the error..</param>
        /// <param name="exportId">The export identifier..</param>
        /// <param name="generateExportFinishedAt">The date and time when the export generation finished. Vales are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format..</param>
        /// <param name="generateExportStartedAt">The date and time when the export generation started. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format..</param>
        /// <param name="invoicesDocumentIds">The identifier for the export documents. To get the information required to retrieve the export document&#39;s contents, pass each ID in the &#x60;getInvoicesDocument&#x60; operation.  This list is empty until the status is &#x60;DONE&#x60;..</param>
        /// <param name="status">status.</param>
        public Export(string errorMessage = default, string exportId = default, DateTime? generateExportFinishedAt = default, DateTime? generateExportStartedAt = default, List<string> invoicesDocumentIds = default, ExportStatus? status = default)
        {
            this.ErrorMessage = errorMessage;
            this.ExportId = exportId;
            this.GenerateExportFinishedAt = generateExportFinishedAt;
            this.GenerateExportStartedAt = generateExportStartedAt;
            this.InvoicesDocumentIds = invoicesDocumentIds;
            this.Status = status;
        }

        /// <summary>
        /// When the export generation fails, this attribute contains a description of the error.
        /// </summary>
        /// <value>When the export generation fails, this attribute contains a description of the error.</value>
        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The export identifier.
        /// </summary>
        /// <value>The export identifier.</value>
        [DataMember(Name = "exportId", EmitDefaultValue = false)]
        public string ExportId { get; set; }

        /// <summary>
        /// The date and time when the export generation finished. Vales are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.
        /// </summary>
        /// <value>The date and time when the export generation finished. Vales are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.</value>
        [DataMember(Name = "generateExportFinishedAt", EmitDefaultValue = false)]
        public DateTime? GenerateExportFinishedAt { get; set; }

        /// <summary>
        /// The date and time when the export generation started. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.
        /// </summary>
        /// <value>The date and time when the export generation started. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.</value>
        [DataMember(Name = "generateExportStartedAt", EmitDefaultValue = false)]
        public DateTime? GenerateExportStartedAt { get; set; }

        /// <summary>
        /// The identifier for the export documents. To get the information required to retrieve the export document&#39;s contents, pass each ID in the &#x60;getInvoicesDocument&#x60; operation.  This list is empty until the status is &#x60;DONE&#x60;.
        /// </summary>
        /// <value>The identifier for the export documents. To get the information required to retrieve the export document&#39;s contents, pass each ID in the &#x60;getInvoicesDocument&#x60; operation.  This list is empty until the status is &#x60;DONE&#x60;.</value>
        [DataMember(Name = "invoicesDocumentIds", EmitDefaultValue = false)]
        public List<string> InvoicesDocumentIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Export {\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ExportId: ").Append(ExportId).Append("\n");
            sb.Append("  GenerateExportFinishedAt: ").Append(GenerateExportFinishedAt).Append("\n");
            sb.Append("  GenerateExportStartedAt: ").Append(GenerateExportStartedAt).Append("\n");
            sb.Append("  InvoicesDocumentIds: ").Append(InvoicesDocumentIds).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Export);
        }

        /// <summary>
        /// Returns true if Export instances are equal
        /// </summary>
        /// <param name="input">Instance of Export to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Export input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) &&
                (
                    this.ExportId == input.ExportId ||
                    (this.ExportId != null &&
                    this.ExportId.Equals(input.ExportId))
                ) &&
                (
                    this.GenerateExportFinishedAt == input.GenerateExportFinishedAt ||
                    (this.GenerateExportFinishedAt != null &&
                    this.GenerateExportFinishedAt.Equals(input.GenerateExportFinishedAt))
                ) &&
                (
                    this.GenerateExportStartedAt == input.GenerateExportStartedAt ||
                    (this.GenerateExportStartedAt != null &&
                    this.GenerateExportStartedAt.Equals(input.GenerateExportStartedAt))
                ) &&
                (
                    this.InvoicesDocumentIds == input.InvoicesDocumentIds ||
                    this.InvoicesDocumentIds != null &&
                    this.InvoicesDocumentIds.SequenceEqual(input.InvoicesDocumentIds)
                ) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.ExportId != null)
                    hashCode = hashCode * 59 + this.ExportId.GetHashCode();
                if (this.GenerateExportFinishedAt != null)
                    hashCode = hashCode * 59 + this.GenerateExportFinishedAt.GetHashCode();
                if (this.GenerateExportStartedAt != null)
                    hashCode = hashCode * 59 + this.GenerateExportStartedAt.GetHashCode();
                if (this.InvoicesDocumentIds != null)
                    hashCode = hashCode * 59 + this.InvoicesDocumentIds.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
