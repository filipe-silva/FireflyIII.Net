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
    /// AutocompleteTag
    /// </summary>
    [DataContract(Name = "AutocompleteTag")]
    public partial class AutocompleteTag : IEquatable<AutocompleteTag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteTag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutocompleteTag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteTag" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">Name of the tag found by an auto-complete search. (required).</param>
        /// <param name="tag">Name of the tag found by an auto-complete search. (required).</param>
        public AutocompleteTag(string id = default(string), string name = default(string), string tag = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AutocompleteTag and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AutocompleteTag and cannot be null");
            }
            this.Name = name;
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new ArgumentNullException("tag is a required property for AutocompleteTag and cannot be null");
            }
            this.Tag = tag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the tag found by an auto-complete search.
        /// </summary>
        /// <value>Name of the tag found by an auto-complete search.</value>
        /// <example>too-expensive-tag-example</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the tag found by an auto-complete search.
        /// </summary>
        /// <value>Name of the tag found by an auto-complete search.</value>
        /// <example>too-expensive-tag-example</example>
        [DataMember(Name = "tag", IsRequired = true, EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutocompleteTag {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(input as AutocompleteTag);
        }

        /// <summary>
        /// Returns true if AutocompleteTag instances are equal
        /// </summary>
        /// <param name="input">Instance of AutocompleteTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutocompleteTag input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
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
