/* 
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * Use the Selling Partner API for Direct Fulfillment Shipping to access a direct fulfillment vendor's shipping data.
 *
 * OpenAPI spec version: 2021-12-28
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping
{
    /// <summary>
    /// The package that is associated with the container.
    /// </summary>
    [DataContract]
    public partial class Package : IEquatable<Package>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        [JsonConstructor]
        protected Package() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        /// <param name="packageTrackingNumber">The tracking number on the label of shipment package, that you can fetch from the &#x60;shippingLabels&#x60; response. You can also scan the bar code on the shipping label to get the tracking number. (required).</param>
        public Package(string packageTrackingNumber = default)
        {
            // to ensure "packageTrackingNumber" is required (not null)
            if (packageTrackingNumber == null)
            {
                throw new InvalidDataException("packageTrackingNumber is a required property for Package and cannot be null");
            }
            else
            {
                this.PackageTrackingNumber = packageTrackingNumber;
            }
        }

        /// <summary>
        /// The tracking number on the label of shipment package, that you can fetch from the &#x60;shippingLabels&#x60; response. You can also scan the bar code on the shipping label to get the tracking number.
        /// </summary>
        /// <value>The tracking number on the label of shipment package, that you can fetch from the &#x60;shippingLabels&#x60; response. You can also scan the bar code on the shipping label to get the tracking number.</value>
        [DataMember(Name = "packageTrackingNumber", EmitDefaultValue = false)]
        public string PackageTrackingNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Package {\n");
            sb.Append("  PackageTrackingNumber: ").Append(PackageTrackingNumber).Append("\n");
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
            return this.Equals(input as Package);
        }

        /// <summary>
        /// Returns true if Package instances are equal
        /// </summary>
        /// <param name="input">Instance of Package to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Package input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PackageTrackingNumber == input.PackageTrackingNumber ||
                    (this.PackageTrackingNumber != null &&
                    this.PackageTrackingNumber.Equals(input.PackageTrackingNumber))
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
                if (this.PackageTrackingNumber != null)
                    hashCode = hashCode * 59 + this.PackageTrackingNumber.GetHashCode();
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
