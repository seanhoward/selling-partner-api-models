/* 
 * Fulfillment Inbound v2024-03-20
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound
{
    /// <summary>
    /// The &#x60;createMarketplaceItemLabels&#x60; response.
    /// </summary>
    [DataContract]
    public partial class CreateMarketplaceItemLabelsResponse :  IEquatable<CreateMarketplaceItemLabelsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMarketplaceItemLabelsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateMarketplaceItemLabelsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMarketplaceItemLabelsResponse" /> class.
        /// </summary>
        /// <param name="documentDownloads">Resources to download the requested document. (required).</param>
        public CreateMarketplaceItemLabelsResponse(List<DocumentDownload> documentDownloads = default(List<DocumentDownload>))
        {
            // to ensure "documentDownloads" is required (not null)
            if (documentDownloads == null)
            {
                throw new InvalidDataException("documentDownloads is a required property for CreateMarketplaceItemLabelsResponse and cannot be null");
            }
            else
            {
                this.DocumentDownloads = documentDownloads;
            }
        }
        
        /// <summary>
        /// Resources to download the requested document.
        /// </summary>
        /// <value>Resources to download the requested document.</value>
        [DataMember(Name="documentDownloads", EmitDefaultValue=false)]
        public List<DocumentDownload> DocumentDownloads { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMarketplaceItemLabelsResponse {\n");
            sb.Append("  DocumentDownloads: ").Append(DocumentDownloads).Append("\n");
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
            return this.Equals(input as CreateMarketplaceItemLabelsResponse);
        }

        /// <summary>
        /// Returns true if CreateMarketplaceItemLabelsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateMarketplaceItemLabelsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateMarketplaceItemLabelsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentDownloads == input.DocumentDownloads ||
                    this.DocumentDownloads != null &&
                    this.DocumentDownloads.SequenceEqual(input.DocumentDownloads)
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
                if (this.DocumentDownloads != null)
                    hashCode = hashCode * 59 + this.DocumentDownloads.GetHashCode();
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
