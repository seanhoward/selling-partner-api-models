/* 
 * Selling Partner API for Easy Ship
 *
 * Use the Selling Partner API for Easy Ship to build applications for sellers to manage and ship Amazon Easy Ship orders. With this API, you can get available time slots, schedule and reschedule Easy Ship orders, and print shipping labels, invoices, and warranties. To review the differences in Easy Ship operations by marketplace, refer to [Marketplace support](https://developer-docs.amazon.com/sp-api/docs/easyship-api-v2022-03-23-use-case-guide#marketplace-support).
 *
 * OpenAPI spec version: 2022-03-23
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.EasyShip
{
    /// <summary>
    /// Identifies the method by which a seller will hand a package over to Amazon Logistics.
    /// </summary>
    /// <value>Identifies the method by which a seller will hand a package over to Amazon Logistics.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum HandoverMethod
    {

        /// <summary>
        /// Enum Pickup for value: Pickup
        /// </summary>
        [EnumMember(Value = "Pickup")]
        Pickup = 1,

        /// <summary>
        /// Enum Dropoff for value: Dropoff
        /// </summary>
        [EnumMember(Value = "Dropoff")]
        Dropoff = 2
    }

}
