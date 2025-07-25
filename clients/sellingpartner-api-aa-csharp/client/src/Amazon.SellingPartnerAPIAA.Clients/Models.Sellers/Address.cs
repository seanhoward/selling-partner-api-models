/* 
 * The Selling Partner API for Sellers
 *
 * The [Selling Partner API for Sellers](https://developer-docs.amazon.com/sp-api/docs/sellers-api-v1-reference) (Sellers API) provides essential information about seller accounts, such as:  - The marketplaces a seller can list in - The default language and currency of a marketplace - Whether the seller has suspended listings  Refer to the [Sellers API reference](https://developer-docs.amazon.com/sp-api/docs/sellers-api-v1-reference) for details about this API's operations, data types, and schemas.
 *
 * OpenAPI spec version: v1
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Sellers
{
    /// <summary>
    /// Represents an address
    /// </summary>
    [DataContract]
    public partial class Address : IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructor]
        protected Address() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="addressLine1">Street address information. (required).</param>
        /// <param name="addressLine2">Additional street address information..</param>
        /// <param name="countryCode">The country code in two-character ISO 3166-1 alpha-2 format. (required).</param>
        /// <param name="stateOrProvinceCode">The state or province code..</param>
        /// <param name="city">The city..</param>
        /// <param name="postalCode">The postal code..</param>
        public Address(string addressLine1 = default, string addressLine2 = default, string countryCode = default, string stateOrProvinceCode = default, string city = default, string postalCode = default)
        {
            // to ensure "addressLine1" is required (not null)
            if (addressLine1 == null)
            {
                throw new InvalidDataException("addressLine1 is a required property for Address and cannot be null");
            }
            else
            {
                this.AddressLine1 = addressLine1;
            }
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new InvalidDataException("countryCode is a required property for Address and cannot be null");
            }
            else
            {
                this.CountryCode = countryCode;
            }
            this.AddressLine2 = addressLine2;
            this.StateOrProvinceCode = stateOrProvinceCode;
            this.City = city;
            this.PostalCode = postalCode;
        }

        /// <summary>
        /// Street address information.
        /// </summary>
        /// <value>Street address information.</value>
        [DataMember(Name = "addressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Additional street address information.
        /// </summary>
        /// <value>Additional street address information.</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The country code in two-character ISO 3166-1 alpha-2 format.
        /// </summary>
        /// <value>The country code in two-character ISO 3166-1 alpha-2 format.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The state or province code.
        /// </summary>
        /// <value>The state or province code.</value>
        [DataMember(Name = "stateOrProvinceCode", EmitDefaultValue = false)]
        public string StateOrProvinceCode { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        /// <value>The city.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The postal code.
        /// </summary>
        /// <value>The postal code.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  StateOrProvinceCode: ").Append(StateOrProvinceCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) &&
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) &&
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) &&
                (
                    this.StateOrProvinceCode == input.StateOrProvinceCode ||
                    (this.StateOrProvinceCode != null &&
                    this.StateOrProvinceCode.Equals(input.StateOrProvinceCode))
                ) &&
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) &&
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
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
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.StateOrProvinceCode != null)
                    hashCode = hashCode * 59 + this.StateOrProvinceCode.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
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
