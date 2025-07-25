/* 
 * Selling Partner API for Replenishment
 *
 * The Selling Partner API for Replenishment (Replenishment API) provides programmatic access to replenishment program metrics and offers. These programs provide recurring delivery of any replenishable item at a frequency chosen by the customer.  The Replenishment API is available worldwide wherever Amazon Subscribe & Save is available or is supported. The API is available to vendors and FBA selling partners.
 *
 * OpenAPI spec version: 2022-11-07
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Replenishment
{
    /// <summary>
    /// The attribute to use to sort the results.
    /// </summary>
    /// <value>The attribute to use to sort the results.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum ListOfferMetricsSortKey
    {

        /// <summary>
        /// Enum SHIPPEDSUBSCRIPTIONUNITS for value: SHIPPED_SUBSCRIPTION_UNITS
        /// </summary>
        [EnumMember(Value = "SHIPPED_SUBSCRIPTION_UNITS")]
        SHIPPEDSUBSCRIPTIONUNITS = 1,

        /// <summary>
        /// Enum TOTALSUBSCRIPTIONSREVENUE for value: TOTAL_SUBSCRIPTIONS_REVENUE
        /// </summary>
        [EnumMember(Value = "TOTAL_SUBSCRIPTIONS_REVENUE")]
        TOTALSUBSCRIPTIONSREVENUE = 2,

        /// <summary>
        /// Enum ACTIVESUBSCRIPTIONS for value: ACTIVE_SUBSCRIPTIONS
        /// </summary>
        [EnumMember(Value = "ACTIVE_SUBSCRIPTIONS")]
        ACTIVESUBSCRIPTIONS = 3,

        /// <summary>
        /// Enum NEXT90DAYSSHIPPEDSUBSCRIPTIONUNITS for value: NEXT_90DAYS_SHIPPED_SUBSCRIPTION_UNITS
        /// </summary>
        [EnumMember(Value = "NEXT_90DAYS_SHIPPED_SUBSCRIPTION_UNITS")]
        NEXT90DAYSSHIPPEDSUBSCRIPTIONUNITS = 4,

        /// <summary>
        /// Enum NEXT60DAYSSHIPPEDSUBSCRIPTIONUNITS for value: NEXT_60DAYS_SHIPPED_SUBSCRIPTION_UNITS
        /// </summary>
        [EnumMember(Value = "NEXT_60DAYS_SHIPPED_SUBSCRIPTION_UNITS")]
        NEXT60DAYSSHIPPEDSUBSCRIPTIONUNITS = 5,

        /// <summary>
        /// Enum NEXT30DAYSSHIPPEDSUBSCRIPTIONUNITS for value: NEXT_30DAYS_SHIPPED_SUBSCRIPTION_UNITS
        /// </summary>
        [EnumMember(Value = "NEXT_30DAYS_SHIPPED_SUBSCRIPTION_UNITS")]
        NEXT30DAYSSHIPPEDSUBSCRIPTIONUNITS = 6,

        /// <summary>
        /// Enum NEXT90DAYSTOTALSUBSCRIPTIONSREVENUE for value: NEXT_90DAYS_TOTAL_SUBSCRIPTIONS_REVENUE
        /// </summary>
        [EnumMember(Value = "NEXT_90DAYS_TOTAL_SUBSCRIPTIONS_REVENUE")]
        NEXT90DAYSTOTALSUBSCRIPTIONSREVENUE = 7,

        /// <summary>
        /// Enum NEXT60DAYSTOTALSUBSCRIPTIONSREVENUE for value: NEXT_60DAYS_TOTAL_SUBSCRIPTIONS_REVENUE
        /// </summary>
        [EnumMember(Value = "NEXT_60DAYS_TOTAL_SUBSCRIPTIONS_REVENUE")]
        NEXT60DAYSTOTALSUBSCRIPTIONSREVENUE = 8,

        /// <summary>
        /// Enum NEXT30DAYSTOTALSUBSCRIPTIONSREVENUE for value: NEXT_30DAYS_TOTAL_SUBSCRIPTIONS_REVENUE
        /// </summary>
        [EnumMember(Value = "NEXT_30DAYS_TOTAL_SUBSCRIPTIONS_REVENUE")]
        NEXT30DAYSTOTALSUBSCRIPTIONSREVENUE = 9
    }

}
