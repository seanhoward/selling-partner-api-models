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
    /// Payload for creating an inbound order.
    /// </summary>
    [DataContract]
    public partial class InboundOrderCreationData :  IEquatable<InboundOrderCreationData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundOrderCreationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboundOrderCreationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundOrderCreationData" /> class.
        /// </summary>
        /// <param name="externalReferenceId">Reference ID that can be used to correlate the order with partner resources..</param>
        /// <param name="originAddress">Origin address from where the inbound order will be shipped. (required).</param>
        /// <param name="packagesToInbound">List of packages to be inbounded. (required).</param>
        /// <param name="preferences">preferences.</param>
        /// <param name="shipBy">Estimated date by when goods have to be picked up..</param>
        public InboundOrderCreationData(string externalReferenceId = default(string), Address originAddress = default(Address), List<DistributionPackageQuantity> packagesToInbound = default(List<DistributionPackageQuantity>), InboundPreferences preferences = default(InboundPreferences), DateTime? shipBy = default(DateTime?))
        {
            // to ensure "originAddress" is required (not null)
            if (originAddress == null)
            {
                throw new InvalidDataException("originAddress is a required property for InboundOrderCreationData and cannot be null");
            }
            else
            {
                this.OriginAddress = originAddress;
            }
            // to ensure "packagesToInbound" is required (not null)
            if (packagesToInbound == null)
            {
                throw new InvalidDataException("packagesToInbound is a required property for InboundOrderCreationData and cannot be null");
            }
            else
            {
                this.PackagesToInbound = packagesToInbound;
            }
            this.ExternalReferenceId = externalReferenceId;
            this.Preferences = preferences;
            this.ShipBy = shipBy;
        }
        
        /// <summary>
        /// Reference ID that can be used to correlate the order with partner resources.
        /// </summary>
        /// <value>Reference ID that can be used to correlate the order with partner resources.</value>
        [DataMember(Name="externalReferenceId", EmitDefaultValue=false)]
        public string ExternalReferenceId { get; set; }

        /// <summary>
        /// Origin address from where the inbound order will be shipped.
        /// </summary>
        /// <value>Origin address from where the inbound order will be shipped.</value>
        [DataMember(Name="originAddress", EmitDefaultValue=false)]
        public Address OriginAddress { get; set; }

        /// <summary>
        /// List of packages to be inbounded.
        /// </summary>
        /// <value>List of packages to be inbounded.</value>
        [DataMember(Name="packagesToInbound", EmitDefaultValue=false)]
        public List<DistributionPackageQuantity> PackagesToInbound { get; set; }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public InboundPreferences Preferences { get; set; }

        /// <summary>
        /// Estimated date by when goods have to be picked up.
        /// </summary>
        /// <value>Estimated date by when goods have to be picked up.</value>
        [DataMember(Name="shipBy", EmitDefaultValue=false)]
        public DateTime? ShipBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundOrderCreationData {\n");
            sb.Append("  ExternalReferenceId: ").Append(ExternalReferenceId).Append("\n");
            sb.Append("  OriginAddress: ").Append(OriginAddress).Append("\n");
            sb.Append("  PackagesToInbound: ").Append(PackagesToInbound).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  ShipBy: ").Append(ShipBy).Append("\n");
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
            return this.Equals(input as InboundOrderCreationData);
        }

        /// <summary>
        /// Returns true if InboundOrderCreationData instances are equal
        /// </summary>
        /// <param name="input">Instance of InboundOrderCreationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundOrderCreationData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalReferenceId == input.ExternalReferenceId ||
                    (this.ExternalReferenceId != null &&
                    this.ExternalReferenceId.Equals(input.ExternalReferenceId))
                ) && 
                (
                    this.OriginAddress == input.OriginAddress ||
                    (this.OriginAddress != null &&
                    this.OriginAddress.Equals(input.OriginAddress))
                ) && 
                (
                    this.PackagesToInbound == input.PackagesToInbound ||
                    this.PackagesToInbound != null &&
                    this.PackagesToInbound.SequenceEqual(input.PackagesToInbound)
                ) && 
                (
                    this.Preferences == input.Preferences ||
                    (this.Preferences != null &&
                    this.Preferences.Equals(input.Preferences))
                ) && 
                (
                    this.ShipBy == input.ShipBy ||
                    (this.ShipBy != null &&
                    this.ShipBy.Equals(input.ShipBy))
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
                if (this.ExternalReferenceId != null)
                    hashCode = hashCode * 59 + this.ExternalReferenceId.GetHashCode();
                if (this.OriginAddress != null)
                    hashCode = hashCode * 59 + this.OriginAddress.GetHashCode();
                if (this.PackagesToInbound != null)
                    hashCode = hashCode * 59 + this.PackagesToInbound.GetHashCode();
                if (this.Preferences != null)
                    hashCode = hashCode * 59 + this.Preferences.GetHashCode();
                if (this.ShipBy != null)
                    hashCode = hashCode * 59 + this.ShipBy.GetHashCode();
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
