/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Pricing
{
    /// <summary>
    /// ListingOffersRequestParams
    /// </summary>
    [DataContract]
    public partial class ListingOffersRequestParams : BatchOffersRequestParams,  IEquatable<ListingOffersRequestParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingOffersRequestParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListingOffersRequestParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingOffersRequestParams" /> class.
        /// </summary>
        /// <param name="sellerSKU">The seller stock keeping unit (SKU) of the item. This is the same SKU passed as a path parameter. (required).</param>
        public ListingOffersRequestParams(string sellerSKU = default(string), string marketplaceId = default(string), ItemCondition itemCondition = default(ItemCondition), CustomerType? customerType = default(CustomerType?)) : base(marketplaceId, itemCondition, customerType)
        {
            // to ensure "sellerSKU" is required (not null)
            if (sellerSKU == null)
            {
                throw new InvalidDataException("sellerSKU is a required property for ListingOffersRequestParams and cannot be null");
            }
            else
            {
                this.SellerSKU = sellerSKU;
            }
        }
        
        /// <summary>
        /// The seller stock keeping unit (SKU) of the item. This is the same SKU passed as a path parameter.
        /// </summary>
        /// <value>The seller stock keeping unit (SKU) of the item. This is the same SKU passed as a path parameter.</value>
        [DataMember(Name="SellerSKU", EmitDefaultValue=false)]
        public string SellerSKU { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingOffersRequestParams {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  SellerSKU: ").Append(SellerSKU).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ListingOffersRequestParams);
        }

        /// <summary>
        /// Returns true if ListingOffersRequestParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingOffersRequestParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingOffersRequestParams input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.SellerSKU == input.SellerSKU ||
                    (this.SellerSKU != null &&
                    this.SellerSKU.Equals(input.SellerSKU))
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
                int hashCode = base.GetHashCode();
                if (this.SellerSKU != null)
                    hashCode = hashCode * 59 + this.SellerSKU.GetHashCode();
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
            //foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
