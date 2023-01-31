/* 
 * Selling Partner API for Reports
 *
 * The Selling Partner API for Reports lets you retrieve and manage a variety of reports that can help selling partners manage their businesses.
 *
 * OpenAPI spec version: 2021-06-30
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
using SwaggerDateConverter = Amazon.SellingPartnerAPIAA.Client.Client.SwaggerDateConverter;

namespace Amazon.SellingPartnerAPIAA.Client.Model
{
    /// <summary>
    /// CreateReportScheduleSpecification
    /// </summary>
    [DataContract]
    public partial class CreateReportScheduleSpecification :  IEquatable<CreateReportScheduleSpecification>, IValidatableObject
    {
        /// <summary>
        /// One of a set of predefined ISO 8601 periods that specifies how often a report should be created.
        /// </summary>
        /// <value>One of a set of predefined ISO 8601 periods that specifies how often a report should be created.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodEnum
        {
            
            /// <summary>
            /// Enum PT5M for value: PT5M
            /// </summary>
            [EnumMember(Value = "PT5M")]
            PT5M = 1,
            
            /// <summary>
            /// Enum PT15M for value: PT15M
            /// </summary>
            [EnumMember(Value = "PT15M")]
            PT15M = 2,
            
            /// <summary>
            /// Enum PT30M for value: PT30M
            /// </summary>
            [EnumMember(Value = "PT30M")]
            PT30M = 3,
            
            /// <summary>
            /// Enum PT1H for value: PT1H
            /// </summary>
            [EnumMember(Value = "PT1H")]
            PT1H = 4,
            
            /// <summary>
            /// Enum PT2H for value: PT2H
            /// </summary>
            [EnumMember(Value = "PT2H")]
            PT2H = 5,
            
            /// <summary>
            /// Enum PT4H for value: PT4H
            /// </summary>
            [EnumMember(Value = "PT4H")]
            PT4H = 6,
            
            /// <summary>
            /// Enum PT8H for value: PT8H
            /// </summary>
            [EnumMember(Value = "PT8H")]
            PT8H = 7,
            
            /// <summary>
            /// Enum PT12H for value: PT12H
            /// </summary>
            [EnumMember(Value = "PT12H")]
            PT12H = 8,
            
            /// <summary>
            /// Enum P1D for value: P1D
            /// </summary>
            [EnumMember(Value = "P1D")]
            P1D = 9,
            
            /// <summary>
            /// Enum P2D for value: P2D
            /// </summary>
            [EnumMember(Value = "P2D")]
            P2D = 10,
            
            /// <summary>
            /// Enum P3D for value: P3D
            /// </summary>
            [EnumMember(Value = "P3D")]
            P3D = 11,
            
            /// <summary>
            /// Enum PT84H for value: PT84H
            /// </summary>
            [EnumMember(Value = "PT84H")]
            PT84H = 12,
            
            /// <summary>
            /// Enum P7D for value: P7D
            /// </summary>
            [EnumMember(Value = "P7D")]
            P7D = 13,
            
            /// <summary>
            /// Enum P14D for value: P14D
            /// </summary>
            [EnumMember(Value = "P14D")]
            P14D = 14,
            
            /// <summary>
            /// Enum P15D for value: P15D
            /// </summary>
            [EnumMember(Value = "P15D")]
            P15D = 15,
            
            /// <summary>
            /// Enum P18D for value: P18D
            /// </summary>
            [EnumMember(Value = "P18D")]
            P18D = 16,
            
            /// <summary>
            /// Enum P30D for value: P30D
            /// </summary>
            [EnumMember(Value = "P30D")]
            P30D = 17,
            
            /// <summary>
            /// Enum P1M for value: P1M
            /// </summary>
            [EnumMember(Value = "P1M")]
            P1M = 18
        }

        /// <summary>
        /// One of a set of predefined ISO 8601 periods that specifies how often a report should be created.
        /// </summary>
        /// <value>One of a set of predefined ISO 8601 periods that specifies how often a report should be created.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public PeriodEnum Period { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReportScheduleSpecification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateReportScheduleSpecification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReportScheduleSpecification" /> class.
        /// </summary>
        /// <param name="reportType">The report type. (required).</param>
        /// <param name="marketplaceIds">A list of marketplace identifiers for the report schedule. (required).</param>
        /// <param name="reportOptions">reportOptions.</param>
        /// <param name="period">One of a set of predefined ISO 8601 periods that specifies how often a report should be created. (required).</param>
        /// <param name="nextReportCreationTime">The date and time when the schedule will create its next report, in ISO 8601 date time format..</param>
        public CreateReportScheduleSpecification(string reportType = default(string), List<string> marketplaceIds = default(List<string>), ReportOptions reportOptions = default(ReportOptions), PeriodEnum period = default(PeriodEnum), DateTime? nextReportCreationTime = default(DateTime?))
        {
            // to ensure "reportType" is required (not null)
            if (reportType == null)
            {
                throw new InvalidDataException("reportType is a required property for CreateReportScheduleSpecification and cannot be null");
            }
            else
            {
                this.ReportType = reportType;
            }
            // to ensure "marketplaceIds" is required (not null)
            if (marketplaceIds == null)
            {
                throw new InvalidDataException("marketplaceIds is a required property for CreateReportScheduleSpecification and cannot be null");
            }
            else
            {
                this.MarketplaceIds = marketplaceIds;
            }
            // to ensure "period" is required (not null)
            if (period == null)
            {
                throw new InvalidDataException("period is a required property for CreateReportScheduleSpecification and cannot be null");
            }
            else
            {
                this.Period = period;
            }
            this.ReportOptions = reportOptions;
            this.NextReportCreationTime = nextReportCreationTime;
        }
        
        /// <summary>
        /// The report type.
        /// </summary>
        /// <value>The report type.</value>
        [DataMember(Name="reportType", EmitDefaultValue=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// A list of marketplace identifiers for the report schedule.
        /// </summary>
        /// <value>A list of marketplace identifiers for the report schedule.</value>
        [DataMember(Name="marketplaceIds", EmitDefaultValue=false)]
        public List<string> MarketplaceIds { get; set; }

        /// <summary>
        /// Gets or Sets ReportOptions
        /// </summary>
        [DataMember(Name="reportOptions", EmitDefaultValue=false)]
        public ReportOptions ReportOptions { get; set; }


        /// <summary>
        /// The date and time when the schedule will create its next report, in ISO 8601 date time format.
        /// </summary>
        /// <value>The date and time when the schedule will create its next report, in ISO 8601 date time format.</value>
        [DataMember(Name="nextReportCreationTime", EmitDefaultValue=false)]
        public DateTime? NextReportCreationTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateReportScheduleSpecification {\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
            sb.Append("  MarketplaceIds: ").Append(MarketplaceIds).Append("\n");
            sb.Append("  ReportOptions: ").Append(ReportOptions).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  NextReportCreationTime: ").Append(NextReportCreationTime).Append("\n");
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
            return this.Equals(input as CreateReportScheduleSpecification);
        }

        /// <summary>
        /// Returns true if CreateReportScheduleSpecification instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateReportScheduleSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateReportScheduleSpecification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReportType == input.ReportType ||
                    (this.ReportType != null &&
                    this.ReportType.Equals(input.ReportType))
                ) && 
                (
                    this.MarketplaceIds == input.MarketplaceIds ||
                    this.MarketplaceIds != null &&
                    this.MarketplaceIds.SequenceEqual(input.MarketplaceIds)
                ) && 
                (
                    this.ReportOptions == input.ReportOptions ||
                    (this.ReportOptions != null &&
                    this.ReportOptions.Equals(input.ReportOptions))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.NextReportCreationTime == input.NextReportCreationTime ||
                    (this.NextReportCreationTime != null &&
                    this.NextReportCreationTime.Equals(input.NextReportCreationTime))
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
                if (this.ReportType != null)
                    hashCode = hashCode * 59 + this.ReportType.GetHashCode();
                if (this.MarketplaceIds != null)
                    hashCode = hashCode * 59 + this.MarketplaceIds.GetHashCode();
                if (this.ReportOptions != null)
                    hashCode = hashCode * 59 + this.ReportOptions.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.NextReportCreationTime != null)
                    hashCode = hashCode * 59 + this.NextReportCreationTime.GetHashCode();
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
