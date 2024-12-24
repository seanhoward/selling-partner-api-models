/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * With the Selling Partner API for Merchant Fulfillment, you can build applications that sellers can use to purchase shipping for non-Prime and Prime orders using Amazon's Buy Shipping Services.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment
{
    /// <summary>
    /// Request schema.
    /// </summary>
    [DataContract]
    public partial class GetEligibleShipmentServicesRequest :  IEquatable<GetEligibleShipmentServicesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEligibleShipmentServicesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEligibleShipmentServicesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEligibleShipmentServicesRequest" /> class.
        /// </summary>
        /// <param name="shipmentRequestDetails">Shipment information required for requesting shipping service offers. (required).</param>
        /// <param name="shippingOfferingFilter">shippingOfferingFilter.</param>
        public GetEligibleShipmentServicesRequest(ShipmentRequestDetails shipmentRequestDetails = default(ShipmentRequestDetails), ShippingOfferingFilter shippingOfferingFilter = default(ShippingOfferingFilter))
        {
            // to ensure "shipmentRequestDetails" is required (not null)
            if (shipmentRequestDetails == null)
            {
                throw new InvalidDataException("shipmentRequestDetails is a required property for GetEligibleShipmentServicesRequest and cannot be null");
            }
            else
            {
                this.ShipmentRequestDetails = shipmentRequestDetails;
            }
            this.ShippingOfferingFilter = shippingOfferingFilter;
        }
        
        /// <summary>
        /// Shipment information required for requesting shipping service offers.
        /// </summary>
        /// <value>Shipment information required for requesting shipping service offers.</value>
        [DataMember(Name="ShipmentRequestDetails", EmitDefaultValue=false)]
        public ShipmentRequestDetails ShipmentRequestDetails { get; set; }

        /// <summary>
        /// Gets or Sets ShippingOfferingFilter
        /// </summary>
        [DataMember(Name="ShippingOfferingFilter", EmitDefaultValue=false)]
        public ShippingOfferingFilter ShippingOfferingFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetEligibleShipmentServicesRequest {\n");
            sb.Append("  ShipmentRequestDetails: ").Append(ShipmentRequestDetails).Append("\n");
            sb.Append("  ShippingOfferingFilter: ").Append(ShippingOfferingFilter).Append("\n");
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
            return this.Equals(input as GetEligibleShipmentServicesRequest);
        }

        /// <summary>
        /// Returns true if GetEligibleShipmentServicesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEligibleShipmentServicesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEligibleShipmentServicesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShipmentRequestDetails == input.ShipmentRequestDetails ||
                    (this.ShipmentRequestDetails != null &&
                    this.ShipmentRequestDetails.Equals(input.ShipmentRequestDetails))
                ) && 
                (
                    this.ShippingOfferingFilter == input.ShippingOfferingFilter ||
                    (this.ShippingOfferingFilter != null &&
                    this.ShippingOfferingFilter.Equals(input.ShippingOfferingFilter))
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
                if (this.ShipmentRequestDetails != null)
                    hashCode = hashCode * 59 + this.ShipmentRequestDetails.GetHashCode();
                if (this.ShippingOfferingFilter != null)
                    hashCode = hashCode * 59 + this.ShippingOfferingFilter.GetHashCode();
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
