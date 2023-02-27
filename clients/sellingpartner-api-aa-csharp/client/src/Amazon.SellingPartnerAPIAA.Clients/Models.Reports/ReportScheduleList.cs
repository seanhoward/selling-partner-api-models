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
using SwaggerDateConverter = Amazon.SellingPartnerAPIAA.Clients.Client.SwaggerDateConverter;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Reports
{
    /// <summary>
    /// A list of report schedules.
    /// </summary>
    [DataContract]
    public partial class ReportScheduleList :  IEquatable<ReportScheduleList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportScheduleList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportScheduleList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportScheduleList" /> class.
        /// </summary>
        /// <param name="reportSchedules">reportSchedules (required).</param>
        public ReportScheduleList(List<ReportSchedule> reportSchedules = default(List<ReportSchedule>))
        {
            // to ensure "reportSchedules" is required (not null)
            if (reportSchedules == null)
            {
                throw new InvalidDataException("reportSchedules is a required property for ReportScheduleList and cannot be null");
            }
            else
            {
                this.ReportSchedules = reportSchedules;
            }
        }
        
        /// <summary>
        /// Gets or Sets ReportSchedules
        /// </summary>
        [DataMember(Name="reportSchedules", EmitDefaultValue=false)]
        public List<ReportSchedule> ReportSchedules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportScheduleList {\n");
            sb.Append("  ReportSchedules: ").Append(ReportSchedules).Append("\n");
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
            return this.Equals(input as ReportScheduleList);
        }

        /// <summary>
        /// Returns true if ReportScheduleList instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportScheduleList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportScheduleList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReportSchedules == input.ReportSchedules ||
                    this.ReportSchedules != null &&
                    this.ReportSchedules.SequenceEqual(input.ReportSchedules)
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
                if (this.ReportSchedules != null)
                    hashCode = hashCode * 59 + this.ReportSchedules.GetHashCode();
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