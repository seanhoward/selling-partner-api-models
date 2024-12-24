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
    /// The delivery terms for the delivery offer.
    /// </summary>
    [DataContract]
    public partial class GetDeliveryOffersTerms :  IEquatable<GetDeliveryOffersTerms>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeliveryOffersTerms" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDeliveryOffersTerms() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeliveryOffersTerms" /> class.
        /// </summary>
        /// <param name="origin">The origin for the delivery offer. (required).</param>
        /// <param name="destination">The destination for the delivery offer. (required).</param>
        public GetDeliveryOffersTerms(Origin origin = default(Origin), Destination destination = default(Destination))
        {
            // to ensure "origin" is required (not null)
            if (origin == null)
            {
                throw new InvalidDataException("origin is a required property for GetDeliveryOffersTerms and cannot be null");
            }
            else
            {
                this.Origin = origin;
            }
            // to ensure "destination" is required (not null)
            if (destination == null)
            {
                throw new InvalidDataException("destination is a required property for GetDeliveryOffersTerms and cannot be null");
            }
            else
            {
                this.Destination = destination;
            }
        }
        
        /// <summary>
        /// The origin for the delivery offer.
        /// </summary>
        /// <value>The origin for the delivery offer.</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public Origin Origin { get; set; }

        /// <summary>
        /// The destination for the delivery offer.
        /// </summary>
        /// <value>The destination for the delivery offer.</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public Destination Destination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDeliveryOffersTerms {\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
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
            return this.Equals(input as GetDeliveryOffersTerms);
        }

        /// <summary>
        /// Returns true if GetDeliveryOffersTerms instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDeliveryOffersTerms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDeliveryOffersTerms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
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
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
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