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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorShipments
{
    /// <summary>
    /// Name/Address and tax details of the party.
    /// </summary>
    [DataContract]
    public partial class PartyIdentification : IEquatable<PartyIdentification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartyIdentification" /> class.
        /// </summary>
        [JsonConstructor]
        protected PartyIdentification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartyIdentification" /> class.
        /// </summary>
        /// <param name="address">Identification of the party by address..</param>
        /// <param name="partyId">Assigned identification for the party. (required).</param>
        /// <param name="taxRegistrationDetails">Tax registration details of the entity..</param>
        public PartyIdentification(Address address = default, string partyId = default, List<TaxRegistrationDetails> taxRegistrationDetails = default)
        {
            // to ensure "partyId" is required (not null)
            if (partyId == null)
            {
                throw new InvalidDataException("partyId is a required property for PartyIdentification and cannot be null");
            }
            else
            {
                this.PartyId = partyId;
            }
            this.Address = address;
            this.TaxRegistrationDetails = taxRegistrationDetails;
        }

        /// <summary>
        /// Identification of the party by address.
        /// </summary>
        /// <value>Identification of the party by address.</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// Assigned identification for the party.
        /// </summary>
        /// <value>Assigned identification for the party.</value>
        [DataMember(Name = "partyId", EmitDefaultValue = false)]
        public string PartyId { get; set; }

        /// <summary>
        /// Tax registration details of the entity.
        /// </summary>
        /// <value>Tax registration details of the entity.</value>
        [DataMember(Name = "taxRegistrationDetails", EmitDefaultValue = false)]
        public List<TaxRegistrationDetails> TaxRegistrationDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartyIdentification {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PartyId: ").Append(PartyId).Append("\n");
            sb.Append("  TaxRegistrationDetails: ").Append(TaxRegistrationDetails).Append("\n");
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
            return this.Equals(input as PartyIdentification);
        }

        /// <summary>
        /// Returns true if PartyIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of PartyIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartyIdentification input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) &&
                (
                    this.PartyId == input.PartyId ||
                    (this.PartyId != null &&
                    this.PartyId.Equals(input.PartyId))
                ) &&
                (
                    this.TaxRegistrationDetails == input.TaxRegistrationDetails ||
                    this.TaxRegistrationDetails != null &&
                    this.TaxRegistrationDetails.SequenceEqual(input.TaxRegistrationDetails)
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.PartyId != null)
                    hashCode = hashCode * 59 + this.PartyId.GetHashCode();
                if (this.TaxRegistrationDetails != null)
                    hashCode = hashCode * 59 + this.TaxRegistrationDetails.GetHashCode();
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
