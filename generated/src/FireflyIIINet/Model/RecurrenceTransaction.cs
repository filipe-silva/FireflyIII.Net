/*
 * Firefly III API v2.0.3
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-06-11T09:13:59+00:00 
 *
 * The version of the OpenAPI document: 2.0.3
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
    /// RecurrenceTransaction
    /// </summary>
    [DataContract(Name = "RecurrenceTransaction")]
    public partial class RecurrenceTransaction : IEquatable<RecurrenceTransaction>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name = "source_type", EmitDefaultValue = false)]
        public AccountTypeProperty? SourceType { get; set; }

        /// <summary>
        /// Gets or Sets DestinationType
        /// </summary>
        [DataMember(Name = "destination_type", EmitDefaultValue = false)]
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
        /// <param name="billId">Optional. Use either this or the bill_name.</param>
        /// <param name="billName">Optional. Use either this or the bill_id.</param>
        public RecurrenceTransaction(string description = default(string), string amount = default(string), string foreignAmount = default(string), string currencyId = default(string), string currencyCode = default(string), string foreignCurrencyId = default(string), string foreignCurrencyCode = default(string), string budgetId = default(string), string categoryId = default(string), string categoryName = default(string), string sourceId = default(string), string sourceName = default(string), AccountTypeProperty? sourceType = default(AccountTypeProperty?), string destinationId = default(string), string destinationName = default(string), AccountTypeProperty? destinationType = default(AccountTypeProperty?), List<string> tags = default(List<string>), string piggyBankId = default(string), string piggyBankName = default(string), string billId = default(string), string billName = default(string))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for RecurrenceTransaction and cannot be null");
            }
            this.Description = description;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for RecurrenceTransaction and cannot be null");
            }
            this.Amount = amount;
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
            this.BillId = billId;
            this.BillName = billName;
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
        /// Gets or Sets CurrencySymbol
        /// </summary>
        /// <example>€</example>
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
        /// Number of decimals in the currency
        /// </summary>
        /// <value>Number of decimals in the currency</value>
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
        /// Gets or Sets ForeignCurrencySymbol
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "foreign_currency_symbol", EmitDefaultValue = true)]
        public string ForeignCurrencySymbol { get; private set; }

        /// <summary>
        /// Returns false as ForeignCurrencySymbol should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeForeignCurrencySymbol()
        {
            return false;
        }
        /// <summary>
        /// Number of decimals in the currency
        /// </summary>
        /// <value>Number of decimals in the currency</value>
        /// <example>2</example>
        [DataMember(Name = "foreign_currency_decimal_places", EmitDefaultValue = true)]
        public int? ForeignCurrencyDecimalPlaces { get; private set; }

        /// <summary>
        /// Returns false as ForeignCurrencyDecimalPlaces should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeForeignCurrencyDecimalPlaces()
        {
            return false;
        }
        /// <summary>
        /// The budget ID for this transaction.
        /// </summary>
        /// <value>The budget ID for this transaction.</value>
        /// <example>4</example>
        [DataMember(Name = "budget_id", EmitDefaultValue = false)]
        public string BudgetId { get; set; }

        /// <summary>
        /// The name of the budget to be used. If the budget name is unknown, the ID will be used or the value will be ignored.
        /// </summary>
        /// <value>The name of the budget to be used. If the budget name is unknown, the ID will be used or the value will be ignored.</value>
        /// <example>Groceries</example>
        [DataMember(Name = "budget_name", EmitDefaultValue = true)]
        public string BudgetName { get; private set; }

        /// <summary>
        /// Returns false as BudgetName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBudgetName()
        {
            return false;
        }
        /// <summary>
        /// Category ID for this transaction.
        /// </summary>
        /// <value>Category ID for this transaction.</value>
        /// <example>211</example>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// Category name for this transaction.
        /// </summary>
        /// <value>Category name for this transaction.</value>
        /// <example>Bills</example>
        [DataMember(Name = "category_name", EmitDefaultValue = false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// ID of the source account. Submit either this or source_name.
        /// </summary>
        /// <value>ID of the source account. Submit either this or source_name.</value>
        /// <example>913</example>
        [DataMember(Name = "source_id", EmitDefaultValue = false)]
        public string SourceId { get; set; }

        /// <summary>
        /// Name of the source account. Submit either this or source_id.
        /// </summary>
        /// <value>Name of the source account. Submit either this or source_id.</value>
        /// <example>Checking account</example>
        [DataMember(Name = "source_name", EmitDefaultValue = false)]
        public string SourceName { get; set; }

        /// <summary>
        /// Gets or Sets SourceIban
        /// </summary>
        /// <example>NL02ABNA0123456789</example>
        [DataMember(Name = "source_iban", EmitDefaultValue = true)]
        public string SourceIban { get; private set; }

        /// <summary>
        /// Returns false as SourceIban should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSourceIban()
        {
            return false;
        }
        /// <summary>
        /// ID of the destination account. Submit either this or destination_name.
        /// </summary>
        /// <value>ID of the destination account. Submit either this or destination_name.</value>
        /// <example>258</example>
        [DataMember(Name = "destination_id", EmitDefaultValue = false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// Name of the destination account. Submit either this or destination_id.
        /// </summary>
        /// <value>Name of the destination account. Submit either this or destination_id.</value>
        /// <example>Buy and Large</example>
        [DataMember(Name = "destination_name", EmitDefaultValue = false)]
        public string DestinationName { get; set; }

        /// <summary>
        /// Gets or Sets DestinationIban
        /// </summary>
        /// <example>NL02ABNA0123456789</example>
        [DataMember(Name = "destination_iban", EmitDefaultValue = true)]
        public string DestinationIban { get; private set; }

        /// <summary>
        /// Returns false as DestinationIban should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDestinationIban()
        {
            return false;
        }
        /// <summary>
        /// Array of tags.
        /// </summary>
        /// <value>Array of tags.</value>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Optional. Use either this or the piggy_bank_name
        /// </summary>
        /// <value>Optional. Use either this or the piggy_bank_name</value>
        /// <example>123</example>
        [DataMember(Name = "piggy_bank_id", EmitDefaultValue = true)]
        public string PiggyBankId { get; set; }

        /// <summary>
        /// Optional. Use either this or the piggy_bank_id
        /// </summary>
        /// <value>Optional. Use either this or the piggy_bank_id</value>
        [DataMember(Name = "piggy_bank_name", EmitDefaultValue = true)]
        public string PiggyBankName { get; set; }

        /// <summary>
        /// Optional. Use either this or the bill_name
        /// </summary>
        /// <value>Optional. Use either this or the bill_name</value>
        /// <example>123</example>
        [DataMember(Name = "bill_id", EmitDefaultValue = true)]
        public string BillId { get; set; }

        /// <summary>
        /// Optional. Use either this or the bill_id
        /// </summary>
        /// <value>Optional. Use either this or the bill_id</value>
        [DataMember(Name = "bill_name", EmitDefaultValue = true)]
        public string BillName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
            sb.Append("  BillId: ").Append(BillId).Append("\n");
            sb.Append("  BillName: ").Append(BillName).Append("\n");
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
                    (this.BudgetId != null &&
                    this.BudgetId.Equals(input.BudgetId))
                ) && 
                (
                    this.BudgetName == input.BudgetName ||
                    (this.BudgetName != null &&
                    this.BudgetName.Equals(input.BudgetName))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
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
                    (this.DestinationId != null &&
                    this.DestinationId.Equals(input.DestinationId))
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
                    (this.PiggyBankId != null &&
                    this.PiggyBankId.Equals(input.PiggyBankId))
                ) && 
                (
                    this.PiggyBankName == input.PiggyBankName ||
                    (this.PiggyBankName != null &&
                    this.PiggyBankName.Equals(input.PiggyBankName))
                ) && 
                (
                    this.BillId == input.BillId ||
                    (this.BillId != null &&
                    this.BillId.Equals(input.BillId))
                ) && 
                (
                    this.BillName == input.BillName ||
                    (this.BillName != null &&
                    this.BillName.Equals(input.BillName))
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
                if (this.CurrencySymbol != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencySymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CurrencyDecimalPlaces.GetHashCode();
                if (this.ForeignCurrencyId != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignCurrencyId.GetHashCode();
                }
                if (this.ForeignCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignCurrencyCode.GetHashCode();
                }
                if (this.ForeignCurrencySymbol != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignCurrencySymbol.GetHashCode();
                }
                if (this.ForeignCurrencyDecimalPlaces != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignCurrencyDecimalPlaces.GetHashCode();
                }
                if (this.BudgetId != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetId.GetHashCode();
                }
                if (this.BudgetName != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetName.GetHashCode();
                }
                if (this.CategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryId.GetHashCode();
                }
                if (this.CategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryName.GetHashCode();
                }
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.SourceName != null)
                {
                    hashCode = (hashCode * 59) + this.SourceName.GetHashCode();
                }
                if (this.SourceIban != null)
                {
                    hashCode = (hashCode * 59) + this.SourceIban.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SourceType.GetHashCode();
                if (this.DestinationId != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationId.GetHashCode();
                }
                if (this.DestinationName != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationName.GetHashCode();
                }
                if (this.DestinationIban != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationIban.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DestinationType.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.PiggyBankId != null)
                {
                    hashCode = (hashCode * 59) + this.PiggyBankId.GetHashCode();
                }
                if (this.PiggyBankName != null)
                {
                    hashCode = (hashCode * 59) + this.PiggyBankName.GetHashCode();
                }
                if (this.BillId != null)
                {
                    hashCode = (hashCode * 59) + this.BillId.GetHashCode();
                }
                if (this.BillName != null)
                {
                    hashCode = (hashCode * 59) + this.BillName.GetHashCode();
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
