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
    /// The specific rate for a shipping service, or null if no service available.
    /// </summary>
    [DataContract]
    public partial class ServiceRate :  IEquatable<ServiceRate>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ServiceType
        /// </summary>
        [DataMember(Name="serviceType", EmitDefaultValue=false)]
        public ServiceType ServiceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceRate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRate" /> class.
        /// </summary>
        /// <param name="totalCharge">The total charge that will be billed for the rate. (required).</param>
        /// <param name="billableWeight">The weight that was used to calculate the totalCharge. (required).</param>
        /// <param name="serviceType">serviceType (required).</param>
        /// <param name="promise">promise (required).</param>
        public ServiceRate(Currency totalCharge = default(Currency), Weight billableWeight = default(Weight), ServiceType serviceType = default(ServiceType), ShippingPromiseSet promise = default(ShippingPromiseSet))
        {
            // to ensure "totalCharge" is required (not null)
            if (totalCharge == null)
            {
                throw new InvalidDataException("totalCharge is a required property for ServiceRate and cannot be null");
            }
            else
            {
                this.TotalCharge = totalCharge;
            }
            // to ensure "billableWeight" is required (not null)
            if (billableWeight == null)
            {
                throw new InvalidDataException("billableWeight is a required property for ServiceRate and cannot be null");
            }
            else
            {
                this.BillableWeight = billableWeight;
            }
            // to ensure "serviceType" is required (not null)
            if (serviceType == null)
            {
                throw new InvalidDataException("serviceType is a required property for ServiceRate and cannot be null");
            }
            else
            {
                this.ServiceType = serviceType;
            }
            // to ensure "promise" is required (not null)
            if (promise == null)
            {
                throw new InvalidDataException("promise is a required property for ServiceRate and cannot be null");
            }
            else
            {
                this.Promise = promise;
            }
        }
        
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
        [DataMember(Name="billableWeight", EmitDefaultValue=false)]
        public Weight BillableWeight { get; set; }


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
            sb.Append("class ServiceRate {\n");
            sb.Append("  TotalCharge: ").Append(TotalCharge).Append("\n");
            sb.Append("  BillableWeight: ").Append(BillableWeight).Append("\n");
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
            return this.Equals(input as ServiceRate);
        }

        /// <summary>
        /// Returns true if ServiceRate instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceRate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCharge == input.TotalCharge ||
                    (this.TotalCharge != null &&
                    this.TotalCharge.Equals(input.TotalCharge))
                ) && 
                (
                    this.BillableWeight == input.BillableWeight ||
                    (this.BillableWeight != null &&
                    this.BillableWeight.Equals(input.BillableWeight))
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
                if (this.TotalCharge != null)
                    hashCode = hashCode * 59 + this.TotalCharge.GetHashCode();
                if (this.BillableWeight != null)
                    hashCode = hashCode * 59 + this.BillableWeight.GetHashCode();
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