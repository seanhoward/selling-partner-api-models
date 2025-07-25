/* 
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: 2020-07-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// The request body schema for the getDeliveryOffers operation.
    /// </summary>
    [DataContract]
    public partial class GetDeliveryOffersRequest : IEquatable<GetDeliveryOffersRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeliveryOffersRequest" /> class.
        /// </summary>
        [JsonConstructor]
        protected GetDeliveryOffersRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeliveryOffersRequest" /> class.
        /// </summary>
        /// <param name="product">The product details for the delivery offer. (required).</param>
        /// <param name="terms">The terms for the delivery offer. (required).</param>
        public GetDeliveryOffersRequest(GetDeliveryOffersProduct product = default, GetDeliveryOffersTerms terms = default)
        {
            // to ensure "product" is required (not null)
            if (product == null)
            {
                throw new InvalidDataException("product is a required property for GetDeliveryOffersRequest and cannot be null");
            }
            else
            {
                this.Product = product;
            }
            // to ensure "terms" is required (not null)
            if (terms == null)
            {
                throw new InvalidDataException("terms is a required property for GetDeliveryOffersRequest and cannot be null");
            }
            else
            {
                this.Terms = terms;
            }
        }

        /// <summary>
        /// The product details for the delivery offer.
        /// </summary>
        /// <value>The product details for the delivery offer.</value>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public GetDeliveryOffersProduct Product { get; set; }

        /// <summary>
        /// The terms for the delivery offer.
        /// </summary>
        /// <value>The terms for the delivery offer.</value>
        [DataMember(Name = "terms", EmitDefaultValue = false)]
        public GetDeliveryOffersTerms Terms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDeliveryOffersRequest {\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
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
            return this.Equals(input as GetDeliveryOffersRequest);
        }

        /// <summary>
        /// Returns true if GetDeliveryOffersRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDeliveryOffersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDeliveryOffersRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) &&
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
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
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
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
