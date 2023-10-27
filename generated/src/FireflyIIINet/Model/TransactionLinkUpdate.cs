/*
 * Firefly III API v1.5.3
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2021-09-19T08:24:18+00:00 
 *
 * The version of the OpenAPI document: 1.5.3
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
    /// TransactionLinkUpdate
    /// </summary>
    [DataContract(Name = "TransactionLinkUpdate")]
    public partial class TransactionLinkUpdate : IEquatable<TransactionLinkUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLinkUpdate" /> class.
        /// </summary>
        /// <param name="linkTypeId">The link type ID to use. Use this field OR use the link_type_name field..</param>
        /// <param name="linkTypeName">The link type name to use. Use this field OR use the link_type_id field..</param>
        /// <param name="inwardId">The inward transaction transaction_journal_id for the link. This becomes the &#39;is paid by&#39; transaction of the set..</param>
        /// <param name="outwardId">The outward transaction transaction_journal_id for the link. This becomes the &#39;pays for&#39; transaction of the set..</param>
        /// <param name="notes">Optional. Some notes. If you submit an empty string the current notes will be removed.</param>
        public TransactionLinkUpdate(string linkTypeId = default(string), string linkTypeName = default(string), string inwardId = default(string), string outwardId = default(string), string notes = default(string))
        {
            this.LinkTypeId = linkTypeId;
            this.LinkTypeName = linkTypeName;
            this.InwardId = inwardId;
            this.OutwardId = outwardId;
            this.Notes = notes;
        }

        /// <summary>
        /// The link type ID to use. Use this field OR use the link_type_name field.
        /// </summary>
        /// <value>The link type ID to use. Use this field OR use the link_type_name field.</value>
        /// <example>5</example>
        [DataMember(Name = "link_type_id", EmitDefaultValue = false)]
        public string LinkTypeId { get; set; }

        /// <summary>
        /// The link type name to use. Use this field OR use the link_type_id field.
        /// </summary>
        /// <value>The link type name to use. Use this field OR use the link_type_id field.</value>
        /// <example>Is paid by</example>
        [DataMember(Name = "link_type_name", EmitDefaultValue = false)]
        public string LinkTypeName { get; set; }

        /// <summary>
        /// The inward transaction transaction_journal_id for the link. This becomes the &#39;is paid by&#39; transaction of the set.
        /// </summary>
        /// <value>The inward transaction transaction_journal_id for the link. This becomes the &#39;is paid by&#39; transaction of the set.</value>
        /// <example>131</example>
        [DataMember(Name = "inward_id", EmitDefaultValue = false)]
        public string InwardId { get; set; }

        /// <summary>
        /// The outward transaction transaction_journal_id for the link. This becomes the &#39;pays for&#39; transaction of the set.
        /// </summary>
        /// <value>The outward transaction transaction_journal_id for the link. This becomes the &#39;pays for&#39; transaction of the set.</value>
        /// <example>131</example>
        [DataMember(Name = "outward_id", EmitDefaultValue = false)]
        public string OutwardId { get; set; }

        /// <summary>
        /// Optional. Some notes. If you submit an empty string the current notes will be removed
        /// </summary>
        /// <value>Optional. Some notes. If you submit an empty string the current notes will be removed</value>
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
            sb.Append("class TransactionLinkUpdate {\n");
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
            return this.Equals(input as TransactionLinkUpdate);
        }

        /// <summary>
        /// Returns true if TransactionLinkUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionLinkUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionLinkUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
