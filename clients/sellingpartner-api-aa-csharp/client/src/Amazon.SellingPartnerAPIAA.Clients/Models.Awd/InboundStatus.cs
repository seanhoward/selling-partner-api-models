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
    /// The supported statuses for an inbound order.
    /// </summary>
    /// <value>The supported statuses for an inbound order.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum InboundStatus
    {
        
        /// <summary>
        /// Enum DRAFT for value: DRAFT
        /// </summary>
        [EnumMember(Value = "DRAFT")]
        DRAFT = 1,
        
        /// <summary>
        /// Enum VALIDATING for value: VALIDATING
        /// </summary>
        [EnumMember(Value = "VALIDATING")]
        VALIDATING = 2,
        
        /// <summary>
        /// Enum CONFIRMED for value: CONFIRMED
        /// </summary>
        [EnumMember(Value = "CONFIRMED")]
        CONFIRMED = 3,
        
        /// <summary>
        /// Enum CLOSED for value: CLOSED
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        CLOSED = 4,
        
        /// <summary>
        /// Enum EXPIRED for value: EXPIRED
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        EXPIRED = 5,
        
        /// <summary>
        /// Enum CANCELLED for value: CANCELLED
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        CANCELLED = 6
    }

}
