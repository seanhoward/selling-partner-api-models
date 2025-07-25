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
    /// An item in the Amazon catalog.
    /// </summary>
    [DataContract]
    public partial class Item : IEquatable<Item>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        [JsonConstructor]
        protected Item() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="asin">asin (required).</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="classifications">classifications.</param>
        /// <param name="dimensions">dimensions.</param>
        /// <param name="identifiers">identifiers.</param>
        /// <param name="images">images.</param>
        /// <param name="productTypes">productTypes.</param>
        /// <param name="relationships">relationships.</param>
        /// <param name="salesRanks">salesRanks.</param>
        /// <param name="summaries">summaries.</param>
        /// <param name="vendorDetails">vendorDetails.</param>
        public Item(string asin = default, Newtonsoft.Json.Linq.JObject attributes = default, ItemBrowseClassifications classifications = default, ItemDimensions dimensions = default, ItemIdentifiers identifiers = default, ItemImages images = default, ItemProductTypes productTypes = default, ItemRelationships relationships = default, ItemSalesRanks salesRanks = default, ItemSummaries summaries = default, ItemVendorDetails vendorDetails = default)
        {
            // to ensure "asin" is required (not null)
            if (asin == null)
            {
                throw new InvalidDataException("asin is a required property for Item and cannot be null");
            }
            else
            {
                this.Asin = asin;
            }
            this.Attributes = attributes;
            this.Classifications = classifications;
            this.Dimensions = dimensions;
            this.Identifiers = identifiers;
            this.Images = images;
            this.ProductTypes = productTypes;
            this.Relationships = relationships;
            this.SalesRanks = salesRanks;
            this.Summaries = summaries;
            this.VendorDetails = vendorDetails;
        }

        /// <summary>
        /// Gets or Sets Asin
        /// </summary>
        [DataMember(Name = "asin", EmitDefaultValue = false)]
        public string Asin { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public Newtonsoft.Json.Linq.JObject Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Classifications
        /// </summary>
        [DataMember(Name = "classifications", EmitDefaultValue = false)]
        public ItemBrowseClassifications Classifications { get; set; }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "dimensions", EmitDefaultValue = false)]
        public ItemDimensions Dimensions { get; set; }

        /// <summary>
        /// Gets or Sets Identifiers
        /// </summary>
        [DataMember(Name = "identifiers", EmitDefaultValue = false)]
        public ItemIdentifiers Identifiers { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public ItemImages Images { get; set; }

        /// <summary>
        /// Gets or Sets ProductTypes
        /// </summary>
        [DataMember(Name = "productTypes", EmitDefaultValue = false)]
        public ItemProductTypes ProductTypes { get; set; }

        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name = "relationships", EmitDefaultValue = false)]
        public ItemRelationships Relationships { get; set; }

        /// <summary>
        /// Gets or Sets SalesRanks
        /// </summary>
        [DataMember(Name = "salesRanks", EmitDefaultValue = false)]
        public ItemSalesRanks SalesRanks { get; set; }

        /// <summary>
        /// Gets or Sets Summaries
        /// </summary>
        [DataMember(Name = "summaries", EmitDefaultValue = false)]
        public ItemSummaries Summaries { get; set; }

        /// <summary>
        /// Gets or Sets VendorDetails
        /// </summary>
        [DataMember(Name = "vendorDetails", EmitDefaultValue = false)]
        public ItemVendorDetails VendorDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  Asin: ").Append(Asin).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Classifications: ").Append(Classifications).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  ProductTypes: ").Append(ProductTypes).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
            sb.Append("  SalesRanks: ").Append(SalesRanks).Append("\n");
            sb.Append("  Summaries: ").Append(Summaries).Append("\n");
            sb.Append("  VendorDetails: ").Append(VendorDetails).Append("\n");
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
            return this.Equals(input as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="input">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Asin == input.Asin ||
                    (this.Asin != null &&
                    this.Asin.Equals(input.Asin))
                ) &&
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) &&
                (
                    this.Classifications == input.Classifications ||
                    (this.Classifications != null &&
                    this.Classifications.Equals(input.Classifications))
                ) &&
                (
                    this.Dimensions == input.Dimensions ||
                    (this.Dimensions != null &&
                    this.Dimensions.Equals(input.Dimensions))
                ) &&
                (
                    this.Identifiers == input.Identifiers ||
                    (this.Identifiers != null &&
                    this.Identifiers.Equals(input.Identifiers))
                ) &&
                (
                    this.Images == input.Images ||
                    (this.Images != null &&
                    this.Images.Equals(input.Images))
                ) &&
                (
                    this.ProductTypes == input.ProductTypes ||
                    (this.ProductTypes != null &&
                    this.ProductTypes.Equals(input.ProductTypes))
                ) &&
                (
                    this.Relationships == input.Relationships ||
                    (this.Relationships != null &&
                    this.Relationships.Equals(input.Relationships))
                ) &&
                (
                    this.SalesRanks == input.SalesRanks ||
                    (this.SalesRanks != null &&
                    this.SalesRanks.Equals(input.SalesRanks))
                ) &&
                (
                    this.Summaries == input.Summaries ||
                    (this.Summaries != null &&
                    this.Summaries.Equals(input.Summaries))
                ) &&
                (
                    this.VendorDetails == input.VendorDetails ||
                    (this.VendorDetails != null &&
                    this.VendorDetails.Equals(input.VendorDetails))
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
                if (this.Asin != null)
                    hashCode = hashCode * 59 + this.Asin.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Classifications != null)
                    hashCode = hashCode * 59 + this.Classifications.GetHashCode();
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Identifiers != null)
                    hashCode = hashCode * 59 + this.Identifiers.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.ProductTypes != null)
                    hashCode = hashCode * 59 + this.ProductTypes.GetHashCode();
                if (this.Relationships != null)
                    hashCode = hashCode * 59 + this.Relationships.GetHashCode();
                if (this.SalesRanks != null)
                    hashCode = hashCode * 59 + this.SalesRanks.GetHashCode();
                if (this.Summaries != null)
                    hashCode = hashCode * 59 + this.Summaries.GetHashCode();
                if (this.VendorDetails != null)
                    hashCode = hashCode * 59 + this.VendorDetails.GetHashCode();
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
