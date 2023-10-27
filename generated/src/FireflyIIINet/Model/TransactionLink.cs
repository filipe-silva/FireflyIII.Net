/*
 * Firefly III API v1.5.4
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2021-09-25T14:21:28+00:00 
 *
 * The version of the OpenAPI document: 1.5.4
 * Contact: james@firefly-iii.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FireflyIIINet.Client.OpenAPIDateConverter;

namespace FireflyIIINet.Model
{
    /// <summary>
    /// TransactionLink
    /// </summary>
    [DataContract(Name = "TransactionLink")]
    public partial class TransactionLink : IEquatable<TransactionLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLink" /> class.
        /// </summary>
        /// <param name="linkTypeId">The link type ID to use. You can also use the link_type_name field. (required).</param>
        /// <param name="linkTypeName">The link type name to use. You can also use the link_type_id field..</param>
        /// <param name="inwardId">The inward transaction transaction_journal_id for the link. This becomes the &#39;is paid by&#39; transaction of the set. (required).</param>
        /// <param name="outwardId">The outward transaction transaction_journal_id for the link. This becomes the &#39;pays for&#39; transaction of the set. (required).</param>
        /// <param name="notes">Optional. Some notes..</param>
        public TransactionLink(string linkTypeId = default(string), string linkTypeName = default(string), string inwardId = default(string), string outwardId = default(string), string notes = default(string))
        {
            // to ensure "linkTypeId" is required (not null)
            if (linkTypeId == null)
            {
                throw new ArgumentNullException("linkTypeId is a required property for TransactionLink and cannot be null");
            }
            this.LinkTypeId = linkTypeId;
            // to ensure "inwardId" is required (not null)
            if (inwardId == null)
            {
                throw new ArgumentNullException("inwardId is a required property for TransactionLink and cannot be null");
            }
            this.InwardId = inwardId;
            // to ensure "outwardId" is required (not null)
            if (outwardId == null)
            {
                throw new ArgumentNullException("outwardId is a required property for TransactionLink and cannot be null");
            }
            this.OutwardId = outwardId;
            this.LinkTypeName = linkTypeName;
            this.Notes = notes;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// The link type ID to use. You can also use the link_type_name field.
        /// </summary>
        /// <value>The link type ID to use. You can also use the link_type_name field.</value>
        /// <example>5</example>
        [DataMember(Name = "link_type_id", IsRequired = true, EmitDefaultValue = true)]
        public string LinkTypeId { get; set; }

        /// <summary>
        /// The link type name to use. You can also use the link_type_id field.
        /// </summary>
        /// <value>The link type name to use. You can also use the link_type_id field.</value>
        /// <example>Is paid by</example>
        [DataMember(Name = "link_type_name", EmitDefaultValue = false)]
        public string LinkTypeName { get; set; }

        /// <summary>
        /// The inward transaction transaction_journal_id for the link. This becomes the &#39;is paid by&#39; transaction of the set.
        /// </summary>
        /// <value>The inward transaction transaction_journal_id for the link. This becomes the &#39;is paid by&#39; transaction of the set.</value>
        /// <example>131</example>
        [DataMember(Name = "inward_id", IsRequired = true, EmitDefaultValue = true)]
        public string InwardId { get; set; }

        /// <summary>
        /// The outward transaction transaction_journal_id for the link. This becomes the &#39;pays for&#39; transaction of the set.
        /// </summary>
        /// <value>The outward transaction transaction_journal_id for the link. This becomes the &#39;pays for&#39; transaction of the set.</value>
        /// <example>131</example>
        [DataMember(Name = "outward_id", IsRequired = true, EmitDefaultValue = true)]
        public string OutwardId { get; set; }

        /// <summary>
        /// Optional. Some notes.
        /// </summary>
        /// <value>Optional. Some notes.</value>
        /// <example>Some example notes</example>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionLink {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  LinkTypeId: ").Append(LinkTypeId).Append("\n");
            sb.Append("  LinkTypeName: ").Append(LinkTypeName).Append("\n");
            sb.Append("  InwardId: ").Append(InwardId).Append("\n");
            sb.Append("  OutwardId: ").Append(OutwardId).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransactionLink);
        }

        /// <summary>
        /// Returns true if TransactionLink instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionLink input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.LinkTypeId == input.LinkTypeId ||
                    (this.LinkTypeId != null &&
                    this.LinkTypeId.Equals(input.LinkTypeId))
                ) && 
                (
                    this.LinkTypeName == input.LinkTypeName ||
                    (this.LinkTypeName != null &&
                    this.LinkTypeName.Equals(input.LinkTypeName))
                ) && 
                (
                    this.InwardId == input.InwardId ||
                    (this.InwardId != null &&
                    this.InwardId.Equals(input.InwardId))
                ) && 
                (
                    this.OutwardId == input.OutwardId ||
                    (this.OutwardId != null &&
                    this.OutwardId.Equals(input.OutwardId))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.LinkTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.LinkTypeId.GetHashCode();
                }
                if (this.LinkTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.LinkTypeName.GetHashCode();
                }
                if (this.InwardId != null)
                {
                    hashCode = (hashCode * 59) + this.InwardId.GetHashCode();
                }
                if (this.OutwardId != null)
                {
                    hashCode = (hashCode * 59) + this.OutwardId.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
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
