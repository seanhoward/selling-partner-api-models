/* 
 * Selling Partner API for Product Type Definitions
 *
 * The Selling Partner API for Product Type Definitions provides programmatic access to attribute and data requirements for product types in the Amazon catalog. Use this API to return the JSON Schema for a product type that you can then use with other Selling Partner APIs, such as the Selling Partner API for Listings Items, the Selling Partner API for Catalog Items, and the Selling Partner API for Feeds (for JSON-based listing feeds).  For more information, see the [Product Type Definitions API Use Case Guide](doc:product-type-api-use-case-guide).
 *
 * OpenAPI spec version: 2020-09-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.DefinitionsProductTypes
{
    /// <summary>
    /// A list of Amazon product types with definitions available.
    /// </summary>
    [DataContract]
    public partial class ProductTypeList :  IEquatable<ProductTypeList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductTypeList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductTypeList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductTypeList" /> class.
        /// </summary>
        /// <param name="productTypes">productTypes (required).</param>
        /// <param name="productTypeVersion">Amazon product type version identifier. (required).</param>
        public ProductTypeList(List<ProductType> productTypes = default(List<ProductType>), string productTypeVersion = default(string))
        {
            // to ensure "productTypes" is required (not null)
            if (productTypes == null)
            {
                throw new InvalidDataException("productTypes is a required property for ProductTypeList and cannot be null");
            }
            else
            {
                this.ProductTypes = productTypes;
            }
            // to ensure "productTypeVersion" is required (not null)
            if (productTypeVersion == null)
            {
                throw new InvalidDataException("productTypeVersion is a required property for ProductTypeList and cannot be null");
            }
            else
            {
                this.ProductTypeVersion = productTypeVersion;
            }
        }
        
        /// <summary>
        /// Gets or Sets ProductTypes
        /// </summary>
        [DataMember(Name="productTypes", EmitDefaultValue=false)]
        public List<ProductType> ProductTypes { get; set; }

        /// <summary>
        /// Amazon product type version identifier.
        /// </summary>
        /// <value>Amazon product type version identifier.</value>
        [DataMember(Name="productTypeVersion", EmitDefaultValue=false)]
        public string ProductTypeVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductTypeList {\n");
            sb.Append("  ProductTypes: ").Append(ProductTypes).Append("\n");
            sb.Append("  ProductTypeVersion: ").Append(ProductTypeVersion).Append("\n");
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
            return this.Equals(input as ProductTypeList);
        }

        /// <summary>
        /// Returns true if ProductTypeList instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductTypeList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductTypeList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductTypes == input.ProductTypes ||
                    this.ProductTypes != null &&
                    this.ProductTypes.SequenceEqual(input.ProductTypes)
                ) && 
                (
                    this.ProductTypeVersion == input.ProductTypeVersion ||
                    (this.ProductTypeVersion != null &&
                    this.ProductTypeVersion.Equals(input.ProductTypeVersion))
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
                if (this.ProductTypes != null)
                    hashCode = hashCode * 59 + this.ProductTypes.GetHashCode();
                if (this.ProductTypeVersion != null)
                    hashCode = hashCode * 59 + this.ProductTypeVersion.GetHashCode();
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