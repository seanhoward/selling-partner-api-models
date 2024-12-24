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
    /// Represents the weight of the package with a unit of measurement.
    /// </summary>
    [DataContract]
    public partial class PackageWeight :  IEquatable<PackageWeight>, IValidatableObject
    {
        /// <summary>
        /// Unit of measurement for the package weight.
        /// </summary>
        /// <value>Unit of measurement for the package weight.</value>
        [DataMember(Name="unitOfMeasurement", EmitDefaultValue=false)]
        public WeightUnitOfMeasurement UnitOfMeasurement { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageWeight" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PackageWeight() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageWeight" /> class.
        /// </summary>
        /// <param name="unitOfMeasurement">Unit of measurement for the package weight. (required).</param>
        /// <param name="weight">The package weight value. (required).</param>
        public PackageWeight(WeightUnitOfMeasurement unitOfMeasurement = default(WeightUnitOfMeasurement), double? weight = default(double?))
        {
            // to ensure "unitOfMeasurement" is required (not null)
            if (unitOfMeasurement == null)
            {
                throw new InvalidDataException("unitOfMeasurement is a required property for PackageWeight and cannot be null");
            }
            else
            {
                this.UnitOfMeasurement = unitOfMeasurement;
            }
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new InvalidDataException("weight is a required property for PackageWeight and cannot be null");
            }
            else
            {
                this.Weight = weight;
            }
        }
        

        /// <summary>
        /// The package weight value.
        /// </summary>
        /// <value>The package weight value.</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public double? Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageWeight {\n");
            sb.Append("  UnitOfMeasurement: ").Append(UnitOfMeasurement).Append("\n");
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
            return this.Equals(input as PackageWeight);
        }

        /// <summary>
        /// Returns true if PackageWeight instances are equal
        /// </summary>
        /// <param name="input">Instance of PackageWeight to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackageWeight input)
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
                if (this.UnitOfMeasurement != null)
                    hashCode = hashCode * 59 + this.UnitOfMeasurement.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}