/* 
 * The Selling Partner API for Amazon Warehousing and Distribution
 *
 * The Selling Partner API for Amazon Warehousing and Distribution (AWD) provides programmatic access to information about AWD shipments and inventory. 
 *
 * OpenAPI spec version: 2024-05-09
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Awd
{
    /// <summary>
    /// Label page type.
    /// </summary>
    /// <value>Label page type.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PageType
    {
        
        /// <summary>
        /// Enum THERMALNONPCP for value: THERMAL_NONPCP
        /// </summary>
        [EnumMember(Value = "THERMAL_NONPCP")]
        THERMALNONPCP = 1,
        
        /// <summary>
        /// Enum PLAINPAPER for value: PLAIN_PAPER
        /// </summary>
        [EnumMember(Value = "PLAIN_PAPER")]
        PLAINPAPER = 2,
        
        /// <summary>
        /// Enum LETTER6 for value: LETTER_6
        /// </summary>
        [EnumMember(Value = "LETTER_6")]
        LETTER6 = 3
    }

}