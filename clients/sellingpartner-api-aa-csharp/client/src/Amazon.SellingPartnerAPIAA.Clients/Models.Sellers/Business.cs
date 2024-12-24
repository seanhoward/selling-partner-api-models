/* 
 * The Selling Partner API for Sellers
 *
 * The Selling Partner API for Sellers lets you retrieve information on behalf of sellers about their seller account, such as the marketplaces they participate in. Along with listing the marketplaces that a seller can sell in, the API also provides additional information about the marketplace such as the default language and the default currency. The API also provides seller-specific information such as whether the seller has suspended listings in that marketplace.
 *
 * OpenAPI spec version: v1
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Sellers
{
    /// <summary>
    /// Information about the Seller&#39;s business. These fields may be omitted if the Seller is registered as an individual.
    /// </summary>
    [DataContract]
    public partial class Business :  IEquatable<Business>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Business" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Business() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Business" /> class.
        /// </summary>
        /// <param name="name">The registered business name. (required).</param>
        /// <param name="registeredBusinessAddress">The registered business address. (required).</param>
        /// <param name="companyRegistrationNumber">The seller&#39;s company registration number, if applicable. This field will be absent for individual sellers and sole proprietorships..</param>
        /// <param name="companyTaxIdentificationNumber">The seller&#39;s company tax identification number, if applicable. This field will be present for certain business types only, such as sole proprietorships..</param>
        /// <param name="nonLatinName">The non-Latin script version of the registered business name, if applicable..</param>
        public Business(string name = default(string), Address registeredBusinessAddress = default(Address), string companyRegistrationNumber = default(string), string companyTaxIdentificationNumber = default(string), string nonLatinName = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Business and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "registeredBusinessAddress" is required (not null)
            if (registeredBusinessAddress == null)
            {
                throw new InvalidDataException("registeredBusinessAddress is a required property for Business and cannot be null");
            }
            else
            {
                this.RegisteredBusinessAddress = registeredBusinessAddress;
            }
            this.CompanyRegistrationNumber = companyRegistrationNumber;
            this.CompanyTaxIdentificationNumber = companyTaxIdentificationNumber;
            this.NonLatinName = nonLatinName;
        }
        
        /// <summary>
        /// The registered business name.
        /// </summary>
        /// <value>The registered business name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The registered business address.
        /// </summary>
        /// <value>The registered business address.</value>
        [DataMember(Name="registeredBusinessAddress", EmitDefaultValue=false)]
        public Address RegisteredBusinessAddress { get; set; }

        /// <summary>
        /// The seller&#39;s company registration number, if applicable. This field will be absent for individual sellers and sole proprietorships.
        /// </summary>
        /// <value>The seller&#39;s company registration number, if applicable. This field will be absent for individual sellers and sole proprietorships.</value>
        [DataMember(Name="companyRegistrationNumber", EmitDefaultValue=false)]
        public string CompanyRegistrationNumber { get; set; }

        /// <summary>
        /// The seller&#39;s company tax identification number, if applicable. This field will be present for certain business types only, such as sole proprietorships.
        /// </summary>
        /// <value>The seller&#39;s company tax identification number, if applicable. This field will be present for certain business types only, such as sole proprietorships.</value>
        [DataMember(Name="companyTaxIdentificationNumber", EmitDefaultValue=false)]
        public string CompanyTaxIdentificationNumber { get; set; }

        /// <summary>
        /// The non-Latin script version of the registered business name, if applicable.
        /// </summary>
        /// <value>The non-Latin script version of the registered business name, if applicable.</value>
        [DataMember(Name="nonLatinName", EmitDefaultValue=false)]
        public string NonLatinName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Business {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RegisteredBusinessAddress: ").Append(RegisteredBusinessAddress).Append("\n");
            sb.Append("  CompanyRegistrationNumber: ").Append(CompanyRegistrationNumber).Append("\n");
            sb.Append("  CompanyTaxIdentificationNumber: ").Append(CompanyTaxIdentificationNumber).Append("\n");
            sb.Append("  NonLatinName: ").Append(NonLatinName).Append("\n");
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
            return this.Equals(input as Business);
        }

        /// <summary>
        /// Returns true if Business instances are equal
        /// </summary>
        /// <param name="input">Instance of Business to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Business input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RegisteredBusinessAddress == input.RegisteredBusinessAddress ||
                    (this.RegisteredBusinessAddress != null &&
                    this.RegisteredBusinessAddress.Equals(input.RegisteredBusinessAddress))
                ) && 
                (
                    this.CompanyRegistrationNumber == input.CompanyRegistrationNumber ||
                    (this.CompanyRegistrationNumber != null &&
                    this.CompanyRegistrationNumber.Equals(input.CompanyRegistrationNumber))
                ) && 
                (
                    this.CompanyTaxIdentificationNumber == input.CompanyTaxIdentificationNumber ||
                    (this.CompanyTaxIdentificationNumber != null &&
                    this.CompanyTaxIdentificationNumber.Equals(input.CompanyTaxIdentificationNumber))
                ) && 
                (
                    this.NonLatinName == input.NonLatinName ||
                    (this.NonLatinName != null &&
                    this.NonLatinName.Equals(input.NonLatinName))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RegisteredBusinessAddress != null)
                    hashCode = hashCode * 59 + this.RegisteredBusinessAddress.GetHashCode();
                if (this.CompanyRegistrationNumber != null)
                    hashCode = hashCode * 59 + this.CompanyRegistrationNumber.GetHashCode();
                if (this.CompanyTaxIdentificationNumber != null)
                    hashCode = hashCode * 59 + this.CompanyTaxIdentificationNumber.GetHashCode();
                if (this.NonLatinName != null)
                    hashCode = hashCode * 59 + this.NonLatinName.GetHashCode();
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