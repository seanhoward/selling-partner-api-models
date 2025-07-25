/* 
 * Selling Partner API for Replenishment
 *
 * The Selling Partner API for Replenishment (Replenishment API) provides programmatic access to replenishment program metrics and offers. These programs provide recurring delivery of any replenishable item at a frequency chosen by the customer.  The Replenishment API is available worldwide wherever Amazon Subscribe & Save is available or is supported. The API is available to vendors and FBA selling partners.
 *
 * OpenAPI spec version: 2022-11-07
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Replenishment
{
    /// <summary>
    /// Use these parameters to sort the response.
    /// </summary>
    [DataContract]
    public partial class ListOfferMetricsRequestSort : IEquatable<ListOfferMetricsRequestSort>, IValidatableObject
    {
        /// <summary>
        /// The sort order.
        /// </summary>
        /// <value>The sort order.</value>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public SortOrder Order { get; set; }
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public ListOfferMetricsSortKey Key { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfferMetricsRequestSort" /> class.
        /// </summary>
        [JsonConstructor]
        protected ListOfferMetricsRequestSort() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfferMetricsRequestSort" /> class.
        /// </summary>
        /// <param name="order">The sort order. (required).</param>
        /// <param name="key">key (required).</param>
        public ListOfferMetricsRequestSort(SortOrder order = default, ListOfferMetricsSortKey key = default)
        {
            // to ensure "order" is required (not null)
            if (order == null)
            {
                throw new InvalidDataException("order is a required property for ListOfferMetricsRequestSort and cannot be null");
            }
            else
            {
                this.Order = order;
            }
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for ListOfferMetricsRequestSort and cannot be null");
            }
            else
            {
                this.Key = key;
            }
        }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOfferMetricsRequestSort {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as ListOfferMetricsRequestSort);
        }

        /// <summary>
        /// Returns true if ListOfferMetricsRequestSort instances are equal
        /// </summary>
        /// <param name="input">Instance of ListOfferMetricsRequestSort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListOfferMetricsRequestSort input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) &&
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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
