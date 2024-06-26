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
    /// BatchOffersRequestParams
    /// </summary>
    [DataContract]
    public partial class BatchOffersRequestParams :  IEquatable<BatchOffersRequestParams>, IValidatableObject
    {
        /// <summary>
        /// Filters the offer listings to be considered based on item condition. Possible values: New, Used, Collectible, Refurbished, Club.
        /// </summary>
        /// <value>Filters the offer listings to be considered based on item condition. Possible values: New, Used, Collectible, Refurbished, Club.</value>
        [DataMember(Name="ItemCondition", EmitDefaultValue=false)]
        public ItemCondition ItemCondition { get; set; }
        /// <summary>
        /// Indicates whether to request Consumer or Business offers. Default is Consumer.
        /// </summary>
        /// <value>Indicates whether to request Consumer or Business offers. Default is Consumer.</value>
        [DataMember(Name="CustomerType", EmitDefaultValue=false)]
        public CustomerType? CustomerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchOffersRequestParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchOffersRequestParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchOffersRequestParams" /> class.
        /// </summary>
        /// <param name="marketplaceId">marketplaceId (required).</param>
        /// <param name="itemCondition">Filters the offer listings to be considered based on item condition. Possible values: New, Used, Collectible, Refurbished, Club. (required).</param>
        /// <param name="customerType">Indicates whether to request Consumer or Business offers. Default is Consumer..</param>
        public BatchOffersRequestParams(string marketplaceId = default(string), ItemCondition itemCondition = default(ItemCondition), CustomerType? customerType = default(CustomerType?))
        {
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for BatchOffersRequestParams and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            // to ensure "itemCondition" is required (not null)
            if (itemCondition == null)
            {
                throw new InvalidDataException("itemCondition is a required property for BatchOffersRequestParams and cannot be null");
            }
            else
            {
                this.ItemCondition = itemCondition;
            }
            this.CustomerType = customerType;
        }
        
        /// <summary>
        /// Gets or Sets MarketplaceId
        /// </summary>
        [DataMember(Name="MarketplaceId", EmitDefaultValue=false)]
        public string MarketplaceId { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchOffersRequestParams {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  ItemCondition: ").Append(ItemCondition).Append("\n");
            sb.Append("  CustomerType: ").Append(CustomerType).Append("\n");
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
            return this.Equals(input as BatchOffersRequestParams);
        }

        /// <summary>
        /// Returns true if BatchOffersRequestParams instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchOffersRequestParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchOffersRequestParams input)
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
                    this.ItemCondition == input.ItemCondition ||
                    (this.ItemCondition != null &&
                    this.ItemCondition.Equals(input.ItemCondition))
                ) && 
                (
                    this.CustomerType == input.CustomerType ||
                    (this.CustomerType != null &&
                    this.CustomerType.Equals(input.CustomerType))
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
                if (this.ItemCondition != null)
                    hashCode = hashCode * 59 + this.ItemCondition.GetHashCode();
                if (this.CustomerType != null)
                    hashCode = hashCode * 59 + this.CustomerType.GetHashCode();
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
