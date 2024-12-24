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
    /// Sort order for a collection of items. For example, order or shipment.
    /// </summary>
    /// <value>Sort order for a collection of items. For example, order or shipment.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SortOrder
    {
        
        /// <summary>
        /// Enum ASCENDING for value: ASCENDING
        /// </summary>
        [EnumMember(Value = "ASCENDING")]
        ASCENDING = 1,
        
        /// <summary>
        /// Enum DESCENDING for value: DESCENDING
        /// </summary>
        [EnumMember(Value = "DESCENDING")]
        DESCENDING = 2
    }

}
