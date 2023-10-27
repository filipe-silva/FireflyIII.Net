/*
 * Firefly III API v1.5.5
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2022-02-04T17:00:55+00:00 
 *
 * The version of the OpenAPI document: 1.5.5
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
    /// PiggyBankStore
    /// </summary>
    [DataContract(Name = "PiggyBankStore")]
    public partial class PiggyBankStore : IEquatable<PiggyBankStore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PiggyBankStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PiggyBankStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PiggyBankStore" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="accountId">The ID of the asset account this piggy bank is connected to. (required).</param>
        /// <param name="targetAmount">targetAmount (required).</param>
        /// <param name="currentAmount">currentAmount.</param>
        /// <param name="startDate">The date you started with this piggy bank..</param>
        /// <param name="targetDate">The date you intend to finish saving money..</param>
        /// <param name="order">order.</param>
        /// <param name="notes">notes.</param>
        /// <param name="objectGroupId">The group ID of the group this object is part of. NULL if no group..</param>
        /// <param name="objectGroupTitle">The name of the group. NULL if no group..</param>
        public PiggyBankStore(string name = default(string), string accountId = default(string), string targetAmount = default(string), string currentAmount = default(string), DateTime startDate = default(DateTime), DateTime? targetDate = default(DateTime?), int order = default(int), string notes = default(string), string objectGroupId = default(string), string objectGroupTitle = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PiggyBankStore and cannot be null");
            }
            this.Name = name;
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException("accountId is a required property for PiggyBankStore and cannot be null");
            }
            this.AccountId = accountId;
            // to ensure "targetAmount" is required (not null)
            if (targetAmount == null)
            {
                throw new ArgumentNullException("targetAmount is a required property for PiggyBankStore and cannot be null");
            }
            this.TargetAmount = targetAmount;
            this.CurrentAmount = currentAmount;
            this.StartDate = startDate;
            this.TargetDate = targetDate;
            this.Order = order;
            this.Notes = notes;
            this.ObjectGroupId = objectGroupId;
            this.ObjectGroupTitle = objectGroupTitle;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>New digital camera</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the asset account this piggy bank is connected to.
        /// </summary>
        /// <value>The ID of the asset account this piggy bank is connected to.</value>
        /// <example>13</example>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets TargetAmount
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "target_amount", IsRequired = true, EmitDefaultValue = true)]
        public string TargetAmount { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAmount
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "current_amount", EmitDefaultValue = false)]
        public string CurrentAmount { get; set; }

        /// <summary>
        /// The date you started with this piggy bank.
        /// </summary>
        /// <value>The date you started with this piggy bank.</value>
        /// <example>Mon Sep 17 01:00:00 WEST 2018</example>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The date you intend to finish saving money.
        /// </summary>
        /// <value>The date you intend to finish saving money.</value>
        /// <example>Thu Sep 17 01:00:00 WEST 2020</example>
        [DataMember(Name = "target_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? TargetDate { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; private set; }

        /// <summary>
        /// Returns false as Active should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActive()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        /// <example>Some notes</example>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// The group ID of the group this object is part of. NULL if no group.
        /// </summary>
        /// <value>The group ID of the group this object is part of. NULL if no group.</value>
        /// <example>5</example>
        [DataMember(Name = "object_group_id", EmitDefaultValue = true)]
        public string ObjectGroupId { get; set; }

        /// <summary>
        /// The name of the group. NULL if no group.
        /// </summary>
        /// <value>The name of the group. NULL if no group.</value>
        /// <example>Example Group</example>
        [DataMember(Name = "object_group_title", EmitDefaultValue = true)]
        public string ObjectGroupTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PiggyBankStore {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  TargetAmount: ").Append(TargetAmount).Append("\n");
            sb.Append("  CurrentAmount: ").Append(CurrentAmount).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ObjectGroupId: ").Append(ObjectGroupId).Append("\n");
            sb.Append("  ObjectGroupTitle: ").Append(ObjectGroupTitle).Append("\n");
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
            return this.Equals(input as PiggyBankStore);
        }

        /// <summary>
        /// Returns true if PiggyBankStore instances are equal
        /// </summary>
        /// <param name="input">Instance of PiggyBankStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PiggyBankStore input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.TargetAmount == input.TargetAmount ||
                    (this.TargetAmount != null &&
                    this.TargetAmount.Equals(input.TargetAmount))
                ) && 
                (
                    this.CurrentAmount == input.CurrentAmount ||
                    (this.CurrentAmount != null &&
                    this.CurrentAmount.Equals(input.CurrentAmount))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.TargetDate == input.TargetDate ||
                    (this.TargetDate != null &&
                    this.TargetDate.Equals(input.TargetDate))
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.ObjectGroupId == input.ObjectGroupId ||
                    (this.ObjectGroupId != null &&
                    this.ObjectGroupId.Equals(input.ObjectGroupId))
                ) && 
                (
                    this.ObjectGroupTitle == input.ObjectGroupTitle ||
                    (this.ObjectGroupTitle != null &&
                    this.ObjectGroupTitle.Equals(input.ObjectGroupTitle))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.TargetAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TargetAmount.GetHashCode();
                }
                if (this.CurrentAmount != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAmount.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.TargetDate != null)
                {
                    hashCode = (hashCode * 59) + this.TargetDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.ObjectGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectGroupId.GetHashCode();
                }
                if (this.ObjectGroupTitle != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectGroupTitle.GetHashCode();
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
