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
    /// Delivery information for a scheduled delivery. This is only available in the JP marketplace.
    /// </summary>
    [DataContract]
    public partial class ScheduledDeliveryInfo :  IEquatable<ScheduledDeliveryInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledDeliveryInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduledDeliveryInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledDeliveryInfo" /> class.
        /// </summary>
        /// <param name="deliveryTimeZone">The time zone of the destination address for the fulfillment order preview. Must be an IANA time zone name. Example: Asia/Tokyo. (required).</param>
        /// <param name="deliveryWindows">An array of time ranges that are available for scheduled delivery. (required).</param>
        public ScheduledDeliveryInfo(string deliveryTimeZone = default(string), DeliveryWindowList deliveryWindows = default(DeliveryWindowList))
        {
            // to ensure "deliveryTimeZone" is required (not null)
            if (deliveryTimeZone == null)
            {
                throw new InvalidDataException("deliveryTimeZone is a required property for ScheduledDeliveryInfo and cannot be null");
            }
            else
            {
                this.DeliveryTimeZone = deliveryTimeZone;
            }
            // to ensure "deliveryWindows" is required (not null)
            if (deliveryWindows == null)
            {
                throw new InvalidDataException("deliveryWindows is a required property for ScheduledDeliveryInfo and cannot be null");
            }
            else
            {
                this.DeliveryWindows = deliveryWindows;
            }
        }
        
        /// <summary>
        /// The time zone of the destination address for the fulfillment order preview. Must be an IANA time zone name. Example: Asia/Tokyo.
        /// </summary>
        /// <value>The time zone of the destination address for the fulfillment order preview. Must be an IANA time zone name. Example: Asia/Tokyo.</value>
        [DataMember(Name="deliveryTimeZone", EmitDefaultValue=false)]
        public string DeliveryTimeZone { get; set; }

        /// <summary>
        /// An array of time ranges that are available for scheduled delivery.
        /// </summary>
        /// <value>An array of time ranges that are available for scheduled delivery.</value>
        [DataMember(Name="deliveryWindows", EmitDefaultValue=false)]
        public DeliveryWindowList DeliveryWindows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledDeliveryInfo {\n");
            sb.Append("  DeliveryTimeZone: ").Append(DeliveryTimeZone).Append("\n");
            sb.Append("  DeliveryWindows: ").Append(DeliveryWindows).Append("\n");
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
            return this.Equals(input as ScheduledDeliveryInfo);
        }

        /// <summary>
        /// Returns true if ScheduledDeliveryInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduledDeliveryInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledDeliveryInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeliveryTimeZone == input.DeliveryTimeZone ||
                    (this.DeliveryTimeZone != null &&
                    this.DeliveryTimeZone.Equals(input.DeliveryTimeZone))
                ) && 
                (
                    this.DeliveryWindows == input.DeliveryWindows ||
                    (this.DeliveryWindows != null &&
                    this.DeliveryWindows.Equals(input.DeliveryWindows))
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
                if (this.DeliveryTimeZone != null)
                    hashCode = hashCode * 59 + this.DeliveryTimeZone.GetHashCode();
                if (this.DeliveryWindows != null)
                    hashCode = hashCode * 59 + this.DeliveryWindows.GetHashCode();
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