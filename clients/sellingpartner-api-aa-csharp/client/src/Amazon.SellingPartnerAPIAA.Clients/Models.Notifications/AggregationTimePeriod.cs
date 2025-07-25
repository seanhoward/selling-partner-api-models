/* 
 * Selling Partner API for Notifications
 *
 * The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.  For more information, refer to the [Notifications Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/notifications-api-v1-use-case-guide).
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Notifications
{
    /// <summary>
    /// The supported aggregation time periods. For example, if FiveMinutes is the value chosen, and 50 price updates occur for an ASIN within 5 minutes, Amazon will send only two notifications; one for the first event, and then a subsequent notification 5 minutes later with the final end state of the data. The 48 interim events will be dropped.
    /// </summary>
    /// <value>The supported aggregation time periods. For example, if FiveMinutes is the value chosen, and 50 price updates occur for an ASIN within 5 minutes, Amazon will send only two notifications; one for the first event, and then a subsequent notification 5 minutes later with the final end state of the data. The 48 interim events will be dropped.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum AggregationTimePeriod
    {

        /// <summary>
        /// Enum FiveMinutes for value: FiveMinutes
        /// </summary>
        [EnumMember(Value = "FiveMinutes")]
        FiveMinutes = 1,

        /// <summary>
        /// Enum TenMinutes for value: TenMinutes
        /// </summary>
        [EnumMember(Value = "TenMinutes")]
        TenMinutes = 2
    }

}
