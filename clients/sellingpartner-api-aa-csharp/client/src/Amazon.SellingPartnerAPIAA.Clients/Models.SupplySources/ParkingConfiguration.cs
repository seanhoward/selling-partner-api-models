/* 
 * Selling Partner API for Supply Sources
 *
 * Manage configurations and capabilities of seller supply sources.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources
{
    /// <summary>
    /// The parking configuration.
    /// </summary>
    [DataContract]
    public partial class ParkingConfiguration :  IEquatable<ParkingConfiguration>, IValidatableObject
    {
        /// <summary>
        /// The type of cost at parking location.
        /// </summary>
        /// <value>The type of cost at parking location.</value>
        [DataMember(Name="parkingCostType", EmitDefaultValue=false)]
        public ParkingCostType? ParkingCostType { get; set; }
        /// <summary>
        /// The type of parking spot identification used at parking location.
        /// </summary>
        /// <value>The type of parking spot identification used at parking location.</value>
        [DataMember(Name="parkingSpotIdentificationType", EmitDefaultValue=false)]
        public ParkingSpotIdentificationType? ParkingSpotIdentificationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParkingConfiguration" /> class.
        /// </summary>
        /// <param name="parkingCostType">The type of cost at parking location..</param>
        /// <param name="parkingSpotIdentificationType">The type of parking spot identification used at parking location..</param>
        /// <param name="numberOfParkingSpots">The number of parking spots..</param>
        public ParkingConfiguration(ParkingCostType? parkingCostType = default(ParkingCostType?), ParkingSpotIdentificationType? parkingSpotIdentificationType = default(ParkingSpotIdentificationType?), int? numberOfParkingSpots = default(int?))
        {
            this.ParkingCostType = parkingCostType;
            this.ParkingSpotIdentificationType = parkingSpotIdentificationType;
            this.NumberOfParkingSpots = numberOfParkingSpots;
        }
        


        /// <summary>
        /// The number of parking spots.
        /// </summary>
        /// <value>The number of parking spots.</value>
        [DataMember(Name="numberOfParkingSpots", EmitDefaultValue=false)]
        public int? NumberOfParkingSpots { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParkingConfiguration {\n");
            sb.Append("  ParkingCostType: ").Append(ParkingCostType).Append("\n");
            sb.Append("  ParkingSpotIdentificationType: ").Append(ParkingSpotIdentificationType).Append("\n");
            sb.Append("  NumberOfParkingSpots: ").Append(NumberOfParkingSpots).Append("\n");
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
            return this.Equals(input as ParkingConfiguration);
        }

        /// <summary>
        /// Returns true if ParkingConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of ParkingConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParkingConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParkingCostType == input.ParkingCostType ||
                    (this.ParkingCostType != null &&
                    this.ParkingCostType.Equals(input.ParkingCostType))
                ) && 
                (
                    this.ParkingSpotIdentificationType == input.ParkingSpotIdentificationType ||
                    (this.ParkingSpotIdentificationType != null &&
                    this.ParkingSpotIdentificationType.Equals(input.ParkingSpotIdentificationType))
                ) && 
                (
                    this.NumberOfParkingSpots == input.NumberOfParkingSpots ||
                    (this.NumberOfParkingSpots != null &&
                    this.NumberOfParkingSpots.Equals(input.NumberOfParkingSpots))
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
                if (this.ParkingCostType != null)
                    hashCode = hashCode * 59 + this.ParkingCostType.GetHashCode();
                if (this.ParkingSpotIdentificationType != null)
                    hashCode = hashCode * 59 + this.ParkingSpotIdentificationType.GetHashCode();
                if (this.NumberOfParkingSpots != null)
                    hashCode = hashCode * 59 + this.NumberOfParkingSpots.GetHashCode();
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
