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
    /// AvailableBudget
    /// </summary>
    [DataContract(Name = "AvailableBudget")]
    public partial class AvailableBudget : IEquatable<AvailableBudget>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableBudget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AvailableBudget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableBudget" /> class.
        /// </summary>
        /// <param name="currencyId">Use either currency_id or currency_code..</param>
        /// <param name="currencyCode">Use either currency_id or currency_code..</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="start">Start date of the available budget. (required).</param>
        /// <param name="end">End date of the available budget. (required).</param>
        public AvailableBudget(string currencyId = default(string), string currencyCode = default(string), string amount = default(string), DateTime start = default(DateTime), DateTime end = default(DateTime))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for AvailableBudget and cannot be null");
            }
            this.Amount = amount;
            this.Start = start;
            this.End = end;
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
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
        /// Use either currency_id or currency_code.
        /// </summary>
        /// <value>Use either currency_id or currency_code.</value>
        /// <example>5</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = false)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Use either currency_id or currency_code.
        /// </summary>
        /// <value>Use either currency_id or currency_code.</value>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "currency_symbol", EmitDefaultValue = false)]
        public string CurrencySymbol { get; private set; }

        /// <summary>
        /// Returns false as CurrencySymbol should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrencySymbol()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrencyDecimalPlaces
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "currency_decimal_places", EmitDefaultValue = false)]
        public int CurrencyDecimalPlaces { get; private set; }

        /// <summary>
        /// Returns false as CurrencyDecimalPlaces should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrencyDecimalPlaces()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Start date of the available budget.
        /// </summary>
        /// <value>Start date of the available budget.</value>
        /// <example>Sun Sep 17 01:00:00 WEST 2017</example>
        [DataMember(Name = "start", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Start { get; set; }

        /// <summary>
        /// End date of the available budget.
        /// </summary>
        /// <value>End date of the available budget.</value>
        /// <example>Sun Sep 17 01:00:00 WEST 2017</example>
        [DataMember(Name = "end", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime End { get; set; }

        /// <summary>
        /// Gets or Sets SpentInBudgets
        /// </summary>
        [DataMember(Name = "spent_in_budgets", EmitDefaultValue = false)]
        public List<BudgetSpent> SpentInBudgets { get; private set; }

        /// <summary>
        /// Returns false as SpentInBudgets should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSpentInBudgets()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SpentOutsideBudget
        /// </summary>
        [DataMember(Name = "spent_outside_budget", EmitDefaultValue = false)]
        public List<BudgetSpent> SpentOutsideBudget { get; private set; }

        /// <summary>
        /// Returns false as SpentOutsideBudget should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSpentOutsideBudget()
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
            sb.Append("class AvailableBudget {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  SpentInBudgets: ").Append(SpentInBudgets).Append("\n");
            sb.Append("  SpentOutsideBudget: ").Append(SpentOutsideBudget).Append("\n");
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
            return this.Equals(input as AvailableBudget);
        }

        /// <summary>
        /// Returns true if AvailableBudget instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailableBudget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableBudget input)
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
                    this.CurrencySymbol == input.CurrencySymbol ||
                    (this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(input.CurrencySymbol))
                ) && 
                (
                    this.CurrencyDecimalPlaces == input.CurrencyDecimalPlaces ||
                    this.CurrencyDecimalPlaces.Equals(input.CurrencyDecimalPlaces)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.SpentInBudgets == input.SpentInBudgets ||
                    this.SpentInBudgets != null &&
                    input.SpentInBudgets != null &&
                    this.SpentInBudgets.SequenceEqual(input.SpentInBudgets)
                ) && 
                (
                    this.SpentOutsideBudget == input.SpentOutsideBudget ||
                    this.SpentOutsideBudget != null &&
                    input.SpentOutsideBudget != null &&
                    this.SpentOutsideBudget.SequenceEqual(input.SpentOutsideBudget)
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
                if (this.CurrencyId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyId.GetHashCode();
                }
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.CurrencySymbol != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencySymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CurrencyDecimalPlaces.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Start != null)
                {
                    hashCode = (hashCode * 59) + this.Start.GetHashCode();
                }
                if (this.End != null)
                {
                    hashCode = (hashCode * 59) + this.End.GetHashCode();
                }
                if (this.SpentInBudgets != null)
                {
                    hashCode = (hashCode * 59) + this.SpentInBudgets.GetHashCode();
                }
                if (this.SpentOutsideBudget != null)
                {
                    hashCode = (hashCode * 59) + this.SpentOutsideBudget.GetHashCode();
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
