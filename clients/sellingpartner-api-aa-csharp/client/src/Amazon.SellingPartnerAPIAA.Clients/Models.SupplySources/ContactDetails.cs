/* 
 * Selling Partner API for Supply Sources
 *
 * Manage configurations and capabilities of seller supply sources.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources
{
    /// <summary>
    /// The contact details
    /// </summary>
    [DataContract]
    public partial class ContactDetails :  IEquatable<ContactDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDetails" /> class.
        /// </summary>
        /// <param name="primary">primary.</param>
        public ContactDetails(ContactDetailsPrimary primary = default(ContactDetailsPrimary))
        {
            this.Primary = primary;
        }
        
        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public ContactDetailsPrimary Primary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactDetails {\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
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
            return this.Equals(input as ContactDetails);
        }

        /// <summary>
        /// Returns true if ContactDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Primary == input.Primary ||
                    (this.Primary != null &&
                    this.Primary.Equals(input.Primary))
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
                if (this.Primary != null)
                    hashCode = hashCode * 59 + this.Primary.GetHashCode();
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