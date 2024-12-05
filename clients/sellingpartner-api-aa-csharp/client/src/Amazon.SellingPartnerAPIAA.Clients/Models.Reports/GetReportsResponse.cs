/* 
 * Report v2021-06-30
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
    /// The response for the &#x60;getReports&#x60; operation.
    /// </summary>
    [DataContract]
    public partial class GetReportsResponse :  IEquatable<GetReportsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetReportsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportsResponse" /> class.
        /// </summary>
        /// <param name="reports">The reports. (required).</param>
        /// <param name="nextToken">Returned when the number of results exceeds &#x60;pageSize&#x60;. To get the next page of results, call &#x60;getReports&#x60; with this token as the only parameter..</param>
        public GetReportsResponse(ReportList reports = default(ReportList), string nextToken = default(string))
        {
            // to ensure "reports" is required (not null)
            if (reports == null)
            {
                throw new InvalidDataException("reports is a required property for GetReportsResponse and cannot be null");
            }
            else
            {
                this.Reports = reports;
            }
            this.NextToken = nextToken;
        }
        
        /// <summary>
        /// The reports.
        /// </summary>
        /// <value>The reports.</value>
        [DataMember(Name="reports", EmitDefaultValue=false)]
        public ReportList Reports { get; set; }

        /// <summary>
        /// Returned when the number of results exceeds &#x60;pageSize&#x60;. To get the next page of results, call &#x60;getReports&#x60; with this token as the only parameter.
        /// </summary>
        /// <value>Returned when the number of results exceeds &#x60;pageSize&#x60;. To get the next page of results, call &#x60;getReports&#x60; with this token as the only parameter.</value>
        [DataMember(Name="nextToken", EmitDefaultValue=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetReportsResponse {\n");
            sb.Append("  Reports: ").Append(Reports).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
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
            return this.Equals(input as GetReportsResponse);
        }

        /// <summary>
        /// Returns true if GetReportsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetReportsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetReportsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reports == input.Reports ||
                    (this.Reports != null &&
                    this.Reports.Equals(input.Reports))
                ) && 
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
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
                if (this.Reports != null)
                    hashCode = hashCode * 59 + this.Reports.GetHashCode();
                if (this.NextToken != null)
                    hashCode = hashCode * 59 + this.NextToken.GetHashCode();
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
