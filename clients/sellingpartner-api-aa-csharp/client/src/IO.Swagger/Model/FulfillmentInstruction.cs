/* 
 * Selling Partner API for Orders
 *
 * The Selling Partner API for Orders helps you programmatically retrieve order information. These APIs let you develop fast, flexible, custom applications in areas like order synchronization, order research, and demand-based decision support tools.
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Contains the instructions about the fulfillment like where should it be fulfilled from.
    /// </summary>
    [DataContract]
    public partial class FulfillmentInstruction :  IEquatable<FulfillmentInstruction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentInstruction" /> class.
        /// </summary>
        /// <param name="fulfillmentSupplySourceId">Denotes the recommended sourceId where the order should be fulfilled from..</param>
        public FulfillmentInstruction(string fulfillmentSupplySourceId = default(string))
        {
            this.FulfillmentSupplySourceId = fulfillmentSupplySourceId;
        }
        
        /// <summary>
        /// Denotes the recommended sourceId where the order should be fulfilled from.
        /// </summary>
        /// <value>Denotes the recommended sourceId where the order should be fulfilled from.</value>
        [DataMember(Name="FulfillmentSupplySourceId", EmitDefaultValue=false)]
        public string FulfillmentSupplySourceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentInstruction {\n");
            sb.Append("  FulfillmentSupplySourceId: ").Append(FulfillmentSupplySourceId).Append("\n");
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
            return this.Equals(input as FulfillmentInstruction);
        }

        /// <summary>
        /// Returns true if FulfillmentInstruction instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentInstruction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentInstruction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FulfillmentSupplySourceId == input.FulfillmentSupplySourceId ||
                    (this.FulfillmentSupplySourceId != null &&
                    this.FulfillmentSupplySourceId.Equals(input.FulfillmentSupplySourceId))
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
                if (this.FulfillmentSupplySourceId != null)
                    hashCode = hashCode * 59 + this.FulfillmentSupplySourceId.GetHashCode();
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
