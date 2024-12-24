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
    /// The payload schema for the createShipment operation.
    /// </summary>
    [DataContract]
    public partial class CreateShipmentResult :  IEquatable<CreateShipmentResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShipmentResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateShipmentResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShipmentResult" /> class.
        /// </summary>
        /// <param name="shipmentId">shipmentId (required).</param>
        /// <param name="eligibleRates">eligibleRates (required).</param>
        public CreateShipmentResult(string shipmentId = default(string), RateList eligibleRates = default(RateList))
        {
            // to ensure "shipmentId" is required (not null)
            if (shipmentId == null)
            {
                throw new InvalidDataException("shipmentId is a required property for CreateShipmentResult and cannot be null");
            }
            else
            {
                this.ShipmentId = shipmentId;
            }
            // to ensure "eligibleRates" is required (not null)
            if (eligibleRates == null)
            {
                throw new InvalidDataException("eligibleRates is a required property for CreateShipmentResult and cannot be null");
            }
            else
            {
                this.EligibleRates = eligibleRates;
            }
        }
        
        /// <summary>
        /// Gets or Sets ShipmentId
        /// </summary>
        [DataMember(Name="shipmentId", EmitDefaultValue=false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Gets or Sets EligibleRates
        /// </summary>
        [DataMember(Name="eligibleRates", EmitDefaultValue=false)]
        public RateList EligibleRates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateShipmentResult {\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  EligibleRates: ").Append(EligibleRates).Append("\n");
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
            return this.Equals(input as CreateShipmentResult);
        }

        /// <summary>
        /// Returns true if CreateShipmentResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateShipmentResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateShipmentResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShipmentId == input.ShipmentId ||
                    (this.ShipmentId != null &&
                    this.ShipmentId.Equals(input.ShipmentId))
                ) && 
                (
                    this.EligibleRates == input.EligibleRates ||
                    (this.EligibleRates != null &&
                    this.EligibleRates.Equals(input.EligibleRates))
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
                if (this.ShipmentId != null)
                    hashCode = hashCode * 59 + this.ShipmentId.GetHashCode();
                if (this.EligibleRates != null)
                    hashCode = hashCode * 59 + this.EligibleRates.GetHashCode();
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
