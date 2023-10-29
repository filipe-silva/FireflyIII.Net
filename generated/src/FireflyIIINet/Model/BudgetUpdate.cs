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
    /// BudgetUpdate
    /// </summary>
    [DataContract(Name = "BudgetUpdate")]
    public partial class BudgetUpdate : IEquatable<BudgetUpdate>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AutoBudgetType
        /// </summary>
        [DataMember(Name = "auto_budget_type", EmitDefaultValue = true)]
        public AutoBudgetType? AutoBudgetType { get; set; }

        /// <summary>
        /// Gets or Sets AutoBudgetPeriod
        /// </summary>
        [DataMember(Name = "auto_budget_period", EmitDefaultValue = true)]
        public AutoBudgetPeriod? AutoBudgetPeriod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetUpdate" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="active">active.</param>
        /// <param name="order">order.</param>
        /// <param name="notes">notes.</param>
        /// <param name="autoBudgetType">autoBudgetType.</param>
        /// <param name="autoBudgetCurrencyId">Use either currency_id or currency_code. Defaults to the user&#39;s default currency..</param>
        /// <param name="autoBudgetCurrencyCode">Use either currency_id or currency_code. Defaults to the user&#39;s default currency..</param>
        /// <param name="autoBudgetAmount">autoBudgetAmount.</param>
        /// <param name="autoBudgetPeriod">autoBudgetPeriod.</param>
        public BudgetUpdate(string name = default(string), bool active = default(bool), int order = default(int), string notes = default(string), AutoBudgetType? autoBudgetType = default(AutoBudgetType?), string autoBudgetCurrencyId = default(string), string autoBudgetCurrencyCode = default(string), string autoBudgetAmount = default(string), AutoBudgetPeriod? autoBudgetPeriod = default(AutoBudgetPeriod?))
        {
            this.Name = name;
            this.Active = active;
            this.Order = order;
            this.Notes = notes;
            this.AutoBudgetType = autoBudgetType;
            this.AutoBudgetCurrencyId = autoBudgetCurrencyId;
            this.AutoBudgetCurrencyCode = autoBudgetCurrencyCode;
            this.AutoBudgetAmount = autoBudgetAmount;
            this.AutoBudgetPeriod = autoBudgetPeriod;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>Bills</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
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
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        /// <example>Some notes</example>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BudgetUpdate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  AutoBudgetType: ").Append(AutoBudgetType).Append("\n");
            sb.Append("  AutoBudgetCurrencyId: ").Append(AutoBudgetCurrencyId).Append("\n");
            sb.Append("  AutoBudgetCurrencyCode: ").Append(AutoBudgetCurrencyCode).Append("\n");
            sb.Append("  AutoBudgetAmount: ").Append(AutoBudgetAmount).Append("\n");
            sb.Append("  AutoBudgetPeriod: ").Append(AutoBudgetPeriod).Append("\n");
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
            return this.Equals(input as BudgetUpdate);
        }

        /// <summary>
        /// Returns true if BudgetUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetUpdate input)
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
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
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
