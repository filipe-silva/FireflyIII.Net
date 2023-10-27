/*
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 1.0.2
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
    /// Attachment
    /// </summary>
    [DataContract(Name = "Attachment")]
    public partial class Attachment : IEquatable<Attachment>, IValidatableObject
    {
        /// <summary>
        /// The object class to which the attachment must be linked.
        /// </summary>
        /// <value>The object class to which the attachment must be linked.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AttachableTypeEnum
        {
            /// <summary>
            /// Enum Bill for value: Bill
            /// </summary>
            [EnumMember(Value = "Bill")]
            Bill = 1,

            /// <summary>
            /// Enum TransactionJournal for value: TransactionJournal
            /// </summary>
            [EnumMember(Value = "TransactionJournal")]
            TransactionJournal = 2,

            /// <summary>
            /// Enum ImportJob for value: ImportJob
            /// </summary>
            [EnumMember(Value = "ImportJob")]
            ImportJob = 3
        }


        /// <summary>
        /// The object class to which the attachment must be linked.
        /// </summary>
        /// <value>The object class to which the attachment must be linked.</value>
        /// <example>Bill</example>
        [DataMember(Name = "attachable_type", IsRequired = true, EmitDefaultValue = true)]
        public AttachableTypeEnum AttachableType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Attachment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        /// <param name="filename">filename (required).</param>
        /// <param name="attachableType">The object class to which the attachment must be linked. (required).</param>
        /// <param name="attachableId">ID of the model this attachment is linked to. (required).</param>
        /// <param name="md5">MD5 hash of the file for basic duplicate detection..</param>
        /// <param name="downloadUri">downloadUri.</param>
        /// <param name="uploadUri">uploadUri.</param>
        /// <param name="title">title.</param>
        /// <param name="notes">notes.</param>
        public Attachment(string filename = default(string), AttachableTypeEnum attachableType = default(AttachableTypeEnum), int attachableId = default(int), string md5 = default(string), string downloadUri = default(string), string uploadUri = default(string), string title = default(string), string notes = default(string))
        {
            // to ensure "filename" is required (not null)
            if (filename == null)
            {
                throw new ArgumentNullException("filename is a required property for Attachment and cannot be null");
            }
            this.Filename = filename;
            this.AttachableType = attachableType;
            this.AttachableId = attachableId;
            this.Md5 = md5;
            this.DownloadUri = downloadUri;
            this.UploadUri = uploadUri;
            this.Title = title;
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
        public int AttachableId { get; set; }

        /// <summary>
        /// MD5 hash of the file for basic duplicate detection.
        /// </summary>
        /// <value>MD5 hash of the file for basic duplicate detection.</value>
        /// <example>0c3f95f34370baa88f9fd9a671fea305</example>
        [DataMember(Name = "md5", EmitDefaultValue = false)]
        public string Md5 { get; set; }

        /// <summary>
        /// Gets or Sets DownloadUri
        /// </summary>
        /// <example>https://demo.firefly-iii.org/api/v1/attachments/191/download</example>
        [DataMember(Name = "download_uri", EmitDefaultValue = false)]
        public string DownloadUri { get; set; }

        /// <summary>
        /// Gets or Sets UploadUri
        /// </summary>
        /// <example>https://demo.firefly-iii.org/api/v1/attachments/191/download</example>
        [DataMember(Name = "upload_uri", EmitDefaultValue = false)]
        public string UploadUri { get; set; }

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
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets Mime
        /// </summary>
        /// <example>application/pdf</example>
        [DataMember(Name = "mime", EmitDefaultValue = false)]
        public string Mime { get; private set; }

        /// <summary>
        /// Returns false as Mime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMime()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        /// <example>48211</example>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; private set; }

        /// <summary>
        /// Returns false as Size should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSize()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Attachment {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  AttachableType: ").Append(AttachableType).Append("\n");
            sb.Append("  AttachableId: ").Append(AttachableId).Append("\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
            sb.Append("  DownloadUri: ").Append(DownloadUri).Append("\n");
            sb.Append("  UploadUri: ").Append(UploadUri).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Mime: ").Append(Mime).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as Attachment);
        }

        /// <summary>
        /// Returns true if Attachment instances are equal
        /// </summary>
        /// <param name="input">Instance of Attachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attachment input)
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
                    this.AttachableId.Equals(input.AttachableId)
                ) && 
                (
                    this.Md5 == input.Md5 ||
                    (this.Md5 != null &&
                    this.Md5.Equals(input.Md5))
                ) && 
                (
                    this.DownloadUri == input.DownloadUri ||
                    (this.DownloadUri != null &&
                    this.DownloadUri.Equals(input.DownloadUri))
                ) && 
                (
                    this.UploadUri == input.UploadUri ||
                    (this.UploadUri != null &&
                    this.UploadUri.Equals(input.UploadUri))
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
                ) && 
                (
                    this.Mime == input.Mime ||
                    (this.Mime != null &&
                    this.Mime.Equals(input.Mime))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
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
                if (this.Filename != null)
                {
                    hashCode = (hashCode * 59) + this.Filename.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AttachableType.GetHashCode();
                hashCode = (hashCode * 59) + this.AttachableId.GetHashCode();
                if (this.Md5 != null)
                {
                    hashCode = (hashCode * 59) + this.Md5.GetHashCode();
                }
                if (this.DownloadUri != null)
                {
                    hashCode = (hashCode * 59) + this.DownloadUri.GetHashCode();
                }
                if (this.UploadUri != null)
                {
                    hashCode = (hashCode * 59) + this.UploadUri.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.Mime != null)
                {
                    hashCode = (hashCode * 59) + this.Mime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
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