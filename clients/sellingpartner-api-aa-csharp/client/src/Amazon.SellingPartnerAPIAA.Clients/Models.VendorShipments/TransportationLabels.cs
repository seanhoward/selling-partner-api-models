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
    /// The request schema for the GetShipmentLabels operation.
    /// </summary>
    [DataContract]
    public partial class TransportationLabels :  IEquatable<TransportationLabels>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportationLabels" /> class.
        /// </summary>
        /// <param name="pagination">pagination.</param>
        /// <param name="transportLabels">A list of one or more ShipmentLabels..</param>
        public TransportationLabels(Pagination pagination = default(Pagination), List<TransportLabel> transportLabels = default(List<TransportLabel>))
        {
            this.Pagination = pagination;
            this.TransportLabels = transportLabels;
        }
        
        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// A list of one or more ShipmentLabels.
        /// </summary>
        /// <value>A list of one or more ShipmentLabels.</value>
        [DataMember(Name="transportLabels", EmitDefaultValue=false)]
        public List<TransportLabel> TransportLabels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransportationLabels {\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  TransportLabels: ").Append(TransportLabels).Append("\n");
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
            return this.Equals(input as TransportationLabels);
        }

        /// <summary>
        /// Returns true if TransportationLabels instances are equal
        /// </summary>
        /// <param name="input">Instance of TransportationLabels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransportationLabels input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.TransportLabels == input.TransportLabels ||
                    this.TransportLabels != null &&
                    this.TransportLabels.SequenceEqual(input.TransportLabels)
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
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
                if (this.TransportLabels != null)
                    hashCode = hashCode * 59 + this.TransportLabels.GetHashCode();
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