/* 
 * Selling Partner API for Messaging
 *
 * With the Messaging API you can build applications that send messages to buyers. You can get a list of message types that are available for an order that you specify, then call an operation that sends a message to the buyer for that order. The Messaging API returns responses that are formed according to the <a href=https://tools.ietf.org/html/draft-kelly-json-hal-08>JSON Hypertext Application Language</a> (HAL) standard.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Messaging
{
    /// <summary>
    /// The list of attributes related to the buyer.
    /// </summary>
    [DataContract]
    public partial class GetAttributesResponseBuyer :  IEquatable<GetAttributesResponseBuyer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAttributesResponseBuyer" /> class.
        /// </summary>
        /// <param name="locale">The buyer&#39;s language of preference, indicated with a locale-specific language tag. Examples: \&quot;en-US\&quot;, \&quot;zh-CN\&quot;, and \&quot;en-GB\&quot;..</param>
        public GetAttributesResponseBuyer(string locale = default(string))
        {
            this.Locale = locale;
        }
        
        /// <summary>
        /// The buyer&#39;s language of preference, indicated with a locale-specific language tag. Examples: \&quot;en-US\&quot;, \&quot;zh-CN\&quot;, and \&quot;en-GB\&quot;.
        /// </summary>
        /// <value>The buyer&#39;s language of preference, indicated with a locale-specific language tag. Examples: \&quot;en-US\&quot;, \&quot;zh-CN\&quot;, and \&quot;en-GB\&quot;.</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAttributesResponseBuyer {\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(input as GetAttributesResponseBuyer);
        }

        /// <summary>
        /// Returns true if GetAttributesResponseBuyer instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAttributesResponseBuyer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAttributesResponseBuyer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
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
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
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