/*
 * Firefly III API v2.0.0
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-03-05T14:16:31+00:00 
 *
 * The version of the OpenAPI document: 2.0.0
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
    /// AttachmentStore
    /// </summary>
    [DataContract(Name = "AttachmentStore")]
    public partial class AttachmentStore : IEquatable<AttachmentStore>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AttachableType
        /// </summary>
        [DataMember(Name = "attachable_type", IsRequired = true, EmitDefaultValue = true)]
        public AttachableType AttachableType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttachmentStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentStore" /> class.
        /// </summary>
        /// <param name="filename">filename (required).</param>
        /// <param name="attachableType">attachableType (required).</param>
        /// <param name="attachableId">ID of the model this attachment is linked to. (required).</param>
        /// <param name="title">title.</param>
        /// <param name="notes">notes.</param>
        public AttachmentStore(string filename = default(string), AttachableType attachableType = default(AttachableType), string attachableId = default(string), string title = default(string), string notes = default(string))
        {
            // to ensure "filename" is required (not null)
            if (filename == null)
            {
                throw new ArgumentNullException("filename is a required property for AttachmentStore and cannot be null");
            }
            this.Filename = filename;
            this.AttachableType = attachableType;
            // to ensure "attachableId" is required (not null)
            if (attachableId == null)
            {
                throw new ArgumentNullException("attachableId is a required property for AttachmentStore and cannot be null");
            }
            this.AttachableId = attachableId;
            this.Title = title;
            this.Notes = notes;
        }

        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        /// <example>file.pdf</example>
        [DataMember(Name = "filename", IsRequired = true, EmitDefaultValue = true)]
        public string Filename { get; set; }

        /// <summary>
        /// ID of the model this attachment is linked to.
        /// </summary>
        /// <value>ID of the model this attachment is linked to.</value>
        /// <example>134</example>
        [DataMember(Name = "attachable_id", IsRequired = true, EmitDefaultValue = true)]
        public string AttachableId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        /// <example>Some PDF file</example>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        /// <example>Some notes</example>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttachmentStore {\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  AttachableType: ").Append(AttachableType).Append("\n");
            sb.Append("  AttachableId: ").Append(AttachableId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as AttachmentStore);
        }

        /// <summary>
        /// Returns true if AttachmentStore instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentStore input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.AttachableType == input.AttachableType ||
                    this.AttachableType.Equals(input.AttachableType)
                ) && 
                (
                    this.AttachableId == input.AttachableId ||
                    (this.AttachableId != null &&
                    this.AttachableId.Equals(input.AttachableId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Filename != null)
                {
                    hashCode = (hashCode * 59) + this.Filename.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AttachableType.GetHashCode();
                if (this.AttachableId != null)
                {
                    hashCode = (hashCode * 59) + this.AttachableId.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
