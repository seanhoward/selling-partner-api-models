/* 
 * Fulfillment Inbound v2024-03-20
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound
{
    /// <summary>
    /// Contains information pertaining to a delivery window option.
    /// </summary>
    [DataContract]
    public partial class DeliveryWindowOption :  IEquatable<DeliveryWindowOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryWindowOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeliveryWindowOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryWindowOption" /> class.
        /// </summary>
        /// <param name="availabilityType">Identifies type of Delivery Window Availability. Values: &#x60;AVAILABLE&#x60;, &#x60;CONGESTED&#x60; (required).</param>
        /// <param name="deliveryWindowOptionId">Identifier of a delivery window option. A delivery window option represent one option for when a shipment is expected to be delivered. (required).</param>
        /// <param name="endDate">The time at which this delivery window option ends. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mmZ&#x60;. (required).</param>
        /// <param name="startDate">The time at which this delivery window option starts. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mmZ&#x60;. (required).</param>
        /// <param name="validUntil">The time at which this window delivery option is no longer valid. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mmZ&#x60;. (required).</param>
        public DeliveryWindowOption(string availabilityType = default(string), string deliveryWindowOptionId = default(string), DateTime? endDate = default(DateTime?), DateTime? startDate = default(DateTime?), DateTime? validUntil = default(DateTime?))
        {
            // to ensure "availabilityType" is required (not null)
            if (availabilityType == null)
            {
                throw new InvalidDataException("availabilityType is a required property for DeliveryWindowOption and cannot be null");
            }
            else
            {
                this.AvailabilityType = availabilityType;
            }
            // to ensure "deliveryWindowOptionId" is required (not null)
            if (deliveryWindowOptionId == null)
            {
                throw new InvalidDataException("deliveryWindowOptionId is a required property for DeliveryWindowOption and cannot be null");
            }
            else
            {
                this.DeliveryWindowOptionId = deliveryWindowOptionId;
            }
            // to ensure "endDate" is required (not null)
            if (endDate == null)
            {
                throw new InvalidDataException("endDate is a required property for DeliveryWindowOption and cannot be null");
            }
            else
            {
                this.EndDate = endDate;
            }
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for DeliveryWindowOption and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            // to ensure "validUntil" is required (not null)
            if (validUntil == null)
            {
                throw new InvalidDataException("validUntil is a required property for DeliveryWindowOption and cannot be null");
            }
            else
            {
                this.ValidUntil = validUntil;
            }
        }
        
        /// <summary>
        /// Identifies type of Delivery Window Availability. Values: &#x60;AVAILABLE&#x60;, &#x60;CONGESTED&#x60;
        /// </summary>
        /// <value>Identifies type of Delivery Window Availability. Values: &#x60;AVAILABLE&#x60;, &#x60;CONGESTED&#x60;</value>
        [DataMember(Name="availabilityType", EmitDefaultValue=false)]
        public string AvailabilityType { get; set; }

        /// <summary>
        /// Identifier of a delivery window option. A delivery window option represent one option for when a shipment is expected to be delivered.
        /// </summary>
        /// <value>Identifier of a delivery window option. A delivery window option represent one option for when a shipment is expected to be delivered.</value>
        [DataMember(Name="deliveryWindowOptionId", EmitDefaultValue=false)]
        public string DeliveryWindowOptionId { get; set; }

        /// <summary>
        /// The time at which this delivery window option ends. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mmZ&#x60;.
        /// </summary>
        /// <value>The time at which this delivery window option ends. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mmZ&#x60;.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The time at which this delivery window option starts. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mmZ&#x60;.
        /// </summary>
        /// <value>The time at which this delivery window option starts. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mmZ&#x60;.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The time at which this window delivery option is no longer valid. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mmZ&#x60;.
        /// </summary>
        /// <value>The time at which this window delivery option is no longer valid. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mmZ&#x60;.</value>
        [DataMember(Name="validUntil", EmitDefaultValue=false)]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryWindowOption {\n");
            sb.Append("  AvailabilityType: ").Append(AvailabilityType).Append("\n");
            sb.Append("  DeliveryWindowOptionId: ").Append(DeliveryWindowOptionId).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
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
            return this.Equals(input as DeliveryWindowOption);
        }

        /// <summary>
        /// Returns true if DeliveryWindowOption instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryWindowOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryWindowOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailabilityType == input.AvailabilityType ||
                    (this.AvailabilityType != null &&
                    this.AvailabilityType.Equals(input.AvailabilityType))
                ) && 
                (
                    this.DeliveryWindowOptionId == input.DeliveryWindowOptionId ||
                    (this.DeliveryWindowOptionId != null &&
                    this.DeliveryWindowOptionId.Equals(input.DeliveryWindowOptionId))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ValidUntil == input.ValidUntil ||
                    (this.ValidUntil != null &&
                    this.ValidUntil.Equals(input.ValidUntil))
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
                if (this.AvailabilityType != null)
                    hashCode = hashCode * 59 + this.AvailabilityType.GetHashCode();
                if (this.DeliveryWindowOptionId != null)
                    hashCode = hashCode * 59 + this.DeliveryWindowOptionId.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ValidUntil != null)
                    hashCode = hashCode * 59 + this.ValidUntil.GetHashCode();
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
            // DeliveryWindowOptionId (string) maxLength
            if(this.DeliveryWindowOptionId != null && this.DeliveryWindowOptionId.Length > 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeliveryWindowOptionId, length must be less than 38.", new [] { "DeliveryWindowOptionId" });
            }

            // DeliveryWindowOptionId (string) minLength
            if(this.DeliveryWindowOptionId != null && this.DeliveryWindowOptionId.Length < 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeliveryWindowOptionId, length must be greater than 36.", new [] { "DeliveryWindowOptionId" });
            }

            // DeliveryWindowOptionId (string) pattern
            Regex regexDeliveryWindowOptionId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
            if (false == regexDeliveryWindowOptionId.Match(this.DeliveryWindowOptionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeliveryWindowOptionId, must match a pattern of " + regexDeliveryWindowOptionId, new [] { "DeliveryWindowOptionId" });
            }

            yield break;
        }
    }

}
