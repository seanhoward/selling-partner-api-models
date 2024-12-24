/* 
 * The Selling Partner API for Amazon Warehousing and Distribution
 *
 * The Selling Partner API for Amazon Warehousing and Distribution (AWD) provides programmatic access to information about AWD shipments and inventory. 
 *
 * OpenAPI spec version: 2024-05-09
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Awd
{
    /// <summary>
    /// AWD inventory payload.
    /// </summary>
    [DataContract]
    public partial class InventoryListing :  IEquatable<InventoryListing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryListing" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InventoryListing() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryListing" /> class.
        /// </summary>
        /// <param name="inventory">List of inventory summaries. (required).</param>
        /// <param name="nextToken">A token that is used to retrieve the next page of results. The response includes &#x60;nextToken&#x60; when the number of results exceeds the specified &#x60;maxResults&#x60; value. To get the next page of results, call the operation with this token and include the same arguments as the call that produced the token. To get a complete list, call this operation until &#x60;nextToken&#x60; is null. Note that this operation can return empty pages..</param>
        public InventoryListing(List<InventorySummary> inventory = default(List<InventorySummary>), string nextToken = default(string))
        {
            // to ensure "inventory" is required (not null)
            if (inventory == null)
            {
                throw new InvalidDataException("inventory is a required property for InventoryListing and cannot be null");
            }
            else
            {
                this.Inventory = inventory;
            }
            this.NextToken = nextToken;
        }
        
        /// <summary>
        /// List of inventory summaries.
        /// </summary>
        /// <value>List of inventory summaries.</value>
        [DataMember(Name="inventory", EmitDefaultValue=false)]
        public List<InventorySummary> Inventory { get; set; }

        /// <summary>
        /// A token that is used to retrieve the next page of results. The response includes &#x60;nextToken&#x60; when the number of results exceeds the specified &#x60;maxResults&#x60; value. To get the next page of results, call the operation with this token and include the same arguments as the call that produced the token. To get a complete list, call this operation until &#x60;nextToken&#x60; is null. Note that this operation can return empty pages.
        /// </summary>
        /// <value>A token that is used to retrieve the next page of results. The response includes &#x60;nextToken&#x60; when the number of results exceeds the specified &#x60;maxResults&#x60; value. To get the next page of results, call the operation with this token and include the same arguments as the call that produced the token. To get a complete list, call this operation until &#x60;nextToken&#x60; is null. Note that this operation can return empty pages.</value>
        [DataMember(Name="nextToken", EmitDefaultValue=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryListing {\n");
            sb.Append("  Inventory: ").Append(Inventory).Append("\n");
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
            return this.Equals(input as InventoryListing);
        }

        /// <summary>
        /// Returns true if InventoryListing instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryListing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Inventory == input.Inventory ||
                    this.Inventory != null &&
                    this.Inventory.SequenceEqual(input.Inventory)
                ) && 
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
                if (this.Inventory != null)
                    hashCode = hashCode * 59 + this.Inventory.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
