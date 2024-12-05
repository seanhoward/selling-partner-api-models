/* 
 * Orders v0
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
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
    /// An item that is associated with an order item. For example, a tire installation service that is purchased with tires.
    /// </summary>
    [DataContract]
    public partial class AssociatedItem :  IEquatable<AssociatedItem>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AssociationType
        /// </summary>
        [DataMember(Name="AssociationType", EmitDefaultValue=false)]
        public AssociationType? AssociationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedItem" /> class.
        /// </summary>
        /// <param name="orderId">The order item&#39;s order identifier, in 3-7-7 format..</param>
        /// <param name="orderItemId">An Amazon-defined item identifier for the associated item..</param>
        /// <param name="associationType">associationType.</param>
        public AssociatedItem(string orderId = default(string), string orderItemId = default(string), AssociationType? associationType = default(AssociationType?))
        {
            this.OrderId = orderId;
            this.OrderItemId = orderItemId;
            this.AssociationType = associationType;
        }
        
        /// <summary>
        /// The order item&#39;s order identifier, in 3-7-7 format.
        /// </summary>
        /// <value>The order item&#39;s order identifier, in 3-7-7 format.</value>
        [DataMember(Name="OrderId", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// An Amazon-defined item identifier for the associated item.
        /// </summary>
        /// <value>An Amazon-defined item identifier for the associated item.</value>
        [DataMember(Name="OrderItemId", EmitDefaultValue=false)]
        public string OrderItemId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociatedItem {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderItemId: ").Append(OrderItemId).Append("\n");
            sb.Append("  AssociationType: ").Append(AssociationType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociatedItem);
        }

        /// <summary>
        /// Returns true if AssociatedItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AssociatedItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssociatedItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OrderItemId == input.OrderItemId ||
                    (this.OrderItemId != null &&
                    this.OrderItemId.Equals(input.OrderItemId))
                ) && 
                (
                    this.AssociationType == input.AssociationType ||
                    (this.AssociationType != null &&
                    this.AssociationType.Equals(input.AssociationType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OrderItemId != null)
                    hashCode = hashCode * 59 + this.OrderItemId.GetHashCode();
                if (this.AssociationType != null)
                    hashCode = hashCode * 59 + this.AssociationType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
