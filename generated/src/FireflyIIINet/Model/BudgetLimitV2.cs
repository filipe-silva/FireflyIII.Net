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
    /// BudgetLimitV2
    /// </summary>
    [DataContract(Name = "BudgetLimitV2")]
    public partial class BudgetLimitV2 : IEquatable<BudgetLimitV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetLimitV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BudgetLimitV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetLimitV2" /> class.
        /// </summary>
        /// <param name="start">Start date of the budget limit. (required).</param>
        /// <param name="end">End date of the budget limit. (required).</param>
        /// <param name="currencyId">Use either currency_id or currency_code. Defaults to the user&#39;s default currency..</param>
        /// <param name="currencyCode">Use either currency_id or currency_code. Defaults to the user&#39;s default currency..</param>
        /// <param name="amount">amount (required).</param>
        public BudgetLimitV2(DateTime start = default(DateTime), DateTime end = default(DateTime), string currencyId = default(string), string currencyCode = default(string), string amount = default(string))
        {
            Start = start;
            End = end;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for BudgetLimitV2 and cannot be null");
            }
            Amount = amount;
            CurrencyId = currencyId;
            CurrencyCode = currencyCode;
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
        /// Start date of the budget limit.
        /// </summary>
        /// <value>Start date of the budget limit.</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "start", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Start { get; set; }

        /// <summary>
        /// End date of the budget limit.
        /// </summary>
        /// <value>End date of the budget limit.</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "end", IsRequired = true, EmitDefaultValue = true)]
        public DateTime End { get; set; }

        /// <summary>
        /// Use either currency_id or currency_code. Defaults to the user&#39;s default currency.
        /// </summary>
        /// <value>Use either currency_id or currency_code. Defaults to the user&#39;s default currency.</value>
        /// <example>5</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Use either currency_id or currency_code. Defaults to the user&#39;s default currency.
        /// </summary>
        /// <value>Use either currency_id or currency_code. Defaults to the user&#39;s default currency.</value>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyName
        /// </summary>
        /// <example>Euro</example>
        [DataMember(Name = "currency_name", EmitDefaultValue = true)]
        public string CurrencyName { get; private set; }

        /// <summary>
        /// Returns false as CurrencyName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrencyName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "currency_symbol", EmitDefaultValue = true)]
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
        [DataMember(Name = "currency_decimal_places", EmitDefaultValue = true)]
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
        /// Period of the budget limit. Only used when auto-generated by auto-budget.
        /// </summary>
        /// <value>Period of the budget limit. Only used when auto-generated by auto-budget.</value>
        /// <example>monthly</example>
        [DataMember(Name = "period", EmitDefaultValue = false)]
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
            sb.Append("class BudgetLimitV2 {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencyName: ").Append(CurrencyName).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  BudgetId: ").Append(BudgetId).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as BudgetLimitV2);
        }

        /// <summary>
        /// Returns true if BudgetLimitV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetLimitV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetLimitV2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    CreatedAt == input.CreatedAt ||
					CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    UpdatedAt == input.UpdatedAt ||
					UpdatedAt.Equals(input.UpdatedAt)
                ) && 
                (
                    Start == input.Start ||
					Start.Equals(input.Start)
                ) && 
                (
                    End == input.End ||
					End.Equals(input.End)
                ) && 
                (
                    CurrencyId == input.CurrencyId ||
					CurrencyId.Equals(input.CurrencyId)
                ) && 
                (
                    CurrencyCode == input.CurrencyCode ||
					CurrencyCode.Equals(input.CurrencyCode)
                ) && 
                (
                    CurrencyName == input.CurrencyName ||
					CurrencyName.Equals(input.CurrencyName)
                ) && 
                (
                    CurrencySymbol == input.CurrencySymbol ||
					CurrencySymbol.Equals(input.CurrencySymbol)
                ) && 
                (
                    CurrencyDecimalPlaces == input.CurrencyDecimalPlaces ||
                    CurrencyDecimalPlaces.Equals(input.CurrencyDecimalPlaces)
                ) && 
                (
                    BudgetId == input.BudgetId ||
					BudgetId.Equals(input.BudgetId)
                ) && 
                (
                    Period == input.Period ||
                    (Period != null &&
                    Period.Equals(input.Period))
                ) && 
                (
                    Amount == input.Amount ||
					Amount.Equals(input.Amount)
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
				hashCode = (hashCode * 59) + CreatedAt.GetHashCode();
				hashCode = (hashCode * 59) + UpdatedAt.GetHashCode();
				hashCode = (hashCode * 59) + Start.GetHashCode();
				hashCode = (hashCode * 59) + End.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyId.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyCode.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyName.GetHashCode();
				hashCode = (hashCode * 59) + CurrencySymbol.GetHashCode();
                hashCode = (hashCode * 59) + CurrencyDecimalPlaces.GetHashCode();
				hashCode = (hashCode * 59) + BudgetId.GetHashCode();
                if (Period != null)
                {
                    hashCode = (hashCode * 59) + Period.GetHashCode();
                }
				hashCode = (hashCode * 59) + Amount.GetHashCode();
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
