/* 
 * Fulfillment Inbound v2024-03-20
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound
{
    /// <summary>
    /// A constraint that can apply to an individual owner. If no constraint is specified, both &#x60;AMAZON&#x60; and &#x60;SELLER&#x60; are acceptable.
    /// </summary>
    /// <value>A constraint that can apply to an individual owner. If no constraint is specified, both &#x60;AMAZON&#x60; and &#x60;SELLER&#x60; are acceptable.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OwnerConstraint
    {
        
        /// <summary>
        /// Enum AMAZONONLY for value: AMAZON_ONLY
        /// </summary>
        [EnumMember(Value = "AMAZON_ONLY")]
        AMAZONONLY = 1,
        
        /// <summary>
        /// Enum NONEONLY for value: NONE_ONLY
        /// </summary>
        [EnumMember(Value = "NONE_ONLY")]
        NONEONLY = 2,
        
        /// <summary>
        /// Enum SELLERONLY for value: SELLER_ONLY
        /// </summary>
        [EnumMember(Value = "SELLER_ONLY")]
        SELLERONLY = 3
    }

}
