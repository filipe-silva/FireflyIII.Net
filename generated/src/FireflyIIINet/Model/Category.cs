/*
 * Firefly III API v2.0.3
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-06-11T09:13:59+00:00 
 *
 * The version of the OpenAPI document: 2.0.3
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
    /// Category
    /// </summary>
    [DataContract(Name = "Category")]
    public partial class Category : IEquatable<Category>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Category() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="notes">notes.</param>
        public Category(string name = default(string), string notes = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Category and cannot be null");
            }
            this.Name = name;
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
        /// Gets or Sets Name
        /// </summary>
        /// <example>Lunch</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        /// <example>Some example notes</example>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets Spent
        /// </summary>
        [DataMember(Name = "spent", EmitDefaultValue = false)]
        public List<CategorySpent> Spent { get; private set; }

        /// <summary>
        /// Returns false as Spent should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSpent()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Earned
        /// </summary>
        [DataMember(Name = "earned", EmitDefaultValue = false)]
        public List<CategoryEarned> Earned { get; private set; }

        /// <summary>
        /// Returns false as Earned should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEarned()
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
            sb.Append("class Category {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Spent: ").Append(Spent).Append("\n");
            sb.Append("  Earned: ").Append(Earned).Append("\n");
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
            return this.Equals(input as Category);
        }

        /// <summary>
        /// Returns true if Category instances are equal
        /// </summary>
        /// <param name="input">Instance of Category to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Category input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Spent == input.Spent ||
                    this.Spent != null &&
                    input.Spent != null &&
                    this.Spent.SequenceEqual(input.Spent)
                ) && 
                (
                    this.Earned == input.Earned ||
                    this.Earned != null &&
                    input.Earned != null &&
                    this.Earned.SequenceEqual(input.Earned)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.Spent != null)
                {
                    hashCode = (hashCode * 59) + this.Spent.GetHashCode();
                }
                if (this.Earned != null)
                {
                    hashCode = (hashCode * 59) + this.Earned.GetHashCode();
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
