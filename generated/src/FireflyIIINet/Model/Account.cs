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
        [DataMember(Name = "account_role", EmitDefaultValue = false)]
        public AccountRoleProperty? AccountRole { get; set; }

        /// <summary>
        /// Gets or Sets CreditCardType
        /// </summary>
        [DataMember(Name = "credit_card_type", EmitDefaultValue = false)]
        public CreditCardType? CreditCardType { get; set; }

        /// <summary>
        /// Gets or Sets LiabilityType
        /// </summary>
        [DataMember(Name = "liability_type", EmitDefaultValue = false)]
        public LiabilityType? LiabilityType { get; set; }

        /// <summary>
        /// Gets or Sets LiabilityDirection
        /// </summary>
        [DataMember(Name = "liability_direction", EmitDefaultValue = false)]
        public LiabilityDirection? LiabilityDirection { get; set; }

        /// <summary>
        /// Gets or Sets InterestPeriod
        /// </summary>
        [DataMember(Name = "interest_period", EmitDefaultValue = false)]
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
            Name = name;
            Type = type;
            Active = active;
            Order = order;
            AccountRole = accountRole;
            CurrencyId = currencyId;
            CurrencyCode = currencyCode;
            Iban = iban;
            Bic = bic;
            AccountNumber = accountNumber;
            OpeningBalance = openingBalance;
            CurrentDebt = currentDebt;
            OpeningBalanceDate = openingBalanceDate;
            VirtualBalance = virtualBalance;
            IncludeNetWorth = includeNetWorth;
            CreditCardType = creditCardType;
            MonthlyPaymentDate = monthlyPaymentDate;
            LiabilityType = liabilityType;
            LiabilityDirection = liabilityDirection;
            Interest = interest;
            InterestPeriod = interestPeriod;
            Notes = notes;
            Latitude = latitude;
            Longitude = longitude;
            ZoomLevel = zoomLevel;
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
        [DataMember(Name = "order", EmitDefaultValue = false)]
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
        /// Gets or Sets CurrentBalance
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "current_balance", EmitDefaultValue = true)]
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
        /// Gets or Sets CurrentBalanceDate
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "current_balance_date", EmitDefaultValue = true)]
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
        /// Represents the opening balance, the initial amount this account holds.
        /// </summary>
        /// <value>Represents the opening balance, the initial amount this account holds.</value>
        /// <example>-1012.12</example>
        [DataMember(Name = "opening_balance", EmitDefaultValue = true)]
        public string OpeningBalance { get; set; }

        /// <summary>
        /// Represents the current debt for liabilities.
        /// </summary>
        /// <value>Represents the current debt for liabilities.</value>
        /// <example>1012.12</example>
        [DataMember(Name = "current_debt", EmitDefaultValue = false)]
        public string CurrentDebt { get; set; }

        /// <summary>
        /// Represents the date of the opening balance.
        /// </summary>
        /// <value>Represents the date of the opening balance.</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "opening_balance_date", EmitDefaultValue = false)]
        public DateTime? OpeningBalanceDate { get; set; }

        /// <summary>
        /// Gets or Sets VirtualBalance
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "virtual_balance", EmitDefaultValue = true)]
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
        [DataMember(Name = "monthly_payment_date", EmitDefaultValue = false)]
        public DateTime? MonthlyPaymentDate { get; set; }

        /// <summary>
        /// Mandatory when type is liability. Interest percentage.
        /// </summary>
        /// <value>Mandatory when type is liability. Interest percentage.</value>
        /// <example>5.3</example>
        [DataMember(Name = "interest", EmitDefaultValue = false)]
        public string Interest { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        /// <example>Some example notes</example>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Latitude of the accounts&#39;s location, if applicable. Can be used to draw a map.
        /// </summary>
        /// <value>Latitude of the accounts&#39;s location, if applicable. Can be used to draw a map.</value>
        /// <example>51.983333</example>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Latitude of the accounts&#39;s location, if applicable. Can be used to draw a map.
        /// </summary>
        /// <value>Latitude of the accounts&#39;s location, if applicable. Can be used to draw a map.</value>
        /// <example>5.916667</example>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Zoom level for the map, if drawn. This to set the box right. Unfortunately this is a proprietary value because each map provider has different zoom levels.
        /// </summary>
        /// <value>Zoom level for the map, if drawn. This to set the box right. Unfortunately this is a proprietary value because each map provider has different zoom levels.</value>
        /// <example>6</example>
        [DataMember(Name = "zoom_level", EmitDefaultValue = false)]
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as Account);
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
                    CreatedAt == input.CreatedAt ||
					CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    UpdatedAt == input.UpdatedAt ||
					UpdatedAt.Equals(input.UpdatedAt)
                ) && 
                (
                    Active == input.Active ||
                    Active.Equals(input.Active)
                ) && 
                (
                    Order == input.Order ||
                    (Order != null &&
                    Order.Equals(input.Order))
                ) && 
                (
                    Name == input.Name ||
					Name.Equals(input.Name)
                ) && 
                (
                    Type == input.Type ||
                    Type.Equals(input.Type)
                ) && 
                (
                    AccountRole == input.AccountRole ||
                    AccountRole.Equals(input.AccountRole)
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
                    CurrencySymbol == input.CurrencySymbol ||
					CurrencySymbol.Equals(input.CurrencySymbol)
                ) && 
                (
                    CurrencyDecimalPlaces == input.CurrencyDecimalPlaces ||
                    CurrencyDecimalPlaces.Equals(input.CurrencyDecimalPlaces)
                ) && 
                (
                    CurrentBalance == input.CurrentBalance ||
					CurrentBalance.Equals(input.CurrentBalance)
                ) && 
                (
                    CurrentBalanceDate == input.CurrentBalanceDate ||
					CurrentBalanceDate.Equals(input.CurrentBalanceDate)
                ) && 
                (
                    Iban == input.Iban ||
                    (Iban != null &&
                    Iban.Equals(input.Iban))
                ) && 
                (
                    Bic == input.Bic ||
                    (Bic != null &&
                    Bic.Equals(input.Bic))
                ) && 
                (
                    AccountNumber == input.AccountNumber ||
                    (AccountNumber != null &&
                    AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    OpeningBalance == input.OpeningBalance ||
					OpeningBalance.Equals(input.OpeningBalance)
                ) && 
                (
                    CurrentDebt == input.CurrentDebt ||
                    (CurrentDebt != null &&
                    CurrentDebt.Equals(input.CurrentDebt))
                ) && 
                (
                    OpeningBalanceDate == input.OpeningBalanceDate ||
                    (OpeningBalanceDate != null &&
                    OpeningBalanceDate.Equals(input.OpeningBalanceDate))
                ) && 
                (
                    VirtualBalance == input.VirtualBalance ||
					VirtualBalance.Equals(input.VirtualBalance)
                ) && 
                (
                    IncludeNetWorth == input.IncludeNetWorth ||
                    IncludeNetWorth.Equals(input.IncludeNetWorth)
                ) && 
                (
                    CreditCardType == input.CreditCardType ||
                    CreditCardType.Equals(input.CreditCardType)
                ) && 
                (
                    MonthlyPaymentDate == input.MonthlyPaymentDate ||
                    (MonthlyPaymentDate != null &&
                    MonthlyPaymentDate.Equals(input.MonthlyPaymentDate))
                ) && 
                (
                    LiabilityType == input.LiabilityType ||
                    LiabilityType.Equals(input.LiabilityType)
                ) && 
                (
                    LiabilityDirection == input.LiabilityDirection ||
                    LiabilityDirection.Equals(input.LiabilityDirection)
                ) && 
                (
                    Interest == input.Interest ||
                    (Interest != null &&
                    Interest.Equals(input.Interest))
                ) && 
                (
                    InterestPeriod == input.InterestPeriod ||
                    InterestPeriod.Equals(input.InterestPeriod)
                ) && 
                (
                    Notes == input.Notes ||
                    (Notes != null &&
                    Notes.Equals(input.Notes))
                ) && 
                (
                    Latitude == input.Latitude ||
                    (Latitude != null &&
                    Latitude.Equals(input.Latitude))
                ) && 
                (
                    Longitude == input.Longitude ||
                    (Longitude != null &&
                    Longitude.Equals(input.Longitude))
                ) && 
                (
                    ZoomLevel == input.ZoomLevel ||
                    (ZoomLevel != null &&
                    ZoomLevel.Equals(input.ZoomLevel))
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
                hashCode = (hashCode * 59) + Active.GetHashCode();
                if (Order != null)
                {
                    hashCode = (hashCode * 59) + Order.GetHashCode();
                }
				hashCode = (hashCode * 59) + Name.GetHashCode();
                hashCode = (hashCode * 59) + Type.GetHashCode();
                hashCode = (hashCode * 59) + AccountRole.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyId.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyCode.GetHashCode();
				hashCode = (hashCode * 59) + CurrencySymbol.GetHashCode();
                hashCode = (hashCode * 59) + CurrencyDecimalPlaces.GetHashCode();
				hashCode = (hashCode * 59) + CurrentBalance.GetHashCode();
				hashCode = (hashCode * 59) + CurrentBalanceDate.GetHashCode();
                if (Iban != null)
                {
                    hashCode = (hashCode * 59) + Iban.GetHashCode();
                }
                if (Bic != null)
                {
                    hashCode = (hashCode * 59) + Bic.GetHashCode();
                }
                if (AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + AccountNumber.GetHashCode();
                }
				hashCode = (hashCode * 59) + OpeningBalance.GetHashCode();
                if (CurrentDebt != null)
                {
                    hashCode = (hashCode * 59) + CurrentDebt.GetHashCode();
                }
                if (OpeningBalanceDate != null)
                {
                    hashCode = (hashCode * 59) + OpeningBalanceDate.GetHashCode();
                }
				hashCode = (hashCode * 59) + VirtualBalance.GetHashCode();
                hashCode = (hashCode * 59) + IncludeNetWorth.GetHashCode();
                hashCode = (hashCode * 59) + CreditCardType.GetHashCode();
                if (MonthlyPaymentDate != null)
                {
                    hashCode = (hashCode * 59) + MonthlyPaymentDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + LiabilityType.GetHashCode();
                hashCode = (hashCode * 59) + LiabilityDirection.GetHashCode();
                if (Interest != null)
                {
                    hashCode = (hashCode * 59) + Interest.GetHashCode();
                }
                hashCode = (hashCode * 59) + InterestPeriod.GetHashCode();
                if (Notes != null)
                {
                    hashCode = (hashCode * 59) + Notes.GetHashCode();
                }
                if (Latitude != null)
                {
                    hashCode = (hashCode * 59) + Latitude.GetHashCode();
                }
                if (Longitude != null)
                {
                    hashCode = (hashCode * 59) + Longitude.GetHashCode();
                }
                if (ZoomLevel != null)
                {
                    hashCode = (hashCode * 59) + ZoomLevel.GetHashCode();
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
