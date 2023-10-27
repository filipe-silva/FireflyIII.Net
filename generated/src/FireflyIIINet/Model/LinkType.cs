/*
 * Firefly III API v1.5.5
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2022-02-04T17:00:55+00:00 
 *
 * The version of the OpenAPI document: 1.5.5
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
    /// LinkType
    /// </summary>
    [DataContract(Name = "LinkType")]
    public partial class LinkType : IEquatable<LinkType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkType" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="inward">inward (required).</param>
        /// <param name="outward">outward (required).</param>
        public LinkType(string name = default(string), string inward = default(string), string outward = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for LinkType and cannot be null");
            }
            this.Name = name;
            // to ensure "inward" is required (not null)
            if (inward == null)
            {
                throw new ArgumentNullException("inward is a required property for LinkType and cannot be null");
            }
            this.Inward = inward;
            // to ensure "outward" is required (not null)
            if (outward == null)
            {
                throw new ArgumentNullException("outward is a required property for LinkType and cannot be null");
            }
            this.Outward = outward;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>Paid</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Inward
        /// </summary>
        /// <example>is (partially) paid for by</example>
        [DataMember(Name = "inward", IsRequired = true, EmitDefaultValue = true)]
        public string Inward { get; set; }

        /// <summary>
        /// Gets or Sets Outward
        /// </summary>
        /// <example>(partially) pays for</example>
        [DataMember(Name = "outward", IsRequired = true, EmitDefaultValue = true)]
        public string Outward { get; set; }

        /// <summary>
        /// Gets or Sets Editable
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "editable", EmitDefaultValue = true)]
        public bool Editable { get; private set; }

        /// <summary>
        /// Returns false as Editable should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEditable()
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
            sb.Append("class LinkType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Inward: ").Append(Inward).Append("\n");
            sb.Append("  Outward: ").Append(Outward).Append("\n");
            sb.Append("  Editable: ").Append(Editable).Append("\n");
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
            return this.Equals(input as LinkType);
        }

        /// <summary>
        /// Returns true if LinkType instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Inward == input.Inward ||
                    (this.Inward != null &&
                    this.Inward.Equals(input.Inward))
                ) && 
                (
                    this.Outward == input.Outward ||
                    (this.Outward != null &&
                    this.Outward.Equals(input.Outward))
                ) && 
                (
                    this.Editable == input.Editable ||
                    this.Editable.Equals(input.Editable)
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
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Inward != null)
                {
                    hashCode = (hashCode * 59) + this.Inward.GetHashCode();
                }
                if (this.Outward != null)
                {
                    hashCode = (hashCode * 59) + this.Outward.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Editable.GetHashCode();
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
