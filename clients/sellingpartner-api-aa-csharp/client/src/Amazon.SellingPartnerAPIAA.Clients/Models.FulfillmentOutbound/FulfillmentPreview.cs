/* 
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: 2020-07-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// Information about a fulfillment order preview, including delivery and fee information based on shipping method.
    /// </summary>
    [DataContract]
    public partial class FulfillmentPreview :  IEquatable<FulfillmentPreview>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ShippingSpeedCategory
        /// </summary>
        [DataMember(Name="shippingSpeedCategory", EmitDefaultValue=false)]
        public ShippingSpeedCategory ShippingSpeedCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentPreview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FulfillmentPreview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentPreview" /> class.
        /// </summary>
        /// <param name="shippingSpeedCategory">shippingSpeedCategory (required).</param>
        /// <param name="scheduledDeliveryInfo">scheduledDeliveryInfo.</param>
        /// <param name="isFulfillable">When true, this fulfillment order preview is fulfillable. (required).</param>
        /// <param name="isCODCapable">When true, this fulfillment order preview is for COD (Cash On Delivery). (required).</param>
        /// <param name="estimatedShippingWeight">Estimated shipping weight for this fulfillment order preview..</param>
        /// <param name="estimatedFees">The estimated fulfillment fees for this fulfillment order preview, if applicable. The fees data will not be available for IN marketplace orders..</param>
        /// <param name="fulfillmentPreviewShipments">fulfillmentPreviewShipments.</param>
        /// <param name="unfulfillablePreviewItems">unfulfillablePreviewItems.</param>
        /// <param name="orderUnfulfillableReasons">Error codes associated with the fulfillment order preview that indicate why the order is not fulfillable.  Error code examples:  &#x60;DeliverySLAUnavailable&#x60; &#x60;InvalidDestinationAddress&#x60;.</param>
        /// <param name="marketplaceId">The marketplace the fulfillment order is placed against. (required).</param>
        /// <param name="featureConstraints">A list of features and their fulfillment policies to apply to the order..</param>
        public FulfillmentPreview(ShippingSpeedCategory shippingSpeedCategory = default(ShippingSpeedCategory), ScheduledDeliveryInfo scheduledDeliveryInfo = default(ScheduledDeliveryInfo), bool? isFulfillable = default(bool?), bool? isCODCapable = default(bool?), Weight estimatedShippingWeight = default(Weight), FeeList estimatedFees = default(FeeList), FulfillmentPreviewShipmentList fulfillmentPreviewShipments = default(FulfillmentPreviewShipmentList), UnfulfillablePreviewItemList unfulfillablePreviewItems = default(UnfulfillablePreviewItemList), StringList orderUnfulfillableReasons = default(StringList), string marketplaceId = default(string), List<FeatureSettings> featureConstraints = default(List<FeatureSettings>))
        {
            // to ensure "shippingSpeedCategory" is required (not null)
            if (shippingSpeedCategory == null)
            {
                throw new InvalidDataException("shippingSpeedCategory is a required property for FulfillmentPreview and cannot be null");
            }
            else
            {
                this.ShippingSpeedCategory = shippingSpeedCategory;
            }
            // to ensure "isFulfillable" is required (not null)
            if (isFulfillable == null)
            {
                throw new InvalidDataException("isFulfillable is a required property for FulfillmentPreview and cannot be null");
            }
            else
            {
                this.IsFulfillable = isFulfillable;
            }
            // to ensure "isCODCapable" is required (not null)
            if (isCODCapable == null)
            {
                throw new InvalidDataException("isCODCapable is a required property for FulfillmentPreview and cannot be null");
            }
            else
            {
                this.IsCODCapable = isCODCapable;
            }
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for FulfillmentPreview and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            this.ScheduledDeliveryInfo = scheduledDeliveryInfo;
            this.EstimatedShippingWeight = estimatedShippingWeight;
            this.EstimatedFees = estimatedFees;
            this.FulfillmentPreviewShipments = fulfillmentPreviewShipments;
            this.UnfulfillablePreviewItems = unfulfillablePreviewItems;
            this.OrderUnfulfillableReasons = orderUnfulfillableReasons;
            this.FeatureConstraints = featureConstraints;
        }
        

        /// <summary>
        /// Gets or Sets ScheduledDeliveryInfo
        /// </summary>
        [DataMember(Name="scheduledDeliveryInfo", EmitDefaultValue=false)]
        public ScheduledDeliveryInfo ScheduledDeliveryInfo { get; set; }

        /// <summary>
        /// When true, this fulfillment order preview is fulfillable.
        /// </summary>
        /// <value>When true, this fulfillment order preview is fulfillable.</value>
        [DataMember(Name="isFulfillable", EmitDefaultValue=false)]
        public bool? IsFulfillable { get; set; }

        /// <summary>
        /// When true, this fulfillment order preview is for COD (Cash On Delivery).
        /// </summary>
        /// <value>When true, this fulfillment order preview is for COD (Cash On Delivery).</value>
        [DataMember(Name="isCODCapable", EmitDefaultValue=false)]
        public bool? IsCODCapable { get; set; }

        /// <summary>
        /// Estimated shipping weight for this fulfillment order preview.
        /// </summary>
        /// <value>Estimated shipping weight for this fulfillment order preview.</value>
        [DataMember(Name="estimatedShippingWeight", EmitDefaultValue=false)]
        public Weight EstimatedShippingWeight { get; set; }

        /// <summary>
        /// The estimated fulfillment fees for this fulfillment order preview, if applicable. The fees data will not be available for IN marketplace orders.
        /// </summary>
        /// <value>The estimated fulfillment fees for this fulfillment order preview, if applicable. The fees data will not be available for IN marketplace orders.</value>
        [DataMember(Name="estimatedFees", EmitDefaultValue=false)]
        public FeeList EstimatedFees { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentPreviewShipments
        /// </summary>
        [DataMember(Name="fulfillmentPreviewShipments", EmitDefaultValue=false)]
        public FulfillmentPreviewShipmentList FulfillmentPreviewShipments { get; set; }

        /// <summary>
        /// Gets or Sets UnfulfillablePreviewItems
        /// </summary>
        [DataMember(Name="unfulfillablePreviewItems", EmitDefaultValue=false)]
        public UnfulfillablePreviewItemList UnfulfillablePreviewItems { get; set; }

        /// <summary>
        /// Error codes associated with the fulfillment order preview that indicate why the order is not fulfillable.  Error code examples:  &#x60;DeliverySLAUnavailable&#x60; &#x60;InvalidDestinationAddress&#x60;
        /// </summary>
        /// <value>Error codes associated with the fulfillment order preview that indicate why the order is not fulfillable.  Error code examples:  &#x60;DeliverySLAUnavailable&#x60; &#x60;InvalidDestinationAddress&#x60;</value>
        [DataMember(Name="orderUnfulfillableReasons", EmitDefaultValue=false)]
        public StringList OrderUnfulfillableReasons { get; set; }

        /// <summary>
        /// The marketplace the fulfillment order is placed against.
        /// </summary>
        /// <value>The marketplace the fulfillment order is placed against.</value>
        [DataMember(Name="marketplaceId", EmitDefaultValue=false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// A list of features and their fulfillment policies to apply to the order.
        /// </summary>
        /// <value>A list of features and their fulfillment policies to apply to the order.</value>
        [DataMember(Name="featureConstraints", EmitDefaultValue=false)]
        public List<FeatureSettings> FeatureConstraints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentPreview {\n");
            sb.Append("  ShippingSpeedCategory: ").Append(ShippingSpeedCategory).Append("\n");
            sb.Append("  ScheduledDeliveryInfo: ").Append(ScheduledDeliveryInfo).Append("\n");
            sb.Append("  IsFulfillable: ").Append(IsFulfillable).Append("\n");
            sb.Append("  IsCODCapable: ").Append(IsCODCapable).Append("\n");
            sb.Append("  EstimatedShippingWeight: ").Append(EstimatedShippingWeight).Append("\n");
            sb.Append("  EstimatedFees: ").Append(EstimatedFees).Append("\n");
            sb.Append("  FulfillmentPreviewShipments: ").Append(FulfillmentPreviewShipments).Append("\n");
            sb.Append("  UnfulfillablePreviewItems: ").Append(UnfulfillablePreviewItems).Append("\n");
            sb.Append("  OrderUnfulfillableReasons: ").Append(OrderUnfulfillableReasons).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  FeatureConstraints: ").Append(FeatureConstraints).Append("\n");
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
            return this.Equals(input as FulfillmentPreview);
        }

        /// <summary>
        /// Returns true if FulfillmentPreview instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentPreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentPreview input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShippingSpeedCategory == input.ShippingSpeedCategory ||
                    (this.ShippingSpeedCategory != null &&
                    this.ShippingSpeedCategory.Equals(input.ShippingSpeedCategory))
                ) && 
                (
                    this.ScheduledDeliveryInfo == input.ScheduledDeliveryInfo ||
                    (this.ScheduledDeliveryInfo != null &&
                    this.ScheduledDeliveryInfo.Equals(input.ScheduledDeliveryInfo))
                ) && 
                (
                    this.IsFulfillable == input.IsFulfillable ||
                    (this.IsFulfillable != null &&
                    this.IsFulfillable.Equals(input.IsFulfillable))
                ) && 
                (
                    this.IsCODCapable == input.IsCODCapable ||
                    (this.IsCODCapable != null &&
                    this.IsCODCapable.Equals(input.IsCODCapable))
                ) && 
                (
                    this.EstimatedShippingWeight == input.EstimatedShippingWeight ||
                    (this.EstimatedShippingWeight != null &&
                    this.EstimatedShippingWeight.Equals(input.EstimatedShippingWeight))
                ) && 
                (
                    this.EstimatedFees == input.EstimatedFees ||
                    (this.EstimatedFees != null &&
                    this.EstimatedFees.Equals(input.EstimatedFees))
                ) && 
                (
                    this.FulfillmentPreviewShipments == input.FulfillmentPreviewShipments ||
                    (this.FulfillmentPreviewShipments != null &&
                    this.FulfillmentPreviewShipments.Equals(input.FulfillmentPreviewShipments))
                ) && 
                (
                    this.UnfulfillablePreviewItems == input.UnfulfillablePreviewItems ||
                    (this.UnfulfillablePreviewItems != null &&
                    this.UnfulfillablePreviewItems.Equals(input.UnfulfillablePreviewItems))
                ) && 
                (
                    this.OrderUnfulfillableReasons == input.OrderUnfulfillableReasons ||
                    (this.OrderUnfulfillableReasons != null &&
                    this.OrderUnfulfillableReasons.Equals(input.OrderUnfulfillableReasons))
                ) && 
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) && 
                (
                    this.FeatureConstraints == input.FeatureConstraints ||
                    this.FeatureConstraints != null &&
                    this.FeatureConstraints.SequenceEqual(input.FeatureConstraints)
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
                if (this.ShippingSpeedCategory != null)
                    hashCode = hashCode * 59 + this.ShippingSpeedCategory.GetHashCode();
                if (this.ScheduledDeliveryInfo != null)
                    hashCode = hashCode * 59 + this.ScheduledDeliveryInfo.GetHashCode();
                if (this.IsFulfillable != null)
                    hashCode = hashCode * 59 + this.IsFulfillable.GetHashCode();
                if (this.IsCODCapable != null)
                    hashCode = hashCode * 59 + this.IsCODCapable.GetHashCode();
                if (this.EstimatedShippingWeight != null)
                    hashCode = hashCode * 59 + this.EstimatedShippingWeight.GetHashCode();
                if (this.EstimatedFees != null)
                    hashCode = hashCode * 59 + this.EstimatedFees.GetHashCode();
                if (this.FulfillmentPreviewShipments != null)
                    hashCode = hashCode * 59 + this.FulfillmentPreviewShipments.GetHashCode();
                if (this.UnfulfillablePreviewItems != null)
                    hashCode = hashCode * 59 + this.UnfulfillablePreviewItems.GetHashCode();
                if (this.OrderUnfulfillableReasons != null)
                    hashCode = hashCode * 59 + this.OrderUnfulfillableReasons.GetHashCode();
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.FeatureConstraints != null)
                    hashCode = hashCode * 59 + this.FeatureConstraints.GetHashCode();
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