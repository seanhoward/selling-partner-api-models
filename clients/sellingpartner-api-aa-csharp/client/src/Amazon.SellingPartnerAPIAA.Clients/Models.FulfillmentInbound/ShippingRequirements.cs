/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound
{
    /// <summary>
    /// The possible shipping modes for the packing option for a given shipping solution or program. Available solutions are Amazon-Partnered Carrier and Use Your Own Carrier. Available modes are ground small parcel, freight less-than-truckload (LTL), freight full-truckload (FTL) palletized, freight FTL non-palletized, ocean less-than-container-load (LCL), ocean full-container load (FCL), air small parcel, and air small parcel express.
    /// </summary>
    [DataContract]
    public partial class ShippingRequirements : IEquatable<ShippingRequirements>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingRequirements" /> class.
        /// </summary>
        [JsonConstructor]
        protected ShippingRequirements() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingRequirements" /> class.
        /// </summary>
        /// <param name="modes">Available shipment modes for this shipping program. (required).</param>
        /// <param name="solution">Shipping program for the option. Can be: &#x60;AMAZON_PARTNERED_CARRIER&#x60;, &#x60;USE_YOUR_OWN_CARRIER&#x60;. (required).</param>
        public ShippingRequirements(List<string> modes = default, string solution = default)
        {
            // to ensure "modes" is required (not null)
            if (modes == null)
            {
                throw new InvalidDataException("modes is a required property for ShippingRequirements and cannot be null");
            }
            else
            {
                this.Modes = modes;
            }
            // to ensure "solution" is required (not null)
            if (solution == null)
            {
                throw new InvalidDataException("solution is a required property for ShippingRequirements and cannot be null");
            }
            else
            {
                this.Solution = solution;
            }
        }

        /// <summary>
        /// Available shipment modes for this shipping program.
        /// </summary>
        /// <value>Available shipment modes for this shipping program.</value>
        [DataMember(Name = "modes", EmitDefaultValue = false)]
        public List<string> Modes { get; set; }

        /// <summary>
        /// Shipping program for the option. Can be: &#x60;AMAZON_PARTNERED_CARRIER&#x60;, &#x60;USE_YOUR_OWN_CARRIER&#x60;.
        /// </summary>
        /// <value>Shipping program for the option. Can be: &#x60;AMAZON_PARTNERED_CARRIER&#x60;, &#x60;USE_YOUR_OWN_CARRIER&#x60;.</value>
        [DataMember(Name = "solution", EmitDefaultValue = false)]
        public string Solution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingRequirements {\n");
            sb.Append("  Modes: ").Append(Modes).Append("\n");
            sb.Append("  Solution: ").Append(Solution).Append("\n");
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
            return this.Equals(input as ShippingRequirements);
        }

        /// <summary>
        /// Returns true if ShippingRequirements instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingRequirements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingRequirements input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Modes == input.Modes ||
                    this.Modes != null &&
                    this.Modes.SequenceEqual(input.Modes)
                ) &&
                (
                    this.Solution == input.Solution ||
                    (this.Solution != null &&
                    this.Solution.Equals(input.Solution))
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
                if (this.Modes != null)
                    hashCode = hashCode * 59 + this.Modes.GetHashCode();
                if (this.Solution != null)
                    hashCode = hashCode * 59 + this.Solution.GetHashCode();
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
            // Solution (string) maxLength
            if (this.Solution != null && this.Solution.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for Solution, length must be less than 1024.", new[] { "Solution" });
            }

            // Solution (string) minLength
            if (this.Solution != null && this.Solution.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Solution, length must be greater than 1.", new[] { "Solution" });
            }

            yield break;
        }
    }

}
