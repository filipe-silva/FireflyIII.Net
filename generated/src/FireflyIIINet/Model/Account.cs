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
    /// Account
    /// </summary>
    [DataContract(Name = "Account")]
    public partial class Account : IEquatable<Account>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public ShortAccountTypeProperty Type { get; set; }

        /// <summary>
        /// Gets or Sets AccountRole
        /// </summary>
        [DataMember(Name = "account_role", EmitDefaultValue = true)]
        public AccountRoleProperty? AccountRole { get; set; }

        /// <summary>
        /// Gets or Sets CreditCardType
        /// </summary>
        [DataMember(Name = "credit_card_type", EmitDefaultValue = true)]
        public CreditCardType? CreditCardType { get; set; }

        /// <summary>
        /// Gets or Sets LiabilityType
        /// </summary>
        [DataMember(Name = "liability_type", EmitDefaultValue = true)]
        public LiabilityType? LiabilityType { get; set; }

        /// <summary>
        /// Gets or Sets LiabilityDirection
        /// </summary>
        [DataMember(Name = "liability_direction", EmitDefaultValue = true)]
        public LiabilityDirection? LiabilityDirection { get; set; }

        /// <summary>
        /// Gets or Sets InterestPeriod
        /// </summary>
        [DataMember(Name = "interest_period", EmitDefaultValue = true)]
        public InterestPeriod? InterestPeriod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Account() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="active">If omitted, defaults to true. (default to true).</param>
        /// <param name="order">Order of the account. Is NULL if account is not asset or liability..</param>
        /// <param name="name">name (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="accountRole">accountRole.</param>
        /// <param name="currencyId">Use either currency_id or currency_code. Defaults to the user&#39;s default currency..</param>
        /// <param name="currencyCode">Use either currency_id or currency_code. Defaults to the user&#39;s default currency..</param>
        /// <param name="iban">iban.</param>
        /// <param name="bic">bic.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="openingBalance">Represents the opening balance, the initial amount this account holds..</param>
        /// <param name="currentDebt">Represents the current debt for liabilities..</param>
        /// <param name="openingBalanceDate">Represents the date of the opening balance..</param>
        /// <param name="virtualBalance">virtualBalance.</param>
        /// <param name="includeNetWorth">If omitted, defaults to true. (default to true).</param>
        /// <param name="creditCardType">creditCardType.</param>
        /// <param name="monthlyPaymentDate">Mandatory when the account_role is ccAsset. Moment at which CC payment installments are asked for by the bank..</param>
        /// <param name="liabilityType">liabilityType.</param>
        /// <param name="liabilityDirection">liabilityDirection.</param>
        /// <param name="interest">Mandatory when type is liability. Interest percentage..</param>
        /// <param name="interestPeriod">interestPeriod.</param>
        /// <param name="notes">notes.</param>
        /// <param name="latitude">Latitude of the accounts&#39;s location, if applicable. Can be used to draw a map..</param>
        /// <param name="longitude">Latitude of the accounts&#39;s location, if applicable. Can be used to draw a map..</param>
        /// <param name="zoomLevel">Zoom level for the map, if drawn. This to set the box right. Unfortunately this is a proprietary value because each map provider has different zoom levels..</param>
        public Account(bool active = true, int? order = default(int?), string name = default(string), ShortAccountTypeProperty type = default(ShortAccountTypeProperty), AccountRoleProperty? accountRole = default(AccountRoleProperty?), string currencyId = default(string), string currencyCode = default(string), string iban = default(string), string bic = default(string), string accountNumber = default(string), string openingBalance = default(string), string currentDebt = default(string), DateTime? openingBalanceDate = default(DateTime?), string virtualBalance = default(string), bool includeNetWorth = true, CreditCardType? creditCardType = default(CreditCardType?), DateTime? monthlyPaymentDate = default(DateTime?), LiabilityType? liabilityType = default(LiabilityType?), LiabilityDirection? liabilityDirection = default(LiabilityDirection?), string interest = default(string), InterestPeriod? interestPeriod = default(InterestPeriod?), string notes = default(string), double? latitude = default(double?), double? longitude = default(double?), int? zoomLevel = default(int?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Account and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.Active = active;
            this.Order = order;
            this.AccountRole = accountRole;
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
            this.Iban = iban;
            this.Bic = bic;
            this.AccountNumber = accountNumber;
            this.OpeningBalance = openingBalance;
            this.CurrentDebt = currentDebt;
            this.OpeningBalanceDate = openingBalanceDate;
            this.VirtualBalance = virtualBalance;
            this.IncludeNetWorth = includeNetWorth;
            this.CreditCardType = creditCardType;
            this.MonthlyPaymentDate = monthlyPaymentDate;
            this.LiabilityType = liabilityType;
            this.LiabilityDirection = liabilityDirection;
            this.Interest = interest;
            this.InterestPeriod = interestPeriod;
            this.Notes = notes;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.ZoomLevel = zoomLevel;
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
        /// If omitted, defaults to true.
        /// </summary>
        /// <value>If omitted, defaults to true.</value>
        /// <example>false</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Order of the account. Is NULL if account is not asset or liability.
        /// </summary>
        /// <value>Order of the account. Is NULL if account is not asset or liability.</value>
        /// <example>1</example>
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>My checking account</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Use either currency_id or currency_code. Defaults to the user&#39;s default currency.
        /// </summary>
        /// <value>Use either currency_id or currency_code. Defaults to the user&#39;s default currency.</value>
        /// <example>12</example>
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
        /// Gets or Sets CurrentBalance
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "current_balance", EmitDefaultValue = false)]
        public string CurrentBalance { get; private set; }

        /// <summary>
        /// Returns false as CurrentBalance should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrentBalance()
        {
            return false;
        }
        /// <summary>
        /// The timestamp for this date is always 23:59:59, to indicate it&#39;s the balance at the very END of that particular day.
        /// </summary>
        /// <value>The timestamp for this date is always 23:59:59, to indicate it&#39;s the balance at the very END of that particular day.</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "current_balance_date", EmitDefaultValue = false)]
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
        /// Gets or Sets Iban
        /// </summary>
        /// <example>GB98MIDL07009312345678</example>
        [DataMember(Name = "iban", EmitDefaultValue = true)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets Bic
        /// </summary>
        /// <example>BOFAUS3N</example>
        [DataMember(Name = "bic", EmitDefaultValue = true)]
        public string Bic { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        /// <example>7009312345678</example>
        [DataMember(Name = "account_number", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Represents the opening balance, the initial amount this account holds.
        /// </summary>
        /// <value>Represents the opening balance, the initial amount this account holds.</value>
        /// <example>-1012.12</example>
        [DataMember(Name = "opening_balance", EmitDefaultValue = false)]
        public string OpeningBalance { get; set; }

        /// <summary>
        /// Represents the current debt for liabilities.
        /// </summary>
        /// <value>Represents the current debt for liabilities.</value>
        /// <example>1012.12</example>
        [DataMember(Name = "current_debt", EmitDefaultValue = true)]
        public string CurrentDebt { get; set; }

        /// <summary>
        /// Represents the date of the opening balance.
        /// </summary>
        /// <value>Represents the date of the opening balance.</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "opening_balance_date", EmitDefaultValue = true)]
        public DateTime? OpeningBalanceDate { get; set; }

        /// <summary>
        /// Gets or Sets VirtualBalance
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "virtual_balance", EmitDefaultValue = false)]
        public string VirtualBalance { get; set; }

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
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "monthly_payment_date", EmitDefaultValue = true)]
        public DateTime? MonthlyPaymentDate { get; set; }

        /// <summary>
        /// Mandatory when type is liability. Interest percentage.
        /// </summary>
        /// <value>Mandatory when type is liability. Interest percentage.</value>
        /// <example>5.3</example>
        [DataMember(Name = "interest", EmitDefaultValue = true)]
        public string Interest { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        /// <example>Some example notes</example>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Latitude of the accounts&#39;s location, if applicable. Can be used to draw a map.
        /// </summary>
        /// <value>Latitude of the accounts&#39;s location, if applicable. Can be used to draw a map.</value>
        /// <example>51.983333</example>
        [DataMember(Name = "latitude", EmitDefaultValue = true)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Latitude of the accounts&#39;s location, if applicable. Can be used to draw a map.
        /// </summary>
        /// <value>Latitude of the accounts&#39;s location, if applicable. Can be used to draw a map.</value>
        /// <example>5.916667</example>
        [DataMember(Name = "longitude", EmitDefaultValue = true)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Zoom level for the map, if drawn. This to set the box right. Unfortunately this is a proprietary value because each map provider has different zoom levels.
        /// </summary>
        /// <value>Zoom level for the map, if drawn. This to set the box right. Unfortunately this is a proprietary value because each map provider has different zoom levels.</value>
        /// <example>6</example>
        [DataMember(Name = "zoom_level", EmitDefaultValue = true)]
        public int? ZoomLevel { get; set; }

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
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AccountRole: ").Append(AccountRole).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
            sb.Append("  CurrentBalanceDate: ").Append(CurrentBalanceDate).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Bic: ").Append(Bic).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  OpeningBalance: ").Append(OpeningBalance).Append("\n");
            sb.Append("  CurrentDebt: ").Append(CurrentDebt).Append("\n");
            sb.Append("  OpeningBalanceDate: ").Append(OpeningBalanceDate).Append("\n");
            sb.Append("  VirtualBalance: ").Append(VirtualBalance).Append("\n");
            sb.Append("  IncludeNetWorth: ").Append(IncludeNetWorth).Append("\n");
            sb.Append("  CreditCardType: ").Append(CreditCardType).Append("\n");
            sb.Append("  MonthlyPaymentDate: ").Append(MonthlyPaymentDate).Append("\n");
            sb.Append("  LiabilityType: ").Append(LiabilityType).Append("\n");
            sb.Append("  LiabilityDirection: ").Append(LiabilityDirection).Append("\n");
            sb.Append("  Interest: ").Append(Interest).Append("\n");
            sb.Append("  InterestPeriod: ").Append(InterestPeriod).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  ZoomLevel: ").Append(ZoomLevel).Append("\n");
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
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                    this.AccountRole == input.AccountRole ||
                    this.AccountRole.Equals(input.AccountRole)
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
                    this.CurrentBalance == input.CurrentBalance ||
                    (this.CurrentBalance != null &&
                    this.CurrentBalance.Equals(input.CurrentBalance))
                ) && 
                (
                    this.CurrentBalanceDate == input.CurrentBalanceDate ||
                    (this.CurrentBalanceDate != null &&
                    this.CurrentBalanceDate.Equals(input.CurrentBalanceDate))
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
                    (this.OpeningBalance != null &&
                    this.OpeningBalance.Equals(input.OpeningBalance))
                ) && 
                (
                    this.CurrentDebt == input.CurrentDebt ||
                    (this.CurrentDebt != null &&
                    this.CurrentDebt.Equals(input.CurrentDebt))
                ) && 
                (
                    this.OpeningBalanceDate == input.OpeningBalanceDate ||
                    (this.OpeningBalanceDate != null &&
                    this.OpeningBalanceDate.Equals(input.OpeningBalanceDate))
                ) && 
                (
                    this.VirtualBalance == input.VirtualBalance ||
                    (this.VirtualBalance != null &&
                    this.VirtualBalance.Equals(input.VirtualBalance))
                ) && 
                (
                    this.IncludeNetWorth == input.IncludeNetWorth ||
                    this.IncludeNetWorth.Equals(input.IncludeNetWorth)
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
                    this.LiabilityDirection == input.LiabilityDirection ||
                    this.LiabilityDirection.Equals(input.LiabilityDirection)
                ) && 
                (
                    this.Interest == input.Interest ||
                    (this.Interest != null &&
                    this.Interest.Equals(input.Interest))
                ) && 
                (
                    this.InterestPeriod == input.InterestPeriod ||
                    this.InterestPeriod.Equals(input.InterestPeriod)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.ZoomLevel == input.ZoomLevel ||
                    (this.ZoomLevel != null &&
                    this.ZoomLevel.Equals(input.ZoomLevel))
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Order != null)
                {
                    hashCode = (hashCode * 59) + this.Order.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.AccountRole.GetHashCode();
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
                if (this.CurrentBalance != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentBalance.GetHashCode();
                }
                if (this.CurrentBalanceDate != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentBalanceDate.GetHashCode();
                }
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
                if (this.OpeningBalance != null)
                {
                    hashCode = (hashCode * 59) + this.OpeningBalance.GetHashCode();
                }
                if (this.CurrentDebt != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentDebt.GetHashCode();
                }
                if (this.OpeningBalanceDate != null)
                {
                    hashCode = (hashCode * 59) + this.OpeningBalanceDate.GetHashCode();
                }
                if (this.VirtualBalance != null)
                {
                    hashCode = (hashCode * 59) + this.VirtualBalance.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IncludeNetWorth.GetHashCode();
                hashCode = (hashCode * 59) + this.CreditCardType.GetHashCode();
                if (this.MonthlyPaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.MonthlyPaymentDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LiabilityType.GetHashCode();
                hashCode = (hashCode * 59) + this.LiabilityDirection.GetHashCode();
                if (this.Interest != null)
                {
                    hashCode = (hashCode * 59) + this.Interest.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InterestPeriod.GetHashCode();
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                }
                if (this.ZoomLevel != null)
                {
                    hashCode = (hashCode * 59) + this.ZoomLevel.GetHashCode();
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
