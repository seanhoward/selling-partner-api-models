/* 
 * Selling Partner API for Data Kiosk
 *
 * The Selling Partner API for Data Kiosk lets you submit GraphQL queries from a variety of schemas to help selling partners manage their businesses.
 *
 * OpenAPI spec version: 2023-11-15
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.DataKiosk
{
    /// <summary>
    /// The response for the &#x60;getQueries&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class GetQueriesResponse : IEquatable<GetQueriesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetQueriesResponse" /> class.
        /// </summary>
        [JsonConstructor]
        protected GetQueriesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetQueriesResponse" /> class.
        /// </summary>
        /// <param name="queries">The Data Kiosk queries. (required).</param>
        /// <param name="pagination">pagination.</param>
        public GetQueriesResponse(QueryList queries = default, GetQueriesResponsePagination pagination = default)
        {
            // to ensure "queries" is required (not null)
            if (queries == null)
            {
                throw new InvalidDataException("queries is a required property for GetQueriesResponse and cannot be null");
            }
            else
            {
                this.Queries = queries;
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// The Data Kiosk queries.
        /// </summary>
        /// <value>The Data Kiosk queries.</value>
        [DataMember(Name = "queries", EmitDefaultValue = false)]
        public QueryList Queries { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public GetQueriesResponsePagination Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetQueriesResponse {\n");
            sb.Append("  Queries: ").Append(Queries).Append("\n");
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
            return this.Equals(input as GetQueriesResponse);
        }

        /// <summary>
        /// Returns true if GetQueriesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetQueriesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetQueriesResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Queries == input.Queries ||
                    (this.Queries != null &&
                    this.Queries.Equals(input.Queries))
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
                if (this.Queries != null)
                    hashCode = hashCode * 59 + this.Queries.GetHashCode();
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
