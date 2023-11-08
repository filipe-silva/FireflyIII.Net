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
    /// RecurrenceTransactionStore
    /// </summary>
    [DataContract(Name = "RecurrenceTransactionStore")]
    public partial class RecurrenceTransactionStore : IEquatable<RecurrenceTransactionStore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceTransactionStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecurrenceTransactionStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceTransactionStore" /> class.
        /// </summary>
        /// <param name="description">description (required).</param>
        /// <param name="amount">Amount of the transaction. (required).</param>
        /// <param name="foreignAmount">Foreign amount of the transaction..</param>
        /// <param name="currencyId">Submit either a currency_id or a currency_code..</param>
        /// <param name="currencyCode">Submit either a currency_id or a currency_code..</param>
        /// <param name="foreignCurrencyId">Submit either a foreign_currency_id or a foreign_currency_code, or neither..</param>
        /// <param name="foreignCurrencyCode">Submit either a foreign_currency_id or a foreign_currency_code, or neither..</param>
        /// <param name="budgetId">The budget ID for this transaction..</param>
        /// <param name="categoryId">Category ID for this transaction..</param>
        /// <param name="sourceId">ID of the source account. (required).</param>
        /// <param name="destinationId">ID of the destination account. (required).</param>
        /// <param name="tags">Array of tags..</param>
        /// <param name="piggyBankId">Optional..</param>
        public RecurrenceTransactionStore(string description = default(string), string amount = default(string), string foreignAmount = default(string), string currencyId = default(string), string currencyCode = default(string), string foreignCurrencyId = default(string), string foreignCurrencyCode = default(string), string budgetId = default(string), string categoryId = default(string), string sourceId = default(string), string destinationId = default(string), List<string> tags = default(List<string>), string piggyBankId = default(string))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for RecurrenceTransactionStore and cannot be null");
            }
            Description = description;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for RecurrenceTransactionStore and cannot be null");
            }
            Amount = amount;
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for RecurrenceTransactionStore and cannot be null");
            }
            SourceId = sourceId;
            // to ensure "destinationId" is required (not null)
            if (destinationId == null)
            {
                throw new ArgumentNullException("destinationId is a required property for RecurrenceTransactionStore and cannot be null");
            }
            DestinationId = destinationId;
            ForeignAmount = foreignAmount;
            CurrencyId = currencyId;
            CurrencyCode = currencyCode;
            ForeignCurrencyId = foreignCurrencyId;
            ForeignCurrencyCode = foreignCurrencyCode;
            BudgetId = budgetId;
            CategoryId = categoryId;
            Tags = tags;
            PiggyBankId = piggyBankId;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /// <example>Rent for the current month</example>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        /// <value>Amount of the transaction.</value>
        /// <example>123.45</example>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Foreign amount of the transaction.
        /// </summary>
        /// <value>Foreign amount of the transaction.</value>
        /// <example>123.45</example>
        [DataMember(Name = "foreign_amount", EmitDefaultValue = false)]
        public string ForeignAmount { get; set; }

        /// <summary>
        /// Submit either a currency_id or a currency_code.
        /// </summary>
        /// <value>Submit either a currency_id or a currency_code.</value>
        /// <example>3</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Submit either a currency_id or a currency_code.
        /// </summary>
        /// <value>Submit either a currency_id or a currency_code.</value>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Submit either a foreign_currency_id or a foreign_currency_code, or neither.
        /// </summary>
        /// <value>Submit either a foreign_currency_id or a foreign_currency_code, or neither.</value>
        /// <example>17</example>
        [DataMember(Name = "foreign_currency_id", EmitDefaultValue = false)]
        public string ForeignCurrencyId { get; set; }

        /// <summary>
        /// Submit either a foreign_currency_id or a foreign_currency_code, or neither.
        /// </summary>
        /// <value>Submit either a foreign_currency_id or a foreign_currency_code, or neither.</value>
        /// <example>GBP</example>
        [DataMember(Name = "foreign_currency_code", EmitDefaultValue = false)]
        public string ForeignCurrencyCode { get; set; }

        /// <summary>
        /// The budget ID for this transaction.
        /// </summary>
        /// <value>The budget ID for this transaction.</value>
        /// <example>4</example>
        [DataMember(Name = "budget_id", EmitDefaultValue = true)]
        public string BudgetId { get; set; }

        /// <summary>
        /// Category ID for this transaction.
        /// </summary>
        /// <value>Category ID for this transaction.</value>
        /// <example>211</example>
        [DataMember(Name = "category_id", EmitDefaultValue = true)]
        public string CategoryId { get; set; }

        /// <summary>
        /// ID of the source account.
        /// </summary>
        /// <value>ID of the source account.</value>
        /// <example>913</example>
        [DataMember(Name = "source_id", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// ID of the destination account.
        /// </summary>
        /// <value>ID of the destination account.</value>
        /// <example>258</example>
        [DataMember(Name = "destination_id", IsRequired = true, EmitDefaultValue = true)]
        public string DestinationId { get; set; }

        /// <summary>
        /// Array of tags.
        /// </summary>
        /// <value>Array of tags.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Optional.
        /// </summary>
        /// <value>Optional.</value>
        /// <example>123</example>
        [DataMember(Name = "piggy_bank_id", EmitDefaultValue = false)]
        public string PiggyBankId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecurrenceTransactionStore {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ForeignAmount: ").Append(ForeignAmount).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ForeignCurrencyId: ").Append(ForeignCurrencyId).Append("\n");
            sb.Append("  ForeignCurrencyCode: ").Append(ForeignCurrencyCode).Append("\n");
            sb.Append("  BudgetId: ").Append(BudgetId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  DestinationId: ").Append(DestinationId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  PiggyBankId: ").Append(PiggyBankId).Append("\n");
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
            return Equals(input as RecurrenceTransactionStore);
        }

        /// <summary>
        /// Returns true if RecurrenceTransactionStore instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurrenceTransactionStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurrenceTransactionStore input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Description == input.Description ||
					Description.Equals(input.Description)
                ) && 
                (
                    Amount == input.Amount ||
					Amount.Equals(input.Amount)
                ) && 
                (
                    ForeignAmount == input.ForeignAmount ||
                    (ForeignAmount != null &&
                    ForeignAmount.Equals(input.ForeignAmount))
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
                    ForeignCurrencyId == input.ForeignCurrencyId ||
                    (ForeignCurrencyId != null &&
                    ForeignCurrencyId.Equals(input.ForeignCurrencyId))
                ) && 
                (
                    ForeignCurrencyCode == input.ForeignCurrencyCode ||
                    (ForeignCurrencyCode != null &&
                    ForeignCurrencyCode.Equals(input.ForeignCurrencyCode))
                ) && 
                (
                    BudgetId == input.BudgetId ||
					BudgetId.Equals(input.BudgetId)
                ) && 
                (
                    CategoryId == input.CategoryId ||
					CategoryId.Equals(input.CategoryId)
                ) && 
                (
                    SourceId == input.SourceId ||
					SourceId.Equals(input.SourceId)
                ) && 
                (
                    DestinationId == input.DestinationId ||
					DestinationId.Equals(input.DestinationId)
                ) && 
                (
                    Tags == input.Tags ||
                    Tags != null &&
                    input.Tags != null &&
                    Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    PiggyBankId == input.PiggyBankId ||
                    (PiggyBankId != null &&
                    PiggyBankId.Equals(input.PiggyBankId))
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
				hashCode = (hashCode * 59) + Description.GetHashCode();
				hashCode = (hashCode * 59) + Amount.GetHashCode();
                if (ForeignAmount != null)
                {
                    hashCode = (hashCode * 59) + ForeignAmount.GetHashCode();
                }
				hashCode = (hashCode * 59) + CurrencyId.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyCode.GetHashCode();
                if (ForeignCurrencyId != null)
                {
                    hashCode = (hashCode * 59) + ForeignCurrencyId.GetHashCode();
                }
                if (ForeignCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + ForeignCurrencyCode.GetHashCode();
                }
				hashCode = (hashCode * 59) + BudgetId.GetHashCode();
				hashCode = (hashCode * 59) + CategoryId.GetHashCode();
				hashCode = (hashCode * 59) + SourceId.GetHashCode();
				hashCode = (hashCode * 59) + DestinationId.GetHashCode();
                if (Tags != null)
                {
                    hashCode = (hashCode * 59) + Tags.GetHashCode();
                }
                if (PiggyBankId != null)
                {
                    hashCode = (hashCode * 59) + PiggyBankId.GetHashCode();
                }
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
