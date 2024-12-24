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
    /// Supported preferences for the distribution order.
    /// </summary>
    /// <value>Supported preferences for the distribution order.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OrderPreference
    {
        
        /// <summary>
        /// Enum PARTIALORDER for value: PARTIAL_ORDER
        /// </summary>
        [EnumMember(Value = "PARTIAL_ORDER")]
        PARTIALORDER = 1
    }

}