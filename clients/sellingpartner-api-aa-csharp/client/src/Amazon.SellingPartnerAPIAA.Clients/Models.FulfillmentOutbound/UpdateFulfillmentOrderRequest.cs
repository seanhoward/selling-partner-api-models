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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// The request body schema for the &#x60;updateFulfillmentOrder&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class UpdateFulfillmentOrderRequest : IEquatable<UpdateFulfillmentOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ShippingSpeedCategory
        /// </summary>
        [DataMember(Name = "shippingSpeedCategory", EmitDefaultValue = false)]
        public ShippingSpeedCategory? ShippingSpeedCategory { get; set; }
        /// <summary>
        /// Gets or Sets FulfillmentAction
        /// </summary>
        [DataMember(Name = "fulfillmentAction", EmitDefaultValue = false)]
        public FulfillmentAction? FulfillmentAction { get; set; }
        /// <summary>
        /// Gets or Sets FulfillmentPolicy
        /// </summary>
        [DataMember(Name = "fulfillmentPolicy", EmitDefaultValue = false)]
        public FulfillmentPolicy? FulfillmentPolicy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFulfillmentOrderRequest" /> class.
        /// </summary>
        /// <param name="marketplaceId">The marketplace the fulfillment order is placed against..</param>
        /// <param name="displayableOrderId">A fulfillment order identifier that the seller creates. This value displays as the order identifier in recipient-facing materials such as the outbound shipment packing slip. The value of &#x60;DisplayableOrderId&#x60; should match the order identifier that the seller provides to the recipient. The seller can use the &#x60;SellerFulfillmentOrderId&#x60; for this value or they can specify an alternate value if they want the recipient to reference an alternate order identifier..</param>
        /// <param name="displayableOrderDate">The date and time of the fulfillment order. Displays as the order date in recipient-facing materials such as the outbound shipment packing slip..</param>
        /// <param name="displayableOrderComment">Order-specific text that appears in recipient-facing materials such as the outbound shipment packing slip..</param>
        /// <param name="shippingSpeedCategory">shippingSpeedCategory.</param>
        /// <param name="destinationAddress">The destination address for the fulfillment order..</param>
        /// <param name="fulfillmentAction">fulfillmentAction.</param>
        /// <param name="fulfillmentPolicy">fulfillmentPolicy.</param>
        /// <param name="shipFromCountryCode">The two-character country code for the country from which the fulfillment order ships. Must be in ISO 3166-1 alpha-2 format..</param>
        /// <param name="notificationEmails">notificationEmails.</param>
        /// <param name="featureConstraints">A list of features and their fulfillment policies to apply to the order..</param>
        /// <param name="items">A list of items to include in the fulfillment order preview, including quantity..</param>
        public UpdateFulfillmentOrderRequest(string marketplaceId = default, string displayableOrderId = default, DateTime? displayableOrderDate = default, string displayableOrderComment = default, ShippingSpeedCategory? shippingSpeedCategory = default, Address destinationAddress = default, FulfillmentAction? fulfillmentAction = default, FulfillmentPolicy? fulfillmentPolicy = default, string shipFromCountryCode = default, NotificationEmailList notificationEmails = default, List<FeatureSettings> featureConstraints = default, UpdateFulfillmentOrderItemList items = default)
        {
            this.MarketplaceId = marketplaceId;
            this.DisplayableOrderId = displayableOrderId;
            this.DisplayableOrderDate = displayableOrderDate;
            this.DisplayableOrderComment = displayableOrderComment;
            this.ShippingSpeedCategory = shippingSpeedCategory;
            this.DestinationAddress = destinationAddress;
            this.FulfillmentAction = fulfillmentAction;
            this.FulfillmentPolicy = fulfillmentPolicy;
            this.ShipFromCountryCode = shipFromCountryCode;
            this.NotificationEmails = notificationEmails;
            this.FeatureConstraints = featureConstraints;
            this.Items = items;
        }

        /// <summary>
        /// The marketplace the fulfillment order is placed against.
        /// </summary>
        /// <value>The marketplace the fulfillment order is placed against.</value>
        [DataMember(Name = "marketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// A fulfillment order identifier that the seller creates. This value displays as the order identifier in recipient-facing materials such as the outbound shipment packing slip. The value of &#x60;DisplayableOrderId&#x60; should match the order identifier that the seller provides to the recipient. The seller can use the &#x60;SellerFulfillmentOrderId&#x60; for this value or they can specify an alternate value if they want the recipient to reference an alternate order identifier.
        /// </summary>
        /// <value>A fulfillment order identifier that the seller creates. This value displays as the order identifier in recipient-facing materials such as the outbound shipment packing slip. The value of &#x60;DisplayableOrderId&#x60; should match the order identifier that the seller provides to the recipient. The seller can use the &#x60;SellerFulfillmentOrderId&#x60; for this value or they can specify an alternate value if they want the recipient to reference an alternate order identifier.</value>
        [DataMember(Name = "displayableOrderId", EmitDefaultValue = false)]
        public string DisplayableOrderId { get; set; }

        /// <summary>
        /// The date and time of the fulfillment order. Displays as the order date in recipient-facing materials such as the outbound shipment packing slip.
        /// </summary>
        /// <value>The date and time of the fulfillment order. Displays as the order date in recipient-facing materials such as the outbound shipment packing slip.</value>
        [DataMember(Name = "displayableOrderDate", EmitDefaultValue = false)]
        public DateTime? DisplayableOrderDate { get; set; }

        /// <summary>
        /// Order-specific text that appears in recipient-facing materials such as the outbound shipment packing slip.
        /// </summary>
        /// <value>Order-specific text that appears in recipient-facing materials such as the outbound shipment packing slip.</value>
        [DataMember(Name = "displayableOrderComment", EmitDefaultValue = false)]
        public string DisplayableOrderComment { get; set; }


        /// <summary>
        /// The destination address for the fulfillment order.
        /// </summary>
        /// <value>The destination address for the fulfillment order.</value>
        [DataMember(Name = "destinationAddress", EmitDefaultValue = false)]
        public Address DestinationAddress { get; set; }



        /// <summary>
        /// The two-character country code for the country from which the fulfillment order ships. Must be in ISO 3166-1 alpha-2 format.
        /// </summary>
        /// <value>The two-character country code for the country from which the fulfillment order ships. Must be in ISO 3166-1 alpha-2 format.</value>
        [DataMember(Name = "shipFromCountryCode", EmitDefaultValue = false)]
        public string ShipFromCountryCode { get; set; }

        /// <summary>
        /// Gets or Sets NotificationEmails
        /// </summary>
        [DataMember(Name = "notificationEmails", EmitDefaultValue = false)]
        public NotificationEmailList NotificationEmails { get; set; }

        /// <summary>
        /// A list of features and their fulfillment policies to apply to the order.
        /// </summary>
        /// <value>A list of features and their fulfillment policies to apply to the order.</value>
        [DataMember(Name = "featureConstraints", EmitDefaultValue = false)]
        public List<FeatureSettings> FeatureConstraints { get; set; }

        /// <summary>
        /// A list of items to include in the fulfillment order preview, including quantity.
        /// </summary>
        /// <value>A list of items to include in the fulfillment order preview, including quantity.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public UpdateFulfillmentOrderItemList Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFulfillmentOrderRequest {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  DisplayableOrderId: ").Append(DisplayableOrderId).Append("\n");
            sb.Append("  DisplayableOrderDate: ").Append(DisplayableOrderDate).Append("\n");
            sb.Append("  DisplayableOrderComment: ").Append(DisplayableOrderComment).Append("\n");
            sb.Append("  ShippingSpeedCategory: ").Append(ShippingSpeedCategory).Append("\n");
            sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
            sb.Append("  FulfillmentAction: ").Append(FulfillmentAction).Append("\n");
            sb.Append("  FulfillmentPolicy: ").Append(FulfillmentPolicy).Append("\n");
            sb.Append("  ShipFromCountryCode: ").Append(ShipFromCountryCode).Append("\n");
            sb.Append("  NotificationEmails: ").Append(NotificationEmails).Append("\n");
            sb.Append("  FeatureConstraints: ").Append(FeatureConstraints).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as UpdateFulfillmentOrderRequest);
        }

        /// <summary>
        /// Returns true if UpdateFulfillmentOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateFulfillmentOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateFulfillmentOrderRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    this.DisplayableOrderId == input.DisplayableOrderId ||
                    (this.DisplayableOrderId != null &&
                    this.DisplayableOrderId.Equals(input.DisplayableOrderId))
                ) &&
                (
                    this.DisplayableOrderDate == input.DisplayableOrderDate ||
                    (this.DisplayableOrderDate != null &&
                    this.DisplayableOrderDate.Equals(input.DisplayableOrderDate))
                ) &&
                (
                    this.DisplayableOrderComment == input.DisplayableOrderComment ||
                    (this.DisplayableOrderComment != null &&
                    this.DisplayableOrderComment.Equals(input.DisplayableOrderComment))
                ) &&
                (
                    this.ShippingSpeedCategory == input.ShippingSpeedCategory ||
                    (this.ShippingSpeedCategory != null &&
                    this.ShippingSpeedCategory.Equals(input.ShippingSpeedCategory))
                ) &&
                (
                    this.DestinationAddress == input.DestinationAddress ||
                    (this.DestinationAddress != null &&
                    this.DestinationAddress.Equals(input.DestinationAddress))
                ) &&
                (
                    this.FulfillmentAction == input.FulfillmentAction ||
                    (this.FulfillmentAction != null &&
                    this.FulfillmentAction.Equals(input.FulfillmentAction))
                ) &&
                (
                    this.FulfillmentPolicy == input.FulfillmentPolicy ||
                    (this.FulfillmentPolicy != null &&
                    this.FulfillmentPolicy.Equals(input.FulfillmentPolicy))
                ) &&
                (
                    this.ShipFromCountryCode == input.ShipFromCountryCode ||
                    (this.ShipFromCountryCode != null &&
                    this.ShipFromCountryCode.Equals(input.ShipFromCountryCode))
                ) &&
                (
                    this.NotificationEmails == input.NotificationEmails ||
                    (this.NotificationEmails != null &&
                    this.NotificationEmails.Equals(input.NotificationEmails))
                ) &&
                (
                    this.FeatureConstraints == input.FeatureConstraints ||
                    this.FeatureConstraints != null &&
                    this.FeatureConstraints.SequenceEqual(input.FeatureConstraints)
                ) &&
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
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
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.DisplayableOrderId != null)
                    hashCode = hashCode * 59 + this.DisplayableOrderId.GetHashCode();
                if (this.DisplayableOrderDate != null)
                    hashCode = hashCode * 59 + this.DisplayableOrderDate.GetHashCode();
                if (this.DisplayableOrderComment != null)
                    hashCode = hashCode * 59 + this.DisplayableOrderComment.GetHashCode();
                if (this.ShippingSpeedCategory != null)
                    hashCode = hashCode * 59 + this.ShippingSpeedCategory.GetHashCode();
                if (this.DestinationAddress != null)
                    hashCode = hashCode * 59 + this.DestinationAddress.GetHashCode();
                if (this.FulfillmentAction != null)
                    hashCode = hashCode * 59 + this.FulfillmentAction.GetHashCode();
                if (this.FulfillmentPolicy != null)
                    hashCode = hashCode * 59 + this.FulfillmentPolicy.GetHashCode();
                if (this.ShipFromCountryCode != null)
                    hashCode = hashCode * 59 + this.ShipFromCountryCode.GetHashCode();
                if (this.NotificationEmails != null)
                    hashCode = hashCode * 59 + this.NotificationEmails.GetHashCode();
                if (this.FeatureConstraints != null)
                    hashCode = hashCode * 59 + this.FeatureConstraints.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
            // DisplayableOrderId (string) maxLength
            if (this.DisplayableOrderId != null && this.DisplayableOrderId.Length > 40)
            {
                yield return new ValidationResult("Invalid value for DisplayableOrderId, length must be less than 40.", new[] { "DisplayableOrderId" });
            }

            // DisplayableOrderComment (string) maxLength
            if (this.DisplayableOrderComment != null && this.DisplayableOrderComment.Length > 750)
            {
                yield return new ValidationResult("Invalid value for DisplayableOrderComment, length must be less than 750.", new[] { "DisplayableOrderComment" });
            }

            yield break;
        }
    }

}
