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
    /// AvailableBudgetStore
    /// </summary>
    [DataContract(Name = "AvailableBudgetStore")]
    public partial class AvailableBudgetStore : IEquatable<AvailableBudgetStore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableBudgetStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AvailableBudgetStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableBudgetStore" /> class.
        /// </summary>
        /// <param name="currencyId">Use either currency_id or currency_code..</param>
        /// <param name="currencyCode">Use either currency_id or currency_code..</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="start">Start date of the available budget. (required).</param>
        /// <param name="end">End date of the available budget. (required).</param>
        public AvailableBudgetStore(string currencyId = default(string), string currencyCode = default(string), string amount = default(string), DateTime start = default(DateTime), DateTime end = default(DateTime))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for AvailableBudgetStore and cannot be null");
            }
            Amount = amount;
            Start = start;
            End = end;
            CurrencyId = currencyId;
            CurrencyCode = currencyCode;
        }

        /// <summary>
        /// Use either currency_id or currency_code.
        /// </summary>
        /// <value>Use either currency_id or currency_code.</value>
        /// <example>5</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Use either currency_id or currency_code.
        /// </summary>
        /// <value>Use either currency_id or currency_code.</value>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AvailableBudgetStore {\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
            return Equals(input as AvailableBudgetStore);
        }

        /// <summary>
        /// Returns true if AvailableBudgetStore instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailableBudgetStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableBudgetStore input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    CurrencyId == input.CurrencyId ||
					CurrencyId.Equals(input.CurrencyId)
                ) && 
                (
                    CurrencyCode == input.CurrencyCode ||
					CurrencyCode.Equals(input.CurrencyCode)
                ) && 
                (
                    Amount == input.Amount ||
					Amount.Equals(input.Amount)
                ) && 
                (
                    Start == input.Start ||
					Start.Equals(input.Start)
                ) && 
                (
                    End == input.End ||
					End.Equals(input.End)
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
				hashCode = (hashCode * 59) + CurrencyId.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyCode.GetHashCode();
				hashCode = (hashCode * 59) + Amount.GetHashCode();
				hashCode = (hashCode * 59) + Start.GetHashCode();
				hashCode = (hashCode * 59) + End.GetHashCode();
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
