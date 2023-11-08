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
    /// AutocompleteTransactionType
    /// </summary>
    [DataContract(Name = "AutocompleteTransactionType")]
    public partial class AutocompleteTransactionType : IEquatable<AutocompleteTransactionType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteTransactionType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutocompleteTransactionType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteTransactionType" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">Type of the object found by an auto-complete search. (required).</param>
        /// <param name="type">Name of the object found by an auto-complete search. (required).</param>
        public AutocompleteTransactionType(string id = default(string), string name = default(string), string type = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AutocompleteTransactionType and cannot be null");
            }
            Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AutocompleteTransactionType and cannot be null");
            }
            Name = name;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for AutocompleteTransactionType and cannot be null");
            }
            Type = type;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Type of the object found by an auto-complete search.
        /// </summary>
        /// <value>Type of the object found by an auto-complete search.</value>
        /// <example>Withdrawal</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the object found by an auto-complete search.
        /// </summary>
        /// <value>Name of the object found by an auto-complete search.</value>
        /// <example>Withdrawal</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutocompleteTransactionType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return Equals(input as AutocompleteTransactionType);
        }

        /// <summary>
        /// Returns true if AutocompleteTransactionType instances are equal
        /// </summary>
        /// <param name="input">Instance of AutocompleteTransactionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutocompleteTransactionType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Id == input.Id ||
					Id.Equals(input.Id)
                ) && 
                (
                    Name == input.Name ||
					Name.Equals(input.Name)
                ) && 
                (
                    Type == input.Type ||
					Type.Equals(input.Type)
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
				hashCode = (hashCode * 59) + Id.GetHashCode();
				hashCode = (hashCode * 59) + Name.GetHashCode();
				hashCode = (hashCode * 59) + Type.GetHashCode();
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
