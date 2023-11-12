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
            Name = name;
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException("accountId is a required property for PiggyBankStore and cannot be null");
            }
            AccountId = accountId;
            // to ensure "targetAmount" is required (not null)
            if (targetAmount == null)
            {
                throw new ArgumentNullException("targetAmount is a required property for PiggyBankStore and cannot be null");
            }
            TargetAmount = targetAmount;
            CurrentAmount = currentAmount;
            StartDate = startDate;
            TargetDate = targetDate;
            Order = order;
            Notes = notes;
            ObjectGroupId = objectGroupId;
            ObjectGroupTitle = objectGroupTitle;
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
        [DataMember(Name = "current_amount", EmitDefaultValue = true)]
        public string CurrentAmount { get; set; }

        /// <summary>
        /// The date you started with this piggy bank.
        /// </summary>
        /// <value>The date you started with this piggy bank.</value>
        /// <example>Mon Sep 17 01:00:00 WEST 2018</example>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The date you intend to finish saving money.
        /// </summary>
        /// <value>The date you intend to finish saving money.</value>
        /// <example>Mon Sep 17 01:00:00 WEST 2018</example>
        [DataMember(Name = "target_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? TargetDate { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "order", EmitDefaultValue = true)]
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
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// The group ID of the group this object is part of. NULL if no group.
        /// </summary>
        /// <value>The group ID of the group this object is part of. NULL if no group.</value>
        /// <example>5</example>
        [DataMember(Name = "object_group_id", EmitDefaultValue = false)]
        public string ObjectGroupId { get; set; }

        /// <summary>
        /// The name of the group. NULL if no group.
        /// </summary>
        /// <value>The name of the group. NULL if no group.</value>
        /// <example>Example Group</example>
        [DataMember(Name = "object_group_title", EmitDefaultValue = false)]
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as PiggyBankStore);
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
                    Name == input.Name ||
					Name.Equals(input.Name)
                ) && 
                (
                    AccountId == input.AccountId ||
					AccountId.Equals(input.AccountId)
                ) && 
                (
                    TargetAmount == input.TargetAmount ||
                    (TargetAmount != null &&
                    TargetAmount.Equals(input.TargetAmount))
                ) && 
                (
                    CurrentAmount == input.CurrentAmount ||
					CurrentAmount.Equals(input.CurrentAmount)
                ) && 
                (
                    StartDate == input.StartDate ||
					StartDate.Equals(input.StartDate)
                ) && 
                (
                    TargetDate == input.TargetDate ||
                    (TargetDate != null &&
                    TargetDate.Equals(input.TargetDate))
                ) && 
                (
                    Order == input.Order ||
                    Order.Equals(input.Order)
                ) && 
                (
                    Active == input.Active ||
                    Active.Equals(input.Active)
                ) && 
                (
                    Notes == input.Notes ||
                    (Notes != null &&
                    Notes.Equals(input.Notes))
                ) && 
                (
                    ObjectGroupId == input.ObjectGroupId ||
                    (ObjectGroupId != null &&
                    ObjectGroupId.Equals(input.ObjectGroupId))
                ) && 
                (
                    ObjectGroupTitle == input.ObjectGroupTitle ||
                    (ObjectGroupTitle != null &&
                    ObjectGroupTitle.Equals(input.ObjectGroupTitle))
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
				hashCode = (hashCode * 59) + Name.GetHashCode();
				hashCode = (hashCode * 59) + AccountId.GetHashCode();
                if (TargetAmount != null)
                {
                    hashCode = (hashCode * 59) + TargetAmount.GetHashCode();
                }
				hashCode = (hashCode * 59) + CurrentAmount.GetHashCode();
				hashCode = (hashCode * 59) + StartDate.GetHashCode();
                if (TargetDate != null)
                {
                    hashCode = (hashCode * 59) + TargetDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + Order.GetHashCode();
                hashCode = (hashCode * 59) + Active.GetHashCode();
                if (Notes != null)
                {
                    hashCode = (hashCode * 59) + Notes.GetHashCode();
                }
                if (ObjectGroupId != null)
                {
                    hashCode = (hashCode * 59) + ObjectGroupId.GetHashCode();
                }
                if (ObjectGroupTitle != null)
                {
                    hashCode = (hashCode * 59) + ObjectGroupTitle.GetHashCode();
                }
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
