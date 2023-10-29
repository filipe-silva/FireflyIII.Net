/*
 * Firefly III API v2.0.0
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-03-05T14:16:31+00:00 
 *
 * The version of the OpenAPI document: 2.0.0
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
    /// RuleStore
    /// </summary>
    [DataContract(Name = "RuleStore")]
    public partial class RuleStore : IEquatable<RuleStore>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Trigger
        /// </summary>
        [DataMember(Name = "trigger", IsRequired = true, EmitDefaultValue = true)]
        public RuleTriggerType Trigger { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleStore" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="description">description.</param>
        /// <param name="ruleGroupId">ID of the rule group under which the rule must be stored. Either this field or rule_group_title is mandatory. (required).</param>
        /// <param name="ruleGroupTitle">Title of the rule group under which the rule must be stored. Either this field or rule_group_id is mandatory..</param>
        /// <param name="order">order.</param>
        /// <param name="trigger">trigger (required).</param>
        /// <param name="active">Whether or not the rule is even active. Default is true. (default to true).</param>
        /// <param name="strict">If the rule is set to be strict, ALL triggers must hit in order for the rule to fire. Otherwise, just one is enough. Default value is true. (default to true).</param>
        /// <param name="stopProcessing">If this value is true and the rule is triggered, other rules  after this one in the group will be skipped. Default value is false..</param>
        /// <param name="triggers">triggers (required).</param>
        /// <param name="actions">actions (required).</param>
        public RuleStore(string title = default(string), string description = default(string), string ruleGroupId = default(string), string ruleGroupTitle = default(string), int order = default(int), RuleTriggerType trigger = default(RuleTriggerType), bool active = true, bool strict = true, bool stopProcessing = default(bool), List<RuleTriggerStore> triggers = default(List<RuleTriggerStore>), List<RuleActionStore> actions = default(List<RuleActionStore>))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for RuleStore and cannot be null");
            }
            this.Title = title;
            // to ensure "ruleGroupId" is required (not null)
            if (ruleGroupId == null)
            {
                throw new ArgumentNullException("ruleGroupId is a required property for RuleStore and cannot be null");
            }
            this.RuleGroupId = ruleGroupId;
            this.Trigger = trigger;
            // to ensure "triggers" is required (not null)
            if (triggers == null)
            {
                throw new ArgumentNullException("triggers is a required property for RuleStore and cannot be null");
            }
            this.Triggers = triggers;
            // to ensure "actions" is required (not null)
            if (actions == null)
            {
                throw new ArgumentNullException("actions is a required property for RuleStore and cannot be null");
            }
            this.Actions = actions;
            this.Description = description;
            this.RuleGroupTitle = ruleGroupTitle;
            this.Order = order;
            this.Active = active;
            this.Strict = strict;
            this.StopProcessing = stopProcessing;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        /// <example>First rule title.</example>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /// <example>First rule description</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// ID of the rule group under which the rule must be stored. Either this field or rule_group_title is mandatory.
        /// </summary>
        /// <value>ID of the rule group under which the rule must be stored. Either this field or rule_group_title is mandatory.</value>
        /// <example>81</example>
        [DataMember(Name = "rule_group_id", IsRequired = true, EmitDefaultValue = true)]
        public string RuleGroupId { get; set; }

        /// <summary>
        /// Title of the rule group under which the rule must be stored. Either this field or rule_group_id is mandatory.
        /// </summary>
        /// <value>Title of the rule group under which the rule must be stored. Either this field or rule_group_id is mandatory.</value>
        /// <example>New rule group</example>
        [DataMember(Name = "rule_group_title", EmitDefaultValue = false)]
        public string RuleGroupTitle { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Whether or not the rule is even active. Default is true.
        /// </summary>
        /// <value>Whether or not the rule is even active. Default is true.</value>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// If the rule is set to be strict, ALL triggers must hit in order for the rule to fire. Otherwise, just one is enough. Default value is true.
        /// </summary>
        /// <value>If the rule is set to be strict, ALL triggers must hit in order for the rule to fire. Otherwise, just one is enough. Default value is true.</value>
        /// <example>true</example>
        [DataMember(Name = "strict", EmitDefaultValue = true)]
        public bool Strict { get; set; }

        /// <summary>
        /// If this value is true and the rule is triggered, other rules  after this one in the group will be skipped. Default value is false.
        /// </summary>
        /// <value>If this value is true and the rule is triggered, other rules  after this one in the group will be skipped. Default value is false.</value>
        /// <example>false</example>
        [DataMember(Name = "stop_processing", EmitDefaultValue = true)]
        public bool StopProcessing { get; set; }

        /// <summary>
        /// Gets or Sets Triggers
        /// </summary>
        [DataMember(Name = "triggers", IsRequired = true, EmitDefaultValue = true)]
        public List<RuleTriggerStore> Triggers { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name = "actions", IsRequired = true, EmitDefaultValue = true)]
        public List<RuleActionStore> Actions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleStore {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RuleGroupId: ").Append(RuleGroupId).Append("\n");
            sb.Append("  RuleGroupTitle: ").Append(RuleGroupTitle).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Strict: ").Append(Strict).Append("\n");
            sb.Append("  StopProcessing: ").Append(StopProcessing).Append("\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(input as RuleStore);
        }

        /// <summary>
        /// Returns true if RuleStore instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleStore input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.RuleGroupId == input.RuleGroupId ||
                    (this.RuleGroupId != null &&
                    this.RuleGroupId.Equals(input.RuleGroupId))
                ) && 
                (
                    this.RuleGroupTitle == input.RuleGroupTitle ||
                    (this.RuleGroupTitle != null &&
                    this.RuleGroupTitle.Equals(input.RuleGroupTitle))
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    this.Trigger.Equals(input.Trigger)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Strict == input.Strict ||
                    this.Strict.Equals(input.Strict)
                ) && 
                (
                    this.StopProcessing == input.StopProcessing ||
                    this.StopProcessing.Equals(input.StopProcessing)
                ) && 
                (
                    this.Triggers == input.Triggers ||
                    this.Triggers != null &&
                    input.Triggers != null &&
                    this.Triggers.SequenceEqual(input.Triggers)
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.RuleGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.RuleGroupId.GetHashCode();
                }
                if (this.RuleGroupTitle != null)
                {
                    hashCode = (hashCode * 59) + this.RuleGroupTitle.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
                hashCode = (hashCode * 59) + this.Trigger.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.Strict.GetHashCode();
                hashCode = (hashCode * 59) + this.StopProcessing.GetHashCode();
                if (this.Triggers != null)
                {
                    hashCode = (hashCode * 59) + this.Triggers.GetHashCode();
                }
                if (this.Actions != null)
                {
                    hashCode = (hashCode * 59) + this.Actions.GetHashCode();
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
