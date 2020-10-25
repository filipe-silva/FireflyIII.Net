/* 
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 0.10.4-modified
 * Contact: thegrumpydictator@gmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FireflyIII.Client.OpenAPIDateConverter;

namespace FireflyIII.Model
{
    /// <summary>
    /// RecurrenceTransaction
    /// </summary>
    [DataContract]
    public partial class RecurrenceTransaction :  IEquatable<RecurrenceTransaction>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name="source_type", EmitDefaultValue=false)]
        public AccountTypeProperty? SourceType { get; set; }
        /// <summary>
        /// Gets or Sets DestinationType
        /// </summary>
        [DataMember(Name="destination_type", EmitDefaultValue=false)]
        public AccountTypeProperty? DestinationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecurrenceTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceTransaction" /> class.
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
        /// <param name="categoryName">Category name for this transaction..</param>
        /// <param name="sourceId">ID of the source account. Submit either this or source_name..</param>
        /// <param name="sourceName">Name of the source account. Submit either this or source_id..</param>
        /// <param name="sourceType">sourceType.</param>
        /// <param name="destinationId">ID of the destination account. Submit either this or destination_name..</param>
        /// <param name="destinationName">Name of the destination account. Submit either this or destination_id..</param>
        /// <param name="destinationType">destinationType.</param>
        /// <param name="tags">Array of tags..</param>
        /// <param name="piggyBankId">Optional. Use either this or the piggy_bank_name.</param>
        /// <param name="piggyBankName">Optional. Use either this or the piggy_bank_id.</param>
        public RecurrenceTransaction(string description = default(string), double amount = default(double), double? foreignAmount = default(double?), int currencyId = default(int), string currencyCode = default(string), int? foreignCurrencyId = default(int?), string foreignCurrencyCode = default(string), int budgetId = default(int), int categoryId = default(int), string categoryName = default(string), int sourceId = default(int), string sourceName = default(string), AccountTypeProperty sourceType = default(AccountTypeProperty), int destinationId = default(int), string destinationName = default(string), AccountTypeProperty destinationType = default(AccountTypeProperty), List<string> tags = default(List<string>), int piggyBankId = default(int), string piggyBankName = default(string))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for RecurrenceTransaction and cannot be null");
            }
            else
            {
                this.Description = description;
            }

            // to ensure "amount" is required (not null)
            if (amount == 0)
            {
                throw new InvalidDataException("amount is a required property for RecurrenceTransaction and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            this.ForeignAmount = foreignAmount;
            this.ForeignCurrencyId = foreignCurrencyId;
            this.ForeignCurrencyCode = foreignCurrencyCode;
            this.Tags = tags;
            this.ForeignAmount = foreignAmount;
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
            this.ForeignCurrencyId = foreignCurrencyId;
            this.ForeignCurrencyCode = foreignCurrencyCode;
            this.BudgetId = budgetId;
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
            this.SourceId = sourceId;
            this.SourceName = sourceName;
            this.SourceType = sourceType;
            this.DestinationId = destinationId;
            this.DestinationName = destinationName;
            this.DestinationType = destinationType;
            this.Tags = tags;
            this.PiggyBankId = piggyBankId;
            this.PiggyBankName = piggyBankName;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        /// <value>Amount of the transaction.</value>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public double Amount { get; set; }

        /// <summary>
        /// Foreign amount of the transaction.
        /// </summary>
        /// <value>Foreign amount of the transaction.</value>
        [DataMember(Name="foreign_amount", EmitDefaultValue=false)]
        public double? ForeignAmount { get; set; }

        /// <summary>
        /// Submit either a currency_id or a currency_code.
        /// </summary>
        /// <value>Submit either a currency_id or a currency_code.</value>
        [DataMember(Name="currency_id", EmitDefaultValue=false)]
        public int CurrencyId { get; set; }

        /// <summary>
        /// Submit either a currency_id or a currency_code.
        /// </summary>
        /// <value>Submit either a currency_id or a currency_code.</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        [DataMember(Name="currency_symbol", EmitDefaultValue=false)]
        public string CurrencySymbol { get; private set; }

        /// <summary>
        /// Number of decimals in the currency
        /// </summary>
        /// <value>Number of decimals in the currency</value>
        [DataMember(Name="currency_decimal_places", EmitDefaultValue=false)]
        public int CurrencyDecimalPlaces { get; private set; }

        /// <summary>
        /// Submit either a foreign_currency_id or a foreign_currency_code, or neither.
        /// </summary>
        /// <value>Submit either a foreign_currency_id or a foreign_currency_code, or neither.</value>
        [DataMember(Name="foreign_currency_id", EmitDefaultValue=false)]
        public int? ForeignCurrencyId { get; set; }

        /// <summary>
        /// Submit either a foreign_currency_id or a foreign_currency_code, or neither.
        /// </summary>
        /// <value>Submit either a foreign_currency_id or a foreign_currency_code, or neither.</value>
        [DataMember(Name="foreign_currency_code", EmitDefaultValue=false)]
        public string ForeignCurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets ForeignCurrencySymbol
        /// </summary>
        [DataMember(Name="foreign_currency_symbol", EmitDefaultValue=false)]
        public string ForeignCurrencySymbol { get; private set; }

        /// <summary>
        /// Number of decimals in the currency
        /// </summary>
        /// <value>Number of decimals in the currency</value>
        [DataMember(Name="foreign_currency_decimal_places", EmitDefaultValue=false)]
        public int? ForeignCurrencyDecimalPlaces { get; private set; }

        /// <summary>
        /// The budget ID for this transaction.
        /// </summary>
        /// <value>The budget ID for this transaction.</value>
        [DataMember(Name="budget_id", EmitDefaultValue=false)]
        public int BudgetId { get; set; }

        /// <summary>
        /// The name of the budget to be used. If the budget name is unknown, the ID will be used or the value will be ignored.
        /// </summary>
        /// <value>The name of the budget to be used. If the budget name is unknown, the ID will be used or the value will be ignored.</value>
        [DataMember(Name="budget_name", EmitDefaultValue=false)]
        public string BudgetName { get; private set; }

        /// <summary>
        /// Category ID for this transaction.
        /// </summary>
        /// <value>Category ID for this transaction.</value>
        [DataMember(Name="category_id", EmitDefaultValue=false)]
        public int CategoryId { get; set; }

        /// <summary>
        /// Category name for this transaction.
        /// </summary>
        /// <value>Category name for this transaction.</value>
        [DataMember(Name="category_name", EmitDefaultValue=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// ID of the source account. Submit either this or source_name.
        /// </summary>
        /// <value>ID of the source account. Submit either this or source_name.</value>
        [DataMember(Name="source_id", EmitDefaultValue=false)]
        public int SourceId { get; set; }

        /// <summary>
        /// Name of the source account. Submit either this or source_id.
        /// </summary>
        /// <value>Name of the source account. Submit either this or source_id.</value>
        [DataMember(Name="source_name", EmitDefaultValue=false)]
        public string SourceName { get; set; }

        /// <summary>
        /// Gets or Sets SourceIban
        /// </summary>
        [DataMember(Name="source_iban", EmitDefaultValue=false)]
        public string SourceIban { get; private set; }

        /// <summary>
        /// ID of the destination account. Submit either this or destination_name.
        /// </summary>
        /// <value>ID of the destination account. Submit either this or destination_name.</value>
        [DataMember(Name="destination_id", EmitDefaultValue=false)]
        public int DestinationId { get; set; }

        /// <summary>
        /// Name of the destination account. Submit either this or destination_id.
        /// </summary>
        /// <value>Name of the destination account. Submit either this or destination_id.</value>
        [DataMember(Name="destination_name", EmitDefaultValue=false)]
        public string DestinationName { get; set; }

        /// <summary>
        /// Gets or Sets DestinationIban
        /// </summary>
        [DataMember(Name="destination_iban", EmitDefaultValue=false)]
        public string DestinationIban { get; private set; }

        /// <summary>
        /// Array of tags.
        /// </summary>
        /// <value>Array of tags.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Optional. Use either this or the piggy_bank_name
        /// </summary>
        /// <value>Optional. Use either this or the piggy_bank_name</value>
        [DataMember(Name="piggy_bank_id", EmitDefaultValue=false)]
        public int PiggyBankId { get; set; }

        /// <summary>
        /// Optional. Use either this or the piggy_bank_id
        /// </summary>
        /// <value>Optional. Use either this or the piggy_bank_id</value>
        [DataMember(Name="piggy_bank_name", EmitDefaultValue=false)]
        public string PiggyBankName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecurrenceTransaction {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ForeignAmount: ").Append(ForeignAmount).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  ForeignCurrencyId: ").Append(ForeignCurrencyId).Append("\n");
            sb.Append("  ForeignCurrencyCode: ").Append(ForeignCurrencyCode).Append("\n");
            sb.Append("  ForeignCurrencySymbol: ").Append(ForeignCurrencySymbol).Append("\n");
            sb.Append("  ForeignCurrencyDecimalPlaces: ").Append(ForeignCurrencyDecimalPlaces).Append("\n");
            sb.Append("  BudgetId: ").Append(BudgetId).Append("\n");
            sb.Append("  BudgetName: ").Append(BudgetName).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SourceName: ").Append(SourceName).Append("\n");
            sb.Append("  SourceIban: ").Append(SourceIban).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  DestinationId: ").Append(DestinationId).Append("\n");
            sb.Append("  DestinationName: ").Append(DestinationName).Append("\n");
            sb.Append("  DestinationIban: ").Append(DestinationIban).Append("\n");
            sb.Append("  DestinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  PiggyBankId: ").Append(PiggyBankId).Append("\n");
            sb.Append("  PiggyBankName: ").Append(PiggyBankName).Append("\n");
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
            return this.Equals(input as RecurrenceTransaction);
        }

        /// <summary>
        /// Returns true if RecurrenceTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurrenceTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurrenceTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.ForeignAmount == input.ForeignAmount ||
                    (this.ForeignAmount != null &&
                    this.ForeignAmount.Equals(input.ForeignAmount))
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    this.CurrencyId.Equals(input.CurrencyId)
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
                    this.ForeignCurrencySymbol == input.ForeignCurrencySymbol ||
                    (this.ForeignCurrencySymbol != null &&
                    this.ForeignCurrencySymbol.Equals(input.ForeignCurrencySymbol))
                ) && 
                (
                    this.ForeignCurrencyDecimalPlaces == input.ForeignCurrencyDecimalPlaces ||
                    (this.ForeignCurrencyDecimalPlaces != null &&
                    this.ForeignCurrencyDecimalPlaces.Equals(input.ForeignCurrencyDecimalPlaces))
                ) && 
                (
                    this.BudgetId == input.BudgetId ||
                    this.BudgetId.Equals(input.BudgetId)
                ) && 
                (
                    this.BudgetName == input.BudgetName ||
                    (this.BudgetName != null &&
                    this.BudgetName.Equals(input.BudgetName))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    this.CategoryId.Equals(input.CategoryId)
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    this.SourceId.Equals(input.SourceId)
                ) && 
                (
                    this.SourceName == input.SourceName ||
                    (this.SourceName != null &&
                    this.SourceName.Equals(input.SourceName))
                ) && 
                (
                    this.SourceIban == input.SourceIban ||
                    (this.SourceIban != null &&
                    this.SourceIban.Equals(input.SourceIban))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    this.SourceType.Equals(input.SourceType)
                ) && 
                (
                    this.DestinationId == input.DestinationId ||
                    this.DestinationId.Equals(input.DestinationId)
                ) && 
                (
                    this.DestinationName == input.DestinationName ||
                    (this.DestinationName != null &&
                    this.DestinationName.Equals(input.DestinationName))
                ) && 
                (
                    this.DestinationIban == input.DestinationIban ||
                    (this.DestinationIban != null &&
                    this.DestinationIban.Equals(input.DestinationIban))
                ) && 
                (
                    this.DestinationType == input.DestinationType ||
                    this.DestinationType.Equals(input.DestinationType)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.PiggyBankId == input.PiggyBankId ||
                    this.PiggyBankId.Equals(input.PiggyBankId)
                ) && 
                (
                    this.PiggyBankName == input.PiggyBankName ||
                    (this.PiggyBankName != null &&
                    this.PiggyBankName.Equals(input.PiggyBankName))
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
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ForeignAmount != null)
                    hashCode = hashCode * 59 + this.ForeignAmount.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.CurrencySymbol != null)
                    hashCode = hashCode * 59 + this.CurrencySymbol.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyDecimalPlaces.GetHashCode();
                if (this.ForeignCurrencyId != null)
                    hashCode = hashCode * 59 + this.ForeignCurrencyId.GetHashCode();
                if (this.ForeignCurrencyCode != null)
                    hashCode = hashCode * 59 + this.ForeignCurrencyCode.GetHashCode();
                if (this.ForeignCurrencySymbol != null)
                    hashCode = hashCode * 59 + this.ForeignCurrencySymbol.GetHashCode();
                if (this.ForeignCurrencyDecimalPlaces != null)
                    hashCode = hashCode * 59 + this.ForeignCurrencyDecimalPlaces.GetHashCode();
                hashCode = hashCode * 59 + this.BudgetId.GetHashCode();
                if (this.BudgetName != null)
                    hashCode = hashCode * 59 + this.BudgetName.GetHashCode();
                hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.SourceName != null)
                    hashCode = hashCode * 59 + this.SourceName.GetHashCode();
                if (this.SourceIban != null)
                    hashCode = hashCode * 59 + this.SourceIban.GetHashCode();
                hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                hashCode = hashCode * 59 + this.DestinationId.GetHashCode();
                if (this.DestinationName != null)
                    hashCode = hashCode * 59 + this.DestinationName.GetHashCode();
                if (this.DestinationIban != null)
                    hashCode = hashCode * 59 + this.DestinationIban.GetHashCode();
                hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.PiggyBankId.GetHashCode();
                if (this.PiggyBankName != null)
                    hashCode = hashCode * 59 + this.PiggyBankName.GetHashCode();
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
