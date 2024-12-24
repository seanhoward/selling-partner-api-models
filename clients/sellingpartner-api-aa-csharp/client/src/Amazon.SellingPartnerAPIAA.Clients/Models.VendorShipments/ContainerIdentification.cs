/* 
 * Vendor Shipments v1
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
    /// A list of carton identifiers.
    /// </summary>
    [DataContract]
    public partial class ContainerIdentification :  IEquatable<ContainerIdentification>, IValidatableObject
    {
        /// <summary>
        /// The container identification type.
        /// </summary>
        /// <value>The container identification type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContainerIdentificationTypeEnum
        {
            
            /// <summary>
            /// Enum SSCC for value: SSCC
            /// </summary>
            [EnumMember(Value = "SSCC")]
            SSCC = 1,
            
            /// <summary>
            /// Enum AMZNCC for value: AMZNCC
            /// </summary>
            [EnumMember(Value = "AMZNCC")]
            AMZNCC = 2,
            
            /// <summary>
            /// Enum GTIN for value: GTIN
            /// </summary>
            [EnumMember(Value = "GTIN")]
            GTIN = 3,
            
            /// <summary>
            /// Enum BPS for value: BPS
            /// </summary>
            [EnumMember(Value = "BPS")]
            BPS = 4,
            
            /// <summary>
            /// Enum CID for value: CID
            /// </summary>
            [EnumMember(Value = "CID")]
            CID = 5
        }

        /// <summary>
        /// The container identification type.
        /// </summary>
        /// <value>The container identification type.</value>
        [DataMember(Name="containerIdentificationType", EmitDefaultValue=false)]
        public ContainerIdentificationTypeEnum ContainerIdentificationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerIdentification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContainerIdentification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerIdentification" /> class.
        /// </summary>
        /// <param name="containerIdentificationType">The container identification type. (required).</param>
        /// <param name="containerIdentificationNumber">Container identification number that adheres to the definition of the container identification type. (required).</param>
        public ContainerIdentification(ContainerIdentificationTypeEnum containerIdentificationType = default(ContainerIdentificationTypeEnum), string containerIdentificationNumber = default(string))
        {
            // to ensure "containerIdentificationType" is required (not null)
            if (containerIdentificationType == null)
            {
                throw new InvalidDataException("containerIdentificationType is a required property for ContainerIdentification and cannot be null");
            }
            else
            {
                this.ContainerIdentificationType = containerIdentificationType;
            }
            // to ensure "containerIdentificationNumber" is required (not null)
            if (containerIdentificationNumber == null)
            {
                throw new InvalidDataException("containerIdentificationNumber is a required property for ContainerIdentification and cannot be null");
            }
            else
            {
                this.ContainerIdentificationNumber = containerIdentificationNumber;
            }
        }
        

        /// <summary>
        /// Container identification number that adheres to the definition of the container identification type.
        /// </summary>
        /// <value>Container identification number that adheres to the definition of the container identification type.</value>
        [DataMember(Name="containerIdentificationNumber", EmitDefaultValue=false)]
        public string ContainerIdentificationNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContainerIdentification {\n");
            sb.Append("  ContainerIdentificationType: ").Append(ContainerIdentificationType).Append("\n");
            sb.Append("  ContainerIdentificationNumber: ").Append(ContainerIdentificationNumber).Append("\n");
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
            return this.Equals(input as ContainerIdentification);
        }

        /// <summary>
        /// Returns true if ContainerIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of ContainerIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContainerIdentification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContainerIdentificationType == input.ContainerIdentificationType ||
                    (this.ContainerIdentificationType != null &&
                    this.ContainerIdentificationType.Equals(input.ContainerIdentificationType))
                ) && 
                (
                    this.ContainerIdentificationNumber == input.ContainerIdentificationNumber ||
                    (this.ContainerIdentificationNumber != null &&
                    this.ContainerIdentificationNumber.Equals(input.ContainerIdentificationNumber))
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
                if (this.ContainerIdentificationType != null)
                    hashCode = hashCode * 59 + this.ContainerIdentificationType.GetHashCode();
                if (this.ContainerIdentificationNumber != null)
                    hashCode = hashCode * 59 + this.ContainerIdentificationNumber.GetHashCode();
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
