/* 
 * Selling Partner API for Easy Ship
 *
 * The Selling Partner API for Easy Ship helps you build applications that help sellers manage and ship Amazon Easy Ship orders.  Your Easy Ship applications can:  * Get available time slots for packages to be scheduled for delivery.  * Schedule, reschedule, and cancel Easy Ship orders.  * Print labels, invoices, and warranties.  See the [Marketplace Support Table](doc:easyship-api-v2022-03-23-use-case-guide#marketplace-support-table) for the differences in Easy Ship operations by marketplace.
 *
 * OpenAPI spec version: 2022-03-23
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.EasyShip
{
    /// <summary>
    /// The unit of measurement used to measure the weight.
    /// </summary>
    /// <value>The unit of measurement used to measure the weight.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UnitOfWeight
    {
        
        /// <summary>
        /// Enum Grams for value: Grams
        /// </summary>
        [EnumMember(Value = "Grams")]
        Grams = 1,
        
        /// <summary>
        /// Enum G for value: G
        /// </summary>
        [EnumMember(Value = "G")]
        G = 2
    }

}
