/*
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 1.4.0
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
    /// ExchangeRateAttributes
    /// </summary>
    [DataContract(Name = "ExchangeRate_attributes")]
    public partial class ExchangeRateAttributes : IEquatable<ExchangeRateAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRateAttributes" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="fromCurrencyId">fromCurrencyId.</param>
        /// <param name="fromCurrencyName">fromCurrencyName.</param>
        /// <param name="fromCurrencyCode">fromCurrencyCode.</param>
        /// <param name="fromCurrencySymbol">fromCurrencySymbol.</param>
        /// <param name="fromCurrencyDecimalPlaces">fromCurrencyDecimalPlaces.</param>
        /// <param name="toCurrencyId">toCurrencyId.</param>
        /// <param name="toCurrencyCode">toCurrencyCode.</param>
        /// <param name="toCurrencySymbol">toCurrencySymbol.</param>
        /// <param name="toCurrencyDecimalPlaces">toCurrencyDecimalPlaces.</param>
        /// <param name="date">date.</param>
        /// <param name="rate">rate.</param>
        /// <param name="amount">The amount in the \&quot;to\&quot;-currency, if provided in the request..</param>
        public ExchangeRateAttributes(DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), int fromCurrencyId = default(int), string fromCurrencyName = default(string), string fromCurrencyCode = default(string), string fromCurrencySymbol = default(string), int fromCurrencyDecimalPlaces = default(int), int toCurrencyId = default(int), string toCurrencyCode = default(string), string toCurrencySymbol = default(string), int toCurrencyDecimalPlaces = default(int), DateTime date = default(DateTime), float rate = default(float), string amount = default(string))
        {
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FromCurrencyId = fromCurrencyId;
            this.FromCurrencyName = fromCurrencyName;
            this.FromCurrencyCode = fromCurrencyCode;
            this.FromCurrencySymbol = fromCurrencySymbol;
            this.FromCurrencyDecimalPlaces = fromCurrencyDecimalPlaces;
            this.ToCurrencyId = toCurrencyId;
            this.ToCurrencyCode = toCurrencyCode;
            this.ToCurrencySymbol = toCurrencySymbol;
            this.ToCurrencyDecimalPlaces = toCurrencyDecimalPlaces;
            this.Date = date;
            this.Rate = rate;
            this.Amount = amount;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets FromCurrencyId
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "from_currency_id", EmitDefaultValue = false)]
        public int FromCurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets FromCurrencyName
        /// </summary>
        /// <example>Euro</example>
        [DataMember(Name = "from_currency_name", EmitDefaultValue = false)]
        public string FromCurrencyName { get; set; }

        /// <summary>
        /// Gets or Sets FromCurrencyCode
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "from_currency_code", EmitDefaultValue = false)]
        public string FromCurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets FromCurrencySymbol
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "from_currency_symbol", EmitDefaultValue = false)]
        public string FromCurrencySymbol { get; set; }

        /// <summary>
        /// Gets or Sets FromCurrencyDecimalPlaces
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "from_currency_decimal_places", EmitDefaultValue = false)]
        public int FromCurrencyDecimalPlaces { get; set; }

        /// <summary>
        /// Gets or Sets ToCurrencyId
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "to_currency_id", EmitDefaultValue = false)]
        public int ToCurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets ToCurrencyCode
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "to_currency_code", EmitDefaultValue = false)]
        public string ToCurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets ToCurrencySymbol
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "to_currency_symbol", EmitDefaultValue = false)]
        public string ToCurrencySymbol { get; set; }

        /// <summary>
        /// Gets or Sets ToCurrencyDecimalPlaces
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "to_currency_decimal_places", EmitDefaultValue = false)]
        public int ToCurrencyDecimalPlaces { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        /// <example>Mon Sep 17 01:00:00 WEST 2018</example>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        /// <example>1.1213</example>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public float Rate { get; set; }

        /// <summary>
        /// The amount in the \&quot;to\&quot;-currency, if provided in the request.
        /// </summary>
        /// <value>The amount in the \&quot;to\&quot;-currency, if provided in the request.</value>
        /// <example>123.45</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExchangeRateAttributes {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  FromCurrencyId: ").Append(FromCurrencyId).Append("\n");
            sb.Append("  FromCurrencyName: ").Append(FromCurrencyName).Append("\n");
            sb.Append("  FromCurrencyCode: ").Append(FromCurrencyCode).Append("\n");
            sb.Append("  FromCurrencySymbol: ").Append(FromCurrencySymbol).Append("\n");
            sb.Append("  FromCurrencyDecimalPlaces: ").Append(FromCurrencyDecimalPlaces).Append("\n");
            sb.Append("  ToCurrencyId: ").Append(ToCurrencyId).Append("\n");
            sb.Append("  ToCurrencyCode: ").Append(ToCurrencyCode).Append("\n");
            sb.Append("  ToCurrencySymbol: ").Append(ToCurrencySymbol).Append("\n");
            sb.Append("  ToCurrencyDecimalPlaces: ").Append(ToCurrencyDecimalPlaces).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExchangeRateAttributes);
        }

        /// <summary>
        /// Returns true if ExchangeRateAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeRateAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeRateAttributes input)
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
                    this.FromCurrencyId == input.FromCurrencyId ||
                    this.FromCurrencyId.Equals(input.FromCurrencyId)
                ) && 
                (
                    this.FromCurrencyName == input.FromCurrencyName ||
                    (this.FromCurrencyName != null &&
                    this.FromCurrencyName.Equals(input.FromCurrencyName))
                ) && 
                (
                    this.FromCurrencyCode == input.FromCurrencyCode ||
                    (this.FromCurrencyCode != null &&
                    this.FromCurrencyCode.Equals(input.FromCurrencyCode))
                ) && 
                (
                    this.FromCurrencySymbol == input.FromCurrencySymbol ||
                    (this.FromCurrencySymbol != null &&
                    this.FromCurrencySymbol.Equals(input.FromCurrencySymbol))
                ) && 
                (
                    this.FromCurrencyDecimalPlaces == input.FromCurrencyDecimalPlaces ||
                    this.FromCurrencyDecimalPlaces.Equals(input.FromCurrencyDecimalPlaces)
                ) && 
                (
                    this.ToCurrencyId == input.ToCurrencyId ||
                    this.ToCurrencyId.Equals(input.ToCurrencyId)
                ) && 
                (
                    this.ToCurrencyCode == input.ToCurrencyCode ||
                    (this.ToCurrencyCode != null &&
                    this.ToCurrencyCode.Equals(input.ToCurrencyCode))
                ) && 
                (
                    this.ToCurrencySymbol == input.ToCurrencySymbol ||
                    (this.ToCurrencySymbol != null &&
                    this.ToCurrencySymbol.Equals(input.ToCurrencySymbol))
                ) && 
                (
                    this.ToCurrencyDecimalPlaces == input.ToCurrencyDecimalPlaces ||
                    this.ToCurrencyDecimalPlaces.Equals(input.ToCurrencyDecimalPlaces)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Rate == input.Rate ||
                    this.Rate.Equals(input.Rate)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                hashCode = (hashCode * 59) + this.FromCurrencyId.GetHashCode();
                if (this.FromCurrencyName != null)
                {
                    hashCode = (hashCode * 59) + this.FromCurrencyName.GetHashCode();
                }
                if (this.FromCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.FromCurrencyCode.GetHashCode();
                }
                if (this.FromCurrencySymbol != null)
                {
                    hashCode = (hashCode * 59) + this.FromCurrencySymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FromCurrencyDecimalPlaces.GetHashCode();
                hashCode = (hashCode * 59) + this.ToCurrencyId.GetHashCode();
                if (this.ToCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.ToCurrencyCode.GetHashCode();
                }
                if (this.ToCurrencySymbol != null)
                {
                    hashCode = (hashCode * 59) + this.ToCurrencySymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ToCurrencyDecimalPlaces.GetHashCode();
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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
