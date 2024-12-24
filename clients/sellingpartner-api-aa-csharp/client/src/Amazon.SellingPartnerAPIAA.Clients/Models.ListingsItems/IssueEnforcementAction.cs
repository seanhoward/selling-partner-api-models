/* 
 * Listings Items v2021-08-01
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
    /// The enforcement action taken by Amazon that affect the publishing or status of a listing
    /// </summary>
    [DataContract]
    public partial class IssueEnforcementAction :  IEquatable<IssueEnforcementAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEnforcementAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IssueEnforcementAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEnforcementAction" /> class.
        /// </summary>
        /// <param name="action">The enforcement action name.   Possible values:   * &#x60;LISTING_SUPPRESSED&#x60; - This enforcement takes down the current listing item&#39;s buyability.   * &#x60;ATTRIBUTE_SUPPRESSED&#x60; - An attribute&#39;s value on the listing item is invalid, which causes it to be rejected by Amazon.   * &#x60;CATALOG_ITEM_REMOVED&#x60; - This catalog item is inactive on Amazon, and all offers against it in the applicable marketplace are non-buyable.   * &#x60;SEARCH_SUPPRESSED&#x60; - This value indicates that the catalog item is hidden from search results. (required).</param>
        public IssueEnforcementAction(string action = default(string))
        {
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for IssueEnforcementAction and cannot be null");
            }
            else
            {
                this.Action = action;
            }
        }
        
        /// <summary>
        /// The enforcement action name.   Possible values:   * &#x60;LISTING_SUPPRESSED&#x60; - This enforcement takes down the current listing item&#39;s buyability.   * &#x60;ATTRIBUTE_SUPPRESSED&#x60; - An attribute&#39;s value on the listing item is invalid, which causes it to be rejected by Amazon.   * &#x60;CATALOG_ITEM_REMOVED&#x60; - This catalog item is inactive on Amazon, and all offers against it in the applicable marketplace are non-buyable.   * &#x60;SEARCH_SUPPRESSED&#x60; - This value indicates that the catalog item is hidden from search results.
        /// </summary>
        /// <value>The enforcement action name.   Possible values:   * &#x60;LISTING_SUPPRESSED&#x60; - This enforcement takes down the current listing item&#39;s buyability.   * &#x60;ATTRIBUTE_SUPPRESSED&#x60; - An attribute&#39;s value on the listing item is invalid, which causes it to be rejected by Amazon.   * &#x60;CATALOG_ITEM_REMOVED&#x60; - This catalog item is inactive on Amazon, and all offers against it in the applicable marketplace are non-buyable.   * &#x60;SEARCH_SUPPRESSED&#x60; - This value indicates that the catalog item is hidden from search results.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueEnforcementAction {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(input as IssueEnforcementAction);
        }

        /// <summary>
        /// Returns true if IssueEnforcementAction instances are equal
        /// </summary>
        /// <param name="input">Instance of IssueEnforcementAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueEnforcementAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
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
