/* 
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound
{
    /// <summary>
    /// The &#x60;FulfillmentPolicy&#x60; value specified when you submitted the &#x60;createFulfillmentOrder&#x60; operation.
    /// </summary>
    /// <value>The &#x60;FulfillmentPolicy&#x60; value specified when you submitted the &#x60;createFulfillmentOrder&#x60; operation.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FulfillmentPolicy
    {
        
        /// <summary>
        /// Enum FillOrKill for value: FillOrKill
        /// </summary>
        [EnumMember(Value = "FillOrKill")]
        FillOrKill = 1,
        
        /// <summary>
        /// Enum FillAll for value: FillAll
        /// </summary>
        [EnumMember(Value = "FillAll")]
        FillAll = 2,
        
        /// <summary>
        /// Enum FillAllAvailable for value: FillAllAvailable
        /// </summary>
        [EnumMember(Value = "FillAllAvailable")]
        FillAllAvailable = 3
    }

}