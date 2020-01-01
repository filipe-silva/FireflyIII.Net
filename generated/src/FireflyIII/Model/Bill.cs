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
    /// Bill
    /// </summary>
    [DataContract]
    public partial class Bill :  IEquatable<Bill>, IValidatableObject
    {
        /// <summary>
        /// How often the bill must be paid.
        /// </summary>
        /// <value>How often the bill must be paid.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RepeatFreqEnum
        {
            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 1,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 2,

            /// <summary>
            /// Enum Quarterly for value: quarterly
            /// </summary>
            [EnumMember(Value = "quarterly")]
            Quarterly = 3,

            /// <summary>
            /// Enum HalfYear for value: half-year
            /// </summary>
            [EnumMember(Value = "half-year")]
            HalfYear = 4,

            /// <summary>
            /// Enum Yearly for value: yearly
            /// </summary>
            [EnumMember(Value = "yearly")]
            Yearly = 5

        }

        /// <summary>
        /// How often the bill must be paid.
        /// </summary>
        /// <value>How often the bill must be paid.</value>
        [DataMember(Name="repeat_freq", EmitDefaultValue=true)]
        public RepeatFreqEnum RepeatFreq { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bill" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Bill() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bill" /> class.
        /// </summary>
        /// <param name="currencyId">Use either currency_id or currency_code.</param>
        /// <param name="currencyCode">Use either currency_id or currency_code.</param>
        /// <param name="name">name (required).</param>
        /// <param name="amountMin">amountMin (required).</param>
        /// <param name="amountMax">amountMax (required).</param>
        /// <param name="date">date (required).</param>
        /// <param name="repeatFreq">How often the bill must be paid. (required).</param>
        /// <param name="skip">How often the bill must be skipped. 1 means a bi-monthly bill..</param>
        /// <param name="active">If the bill is active..</param>
        /// <param name="notes">notes.</param>
        public Bill(int currencyId = default(int), string currencyCode = default(string), string name = default(string), double amountMin = default(double), double amountMax = default(double), DateTime date = default(DateTime), RepeatFreqEnum repeatFreq = default(RepeatFreqEnum), int skip = default(int), bool active = default(bool), string notes = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Bill and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "amountMin" is required (not null)
            if (amountMin == null)
            {
                throw new InvalidDataException("amountMin is a required property for Bill and cannot be null");
            }
            else
            {
                this.AmountMin = amountMin;
            }

            // to ensure "amountMax" is required (not null)
            if (amountMax == null)
            {
                throw new InvalidDataException("amountMax is a required property for Bill and cannot be null");
            }
            else
            {
                this.AmountMax = amountMax;
            }

            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for Bill and cannot be null");
            }
            else
            {
                this.Date = date;
            }

            this.RepeatFreq = repeatFreq;
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
            this.Skip = skip;
            this.Active = active;
            this.Notes = notes;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Use either currency_id or currency_code
        /// </summary>
        /// <value>Use either currency_id or currency_code</value>
        [DataMember(Name="currency_id", EmitDefaultValue=false)]
        public int CurrencyId { get; set; }

        /// <summary>
        /// Use either currency_id or currency_code
        /// </summary>
        /// <value>Use either currency_id or currency_code</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        [DataMember(Name="currency_symbol", EmitDefaultValue=false)]
        public string CurrencySymbol { get; private set; }

        /// <summary>
        /// Gets or Sets CurrencyDecimalPlaces
        /// </summary>
        [DataMember(Name="currency_decimal_places", EmitDefaultValue=false)]
        public int CurrencyDecimalPlaces { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AmountMin
        /// </summary>
        [DataMember(Name="amount_min", EmitDefaultValue=true)]
        public double AmountMin { get; set; }

        /// <summary>
        /// Gets or Sets AmountMax
        /// </summary>
        [DataMember(Name="amount_max", EmitDefaultValue=true)]
        public double AmountMax { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// How often the bill must be skipped. 1 means a bi-monthly bill.
        /// </summary>
        /// <value>How often the bill must be skipped. 1 means a bi-monthly bill.</value>
        [DataMember(Name="skip", EmitDefaultValue=false)]
        public int Skip { get; set; }

        /// <summary>
        /// If the bill is active.
        /// </summary>
        /// <value>If the bill is active.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// When the bill is expected to be due.
        /// </summary>
        /// <value>When the bill is expected to be due.</value>
        [DataMember(Name="next_expected_match", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime NextExpectedMatch { get; private set; }

        /// <summary>
        /// Array of future dates when the bill is expected to be paid. Autogenerated.
        /// </summary>
        /// <value>Array of future dates when the bill is expected to be paid. Autogenerated.</value>
        [DataMember(Name="pay_dates", EmitDefaultValue=false)]
        public List<DateTime> PayDates { get; private set; }

        /// <summary>
        /// Array of past transactions when the bill was paid.
        /// </summary>
        /// <value>Array of past transactions when the bill was paid.</value>
        [DataMember(Name="paid_dates", EmitDefaultValue=false)]
        public List<BillPaidDates> PaidDates { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bill {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AmountMin: ").Append(AmountMin).Append("\n");
            sb.Append("  AmountMax: ").Append(AmountMax).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  RepeatFreq: ").Append(RepeatFreq).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  NextExpectedMatch: ").Append(NextExpectedMatch).Append("\n");
            sb.Append("  PayDates: ").Append(PayDates).Append("\n");
            sb.Append("  PaidDates: ").Append(PaidDates).Append("\n");
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
            return this.Equals(input as Bill);
        }

        /// <summary>
        /// Returns true if Bill instances are equal
        /// </summary>
        /// <param name="input">Instance of Bill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bill input)
        {
            if (input == null)
                return false;

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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AmountMin == input.AmountMin ||
                    this.AmountMin.Equals(input.AmountMin)
                ) && 
                (
                    this.AmountMax == input.AmountMax ||
                    this.AmountMax.Equals(input.AmountMax)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.RepeatFreq == input.RepeatFreq ||
                    this.RepeatFreq.Equals(input.RepeatFreq)
                ) && 
                (
                    this.Skip == input.Skip ||
                    this.Skip.Equals(input.Skip)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.NextExpectedMatch == input.NextExpectedMatch ||
                    (this.NextExpectedMatch != null &&
                    this.NextExpectedMatch.Equals(input.NextExpectedMatch))
                ) && 
                (
                    this.PayDates == input.PayDates ||
                    this.PayDates != null &&
                    input.PayDates != null &&
                    this.PayDates.SequenceEqual(input.PayDates)
                ) && 
                (
                    this.PaidDates == input.PaidDates ||
                    this.PaidDates != null &&
                    input.PaidDates != null &&
                    this.PaidDates.SequenceEqual(input.PaidDates)
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
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.CurrencySymbol != null)
                    hashCode = hashCode * 59 + this.CurrencySymbol.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyDecimalPlaces.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.AmountMin.GetHashCode();
                hashCode = hashCode * 59 + this.AmountMax.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                hashCode = hashCode * 59 + this.RepeatFreq.GetHashCode();
                hashCode = hashCode * 59 + this.Skip.GetHashCode();
                hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.NextExpectedMatch != null)
                    hashCode = hashCode * 59 + this.NextExpectedMatch.GetHashCode();
                if (this.PayDates != null)
                    hashCode = hashCode * 59 + this.PayDates.GetHashCode();
                if (this.PaidDates != null)
                    hashCode = hashCode * 59 + this.PaidDates.GetHashCode();
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