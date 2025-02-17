/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * With the Selling Partner API for Merchant Fulfillment, you can build applications that sellers can use to purchase shipping for non-Prime and Prime orders using Amazon's Buy Shipping Services.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment
{
    /// <summary>
    /// Indicates whether the additional seller input is at the item or shipment level.
    /// </summary>
    /// <value>Indicates whether the additional seller input is at the item or shipment level.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum InputTargetType
    {
        
        /// <summary>
        /// Enum SHIPMENTLEVEL for value: SHIPMENT_LEVEL
        /// </summary>
        [EnumMember(Value = "SHIPMENT_LEVEL")]
        SHIPMENTLEVEL = 1,
        
        /// <summary>
        /// Enum ITEMLEVEL for value: ITEM_LEVEL
        /// </summary>
        [EnumMember(Value = "ITEM_LEVEL")]
        ITEMLEVEL = 2
    }

}
