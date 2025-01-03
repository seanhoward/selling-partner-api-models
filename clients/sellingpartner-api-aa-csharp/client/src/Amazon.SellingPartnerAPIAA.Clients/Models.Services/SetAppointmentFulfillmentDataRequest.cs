/* 
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders and manage their resources.
 *
 * OpenAPI spec version: v1
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Services
{
    /// <summary>
    /// Input for set appointment fulfillment data operation.
    /// </summary>
    [DataContract]
    public partial class SetAppointmentFulfillmentDataRequest :  IEquatable<SetAppointmentFulfillmentDataRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetAppointmentFulfillmentDataRequest" /> class.
        /// </summary>
        /// <param name="fulfillmentTime">Input appointment time details..</param>
        /// <param name="appointmentResources">Resources involved in appointment fulfillment..</param>
        /// <param name="fulfillmentDocuments">Documents specific to appointment fulfillment..</param>
        public SetAppointmentFulfillmentDataRequest(FulfillmentTime fulfillmentTime = default(FulfillmentTime), AppointmentResources appointmentResources = default(AppointmentResources), FulfillmentDocuments fulfillmentDocuments = default(FulfillmentDocuments))
        {
            this.FulfillmentTime = fulfillmentTime;
            this.AppointmentResources = appointmentResources;
            this.FulfillmentDocuments = fulfillmentDocuments;
        }
        
        /// <summary>
        /// Input appointment time details.
        /// </summary>
        /// <value>Input appointment time details.</value>
        [DataMember(Name="fulfillmentTime", EmitDefaultValue=false)]
        public FulfillmentTime FulfillmentTime { get; set; }

        /// <summary>
        /// Resources involved in appointment fulfillment.
        /// </summary>
        /// <value>Resources involved in appointment fulfillment.</value>
        [DataMember(Name="appointmentResources", EmitDefaultValue=false)]
        public AppointmentResources AppointmentResources { get; set; }

        /// <summary>
        /// Documents specific to appointment fulfillment.
        /// </summary>
        /// <value>Documents specific to appointment fulfillment.</value>
        [DataMember(Name="fulfillmentDocuments", EmitDefaultValue=false)]
        public FulfillmentDocuments FulfillmentDocuments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetAppointmentFulfillmentDataRequest {\n");
            sb.Append("  FulfillmentTime: ").Append(FulfillmentTime).Append("\n");
            sb.Append("  AppointmentResources: ").Append(AppointmentResources).Append("\n");
            sb.Append("  FulfillmentDocuments: ").Append(FulfillmentDocuments).Append("\n");
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
            return this.Equals(input as SetAppointmentFulfillmentDataRequest);
        }

        /// <summary>
        /// Returns true if SetAppointmentFulfillmentDataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetAppointmentFulfillmentDataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetAppointmentFulfillmentDataRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FulfillmentTime == input.FulfillmentTime ||
                    (this.FulfillmentTime != null &&
                    this.FulfillmentTime.Equals(input.FulfillmentTime))
                ) && 
                (
                    this.AppointmentResources == input.AppointmentResources ||
                    (this.AppointmentResources != null &&
                    this.AppointmentResources.Equals(input.AppointmentResources))
                ) && 
                (
                    this.FulfillmentDocuments == input.FulfillmentDocuments ||
                    (this.FulfillmentDocuments != null &&
                    this.FulfillmentDocuments.Equals(input.FulfillmentDocuments))
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
                if (this.FulfillmentTime != null)
                    hashCode = hashCode * 59 + this.FulfillmentTime.GetHashCode();
                if (this.AppointmentResources != null)
                    hashCode = hashCode * 59 + this.AppointmentResources.GetHashCode();
                if (this.FulfillmentDocuments != null)
                    hashCode = hashCode * 59 + this.FulfillmentDocuments.GetHashCode();
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
