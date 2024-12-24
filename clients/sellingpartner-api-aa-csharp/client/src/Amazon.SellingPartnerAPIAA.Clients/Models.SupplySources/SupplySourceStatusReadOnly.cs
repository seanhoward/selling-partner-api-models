/* 
 * Selling Partner API for Supply Sources
 *
 * Manage configurations and capabilities of seller supply sources.
 *
 * OpenAPI spec version: 2020-07-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.SupplySources
{
    /// <summary>
    /// The &#x60;SupplySource&#x60; status.
    /// </summary>
    /// <value>The &#x60;SupplySource&#x60; status.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SupplySourceStatusReadOnly
    {
        
        /// <summary>
        /// Enum Active for value: Active
        /// </summary>
        [EnumMember(Value = "Active")]
        Active = 1,
        
        /// <summary>
        /// Enum Inactive for value: Inactive
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive = 2,
        
        /// <summary>
        /// Enum Archived for value: Archived
        /// </summary>
        [EnumMember(Value = "Archived")]
        Archived = 3
    }

}
