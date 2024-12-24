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
    /// Represents an AWD inbound order.
    /// </summary>
    [DataContract]
    public partial class InboundOrder :  IEquatable<InboundOrder>, IValidatableObject
    {
        /// <summary>
        /// Inbound order status.
        /// </summary>
        /// <value>Inbound order status.</value>
        [DataMember(Name="orderStatus", EmitDefaultValue=false)]
        public InboundStatus OrderStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboundOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundOrder" /> class.
        /// </summary>
        /// <param name="channelPlacedInboundShipments">List of inbound shipments part of this order. (required).</param>
        /// <param name="createdAt">Date when this order was created. (required).</param>
        /// <param name="externalReferenceId">Reference ID that can be used to correlate the order with partner resources..</param>
        /// <param name="orderId">Inbound order ID. (required).</param>
        /// <param name="orderStatus">Inbound order status. (required).</param>
        /// <param name="orderVersion">Inbound order version. (required).</param>
        /// <param name="originAddress">Origin address from where the inbound order will be shipped. (required).</param>
        /// <param name="packagesToInbound">List of packages to be inbounded. (required).</param>
        /// <param name="preferences">preferences.</param>
        /// <param name="shipBy">Date by which this order will be shipped..</param>
        /// <param name="updatedAt">Date when this order was last updated..</param>
        public InboundOrder(List<InboundShipment> channelPlacedInboundShipments = default(List<InboundShipment>), DateTime? createdAt = default(DateTime?), string externalReferenceId = default(string), string orderId = default(string), InboundStatus orderStatus = default(InboundStatus), string orderVersion = default(string), Address originAddress = default(Address), List<DistributionPackageQuantity> packagesToInbound = default(List<DistributionPackageQuantity>), InboundPreferences preferences = default(InboundPreferences), DateTime? shipBy = default(DateTime?), DateTime? updatedAt = default(DateTime?))
        {
            // to ensure "channelPlacedInboundShipments" is required (not null)
            if (channelPlacedInboundShipments == null)
            {
                throw new InvalidDataException("channelPlacedInboundShipments is a required property for InboundOrder and cannot be null");
            }
            else
            {
                this.ChannelPlacedInboundShipments = channelPlacedInboundShipments;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for InboundOrder and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new InvalidDataException("orderId is a required property for InboundOrder and cannot be null");
            }
            else
            {
                this.OrderId = orderId;
            }
            // to ensure "orderStatus" is required (not null)
            if (orderStatus == null)
            {
                throw new InvalidDataException("orderStatus is a required property for InboundOrder and cannot be null");
            }
            else
            {
                this.OrderStatus = orderStatus;
            }
            // to ensure "orderVersion" is required (not null)
            if (orderVersion == null)
            {
                throw new InvalidDataException("orderVersion is a required property for InboundOrder and cannot be null");
            }
            else
            {
                this.OrderVersion = orderVersion;
            }
            // to ensure "originAddress" is required (not null)
            if (originAddress == null)
            {
                throw new InvalidDataException("originAddress is a required property for InboundOrder and cannot be null");
            }
            else
            {
                this.OriginAddress = originAddress;
            }
            // to ensure "packagesToInbound" is required (not null)
            if (packagesToInbound == null)
            {
                throw new InvalidDataException("packagesToInbound is a required property for InboundOrder and cannot be null");
            }
            else
            {
                this.PackagesToInbound = packagesToInbound;
            }
            this.ExternalReferenceId = externalReferenceId;
            this.Preferences = preferences;
            this.ShipBy = shipBy;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// List of inbound shipments part of this order.
        /// </summary>
        /// <value>List of inbound shipments part of this order.</value>
        [DataMember(Name="channelPlacedInboundShipments", EmitDefaultValue=false)]
        public List<InboundShipment> ChannelPlacedInboundShipments { get; set; }

        /// <summary>
        /// Date when this order was created.
        /// </summary>
        /// <value>Date when this order was created.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Reference ID that can be used to correlate the order with partner resources.
        /// </summary>
        /// <value>Reference ID that can be used to correlate the order with partner resources.</value>
        [DataMember(Name="externalReferenceId", EmitDefaultValue=false)]
        public string ExternalReferenceId { get; set; }

        /// <summary>
        /// Inbound order ID.
        /// </summary>
        /// <value>Inbound order ID.</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public string OrderId { get; set; }


        /// <summary>
        /// Inbound order version.
        /// </summary>
        /// <value>Inbound order version.</value>
        [DataMember(Name="orderVersion", EmitDefaultValue=false)]
        public string OrderVersion { get; set; }

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
        /// Date by which this order will be shipped.
        /// </summary>
        /// <value>Date by which this order will be shipped.</value>
        [DataMember(Name="shipBy", EmitDefaultValue=false)]
        public DateTime? ShipBy { get; set; }

        /// <summary>
        /// Date when this order was last updated.
        /// </summary>
        /// <value>Date when this order was last updated.</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundOrder {\n");
            sb.Append("  ChannelPlacedInboundShipments: ").Append(ChannelPlacedInboundShipments).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExternalReferenceId: ").Append(ExternalReferenceId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  OrderVersion: ").Append(OrderVersion).Append("\n");
            sb.Append("  OriginAddress: ").Append(OriginAddress).Append("\n");
            sb.Append("  PackagesToInbound: ").Append(PackagesToInbound).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  ShipBy: ").Append(ShipBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as InboundOrder);
        }

        /// <summary>
        /// Returns true if InboundOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of InboundOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelPlacedInboundShipments == input.ChannelPlacedInboundShipments ||
                    this.ChannelPlacedInboundShipments != null &&
                    this.ChannelPlacedInboundShipments.SequenceEqual(input.ChannelPlacedInboundShipments)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ExternalReferenceId == input.ExternalReferenceId ||
                    (this.ExternalReferenceId != null &&
                    this.ExternalReferenceId.Equals(input.ExternalReferenceId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
                ) && 
                (
                    this.OrderVersion == input.OrderVersion ||
                    (this.OrderVersion != null &&
                    this.OrderVersion.Equals(input.OrderVersion))
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
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.ChannelPlacedInboundShipments != null)
                    hashCode = hashCode * 59 + this.ChannelPlacedInboundShipments.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ExternalReferenceId != null)
                    hashCode = hashCode * 59 + this.ExternalReferenceId.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OrderStatus != null)
                    hashCode = hashCode * 59 + this.OrderStatus.GetHashCode();
                if (this.OrderVersion != null)
                    hashCode = hashCode * 59 + this.OrderVersion.GetHashCode();
                if (this.OriginAddress != null)
                    hashCode = hashCode * 59 + this.OriginAddress.GetHashCode();
                if (this.PackagesToInbound != null)
                    hashCode = hashCode * 59 + this.PackagesToInbound.GetHashCode();
                if (this.Preferences != null)
                    hashCode = hashCode * 59 + this.Preferences.GetHashCode();
                if (this.ShipBy != null)
                    hashCode = hashCode * 59 + this.ShipBy.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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