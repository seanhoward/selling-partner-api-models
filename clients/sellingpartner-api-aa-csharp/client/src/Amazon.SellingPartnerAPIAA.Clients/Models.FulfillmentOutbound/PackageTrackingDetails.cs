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
    /// Tracking details of package
    /// </summary>
    [DataContract]
    public partial class PackageTrackingDetails :  IEquatable<PackageTrackingDetails>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CurrentStatus
        /// </summary>
        [DataMember(Name="currentStatus", EmitDefaultValue=false)]
        public CurrentStatus? CurrentStatus { get; set; }
        /// <summary>
        /// Gets or Sets AdditionalLocationInfo
        /// </summary>
        [DataMember(Name="additionalLocationInfo", EmitDefaultValue=false)]
        public AdditionalLocationInfo? AdditionalLocationInfo { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageTrackingDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PackageTrackingDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageTrackingDetails" /> class.
        /// </summary>
        /// <param name="packageNumber">The package identifier. (required).</param>
        /// <param name="trackingNumber">The tracking number for the package..</param>
        /// <param name="customerTrackingLink">Link on swiship.com that allows customers to track the package..</param>
        /// <param name="carrierCode">The name of the carrier..</param>
        /// <param name="carrierPhoneNumber">The phone number of the carrier..</param>
        /// <param name="carrierURL">The URL of the carrier&#39;s website..</param>
        /// <param name="shipDate">The shipping date for the package..</param>
        /// <param name="estimatedArrivalDate">The estimated arrival date..</param>
        /// <param name="shipToAddress">The destination city for the package..</param>
        /// <param name="currentStatus">currentStatus.</param>
        /// <param name="currentStatusDescription">Description corresponding to the &#x60;CurrentStatus&#x60; value..</param>
        /// <param name="signedForBy">The name of the person who signed for the package..</param>
        /// <param name="additionalLocationInfo">additionalLocationInfo.</param>
        /// <param name="trackingEvents">trackingEvents.</param>
        public PackageTrackingDetails(int? packageNumber = default(int?), string trackingNumber = default(string), string customerTrackingLink = default(string), string carrierCode = default(string), string carrierPhoneNumber = default(string), string carrierURL = default(string), DateTime? shipDate = default(DateTime?), DateTime? estimatedArrivalDate = default(DateTime?), TrackingAddress shipToAddress = default(TrackingAddress), CurrentStatus? currentStatus = default(CurrentStatus?), string currentStatusDescription = default(string), string signedForBy = default(string), AdditionalLocationInfo? additionalLocationInfo = default(AdditionalLocationInfo?), TrackingEventList trackingEvents = default(TrackingEventList))
        {
            // to ensure "packageNumber" is required (not null)
            if (packageNumber == null)
            {
                throw new InvalidDataException("packageNumber is a required property for PackageTrackingDetails and cannot be null");
            }
            else
            {
                this.PackageNumber = packageNumber;
            }
            this.TrackingNumber = trackingNumber;
            this.CustomerTrackingLink = customerTrackingLink;
            this.CarrierCode = carrierCode;
            this.CarrierPhoneNumber = carrierPhoneNumber;
            this.CarrierURL = carrierURL;
            this.ShipDate = shipDate;
            this.EstimatedArrivalDate = estimatedArrivalDate;
            this.ShipToAddress = shipToAddress;
            this.CurrentStatus = currentStatus;
            this.CurrentStatusDescription = currentStatusDescription;
            this.SignedForBy = signedForBy;
            this.AdditionalLocationInfo = additionalLocationInfo;
            this.TrackingEvents = trackingEvents;
        }
        
        /// <summary>
        /// The package identifier.
        /// </summary>
        /// <value>The package identifier.</value>
        [DataMember(Name="packageNumber", EmitDefaultValue=false)]
        public int? PackageNumber { get; set; }

        /// <summary>
        /// The tracking number for the package.
        /// </summary>
        /// <value>The tracking number for the package.</value>
        [DataMember(Name="trackingNumber", EmitDefaultValue=false)]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Link on swiship.com that allows customers to track the package.
        /// </summary>
        /// <value>Link on swiship.com that allows customers to track the package.</value>
        [DataMember(Name="customerTrackingLink", EmitDefaultValue=false)]
        public string CustomerTrackingLink { get; set; }

        /// <summary>
        /// The name of the carrier.
        /// </summary>
        /// <value>The name of the carrier.</value>
        [DataMember(Name="carrierCode", EmitDefaultValue=false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// The phone number of the carrier.
        /// </summary>
        /// <value>The phone number of the carrier.</value>
        [DataMember(Name="carrierPhoneNumber", EmitDefaultValue=false)]
        public string CarrierPhoneNumber { get; set; }

        /// <summary>
        /// The URL of the carrier&#39;s website.
        /// </summary>
        /// <value>The URL of the carrier&#39;s website.</value>
        [DataMember(Name="carrierURL", EmitDefaultValue=false)]
        public string CarrierURL { get; set; }

        /// <summary>
        /// The shipping date for the package.
        /// </summary>
        /// <value>The shipping date for the package.</value>
        [DataMember(Name="shipDate", EmitDefaultValue=false)]
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// The estimated arrival date.
        /// </summary>
        /// <value>The estimated arrival date.</value>
        [DataMember(Name="estimatedArrivalDate", EmitDefaultValue=false)]
        public DateTime? EstimatedArrivalDate { get; set; }

        /// <summary>
        /// The destination city for the package.
        /// </summary>
        /// <value>The destination city for the package.</value>
        [DataMember(Name="shipToAddress", EmitDefaultValue=false)]
        public TrackingAddress ShipToAddress { get; set; }


        /// <summary>
        /// Description corresponding to the &#x60;CurrentStatus&#x60; value.
        /// </summary>
        /// <value>Description corresponding to the &#x60;CurrentStatus&#x60; value.</value>
        [DataMember(Name="currentStatusDescription", EmitDefaultValue=false)]
        public string CurrentStatusDescription { get; set; }

        /// <summary>
        /// The name of the person who signed for the package.
        /// </summary>
        /// <value>The name of the person who signed for the package.</value>
        [DataMember(Name="signedForBy", EmitDefaultValue=false)]
        public string SignedForBy { get; set; }


        /// <summary>
        /// Gets or Sets TrackingEvents
        /// </summary>
        [DataMember(Name="trackingEvents", EmitDefaultValue=false)]
        public TrackingEventList TrackingEvents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageTrackingDetails {\n");
            sb.Append("  PackageNumber: ").Append(PackageNumber).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  CustomerTrackingLink: ").Append(CustomerTrackingLink).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  CarrierPhoneNumber: ").Append(CarrierPhoneNumber).Append("\n");
            sb.Append("  CarrierURL: ").Append(CarrierURL).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  EstimatedArrivalDate: ").Append(EstimatedArrivalDate).Append("\n");
            sb.Append("  ShipToAddress: ").Append(ShipToAddress).Append("\n");
            sb.Append("  CurrentStatus: ").Append(CurrentStatus).Append("\n");
            sb.Append("  CurrentStatusDescription: ").Append(CurrentStatusDescription).Append("\n");
            sb.Append("  SignedForBy: ").Append(SignedForBy).Append("\n");
            sb.Append("  AdditionalLocationInfo: ").Append(AdditionalLocationInfo).Append("\n");
            sb.Append("  TrackingEvents: ").Append(TrackingEvents).Append("\n");
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
            return this.Equals(input as PackageTrackingDetails);
        }

        /// <summary>
        /// Returns true if PackageTrackingDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PackageTrackingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackageTrackingDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PackageNumber == input.PackageNumber ||
                    (this.PackageNumber != null &&
                    this.PackageNumber.Equals(input.PackageNumber))
                ) && 
                (
                    this.TrackingNumber == input.TrackingNumber ||
                    (this.TrackingNumber != null &&
                    this.TrackingNumber.Equals(input.TrackingNumber))
                ) && 
                (
                    this.CustomerTrackingLink == input.CustomerTrackingLink ||
                    (this.CustomerTrackingLink != null &&
                    this.CustomerTrackingLink.Equals(input.CustomerTrackingLink))
                ) && 
                (
                    this.CarrierCode == input.CarrierCode ||
                    (this.CarrierCode != null &&
                    this.CarrierCode.Equals(input.CarrierCode))
                ) && 
                (
                    this.CarrierPhoneNumber == input.CarrierPhoneNumber ||
                    (this.CarrierPhoneNumber != null &&
                    this.CarrierPhoneNumber.Equals(input.CarrierPhoneNumber))
                ) && 
                (
                    this.CarrierURL == input.CarrierURL ||
                    (this.CarrierURL != null &&
                    this.CarrierURL.Equals(input.CarrierURL))
                ) && 
                (
                    this.ShipDate == input.ShipDate ||
                    (this.ShipDate != null &&
                    this.ShipDate.Equals(input.ShipDate))
                ) && 
                (
                    this.EstimatedArrivalDate == input.EstimatedArrivalDate ||
                    (this.EstimatedArrivalDate != null &&
                    this.EstimatedArrivalDate.Equals(input.EstimatedArrivalDate))
                ) && 
                (
                    this.ShipToAddress == input.ShipToAddress ||
                    (this.ShipToAddress != null &&
                    this.ShipToAddress.Equals(input.ShipToAddress))
                ) && 
                (
                    this.CurrentStatus == input.CurrentStatus ||
                    (this.CurrentStatus != null &&
                    this.CurrentStatus.Equals(input.CurrentStatus))
                ) && 
                (
                    this.CurrentStatusDescription == input.CurrentStatusDescription ||
                    (this.CurrentStatusDescription != null &&
                    this.CurrentStatusDescription.Equals(input.CurrentStatusDescription))
                ) && 
                (
                    this.SignedForBy == input.SignedForBy ||
                    (this.SignedForBy != null &&
                    this.SignedForBy.Equals(input.SignedForBy))
                ) && 
                (
                    this.AdditionalLocationInfo == input.AdditionalLocationInfo ||
                    (this.AdditionalLocationInfo != null &&
                    this.AdditionalLocationInfo.Equals(input.AdditionalLocationInfo))
                ) && 
                (
                    this.TrackingEvents == input.TrackingEvents ||
                    (this.TrackingEvents != null &&
                    this.TrackingEvents.Equals(input.TrackingEvents))
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
                if (this.PackageNumber != null)
                    hashCode = hashCode * 59 + this.PackageNumber.GetHashCode();
                if (this.TrackingNumber != null)
                    hashCode = hashCode * 59 + this.TrackingNumber.GetHashCode();
                if (this.CustomerTrackingLink != null)
                    hashCode = hashCode * 59 + this.CustomerTrackingLink.GetHashCode();
                if (this.CarrierCode != null)
                    hashCode = hashCode * 59 + this.CarrierCode.GetHashCode();
                if (this.CarrierPhoneNumber != null)
                    hashCode = hashCode * 59 + this.CarrierPhoneNumber.GetHashCode();
                if (this.CarrierURL != null)
                    hashCode = hashCode * 59 + this.CarrierURL.GetHashCode();
                if (this.ShipDate != null)
                    hashCode = hashCode * 59 + this.ShipDate.GetHashCode();
                if (this.EstimatedArrivalDate != null)
                    hashCode = hashCode * 59 + this.EstimatedArrivalDate.GetHashCode();
                if (this.ShipToAddress != null)
                    hashCode = hashCode * 59 + this.ShipToAddress.GetHashCode();
                if (this.CurrentStatus != null)
                    hashCode = hashCode * 59 + this.CurrentStatus.GetHashCode();
                if (this.CurrentStatusDescription != null)
                    hashCode = hashCode * 59 + this.CurrentStatusDescription.GetHashCode();
                if (this.SignedForBy != null)
                    hashCode = hashCode * 59 + this.SignedForBy.GetHashCode();
                if (this.AdditionalLocationInfo != null)
                    hashCode = hashCode * 59 + this.AdditionalLocationInfo.GetHashCode();
                if (this.TrackingEvents != null)
                    hashCode = hashCode * 59 + this.TrackingEvents.GetHashCode();
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