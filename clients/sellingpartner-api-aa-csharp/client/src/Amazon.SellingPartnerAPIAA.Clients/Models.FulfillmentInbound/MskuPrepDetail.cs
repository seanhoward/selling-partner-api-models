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
    /// An MSKU and its related prep details.
    /// </summary>
    [DataContract]
    public partial class MskuPrepDetail :  IEquatable<MskuPrepDetail>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AllOwnersConstraint
        /// </summary>
        [DataMember(Name="allOwnersConstraint", EmitDefaultValue=false)]
        public AllOwnersConstraint? AllOwnersConstraint { get; set; }
        /// <summary>
        /// Gets or Sets LabelOwnerConstraint
        /// </summary>
        [DataMember(Name="labelOwnerConstraint", EmitDefaultValue=false)]
        public OwnerConstraint? LabelOwnerConstraint { get; set; }
        /// <summary>
        /// Gets or Sets PrepCategory
        /// </summary>
        [DataMember(Name="prepCategory", EmitDefaultValue=false)]
        public PrepCategory PrepCategory { get; set; }
        /// <summary>
        /// Gets or Sets PrepOwnerConstraint
        /// </summary>
        [DataMember(Name="prepOwnerConstraint", EmitDefaultValue=false)]
        public OwnerConstraint? PrepOwnerConstraint { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MskuPrepDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MskuPrepDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MskuPrepDetail" /> class.
        /// </summary>
        /// <param name="allOwnersConstraint">allOwnersConstraint.</param>
        /// <param name="labelOwnerConstraint">labelOwnerConstraint.</param>
        /// <param name="msku">The merchant SKU, a merchant-supplied identifier for a specific SKU. (required).</param>
        /// <param name="prepCategory">prepCategory (required).</param>
        /// <param name="prepOwnerConstraint">prepOwnerConstraint.</param>
        /// <param name="prepTypes">A list of preparation types associated with a preparation category. (required).</param>
        public MskuPrepDetail(AllOwnersConstraint? allOwnersConstraint = default(AllOwnersConstraint?), OwnerConstraint? labelOwnerConstraint = default(OwnerConstraint?), string msku = default(string), PrepCategory prepCategory = default(PrepCategory), OwnerConstraint? prepOwnerConstraint = default(OwnerConstraint?), List<PrepType> prepTypes = default(List<PrepType>))
        {
            // to ensure "msku" is required (not null)
            if (msku == null)
            {
                throw new InvalidDataException("msku is a required property for MskuPrepDetail and cannot be null");
            }
            else
            {
                this.Msku = msku;
            }
            // to ensure "prepCategory" is required (not null)
            if (prepCategory == null)
            {
                throw new InvalidDataException("prepCategory is a required property for MskuPrepDetail and cannot be null");
            }
            else
            {
                this.PrepCategory = prepCategory;
            }
            // to ensure "prepTypes" is required (not null)
            if (prepTypes == null)
            {
                throw new InvalidDataException("prepTypes is a required property for MskuPrepDetail and cannot be null");
            }
            else
            {
                this.PrepTypes = prepTypes;
            }
            this.AllOwnersConstraint = allOwnersConstraint;
            this.LabelOwnerConstraint = labelOwnerConstraint;
            this.PrepOwnerConstraint = prepOwnerConstraint;
        }
        


        /// <summary>
        /// The merchant SKU, a merchant-supplied identifier for a specific SKU.
        /// </summary>
        /// <value>The merchant SKU, a merchant-supplied identifier for a specific SKU.</value>
        [DataMember(Name="msku", EmitDefaultValue=false)]
        public string Msku { get; set; }



        /// <summary>
        /// A list of preparation types associated with a preparation category.
        /// </summary>
        /// <value>A list of preparation types associated with a preparation category.</value>
        [DataMember(Name="prepTypes", EmitDefaultValue=false)]
        public List<PrepType> PrepTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MskuPrepDetail {\n");
            sb.Append("  AllOwnersConstraint: ").Append(AllOwnersConstraint).Append("\n");
            sb.Append("  LabelOwnerConstraint: ").Append(LabelOwnerConstraint).Append("\n");
            sb.Append("  Msku: ").Append(Msku).Append("\n");
            sb.Append("  PrepCategory: ").Append(PrepCategory).Append("\n");
            sb.Append("  PrepOwnerConstraint: ").Append(PrepOwnerConstraint).Append("\n");
            sb.Append("  PrepTypes: ").Append(PrepTypes).Append("\n");
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
            return this.Equals(input as MskuPrepDetail);
        }

        /// <summary>
        /// Returns true if MskuPrepDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of MskuPrepDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MskuPrepDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllOwnersConstraint == input.AllOwnersConstraint ||
                    (this.AllOwnersConstraint != null &&
                    this.AllOwnersConstraint.Equals(input.AllOwnersConstraint))
                ) && 
                (
                    this.LabelOwnerConstraint == input.LabelOwnerConstraint ||
                    (this.LabelOwnerConstraint != null &&
                    this.LabelOwnerConstraint.Equals(input.LabelOwnerConstraint))
                ) && 
                (
                    this.Msku == input.Msku ||
                    (this.Msku != null &&
                    this.Msku.Equals(input.Msku))
                ) && 
                (
                    this.PrepCategory == input.PrepCategory ||
                    (this.PrepCategory != null &&
                    this.PrepCategory.Equals(input.PrepCategory))
                ) && 
                (
                    this.PrepOwnerConstraint == input.PrepOwnerConstraint ||
                    (this.PrepOwnerConstraint != null &&
                    this.PrepOwnerConstraint.Equals(input.PrepOwnerConstraint))
                ) && 
                (
                    this.PrepTypes == input.PrepTypes ||
                    this.PrepTypes != null &&
                    this.PrepTypes.SequenceEqual(input.PrepTypes)
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
                if (this.AllOwnersConstraint != null)
                    hashCode = hashCode * 59 + this.AllOwnersConstraint.GetHashCode();
                if (this.LabelOwnerConstraint != null)
                    hashCode = hashCode * 59 + this.LabelOwnerConstraint.GetHashCode();
                if (this.Msku != null)
                    hashCode = hashCode * 59 + this.Msku.GetHashCode();
                if (this.PrepCategory != null)
                    hashCode = hashCode * 59 + this.PrepCategory.GetHashCode();
                if (this.PrepOwnerConstraint != null)
                    hashCode = hashCode * 59 + this.PrepOwnerConstraint.GetHashCode();
                if (this.PrepTypes != null)
                    hashCode = hashCode * 59 + this.PrepTypes.GetHashCode();
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
            // Msku (string) maxLength
            if(this.Msku != null && this.Msku.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Msku, length must be less than 40.", new [] { "Msku" });
            }

            // Msku (string) minLength
            if(this.Msku != null && this.Msku.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Msku, length must be greater than 1.", new [] { "Msku" });
            }

            yield break;
        }
    }

}
