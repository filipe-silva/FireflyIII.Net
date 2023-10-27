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
    /// RuleActionStore
    /// </summary>
    [DataContract(Name = "RuleActionStore")]
    public partial class RuleActionStore : IEquatable<RuleActionStore>, IValidatableObject
    {
        /// <summary>
        /// The type of thing this action will do. A limited set is possible.
        /// </summary>
        /// <value>The type of thing this action will do. A limited set is possible.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum UserAction for value: user_action
            /// </summary>
            [EnumMember(Value = "user_action")]
            UserAction = 1,

            /// <summary>
            /// Enum SetCategory for value: set_category
            /// </summary>
            [EnumMember(Value = "set_category")]
            SetCategory = 2,

            /// <summary>
            /// Enum ClearCategory for value: clear_category
            /// </summary>
            [EnumMember(Value = "clear_category")]
            ClearCategory = 3,

            /// <summary>
            /// Enum SetBudget for value: set_budget
            /// </summary>
            [EnumMember(Value = "set_budget")]
            SetBudget = 4,

            /// <summary>
            /// Enum ClearBudget for value: clear_budget
            /// </summary>
            [EnumMember(Value = "clear_budget")]
            ClearBudget = 5,

            /// <summary>
            /// Enum AddTag for value: add_tag
            /// </summary>
            [EnumMember(Value = "add_tag")]
            AddTag = 6,

            /// <summary>
            /// Enum RemoveTag for value: remove_tag
            /// </summary>
            [EnumMember(Value = "remove_tag")]
            RemoveTag = 7,

            /// <summary>
            /// Enum RemoveAllTags for value: remove_all_tags
            /// </summary>
            [EnumMember(Value = "remove_all_tags")]
            RemoveAllTags = 8,

            /// <summary>
            /// Enum SetDescription for value: set_description
            /// </summary>
            [EnumMember(Value = "set_description")]
            SetDescription = 9,

            /// <summary>
            /// Enum AppendDescription for value: append_description
            /// </summary>
            [EnumMember(Value = "append_description")]
            AppendDescription = 10,

            /// <summary>
            /// Enum PrependDescription for value: prepend_description
            /// </summary>
            [EnumMember(Value = "prepend_description")]
            PrependDescription = 11,

            /// <summary>
            /// Enum SetSourceAccount for value: set_source_account
            /// </summary>
            [EnumMember(Value = "set_source_account")]
            SetSourceAccount = 12,

            /// <summary>
            /// Enum SetDestinationAccount for value: set_destination_account
            /// </summary>
            [EnumMember(Value = "set_destination_account")]
            SetDestinationAccount = 13,

            /// <summary>
            /// Enum SetNotes for value: set_notes
            /// </summary>
            [EnumMember(Value = "set_notes")]
            SetNotes = 14,

            /// <summary>
            /// Enum AppendNotes for value: append_notes
            /// </summary>
            [EnumMember(Value = "append_notes")]
            AppendNotes = 15,

            /// <summary>
            /// Enum PrependNotes for value: prepend_notes
            /// </summary>
            [EnumMember(Value = "prepend_notes")]
            PrependNotes = 16,

            /// <summary>
            /// Enum ClearNotes for value: clear_notes
            /// </summary>
            [EnumMember(Value = "clear_notes")]
            ClearNotes = 17,

            /// <summary>
            /// Enum LinkToBill for value: link_to_bill
            /// </summary>
            [EnumMember(Value = "link_to_bill")]
            LinkToBill = 18,

            /// <summary>
            /// Enum ConvertWithdrawal for value: convert_withdrawal
            /// </summary>
            [EnumMember(Value = "convert_withdrawal")]
            ConvertWithdrawal = 19,

            /// <summary>
            /// Enum ConvertDeposit for value: convert_deposit
            /// </summary>
            [EnumMember(Value = "convert_deposit")]
            ConvertDeposit = 20,

            /// <summary>
            /// Enum ConvertTransfer for value: convert_transfer
            /// </summary>
            [EnumMember(Value = "convert_transfer")]
            ConvertTransfer = 21
        }


        /// <summary>
        /// The type of thing this action will do. A limited set is possible.
        /// </summary>
        /// <value>The type of thing this action will do. A limited set is possible.</value>
        /// <example>set_category</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleActionStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleActionStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleActionStore" /> class.
        /// </summary>
        /// <param name="type">The type of thing this action will do. A limited set is possible. (required).</param>
        /// <param name="value">The accompanying value the action will set, change or update. Can be empty, but for some types this value is mandatory. (required).</param>
        /// <param name="order">Order of the action.</param>
        /// <param name="active">If the action is active. Defaults to true..</param>
        /// <param name="stopProcessing">When true, other actions will not be fired after this action has fired. Defaults to false..</param>
        public RuleActionStore(TypeEnum type = default(TypeEnum), string value = default(string), int order = default(int), bool active = default(bool), bool stopProcessing = default(bool))
        {
            this.Type = type;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for RuleActionStore and cannot be null");
            }
            this.Value = value;
            this.Order = order;
            this.Active = active;
            this.StopProcessing = stopProcessing;
        }

        /// <summary>
        /// The accompanying value the action will set, change or update. Can be empty, but for some types this value is mandatory.
        /// </summary>
        /// <value>The accompanying value the action will set, change or update. Can be empty, but for some types this value is mandatory.</value>
        /// <example>Daily groceries</example>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Order of the action
        /// </summary>
        /// <value>Order of the action</value>
        /// <example>5</example>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// If the action is active. Defaults to true.
        /// </summary>
        /// <value>If the action is active. Defaults to true.</value>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// When true, other actions will not be fired after this action has fired. Defaults to false.
        /// </summary>
        /// <value>When true, other actions will not be fired after this action has fired. Defaults to false.</value>
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
            sb.Append("class RuleActionStore {\n");
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
            return this.Equals(input as RuleActionStore);
        }

        /// <summary>
        /// Returns true if RuleActionStore instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleActionStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleActionStore input)
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
