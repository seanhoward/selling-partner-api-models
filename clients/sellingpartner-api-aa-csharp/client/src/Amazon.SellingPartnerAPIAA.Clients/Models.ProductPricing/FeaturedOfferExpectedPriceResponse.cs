/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer pricing information for Amazon Marketplace products.  For more information, refer to the [Product Pricing v2022-05-01 Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/product-pricing-api-v2022-05-01-use-case-guide).
 *
 * OpenAPI spec version: 2022-05-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.ProductPricing
{
    /// <summary>
    /// Schema for an individual FOEP response.
    /// </summary>
    [DataContract]
    public partial class FeaturedOfferExpectedPriceResponse : BatchResponse, IEquatable<FeaturedOfferExpectedPriceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturedOfferExpectedPriceResponse" /> class.
        /// </summary>
        [JsonConstructor]
        protected FeaturedOfferExpectedPriceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturedOfferExpectedPriceResponse" /> class.
        /// </summary>
        /// <param name="request">Use these request parameters to map the response back to the request. (required).</param>
        /// <param name="body">body.</param>
        public FeaturedOfferExpectedPriceResponse(FeaturedOfferExpectedPriceRequestParams request = default, FeaturedOfferExpectedPriceResponseBody body = default, HttpHeaders headers = default, HttpStatusLine status = default) : base(headers, status)
        {
            // to ensure "request" is required (not null)
            if (request == null)
            {
                throw new InvalidDataException("request is a required property for FeaturedOfferExpectedPriceResponse and cannot be null");
            }
            else
            {
                this.Request = request;
            }
            this.Body = body;
        }

        /// <summary>
        /// Use these request parameters to map the response back to the request.
        /// </summary>
        /// <value>Use these request parameters to map the response back to the request.</value>
        [DataMember(Name = "request", EmitDefaultValue = false)]
        public FeaturedOfferExpectedPriceRequestParams Request { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public FeaturedOfferExpectedPriceResponseBody Body { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeaturedOfferExpectedPriceResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(input as FeaturedOfferExpectedPriceResponse);
        }

        /// <summary>
        /// Returns true if FeaturedOfferExpectedPriceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FeaturedOfferExpectedPriceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeaturedOfferExpectedPriceResponse input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && base.Equals(input) &&
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
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
            //foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
