/* 
 * Selling Partner API for Catalog Items
 *
 * Use the Selling Partner API for Catalog Items to retrieve information about items in the Amazon catalog.  For more information, refer to the [Catalog Items API Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/:catalog-items-api-v2022-04-01-use-case-guide).
 *
 * OpenAPI spec version: 2022-04-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.CatalogItems
{
    /// <summary>
    /// Dimensions that are associated with the item in the Amazon catalog for the indicated &#x60;marketplaceId&#x60;.
    /// </summary>
    [DataContract]
    public partial class ItemDimensionsByMarketplace : IEquatable<ItemDimensionsByMarketplace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDimensionsByMarketplace" /> class.
        /// </summary>
        [JsonConstructor]
        protected ItemDimensionsByMarketplace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDimensionsByMarketplace" /> class.
        /// </summary>
        /// <param name="marketplaceId">Amazon marketplace identifier. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). (required).</param>
        /// <param name="item">Dimensions of an Amazon catalog item..</param>
        /// <param name="package">Dimensions of a package that contains an Amazon catalog item..</param>
        public ItemDimensionsByMarketplace(string marketplaceId = default, Dimensions item = default, Dimensions package = default)
        {
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for ItemDimensionsByMarketplace and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            this.Item = item;
            this.Package = package;
        }

        /// <summary>
        /// Amazon marketplace identifier. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
        /// </summary>
        /// <value>Amazon marketplace identifier. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).</value>
        [DataMember(Name = "marketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Dimensions of an Amazon catalog item.
        /// </summary>
        /// <value>Dimensions of an Amazon catalog item.</value>
        [DataMember(Name = "item", EmitDefaultValue = false)]
        public Dimensions Item { get; set; }

        /// <summary>
        /// Dimensions of a package that contains an Amazon catalog item.
        /// </summary>
        /// <value>Dimensions of a package that contains an Amazon catalog item.</value>
        [DataMember(Name = "package", EmitDefaultValue = false)]
        public Dimensions Package { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemDimensionsByMarketplace {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Package: ").Append(Package).Append("\n");
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
            return this.Equals(input as ItemDimensionsByMarketplace);
        }

        /// <summary>
        /// Returns true if ItemDimensionsByMarketplace instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemDimensionsByMarketplace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemDimensionsByMarketplace input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
                ) &&
                (
                    this.Package == input.Package ||
                    (this.Package != null &&
                    this.Package.Equals(input.Package))
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
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.Item != null)
                    hashCode = hashCode * 59 + this.Item.GetHashCode();
                if (this.Package != null)
                    hashCode = hashCode * 59 + this.Package.GetHashCode();
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
