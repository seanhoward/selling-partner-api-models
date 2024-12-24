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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Services
{
    /// <summary>
    /// Information about the seller of the service job.
    /// </summary>
    [DataContract]
    public partial class Seller :  IEquatable<Seller>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Seller" /> class.
        /// </summary>
        /// <param name="sellerId">The identifier of the seller of the service job..</param>
        public Seller(string sellerId = default(string))
        {
            this.SellerId = sellerId;
        }
        
        /// <summary>
        /// The identifier of the seller of the service job.
        /// </summary>
        /// <value>The identifier of the seller of the service job.</value>
        [DataMember(Name="sellerId", EmitDefaultValue=false)]
        public string SellerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Seller {\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
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
            return this.Equals(input as Seller);
        }

        /// <summary>
        /// Returns true if Seller instances are equal
        /// </summary>
        /// <param name="input">Instance of Seller to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Seller input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
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
                if (this.SellerId != null)
                    hashCode = hashCode * 59 + this.SellerId.GetHashCode();
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
            // SellerId (string) pattern
            Regex regexSellerId = new Regex(@"^[A-Z0-9]*$", RegexOptions.CultureInvariant);
            if (false == regexSellerId.Match(this.SellerId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SellerId, must match a pattern of " + regexSellerId, new [] { "SellerId" });
            }

            yield break;
        }
    }

}
