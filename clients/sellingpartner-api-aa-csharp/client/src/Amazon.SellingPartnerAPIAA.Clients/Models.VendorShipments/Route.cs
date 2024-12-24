/* 
 * Selling Partner API for Retail Procurement Shipments
 *
 * The Selling Partner API for Retail Procurement Shipments provides programmatic access to retail shipping data for vendors.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorShipments
{
    /// <summary>
    /// This is used only for direct import shipment confirmations.
    /// </summary>
    [DataContract]
    public partial class Route :  IEquatable<Route>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Route" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Route() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Route" /> class.
        /// </summary>
        /// <param name="stops">The port or location involved in transporting the cargo, as specified in transportation contracts or operational plans. (required).</param>
        public Route(List<Stop> stops = default(List<Stop>))
        {
            // to ensure "stops" is required (not null)
            if (stops == null)
            {
                throw new InvalidDataException("stops is a required property for Route and cannot be null");
            }
            else
            {
                this.Stops = stops;
            }
        }
        
        /// <summary>
        /// The port or location involved in transporting the cargo, as specified in transportation contracts or operational plans.
        /// </summary>
        /// <value>The port or location involved in transporting the cargo, as specified in transportation contracts or operational plans.</value>
        [DataMember(Name="stops", EmitDefaultValue=false)]
        public List<Stop> Stops { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Route {\n");
            sb.Append("  Stops: ").Append(Stops).Append("\n");
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
            return this.Equals(input as Route);
        }

        /// <summary>
        /// Returns true if Route instances are equal
        /// </summary>
        /// <param name="input">Instance of Route to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Route input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stops == input.Stops ||
                    this.Stops != null &&
                    this.Stops.SequenceEqual(input.Stops)
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
                if (this.Stops != null)
                    hashCode = hashCode * 59 + this.Stops.GetHashCode();
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