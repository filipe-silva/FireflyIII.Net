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
    /// RuleTriggerStore
    /// </summary>
    [DataContract(Name = "RuleTriggerStore")]
    public partial class RuleTriggerStore : IEquatable<RuleTriggerStore>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public RuleTriggerKeyword Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleTriggerStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleTriggerStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleTriggerStore" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="value">The accompanying value the trigger responds to. This value is often mandatory, but this depends on the trigger. (required).</param>
        /// <param name="order">Order of the trigger.</param>
        /// <param name="active">If the trigger is active. Defaults to true. (default to true).</param>
        /// <param name="stopProcessing">When true, other triggers will not be checked if this trigger was triggered. Defaults to false. (default to false).</param>
        public RuleTriggerStore(RuleTriggerKeyword type = default(RuleTriggerKeyword), string value = default(string), int order = default(int), bool active = true, bool stopProcessing = false)
        {
            Type = type;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for RuleTriggerStore and cannot be null");
            }
            Value = value;
            Order = order;
            Active = active;
            StopProcessing = stopProcessing;
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
        [DataMember(Name = "order", EmitDefaultValue = true)]
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as RuleTriggerStore);
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
                    Type == input.Type ||
                    Type.Equals(input.Type)
                ) && 
                (
                    Value == input.Value ||
					Value.Equals(input.Value)
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
                    StopProcessing == input.StopProcessing ||
                    StopProcessing.Equals(input.StopProcessing)
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
                hashCode = (hashCode * 59) + Type.GetHashCode();
				hashCode = (hashCode * 59) + Value.GetHashCode();
                hashCode = (hashCode * 59) + Order.GetHashCode();
                hashCode = (hashCode * 59) + Active.GetHashCode();
                hashCode = (hashCode * 59) + StopProcessing.GetHashCode();
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
