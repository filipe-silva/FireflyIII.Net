/*
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 1.4.0
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
    /// User
    /// </summary>
    [DataContract(Name = "User")]
    public partial class User : IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// If you say the user must be blocked, this will be the reason code.
        /// </summary>
        /// <value>If you say the user must be blocked, this will be the reason code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BlockedCodeEnum
        {
            /// <summary>
            /// Enum EmailChanged for value: email_changed
            /// </summary>
            [EnumMember(Value = "email_changed")]
            EmailChanged = 1
        }


        /// <summary>
        /// If you say the user must be blocked, this will be the reason code.
        /// </summary>
        /// <value>If you say the user must be blocked, this will be the reason code.</value>
        /// <example>email_changed</example>
        [DataMember(Name = "blocked_code", EmitDefaultValue = true)]
        public BlockedCodeEnum? BlockedCode { get; set; }
        /// <summary>
        /// Role for the new user. Can be empty or omitted.
        /// </summary>
        /// <value>Role for the new user. Can be empty or omitted.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Enum Owner for value: owner
            /// </summary>
            [EnumMember(Value = "owner")]
            Owner = 1,

            /// <summary>
            /// Enum Demo for value: demo
            /// </summary>
            [EnumMember(Value = "demo")]
            Demo = 2
        }


        /// <summary>
        /// Role for the new user. Can be empty or omitted.
        /// </summary>
        /// <value>Role for the new user. Can be empty or omitted.</value>
        /// <example>owner</example>
        [DataMember(Name = "role", EmitDefaultValue = true)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="email">The new users email address. (required).</param>
        /// <param name="blocked">Boolean to indicate if the user is blocked..</param>
        /// <param name="blockedCode">If you say the user must be blocked, this will be the reason code..</param>
        /// <param name="role">Role for the new user. Can be empty or omitted..</param>
        public User(string email = default(string), bool blocked = default(bool), BlockedCodeEnum? blockedCode = default(BlockedCodeEnum?), RoleEnum? role = default(RoleEnum?))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for User and cannot be null");
            }
            this.Email = email;
            this.Blocked = blocked;
            this.BlockedCode = blockedCode;
            this.Role = role;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// The new users email address.
        /// </summary>
        /// <value>The new users email address.</value>
        /// <example>james@firefly-iii.org</example>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Boolean to indicate if the user is blocked.
        /// </summary>
        /// <value>Boolean to indicate if the user is blocked.</value>
        /// <example>false</example>
        [DataMember(Name = "blocked", EmitDefaultValue = true)]
        public bool Blocked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
            sb.Append("  BlockedCode: ").Append(BlockedCode).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Blocked == input.Blocked ||
                    this.Blocked.Equals(input.Blocked)
                ) && 
                (
                    this.BlockedCode == input.BlockedCode ||
                    this.BlockedCode.Equals(input.BlockedCode)
                ) && 
                (
                    this.Role == input.Role ||
                    this.Role.Equals(input.Role)
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Blocked.GetHashCode();
                hashCode = (hashCode * 59) + this.BlockedCode.GetHashCode();
                hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
