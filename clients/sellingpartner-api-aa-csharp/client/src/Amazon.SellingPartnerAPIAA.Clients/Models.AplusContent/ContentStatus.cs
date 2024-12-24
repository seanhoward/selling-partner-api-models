/* 
 * Selling Partner API for A+ Content Management
 *
 * With the A+ Content API, you can build applications that help selling partners add rich marketing content to their Amazon product detail pages. A+ content helps selling partners share their brand and product story, which helps buyers make informed purchasing decisions. Selling partners assemble content by choosing from content modules and adding images and text.
 *
 * OpenAPI spec version: 2020-11-01
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.AplusContent
{
    /// <summary>
    /// The submission status of the content document.
    /// </summary>
    /// <value>The submission status of the content document.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ContentStatus
    {
        
        /// <summary>
        /// Enum APPROVED for value: APPROVED
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        APPROVED = 1,
        
        /// <summary>
        /// Enum DRAFT for value: DRAFT
        /// </summary>
        [EnumMember(Value = "DRAFT")]
        DRAFT = 2,
        
        /// <summary>
        /// Enum REJECTED for value: REJECTED
        /// </summary>
        [EnumMember(Value = "REJECTED")]
        REJECTED = 3,
        
        /// <summary>
        /// Enum SUBMITTED for value: SUBMITTED
        /// </summary>
        [EnumMember(Value = "SUBMITTED")]
        SUBMITTED = 4
    }

}
