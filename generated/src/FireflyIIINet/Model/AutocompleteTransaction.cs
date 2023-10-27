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
    /// AutocompleteTransaction
    /// </summary>
    [DataContract(Name = "AutocompleteTransaction")]
    public partial class AutocompleteTransaction : IEquatable<AutocompleteTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutocompleteTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteTransaction" /> class.
        /// </summary>
        /// <param name="id">The ID of a transaction journal (basically a single split). (required).</param>
        /// <param name="transactionGroupId">The ID of the underlying transaction group..</param>
        /// <param name="name">Transaction description (required).</param>
        /// <param name="description">Transaction description (required).</param>
        public AutocompleteTransaction(string id = default(string), string transactionGroupId = default(string), string name = default(string), string description = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AutocompleteTransaction and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AutocompleteTransaction and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for AutocompleteTransaction and cannot be null");
            }
            this.Description = description;
            this.TransactionGroupId = transactionGroupId;
        }

        /// <summary>
        /// The ID of a transaction journal (basically a single split).
        /// </summary>
        /// <value>The ID of a transaction journal (basically a single split).</value>
        /// <example>2</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the underlying transaction group.
        /// </summary>
        /// <value>The ID of the underlying transaction group.</value>
        /// <example>2</example>
        [DataMember(Name = "transaction_group_id", EmitDefaultValue = false)]
        public string TransactionGroupId { get; set; }

        /// <summary>
        /// Transaction description
        /// </summary>
        /// <value>Transaction description</value>
        /// <example>Transaction</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Transaction description
        /// </summary>
        /// <value>Transaction description</value>
        /// <example>Transaction</example>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutocompleteTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TransactionGroupId: ").Append(TransactionGroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as AutocompleteTransaction);
        }

        /// <summary>
        /// Returns true if AutocompleteTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of AutocompleteTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutocompleteTransaction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TransactionGroupId == input.TransactionGroupId ||
                    (this.TransactionGroupId != null &&
                    this.TransactionGroupId.Equals(input.TransactionGroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.TransactionGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionGroupId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
