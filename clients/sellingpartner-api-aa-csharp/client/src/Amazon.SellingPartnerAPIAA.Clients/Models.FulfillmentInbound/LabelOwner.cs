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
    /// Specifies who will label the items. Options include &#x60;AMAZON&#x60;, &#x60;SELLER&#x60; or &#x60;NONE&#x60;.
    /// </summary>
    /// <value>Specifies who will label the items. Options include &#x60;AMAZON&#x60;, &#x60;SELLER&#x60; or &#x60;NONE&#x60;.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LabelOwner
    {
        
        /// <summary>
        /// Enum AMAZON for value: AMAZON
        /// </summary>
        [EnumMember(Value = "AMAZON")]
        AMAZON = 1,
        
        /// <summary>
        /// Enum SELLER for value: SELLER
        /// </summary>
        [EnumMember(Value = "SELLER")]
        SELLER = 2,
        
        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 3
    }

}
