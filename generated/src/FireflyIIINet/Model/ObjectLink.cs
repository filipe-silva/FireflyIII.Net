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
    /// ObjectLink
    /// </summary>
    [DataContract(Name = "ObjectLink")]
    public partial class ObjectLink : IEquatable<ObjectLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectLink" /> class.
        /// </summary>
        /// <param name="var0">var0.</param>
        /// <param name="self">self.</param>
        public ObjectLink(ObjectLink0 var0 = default(ObjectLink0), string self = default(string))
        {
            this.Var0 = var0;
            this.Self = self;
        }

        /// <summary>
        /// Gets or Sets Var0
        /// </summary>
        [DataMember(Name = "0", EmitDefaultValue = false)]
        public ObjectLink0 Var0 { get; set; }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        /// <example>https://demo.firefly-iii.org/api/v1/OBJECTS/1</example>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public string Self { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObjectLink {\n");
            sb.Append("  Var0: ").Append(Var0).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
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
            return this.Equals(input as ObjectLink);
        }

        /// <summary>
        /// Returns true if ObjectLink instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectLink input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Var0 == input.Var0 ||
                    (this.Var0 != null &&
                    this.Var0.Equals(input.Var0))
                ) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
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
                if (this.Var0 != null)
                {
                    hashCode = (hashCode * 59) + this.Var0.GetHashCode();
                }
                if (this.Self != null)
                {
                    hashCode = (hashCode * 59) + this.Self.GetHashCode();
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
