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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.DataKiosk
{
    /// <summary>
    /// The response for the &#x60;createQuery&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class CreateQueryResponse :  IEquatable<CreateQueryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateQueryResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateQueryResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateQueryResponse" /> class.
        /// </summary>
        /// <param name="queryId">The identifier for the query. This identifier is unique only in combination with a selling partner account ID. (required).</param>
        public CreateQueryResponse(string queryId = default(string))
        {
            // to ensure "queryId" is required (not null)
            if (queryId == null)
            {
                throw new InvalidDataException("queryId is a required property for CreateQueryResponse and cannot be null");
            }
            else
            {
                this.QueryId = queryId;
            }
        }
        
        /// <summary>
        /// The identifier for the query. This identifier is unique only in combination with a selling partner account ID.
        /// </summary>
        /// <value>The identifier for the query. This identifier is unique only in combination with a selling partner account ID.</value>
        [DataMember(Name="queryId", EmitDefaultValue=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateQueryResponse {\n");
            sb.Append("  QueryId: ").Append(QueryId).Append("\n");
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
            return this.Equals(input as CreateQueryResponse);
        }

        /// <summary>
        /// Returns true if CreateQueryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateQueryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QueryId == input.QueryId ||
                    (this.QueryId != null &&
                    this.QueryId.Equals(input.QueryId))
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
                if (this.QueryId != null)
                    hashCode = hashCode * 59 + this.QueryId.GetHashCode();
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