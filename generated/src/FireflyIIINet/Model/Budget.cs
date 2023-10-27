/*
 * Firefly III API v1.5.3
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2021-09-19T08:24:18+00:00 
 *
 * The version of the OpenAPI document: 1.5.3
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
    /// Budget
    /// </summary>
    [DataContract(Name = "Budget")]
    public partial class Budget : IEquatable<Budget>, IValidatableObject
    {
        /// <summary>
        /// The type of auto-budget that Firefly III must create.
        /// </summary>
        /// <value>The type of auto-budget that Firefly III must create.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AutoBudgetTypeEnum
        {
            /// <summary>
            /// Enum Reset for value: reset
            /// </summary>
            [EnumMember(Value = "reset")]
            Reset = 1,

            /// <summary>
            /// Enum Rollover for value: rollover
            /// </summary>
            [EnumMember(Value = "rollover")]
            Rollover = 2,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 3,

            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 4
        }


        /// <summary>
        /// The type of auto-budget that Firefly III must create.
        /// </summary>
        /// <value>The type of auto-budget that Firefly III must create.</value>
        /// <example>reset</example>
        [DataMember(Name = "auto_budget_type", EmitDefaultValue = true)]
        public AutoBudgetTypeEnum? AutoBudgetType { get; set; }
        /// <summary>
        /// Period for the auto budget
        /// </summary>
        /// <value>Period for the auto budget</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AutoBudgetPeriodEnum
        {
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 1,

            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 2,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 3,

            /// <summary>
            /// Enum Quarterly for value: quarterly
            /// </summary>
            [EnumMember(Value = "quarterly")]
            Quarterly = 4,

            /// <summary>
            /// Enum HalfYear for value: half_year
            /// </summary>
            [EnumMember(Value = "half_year")]
            HalfYear = 5,

            /// <summary>
            /// Enum Yearly for value: yearly
            /// </summary>
            [EnumMember(Value = "yearly")]
            Yearly = 6,

            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 7
        }


        /// <summary>
        /// Period for the auto budget
        /// </summary>
        /// <value>Period for the auto budget</value>
        /// <example>monthly</example>
        [DataMember(Name = "auto_budget_period", EmitDefaultValue = true)]
        public AutoBudgetPeriodEnum? AutoBudgetPeriod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Budget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Budget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Budget" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="active">active.</param>
        /// <param name="autoBudgetType">The type of auto-budget that Firefly III must create..</param>
        /// <param name="autoBudgetCurrencyId">Use either currency_id or currency_code. Defaults to the user&#39;s default currency..</param>
        /// <param name="autoBudgetCurrencyCode">Use either currency_id or currency_code. Defaults to the user&#39;s default currency..</param>
        /// <param name="autoBudgetAmount">autoBudgetAmount.</param>
        /// <param name="autoBudgetPeriod">Period for the auto budget.</param>
        public Budget(string name = default(string), bool active = default(bool), AutoBudgetTypeEnum? autoBudgetType = default(AutoBudgetTypeEnum?), string autoBudgetCurrencyId = default(string), string autoBudgetCurrencyCode = default(string), string autoBudgetAmount = default(string), AutoBudgetPeriodEnum? autoBudgetPeriod = default(AutoBudgetPeriodEnum?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Budget and cannot be null");
            }
            this.Name = name;
            this.Active = active;
            this.AutoBudgetType = autoBudgetType;
            this.AutoBudgetCurrencyId = autoBudgetCurrencyId;
            this.AutoBudgetCurrencyCode = autoBudgetCurrencyCode;
            this.AutoBudgetAmount = autoBudgetAmount;
            this.AutoBudgetPeriod = autoBudgetPeriod;
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
        /// Gets or Sets Name
        /// </summary>
        /// <example>Bills</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; private set; }

        /// <summary>
        /// Returns false as Order should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOrder()
        {
            return false;
        }
        /// <summary>
        /// Use either currency_id or currency_code. Defaults to the user&#39;s default currency.
        /// </summary>
        /// <value>Use either currency_id or currency_code. Defaults to the user&#39;s default currency.</value>
        /// <example>12</example>
        [DataMember(Name = "auto_budget_currency_id", EmitDefaultValue = true)]
        public string AutoBudgetCurrencyId { get; set; }

        /// <summary>
        /// Use either currency_id or currency_code. Defaults to the user&#39;s default currency.
        /// </summary>
        /// <value>Use either currency_id or currency_code. Defaults to the user&#39;s default currency.</value>
        /// <example>EUR</example>
        [DataMember(Name = "auto_budget_currency_code", EmitDefaultValue = true)]
        public string AutoBudgetCurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets AutoBudgetAmount
        /// </summary>
        /// <example>-1012.12</example>
        [DataMember(Name = "auto_budget_amount", EmitDefaultValue = true)]
        public string AutoBudgetAmount { get; set; }

        /// <summary>
        /// Information on how much was spent in this budget. Is only filled in when the start and end date are submitted.
        /// </summary>
        /// <value>Information on how much was spent in this budget. Is only filled in when the start and end date are submitted.</value>
        [DataMember(Name = "spent", EmitDefaultValue = false)]
        public List<BudgetSpent> Spent { get; private set; }

        /// <summary>
        /// Returns false as Spent should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSpent()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Budget {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  AutoBudgetType: ").Append(AutoBudgetType).Append("\n");
            sb.Append("  AutoBudgetCurrencyId: ").Append(AutoBudgetCurrencyId).Append("\n");
            sb.Append("  AutoBudgetCurrencyCode: ").Append(AutoBudgetCurrencyCode).Append("\n");
            sb.Append("  AutoBudgetAmount: ").Append(AutoBudgetAmount).Append("\n");
            sb.Append("  AutoBudgetPeriod: ").Append(AutoBudgetPeriod).Append("\n");
            sb.Append("  Spent: ").Append(Spent).Append("\n");
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
            return this.Equals(input as Budget);
        }

        /// <summary>
        /// Returns true if Budget instances are equal
        /// </summary>
        /// <param name="input">Instance of Budget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Budget input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.AutoBudgetType == input.AutoBudgetType ||
                    this.AutoBudgetType.Equals(input.AutoBudgetType)
                ) && 
                (
                    this.AutoBudgetCurrencyId == input.AutoBudgetCurrencyId ||
                    (this.AutoBudgetCurrencyId != null &&
                    this.AutoBudgetCurrencyId.Equals(input.AutoBudgetCurrencyId))
                ) && 
                (
                    this.AutoBudgetCurrencyCode == input.AutoBudgetCurrencyCode ||
                    (this.AutoBudgetCurrencyCode != null &&
                    this.AutoBudgetCurrencyCode.Equals(input.AutoBudgetCurrencyCode))
                ) && 
                (
                    this.AutoBudgetAmount == input.AutoBudgetAmount ||
                    (this.AutoBudgetAmount != null &&
                    this.AutoBudgetAmount.Equals(input.AutoBudgetAmount))
                ) && 
                (
                    this.AutoBudgetPeriod == input.AutoBudgetPeriod ||
                    this.AutoBudgetPeriod.Equals(input.AutoBudgetPeriod)
                ) && 
                (
                    this.Spent == input.Spent ||
                    this.Spent != null &&
                    input.Spent != null &&
                    this.Spent.SequenceEqual(input.Spent)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
                hashCode = (hashCode * 59) + this.AutoBudgetType.GetHashCode();
                if (this.AutoBudgetCurrencyId != null)
                {
                    hashCode = (hashCode * 59) + this.AutoBudgetCurrencyId.GetHashCode();
                }
                if (this.AutoBudgetCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.AutoBudgetCurrencyCode.GetHashCode();
                }
                if (this.AutoBudgetAmount != null)
                {
                    hashCode = (hashCode * 59) + this.AutoBudgetAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AutoBudgetPeriod.GetHashCode();
                if (this.Spent != null)
                {
                    hashCode = (hashCode * 59) + this.Spent.GetHashCode();
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
