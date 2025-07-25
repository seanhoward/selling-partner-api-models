/* 
 * Selling Partner API for Shipment Invoicing
 *
 * The Selling Partner API for Shipment Invoicing helps you programmatically retrieve shipment invoice information in the Brazil marketplace for a selling partner’s Fulfillment by Amazon (FBA) orders.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.ShipmentInvoicing
{
    /// <summary>
    /// The shipment invoice status.
    /// </summary>
    /// <value>The shipment invoice status.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum ShipmentInvoiceStatus
    {

        /// <summary>
        /// Enum Processing for value: Processing
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing = 1,

        /// <summary>
        /// Enum Accepted for value: Accepted
        /// </summary>
        [EnumMember(Value = "Accepted")]
        Accepted = 2,

        /// <summary>
        /// Enum Errored for value: Errored
        /// </summary>
        [EnumMember(Value = "Errored")]
        Errored = 3,

        /// <summary>
        /// Enum NotFound for value: NotFound
        /// </summary>
        [EnumMember(Value = "NotFound")]
        NotFound = 4
    }

}
