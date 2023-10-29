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
    /// RuleActionUpdate
    /// </summary>
    [DataContract(Name = "RuleActionUpdate")]
    public partial class RuleActionUpdate : IEquatable<RuleActionUpdate>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public RuleActionKeyword? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleActionUpdate" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="value">The accompanying value the action will set, change or update. Can be empty, but for some types this value is mandatory..</param>
        /// <param name="order">Order of the action.</param>
        /// <param name="active">If the action is active..</param>
        /// <param name="stopProcessing">When true, other actions will not be fired after this action has fired..</param>
        public RuleActionUpdate(RuleActionKeyword? type = default(RuleActionKeyword?), string value = default(string), int order = default(int), bool active = default(bool), bool stopProcessing = default(bool))
        {
            this.Type = type;
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
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Order of the action
        /// </summary>
        /// <value>Order of the action</value>
        /// <example>5</example>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// If the action is active.
        /// </summary>
        /// <value>If the action is active.</value>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// When true, other actions will not be fired after this action has fired.
        /// </summary>
        /// <value>When true, other actions will not be fired after this action has fired.</value>
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
            sb.Append("class RuleActionUpdate {\n");
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
            return this.Equals(input as RuleActionUpdate);
        }

        /// <summary>
        /// Returns true if RuleActionUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleActionUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleActionUpdate input)
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
