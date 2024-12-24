/* 
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.   **Note:** If you are new to the Amazon Shipping API, refer to the latest version of <a href=\"https://developer-docs.amazon.com/amazon-shipping/docs/shipping-api-v2-reference\">Amazon Shipping API (v2)</a> on the <a href=\"https://developer-docs.amazon.com/amazon-shipping/\">Amazon Shipping Developer Documentation</a> site.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Shipping
{
    /// <summary>
    /// The type of shipping service that will be used for the service offering.
    /// </summary>
    /// <value>The type of shipping service that will be used for the service offering.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ServiceType
    {
        
        /// <summary>
        /// Enum Ground for value: Amazon Shipping Ground
        /// </summary>
        [EnumMember(Value = "Amazon Shipping Ground")]
        Ground = 1,
        
        /// <summary>
        /// Enum Standard for value: Amazon Shipping Standard
        /// </summary>
        [EnumMember(Value = "Amazon Shipping Standard")]
        Standard = 2,
        
        /// <summary>
        /// Enum Premium for value: Amazon Shipping Premium
        /// </summary>
        [EnumMember(Value = "Amazon Shipping Premium")]
        Premium = 3
    }

}