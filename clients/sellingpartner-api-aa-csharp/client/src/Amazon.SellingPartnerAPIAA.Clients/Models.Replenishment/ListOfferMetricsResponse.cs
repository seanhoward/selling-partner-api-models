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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Replenishment
{
    /// <summary>
    /// The response schema for the &#x60;listOfferMetrics&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class ListOfferMetricsResponse :  IEquatable<ListOfferMetricsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfferMetricsResponse" /> class.
        /// </summary>
        /// <param name="offers">A list of offers and associated metrics..</param>
        /// <param name="pagination">Use these parameters to paginate through the response..</param>
        public ListOfferMetricsResponse(List<ListOfferMetricsResponseOffer> offers = default(List<ListOfferMetricsResponseOffer>), PaginationResponse pagination = default(PaginationResponse))
        {
            this.Offers = offers;
            this.Pagination = pagination;
        }
        
        /// <summary>
        /// A list of offers and associated metrics.
        /// </summary>
        /// <value>A list of offers and associated metrics.</value>
        [DataMember(Name="offers", EmitDefaultValue=false)]
        public List<ListOfferMetricsResponseOffer> Offers { get; set; }

        /// <summary>
        /// Use these parameters to paginate through the response.
        /// </summary>
        /// <value>Use these parameters to paginate through the response.</value>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public PaginationResponse Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOfferMetricsResponse {\n");
            sb.Append("  Offers: ").Append(Offers).Append("\n");
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
            return this.Equals(input as ListOfferMetricsResponse);
        }

        /// <summary>
        /// Returns true if ListOfferMetricsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListOfferMetricsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListOfferMetricsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Offers == input.Offers ||
                    this.Offers != null &&
                    this.Offers.SequenceEqual(input.Offers)
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
                if (this.Offers != null)
                    hashCode = hashCode * 59 + this.Offers.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
