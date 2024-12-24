/* 
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders and manage their resources.
 *
 * OpenAPI spec version: v1
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Services
{
    /// <summary>
    /// Type of capacity
    /// </summary>
    /// <value>Type of capacity</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CapacityType
    {
        
        /// <summary>
        /// Enum SCHEDULEDCAPACITY for value: SCHEDULED_CAPACITY
        /// </summary>
        [EnumMember(Value = "SCHEDULED_CAPACITY")]
        SCHEDULEDCAPACITY = 1,
        
        /// <summary>
        /// Enum AVAILABLECAPACITY for value: AVAILABLE_CAPACITY
        /// </summary>
        [EnumMember(Value = "AVAILABLE_CAPACITY")]
        AVAILABLECAPACITY = 2,
        
        /// <summary>
        /// Enum ENCUMBEREDCAPACITY for value: ENCUMBERED_CAPACITY
        /// </summary>
        [EnumMember(Value = "ENCUMBERED_CAPACITY")]
        ENCUMBEREDCAPACITY = 3,
        
        /// <summary>
        /// Enum RESERVEDCAPACITY for value: RESERVED_CAPACITY
        /// </summary>
        [EnumMember(Value = "RESERVED_CAPACITY")]
        RESERVEDCAPACITY = 4
    }

}
