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
    /// BadRequest
    /// </summary>
    [DataContract(Name = "BadRequest")]
    public partial class BadRequest : IEquatable<BadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequest" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="exception">exception.</param>
        public BadRequest(string message = default(string), string exception = default(string))
        {
            Message = message;
            Exception = exception;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        /// <example>Bad Request</example>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Exception
        /// </summary>
        /// <example>BadRequestHttpException</example>
        [DataMember(Name = "exception", EmitDefaultValue = true)]
        public string Exception { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BadRequest {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Exception: ").Append(Exception).Append("\n");
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
            return Equals(input as BadRequest);
        }

        /// <summary>
        /// Returns true if BadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BadRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Message == input.Message ||
					Message.Equals(input.Message)
                ) && 
                (
                    Exception == input.Exception ||
					Exception.Equals(input.Exception)
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
				hashCode = (hashCode * 59) + Message.GetHashCode();
				hashCode = (hashCode * 59) + Exception.GetHashCode();
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
