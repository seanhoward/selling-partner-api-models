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
    /// Represents a product with the SKU details and the corresponding quantity.
    /// </summary>
    [DataContract]
    public partial class ProductQuantity :  IEquatable<ProductQuantity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductQuantity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductQuantity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductQuantity" /> class.
        /// </summary>
        /// <param name="attributes">Attributes for this instance of the product. For example, already-prepped, or other attributes that distinguish the product beyond the SKU..</param>
        /// <param name="quantity">Product quantity. (required).</param>
        /// <param name="sku">The seller or merchant SKU. (required).</param>
        /// <param name="expiration">The expiration date for the SKU. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format..</param>
        /// <param name="prepDetails">Preparation details of a product which contains the prep category, prep owner and the label owner. If not passed while creating an inbound order, NO_PREP will be used on the product by-default. Prep instructions will be generated based on the category passed.</param>
        public ProductQuantity(List<ProductAttribute> attributes = default(List<ProductAttribute>), int? quantity = default(int?), string sku = default(string), DateTime? expiration = default(DateTime?), PrepDetails prepDetails = default(PrepDetails))
        {
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for ProductQuantity and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            // to ensure "sku" is required (not null)
            if (sku == null)
            {
                throw new InvalidDataException("sku is a required property for ProductQuantity and cannot be null");
            }
            else
            {
                this.Sku = sku;
            }
            this.Attributes = attributes;
            this.Expiration = expiration;
            this.PrepDetails = prepDetails;
        }
        
        /// <summary>
        /// Attributes for this instance of the product. For example, already-prepped, or other attributes that distinguish the product beyond the SKU.
        /// </summary>
        /// <value>Attributes for this instance of the product. For example, already-prepped, or other attributes that distinguish the product beyond the SKU.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<ProductAttribute> Attributes { get; set; }

        /// <summary>
        /// Product quantity.
        /// </summary>
        /// <value>Product quantity.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// The seller or merchant SKU.
        /// </summary>
        /// <value>The seller or merchant SKU.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// The expiration date for the SKU. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.
        /// </summary>
        /// <value>The expiration date for the SKU. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// Preparation details of a product which contains the prep category, prep owner and the label owner. If not passed while creating an inbound order, NO_PREP will be used on the product by-default. Prep instructions will be generated based on the category passed
        /// </summary>
        /// <value>Preparation details of a product which contains the prep category, prep owner and the label owner. If not passed while creating an inbound order, NO_PREP will be used on the product by-default. Prep instructions will be generated based on the category passed</value>
        [DataMember(Name="prepDetails", EmitDefaultValue=false)]
        public PrepDetails PrepDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductQuantity {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  PrepDetails: ").Append(PrepDetails).Append("\n");
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
            return this.Equals(input as ProductQuantity);
        }

        /// <summary>
        /// Returns true if ProductQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductQuantity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && 
                (
                    this.PrepDetails == input.PrepDetails ||
                    (this.PrepDetails != null &&
                    this.PrepDetails.Equals(input.PrepDetails))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                if (this.PrepDetails != null)
                    hashCode = hashCode * 59 + this.PrepDetails.GetHashCode();
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
