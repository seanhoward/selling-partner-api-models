/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound
{
    /// <summary>
    /// A light-weight inbound plan.
    /// </summary>
    [DataContract]
    public partial class InboundPlanSummary : IEquatable<InboundPlanSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundPlanSummary" /> class.
        /// </summary>
        [JsonConstructor]
        protected InboundPlanSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundPlanSummary" /> class.
        /// </summary>
        /// <param name="createdAt">The time at which the inbound plan was created. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mm:ssZ&#x60;. (required).</param>
        /// <param name="inboundPlanId">Identifier of an inbound plan. (required).</param>
        /// <param name="lastUpdatedAt">The time at which the inbound plan was last updated. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mm:ssZ&#x60;. (required).</param>
        /// <param name="marketplaceIds">A list of marketplace IDs. (required).</param>
        /// <param name="name">Human-readable name of the inbound plan. (required).</param>
        /// <param name="sourceAddress">sourceAddress (required).</param>
        /// <param name="status">The current status of the inbound plan. Possible values: &#x60;ACTIVE&#x60;, &#x60;VOIDED&#x60;, &#x60;SHIPPED&#x60;, &#x60;ERRORED&#x60;. (required).</param>
        public InboundPlanSummary(DateTime? createdAt = default, string inboundPlanId = default, DateTime? lastUpdatedAt = default, List<string> marketplaceIds = default, string name = default, Address sourceAddress = default, string status = default)
        {
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "inboundPlanId" is required (not null)
            if (inboundPlanId == null)
            {
                throw new InvalidDataException("inboundPlanId is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.InboundPlanId = inboundPlanId;
            }
            // to ensure "lastUpdatedAt" is required (not null)
            if (lastUpdatedAt == null)
            {
                throw new InvalidDataException("lastUpdatedAt is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.LastUpdatedAt = lastUpdatedAt;
            }
            // to ensure "marketplaceIds" is required (not null)
            if (marketplaceIds == null)
            {
                throw new InvalidDataException("marketplaceIds is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.MarketplaceIds = marketplaceIds;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "sourceAddress" is required (not null)
            if (sourceAddress == null)
            {
                throw new InvalidDataException("sourceAddress is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.SourceAddress = sourceAddress;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.Status = status;
            }
        }

        /// <summary>
        /// The time at which the inbound plan was created. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mm:ssZ&#x60;.
        /// </summary>
        /// <value>The time at which the inbound plan was created. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mm:ssZ&#x60;.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Identifier of an inbound plan.
        /// </summary>
        /// <value>Identifier of an inbound plan.</value>
        [DataMember(Name = "inboundPlanId", EmitDefaultValue = false)]
        public string InboundPlanId { get; set; }

        /// <summary>
        /// The time at which the inbound plan was last updated. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mm:ssZ&#x60;.
        /// </summary>
        /// <value>The time at which the inbound plan was last updated. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mm:ssZ&#x60;.</value>
        [DataMember(Name = "lastUpdatedAt", EmitDefaultValue = false)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// A list of marketplace IDs.
        /// </summary>
        /// <value>A list of marketplace IDs.</value>
        [DataMember(Name = "marketplaceIds", EmitDefaultValue = false)]
        public List<string> MarketplaceIds { get; set; }

        /// <summary>
        /// Human-readable name of the inbound plan.
        /// </summary>
        /// <value>Human-readable name of the inbound plan.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SourceAddress
        /// </summary>
        [DataMember(Name = "sourceAddress", EmitDefaultValue = false)]
        public Address SourceAddress { get; set; }

        /// <summary>
        /// The current status of the inbound plan. Possible values: &#x60;ACTIVE&#x60;, &#x60;VOIDED&#x60;, &#x60;SHIPPED&#x60;, &#x60;ERRORED&#x60;.
        /// </summary>
        /// <value>The current status of the inbound plan. Possible values: &#x60;ACTIVE&#x60;, &#x60;VOIDED&#x60;, &#x60;SHIPPED&#x60;, &#x60;ERRORED&#x60;.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundPlanSummary {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  InboundPlanId: ").Append(InboundPlanId).Append("\n");
            sb.Append("  LastUpdatedAt: ").Append(LastUpdatedAt).Append("\n");
            sb.Append("  MarketplaceIds: ").Append(MarketplaceIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SourceAddress: ").Append(SourceAddress).Append("\n");
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
            return this.Equals(input as InboundPlanSummary);
        }

        /// <summary>
        /// Returns true if InboundPlanSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of InboundPlanSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundPlanSummary input)
        {
            if (input == null)
                return false;

            return
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) &&
                (
                    this.InboundPlanId == input.InboundPlanId ||
                    (this.InboundPlanId != null &&
                    this.InboundPlanId.Equals(input.InboundPlanId))
                ) &&
                (
                    this.LastUpdatedAt == input.LastUpdatedAt ||
                    (this.LastUpdatedAt != null &&
                    this.LastUpdatedAt.Equals(input.LastUpdatedAt))
                ) &&
                (
                    this.MarketplaceIds == input.MarketplaceIds ||
                    this.MarketplaceIds != null &&
                    this.MarketplaceIds.SequenceEqual(input.MarketplaceIds)
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.SourceAddress == input.SourceAddress ||
                    (this.SourceAddress != null &&
                    this.SourceAddress.Equals(input.SourceAddress))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.InboundPlanId != null)
                    hashCode = hashCode * 59 + this.InboundPlanId.GetHashCode();
                if (this.LastUpdatedAt != null)
                    hashCode = hashCode * 59 + this.LastUpdatedAt.GetHashCode();
                if (this.MarketplaceIds != null)
                    hashCode = hashCode * 59 + this.MarketplaceIds.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SourceAddress != null)
                    hashCode = hashCode * 59 + this.SourceAddress.GetHashCode();
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
            // InboundPlanId (string) maxLength
            if (this.InboundPlanId != null && this.InboundPlanId.Length > 38)
            {
                yield return new ValidationResult("Invalid value for InboundPlanId, length must be less than 38.", new[] { "InboundPlanId" });
            }

            // InboundPlanId (string) minLength
            if (this.InboundPlanId != null && this.InboundPlanId.Length < 38)
            {
                yield return new ValidationResult("Invalid value for InboundPlanId, length must be greater than 38.", new[] { "InboundPlanId" });
            }

            // InboundPlanId (string) pattern
            Regex regexInboundPlanId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
            if (false == regexInboundPlanId.Match(this.InboundPlanId).Success)
            {
                yield return new ValidationResult("Invalid value for InboundPlanId, must match a pattern of " + regexInboundPlanId, new[] { "InboundPlanId" });
            }

            // Status (string) maxLength
            if (this.Status != null && this.Status.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for Status, length must be less than 1024.", new[] { "Status" });
            }

            // Status (string) minLength
            if (this.Status != null && this.Status.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Status, length must be greater than 1.", new[] { "Status" });
            }

            yield break;
        }
    }

}
