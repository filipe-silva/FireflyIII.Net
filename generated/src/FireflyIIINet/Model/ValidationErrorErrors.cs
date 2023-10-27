/*
 * Firefly III API v1.5.2
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2021-05-14T15:49:56+00:00 
 *
 * The version of the OpenAPI document: 1.5.2
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
    /// ValidationErrorErrors
    /// </summary>
    [DataContract(Name = "ValidationError_errors")]
    public partial class ValidationErrorErrors : IEquatable<ValidationErrorErrors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorErrors" /> class.
        /// </summary>
        /// <param name="field1">field1.</param>
        /// <param name="field2">field2.</param>
        public ValidationErrorErrors(List<string> field1 = default(List<string>), List<string> field2 = default(List<string>))
        {
            this.Field1 = field1;
            this.Field2 = field2;
        }

        /// <summary>
        /// Gets or Sets Field1
        /// </summary>
        [DataMember(Name = "field1", EmitDefaultValue = false)]
        public List<string> Field1 { get; set; }

        /// <summary>
        /// Gets or Sets Field2
        /// </summary>
        [DataMember(Name = "field2", EmitDefaultValue = false)]
        public List<string> Field2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidationErrorErrors {\n");
            sb.Append("  Field1: ").Append(Field1).Append("\n");
            sb.Append("  Field2: ").Append(Field2).Append("\n");
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
            return this.Equals(input as ValidationErrorErrors);
        }

        /// <summary>
        /// Returns true if ValidationErrorErrors instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidationErrorErrors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationErrorErrors input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Field1 == input.Field1 ||
                    this.Field1 != null &&
                    input.Field1 != null &&
                    this.Field1.SequenceEqual(input.Field1)
                ) && 
                (
                    this.Field2 == input.Field2 ||
                    this.Field2 != null &&
                    input.Field2 != null &&
                    this.Field2.SequenceEqual(input.Field2)
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
                if (this.Field1 != null)
                {
                    hashCode = (hashCode * 59) + this.Field1.GetHashCode();
                }
                if (this.Field2 != null)
                {
                    hashCode = (hashCode * 59) + this.Field2.GetHashCode();
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
