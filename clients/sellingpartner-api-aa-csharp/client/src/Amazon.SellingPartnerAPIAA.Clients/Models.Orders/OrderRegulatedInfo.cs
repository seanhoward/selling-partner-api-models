/* 
 * Orders v0
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
 *
 * OpenAPI spec version: v0
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Orders
{
    /// <summary>
    /// The order&#39;s regulated information along with its verification status.
    /// </summary>
    [DataContract]
    public partial class OrderRegulatedInfo :  IEquatable<OrderRegulatedInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRegulatedInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderRegulatedInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRegulatedInfo" /> class.
        /// </summary>
        /// <param name="amazonOrderId">An Amazon-defined order identifier, in 3-7-7 format. (required).</param>
        /// <param name="regulatedInformation">The regulated information collected during purchase and used to verify the order. (required).</param>
        /// <param name="requiresDosageLabel">When true, the order requires attaching a dosage information label when shipped. (required).</param>
        /// <param name="regulatedOrderVerificationStatus">The order&#39;s verification status. (required).</param>
        public OrderRegulatedInfo(string amazonOrderId = default(string), RegulatedInformation regulatedInformation = default(RegulatedInformation), bool? requiresDosageLabel = default(bool?), RegulatedOrderVerificationStatus regulatedOrderVerificationStatus = default(RegulatedOrderVerificationStatus))
        {
            // to ensure "amazonOrderId" is required (not null)
            if (amazonOrderId == null)
            {
                throw new InvalidDataException("amazonOrderId is a required property for OrderRegulatedInfo and cannot be null");
            }
            else
            {
                this.AmazonOrderId = amazonOrderId;
            }
            // to ensure "regulatedInformation" is required (not null)
            if (regulatedInformation == null)
            {
                throw new InvalidDataException("regulatedInformation is a required property for OrderRegulatedInfo and cannot be null");
            }
            else
            {
                this.RegulatedInformation = regulatedInformation;
            }
            // to ensure "requiresDosageLabel" is required (not null)
            if (requiresDosageLabel == null)
            {
                throw new InvalidDataException("requiresDosageLabel is a required property for OrderRegulatedInfo and cannot be null");
            }
            else
            {
                this.RequiresDosageLabel = requiresDosageLabel;
            }
            // to ensure "regulatedOrderVerificationStatus" is required (not null)
            if (regulatedOrderVerificationStatus == null)
            {
                throw new InvalidDataException("regulatedOrderVerificationStatus is a required property for OrderRegulatedInfo and cannot be null");
            }
            else
            {
                this.RegulatedOrderVerificationStatus = regulatedOrderVerificationStatus;
            }
        }
        
        /// <summary>
        /// An Amazon-defined order identifier, in 3-7-7 format.
        /// </summary>
        /// <value>An Amazon-defined order identifier, in 3-7-7 format.</value>
        [DataMember(Name="AmazonOrderId", EmitDefaultValue=false)]
        public string AmazonOrderId { get; set; }

        /// <summary>
        /// The regulated information collected during purchase and used to verify the order.
        /// </summary>
        /// <value>The regulated information collected during purchase and used to verify the order.</value>
        [DataMember(Name="RegulatedInformation", EmitDefaultValue=false)]
        public RegulatedInformation RegulatedInformation { get; set; }

        /// <summary>
        /// When true, the order requires attaching a dosage information label when shipped.
        /// </summary>
        /// <value>When true, the order requires attaching a dosage information label when shipped.</value>
        [DataMember(Name="RequiresDosageLabel", EmitDefaultValue=false)]
        public bool? RequiresDosageLabel { get; set; }

        /// <summary>
        /// The order&#39;s verification status.
        /// </summary>
        /// <value>The order&#39;s verification status.</value>
        [DataMember(Name="RegulatedOrderVerificationStatus", EmitDefaultValue=false)]
        public RegulatedOrderVerificationStatus RegulatedOrderVerificationStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderRegulatedInfo {\n");
            sb.Append("  AmazonOrderId: ").Append(AmazonOrderId).Append("\n");
            sb.Append("  RegulatedInformation: ").Append(RegulatedInformation).Append("\n");
            sb.Append("  RequiresDosageLabel: ").Append(RequiresDosageLabel).Append("\n");
            sb.Append("  RegulatedOrderVerificationStatus: ").Append(RegulatedOrderVerificationStatus).Append("\n");
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
            return this.Equals(input as OrderRegulatedInfo);
        }

        /// <summary>
        /// Returns true if OrderRegulatedInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderRegulatedInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderRegulatedInfo input)
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
                    this.RegulatedInformation == input.RegulatedInformation ||
                    (this.RegulatedInformation != null &&
                    this.RegulatedInformation.Equals(input.RegulatedInformation))
                ) && 
                (
                    this.RequiresDosageLabel == input.RequiresDosageLabel ||
                    (this.RequiresDosageLabel != null &&
                    this.RequiresDosageLabel.Equals(input.RequiresDosageLabel))
                ) && 
                (
                    this.RegulatedOrderVerificationStatus == input.RegulatedOrderVerificationStatus ||
                    (this.RegulatedOrderVerificationStatus != null &&
                    this.RegulatedOrderVerificationStatus.Equals(input.RegulatedOrderVerificationStatus))
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
                if (this.RegulatedInformation != null)
                    hashCode = hashCode * 59 + this.RegulatedInformation.GetHashCode();
                if (this.RequiresDosageLabel != null)
                    hashCode = hashCode * 59 + this.RequiresDosageLabel.GetHashCode();
                if (this.RegulatedOrderVerificationStatus != null)
                    hashCode = hashCode * 59 + this.RegulatedOrderVerificationStatus.GetHashCode();
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
