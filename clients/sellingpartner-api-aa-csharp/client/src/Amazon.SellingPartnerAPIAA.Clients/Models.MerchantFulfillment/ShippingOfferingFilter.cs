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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment
{
    /// <summary>
    /// Filter for use when requesting eligible shipping services.
    /// </summary>
    [DataContract]
    public partial class ShippingOfferingFilter : IEquatable<ShippingOfferingFilter>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CarrierWillPickUp
        /// </summary>
        [DataMember(Name = "CarrierWillPickUp", EmitDefaultValue = false)]
        public CarrierWillPickUpOption? CarrierWillPickUp { get; set; }
        /// <summary>
        /// Gets or Sets DeliveryExperience
        /// </summary>
        [DataMember(Name = "DeliveryExperience", EmitDefaultValue = false)]
        public DeliveryExperienceOption? DeliveryExperience { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingOfferingFilter" /> class.
        /// </summary>
        /// <param name="includePackingSlipWithLabel">When true, include a packing slip with the label..</param>
        /// <param name="includeComplexShippingOptions">When true, include complex shipping options..</param>
        /// <param name="carrierWillPickUp">carrierWillPickUp.</param>
        /// <param name="deliveryExperience">deliveryExperience.</param>
        public ShippingOfferingFilter(bool? includePackingSlipWithLabel = default, bool? includeComplexShippingOptions = default, CarrierWillPickUpOption? carrierWillPickUp = default, DeliveryExperienceOption? deliveryExperience = default)
        {
            this.IncludePackingSlipWithLabel = includePackingSlipWithLabel;
            this.IncludeComplexShippingOptions = includeComplexShippingOptions;
            this.CarrierWillPickUp = carrierWillPickUp;
            this.DeliveryExperience = deliveryExperience;
        }

        /// <summary>
        /// When true, include a packing slip with the label.
        /// </summary>
        /// <value>When true, include a packing slip with the label.</value>
        [DataMember(Name = "IncludePackingSlipWithLabel", EmitDefaultValue = false)]
        public bool? IncludePackingSlipWithLabel { get; set; }

        /// <summary>
        /// When true, include complex shipping options.
        /// </summary>
        /// <value>When true, include complex shipping options.</value>
        [DataMember(Name = "IncludeComplexShippingOptions", EmitDefaultValue = false)]
        public bool? IncludeComplexShippingOptions { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingOfferingFilter {\n");
            sb.Append("  IncludePackingSlipWithLabel: ").Append(IncludePackingSlipWithLabel).Append("\n");
            sb.Append("  IncludeComplexShippingOptions: ").Append(IncludeComplexShippingOptions).Append("\n");
            sb.Append("  CarrierWillPickUp: ").Append(CarrierWillPickUp).Append("\n");
            sb.Append("  DeliveryExperience: ").Append(DeliveryExperience).Append("\n");
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
            return this.Equals(input as ShippingOfferingFilter);
        }

        /// <summary>
        /// Returns true if ShippingOfferingFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingOfferingFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingOfferingFilter input)
        {
            if (input == null)
                return false;

            return
                (
                    this.IncludePackingSlipWithLabel == input.IncludePackingSlipWithLabel ||
                    (this.IncludePackingSlipWithLabel != null &&
                    this.IncludePackingSlipWithLabel.Equals(input.IncludePackingSlipWithLabel))
                ) &&
                (
                    this.IncludeComplexShippingOptions == input.IncludeComplexShippingOptions ||
                    (this.IncludeComplexShippingOptions != null &&
                    this.IncludeComplexShippingOptions.Equals(input.IncludeComplexShippingOptions))
                ) &&
                (
                    this.CarrierWillPickUp == input.CarrierWillPickUp ||
                    (this.CarrierWillPickUp != null &&
                    this.CarrierWillPickUp.Equals(input.CarrierWillPickUp))
                ) &&
                (
                    this.DeliveryExperience == input.DeliveryExperience ||
                    (this.DeliveryExperience != null &&
                    this.DeliveryExperience.Equals(input.DeliveryExperience))
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
                if (this.IncludePackingSlipWithLabel != null)
                    hashCode = hashCode * 59 + this.IncludePackingSlipWithLabel.GetHashCode();
                if (this.IncludeComplexShippingOptions != null)
                    hashCode = hashCode * 59 + this.IncludeComplexShippingOptions.GetHashCode();
                if (this.CarrierWillPickUp != null)
                    hashCode = hashCode * 59 + this.CarrierWillPickUp.GetHashCode();
                if (this.DeliveryExperience != null)
                    hashCode = hashCode * 59 + this.DeliveryExperience.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
