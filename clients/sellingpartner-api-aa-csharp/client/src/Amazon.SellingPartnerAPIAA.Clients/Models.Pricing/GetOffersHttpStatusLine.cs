/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Pricing
{
    /// <summary>
    /// The HTTP status line associated with the response.  For more information, consult [RFC 2616](https://www.w3.org/Protocols/rfc2616/rfc2616-sec6.html).
    /// </summary>
    [DataContract]
    public partial class GetOffersHttpStatusLine :  IEquatable<GetOffersHttpStatusLine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOffersHttpStatusLine" /> class.
        /// </summary>
        /// <param name="statusCode">The HTTP response Status Code..</param>
        /// <param name="reasonPhrase">The HTTP response Reason-Phase..</param>
        public GetOffersHttpStatusLine(int? statusCode = default(int?), string reasonPhrase = default(string))
        {
            this.StatusCode = statusCode;
            this.ReasonPhrase = reasonPhrase;
        }
        
        /// <summary>
        /// The HTTP response Status Code.
        /// </summary>
        /// <value>The HTTP response Status Code.</value>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// The HTTP response Reason-Phase.
        /// </summary>
        /// <value>The HTTP response Reason-Phase.</value>
        [DataMember(Name="reasonPhrase", EmitDefaultValue=false)]
        public string ReasonPhrase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOffersHttpStatusLine {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  ReasonPhrase: ").Append(ReasonPhrase).Append("\n");
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
            return this.Equals(input as GetOffersHttpStatusLine);
        }

        /// <summary>
        /// Returns true if GetOffersHttpStatusLine instances are equal
        /// </summary>
        /// <param name="input">Instance of GetOffersHttpStatusLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOffersHttpStatusLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.ReasonPhrase == input.ReasonPhrase ||
                    (this.ReasonPhrase != null &&
                    this.ReasonPhrase.Equals(input.ReasonPhrase))
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
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.ReasonPhrase != null)
                    hashCode = hashCode * 59 + this.ReasonPhrase.GetHashCode();
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
            // StatusCode (int?) maximum
            if(this.StatusCode > (int?)599)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatusCode, must be a value less than or equal to 599.", new [] { "StatusCode" });
            }

            // StatusCode (int?) minimum
            if(this.StatusCode < (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatusCode, must be a value greater than or equal to 100.", new [] { "StatusCode" });
            }

            yield break;
        }
    }

}
