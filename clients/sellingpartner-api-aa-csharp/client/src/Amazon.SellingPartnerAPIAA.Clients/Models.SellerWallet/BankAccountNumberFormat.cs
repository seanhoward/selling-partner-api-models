/* 
 * The Selling Partner API for Amazon Seller Wallet Open Banking API
 *
 * The Selling Partner API for Seller Wallet (Seller Wallet API) provides financial information that is relevant to a seller's Seller Wallet account. You can obtain financial events, balances, and transfer schedules for Seller Wallet accounts. You can also schedule and initiate transactions.
 *
 * OpenAPI spec version: 2024-03-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet
{
    /// <summary>
    /// The bank account&#39;s format type.
    /// </summary>
    /// <value>The bank account&#39;s format type.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum BankAccountNumberFormat
    {

        /// <summary>
        /// Enum IBAN for value: IBAN
        /// </summary>
        [EnumMember(Value = "IBAN")]
        IBAN = 1,

        /// <summary>
        /// Enum BBAN for value: BBAN
        /// </summary>
        [EnumMember(Value = "BBAN")]
        BBAN = 2
    }

}
