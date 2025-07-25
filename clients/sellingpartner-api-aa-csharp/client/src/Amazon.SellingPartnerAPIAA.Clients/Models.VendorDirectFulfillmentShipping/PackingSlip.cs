/* 
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * Use the Selling Partner API for Direct Fulfillment Shipping to access a direct fulfillment vendor's shipping data.
 *
 * OpenAPI spec version: 2021-12-28
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping
{
    /// <summary>
    /// Packing slip information.
    /// </summary>
    [DataContract]
    public partial class PackingSlip : IEquatable<PackingSlip>, IValidatableObject
    {
        /// <summary>
        /// The format of the file such as PDF, JPEG etc.
        /// </summary>
        /// <value>The format of the file such as PDF, JPEG etc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContentTypeEnum
        {

            /// <summary>
            /// Enum ApplicationPdf for value: application/pdf
            /// </summary>
            [EnumMember(Value = "application/pdf")]
            ApplicationPdf = 1
        }

        /// <summary>
        /// The format of the file such as PDF, JPEG etc.
        /// </summary>
        /// <value>The format of the file such as PDF, JPEG etc.</value>
        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        public ContentTypeEnum? ContentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackingSlip" /> class.
        /// </summary>
        [JsonConstructor]
        protected PackingSlip() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackingSlip" /> class.
        /// </summary>
        /// <param name="purchaseOrderNumber">Purchase order number of the shipment that the packing slip is for. (required).</param>
        /// <param name="content">A Base64 string of the packing slip PDF. (required).</param>
        /// <param name="contentType">The format of the file such as PDF, JPEG etc..</param>
        public PackingSlip(string purchaseOrderNumber = default, string content = default, ContentTypeEnum? contentType = default)
        {
            // to ensure "purchaseOrderNumber" is required (not null)
            if (purchaseOrderNumber == null)
            {
                throw new InvalidDataException("purchaseOrderNumber is a required property for PackingSlip and cannot be null");
            }
            else
            {
                this.PurchaseOrderNumber = purchaseOrderNumber;
            }
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for PackingSlip and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            this.ContentType = contentType;
        }

        /// <summary>
        /// Purchase order number of the shipment that the packing slip is for.
        /// </summary>
        /// <value>Purchase order number of the shipment that the packing slip is for.</value>
        [DataMember(Name = "purchaseOrderNumber", EmitDefaultValue = false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// A Base64 string of the packing slip PDF.
        /// </summary>
        /// <value>A Base64 string of the packing slip PDF.</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackingSlip {\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
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
            return this.Equals(input as PackingSlip);
        }

        /// <summary>
        /// Returns true if PackingSlip instances are equal
        /// </summary>
        /// <param name="input">Instance of PackingSlip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackingSlip input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) &&
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) &&
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
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
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
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
            // PurchaseOrderNumber (string) pattern
            Regex regexPurchaseOrderNumber = new Regex(@"^[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexPurchaseOrderNumber.Match(this.PurchaseOrderNumber).Success)
            {
                yield return new ValidationResult("Invalid value for PurchaseOrderNumber, must match a pattern of " + regexPurchaseOrderNumber, new[] { "PurchaseOrderNumber" });
            }

            yield break;
        }
    }

}
