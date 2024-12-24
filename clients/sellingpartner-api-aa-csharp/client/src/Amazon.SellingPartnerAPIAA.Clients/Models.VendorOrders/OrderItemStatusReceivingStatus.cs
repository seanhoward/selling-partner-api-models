/* 
 * Selling Partner API for Retail Procurement Orders
 *
 * The Selling Partner API for Retail Procurement Orders provides programmatic access to vendor orders data.
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

namespace Amazon.SellingPartnerAPIAA.Clients.Models.VendorOrders
{
    /// <summary>
    /// Item receive status at the buyer&#39;s warehouse.
    /// </summary>
    [DataContract]
    public partial class OrderItemStatusReceivingStatus :  IEquatable<OrderItemStatusReceivingStatus>, IValidatableObject
    {
        /// <summary>
        /// Receive status of the line item.
        /// </summary>
        /// <value>Receive status of the line item.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReceiveStatusEnum
        {
            
            /// <summary>
            /// Enum NOTRECEIVED for value: NOT_RECEIVED
            /// </summary>
            [EnumMember(Value = "NOT_RECEIVED")]
            NOTRECEIVED = 1,
            
            /// <summary>
            /// Enum PARTIALLYRECEIVED for value: PARTIALLY_RECEIVED
            /// </summary>
            [EnumMember(Value = "PARTIALLY_RECEIVED")]
            PARTIALLYRECEIVED = 2,
            
            /// <summary>
            /// Enum RECEIVED for value: RECEIVED
            /// </summary>
            [EnumMember(Value = "RECEIVED")]
            RECEIVED = 3
        }

        /// <summary>
        /// Receive status of the line item.
        /// </summary>
        /// <value>Receive status of the line item.</value>
        [DataMember(Name="receiveStatus", EmitDefaultValue=false)]
        public ReceiveStatusEnum? ReceiveStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemStatusReceivingStatus" /> class.
        /// </summary>
        /// <param name="receiveStatus">Receive status of the line item..</param>
        /// <param name="receivedQuantity">The total item quantity received by the buyer so far..</param>
        /// <param name="lastReceiveDate">The date when the most recent item was received at the buyer&#39;s warehouse. Must be in ISO-8601 date/time format..</param>
        public OrderItemStatusReceivingStatus(ReceiveStatusEnum? receiveStatus = default(ReceiveStatusEnum?), ItemQuantity receivedQuantity = default(ItemQuantity), DateTime? lastReceiveDate = default(DateTime?))
        {
            this.ReceiveStatus = receiveStatus;
            this.ReceivedQuantity = receivedQuantity;
            this.LastReceiveDate = lastReceiveDate;
        }
        

        /// <summary>
        /// The total item quantity received by the buyer so far.
        /// </summary>
        /// <value>The total item quantity received by the buyer so far.</value>
        [DataMember(Name="receivedQuantity", EmitDefaultValue=false)]
        public ItemQuantity ReceivedQuantity { get; set; }

        /// <summary>
        /// The date when the most recent item was received at the buyer&#39;s warehouse. Must be in ISO-8601 date/time format.
        /// </summary>
        /// <value>The date when the most recent item was received at the buyer&#39;s warehouse. Must be in ISO-8601 date/time format.</value>
        [DataMember(Name="lastReceiveDate", EmitDefaultValue=false)]
        public DateTime? LastReceiveDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderItemStatusReceivingStatus {\n");
            sb.Append("  ReceiveStatus: ").Append(ReceiveStatus).Append("\n");
            sb.Append("  ReceivedQuantity: ").Append(ReceivedQuantity).Append("\n");
            sb.Append("  LastReceiveDate: ").Append(LastReceiveDate).Append("\n");
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
            return this.Equals(input as OrderItemStatusReceivingStatus);
        }

        /// <summary>
        /// Returns true if OrderItemStatusReceivingStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItemStatusReceivingStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemStatusReceivingStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReceiveStatus == input.ReceiveStatus ||
                    (this.ReceiveStatus != null &&
                    this.ReceiveStatus.Equals(input.ReceiveStatus))
                ) && 
                (
                    this.ReceivedQuantity == input.ReceivedQuantity ||
                    (this.ReceivedQuantity != null &&
                    this.ReceivedQuantity.Equals(input.ReceivedQuantity))
                ) && 
                (
                    this.LastReceiveDate == input.LastReceiveDate ||
                    (this.LastReceiveDate != null &&
                    this.LastReceiveDate.Equals(input.LastReceiveDate))
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
                if (this.ReceiveStatus != null)
                    hashCode = hashCode * 59 + this.ReceiveStatus.GetHashCode();
                if (this.ReceivedQuantity != null)
                    hashCode = hashCode * 59 + this.ReceivedQuantity.GetHashCode();
                if (this.LastReceiveDate != null)
                    hashCode = hashCode * 59 + this.LastReceiveDate.GetHashCode();
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
