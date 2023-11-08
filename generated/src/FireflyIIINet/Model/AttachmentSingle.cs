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
    /// AttachmentSingle
    /// </summary>
    [DataContract(Name = "AttachmentSingle")]
    public partial class AttachmentSingle : IEquatable<AttachmentSingle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentSingle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttachmentSingle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentSingle" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        public AttachmentSingle(AttachmentRead data = default(AttachmentRead))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for AttachmentSingle and cannot be null");
            }
            Data = data;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public AttachmentRead Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttachmentSingle {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return Equals(input as AttachmentSingle);
        }

        /// <summary>
        /// Returns true if AttachmentSingle instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentSingle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentSingle input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Data == input.Data ||
					Data.Equals(input.Data)
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
				hashCode = (hashCode * 59) + Data.GetHashCode();
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
