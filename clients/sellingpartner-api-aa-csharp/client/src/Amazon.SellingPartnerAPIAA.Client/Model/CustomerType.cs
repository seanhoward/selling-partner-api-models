/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Amazon.SellingPartnerAPIAA.Client.Model
{
    /// <summary>
    /// Indicates whether to request Consumer or Business offers. Default is Consumer.
    /// </summary>
    /// <value>Indicates whether to request Consumer or Business offers. Default is Consumer.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum CustomerType
    {

        /// <summary>
        /// Enum Consumer for value: Consumer
        /// </summary>
        [EnumMember(Value = "Consumer")]
        Consumer = 1,

        /// <summary>
        /// Enum Business for value: Business
        /// </summary>
        [EnumMember(Value = "Business")]
        Business = 2
    }

}
