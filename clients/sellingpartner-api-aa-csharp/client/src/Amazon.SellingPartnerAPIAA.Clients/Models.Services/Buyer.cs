/* 
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders and manage their resources.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Services
{
    /// <summary>
    /// Information about the buyer.
    /// </summary>
    [DataContract]
    public partial class Buyer : IEquatable<Buyer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Buyer" /> class.
        /// </summary>
        /// <param name="buyerId">The identifier of the buyer..</param>
        /// <param name="name">The name of the buyer..</param>
        /// <param name="phone">The phone number of the buyer..</param>
        /// <param name="isPrimeMember">When true, the service is for an Amazon Prime buyer..</param>
        public Buyer(string buyerId = default, string name = default, string phone = default, bool? isPrimeMember = default)
        {
            this.BuyerId = buyerId;
            this.Name = name;
            this.Phone = phone;
            this.IsPrimeMember = isPrimeMember;
        }

        /// <summary>
        /// The identifier of the buyer.
        /// </summary>
        /// <value>The identifier of the buyer.</value>
        [DataMember(Name = "buyerId", EmitDefaultValue = false)]
        public string BuyerId { get; set; }

        /// <summary>
        /// The name of the buyer.
        /// </summary>
        /// <value>The name of the buyer.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The phone number of the buyer.
        /// </summary>
        /// <value>The phone number of the buyer.</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// When true, the service is for an Amazon Prime buyer.
        /// </summary>
        /// <value>When true, the service is for an Amazon Prime buyer.</value>
        [DataMember(Name = "isPrimeMember", EmitDefaultValue = false)]
        public bool? IsPrimeMember { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Buyer {\n");
            sb.Append("  BuyerId: ").Append(BuyerId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  IsPrimeMember: ").Append(IsPrimeMember).Append("\n");
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
            return this.Equals(input as Buyer);
        }

        /// <summary>
        /// Returns true if Buyer instances are equal
        /// </summary>
        /// <param name="input">Instance of Buyer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Buyer input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BuyerId == input.BuyerId ||
                    (this.BuyerId != null &&
                    this.BuyerId.Equals(input.BuyerId))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) &&
                (
                    this.IsPrimeMember == input.IsPrimeMember ||
                    (this.IsPrimeMember != null &&
                    this.IsPrimeMember.Equals(input.IsPrimeMember))
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
                if (this.BuyerId != null)
                    hashCode = hashCode * 59 + this.BuyerId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.IsPrimeMember != null)
                    hashCode = hashCode * 59 + this.IsPrimeMember.GetHashCode();
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
            // BuyerId (string) pattern
            Regex regexBuyerId = new Regex(@"^[A-Z0-9]*$", RegexOptions.CultureInvariant);
            if (false == regexBuyerId.Match(this.BuyerId).Success)
            {
                yield return new ValidationResult("Invalid value for BuyerId, must match a pattern of " + regexBuyerId, new[] { "BuyerId" });
            }

            yield break;
        }
    }

}
