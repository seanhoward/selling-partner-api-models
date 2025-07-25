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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound
{
    /// <summary>
    /// The &#x60;listInboundPlans&#x60; response.
    /// </summary>
    [DataContract]
    public partial class ListInboundPlansResponse : IEquatable<ListInboundPlansResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListInboundPlansResponse" /> class.
        /// </summary>
        /// <param name="inboundPlans">A list of inbound plans with minimal information..</param>
        /// <param name="pagination">pagination.</param>
        public ListInboundPlansResponse(List<InboundPlanSummary> inboundPlans = default, Pagination pagination = default)
        {
            this.InboundPlans = inboundPlans;
            this.Pagination = pagination;
        }

        /// <summary>
        /// A list of inbound plans with minimal information.
        /// </summary>
        /// <value>A list of inbound plans with minimal information.</value>
        [DataMember(Name = "inboundPlans", EmitDefaultValue = false)]
        public List<InboundPlanSummary> InboundPlans { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInboundPlansResponse {\n");
            sb.Append("  InboundPlans: ").Append(InboundPlans).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(input as ListInboundPlansResponse);
        }

        /// <summary>
        /// Returns true if ListInboundPlansResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListInboundPlansResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListInboundPlansResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.InboundPlans == input.InboundPlans ||
                    this.InboundPlans != null &&
                    this.InboundPlans.SequenceEqual(input.InboundPlans)
                ) &&
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
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
                if (this.InboundPlans != null)
                    hashCode = hashCode * 59 + this.InboundPlans.GetHashCode();
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
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
