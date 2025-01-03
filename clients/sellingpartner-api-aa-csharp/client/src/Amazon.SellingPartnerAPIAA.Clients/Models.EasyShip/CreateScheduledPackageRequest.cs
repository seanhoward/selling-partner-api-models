/* 
 * Selling Partner API for Easy Ship
 *
 * The Selling Partner API for Easy Ship helps you build applications that help sellers manage and ship Amazon Easy Ship orders.  Your Easy Ship applications can:  * Get available time slots for packages to be scheduled for delivery.  * Schedule, reschedule, and cancel Easy Ship orders.  * Print labels, invoices, and warranties.  See the [Marketplace Support Table](doc:easyship-api-v2022-03-23-use-case-guide#marketplace-support-table) for the differences in Easy Ship operations by marketplace.
 *
 * OpenAPI spec version: 2022-03-23
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.EasyShip
{
    /// <summary>
    /// The request schema for the &#x60;createScheduledPackage&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class CreateScheduledPackageRequest :  IEquatable<CreateScheduledPackageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduledPackageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateScheduledPackageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduledPackageRequest" /> class.
        /// </summary>
        /// <param name="amazonOrderId">amazonOrderId (required).</param>
        /// <param name="marketplaceId">marketplaceId (required).</param>
        /// <param name="packageDetails">packageDetails (required).</param>
        public CreateScheduledPackageRequest(string amazonOrderId = default(string), string marketplaceId = default(string), PackageDetails packageDetails = default(PackageDetails))
        {
            // to ensure "amazonOrderId" is required (not null)
            if (amazonOrderId == null)
            {
                throw new InvalidDataException("amazonOrderId is a required property for CreateScheduledPackageRequest and cannot be null");
            }
            else
            {
                this.AmazonOrderId = amazonOrderId;
            }
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for CreateScheduledPackageRequest and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            // to ensure "packageDetails" is required (not null)
            if (packageDetails == null)
            {
                throw new InvalidDataException("packageDetails is a required property for CreateScheduledPackageRequest and cannot be null");
            }
            else
            {
                this.PackageDetails = packageDetails;
            }
        }
        
        /// <summary>
        /// Gets or Sets AmazonOrderId
        /// </summary>
        [DataMember(Name="amazonOrderId", EmitDefaultValue=false)]
        public string AmazonOrderId { get; set; }

        /// <summary>
        /// Gets or Sets MarketplaceId
        /// </summary>
        [DataMember(Name="marketplaceId", EmitDefaultValue=false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Gets or Sets PackageDetails
        /// </summary>
        [DataMember(Name="packageDetails", EmitDefaultValue=false)]
        public PackageDetails PackageDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScheduledPackageRequest {\n");
            sb.Append("  AmazonOrderId: ").Append(AmazonOrderId).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  PackageDetails: ").Append(PackageDetails).Append("\n");
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
            return this.Equals(input as CreateScheduledPackageRequest);
        }

        /// <summary>
        /// Returns true if CreateScheduledPackageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateScheduledPackageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateScheduledPackageRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmazonOrderId == input.AmazonOrderId ||
                    (this.AmazonOrderId != null &&
                    this.AmazonOrderId.Equals(input.AmazonOrderId))
                ) && 
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) && 
                (
                    this.PackageDetails == input.PackageDetails ||
                    (this.PackageDetails != null &&
                    this.PackageDetails.Equals(input.PackageDetails))
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
                if (this.AmazonOrderId != null)
                    hashCode = hashCode * 59 + this.AmazonOrderId.GetHashCode();
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.PackageDetails != null)
                    hashCode = hashCode * 59 + this.PackageDetails.GetHashCode();
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
