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
    /// The file type for a label.
    /// </summary>
    /// <value>The file type for a label.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FileType
    {
        
        /// <summary>
        /// Enum ApplicationPdf for value: application/pdf
        /// </summary>
        [EnumMember(Value = "application/pdf")]
        ApplicationPdf = 1,
        
        /// <summary>
        /// Enum ApplicationZpl for value: application/zpl
        /// </summary>
        [EnumMember(Value = "application/zpl")]
        ApplicationZpl = 2,
        
        /// <summary>
        /// Enum ImagePng for value: image/png
        /// </summary>
        [EnumMember(Value = "image/png")]
        ImagePng = 3
    }

}