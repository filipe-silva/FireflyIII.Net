/* 
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 0.10.4-modified
 * Contact: thegrumpydictator@gmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = FireflyIII.Client.OpenAPIDateConverter;

namespace FireflyIII.Model
{
    /// <summary>
    /// TransactionLink
    /// </summary>
    [DataContract]
    public partial class TransactionLink :  IEquatable<TransactionLink>, IValidatableObject
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
        public TransactionLink(int linkTypeId = default(int), string linkTypeName = default(string), int inwardId = default(int), int outwardId = default(int), string notes = default(string))
        {
            // to ensure "linkTypeId" is required (not null)
            if (linkTypeId == 0)
            {
                throw new InvalidDataException("linkTypeId is a required property for TransactionLink and cannot be null");
            }
            else
            {
                this.LinkTypeId = linkTypeId;
            }

            // to ensure "inwardId" is required (not null)
            if (inwardId == 0)
            {
                throw new InvalidDataException("inwardId is a required property for TransactionLink and cannot be null");
            }
            else
            {
                this.InwardId = inwardId;
            }

            // to ensure "outwardId" is required (not null)
            if (outwardId == 0)
            {
                throw new InvalidDataException("outwardId is a required property for TransactionLink and cannot be null");
            }
            else
            {
                this.OutwardId = outwardId;
            }

            this.LinkTypeName = linkTypeName;
            this.Notes = notes;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// The link type ID to use. You can also use the link_type_name field.
        /// </summary>
        /// <value>The link type ID to use. You can also use the link_type_name field.</value>
        [DataMember(Name="link_type_id", EmitDefaultValue=true)]
        public int LinkTypeId { get; set; }

        /// <summary>
        /// The link type name to use. You can also use the link_type_id field.
        /// </summary>
        /// <value>The link type name to use. You can also use the link_type_id field.</value>
        [DataMember(Name="link_type_name", EmitDefaultValue=false)]
        public string LinkTypeName { get; set; }

        /// <summary>
        /// The inward transaction transaction_journal_id for the link. This becomes the &#39;is paid by&#39; transaction of the set.
        /// </summary>
        /// <value>The inward transaction transaction_journal_id for the link. This becomes the &#39;is paid by&#39; transaction of the set.</value>
        [DataMember(Name="inward_id", EmitDefaultValue=true)]
        public int InwardId { get; set; }

        /// <summary>
        /// The outward transaction transaction_journal_id for the link. This becomes the &#39;pays for&#39; transaction of the set.
        /// </summary>
        /// <value>The outward transaction transaction_journal_id for the link. This becomes the &#39;pays for&#39; transaction of the set.</value>
        [DataMember(Name="outward_id", EmitDefaultValue=true)]
        public int OutwardId { get; set; }

        /// <summary>
        /// Optional. Some notes.
        /// </summary>
        /// <value>Optional. Some notes.</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                return false;

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
                    this.LinkTypeId.Equals(input.LinkTypeId)
                ) && 
                (
                    this.LinkTypeName == input.LinkTypeName ||
                    (this.LinkTypeName != null &&
                    this.LinkTypeName.Equals(input.LinkTypeName))
                ) && 
                (
                    this.InwardId == input.InwardId ||
                    this.InwardId.Equals(input.InwardId)
                ) && 
                (
                    this.OutwardId == input.OutwardId ||
                    this.OutwardId.Equals(input.OutwardId)
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
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.LinkTypeId.GetHashCode();
                if (this.LinkTypeName != null)
                    hashCode = hashCode * 59 + this.LinkTypeName.GetHashCode();
                hashCode = hashCode * 59 + this.InwardId.GetHashCode();
                hashCode = hashCode * 59 + this.OutwardId.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
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
