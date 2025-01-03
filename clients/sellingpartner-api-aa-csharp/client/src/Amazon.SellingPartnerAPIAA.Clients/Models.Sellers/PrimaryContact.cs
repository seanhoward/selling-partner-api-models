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
    /// Information about the seller&#39;s primary contact.
    /// </summary>
    [DataContract]
    public partial class PrimaryContact :  IEquatable<PrimaryContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PrimaryContact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryContact" /> class.
        /// </summary>
        /// <param name="name">The full name of the seller&#39;s primary contact. (required).</param>
        /// <param name="address">The primary contact&#39;s residential address. (required).</param>
        /// <param name="nonLatinName">The non-Latin script version of the primary contact&#39;s name, if applicable..</param>
        public PrimaryContact(string name = default(string), Address address = default(Address), string nonLatinName = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PrimaryContact and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for PrimaryContact and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            this.NonLatinName = nonLatinName;
        }
        
        /// <summary>
        /// The full name of the seller&#39;s primary contact.
        /// </summary>
        /// <value>The full name of the seller&#39;s primary contact.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The primary contact&#39;s residential address.
        /// </summary>
        /// <value>The primary contact&#39;s residential address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address Address { get; set; }

        /// <summary>
        /// The non-Latin script version of the primary contact&#39;s name, if applicable.
        /// </summary>
        /// <value>The non-Latin script version of the primary contact&#39;s name, if applicable.</value>
        [DataMember(Name="nonLatinName", EmitDefaultValue=false)]
        public string NonLatinName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrimaryContact {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as PrimaryContact);
        }

        /// <summary>
        /// Returns true if PrimaryContact instances are equal
        /// </summary>
        /// <param name="input">Instance of PrimaryContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrimaryContact input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
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
