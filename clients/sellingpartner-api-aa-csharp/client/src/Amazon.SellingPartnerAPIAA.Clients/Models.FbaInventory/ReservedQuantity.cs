/* 
 * Selling Partner API for FBA Inventory
 *
 * The Selling Partner API for FBA Inventory lets you programmatically retrieve information about inventory in Amazon's fulfillment network.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FbaInventory
{
    /// <summary>
    /// The quantity of reserved inventory.
    /// </summary>
    [DataContract]
    public partial class ReservedQuantity : IEquatable<ReservedQuantity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservedQuantity" /> class.
        /// </summary>
        /// <param name="totalReservedQuantity">The total number of units in Amazon&#39;s fulfillment network that are currently being picked, packed, and shipped; or are sidelined for measurement, sampling, or other internal processes..</param>
        /// <param name="pendingCustomerOrderQuantity">The number of units reserved for customer orders..</param>
        /// <param name="pendingTransshipmentQuantity">The number of units being transferred from one fulfillment center to another..</param>
        /// <param name="fcProcessingQuantity">The number of units that have been sidelined at the fulfillment center for additional processing..</param>
        public ReservedQuantity(int? totalReservedQuantity = default, int? pendingCustomerOrderQuantity = default, int? pendingTransshipmentQuantity = default, int? fcProcessingQuantity = default)
        {
            this.TotalReservedQuantity = totalReservedQuantity;
            this.PendingCustomerOrderQuantity = pendingCustomerOrderQuantity;
            this.PendingTransshipmentQuantity = pendingTransshipmentQuantity;
            this.FcProcessingQuantity = fcProcessingQuantity;
        }

        /// <summary>
        /// The total number of units in Amazon&#39;s fulfillment network that are currently being picked, packed, and shipped; or are sidelined for measurement, sampling, or other internal processes.
        /// </summary>
        /// <value>The total number of units in Amazon&#39;s fulfillment network that are currently being picked, packed, and shipped; or are sidelined for measurement, sampling, or other internal processes.</value>
        [DataMember(Name = "totalReservedQuantity", EmitDefaultValue = false)]
        public int? TotalReservedQuantity { get; set; }

        /// <summary>
        /// The number of units reserved for customer orders.
        /// </summary>
        /// <value>The number of units reserved for customer orders.</value>
        [DataMember(Name = "pendingCustomerOrderQuantity", EmitDefaultValue = false)]
        public int? PendingCustomerOrderQuantity { get; set; }

        /// <summary>
        /// The number of units being transferred from one fulfillment center to another.
        /// </summary>
        /// <value>The number of units being transferred from one fulfillment center to another.</value>
        [DataMember(Name = "pendingTransshipmentQuantity", EmitDefaultValue = false)]
        public int? PendingTransshipmentQuantity { get; set; }

        /// <summary>
        /// The number of units that have been sidelined at the fulfillment center for additional processing.
        /// </summary>
        /// <value>The number of units that have been sidelined at the fulfillment center for additional processing.</value>
        [DataMember(Name = "fcProcessingQuantity", EmitDefaultValue = false)]
        public int? FcProcessingQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReservedQuantity {\n");
            sb.Append("  TotalReservedQuantity: ").Append(TotalReservedQuantity).Append("\n");
            sb.Append("  PendingCustomerOrderQuantity: ").Append(PendingCustomerOrderQuantity).Append("\n");
            sb.Append("  PendingTransshipmentQuantity: ").Append(PendingTransshipmentQuantity).Append("\n");
            sb.Append("  FcProcessingQuantity: ").Append(FcProcessingQuantity).Append("\n");
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
            return this.Equals(input as ReservedQuantity);
        }

        /// <summary>
        /// Returns true if ReservedQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of ReservedQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReservedQuantity input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TotalReservedQuantity == input.TotalReservedQuantity ||
                    (this.TotalReservedQuantity != null &&
                    this.TotalReservedQuantity.Equals(input.TotalReservedQuantity))
                ) &&
                (
                    this.PendingCustomerOrderQuantity == input.PendingCustomerOrderQuantity ||
                    (this.PendingCustomerOrderQuantity != null &&
                    this.PendingCustomerOrderQuantity.Equals(input.PendingCustomerOrderQuantity))
                ) &&
                (
                    this.PendingTransshipmentQuantity == input.PendingTransshipmentQuantity ||
                    (this.PendingTransshipmentQuantity != null &&
                    this.PendingTransshipmentQuantity.Equals(input.PendingTransshipmentQuantity))
                ) &&
                (
                    this.FcProcessingQuantity == input.FcProcessingQuantity ||
                    (this.FcProcessingQuantity != null &&
                    this.FcProcessingQuantity.Equals(input.FcProcessingQuantity))
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
                if (this.TotalReservedQuantity != null)
                    hashCode = hashCode * 59 + this.TotalReservedQuantity.GetHashCode();
                if (this.PendingCustomerOrderQuantity != null)
                    hashCode = hashCode * 59 + this.PendingCustomerOrderQuantity.GetHashCode();
                if (this.PendingTransshipmentQuantity != null)
                    hashCode = hashCode * 59 + this.PendingTransshipmentQuantity.GetHashCode();
                if (this.FcProcessingQuantity != null)
                    hashCode = hashCode * 59 + this.FcProcessingQuantity.GetHashCode();
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
