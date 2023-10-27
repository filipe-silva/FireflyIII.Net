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
            this.Description = description;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for RecurrenceTransactionStore and cannot be null");
            }
            this.Amount = amount;
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for RecurrenceTransactionStore and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "destinationId" is required (not null)
            if (destinationId == null)
            {
                throw new ArgumentNullException("destinationId is a required property for RecurrenceTransactionStore and cannot be null");
            }
            this.DestinationId = destinationId;
            this.ForeignAmount = foreignAmount;
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
            this.ForeignCurrencyId = foreignCurrencyId;
            this.ForeignCurrencyCode = foreignCurrencyCode;
            this.BudgetId = budgetId;
            this.CategoryId = categoryId;
            this.Tags = tags;
            this.PiggyBankId = piggyBankId;
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
        [DataMember(Name = "foreign_amount", EmitDefaultValue = true)]
        public string ForeignAmount { get; set; }

        /// <summary>
        /// Submit either a currency_id or a currency_code.
        /// </summary>
        /// <value>Submit either a currency_id or a currency_code.</value>
        /// <example>3</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = false)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Submit either a currency_id or a currency_code.
        /// </summary>
        /// <value>Submit either a currency_id or a currency_code.</value>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Submit either a foreign_currency_id or a foreign_currency_code, or neither.
        /// </summary>
        /// <value>Submit either a foreign_currency_id or a foreign_currency_code, or neither.</value>
        /// <example>17</example>
        [DataMember(Name = "foreign_currency_id", EmitDefaultValue = true)]
        public string ForeignCurrencyId { get; set; }

        /// <summary>
        /// Submit either a foreign_currency_id or a foreign_currency_code, or neither.
        /// </summary>
        /// <value>Submit either a foreign_currency_id or a foreign_currency_code, or neither.</value>
        /// <example>GBP</example>
        [DataMember(Name = "foreign_currency_code", EmitDefaultValue = true)]
        public string ForeignCurrencyCode { get; set; }

        /// <summary>
        /// The budget ID for this transaction.
        /// </summary>
        /// <value>The budget ID for this transaction.</value>
        /// <example>4</example>
        [DataMember(Name = "budget_id", EmitDefaultValue = false)]
        public string BudgetId { get; set; }

        /// <summary>
        /// Category ID for this transaction.
        /// </summary>
        /// <value>Category ID for this transaction.</value>
        /// <example>211</example>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
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
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Optional.
        /// </summary>
        /// <value>Optional.</value>
        /// <example>123</example>
        [DataMember(Name = "piggy_bank_id", EmitDefaultValue = true)]
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecurrenceTransactionStore);
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ForeignAmount == input.ForeignAmount ||
                    (this.ForeignAmount != null &&
                    this.ForeignAmount.Equals(input.ForeignAmount))
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
                    this.ForeignCurrencyId == input.ForeignCurrencyId ||
                    (this.ForeignCurrencyId != null &&
                    this.ForeignCurrencyId.Equals(input.ForeignCurrencyId))
                ) && 
                (
                    this.ForeignCurrencyCode == input.ForeignCurrencyCode ||
                    (this.ForeignCurrencyCode != null &&
                    this.ForeignCurrencyCode.Equals(input.ForeignCurrencyCode))
                ) && 
                (
                    this.BudgetId == input.BudgetId ||
                    (this.BudgetId != null &&
                    this.BudgetId.Equals(input.BudgetId))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.DestinationId == input.DestinationId ||
                    (this.DestinationId != null &&
                    this.DestinationId.Equals(input.DestinationId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.PiggyBankId == input.PiggyBankId ||
                    (this.PiggyBankId != null &&
                    this.PiggyBankId.Equals(input.PiggyBankId))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.ForeignAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignAmount.GetHashCode();
                }
                if (this.CurrencyId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyId.GetHashCode();
                }
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.ForeignCurrencyId != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignCurrencyId.GetHashCode();
                }
                if (this.ForeignCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignCurrencyCode.GetHashCode();
                }
                if (this.BudgetId != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetId.GetHashCode();
                }
                if (this.CategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryId.GetHashCode();
                }
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.DestinationId != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationId.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.PiggyBankId != null)
                {
                    hashCode = (hashCode * 59) + this.PiggyBankId.GetHashCode();
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
