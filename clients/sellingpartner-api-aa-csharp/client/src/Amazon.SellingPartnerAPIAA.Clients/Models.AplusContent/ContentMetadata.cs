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
    /// The metadata of an A+ Content document.
    /// </summary>
    [DataContract]
    public partial class ContentMetadata :  IEquatable<ContentMetadata>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ContentStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentMetadata" /> class.
        /// </summary>
        /// <param name="name">The A+ Content document name. (required).</param>
        /// <param name="marketplaceId">marketplaceId (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="badgeSet">badgeSet (required).</param>
        /// <param name="updateTime">The approximate age of the A+ Content document and metadata. (required).</param>
        public ContentMetadata(string name = default(string), string marketplaceId = default(string), ContentStatus status = default(ContentStatus), ContentBadgeSet badgeSet = default(ContentBadgeSet), DateTime? updateTime = default(DateTime?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ContentMetadata and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for ContentMetadata and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for ContentMetadata and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "badgeSet" is required (not null)
            if (badgeSet == null)
            {
                throw new InvalidDataException("badgeSet is a required property for ContentMetadata and cannot be null");
            }
            else
            {
                this.BadgeSet = badgeSet;
            }
            // to ensure "updateTime" is required (not null)
            if (updateTime == null)
            {
                throw new InvalidDataException("updateTime is a required property for ContentMetadata and cannot be null");
            }
            else
            {
                this.UpdateTime = updateTime;
            }
        }
        
        /// <summary>
        /// The A+ Content document name.
        /// </summary>
        /// <value>The A+ Content document name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets MarketplaceId
        /// </summary>
        [DataMember(Name="marketplaceId", EmitDefaultValue=false)]
        public string MarketplaceId { get; set; }


        /// <summary>
        /// Gets or Sets BadgeSet
        /// </summary>
        [DataMember(Name="badgeSet", EmitDefaultValue=false)]
        public ContentBadgeSet BadgeSet { get; set; }

        /// <summary>
        /// The approximate age of the A+ Content document and metadata.
        /// </summary>
        /// <value>The approximate age of the A+ Content document and metadata.</value>
        [DataMember(Name="updateTime", EmitDefaultValue=false)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentMetadata {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BadgeSet: ").Append(BadgeSet).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
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
            return this.Equals(input as ContentMetadata);
        }

        /// <summary>
        /// Returns true if ContentMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of ContentMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.BadgeSet == input.BadgeSet ||
                    (this.BadgeSet != null &&
                    this.BadgeSet.Equals(input.BadgeSet))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BadgeSet != null)
                    hashCode = hashCode * 59 + this.BadgeSet.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}