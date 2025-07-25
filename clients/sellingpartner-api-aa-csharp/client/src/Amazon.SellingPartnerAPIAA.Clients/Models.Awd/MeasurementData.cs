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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Awd
{
    /// <summary>
    /// Package weight and dimension.
    /// </summary>
    [DataContract]
    public partial class MeasurementData : IEquatable<MeasurementData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementData" /> class.
        /// </summary>
        [JsonConstructor]
        protected MeasurementData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementData" /> class.
        /// </summary>
        /// <param name="dimensions">Dimensions of the package. Dimensions are required when creating an inbound or outbound order..</param>
        /// <param name="volume">Volume of the package..</param>
        /// <param name="weight">Weight of the package. (required).</param>
        public MeasurementData(PackageDimensions dimensions = default, PackageVolume volume = default, PackageWeight weight = default)
        {
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new InvalidDataException("weight is a required property for MeasurementData and cannot be null");
            }
            else
            {
                this.Weight = weight;
            }
            this.Dimensions = dimensions;
            this.Volume = volume;
        }

        /// <summary>
        /// Dimensions of the package. Dimensions are required when creating an inbound or outbound order.
        /// </summary>
        /// <value>Dimensions of the package. Dimensions are required when creating an inbound or outbound order.</value>
        [DataMember(Name = "dimensions", EmitDefaultValue = false)]
        public PackageDimensions Dimensions { get; set; }

        /// <summary>
        /// Volume of the package.
        /// </summary>
        /// <value>Volume of the package.</value>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public PackageVolume Volume { get; set; }

        /// <summary>
        /// Weight of the package.
        /// </summary>
        /// <value>Weight of the package.</value>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public PackageWeight Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeasurementData {\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as MeasurementData);
        }

        /// <summary>
        /// Returns true if MeasurementData instances are equal
        /// </summary>
        /// <param name="input">Instance of MeasurementData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeasurementData input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Dimensions == input.Dimensions ||
                    (this.Dimensions != null &&
                    this.Dimensions.Equals(input.Dimensions))
                ) &&
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) &&
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
