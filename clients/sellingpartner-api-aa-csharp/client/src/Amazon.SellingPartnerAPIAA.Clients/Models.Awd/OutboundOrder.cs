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
    /// Represents an AWD outbound order.
    /// </summary>
    [DataContract]
    public partial class OutboundOrder :  IEquatable<OutboundOrder>, IValidatableObject
    {
        /// <summary>
        /// Status for the outbound order.
        /// </summary>
        /// <value>Status for the outbound order.</value>
        [DataMember(Name="orderStatus", EmitDefaultValue=false)]
        public OutboundStatus OrderStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutboundOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundOrder" /> class.
        /// </summary>
        /// <param name="confirmedOn">Date on which this outbound order was confirmed..</param>
        /// <param name="createdAt">Date on which this outbound order was created..</param>
        /// <param name="eligiblePackagesToOutbound">List of packages that are eligible for outbound..</param>
        /// <param name="eligibleProductsToOutbound">List of product units that are eligible for outbound..</param>
        /// <param name="executionErrors">Execution errors associated with the outbound order. This field will be populated if the order failed validation..</param>
        /// <param name="orderId">Order ID for the outbound order. (required).</param>
        /// <param name="orderPreferences">Order preferences for this outbound order..</param>
        /// <param name="orderStatus">Status for the outbound order. (required).</param>
        /// <param name="outboundShipments">List of outbound shipments that are part of this order. (required).</param>
        /// <param name="packagesToOutbound">List of packages to be outbound..</param>
        /// <param name="productsToOutbound">List of product units to be outbound..</param>
        /// <param name="shippedOutboundPackages">Outbound packages that are shipped after the execution has completed post confirmation..</param>
        /// <param name="shippedOutboundProducts">Outbound product units that are shipped after the execution has completed post confirmation..</param>
        /// <param name="updatedAt">Date on which this outbound order was last updated..</param>
        public OutboundOrder(DateTime? confirmedOn = default(DateTime?), DateTime? createdAt = default(DateTime?), List<DistributionPackageQuantity> eligiblePackagesToOutbound = default(List<DistributionPackageQuantity>), List<ProductQuantity> eligibleProductsToOutbound = default(List<ProductQuantity>), List<OutboundExecutionError> executionErrors = default(List<OutboundExecutionError>), string orderId = default(string), List<OrderAttribute> orderPreferences = default(List<OrderAttribute>), OutboundStatus orderStatus = default(OutboundStatus), List<OutboundShipment> outboundShipments = default(List<OutboundShipment>), List<DistributionPackageQuantity> packagesToOutbound = default(List<DistributionPackageQuantity>), List<ProductQuantity> productsToOutbound = default(List<ProductQuantity>), List<DistributionPackageQuantity> shippedOutboundPackages = default(List<DistributionPackageQuantity>), List<ProductQuantity> shippedOutboundProducts = default(List<ProductQuantity>), DateTime? updatedAt = default(DateTime?))
        {
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new InvalidDataException("orderId is a required property for OutboundOrder and cannot be null");
            }
            else
            {
                this.OrderId = orderId;
            }
            // to ensure "orderStatus" is required (not null)
            if (orderStatus == null)
            {
                throw new InvalidDataException("orderStatus is a required property for OutboundOrder and cannot be null");
            }
            else
            {
                this.OrderStatus = orderStatus;
            }
            // to ensure "outboundShipments" is required (not null)
            if (outboundShipments == null)
            {
                throw new InvalidDataException("outboundShipments is a required property for OutboundOrder and cannot be null");
            }
            else
            {
                this.OutboundShipments = outboundShipments;
            }
            this.ConfirmedOn = confirmedOn;
            this.CreatedAt = createdAt;
            this.EligiblePackagesToOutbound = eligiblePackagesToOutbound;
            this.EligibleProductsToOutbound = eligibleProductsToOutbound;
            this.ExecutionErrors = executionErrors;
            this.OrderPreferences = orderPreferences;
            this.PackagesToOutbound = packagesToOutbound;
            this.ProductsToOutbound = productsToOutbound;
            this.ShippedOutboundPackages = shippedOutboundPackages;
            this.ShippedOutboundProducts = shippedOutboundProducts;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// Date on which this outbound order was confirmed.
        /// </summary>
        /// <value>Date on which this outbound order was confirmed.</value>
        [DataMember(Name="confirmedOn", EmitDefaultValue=false)]
        public DateTime? ConfirmedOn { get; set; }

        /// <summary>
        /// Date on which this outbound order was created.
        /// </summary>
        /// <value>Date on which this outbound order was created.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// List of packages that are eligible for outbound.
        /// </summary>
        /// <value>List of packages that are eligible for outbound.</value>
        [DataMember(Name="eligiblePackagesToOutbound", EmitDefaultValue=false)]
        public List<DistributionPackageQuantity> EligiblePackagesToOutbound { get; set; }

        /// <summary>
        /// List of product units that are eligible for outbound.
        /// </summary>
        /// <value>List of product units that are eligible for outbound.</value>
        [DataMember(Name="eligibleProductsToOutbound", EmitDefaultValue=false)]
        public List<ProductQuantity> EligibleProductsToOutbound { get; set; }

        /// <summary>
        /// Execution errors associated with the outbound order. This field will be populated if the order failed validation.
        /// </summary>
        /// <value>Execution errors associated with the outbound order. This field will be populated if the order failed validation.</value>
        [DataMember(Name="executionErrors", EmitDefaultValue=false)]
        public List<OutboundExecutionError> ExecutionErrors { get; set; }

        /// <summary>
        /// Order ID for the outbound order.
        /// </summary>
        /// <value>Order ID for the outbound order.</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Order preferences for this outbound order.
        /// </summary>
        /// <value>Order preferences for this outbound order.</value>
        [DataMember(Name="orderPreferences", EmitDefaultValue=false)]
        public List<OrderAttribute> OrderPreferences { get; set; }


        /// <summary>
        /// List of outbound shipments that are part of this order.
        /// </summary>
        /// <value>List of outbound shipments that are part of this order.</value>
        [DataMember(Name="outboundShipments", EmitDefaultValue=false)]
        public List<OutboundShipment> OutboundShipments { get; set; }

        /// <summary>
        /// List of packages to be outbound.
        /// </summary>
        /// <value>List of packages to be outbound.</value>
        [DataMember(Name="packagesToOutbound", EmitDefaultValue=false)]
        public List<DistributionPackageQuantity> PackagesToOutbound { get; set; }

        /// <summary>
        /// List of product units to be outbound.
        /// </summary>
        /// <value>List of product units to be outbound.</value>
        [DataMember(Name="productsToOutbound", EmitDefaultValue=false)]
        public List<ProductQuantity> ProductsToOutbound { get; set; }

        /// <summary>
        /// Outbound packages that are shipped after the execution has completed post confirmation.
        /// </summary>
        /// <value>Outbound packages that are shipped after the execution has completed post confirmation.</value>
        [DataMember(Name="shippedOutboundPackages", EmitDefaultValue=false)]
        public List<DistributionPackageQuantity> ShippedOutboundPackages { get; set; }

        /// <summary>
        /// Outbound product units that are shipped after the execution has completed post confirmation.
        /// </summary>
        /// <value>Outbound product units that are shipped after the execution has completed post confirmation.</value>
        [DataMember(Name="shippedOutboundProducts", EmitDefaultValue=false)]
        public List<ProductQuantity> ShippedOutboundProducts { get; set; }

        /// <summary>
        /// Date on which this outbound order was last updated.
        /// </summary>
        /// <value>Date on which this outbound order was last updated.</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundOrder {\n");
            sb.Append("  ConfirmedOn: ").Append(ConfirmedOn).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EligiblePackagesToOutbound: ").Append(EligiblePackagesToOutbound).Append("\n");
            sb.Append("  EligibleProductsToOutbound: ").Append(EligibleProductsToOutbound).Append("\n");
            sb.Append("  ExecutionErrors: ").Append(ExecutionErrors).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderPreferences: ").Append(OrderPreferences).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  OutboundShipments: ").Append(OutboundShipments).Append("\n");
            sb.Append("  PackagesToOutbound: ").Append(PackagesToOutbound).Append("\n");
            sb.Append("  ProductsToOutbound: ").Append(ProductsToOutbound).Append("\n");
            sb.Append("  ShippedOutboundPackages: ").Append(ShippedOutboundPackages).Append("\n");
            sb.Append("  ShippedOutboundProducts: ").Append(ShippedOutboundProducts).Append("\n");
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
            return this.Equals(input as OutboundOrder);
        }

        /// <summary>
        /// Returns true if OutboundOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of OutboundOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfirmedOn == input.ConfirmedOn ||
                    (this.ConfirmedOn != null &&
                    this.ConfirmedOn.Equals(input.ConfirmedOn))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.EligiblePackagesToOutbound == input.EligiblePackagesToOutbound ||
                    this.EligiblePackagesToOutbound != null &&
                    this.EligiblePackagesToOutbound.SequenceEqual(input.EligiblePackagesToOutbound)
                ) && 
                (
                    this.EligibleProductsToOutbound == input.EligibleProductsToOutbound ||
                    this.EligibleProductsToOutbound != null &&
                    this.EligibleProductsToOutbound.SequenceEqual(input.EligibleProductsToOutbound)
                ) && 
                (
                    this.ExecutionErrors == input.ExecutionErrors ||
                    this.ExecutionErrors != null &&
                    this.ExecutionErrors.SequenceEqual(input.ExecutionErrors)
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OrderPreferences == input.OrderPreferences ||
                    this.OrderPreferences != null &&
                    this.OrderPreferences.SequenceEqual(input.OrderPreferences)
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
                ) && 
                (
                    this.OutboundShipments == input.OutboundShipments ||
                    this.OutboundShipments != null &&
                    this.OutboundShipments.SequenceEqual(input.OutboundShipments)
                ) && 
                (
                    this.PackagesToOutbound == input.PackagesToOutbound ||
                    this.PackagesToOutbound != null &&
                    this.PackagesToOutbound.SequenceEqual(input.PackagesToOutbound)
                ) && 
                (
                    this.ProductsToOutbound == input.ProductsToOutbound ||
                    this.ProductsToOutbound != null &&
                    this.ProductsToOutbound.SequenceEqual(input.ProductsToOutbound)
                ) && 
                (
                    this.ShippedOutboundPackages == input.ShippedOutboundPackages ||
                    this.ShippedOutboundPackages != null &&
                    this.ShippedOutboundPackages.SequenceEqual(input.ShippedOutboundPackages)
                ) && 
                (
                    this.ShippedOutboundProducts == input.ShippedOutboundProducts ||
                    this.ShippedOutboundProducts != null &&
                    this.ShippedOutboundProducts.SequenceEqual(input.ShippedOutboundProducts)
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
                if (this.ConfirmedOn != null)
                    hashCode = hashCode * 59 + this.ConfirmedOn.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.EligiblePackagesToOutbound != null)
                    hashCode = hashCode * 59 + this.EligiblePackagesToOutbound.GetHashCode();
                if (this.EligibleProductsToOutbound != null)
                    hashCode = hashCode * 59 + this.EligibleProductsToOutbound.GetHashCode();
                if (this.ExecutionErrors != null)
                    hashCode = hashCode * 59 + this.ExecutionErrors.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OrderPreferences != null)
                    hashCode = hashCode * 59 + this.OrderPreferences.GetHashCode();
                if (this.OrderStatus != null)
                    hashCode = hashCode * 59 + this.OrderStatus.GetHashCode();
                if (this.OutboundShipments != null)
                    hashCode = hashCode * 59 + this.OutboundShipments.GetHashCode();
                if (this.PackagesToOutbound != null)
                    hashCode = hashCode * 59 + this.PackagesToOutbound.GetHashCode();
                if (this.ProductsToOutbound != null)
                    hashCode = hashCode * 59 + this.ProductsToOutbound.GetHashCode();
                if (this.ShippedOutboundPackages != null)
                    hashCode = hashCode * 59 + this.ShippedOutboundPackages.GetHashCode();
                if (this.ShippedOutboundProducts != null)
                    hashCode = hashCode * 59 + this.ShippedOutboundProducts.GetHashCode();
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
