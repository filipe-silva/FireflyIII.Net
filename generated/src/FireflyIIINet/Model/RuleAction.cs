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
    /// RuleAction
    /// </summary>
    [DataContract(Name = "RuleAction")]
    public partial class RuleAction : IEquatable<RuleAction>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public RuleActionKeyword Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleAction" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="value">The accompanying value the action will set, change or update. Can be empty, but for some types this value is mandatory. (required).</param>
        /// <param name="order">Order of the action.</param>
        /// <param name="active">If the action is active. Defaults to true. (default to true).</param>
        /// <param name="stopProcessing">When true, other actions will not be fired after this action has fired. Defaults to false. (default to false).</param>
        public RuleAction(RuleActionKeyword type = default(RuleActionKeyword), string value = default(string), int order = default(int), bool active = true, bool stopProcessing = false)
        {
            Type = type;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for RuleAction and cannot be null");
            }
            Value = value;
            Order = order;
            Active = active;
            StopProcessing = stopProcessing;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
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
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
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
        [DataMember(Name = "order", EmitDefaultValue = true)]
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
            sb.Append("class RuleAction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return Equals(input as RuleAction);
        }

        /// <summary>
        /// Returns true if RuleAction instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleAction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Id == input.Id ||
					Id.Equals(input.Id)
                ) && 
                (
                    CreatedAt == input.CreatedAt ||
					CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    UpdatedAt == input.UpdatedAt ||
					UpdatedAt.Equals(input.UpdatedAt)
                ) && 
                (
                    Type == input.Type ||
                    Type.Equals(input.Type)
                ) && 
                (
                    Value == input.Value ||
                    (Value != null &&
                    Value.Equals(input.Value))
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
				hashCode = (hashCode * 59) + Id.GetHashCode();
				hashCode = (hashCode * 59) + CreatedAt.GetHashCode();
				hashCode = (hashCode * 59) + UpdatedAt.GetHashCode();
                hashCode = (hashCode * 59) + Type.GetHashCode();
                if (Value != null)
                {
                    hashCode = (hashCode * 59) + Value.GetHashCode();
                }
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
