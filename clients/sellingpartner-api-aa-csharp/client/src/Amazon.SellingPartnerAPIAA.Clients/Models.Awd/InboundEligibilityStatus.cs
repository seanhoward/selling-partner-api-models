/* 
 * The Selling Partner API for Amazon Warehousing and Distribution
 *
 * The Selling Partner API for Amazon Warehousing and Distribution (AWD) provides programmatic access to information about AWD shipments and inventory. 
 *
 * OpenAPI spec version: 2024-05-09
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Awd
{
    /// <summary>
    /// Enum denoting the package inbound eligibility.
    /// </summary>
    /// <value>Enum denoting the package inbound eligibility.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum InboundEligibilityStatus
    {

        /// <summary>
        /// Enum ELIGIBLE for value: ELIGIBLE
        /// </summary>
        [EnumMember(Value = "ELIGIBLE")]
        ELIGIBLE = 1,

        /// <summary>
        /// Enum INELIGIBLE for value: INELIGIBLE
        /// </summary>
        [EnumMember(Value = "INELIGIBLE")]
        INELIGIBLE = 2
    }

}
