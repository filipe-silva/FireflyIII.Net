/*
 * Firefly III API v2.0.2
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-05-17T04:54:43+00:00 
 *
 * The version of the OpenAPI document: 2.0.2
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
    /// LinkTypeRead
    /// </summary>
    [DataContract(Name = "LinkTypeRead")]
    public partial class LinkTypeRead : IEquatable<LinkTypeRead>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkTypeRead" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkTypeRead() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkTypeRead" /> class.
        /// </summary>
        /// <param name="type">Immutable value (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="attributes">attributes (required).</param>
        /// <param name="links">links (required).</param>
        public LinkTypeRead(string type = default(string), string id = default(string), LinkType attributes = default(LinkType), ObjectLink links = default(ObjectLink))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for LinkTypeRead and cannot be null");
            }
            Type = type;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for LinkTypeRead and cannot be null");
            }
            Id = id;
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new ArgumentNullException("attributes is a required property for LinkTypeRead and cannot be null");
            }
            Attributes = attributes;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for LinkTypeRead and cannot be null");
            }
            Links = links;
        }

        /// <summary>
        /// Immutable value
        /// </summary>
        /// <value>Immutable value</value>
        /// <example>link_types</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", IsRequired = true, EmitDefaultValue = true)]
        public LinkType Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public ObjectLink Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinkTypeRead {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return Equals(input as LinkTypeRead);
        }

        /// <summary>
        /// Returns true if LinkTypeRead instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkTypeRead to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkTypeRead input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Type == input.Type ||
					Type.Equals(input.Type)
                ) && 
                (
                    Id == input.Id ||
					Id.Equals(input.Id)
                ) && 
                (
                    Attributes == input.Attributes ||
					Attributes.Equals(input.Attributes)
                ) && 
                (
                    Links == input.Links ||
					Links.Equals(input.Links)
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
				hashCode = (hashCode * 59) + Type.GetHashCode();
				hashCode = (hashCode * 59) + Id.GetHashCode();
				hashCode = (hashCode * 59) + Attributes.GetHashCode();
				hashCode = (hashCode * 59) + Links.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
