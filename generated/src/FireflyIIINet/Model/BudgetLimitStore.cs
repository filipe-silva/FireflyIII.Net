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
    /// BudgetLimitStore
    /// </summary>
    [DataContract(Name = "BudgetLimitStore")]
    public partial class BudgetLimitStore : IEquatable<BudgetLimitStore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetLimitStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BudgetLimitStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetLimitStore" /> class.
        /// </summary>
        /// <param name="currencyId">Use either currency_id or currency_code. Defaults to the user&#39;s default currency..</param>
        /// <param name="currencyCode">Use either currency_id or currency_code. Defaults to the user&#39;s default currency..</param>
        /// <param name="start">Start date of the budget limit. (required).</param>
        /// <param name="end">End date of the budget limit. (required).</param>
        /// <param name="amount">amount (required).</param>
        public BudgetLimitStore(string currencyId = default(string), string currencyCode = default(string), DateTime start = default(DateTime), DateTime end = default(DateTime), string amount = default(string))
        {
            this.Start = start;
            this.End = end;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for BudgetLimitStore and cannot be null");
            }
            this.Amount = amount;
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
        }

        /// <summary>
        /// Use either currency_id or currency_code. Defaults to the user&#39;s default currency.
        /// </summary>
        /// <value>Use either currency_id or currency_code. Defaults to the user&#39;s default currency.</value>
        /// <example>5</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = false)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Use either currency_id or currency_code. Defaults to the user&#39;s default currency.
        /// </summary>
        /// <value>Use either currency_id or currency_code. Defaults to the user&#39;s default currency.</value>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The budget ID of the associated budget.
        /// </summary>
        /// <value>The budget ID of the associated budget.</value>
        /// <example>23</example>
        [DataMember(Name = "budget_id", IsRequired = true, EmitDefaultValue = true)]
        public string BudgetId { get; private set; }

        /// <summary>
        /// Returns false as BudgetId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBudgetId()
        {
            return false;
        }
        /// <summary>
        /// Start date of the budget limit.
        /// </summary>
        /// <value>Start date of the budget limit.</value>
        /// <example>Sun Sep 17 01:00:00 WEST 2017</example>
        [DataMember(Name = "start", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Start { get; set; }

        /// <summary>
        /// Period of the budget limit. Only used when auto-generated by auto-budget.
        /// </summary>
        /// <value>Period of the budget limit. Only used when auto-generated by auto-budget.</value>
        /// <example>monthly</example>
        [DataMember(Name = "period", EmitDefaultValue = true)]
        public string Period { get; private set; }

        /// <summary>
        /// Returns false as Period should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePeriod()
        {
            return false;
        }
        /// <summary>
        /// End date of the budget limit.
        /// </summary>
        /// <value>End date of the budget limit.</value>
        /// <example>Sun Sep 17 01:00:00 WEST 2017</example>
        [DataMember(Name = "end", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime End { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BudgetLimitStore {\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  BudgetId: ").Append(BudgetId).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as BudgetLimitStore);
        }

        /// <summary>
        /// Returns true if BudgetLimitStore instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetLimitStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetLimitStore input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.BudgetId == input.BudgetId ||
                    (this.BudgetId != null &&
                    this.BudgetId.Equals(input.BudgetId))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.CurrencyId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyId.GetHashCode();
                }
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.BudgetId != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetId.GetHashCode();
                }
                if (this.Start != null)
                {
                    hashCode = (hashCode * 59) + this.Start.GetHashCode();
                }
                if (this.Period != null)
                {
                    hashCode = (hashCode * 59) + this.Period.GetHashCode();
                }
                if (this.End != null)
                {
                    hashCode = (hashCode * 59) + this.End.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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