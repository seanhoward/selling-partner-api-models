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
    /// Carrier will pick up option.
    /// </summary>
    /// <value>Carrier will pick up option.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CarrierWillPickUpOption
    {
        
        /// <summary>
        /// Enum CarrierWillPickUp for value: CarrierWillPickUp
        /// </summary>
        [EnumMember(Value = "CarrierWillPickUp")]
        CarrierWillPickUp = 1,
        
        /// <summary>
        /// Enum ShipperWillDropOff for value: ShipperWillDropOff
        /// </summary>
        [EnumMember(Value = "ShipperWillDropOff")]
        ShipperWillDropOff = 2,
        
        /// <summary>
        /// Enum NoPreference for value: NoPreference
        /// </summary>
        [EnumMember(Value = "NoPreference")]
        NoPreference = 3
    }

}