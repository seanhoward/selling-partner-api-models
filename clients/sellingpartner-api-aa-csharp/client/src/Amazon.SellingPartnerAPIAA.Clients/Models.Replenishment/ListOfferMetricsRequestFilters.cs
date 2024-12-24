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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Replenishment
{
    /// <summary>
    /// Use these parameters to filter results. Any result must match all provided parameters. For any parameter that is an array, the result must match at least one element in the provided array.
    /// </summary>
    [DataContract]
    public partial class ListOfferMetricsRequestFilters :  IEquatable<ListOfferMetricsRequestFilters>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AggregationFrequency
        /// </summary>
        [DataMember(Name="aggregationFrequency", EmitDefaultValue=false)]
        public AggregationFrequency? AggregationFrequency { get; set; }
        /// <summary>
        /// Gets or Sets TimePeriodType
        /// </summary>
        [DataMember(Name="timePeriodType", EmitDefaultValue=false)]
        public TimePeriodType TimePeriodType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfferMetricsRequestFilters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListOfferMetricsRequestFilters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfferMetricsRequestFilters" /> class.
        /// </summary>
        /// <param name="aggregationFrequency">aggregationFrequency.</param>
        /// <param name="timeInterval">A time interval used to compute metrics. (required).</param>
        /// <param name="timePeriodType">timePeriodType (required).</param>
        /// <param name="marketplaceId">The marketplace identifier. The supported marketplaces for both sellers and vendors are US, CA, ES, UK, FR, IT, IN, DE and JP. The supported marketplaces for vendors only are BR, AU, MX, AE and NL.  Refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids) to find the identifier for the marketplace. (required).</param>
        /// <param name="programTypes">programTypes (required).</param>
        /// <param name="asins">A list of Amazon Standard Identification Numbers (ASINs)..</param>
        public ListOfferMetricsRequestFilters(AggregationFrequency? aggregationFrequency = default(AggregationFrequency?), TimeInterval timeInterval = default(TimeInterval), TimePeriodType timePeriodType = default(TimePeriodType), string marketplaceId = default(string), ProgramTypes programTypes = default(ProgramTypes), List<string> asins = default(List<string>))
        {
            // to ensure "timeInterval" is required (not null)
            if (timeInterval == null)
            {
                throw new InvalidDataException("timeInterval is a required property for ListOfferMetricsRequestFilters and cannot be null");
            }
            else
            {
                this.TimeInterval = timeInterval;
            }
            // to ensure "timePeriodType" is required (not null)
            if (timePeriodType == null)
            {
                throw new InvalidDataException("timePeriodType is a required property for ListOfferMetricsRequestFilters and cannot be null");
            }
            else
            {
                this.TimePeriodType = timePeriodType;
            }
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for ListOfferMetricsRequestFilters and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            // to ensure "programTypes" is required (not null)
            if (programTypes == null)
            {
                throw new InvalidDataException("programTypes is a required property for ListOfferMetricsRequestFilters and cannot be null");
            }
            else
            {
                this.ProgramTypes = programTypes;
            }
            this.AggregationFrequency = aggregationFrequency;
            this.Asins = asins;
        }
        

        /// <summary>
        /// A time interval used to compute metrics.
        /// </summary>
        /// <value>A time interval used to compute metrics.</value>
        [DataMember(Name="timeInterval", EmitDefaultValue=false)]
        public TimeInterval TimeInterval { get; set; }


        /// <summary>
        /// The marketplace identifier. The supported marketplaces for both sellers and vendors are US, CA, ES, UK, FR, IT, IN, DE and JP. The supported marketplaces for vendors only are BR, AU, MX, AE and NL.  Refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids) to find the identifier for the marketplace.
        /// </summary>
        /// <value>The marketplace identifier. The supported marketplaces for both sellers and vendors are US, CA, ES, UK, FR, IT, IN, DE and JP. The supported marketplaces for vendors only are BR, AU, MX, AE and NL.  Refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids) to find the identifier for the marketplace.</value>
        [DataMember(Name="marketplaceId", EmitDefaultValue=false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Gets or Sets ProgramTypes
        /// </summary>
        [DataMember(Name="programTypes", EmitDefaultValue=false)]
        public ProgramTypes ProgramTypes { get; set; }

        /// <summary>
        /// A list of Amazon Standard Identification Numbers (ASINs).
        /// </summary>
        /// <value>A list of Amazon Standard Identification Numbers (ASINs).</value>
        [DataMember(Name="asins", EmitDefaultValue=false)]
        public List<string> Asins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOfferMetricsRequestFilters {\n");
            sb.Append("  AggregationFrequency: ").Append(AggregationFrequency).Append("\n");
            sb.Append("  TimeInterval: ").Append(TimeInterval).Append("\n");
            sb.Append("  TimePeriodType: ").Append(TimePeriodType).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  ProgramTypes: ").Append(ProgramTypes).Append("\n");
            sb.Append("  Asins: ").Append(Asins).Append("\n");
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
            return this.Equals(input as ListOfferMetricsRequestFilters);
        }

        /// <summary>
        /// Returns true if ListOfferMetricsRequestFilters instances are equal
        /// </summary>
        /// <param name="input">Instance of ListOfferMetricsRequestFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListOfferMetricsRequestFilters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AggregationFrequency == input.AggregationFrequency ||
                    (this.AggregationFrequency != null &&
                    this.AggregationFrequency.Equals(input.AggregationFrequency))
                ) && 
                (
                    this.TimeInterval == input.TimeInterval ||
                    (this.TimeInterval != null &&
                    this.TimeInterval.Equals(input.TimeInterval))
                ) && 
                (
                    this.TimePeriodType == input.TimePeriodType ||
                    (this.TimePeriodType != null &&
                    this.TimePeriodType.Equals(input.TimePeriodType))
                ) && 
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) && 
                (
                    this.ProgramTypes == input.ProgramTypes ||
                    (this.ProgramTypes != null &&
                    this.ProgramTypes.Equals(input.ProgramTypes))
                ) && 
                (
                    this.Asins == input.Asins ||
                    this.Asins != null &&
                    this.Asins.SequenceEqual(input.Asins)
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
                if (this.AggregationFrequency != null)
                    hashCode = hashCode * 59 + this.AggregationFrequency.GetHashCode();
                if (this.TimeInterval != null)
                    hashCode = hashCode * 59 + this.TimeInterval.GetHashCode();
                if (this.TimePeriodType != null)
                    hashCode = hashCode * 59 + this.TimePeriodType.GetHashCode();
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.ProgramTypes != null)
                    hashCode = hashCode * 59 + this.ProgramTypes.GetHashCode();
                if (this.Asins != null)
                    hashCode = hashCode * 59 + this.Asins.GetHashCode();
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