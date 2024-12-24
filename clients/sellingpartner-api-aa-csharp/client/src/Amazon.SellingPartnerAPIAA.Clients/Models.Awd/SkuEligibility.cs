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
    /// Represents eligibility of one SKU.
    /// </summary>
    [DataContract]
    public partial class SkuEligibility :  IEquatable<SkuEligibility>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public InboundEligibilityStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SkuEligibility" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SkuEligibility() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SkuEligibility" /> class.
        /// </summary>
        /// <param name="ineligibilityReasons">If not eligible, these are list of error codes and descriptions..</param>
        /// <param name="packageQuantity">packageQuantity (required).</param>
        /// <param name="status">status (required).</param>
        public SkuEligibility(List<SkuIneligibilityReason> ineligibilityReasons = default(List<SkuIneligibilityReason>), DistributionPackageQuantity packageQuantity = default(DistributionPackageQuantity), InboundEligibilityStatus status = default(InboundEligibilityStatus))
        {
            // to ensure "packageQuantity" is required (not null)
            if (packageQuantity == null)
            {
                throw new InvalidDataException("packageQuantity is a required property for SkuEligibility and cannot be null");
            }
            else
            {
                this.PackageQuantity = packageQuantity;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for SkuEligibility and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.IneligibilityReasons = ineligibilityReasons;
        }
        
        /// <summary>
        /// If not eligible, these are list of error codes and descriptions.
        /// </summary>
        /// <value>If not eligible, these are list of error codes and descriptions.</value>
        [DataMember(Name="ineligibilityReasons", EmitDefaultValue=false)]
        public List<SkuIneligibilityReason> IneligibilityReasons { get; set; }

        /// <summary>
        /// Gets or Sets PackageQuantity
        /// </summary>
        [DataMember(Name="packageQuantity", EmitDefaultValue=false)]
        public DistributionPackageQuantity PackageQuantity { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkuEligibility {\n");
            sb.Append("  IneligibilityReasons: ").Append(IneligibilityReasons).Append("\n");
            sb.Append("  PackageQuantity: ").Append(PackageQuantity).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as SkuEligibility);
        }

        /// <summary>
        /// Returns true if SkuEligibility instances are equal
        /// </summary>
        /// <param name="input">Instance of SkuEligibility to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SkuEligibility input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IneligibilityReasons == input.IneligibilityReasons ||
                    this.IneligibilityReasons != null &&
                    this.IneligibilityReasons.SequenceEqual(input.IneligibilityReasons)
                ) && 
                (
                    this.PackageQuantity == input.PackageQuantity ||
                    (this.PackageQuantity != null &&
                    this.PackageQuantity.Equals(input.PackageQuantity))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.IneligibilityReasons != null)
                    hashCode = hashCode * 59 + this.IneligibilityReasons.GetHashCode();
                if (this.PackageQuantity != null)
                    hashCode = hashCode * 59 + this.PackageQuantity.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
