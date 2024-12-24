/* 
 * The Selling Partner API for Amazon Warehousing and Distribution
 *
 * The Selling Partner API for Amazon Warehousing and Distribution (AWD) provides programmatic access to information about AWD shipments and inventory. 
 *
 * OpenAPI spec version: 2024-05-09
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Awd
{
    /// <summary>
    /// Additional inventory details. This object is only displayed if the details parameter in the request is set to &#x60;SHOW&#x60;.
    /// </summary>
    [DataContract]
    public partial class InventoryDetails :  IEquatable<InventoryDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryDetails" /> class.
        /// </summary>
        /// <param name="availableDistributableQuantity">Quantity that is available for downstream channel replenishment..</param>
        /// <param name="reservedDistributableQuantity">Quantity that is reserved for a downstream channel replenishment order that is being prepared for shipment..</param>
        public InventoryDetails(long? availableDistributableQuantity = default(long?), long? reservedDistributableQuantity = default(long?))
        {
            this.AvailableDistributableQuantity = availableDistributableQuantity;
            this.ReservedDistributableQuantity = reservedDistributableQuantity;
        }
        
        /// <summary>
        /// Quantity that is available for downstream channel replenishment.
        /// </summary>
        /// <value>Quantity that is available for downstream channel replenishment.</value>
        [DataMember(Name="availableDistributableQuantity", EmitDefaultValue=false)]
        public long? AvailableDistributableQuantity { get; set; }

        /// <summary>
        /// Quantity that is reserved for a downstream channel replenishment order that is being prepared for shipment.
        /// </summary>
        /// <value>Quantity that is reserved for a downstream channel replenishment order that is being prepared for shipment.</value>
        [DataMember(Name="reservedDistributableQuantity", EmitDefaultValue=false)]
        public long? ReservedDistributableQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryDetails {\n");
            sb.Append("  AvailableDistributableQuantity: ").Append(AvailableDistributableQuantity).Append("\n");
            sb.Append("  ReservedDistributableQuantity: ").Append(ReservedDistributableQuantity).Append("\n");
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
                    this.AvailableDistributableQuantity == input.AvailableDistributableQuantity ||
                    (this.AvailableDistributableQuantity != null &&
                    this.AvailableDistributableQuantity.Equals(input.AvailableDistributableQuantity))
                ) && 
                (
                    this.ReservedDistributableQuantity == input.ReservedDistributableQuantity ||
                    (this.ReservedDistributableQuantity != null &&
                    this.ReservedDistributableQuantity.Equals(input.ReservedDistributableQuantity))
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
                if (this.AvailableDistributableQuantity != null)
                    hashCode = hashCode * 59 + this.AvailableDistributableQuantity.GetHashCode();
                if (this.ReservedDistributableQuantity != null)
                    hashCode = hashCode * 59 + this.ReservedDistributableQuantity.GetHashCode();
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