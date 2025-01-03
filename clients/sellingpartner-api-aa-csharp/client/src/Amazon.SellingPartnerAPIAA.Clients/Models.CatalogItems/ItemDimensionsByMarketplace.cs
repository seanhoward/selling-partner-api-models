/* 
 * Catalog Items v2022-04-01
 *
 * The Selling Partner API for Catalog Items provides programmatic access to information about items in the Amazon catalog.  For more information, refer to the [Catalog Items API Use Case Guide](doc:catalog-items-api-v2022-04-01-use-case-guide).
 *
 * OpenAPI spec version: 2022-04-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.CatalogItems
{
    /// <summary>
    /// Dimensions associated with the item in the Amazon catalog for the indicated Amazon marketplace.
    /// </summary>
    [DataContract]
    public partial class ItemDimensionsByMarketplace :  IEquatable<ItemDimensionsByMarketplace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDimensionsByMarketplace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemDimensionsByMarketplace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDimensionsByMarketplace" /> class.
        /// </summary>
        /// <param name="marketplaceId">Amazon marketplace identifier. (required).</param>
        /// <param name="item">Dimensions of an Amazon catalog item..</param>
        /// <param name="package">Dimensions of an Amazon catalog item in its packaging..</param>
        public ItemDimensionsByMarketplace(string marketplaceId = default(string), Dimensions item = default(Dimensions), Dimensions package = default(Dimensions))
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
        /// Amazon marketplace identifier.
        /// </summary>
        /// <value>Amazon marketplace identifier.</value>
        [DataMember(Name="marketplaceId", EmitDefaultValue=false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Dimensions of an Amazon catalog item.
        /// </summary>
        /// <value>Dimensions of an Amazon catalog item.</value>
        [DataMember(Name="item", EmitDefaultValue=false)]
        public Dimensions Item { get; set; }

        /// <summary>
        /// Dimensions of an Amazon catalog item in its packaging.
        /// </summary>
        /// <value>Dimensions of an Amazon catalog item in its packaging.</value>
        [DataMember(Name="package", EmitDefaultValue=false)]
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
