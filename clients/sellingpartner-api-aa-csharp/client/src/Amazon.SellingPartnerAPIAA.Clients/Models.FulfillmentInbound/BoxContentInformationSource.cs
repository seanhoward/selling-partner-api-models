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
    /// Indication of how box content is meant to be provided.
    /// </summary>
    /// <value>Indication of how box content is meant to be provided.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BoxContentInformationSource
    {
        
        /// <summary>
        /// Enum BOXCONTENTPROVIDED for value: BOX_CONTENT_PROVIDED
        /// </summary>
        [EnumMember(Value = "BOX_CONTENT_PROVIDED")]
        BOXCONTENTPROVIDED = 1,
        
        /// <summary>
        /// Enum MANUALPROCESS for value: MANUAL_PROCESS
        /// </summary>
        [EnumMember(Value = "MANUAL_PROCESS")]
        MANUALPROCESS = 2,
        
        /// <summary>
        /// Enum BARCODE2D for value: BARCODE_2D
        /// </summary>
        [EnumMember(Value = "BARCODE_2D")]
        BARCODE2D = 3
    }

}