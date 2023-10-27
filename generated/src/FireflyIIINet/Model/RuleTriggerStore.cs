/*
 * Firefly III API v1.5.1
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2021-04-04T11:50:40+00:00 
 *
 * The version of the OpenAPI document: 1.5.1
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
    /// RuleTriggerStore
    /// </summary>
    [DataContract(Name = "RuleTriggerStore")]
    public partial class RuleTriggerStore : IEquatable<RuleTriggerStore>, IValidatableObject
    {
        /// <summary>
        /// The type of thing this trigger responds to. A limited set is possible
        /// </summary>
        /// <value>The type of thing this trigger responds to. A limited set is possible</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum FromAccountStarts for value: from_account_starts
            /// </summary>
            [EnumMember(Value = "from_account_starts")]
            FromAccountStarts = 1,

            /// <summary>
            /// Enum FromAccountEnds for value: from_account_ends
            /// </summary>
            [EnumMember(Value = "from_account_ends")]
            FromAccountEnds = 2,

            /// <summary>
            /// Enum FromAccountIs for value: from_account_is
            /// </summary>
            [EnumMember(Value = "from_account_is")]
            FromAccountIs = 3,

            /// <summary>
            /// Enum FromAccountContains for value: from_account_contains
            /// </summary>
            [EnumMember(Value = "from_account_contains")]
            FromAccountContains = 4,

            /// <summary>
            /// Enum ToAccountStarts for value: to_account_starts
            /// </summary>
            [EnumMember(Value = "to_account_starts")]
            ToAccountStarts = 5,

            /// <summary>
            /// Enum ToAccountEnds for value: to_account_ends
            /// </summary>
            [EnumMember(Value = "to_account_ends")]
            ToAccountEnds = 6,

            /// <summary>
            /// Enum ToAccountIs for value: to_account_is
            /// </summary>
            [EnumMember(Value = "to_account_is")]
            ToAccountIs = 7,

            /// <summary>
            /// Enum ToAccountContains for value: to_account_contains
            /// </summary>
            [EnumMember(Value = "to_account_contains")]
            ToAccountContains = 8,

            /// <summary>
            /// Enum AmountLess for value: amount_less
            /// </summary>
            [EnumMember(Value = "amount_less")]
            AmountLess = 9,

            /// <summary>
            /// Enum AmountExactly for value: amount_exactly
            /// </summary>
            [EnumMember(Value = "amount_exactly")]
            AmountExactly = 10,

            /// <summary>
            /// Enum AmountMore for value: amount_more
            /// </summary>
            [EnumMember(Value = "amount_more")]
            AmountMore = 11,

            /// <summary>
            /// Enum DescriptionStarts for value: description_starts
            /// </summary>
            [EnumMember(Value = "description_starts")]
            DescriptionStarts = 12,

            /// <summary>
            /// Enum DescriptionEnds for value: description_ends
            /// </summary>
            [EnumMember(Value = "description_ends")]
            DescriptionEnds = 13,

            /// <summary>
            /// Enum DescriptionContains for value: description_contains
            /// </summary>
            [EnumMember(Value = "description_contains")]
            DescriptionContains = 14,

            /// <summary>
            /// Enum DescriptionIs for value: description_is
            /// </summary>
            [EnumMember(Value = "description_is")]
            DescriptionIs = 15,

            /// <summary>
            /// Enum TransactionType for value: transaction_type
            /// </summary>
            [EnumMember(Value = "transaction_type")]
            TransactionType = 16,

            /// <summary>
            /// Enum CategoryIs for value: category_is
            /// </summary>
            [EnumMember(Value = "category_is")]
            CategoryIs = 17,

            /// <summary>
            /// Enum BudgetIs for value: budget_is
            /// </summary>
            [EnumMember(Value = "budget_is")]
            BudgetIs = 18,

            /// <summary>
            /// Enum TagIs for value: tag_is
            /// </summary>
            [EnumMember(Value = "tag_is")]
            TagIs = 19,

            /// <summary>
            /// Enum CurrencyIs for value: currency_is
            /// </summary>
            [EnumMember(Value = "currency_is")]
            CurrencyIs = 20,

            /// <summary>
            /// Enum HasAttachments for value: has_attachments
            /// </summary>
            [EnumMember(Value = "has_attachments")]
            HasAttachments = 21,

            /// <summary>
            /// Enum HasNoCategory for value: has_no_category
            /// </summary>
            [EnumMember(Value = "has_no_category")]
            HasNoCategory = 22,

            /// <summary>
            /// Enum HasAnyCategory for value: has_any_category
            /// </summary>
            [EnumMember(Value = "has_any_category")]
            HasAnyCategory = 23,

            /// <summary>
            /// Enum HasNoBudget for value: has_no_budget
            /// </summary>
            [EnumMember(Value = "has_no_budget")]
            HasNoBudget = 24,

            /// <summary>
            /// Enum HasAnyBudget for value: has_any_budget
            /// </summary>
            [EnumMember(Value = "has_any_budget")]
            HasAnyBudget = 25,

            /// <summary>
            /// Enum HasNoTag for value: has_no_tag
            /// </summary>
            [EnumMember(Value = "has_no_tag")]
            HasNoTag = 26,

            /// <summary>
            /// Enum HasAnyTag for value: has_any_tag
            /// </summary>
            [EnumMember(Value = "has_any_tag")]
            HasAnyTag = 27,

            /// <summary>
            /// Enum NotesContain for value: notes_contain
            /// </summary>
            [EnumMember(Value = "notes_contain")]
            NotesContain = 28,

            /// <summary>
            /// Enum NotesStart for value: notes_start
            /// </summary>
            [EnumMember(Value = "notes_start")]
            NotesStart = 29,

            /// <summary>
            /// Enum NotesEnd for value: notes_end
            /// </summary>
            [EnumMember(Value = "notes_end")]
            NotesEnd = 30,

            /// <summary>
            /// Enum NotesAre for value: notes_are
            /// </summary>
            [EnumMember(Value = "notes_are")]
            NotesAre = 31,

            /// <summary>
            /// Enum NoNotes for value: no_notes
            /// </summary>
            [EnumMember(Value = "no_notes")]
            NoNotes = 32,

            /// <summary>
            /// Enum AnyNotes for value: any_notes
            /// </summary>
            [EnumMember(Value = "any_notes")]
            AnyNotes = 33
        }


        /// <summary>
        /// The type of thing this trigger responds to. A limited set is possible
        /// </summary>
        /// <value>The type of thing this trigger responds to. A limited set is possible</value>
        /// <example>user_action</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleTriggerStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleTriggerStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleTriggerStore" /> class.
        /// </summary>
        /// <param name="type">The type of thing this trigger responds to. A limited set is possible (required).</param>
        /// <param name="value">The accompanying value the trigger responds to. This value is often mandatory, but this depends on the trigger. (required).</param>
        /// <param name="order">Order of the trigger.</param>
        /// <param name="active">If the trigger is active. Defaults to true..</param>
        /// <param name="stopProcessing">When true, other triggers will not be checked if this trigger was triggered. Defaults to false..</param>
        public RuleTriggerStore(TypeEnum type = default(TypeEnum), string value = default(string), int order = default(int), bool active = default(bool), bool stopProcessing = default(bool))
        {
            this.Type = type;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for RuleTriggerStore and cannot be null");
            }
            this.Value = value;
            this.Order = order;
            this.Active = active;
            this.StopProcessing = stopProcessing;
        }

        /// <summary>
        /// The accompanying value the trigger responds to. This value is often mandatory, but this depends on the trigger.
        /// </summary>
        /// <value>The accompanying value the trigger responds to. This value is often mandatory, but this depends on the trigger.</value>
        /// <example>tag1</example>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Order of the trigger
        /// </summary>
        /// <value>Order of the trigger</value>
        /// <example>5</example>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// If the trigger is active. Defaults to true.
        /// </summary>
        /// <value>If the trigger is active. Defaults to true.</value>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// When true, other triggers will not be checked if this trigger was triggered. Defaults to false.
        /// </summary>
        /// <value>When true, other triggers will not be checked if this trigger was triggered. Defaults to false.</value>
        /// <example>false</example>
        [DataMember(Name = "stop_processing", EmitDefaultValue = true)]
        public bool StopProcessing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleTriggerStore {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  StopProcessing: ").Append(StopProcessing).Append("\n");
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
            return this.Equals(input as RuleTriggerStore);
        }

        /// <summary>
        /// Returns true if RuleTriggerStore instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleTriggerStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleTriggerStore input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                    this.StopProcessing == input.StopProcessing ||
                    this.StopProcessing.Equals(input.StopProcessing)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.StopProcessing.GetHashCode();
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
