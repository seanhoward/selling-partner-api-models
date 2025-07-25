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
    /// The supported order change type of ORDER_CHANGE notification.
    /// </summary>
    /// <value>The supported order change type of ORDER_CHANGE notification.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum OrderChangeTypeEnum
    {

        /// <summary>
        /// Enum OrderStatusChange for value: OrderStatusChange
        /// </summary>
        [EnumMember(Value = "OrderStatusChange")]
        OrderStatusChange = 1,

        /// <summary>
        /// Enum BuyerRequestedChange for value: BuyerRequestedChange
        /// </summary>
        [EnumMember(Value = "BuyerRequestedChange")]
        BuyerRequestedChange = 2
    }

}
