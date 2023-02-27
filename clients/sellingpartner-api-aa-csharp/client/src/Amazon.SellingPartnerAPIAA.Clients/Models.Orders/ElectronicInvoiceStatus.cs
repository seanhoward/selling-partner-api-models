/* 
 * Selling Partner API for Orders
 *
 * The Selling Partner API for Orders helps you programmatically retrieve order information. These APIs let you develop fast, flexible, custom applications in areas like order synchronization, order research, and demand-based decision support tools.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Orders
{
    /// <summary>
    /// The status of the electronic invoice.
    /// </summary>
    /// <value>The status of the electronic invoice.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ElectronicInvoiceStatus
    {
        
        /// <summary>
        /// Enum NotRequired for value: NotRequired
        /// </summary>
        [EnumMember(Value = "NotRequired")]
        NotRequired = 1,
        
        /// <summary>
        /// Enum NotFound for value: NotFound
        /// </summary>
        [EnumMember(Value = "NotFound")]
        NotFound = 2,
        
        /// <summary>
        /// Enum Processing for value: Processing
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing = 3,
        
        /// <summary>
        /// Enum Errored for value: Errored
        /// </summary>
        [EnumMember(Value = "Errored")]
        Errored = 4,
        
        /// <summary>
        /// Enum Accepted for value: Accepted
        /// </summary>
        [EnumMember(Value = "Accepted")]
        Accepted = 5
    }

}