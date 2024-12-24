/* 
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.   **Note:** If you are new to the Amazon Shipping API, refer to the latest version of <a href=\"https://developer-docs.amazon.com/amazon-shipping/docs/shipping-api-v2-reference\">Amazon Shipping API (v2)</a> on the <a href=\"https://developer-docs.amazon.com/amazon-shipping/\">Amazon Shipping Developer Documentation</a> site.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Shipping
{
    /// <summary>
    /// The available rate that can be used to send the shipment
    /// </summary>
    [DataContract]
    public partial class Rate :  IEquatable<Rate>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ServiceType
        /// </summary>
        [DataMember(Name="serviceType", EmitDefaultValue=false)]
        public ServiceType? ServiceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rate" /> class.
        /// </summary>
        /// <param name="rateId">An identifier for the rate..</param>
        /// <param name="totalCharge">The total charge that will be billed for the rate..</param>
        /// <param name="billedWeight">The weight that was used to calculate the totalCharge..</param>
        /// <param name="expirationTime">The time after which the offering will expire..</param>
        /// <param name="serviceType">serviceType.</param>
        /// <param name="promise">promise.</param>
        public Rate(string rateId = default(string), Currency totalCharge = default(Currency), Weight billedWeight = default(Weight), DateTime? expirationTime = default(DateTime?), ServiceType? serviceType = default(ServiceType?), ShippingPromiseSet promise = default(ShippingPromiseSet))
        {
            this.RateId = rateId;
            this.TotalCharge = totalCharge;
            this.BilledWeight = billedWeight;
            this.ExpirationTime = expirationTime;
            this.ServiceType = serviceType;
            this.Promise = promise;
        }
        
        /// <summary>
        /// An identifier for the rate.
        /// </summary>
        /// <value>An identifier for the rate.</value>
        [DataMember(Name="rateId", EmitDefaultValue=false)]
        public string RateId { get; set; }

        /// <summary>
        /// The total charge that will be billed for the rate.
        /// </summary>
        /// <value>The total charge that will be billed for the rate.</value>
        [DataMember(Name="totalCharge", EmitDefaultValue=false)]
        public Currency TotalCharge { get; set; }

        /// <summary>
        /// The weight that was used to calculate the totalCharge.
        /// </summary>
        /// <value>The weight that was used to calculate the totalCharge.</value>
        [DataMember(Name="billedWeight", EmitDefaultValue=false)]
        public Weight BilledWeight { get; set; }

        /// <summary>
        /// The time after which the offering will expire.
        /// </summary>
        /// <value>The time after which the offering will expire.</value>
        [DataMember(Name="expirationTime", EmitDefaultValue=false)]
        public DateTime? ExpirationTime { get; set; }


        /// <summary>
        /// Gets or Sets Promise
        /// </summary>
        [DataMember(Name="promise", EmitDefaultValue=false)]
        public ShippingPromiseSet Promise { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rate {\n");
            sb.Append("  RateId: ").Append(RateId).Append("\n");
            sb.Append("  TotalCharge: ").Append(TotalCharge).Append("\n");
            sb.Append("  BilledWeight: ").Append(BilledWeight).Append("\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  Promise: ").Append(Promise).Append("\n");
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
            return this.Equals(input as Rate);
        }

        /// <summary>
        /// Returns true if Rate instances are equal
        /// </summary>
        /// <param name="input">Instance of Rate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RateId == input.RateId ||
                    (this.RateId != null &&
                    this.RateId.Equals(input.RateId))
                ) && 
                (
                    this.TotalCharge == input.TotalCharge ||
                    (this.TotalCharge != null &&
                    this.TotalCharge.Equals(input.TotalCharge))
                ) && 
                (
                    this.BilledWeight == input.BilledWeight ||
                    (this.BilledWeight != null &&
                    this.BilledWeight.Equals(input.BilledWeight))
                ) && 
                (
                    this.ExpirationTime == input.ExpirationTime ||
                    (this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(input.ExpirationTime))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.Promise == input.Promise ||
                    (this.Promise != null &&
                    this.Promise.Equals(input.Promise))
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
                if (this.RateId != null)
                    hashCode = hashCode * 59 + this.RateId.GetHashCode();
                if (this.TotalCharge != null)
                    hashCode = hashCode * 59 + this.TotalCharge.GetHashCode();
                if (this.BilledWeight != null)
                    hashCode = hashCode * 59 + this.BilledWeight.GetHashCode();
                if (this.ExpirationTime != null)
                    hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.Promise != null)
                    hashCode = hashCode * 59 + this.Promise.GetHashCode();
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
