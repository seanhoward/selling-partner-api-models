/* 
 * Selling Partner API for A+ Content Management
 *
 * Use the A+ Content API to build applications that help selling partners add rich marketing content to their Amazon product detail pages. Selling partners can use A+ content to share their brand and product story, which helps buyers make informed purchasing decisions. Selling partners use content modules to add images and text.
 *
 * OpenAPI spec version: 2020-11-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent
{
    /// <summary>
    /// The content&#39;s relative positioning.
    /// </summary>
    /// <value>The content&#39;s relative positioning.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum PositionType
    {

        /// <summary>
        /// Enum LEFT for value: LEFT
        /// </summary>
        [EnumMember(Value = "LEFT")]
        LEFT = 1,

        /// <summary>
        /// Enum RIGHT for value: RIGHT
        /// </summary>
        [EnumMember(Value = "RIGHT")]
        RIGHT = 2
    }

}
