/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound
{
    /// <summary>
    /// Unit of the weight being measured.
    /// </summary>
    /// <value>Unit of the weight being measured.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum UnitOfWeight
    {

        /// <summary>
        /// Enum LB for value: LB
        /// </summary>
        [EnumMember(Value = "LB")]
        LB = 1,

        /// <summary>
        /// Enum KG for value: KG
        /// </summary>
        [EnumMember(Value = "KG")]
        KG = 2
    }

}
