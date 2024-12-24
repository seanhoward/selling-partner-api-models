/* 
 * Selling Partner API for FBA Inventory
 *
 * The Selling Partner API for FBA Inventory lets you programmatically retrieve information about inventory in Amazon's fulfillment network.
 *
 * OpenAPI spec version: v1
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FbaInventory
{
    /// <summary>
    /// An item to be created in the inventory.
    /// </summary>
    [DataContract]
    public partial class CreateInventoryItemRequest :  IEquatable<CreateInventoryItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInventoryItemRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateInventoryItemRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInventoryItemRequest" /> class.
        /// </summary>
        /// <param name="sellerSku">The seller SKU of the item. (required).</param>
        /// <param name="marketplaceId">The marketplaceId. (required).</param>
        /// <param name="productName">The name of the item. (required).</param>
        public CreateInventoryItemRequest(string sellerSku = default(string), string marketplaceId = default(string), string productName = default(string))
        {
            // to ensure "sellerSku" is required (not null)
            if (sellerSku == null)
            {
                throw new InvalidDataException("sellerSku is a required property for CreateInventoryItemRequest and cannot be null");
            }
            else
            {
                this.SellerSku = sellerSku;
            }
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for CreateInventoryItemRequest and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            // to ensure "productName" is required (not null)
            if (productName == null)
            {
                throw new InvalidDataException("productName is a required property for CreateInventoryItemRequest and cannot be null");
            }
            else
            {
                this.ProductName = productName;
            }
        }
        
        /// <summary>
        /// The seller SKU of the item.
        /// </summary>
        /// <value>The seller SKU of the item.</value>
        [DataMember(Name="sellerSku", EmitDefaultValue=false)]
        public string SellerSku { get; set; }

        /// <summary>
        /// The marketplaceId.
        /// </summary>
        /// <value>The marketplaceId.</value>
        [DataMember(Name="marketplaceId", EmitDefaultValue=false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        /// <value>The name of the item.</value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInventoryItemRequest {\n");
            sb.Append("  SellerSku: ").Append(SellerSku).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
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
            return this.Equals(input as CreateInventoryItemRequest);
        }

        /// <summary>
        /// Returns true if CreateInventoryItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateInventoryItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateInventoryItemRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SellerSku == input.SellerSku ||
                    (this.SellerSku != null &&
                    this.SellerSku.Equals(input.SellerSku))
                ) && 
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
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
                if (this.SellerSku != null)
                    hashCode = hashCode * 59 + this.SellerSku.GetHashCode();
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.ProductName != null)
                    hashCode = hashCode * 59 + this.ProductName.GetHashCode();
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
