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
    /// Type of distribution packages.
    /// </summary>
    /// <value>Type of distribution packages.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum DistributionPackageType
    {

        /// <summary>
        /// Enum CASE for value: CASE
        /// </summary>
        [EnumMember(Value = "CASE")]
        CASE = 1,

        /// <summary>
        /// Enum PALLET for value: PALLET
        /// </summary>
        [EnumMember(Value = "PALLET")]
        PALLET = 2
    }

}
