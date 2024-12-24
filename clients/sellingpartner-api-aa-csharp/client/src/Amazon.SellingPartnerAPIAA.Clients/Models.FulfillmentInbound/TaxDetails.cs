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
    /// Information used to determine the tax compliance.
    /// </summary>
    [DataContract]
    public partial class TaxDetails :  IEquatable<TaxDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxDetails" /> class.
        /// </summary>
        /// <param name="declaredValue">declaredValue.</param>
        /// <param name="hsnCode">Harmonized System of Nomenclature code..</param>
        /// <param name="taxRates">List of tax rates..</param>
        public TaxDetails(Currency declaredValue = default(Currency), string hsnCode = default(string), List<TaxRate> taxRates = default(List<TaxRate>))
        {
            this.DeclaredValue = declaredValue;
            this.HsnCode = hsnCode;
            this.TaxRates = taxRates;
        }
        
        /// <summary>
        /// Gets or Sets DeclaredValue
        /// </summary>
        [DataMember(Name="declaredValue", EmitDefaultValue=false)]
        public Currency DeclaredValue { get; set; }

        /// <summary>
        /// Harmonized System of Nomenclature code.
        /// </summary>
        /// <value>Harmonized System of Nomenclature code.</value>
        [DataMember(Name="hsnCode", EmitDefaultValue=false)]
        public string HsnCode { get; set; }

        /// <summary>
        /// List of tax rates.
        /// </summary>
        /// <value>List of tax rates.</value>
        [DataMember(Name="taxRates", EmitDefaultValue=false)]
        public List<TaxRate> TaxRates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxDetails {\n");
            sb.Append("  DeclaredValue: ").Append(DeclaredValue).Append("\n");
            sb.Append("  HsnCode: ").Append(HsnCode).Append("\n");
            sb.Append("  TaxRates: ").Append(TaxRates).Append("\n");
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
            return this.Equals(input as TaxDetails);
        }

        /// <summary>
        /// Returns true if TaxDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeclaredValue == input.DeclaredValue ||
                    (this.DeclaredValue != null &&
                    this.DeclaredValue.Equals(input.DeclaredValue))
                ) && 
                (
                    this.HsnCode == input.HsnCode ||
                    (this.HsnCode != null &&
                    this.HsnCode.Equals(input.HsnCode))
                ) && 
                (
                    this.TaxRates == input.TaxRates ||
                    this.TaxRates != null &&
                    this.TaxRates.SequenceEqual(input.TaxRates)
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
                if (this.DeclaredValue != null)
                    hashCode = hashCode * 59 + this.DeclaredValue.GetHashCode();
                if (this.HsnCode != null)
                    hashCode = hashCode * 59 + this.HsnCode.GetHashCode();
                if (this.TaxRates != null)
                    hashCode = hashCode * 59 + this.TaxRates.GetHashCode();
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
            // HsnCode (string) maxLength
            if(this.HsnCode != null && this.HsnCode.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HsnCode, length must be less than 1024.", new [] { "HsnCode" });
            }

            // HsnCode (string) minLength
            if(this.HsnCode != null && this.HsnCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HsnCode, length must be greater than 1.", new [] { "HsnCode" });
            }

            yield break;
        }
    }

}
