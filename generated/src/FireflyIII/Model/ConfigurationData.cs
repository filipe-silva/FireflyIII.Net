/*
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: thegrumpydictator@gmail.com
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
using OpenAPIDateConverter = FireflyIII.Client.OpenAPIDateConverter;

namespace FireflyIII.Model
{
    /// <summary>
    /// ConfigurationData
    /// </summary>
    [DataContract(Name = "Configuration_data")]
    public partial class ConfigurationData : IEquatable<ConfigurationData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationData" /> class.
        /// </summary>
        /// <param name="isDemoSite">isDemoSite.</param>
        /// <param name="permissionUpdateCheck">If the user has given permission to check for updates. - null &#x3D; never asked. - -1 &#x3D; never asked. - 0 &#x3D; no permission. - 1 &#x3D; permission .</param>
        /// <param name="lastUpdateCheck">lastUpdateCheck.</param>
        /// <param name="singleUserMode">Whether other users can register..</param>
        public ConfigurationData(bool isDemoSite = default(bool), int? permissionUpdateCheck = default(int?), DateTime lastUpdateCheck = default(DateTime), bool singleUserMode = default(bool))
        {
            this.IsDemoSite = isDemoSite;
            this.PermissionUpdateCheck = permissionUpdateCheck;
            this.LastUpdateCheck = lastUpdateCheck;
            this.SingleUserMode = singleUserMode;
        }

        /// <summary>
        /// Gets or Sets IsDemoSite
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "is_demo_site", EmitDefaultValue = true)]
        public bool IsDemoSite { get; set; }

        /// <summary>
        /// If the user has given permission to check for updates. - null &#x3D; never asked. - -1 &#x3D; never asked. - 0 &#x3D; no permission. - 1 &#x3D; permission 
        /// </summary>
        /// <value>If the user has given permission to check for updates. - null &#x3D; never asked. - -1 &#x3D; never asked. - 0 &#x3D; no permission. - 1 &#x3D; permission </value>
        /// <example>-1</example>
        [DataMember(Name = "permission_update_check", EmitDefaultValue = true)]
        public int? PermissionUpdateCheck { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdateCheck
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "last_update_check", EmitDefaultValue = false)]
        public DateTime LastUpdateCheck { get; set; }

        /// <summary>
        /// Whether other users can register.
        /// </summary>
        /// <value>Whether other users can register.</value>
        /// <example>true</example>
        [DataMember(Name = "single_user_mode", EmitDefaultValue = true)]
        public bool SingleUserMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigurationData {\n");
            sb.Append("  IsDemoSite: ").Append(IsDemoSite).Append("\n");
            sb.Append("  PermissionUpdateCheck: ").Append(PermissionUpdateCheck).Append("\n");
            sb.Append("  LastUpdateCheck: ").Append(LastUpdateCheck).Append("\n");
            sb.Append("  SingleUserMode: ").Append(SingleUserMode).Append("\n");
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
            return this.Equals(input as ConfigurationData);
        }

        /// <summary>
        /// Returns true if ConfigurationData instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsDemoSite == input.IsDemoSite ||
                    this.IsDemoSite.Equals(input.IsDemoSite)
                ) && 
                (
                    this.PermissionUpdateCheck == input.PermissionUpdateCheck ||
                    (this.PermissionUpdateCheck != null &&
                    this.PermissionUpdateCheck.Equals(input.PermissionUpdateCheck))
                ) && 
                (
                    this.LastUpdateCheck == input.LastUpdateCheck ||
                    (this.LastUpdateCheck != null &&
                    this.LastUpdateCheck.Equals(input.LastUpdateCheck))
                ) && 
                (
                    this.SingleUserMode == input.SingleUserMode ||
                    this.SingleUserMode.Equals(input.SingleUserMode)
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
                hashCode = (hashCode * 59) + this.IsDemoSite.GetHashCode();
                if (this.PermissionUpdateCheck != null)
                {
                    hashCode = (hashCode * 59) + this.PermissionUpdateCheck.GetHashCode();
                }
                if (this.LastUpdateCheck != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdateCheck.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SingleUserMode.GetHashCode();
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
