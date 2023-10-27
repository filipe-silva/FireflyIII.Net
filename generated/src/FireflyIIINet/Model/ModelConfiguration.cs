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
    /// ModelConfiguration
    /// </summary>
    [DataContract(Name = "varConfiguration")]
    public partial class ModelConfiguration : IEquatable<ModelConfiguration>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public ConfigValueFilter Title { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfiguration" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="value">value (required).</param>
        /// <param name="editable">If this config variable can be edited by the user (required).</param>
        public ModelConfiguration(ConfigValueFilter title = default(ConfigValueFilter), ConfigurationValue value = default(ConfigurationValue), bool editable = default(bool))
        {
            this.Title = title;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ModelConfiguration and cannot be null");
            }
            this.Value = value;
            this.Editable = editable;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public ConfigurationValue Value { get; set; }

        /// <summary>
        /// If this config variable can be edited by the user
        /// </summary>
        /// <value>If this config variable can be edited by the user</value>
        /// <example>true</example>
        [DataMember(Name = "editable", IsRequired = true, EmitDefaultValue = true)]
        public bool Editable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelConfiguration {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ModelConfiguration);
        }

        /// <summary>
        /// Returns true if ModelConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    this.Title.Equals(input.Title)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = (hashCode * 59) + this.Title.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
