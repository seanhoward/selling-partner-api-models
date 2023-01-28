/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Amazon.SellingPartnerAPIAA.Client.Model
{
    /// <summary>
    /// ListingOffersRequest
    /// </summary>
    [DataContract]
    public partial class ListingOffersRequest : BatchRequest, IEquatable<ListingOffersRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingOffersRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListingOffersRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingOffersRequest" /> class.
        /// </summary>
        /// <param name="marketplaceId">marketplaceId (required).</param>
        /// <param name="itemCondition">itemCondition (required).</param>
        /// <param name="customerType">customerType.</param>
        public ListingOffersRequest(string marketplaceId = default(string), ItemCondition itemCondition = default(ItemCondition), CustomerType customerType = default(CustomerType), string uri = default(string), HttpMethod method = default(HttpMethod), HttpRequestHeaders headers = default(HttpRequestHeaders)) : base(uri, method, headers)
        {
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for ListingOffersRequest and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            // to ensure "itemCondition" is required (not null)
            if (itemCondition == null)
            {
                throw new InvalidDataException("itemCondition is a required property for ListingOffersRequest and cannot be null");
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
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Gets or Sets ItemCondition
        /// </summary>
        [DataMember(Name = "ItemCondition", EmitDefaultValue = false)]
        public ItemCondition ItemCondition { get; set; }

        /// <summary>
        /// Gets or Sets CustomerType
        /// </summary>
        [DataMember(Name = "CustomerType", EmitDefaultValue = false)]
        public CustomerType CustomerType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingOffersRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            return this.Equals(input as ListingOffersRequest);
        }

        /// <summary>
        /// Returns true if ListingOffersRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingOffersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingOffersRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) && base.Equals(input) &&
                (
                    this.ItemCondition == input.ItemCondition ||
                    (this.ItemCondition != null &&
                    this.ItemCondition.Equals(input.ItemCondition))
                ) && base.Equals(input) &&
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
                int hashCode = base.GetHashCode();
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
            foreach (var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }

        private IEnumerable<ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            return results;
        }
    }

}