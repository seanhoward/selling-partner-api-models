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
    /// Return authorization information for items accepted for return.
    /// </summary>
    [DataContract]
    public partial class ReturnAuthorization :  IEquatable<ReturnAuthorization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnAuthorization" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReturnAuthorization() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnAuthorization" /> class.
        /// </summary>
        /// <param name="returnAuthorizationId">An identifier for the return authorization. This identifier associates return items with the return authorization used to return them. (required).</param>
        /// <param name="fulfillmentCenterId">An identifier for the Amazon fulfillment center that the return items should be sent to. (required).</param>
        /// <param name="returnToAddress">The address of the Amazon fulfillment center that the return items should be sent to. (required).</param>
        /// <param name="amazonRmaId">The return merchandise authorization (RMA) that Amazon needs to process the return. (required).</param>
        /// <param name="rmaPageURL">A URL for a web page that contains the return authorization barcode and the mailing label. This does not include pre-paid shipping. (required).</param>
        public ReturnAuthorization(string returnAuthorizationId = default(string), string fulfillmentCenterId = default(string), Address returnToAddress = default(Address), string amazonRmaId = default(string), string rmaPageURL = default(string))
        {
            // to ensure "returnAuthorizationId" is required (not null)
            if (returnAuthorizationId == null)
            {
                throw new InvalidDataException("returnAuthorizationId is a required property for ReturnAuthorization and cannot be null");
            }
            else
            {
                this.ReturnAuthorizationId = returnAuthorizationId;
            }
            // to ensure "fulfillmentCenterId" is required (not null)
            if (fulfillmentCenterId == null)
            {
                throw new InvalidDataException("fulfillmentCenterId is a required property for ReturnAuthorization and cannot be null");
            }
            else
            {
                this.FulfillmentCenterId = fulfillmentCenterId;
            }
            // to ensure "returnToAddress" is required (not null)
            if (returnToAddress == null)
            {
                throw new InvalidDataException("returnToAddress is a required property for ReturnAuthorization and cannot be null");
            }
            else
            {
                this.ReturnToAddress = returnToAddress;
            }
            // to ensure "amazonRmaId" is required (not null)
            if (amazonRmaId == null)
            {
                throw new InvalidDataException("amazonRmaId is a required property for ReturnAuthorization and cannot be null");
            }
            else
            {
                this.AmazonRmaId = amazonRmaId;
            }
            // to ensure "rmaPageURL" is required (not null)
            if (rmaPageURL == null)
            {
                throw new InvalidDataException("rmaPageURL is a required property for ReturnAuthorization and cannot be null");
            }
            else
            {
                this.RmaPageURL = rmaPageURL;
            }
        }
        
        /// <summary>
        /// An identifier for the return authorization. This identifier associates return items with the return authorization used to return them.
        /// </summary>
        /// <value>An identifier for the return authorization. This identifier associates return items with the return authorization used to return them.</value>
        [DataMember(Name="returnAuthorizationId", EmitDefaultValue=false)]
        public string ReturnAuthorizationId { get; set; }

        /// <summary>
        /// An identifier for the Amazon fulfillment center that the return items should be sent to.
        /// </summary>
        /// <value>An identifier for the Amazon fulfillment center that the return items should be sent to.</value>
        [DataMember(Name="fulfillmentCenterId", EmitDefaultValue=false)]
        public string FulfillmentCenterId { get; set; }

        /// <summary>
        /// The address of the Amazon fulfillment center that the return items should be sent to.
        /// </summary>
        /// <value>The address of the Amazon fulfillment center that the return items should be sent to.</value>
        [DataMember(Name="returnToAddress", EmitDefaultValue=false)]
        public Address ReturnToAddress { get; set; }

        /// <summary>
        /// The return merchandise authorization (RMA) that Amazon needs to process the return.
        /// </summary>
        /// <value>The return merchandise authorization (RMA) that Amazon needs to process the return.</value>
        [DataMember(Name="amazonRmaId", EmitDefaultValue=false)]
        public string AmazonRmaId { get; set; }

        /// <summary>
        /// A URL for a web page that contains the return authorization barcode and the mailing label. This does not include pre-paid shipping.
        /// </summary>
        /// <value>A URL for a web page that contains the return authorization barcode and the mailing label. This does not include pre-paid shipping.</value>
        [DataMember(Name="rmaPageURL", EmitDefaultValue=false)]
        public string RmaPageURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReturnAuthorization {\n");
            sb.Append("  ReturnAuthorizationId: ").Append(ReturnAuthorizationId).Append("\n");
            sb.Append("  FulfillmentCenterId: ").Append(FulfillmentCenterId).Append("\n");
            sb.Append("  ReturnToAddress: ").Append(ReturnToAddress).Append("\n");
            sb.Append("  AmazonRmaId: ").Append(AmazonRmaId).Append("\n");
            sb.Append("  RmaPageURL: ").Append(RmaPageURL).Append("\n");
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
            return this.Equals(input as ReturnAuthorization);
        }

        /// <summary>
        /// Returns true if ReturnAuthorization instances are equal
        /// </summary>
        /// <param name="input">Instance of ReturnAuthorization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReturnAuthorization input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReturnAuthorizationId == input.ReturnAuthorizationId ||
                    (this.ReturnAuthorizationId != null &&
                    this.ReturnAuthorizationId.Equals(input.ReturnAuthorizationId))
                ) && 
                (
                    this.FulfillmentCenterId == input.FulfillmentCenterId ||
                    (this.FulfillmentCenterId != null &&
                    this.FulfillmentCenterId.Equals(input.FulfillmentCenterId))
                ) && 
                (
                    this.ReturnToAddress == input.ReturnToAddress ||
                    (this.ReturnToAddress != null &&
                    this.ReturnToAddress.Equals(input.ReturnToAddress))
                ) && 
                (
                    this.AmazonRmaId == input.AmazonRmaId ||
                    (this.AmazonRmaId != null &&
                    this.AmazonRmaId.Equals(input.AmazonRmaId))
                ) && 
                (
                    this.RmaPageURL == input.RmaPageURL ||
                    (this.RmaPageURL != null &&
                    this.RmaPageURL.Equals(input.RmaPageURL))
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
                if (this.ReturnAuthorizationId != null)
                    hashCode = hashCode * 59 + this.ReturnAuthorizationId.GetHashCode();
                if (this.FulfillmentCenterId != null)
                    hashCode = hashCode * 59 + this.FulfillmentCenterId.GetHashCode();
                if (this.ReturnToAddress != null)
                    hashCode = hashCode * 59 + this.ReturnToAddress.GetHashCode();
                if (this.AmazonRmaId != null)
                    hashCode = hashCode * 59 + this.AmazonRmaId.GetHashCode();
                if (this.RmaPageURL != null)
                    hashCode = hashCode * 59 + this.RmaPageURL.GetHashCode();
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