/*
 * Firefly III API v1.5.0
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2021-04-01T18:51:42+00:00 
 *
 * The version of the OpenAPI document: 1.5.0
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
    /// TransactionUpdate
    /// </summary>
    [DataContract(Name = "TransactionUpdate")]
    public partial class TransactionUpdate : IEquatable<TransactionUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionUpdate" /> class.
        /// </summary>
        /// <param name="applyRules">Whether or not to apply rules when submitting transaction..</param>
        /// <param name="groupTitle">Title of the transaction if it has been split in more than one piece. Empty otherwise..</param>
        /// <param name="transactions">transactions.</param>
        public TransactionUpdate(bool applyRules = default(bool), string groupTitle = default(string), List<TransactionSplitUpdate> transactions = default(List<TransactionSplitUpdate>))
        {
            this.ApplyRules = applyRules;
            this.GroupTitle = groupTitle;
            this.Transactions = transactions;
        }

        /// <summary>
        /// Whether or not to apply rules when submitting transaction.
        /// </summary>
        /// <value>Whether or not to apply rules when submitting transaction.</value>
        /// <example>false</example>
        [DataMember(Name = "apply_rules", EmitDefaultValue = true)]
        public bool ApplyRules { get; set; }

        /// <summary>
        /// Title of the transaction if it has been split in more than one piece. Empty otherwise.
        /// </summary>
        /// <value>Title of the transaction if it has been split in more than one piece. Empty otherwise.</value>
        /// <example>Split transaction title.</example>
        [DataMember(Name = "group_title", EmitDefaultValue = true)]
        public string GroupTitle { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<TransactionSplitUpdate> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionUpdate {\n");
            sb.Append("  ApplyRules: ").Append(ApplyRules).Append("\n");
            sb.Append("  GroupTitle: ").Append(GroupTitle).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as TransactionUpdate);
        }

        /// <summary>
        /// Returns true if TransactionUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyRules == input.ApplyRules ||
                    this.ApplyRules.Equals(input.ApplyRules)
                ) && 
                (
                    this.GroupTitle == input.GroupTitle ||
                    (this.GroupTitle != null &&
                    this.GroupTitle.Equals(input.GroupTitle))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
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
                hashCode = (hashCode * 59) + this.ApplyRules.GetHashCode();
                if (this.GroupTitle != null)
                {
                    hashCode = (hashCode * 59) + this.GroupTitle.GetHashCode();
                }
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
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