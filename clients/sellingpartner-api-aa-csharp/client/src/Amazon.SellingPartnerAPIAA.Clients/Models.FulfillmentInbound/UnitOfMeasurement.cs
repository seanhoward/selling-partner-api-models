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
    /// Unit of linear measure.
    /// </summary>
    /// <value>Unit of linear measure.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UnitOfMeasurement
    {
        
        /// <summary>
        /// Enum IN for value: IN
        /// </summary>
        [EnumMember(Value = "IN")]
        IN = 1,
        
        /// <summary>
        /// Enum CM for value: CM
        /// </summary>
        [EnumMember(Value = "CM")]
        CM = 2
    }

}
