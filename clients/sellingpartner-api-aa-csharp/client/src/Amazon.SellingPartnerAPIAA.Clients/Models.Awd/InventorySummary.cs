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
    /// Summary of inventory per SKU.
    /// </summary>
    [DataContract]
    public partial class InventorySummary :  IEquatable<InventorySummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventorySummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InventorySummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InventorySummary" /> class.
        /// </summary>
        /// <param name="expirationDetails">The expiration details of the inventory. This object will only appear if the &#x60;details&#x60; parameter in the request is set to &#x60;SHOW&#x60;..</param>
        /// <param name="inventoryDetails">inventoryDetails.</param>
        /// <param name="sku">The seller or merchant SKU. (required).</param>
        /// <param name="totalInboundQuantity">Total quantity that is in-transit from the seller and has not yet been received at an AWD Distribution Center.</param>
        /// <param name="totalOnhandQuantity">Total quantity that is present in AWD distribution centers..</param>
        public InventorySummary(List<ExpirationDetails> expirationDetails = default(List<ExpirationDetails>), InventoryDetails inventoryDetails = default(InventoryDetails), string sku = default(string), long? totalInboundQuantity = default(long?), long? totalOnhandQuantity = default(long?))
        {
            // to ensure "sku" is required (not null)
            if (sku == null)
            {
                throw new InvalidDataException("sku is a required property for InventorySummary and cannot be null");
            }
            else
            {
                this.Sku = sku;
            }
            this.ExpirationDetails = expirationDetails;
            this.InventoryDetails = inventoryDetails;
            this.TotalInboundQuantity = totalInboundQuantity;
            this.TotalOnhandQuantity = totalOnhandQuantity;
        }
        
        /// <summary>
        /// The expiration details of the inventory. This object will only appear if the &#x60;details&#x60; parameter in the request is set to &#x60;SHOW&#x60;.
        /// </summary>
        /// <value>The expiration details of the inventory. This object will only appear if the &#x60;details&#x60; parameter in the request is set to &#x60;SHOW&#x60;.</value>
        [DataMember(Name="expirationDetails", EmitDefaultValue=false)]
        public List<ExpirationDetails> ExpirationDetails { get; set; }

        /// <summary>
        /// Gets or Sets InventoryDetails
        /// </summary>
        [DataMember(Name="inventoryDetails", EmitDefaultValue=false)]
        public InventoryDetails InventoryDetails { get; set; }

        /// <summary>
        /// The seller or merchant SKU.
        /// </summary>
        /// <value>The seller or merchant SKU.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Total quantity that is in-transit from the seller and has not yet been received at an AWD Distribution Center
        /// </summary>
        /// <value>Total quantity that is in-transit from the seller and has not yet been received at an AWD Distribution Center</value>
        [DataMember(Name="totalInboundQuantity", EmitDefaultValue=false)]
        public long? TotalInboundQuantity { get; set; }

        /// <summary>
        /// Total quantity that is present in AWD distribution centers.
        /// </summary>
        /// <value>Total quantity that is present in AWD distribution centers.</value>
        [DataMember(Name="totalOnhandQuantity", EmitDefaultValue=false)]
        public long? TotalOnhandQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventorySummary {\n");
            sb.Append("  ExpirationDetails: ").Append(ExpirationDetails).Append("\n");
            sb.Append("  InventoryDetails: ").Append(InventoryDetails).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  TotalInboundQuantity: ").Append(TotalInboundQuantity).Append("\n");
            sb.Append("  TotalOnhandQuantity: ").Append(TotalOnhandQuantity).Append("\n");
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
            return this.Equals(input as InventorySummary);
        }

        /// <summary>
        /// Returns true if InventorySummary instances are equal
        /// </summary>
        /// <param name="input">Instance of InventorySummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventorySummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpirationDetails == input.ExpirationDetails ||
                    this.ExpirationDetails != null &&
                    this.ExpirationDetails.SequenceEqual(input.ExpirationDetails)
                ) && 
                (
                    this.InventoryDetails == input.InventoryDetails ||
                    (this.InventoryDetails != null &&
                    this.InventoryDetails.Equals(input.InventoryDetails))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.TotalInboundQuantity == input.TotalInboundQuantity ||
                    (this.TotalInboundQuantity != null &&
                    this.TotalInboundQuantity.Equals(input.TotalInboundQuantity))
                ) && 
                (
                    this.TotalOnhandQuantity == input.TotalOnhandQuantity ||
                    (this.TotalOnhandQuantity != null &&
                    this.TotalOnhandQuantity.Equals(input.TotalOnhandQuantity))
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
                if (this.ExpirationDetails != null)
                    hashCode = hashCode * 59 + this.ExpirationDetails.GetHashCode();
                if (this.InventoryDetails != null)
                    hashCode = hashCode * 59 + this.InventoryDetails.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.TotalInboundQuantity != null)
                    hashCode = hashCode * 59 + this.TotalInboundQuantity.GetHashCode();
                if (this.TotalOnhandQuantity != null)
                    hashCode = hashCode * 59 + this.TotalOnhandQuantity.GetHashCode();
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
