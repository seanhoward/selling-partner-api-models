/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Amazon.SellingPartnerAPIAA.Clients.Client.SwaggerDateConverter;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Pricing
{
    /// <summary>
    /// Indicates the condition of the item. Possible values: New, Used, Collectible, Refurbished, Club.
    /// </summary>
    /// <value>Indicates the condition of the item. Possible values: New, Used, Collectible, Refurbished, Club.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ConditionType
    {
        
        /// <summary>
        /// Enum New for value: New
        /// </summary>
        [EnumMember(Value = "New")]
        New = 1,
        
        /// <summary>
        /// Enum Used for value: Used
        /// </summary>
        [EnumMember(Value = "Used")]
        Used = 2,
        
        /// <summary>
        /// Enum Collectible for value: Collectible
        /// </summary>
        [EnumMember(Value = "Collectible")]
        Collectible = 3,
        
        /// <summary>
        /// Enum Refurbished for value: Refurbished
        /// </summary>
        [EnumMember(Value = "Refurbished")]
        Refurbished = 4,
        
        /// <summary>
        /// Enum Club for value: Club
        /// </summary>
        [EnumMember(Value = "Club")]
        Club = 5
    }

}
