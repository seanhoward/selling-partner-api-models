/* 
 * Selling Partner API for Replenishment
 *
 * The Selling Partner API for Replenishment (Replenishment API) provides programmatic access to replenishment program metrics and offers. These programs provide recurring delivery of any replenishable item at a frequency chosen by the customer.  The Replenishment API is available worldwide wherever Amazon Subscribe & Save is available or is supported. The API is available to vendors and FBA selling partners.
 *
 * OpenAPI spec version: 2022-11-07
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Replenishment
{
    /// <summary>
    /// Use these parameters to paginate through the response.
    /// </summary>
    [DataContract]
    public partial class ListOfferMetricsRequestPagination : IEquatable<ListOfferMetricsRequestPagination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfferMetricsRequestPagination" /> class.
        /// </summary>
        [JsonConstructor]
        protected ListOfferMetricsRequestPagination() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfferMetricsRequestPagination" /> class.
        /// </summary>
        /// <param name="limit">The maximum number of results to return in the response. (required).</param>
        /// <param name="offset">The offset from which to retrieve the number of results specified by the &#x60;limit&#x60; value. The first result is at offset 0. (required).</param>
        public ListOfferMetricsRequestPagination(long? limit = default, long? offset = default)
        {
            // to ensure "limit" is required (not null)
            if (limit == null)
            {
                throw new InvalidDataException("limit is a required property for ListOfferMetricsRequestPagination and cannot be null");
            }
            else
            {
                this.Limit = limit;
            }
            // to ensure "offset" is required (not null)
            if (offset == null)
            {
                throw new InvalidDataException("offset is a required property for ListOfferMetricsRequestPagination and cannot be null");
            }
            else
            {
                this.Offset = offset;
            }
        }

        /// <summary>
        /// The maximum number of results to return in the response.
        /// </summary>
        /// <value>The maximum number of results to return in the response.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public long? Limit { get; set; }

        /// <summary>
        /// The offset from which to retrieve the number of results specified by the &#x60;limit&#x60; value. The first result is at offset 0.
        /// </summary>
        /// <value>The offset from which to retrieve the number of results specified by the &#x60;limit&#x60; value. The first result is at offset 0.</value>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public long? Offset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOfferMetricsRequestPagination {\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
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
            return this.Equals(input as ListOfferMetricsRequestPagination);
        }

        /// <summary>
        /// Returns true if ListOfferMetricsRequestPagination instances are equal
        /// </summary>
        /// <param name="input">Instance of ListOfferMetricsRequestPagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListOfferMetricsRequestPagination input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) &&
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
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
            // Limit (long?) maximum
            if (this.Limit > (long?)500)
            {
                yield return new ValidationResult("Invalid value for Limit, must be a value less than or equal to 500.", new[] { "Limit" });
            }

            // Limit (long?) minimum
            if (this.Limit < (long?)1)
            {
                yield return new ValidationResult("Invalid value for Limit, must be a value greater than or equal to 1.", new[] { "Limit" });
            }

            // Offset (long?) maximum
            if (this.Offset > (long?)9000)
            {
                yield return new ValidationResult("Invalid value for Offset, must be a value less than or equal to 9000.", new[] { "Offset" });
            }

            // Offset (long?) minimum
            if (this.Offset < (long?)0)
            {
                yield return new ValidationResult("Invalid value for Offset, must be a value greater than or equal to 0.", new[] { "Offset" });
            }

            yield break;
        }
    }

}
