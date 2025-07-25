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
    /// Indicates the type of print type for a given label.
    /// </summary>
    /// <value>Indicates the type of print type for a given label.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum LabelPrintType
    {

        /// <summary>
        /// Enum STANDARDFORMAT for value: STANDARD_FORMAT
        /// </summary>
        [EnumMember(Value = "STANDARD_FORMAT")]
        STANDARDFORMAT = 1,

        /// <summary>
        /// Enum THERMALPRINTING for value: THERMAL_PRINTING
        /// </summary>
        [EnumMember(Value = "THERMAL_PRINTING")]
        THERMALPRINTING = 2
    }

}
