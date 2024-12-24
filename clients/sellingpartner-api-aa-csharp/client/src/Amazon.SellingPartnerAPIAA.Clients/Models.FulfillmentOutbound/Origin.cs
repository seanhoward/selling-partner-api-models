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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// The origin for the delivery offer.
    /// </summary>
    [DataContract]
    public partial class Origin :  IEquatable<Origin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Origin" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Origin() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Origin" /> class.
        /// </summary>
        /// <param name="countryCode">The two digit country code the items should ship from. In ISO 3166-1 alpha-2 format. (required).</param>
        public Origin(string countryCode = default(string))
        {
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new InvalidDataException("countryCode is a required property for Origin and cannot be null");
            }
            else
            {
                this.CountryCode = countryCode;
            }
        }
        
        /// <summary>
        /// The two digit country code the items should ship from. In ISO 3166-1 alpha-2 format.
        /// </summary>
        /// <value>The two digit country code the items should ship from. In ISO 3166-1 alpha-2 format.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Origin {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            return this.Equals(input as Origin);
        }

        /// <summary>
        /// Returns true if Origin instances are equal
        /// </summary>
        /// <param name="input">Instance of Origin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Origin input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
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
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
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
            // CountryCode (string) maxLength
            if(this.CountryCode != null && this.CountryCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 2.", new [] { "CountryCode" });
            }

            // CountryCode (string) minLength
            if(this.CountryCode != null && this.CountryCode.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be greater than 2.", new [] { "CountryCode" });
            }

            yield break;
        }
    }

}
