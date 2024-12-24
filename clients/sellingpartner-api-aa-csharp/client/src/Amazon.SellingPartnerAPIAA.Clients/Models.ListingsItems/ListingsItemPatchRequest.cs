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
    /// The request body schema for the &#x60;patchListingsItem&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class ListingsItemPatchRequest :  IEquatable<ListingsItemPatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingsItemPatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListingsItemPatchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingsItemPatchRequest" /> class.
        /// </summary>
        /// <param name="productType">The Amazon product type of the listings item. (required).</param>
        /// <param name="patches">One or more JSON Patch operations to perform on the listings item. (required).</param>
        public ListingsItemPatchRequest(string productType = default(string), List<PatchOperation> patches = default(List<PatchOperation>))
        {
            // to ensure "productType" is required (not null)
            if (productType == null)
            {
                throw new InvalidDataException("productType is a required property for ListingsItemPatchRequest and cannot be null");
            }
            else
            {
                this.ProductType = productType;
            }
            // to ensure "patches" is required (not null)
            if (patches == null)
            {
                throw new InvalidDataException("patches is a required property for ListingsItemPatchRequest and cannot be null");
            }
            else
            {
                this.Patches = patches;
            }
        }
        
        /// <summary>
        /// The Amazon product type of the listings item.
        /// </summary>
        /// <value>The Amazon product type of the listings item.</value>
        [DataMember(Name="productType", EmitDefaultValue=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// One or more JSON Patch operations to perform on the listings item.
        /// </summary>
        /// <value>One or more JSON Patch operations to perform on the listings item.</value>
        [DataMember(Name="patches", EmitDefaultValue=false)]
        public List<PatchOperation> Patches { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingsItemPatchRequest {\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  Patches: ").Append(Patches).Append("\n");
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
            return this.Equals(input as ListingsItemPatchRequest);
        }

        /// <summary>
        /// Returns true if ListingsItemPatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingsItemPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingsItemPatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductType == input.ProductType ||
                    (this.ProductType != null &&
                    this.ProductType.Equals(input.ProductType))
                ) && 
                (
                    this.Patches == input.Patches ||
                    this.Patches != null &&
                    this.Patches.SequenceEqual(input.Patches)
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
                if (this.ProductType != null)
                    hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.Patches != null)
                    hashCode = hashCode * 59 + this.Patches.GetHashCode();
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
