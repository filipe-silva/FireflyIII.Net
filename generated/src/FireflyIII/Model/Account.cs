/*
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: thegrumpydictator@gmail.com
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
using OpenAPIDateConverter = FireflyIII.Client.OpenAPIDateConverter;

namespace FireflyIII.Model
{
    /// <summary>
    /// Account
    /// </summary>
    [DataContract(Name = "Account")]
    public partial class Account : IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Can only be one one these account types. import, initial-balance and reconciliation cannot be set manually.
        /// </summary>
        /// <value>Can only be one one these account types. import, initial-balance and reconciliation cannot be set manually.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Asset for value: asset
            /// </summary>
            [EnumMember(Value = "asset")]
            Asset = 1,

            /// <summary>
            /// Enum Expense for value: expense
            /// </summary>
            [EnumMember(Value = "expense")]
            Expense = 2,

            /// <summary>
            /// Enum Import for value: import
            /// </summary>
            [EnumMember(Value = "import")]
            Import = 3,

            /// <summary>
            /// Enum Revenue for value: revenue
            /// </summary>
            [EnumMember(Value = "revenue")]
            Revenue = 4,

            /// <summary>
            /// Enum Cash for value: cash
            /// </summary>
            [EnumMember(Value = "cash")]
            Cash = 5,

            /// <summary>
            /// Enum Liability for value: liability
            /// </summary>
            [EnumMember(Value = "liability")]
            Liability = 6,

            /// <summary>
            /// Enum Liabilities for value: liabilities
            /// </summary>
            [EnumMember(Value = "liabilities")]
            Liabilities = 7,

            /// <summary>
            /// Enum InitialBalance for value: initial-balance
            /// </summary>
            [EnumMember(Value = "initial-balance")]
            InitialBalance = 8,

            /// <summary>
            /// Enum Reconciliation for value: reconciliation
            /// </summary>
            [EnumMember(Value = "reconciliation")]
            Reconciliation = 9
        }


        /// <summary>
        /// Can only be one one these account types. import, initial-balance and reconciliation cannot be set manually.
        /// </summary>
        /// <value>Can only be one one these account types. import, initial-balance and reconciliation cannot be set manually.</value>
        /// <example>asset</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Is only mandatory when the type is asset.
        /// </summary>
        /// <value>Is only mandatory when the type is asset.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountRoleEnum
        {
            /// <summary>
            /// Enum DefaultAsset for value: defaultAsset
            /// </summary>
            [EnumMember(Value = "defaultAsset")]
            DefaultAsset = 1,

            /// <summary>
            /// Enum SharedAsset for value: sharedAsset
            /// </summary>
            [EnumMember(Value = "sharedAsset")]
            SharedAsset = 2,

            /// <summary>
            /// Enum SavingAsset for value: savingAsset
            /// </summary>
            [EnumMember(Value = "savingAsset")]
            SavingAsset = 3,

            /// <summary>
            /// Enum CcAsset for value: ccAsset
            /// </summary>
            [EnumMember(Value = "ccAsset")]
            CcAsset = 4,

            /// <summary>
            /// Enum CashWalletAsset for value: cashWalletAsset
            /// </summary>
            [EnumMember(Value = "cashWalletAsset")]
            CashWalletAsset = 5
        }


        /// <summary>
        /// Is only mandatory when the type is asset.
        /// </summary>
        /// <value>Is only mandatory when the type is asset.</value>
        /// <example>defaultAsset</example>
        [DataMember(Name = "account_role", EmitDefaultValue = false)]
        public AccountRoleEnum? AccountRole { get; set; }
        /// <summary>
        /// Mandatory when the account_role is ccAsset. Can only be monthlyFull.
        /// </summary>
        /// <value>Mandatory when the account_role is ccAsset. Can only be monthlyFull.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CreditCardTypeEnum
        {
            /// <summary>
            /// Enum MonthlyFull for value: monthlyFull
            /// </summary>
            [EnumMember(Value = "monthlyFull")]
            MonthlyFull = 1
        }


        /// <summary>
        /// Mandatory when the account_role is ccAsset. Can only be monthlyFull.
        /// </summary>
        /// <value>Mandatory when the account_role is ccAsset. Can only be monthlyFull.</value>
        /// <example>monthlyFull</example>
        [DataMember(Name = "credit_card_type", EmitDefaultValue = true)]
        public CreditCardTypeEnum? CreditCardType { get; set; }
        /// <summary>
        /// Mandatory when type is liability. Specifies the exact type.
        /// </summary>
        /// <value>Mandatory when type is liability. Specifies the exact type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LiabilityTypeEnum
        {
            /// <summary>
            /// Enum Loan for value: loan
            /// </summary>
            [EnumMember(Value = "loan")]
            Loan = 1,

            /// <summary>
            /// Enum Debt for value: debt
            /// </summary>
            [EnumMember(Value = "debt")]
            Debt = 2,

            /// <summary>
            /// Enum Mortgage for value: mortgage
            /// </summary>
            [EnumMember(Value = "mortgage")]
            Mortgage = 3
        }


        /// <summary>
        /// Mandatory when type is liability. Specifies the exact type.
        /// </summary>
        /// <value>Mandatory when type is liability. Specifies the exact type.</value>
        /// <example>loan</example>
        [DataMember(Name = "liability_type", EmitDefaultValue = false)]
        public LiabilityTypeEnum? LiabilityType { get; set; }
        /// <summary>
        /// Mandatory when type is liability. Period over which the interest is calculated.
        /// </summary>
        /// <value>Mandatory when type is liability. Period over which the interest is calculated.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InterestPeriodEnum
        {
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 1,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 2,

            /// <summary>
            /// Enum Yearly for value: yearly
            /// </summary>
            [EnumMember(Value = "yearly")]
            Yearly = 3
        }


        /// <summary>
        /// Mandatory when type is liability. Period over which the interest is calculated.
        /// </summary>
        /// <value>Mandatory when type is liability. Period over which the interest is calculated.</value>
        /// <example>monthly</example>
        [DataMember(Name = "interest_period", EmitDefaultValue = false)]
        public InterestPeriodEnum? InterestPeriod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Account() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="type">Can only be one one these account types. import, initial-balance and reconciliation cannot be set manually. (required).</param>
        /// <param name="iban">iban.</param>
        /// <param name="bic">bic.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="openingBalance">openingBalance.</param>
        /// <param name="openingBalanceDate">openingBalanceDate.</param>
        /// <param name="virtualBalance">virtualBalance.</param>
        /// <param name="currencyId">Use either currency_id or currency_code. Defaults to the user&#39;s default currency..</param>
        /// <param name="currencyCode">Use either currency_id or currency_code. Defaults to the user&#39;s default currency..</param>
        /// <param name="active">If omitted, defaults to true..</param>
        /// <param name="includeNetWorth">If omitted, defaults to true..</param>
        /// <param name="accountRole">Is only mandatory when the type is asset..</param>
        /// <param name="creditCardType">Mandatory when the account_role is ccAsset. Can only be monthlyFull..</param>
        /// <param name="monthlyPaymentDate">Mandatory when the account_role is ccAsset. Moment at which CC payment installments are asked for by the bank..</param>
        /// <param name="liabilityType">Mandatory when type is liability. Specifies the exact type..</param>
        /// <param name="liabilityAmount">Mandatory when type is liability. Amount of money in the liability. Must be positive..</param>
        /// <param name="liabilityStartDate">Mandatory when type is liability. Start date for the liability..</param>
        /// <param name="interest">Mandatory when type is liability. Interest percentage..</param>
        /// <param name="interestPeriod">Mandatory when type is liability. Period over which the interest is calculated..</param>
        /// <param name="notes">notes.</param>
        public Account(string name = default(string), TypeEnum type = default(TypeEnum), string iban = default(string), string bic = default(string), string accountNumber = default(string), double openingBalance = default(double), DateTime openingBalanceDate = default(DateTime), double virtualBalance = default(double), int currencyId = default(int), string currencyCode = default(string), bool active = default(bool), bool includeNetWorth = default(bool), AccountRoleEnum? accountRole = default(AccountRoleEnum?), CreditCardTypeEnum? creditCardType = default(CreditCardTypeEnum?), DateTime? monthlyPaymentDate = default(DateTime?), LiabilityTypeEnum? liabilityType = default(LiabilityTypeEnum?), double liabilityAmount = default(double), DateTime liabilityStartDate = default(DateTime), float interest = default(float), InterestPeriodEnum? interestPeriod = default(InterestPeriodEnum?), string notes = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Account and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.Iban = iban;
            this.Bic = bic;
            this.AccountNumber = accountNumber;
            this.OpeningBalance = openingBalance;
            this.OpeningBalanceDate = openingBalanceDate;
            this.VirtualBalance = virtualBalance;
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
            this.Active = active;
            this.IncludeNetWorth = includeNetWorth;
            this.AccountRole = accountRole;
            this.CreditCardType = creditCardType;
            this.MonthlyPaymentDate = monthlyPaymentDate;
            this.LiabilityType = liabilityType;
            this.LiabilityAmount = liabilityAmount;
            this.LiabilityStartDate = liabilityStartDate;
            this.Interest = interest;
            this.InterestPeriod = interestPeriod;
            this.Notes = notes;
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
        /// Gets or Sets Name
        /// </summary>
        /// <example>My checking account</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        /// <example>GB98MIDL07009312345678</example>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets Bic
        /// </summary>
        /// <example>BOFAUS3N</example>
        [DataMember(Name = "bic", EmitDefaultValue = false)]
        public string Bic { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        /// <example>7009312345678</example>
        [DataMember(Name = "account_number", EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets OpeningBalance
        /// </summary>
        /// <example>-1012.12</example>
        [DataMember(Name = "opening_balance", EmitDefaultValue = false)]
        public double OpeningBalance { get; set; }

        /// <summary>
        /// Gets or Sets OpeningBalanceDate
        /// </summary>
        /// <example>Mon Sep 17 01:00:00 WEST 2018</example>
        [DataMember(Name = "opening_balance_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime OpeningBalanceDate { get; set; }

        /// <summary>
        /// Gets or Sets VirtualBalance
        /// </summary>
        /// <example>1000</example>
        [DataMember(Name = "virtual_balance", EmitDefaultValue = false)]
        public double VirtualBalance { get; set; }

        /// <summary>
        /// Gets or Sets CurrentBalance
        /// </summary>
        /// <example>152.34</example>
        [DataMember(Name = "current_balance", EmitDefaultValue = false)]
        public double CurrentBalance { get; private set; }

        /// <summary>
        /// Returns false as CurrentBalance should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrentBalance()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrentBalanceDate
        /// </summary>
        /// <example>Mon Sep 17 01:00:00 WEST 2018</example>
        [DataMember(Name = "current_balance_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime CurrentBalanceDate { get; private set; }

        /// <summary>
        /// Returns false as CurrentBalanceDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrentBalanceDate()
        {
            return false;
        }
        /// <summary>
        /// Use either currency_id or currency_code. Defaults to the user&#39;s default currency.
        /// </summary>
        /// <value>Use either currency_id or currency_code. Defaults to the user&#39;s default currency.</value>
        /// <example>12</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = false)]
        public int CurrencyId { get; set; }

        /// <summary>
        /// Use either currency_id or currency_code. Defaults to the user&#39;s default currency.
        /// </summary>
        /// <value>Use either currency_id or currency_code. Defaults to the user&#39;s default currency.</value>
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
        /// If omitted, defaults to true.
        /// </summary>
        /// <value>If omitted, defaults to true.</value>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// If omitted, defaults to true.
        /// </summary>
        /// <value>If omitted, defaults to true.</value>
        /// <example>true</example>
        [DataMember(Name = "include_net_worth", EmitDefaultValue = true)]
        public bool IncludeNetWorth { get; set; }

        /// <summary>
        /// Mandatory when the account_role is ccAsset. Moment at which CC payment installments are asked for by the bank.
        /// </summary>
        /// <value>Mandatory when the account_role is ccAsset. Moment at which CC payment installments are asked for by the bank.</value>
        /// <example>Mon Sep 17 01:00:00 WEST 2018</example>
        [DataMember(Name = "monthly_payment_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? MonthlyPaymentDate { get; set; }

        /// <summary>
        /// Mandatory when type is liability. Amount of money in the liability. Must be positive.
        /// </summary>
        /// <value>Mandatory when type is liability. Amount of money in the liability. Must be positive.</value>
        /// <example>12000</example>
        [DataMember(Name = "liability_amount", EmitDefaultValue = false)]
        public double LiabilityAmount { get; set; }

        /// <summary>
        /// Mandatory when type is liability. Start date for the liability.
        /// </summary>
        /// <value>Mandatory when type is liability. Start date for the liability.</value>
        /// <example>Sun Sep 17 01:00:00 WEST 2017</example>
        [DataMember(Name = "liability_start_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime LiabilityStartDate { get; set; }

        /// <summary>
        /// Mandatory when type is liability. Interest percentage.
        /// </summary>
        /// <value>Mandatory when type is liability. Interest percentage.</value>
        /// <example>3</example>
        [DataMember(Name = "interest", EmitDefaultValue = false)]
        public float Interest { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        /// <example>Some example notes</example>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Bic: ").Append(Bic).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  OpeningBalance: ").Append(OpeningBalance).Append("\n");
            sb.Append("  OpeningBalanceDate: ").Append(OpeningBalanceDate).Append("\n");
            sb.Append("  VirtualBalance: ").Append(VirtualBalance).Append("\n");
            sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
            sb.Append("  CurrentBalanceDate: ").Append(CurrentBalanceDate).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  IncludeNetWorth: ").Append(IncludeNetWorth).Append("\n");
            sb.Append("  AccountRole: ").Append(AccountRole).Append("\n");
            sb.Append("  CreditCardType: ").Append(CreditCardType).Append("\n");
            sb.Append("  MonthlyPaymentDate: ").Append(MonthlyPaymentDate).Append("\n");
            sb.Append("  LiabilityType: ").Append(LiabilityType).Append("\n");
            sb.Append("  LiabilityAmount: ").Append(LiabilityAmount).Append("\n");
            sb.Append("  LiabilityStartDate: ").Append(LiabilityStartDate).Append("\n");
            sb.Append("  Interest: ").Append(Interest).Append("\n");
            sb.Append("  InterestPeriod: ").Append(InterestPeriod).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && 
                (
                    this.Bic == input.Bic ||
                    (this.Bic != null &&
                    this.Bic.Equals(input.Bic))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.OpeningBalance == input.OpeningBalance ||
                    this.OpeningBalance.Equals(input.OpeningBalance)
                ) && 
                (
                    this.OpeningBalanceDate == input.OpeningBalanceDate ||
                    (this.OpeningBalanceDate != null &&
                    this.OpeningBalanceDate.Equals(input.OpeningBalanceDate))
                ) && 
                (
                    this.VirtualBalance == input.VirtualBalance ||
                    this.VirtualBalance.Equals(input.VirtualBalance)
                ) && 
                (
                    this.CurrentBalance == input.CurrentBalance ||
                    this.CurrentBalance.Equals(input.CurrentBalance)
                ) && 
                (
                    this.CurrentBalanceDate == input.CurrentBalanceDate ||
                    (this.CurrentBalanceDate != null &&
                    this.CurrentBalanceDate.Equals(input.CurrentBalanceDate))
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
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.IncludeNetWorth == input.IncludeNetWorth ||
                    this.IncludeNetWorth.Equals(input.IncludeNetWorth)
                ) && 
                (
                    this.AccountRole == input.AccountRole ||
                    this.AccountRole.Equals(input.AccountRole)
                ) && 
                (
                    this.CreditCardType == input.CreditCardType ||
                    this.CreditCardType.Equals(input.CreditCardType)
                ) && 
                (
                    this.MonthlyPaymentDate == input.MonthlyPaymentDate ||
                    (this.MonthlyPaymentDate != null &&
                    this.MonthlyPaymentDate.Equals(input.MonthlyPaymentDate))
                ) && 
                (
                    this.LiabilityType == input.LiabilityType ||
                    this.LiabilityType.Equals(input.LiabilityType)
                ) && 
                (
                    this.LiabilityAmount == input.LiabilityAmount ||
                    this.LiabilityAmount.Equals(input.LiabilityAmount)
                ) && 
                (
                    this.LiabilityStartDate == input.LiabilityStartDate ||
                    (this.LiabilityStartDate != null &&
                    this.LiabilityStartDate.Equals(input.LiabilityStartDate))
                ) && 
                (
                    this.Interest == input.Interest ||
                    this.Interest.Equals(input.Interest)
                ) && 
                (
                    this.InterestPeriod == input.InterestPeriod ||
                    this.InterestPeriod.Equals(input.InterestPeriod)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Iban != null)
                {
                    hashCode = (hashCode * 59) + this.Iban.GetHashCode();
                }
                if (this.Bic != null)
                {
                    hashCode = (hashCode * 59) + this.Bic.GetHashCode();
                }
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OpeningBalance.GetHashCode();
                if (this.OpeningBalanceDate != null)
                {
                    hashCode = (hashCode * 59) + this.OpeningBalanceDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VirtualBalance.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentBalance.GetHashCode();
                if (this.CurrentBalanceDate != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentBalanceDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CurrencyId.GetHashCode();
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.CurrencySymbol != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencySymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CurrencyDecimalPlaces.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeNetWorth.GetHashCode();
                hashCode = (hashCode * 59) + this.AccountRole.GetHashCode();
                hashCode = (hashCode * 59) + this.CreditCardType.GetHashCode();
                if (this.MonthlyPaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.MonthlyPaymentDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LiabilityType.GetHashCode();
                hashCode = (hashCode * 59) + this.LiabilityAmount.GetHashCode();
                if (this.LiabilityStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.LiabilityStartDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Interest.GetHashCode();
                hashCode = (hashCode * 59) + this.InterestPeriod.GetHashCode();
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
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
