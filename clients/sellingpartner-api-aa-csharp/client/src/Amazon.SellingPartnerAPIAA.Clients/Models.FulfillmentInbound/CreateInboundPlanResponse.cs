/* 
 * Fulfillment Inbound v2024-03-20
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound
{
    /// <summary>
    /// The &#x60;createInboundPlan&#x60; response.
    /// </summary>
    [DataContract]
    public partial class CreateInboundPlanResponse :  IEquatable<CreateInboundPlanResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboundPlanResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateInboundPlanResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboundPlanResponse" /> class.
        /// </summary>
        /// <param name="inboundPlanId">Identifier of an inbound plan. (required).</param>
        /// <param name="operationId">UUID for the given operation. (required).</param>
        public CreateInboundPlanResponse(string inboundPlanId = default(string), string operationId = default(string))
        {
            // to ensure "inboundPlanId" is required (not null)
            if (inboundPlanId == null)
            {
                throw new InvalidDataException("inboundPlanId is a required property for CreateInboundPlanResponse and cannot be null");
            }
            else
            {
                this.InboundPlanId = inboundPlanId;
            }
            // to ensure "operationId" is required (not null)
            if (operationId == null)
            {
                throw new InvalidDataException("operationId is a required property for CreateInboundPlanResponse and cannot be null");
            }
            else
            {
                this.OperationId = operationId;
            }
        }
        
        /// <summary>
        /// Identifier of an inbound plan.
        /// </summary>
        /// <value>Identifier of an inbound plan.</value>
        [DataMember(Name="inboundPlanId", EmitDefaultValue=false)]
        public string InboundPlanId { get; set; }

        /// <summary>
        /// UUID for the given operation.
        /// </summary>
        /// <value>UUID for the given operation.</value>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInboundPlanResponse {\n");
            sb.Append("  InboundPlanId: ").Append(InboundPlanId).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
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
            return this.Equals(input as CreateInboundPlanResponse);
        }

        /// <summary>
        /// Returns true if CreateInboundPlanResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateInboundPlanResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateInboundPlanResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InboundPlanId == input.InboundPlanId ||
                    (this.InboundPlanId != null &&
                    this.InboundPlanId.Equals(input.InboundPlanId))
                ) && 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
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
                if (this.InboundPlanId != null)
                    hashCode = hashCode * 59 + this.InboundPlanId.GetHashCode();
                if (this.OperationId != null)
                    hashCode = hashCode * 59 + this.OperationId.GetHashCode();
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
            // InboundPlanId (string) maxLength
            if(this.InboundPlanId != null && this.InboundPlanId.Length > 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InboundPlanId, length must be less than 38.", new [] { "InboundPlanId" });
            }

            // InboundPlanId (string) minLength
            if(this.InboundPlanId != null && this.InboundPlanId.Length < 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InboundPlanId, length must be greater than 38.", new [] { "InboundPlanId" });
            }

            // InboundPlanId (string) pattern
            Regex regexInboundPlanId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
            if (false == regexInboundPlanId.Match(this.InboundPlanId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InboundPlanId, must match a pattern of " + regexInboundPlanId, new [] { "InboundPlanId" });
            }

            // OperationId (string) maxLength
            if(this.OperationId != null && this.OperationId.Length > 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperationId, length must be less than 38.", new [] { "OperationId" });
            }

            // OperationId (string) minLength
            if(this.OperationId != null && this.OperationId.Length < 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperationId, length must be greater than 36.", new [] { "OperationId" });
            }

            // OperationId (string) pattern
            Regex regexOperationId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
            if (false == regexOperationId.Match(this.OperationId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperationId, must match a pattern of " + regexOperationId, new [] { "OperationId" });
            }

            yield break;
        }
    }

}
