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
    /// SystemInfoData
    /// </summary>
    [DataContract(Name = "SystemInfo_data")]
    public partial class SystemInfoData : IEquatable<SystemInfoData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfoData" /> class.
        /// </summary>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="apiVersion">apiVersion.</param>
        /// <param name="phpVersion">phpVersion.</param>
        /// <param name="os">os.</param>
        /// <param name="driver">driver.</param>
        public SystemInfoData(string varVersion = default(string), string apiVersion = default(string), string phpVersion = default(string), string os = default(string), string driver = default(string))
        {
            VarVersion = varVersion;
            ApiVersion = apiVersion;
            PhpVersion = phpVersion;
            Os = os;
            Driver = driver;
        }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        /// <example>5.8.0-alpha.1</example>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        /// <example>2.0.0-alpha.1</example>
        [DataMember(Name = "api_version", EmitDefaultValue = true)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets PhpVersion
        /// </summary>
        /// <example>8.1.5</example>
        [DataMember(Name = "php_version", EmitDefaultValue = true)]
        public string PhpVersion { get; set; }

        /// <summary>
        /// Gets or Sets Os
        /// </summary>
        /// <example>Linux</example>
        [DataMember(Name = "os", EmitDefaultValue = true)]
        public string Os { get; set; }

        /// <summary>
        /// Gets or Sets Driver
        /// </summary>
        /// <example>mysql</example>
        [DataMember(Name = "driver", EmitDefaultValue = true)]
        public string Driver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemInfoData {\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  PhpVersion: ").Append(PhpVersion).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  Driver: ").Append(Driver).Append("\n");
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
            return Equals(input as SystemInfoData);
        }

        /// <summary>
        /// Returns true if SystemInfoData instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemInfoData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemInfoData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    VarVersion == input.VarVersion ||
					VarVersion.Equals(input.VarVersion)
                ) && 
                (
                    ApiVersion == input.ApiVersion ||
					ApiVersion.Equals(input.ApiVersion)
                ) && 
                (
                    PhpVersion == input.PhpVersion ||
					PhpVersion.Equals(input.PhpVersion)
                ) && 
                (
                    Os == input.Os ||
					Os.Equals(input.Os)
                ) && 
                (
                    Driver == input.Driver ||
					Driver.Equals(input.Driver)
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
				hashCode = (hashCode * 59) + VarVersion.GetHashCode();
				hashCode = (hashCode * 59) + ApiVersion.GetHashCode();
				hashCode = (hashCode * 59) + PhpVersion.GetHashCode();
				hashCode = (hashCode * 59) + Os.GetHashCode();
				hashCode = (hashCode * 59) + Driver.GetHashCode();
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
