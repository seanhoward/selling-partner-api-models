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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.DataKiosk
{
    /// <summary>
    /// When a query produces results that are not included in the data document, pagination occurs. This means the results are divided into pages. To retrieve the next page, you must pass a &#x60;CreateQuerySpecification&#x60; object with &#x60;paginationToken&#x60; set to this object&#39;s &#x60;nextToken&#x60; and with &#x60;query&#x60; set to this object&#39;s &#x60;query&#x60; in the subsequent &#x60;createQuery&#x60; request. When there are no more pages to fetch, the &#x60;nextToken&#x60; field will be absent.
    /// </summary>
    [DataContract]
    public partial class QueryPagination : IEquatable<QueryPagination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryPagination" /> class.
        /// </summary>
        /// <param name="nextToken">A token that can be used to fetch the next page of results..</param>
        public QueryPagination(string nextToken = default)
        {
            this.NextToken = nextToken;
        }

        /// <summary>
        /// A token that can be used to fetch the next page of results.
        /// </summary>
        /// <value>A token that can be used to fetch the next page of results.</value>
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryPagination {\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
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
            return this.Equals(input as QueryPagination);
        }

        /// <summary>
        /// Returns true if QueryPagination instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryPagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryPagination input)
        {
            if (input == null)
                return false;

            return
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
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
                if (this.NextToken != null)
                    hashCode = hashCode * 59 + this.NextToken.GetHashCode();
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
