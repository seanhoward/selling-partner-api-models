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
    /// Represents the volume of the package with a unit of measurement.
    /// </summary>
    [DataContract]
    public partial class PackageVolume :  IEquatable<PackageVolume>, IValidatableObject
    {
        /// <summary>
        /// Unit of measurement for the package volume.
        /// </summary>
        /// <value>Unit of measurement for the package volume.</value>
        [DataMember(Name="unitOfMeasurement", EmitDefaultValue=false)]
        public VolumeUnitOfMeasurement UnitOfMeasurement { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVolume" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PackageVolume() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVolume" /> class.
        /// </summary>
        /// <param name="unitOfMeasurement">Unit of measurement for the package volume. (required).</param>
        /// <param name="volume">The package volume value. (required).</param>
        public PackageVolume(VolumeUnitOfMeasurement unitOfMeasurement = default(VolumeUnitOfMeasurement), double? volume = default(double?))
        {
            // to ensure "unitOfMeasurement" is required (not null)
            if (unitOfMeasurement == null)
            {
                throw new InvalidDataException("unitOfMeasurement is a required property for PackageVolume and cannot be null");
            }
            else
            {
                this.UnitOfMeasurement = unitOfMeasurement;
            }
            // to ensure "volume" is required (not null)
            if (volume == null)
            {
                throw new InvalidDataException("volume is a required property for PackageVolume and cannot be null");
            }
            else
            {
                this.Volume = volume;
            }
        }
        

        /// <summary>
        /// The package volume value.
        /// </summary>
        /// <value>The package volume value.</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public double? Volume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageVolume {\n");
            sb.Append("  UnitOfMeasurement: ").Append(UnitOfMeasurement).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
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
            return this.Equals(input as PackageVolume);
        }

        /// <summary>
        /// Returns true if PackageVolume instances are equal
        /// </summary>
        /// <param name="input">Instance of PackageVolume to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackageVolume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnitOfMeasurement == input.UnitOfMeasurement ||
                    (this.UnitOfMeasurement != null &&
                    this.UnitOfMeasurement.Equals(input.UnitOfMeasurement))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
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
                if (this.UnitOfMeasurement != null)
                    hashCode = hashCode * 59 + this.UnitOfMeasurement.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
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