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
    /// ObjectLink0
    /// </summary>
    [DataContract(Name = "ObjectLink_0")]
    public partial class ObjectLink0 : IEquatable<ObjectLink0>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectLink0" /> class.
        /// </summary>
        /// <param name="rel">rel.</param>
        /// <param name="uri">uri.</param>
        public ObjectLink0(string rel = default(string), string uri = default(string))
        {
            this.Rel = rel;
            this.Uri = uri;
        }

        /// <summary>
        /// Gets or Sets Rel
        /// </summary>
        /// <example>self</example>
        [DataMember(Name = "rel", EmitDefaultValue = false)]
        public string Rel { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        /// <example>/OBJECTS/1</example>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObjectLink0 {\n");
            sb.Append("  Rel: ").Append(Rel).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(input as ObjectLink0);
        }

        /// <summary>
        /// Returns true if ObjectLink0 instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectLink0 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectLink0 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rel == input.Rel ||
                    (this.Rel != null &&
                    this.Rel.Equals(input.Rel))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
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
                if (this.Rel != null)
                {
                    hashCode = (hashCode * 59) + this.Rel.GetHashCode();
                }
                if (this.Uri != null)
                {
                    hashCode = (hashCode * 59) + this.Uri.GetHashCode();
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
