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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FbaInventory
{
    /// <summary>
    /// Summarized inventory details. This object will not appear if the details parameter in the request is false.
    /// </summary>
    [DataContract]
    public partial class InventoryDetails :  IEquatable<InventoryDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryDetails" /> class.
        /// </summary>
        /// <param name="fulfillableQuantity">The item quantity that can be picked, packed, and shipped..</param>
        /// <param name="inboundWorkingQuantity">The number of units in an inbound shipment for which you have notified Amazon..</param>
        /// <param name="inboundShippedQuantity">The number of units in an inbound shipment that you have notified Amazon about and have provided a tracking number..</param>
        /// <param name="inboundReceivingQuantity">The number of units that have not yet been received at an Amazon fulfillment center for processing, but are part of an inbound shipment with some units that have already been received and processed..</param>
        /// <param name="reservedQuantity">reservedQuantity.</param>
        /// <param name="researchingQuantity">researchingQuantity.</param>
        /// <param name="unfulfillableQuantity">unfulfillableQuantity.</param>
        public InventoryDetails(int? fulfillableQuantity = default(int?), int? inboundWorkingQuantity = default(int?), int? inboundShippedQuantity = default(int?), int? inboundReceivingQuantity = default(int?), ReservedQuantity reservedQuantity = default(ReservedQuantity), ResearchingQuantity researchingQuantity = default(ResearchingQuantity), UnfulfillableQuantity unfulfillableQuantity = default(UnfulfillableQuantity))
        {
            this.FulfillableQuantity = fulfillableQuantity;
            this.InboundWorkingQuantity = inboundWorkingQuantity;
            this.InboundShippedQuantity = inboundShippedQuantity;
            this.InboundReceivingQuantity = inboundReceivingQuantity;
            this.ReservedQuantity = reservedQuantity;
            this.ResearchingQuantity = researchingQuantity;
            this.UnfulfillableQuantity = unfulfillableQuantity;
        }
        
        /// <summary>
        /// The item quantity that can be picked, packed, and shipped.
        /// </summary>
        /// <value>The item quantity that can be picked, packed, and shipped.</value>
        [DataMember(Name="fulfillableQuantity", EmitDefaultValue=false)]
        public int? FulfillableQuantity { get; set; }

        /// <summary>
        /// The number of units in an inbound shipment for which you have notified Amazon.
        /// </summary>
        /// <value>The number of units in an inbound shipment for which you have notified Amazon.</value>
        [DataMember(Name="inboundWorkingQuantity", EmitDefaultValue=false)]
        public int? InboundWorkingQuantity { get; set; }

        /// <summary>
        /// The number of units in an inbound shipment that you have notified Amazon about and have provided a tracking number.
        /// </summary>
        /// <value>The number of units in an inbound shipment that you have notified Amazon about and have provided a tracking number.</value>
        [DataMember(Name="inboundShippedQuantity", EmitDefaultValue=false)]
        public int? InboundShippedQuantity { get; set; }

        /// <summary>
        /// The number of units that have not yet been received at an Amazon fulfillment center for processing, but are part of an inbound shipment with some units that have already been received and processed.
        /// </summary>
        /// <value>The number of units that have not yet been received at an Amazon fulfillment center for processing, but are part of an inbound shipment with some units that have already been received and processed.</value>
        [DataMember(Name="inboundReceivingQuantity", EmitDefaultValue=false)]
        public int? InboundReceivingQuantity { get; set; }

        /// <summary>
        /// Gets or Sets ReservedQuantity
        /// </summary>
        [DataMember(Name="reservedQuantity", EmitDefaultValue=false)]
        public ReservedQuantity ReservedQuantity { get; set; }

        /// <summary>
        /// Gets or Sets ResearchingQuantity
        /// </summary>
        [DataMember(Name="researchingQuantity", EmitDefaultValue=false)]
        public ResearchingQuantity ResearchingQuantity { get; set; }

        /// <summary>
        /// Gets or Sets UnfulfillableQuantity
        /// </summary>
        [DataMember(Name="unfulfillableQuantity", EmitDefaultValue=false)]
        public UnfulfillableQuantity UnfulfillableQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryDetails {\n");
            sb.Append("  FulfillableQuantity: ").Append(FulfillableQuantity).Append("\n");
            sb.Append("  InboundWorkingQuantity: ").Append(InboundWorkingQuantity).Append("\n");
            sb.Append("  InboundShippedQuantity: ").Append(InboundShippedQuantity).Append("\n");
            sb.Append("  InboundReceivingQuantity: ").Append(InboundReceivingQuantity).Append("\n");
            sb.Append("  ReservedQuantity: ").Append(ReservedQuantity).Append("\n");
            sb.Append("  ResearchingQuantity: ").Append(ResearchingQuantity).Append("\n");
            sb.Append("  UnfulfillableQuantity: ").Append(UnfulfillableQuantity).Append("\n");
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
            return this.Equals(input as InventoryDetails);
        }

        /// <summary>
        /// Returns true if InventoryDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FulfillableQuantity == input.FulfillableQuantity ||
                    (this.FulfillableQuantity != null &&
                    this.FulfillableQuantity.Equals(input.FulfillableQuantity))
                ) && 
                (
                    this.InboundWorkingQuantity == input.InboundWorkingQuantity ||
                    (this.InboundWorkingQuantity != null &&
                    this.InboundWorkingQuantity.Equals(input.InboundWorkingQuantity))
                ) && 
                (
                    this.InboundShippedQuantity == input.InboundShippedQuantity ||
                    (this.InboundShippedQuantity != null &&
                    this.InboundShippedQuantity.Equals(input.InboundShippedQuantity))
                ) && 
                (
                    this.InboundReceivingQuantity == input.InboundReceivingQuantity ||
                    (this.InboundReceivingQuantity != null &&
                    this.InboundReceivingQuantity.Equals(input.InboundReceivingQuantity))
                ) && 
                (
                    this.ReservedQuantity == input.ReservedQuantity ||
                    (this.ReservedQuantity != null &&
                    this.ReservedQuantity.Equals(input.ReservedQuantity))
                ) && 
                (
                    this.ResearchingQuantity == input.ResearchingQuantity ||
                    (this.ResearchingQuantity != null &&
                    this.ResearchingQuantity.Equals(input.ResearchingQuantity))
                ) && 
                (
                    this.UnfulfillableQuantity == input.UnfulfillableQuantity ||
                    (this.UnfulfillableQuantity != null &&
                    this.UnfulfillableQuantity.Equals(input.UnfulfillableQuantity))
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
                if (this.FulfillableQuantity != null)
                    hashCode = hashCode * 59 + this.FulfillableQuantity.GetHashCode();
                if (this.InboundWorkingQuantity != null)
                    hashCode = hashCode * 59 + this.InboundWorkingQuantity.GetHashCode();
                if (this.InboundShippedQuantity != null)
                    hashCode = hashCode * 59 + this.InboundShippedQuantity.GetHashCode();
                if (this.InboundReceivingQuantity != null)
                    hashCode = hashCode * 59 + this.InboundReceivingQuantity.GetHashCode();
                if (this.ReservedQuantity != null)
                    hashCode = hashCode * 59 + this.ReservedQuantity.GetHashCode();
                if (this.ResearchingQuantity != null)
                    hashCode = hashCode * 59 + this.ResearchingQuantity.GetHashCode();
                if (this.UnfulfillableQuantity != null)
                    hashCode = hashCode * 59 + this.UnfulfillableQuantity.GetHashCode();
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
