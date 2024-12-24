/* 
 * Selling Partner API for Listings Items
 *
 * The Selling Partner API for Listings Items (Listings Items API) provides programmatic access to selling partner listings on Amazon. Use this API in collaboration with the Selling Partner API for Product Type Definitions, which you use to retrieve the information about Amazon product types needed to use the Listings Items API.  For more information, see the [Listings Items API Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/listings-items-api-v2021-08-01-use-case-guide).
 *
 * OpenAPI spec version: 2021-08-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.ListingsItems
{
    /// <summary>
    /// Selling partner listings items and search related metadata.
    /// </summary>
    [DataContract]
    public partial class ItemSearchResults :  IEquatable<ItemSearchResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSearchResults" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemSearchResults() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSearchResults" /> class.
        /// </summary>
        /// <param name="numberOfResults">The total number of selling partner listings items found for the search criteria (only results up to the page count limit will be returned per request regardless of the number found).  Note: The maximum number of items (SKUs) that can be returned and paged through is 1000. (required).</param>
        /// <param name="pagination">If available, the &#x60;nextToken&#x60; and/or &#x60;previousToken&#x60; values required to return paginated results..</param>
        /// <param name="items">A list of listings items. (required).</param>
        public ItemSearchResults(int? numberOfResults = default(int?), Pagination pagination = default(Pagination), List<Item> items = default(List<Item>))
        {
            // to ensure "numberOfResults" is required (not null)
            if (numberOfResults == null)
            {
                throw new InvalidDataException("numberOfResults is a required property for ItemSearchResults and cannot be null");
            }
            else
            {
                this.NumberOfResults = numberOfResults;
            }
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new InvalidDataException("items is a required property for ItemSearchResults and cannot be null");
            }
            else
            {
                this.Items = items;
            }
            this.Pagination = pagination;
        }
        
        /// <summary>
        /// The total number of selling partner listings items found for the search criteria (only results up to the page count limit will be returned per request regardless of the number found).  Note: The maximum number of items (SKUs) that can be returned and paged through is 1000.
        /// </summary>
        /// <value>The total number of selling partner listings items found for the search criteria (only results up to the page count limit will be returned per request regardless of the number found).  Note: The maximum number of items (SKUs) that can be returned and paged through is 1000.</value>
        [DataMember(Name="numberOfResults", EmitDefaultValue=false)]
        public int? NumberOfResults { get; set; }

        /// <summary>
        /// If available, the &#x60;nextToken&#x60; and/or &#x60;previousToken&#x60; values required to return paginated results.
        /// </summary>
        /// <value>If available, the &#x60;nextToken&#x60; and/or &#x60;previousToken&#x60; values required to return paginated results.</value>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// A list of listings items.
        /// </summary>
        /// <value>A list of listings items.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<Item> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemSearchResults {\n");
            sb.Append("  NumberOfResults: ").Append(NumberOfResults).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as ItemSearchResults);
        }

        /// <summary>
        /// Returns true if ItemSearchResults instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemSearchResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemSearchResults input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumberOfResults == input.NumberOfResults ||
                    (this.NumberOfResults != null &&
                    this.NumberOfResults.Equals(input.NumberOfResults))
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.NumberOfResults != null)
                    hashCode = hashCode * 59 + this.NumberOfResults.GetHashCode();
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
