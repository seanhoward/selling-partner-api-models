/* 
 * The Selling Partner API for CustomerFeedback
 *
 * The Selling Partner API for Customer Feedback (Customer Feedback API) provides information about customer reviews and returns at both the item and browse node level.
 *
 * OpenAPI spec version: 2024-06-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.CustomerFeedback
{
    /// <summary>
    /// The browse node review topic metrics.
    /// </summary>
    [DataContract]
    public partial class BrowseNodeReviewTopicMetrics : IEquatable<BrowseNodeReviewTopicMetrics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowseNodeReviewTopicMetrics" /> class.
        /// </summary>
        /// <param name="occurrencePercentage">The percentage of reviews that mention a topic. This value is &#x60;null&#x60; if the topic isn&#39;t mentioned enough in the reviews..</param>
        /// <param name="starRatingImpact">The effect a topic has on the browse node&#39;s star rating. This value is &#x60;null&#x60; if the topic doesn&#39;t affect the star rating of the browse node..</param>
        public BrowseNodeReviewTopicMetrics(BrowseNodeAllOccurrence occurrencePercentage = default, BrowseNodeAllStarRatingImpact starRatingImpact = default)
        {
            this.OccurrencePercentage = occurrencePercentage;
            this.StarRatingImpact = starRatingImpact;
        }

        /// <summary>
        /// The percentage of reviews that mention a topic. This value is &#x60;null&#x60; if the topic isn&#39;t mentioned enough in the reviews.
        /// </summary>
        /// <value>The percentage of reviews that mention a topic. This value is &#x60;null&#x60; if the topic isn&#39;t mentioned enough in the reviews.</value>
        [DataMember(Name = "occurrencePercentage", EmitDefaultValue = false)]
        public BrowseNodeAllOccurrence OccurrencePercentage { get; set; }

        /// <summary>
        /// The effect a topic has on the browse node&#39;s star rating. This value is &#x60;null&#x60; if the topic doesn&#39;t affect the star rating of the browse node.
        /// </summary>
        /// <value>The effect a topic has on the browse node&#39;s star rating. This value is &#x60;null&#x60; if the topic doesn&#39;t affect the star rating of the browse node.</value>
        [DataMember(Name = "starRatingImpact", EmitDefaultValue = false)]
        public BrowseNodeAllStarRatingImpact StarRatingImpact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrowseNodeReviewTopicMetrics {\n");
            sb.Append("  OccurrencePercentage: ").Append(OccurrencePercentage).Append("\n");
            sb.Append("  StarRatingImpact: ").Append(StarRatingImpact).Append("\n");
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
            return this.Equals(input as BrowseNodeReviewTopicMetrics);
        }

        /// <summary>
        /// Returns true if BrowseNodeReviewTopicMetrics instances are equal
        /// </summary>
        /// <param name="input">Instance of BrowseNodeReviewTopicMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrowseNodeReviewTopicMetrics input)
        {
            if (input == null)
                return false;

            return
                (
                    this.OccurrencePercentage == input.OccurrencePercentage ||
                    (this.OccurrencePercentage != null &&
                    this.OccurrencePercentage.Equals(input.OccurrencePercentage))
                ) &&
                (
                    this.StarRatingImpact == input.StarRatingImpact ||
                    (this.StarRatingImpact != null &&
                    this.StarRatingImpact.Equals(input.StarRatingImpact))
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
                if (this.OccurrencePercentage != null)
                    hashCode = hashCode * 59 + this.OccurrencePercentage.GetHashCode();
                if (this.StarRatingImpact != null)
                    hashCode = hashCode * 59 + this.StarRatingImpact.GetHashCode();
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
