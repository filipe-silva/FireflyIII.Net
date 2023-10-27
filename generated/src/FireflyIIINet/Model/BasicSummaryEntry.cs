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
    /// BasicSummaryEntry
    /// </summary>
    [DataContract(Name = "BasicSummaryEntry")]
    public partial class BasicSummaryEntry : IEquatable<BasicSummaryEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicSummaryEntry" /> class.
        /// </summary>
        /// <param name="key">This is a reference to the type of info shared, not influenced by translations or user preferences. The EUR value is a reference to the currency code. Possibilities are: balance-in-ABC, spent-in-ABC, earned-in-ABC, bills-paid-in-ABC, bills-unpaid-in-ABC, left-to-spend-in-ABC and net-worth-in-ABC..</param>
        /// <param name="title">A translated title for the information shared..</param>
        /// <param name="monetaryValue">The amount as a float..</param>
        /// <param name="currencyId">The currency ID of the associated currency..</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="currencySymbol">currencySymbol.</param>
        /// <param name="currencyDecimalPlaces">Number of decimals for the associated currency..</param>
        /// <param name="valueParsed">The amount formatted according to the users locale.</param>
        /// <param name="localIcon">Reference to a font-awesome icon without the fa- part..</param>
        /// <param name="subTitle">A short explanation of the amounts origin. Already formatted according to the locale of the user or translated, if relevant..</param>
        public BasicSummaryEntry(string key = default(string), string title = default(string), double monetaryValue = default(double), string currencyId = default(string), string currencyCode = default(string), string currencySymbol = default(string), int currencyDecimalPlaces = default(int), string valueParsed = default(string), string localIcon = default(string), string subTitle = default(string))
        {
            this.Key = key;
            this.Title = title;
            this.MonetaryValue = monetaryValue;
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
            this.CurrencySymbol = currencySymbol;
            this.CurrencyDecimalPlaces = currencyDecimalPlaces;
            this.ValueParsed = valueParsed;
            this.LocalIcon = localIcon;
            this.SubTitle = subTitle;
        }

        /// <summary>
        /// This is a reference to the type of info shared, not influenced by translations or user preferences. The EUR value is a reference to the currency code. Possibilities are: balance-in-ABC, spent-in-ABC, earned-in-ABC, bills-paid-in-ABC, bills-unpaid-in-ABC, left-to-spend-in-ABC and net-worth-in-ABC.
        /// </summary>
        /// <value>This is a reference to the type of info shared, not influenced by translations or user preferences. The EUR value is a reference to the currency code. Possibilities are: balance-in-ABC, spent-in-ABC, earned-in-ABC, bills-paid-in-ABC, bills-unpaid-in-ABC, left-to-spend-in-ABC and net-worth-in-ABC.</value>
        /// <example>balance-in-EUR</example>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// A translated title for the information shared.
        /// </summary>
        /// <value>A translated title for the information shared.</value>
        /// <example>Balance ($)</example>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The amount as a float.
        /// </summary>
        /// <value>The amount as a float.</value>
        /// <example>123.45</example>
        [DataMember(Name = "monetary_value", EmitDefaultValue = false)]
        public double MonetaryValue { get; set; }

        /// <summary>
        /// The currency ID of the associated currency.
        /// </summary>
        /// <value>The currency ID of the associated currency.</value>
        /// <example>5</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = false)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "currency_symbol", EmitDefaultValue = false)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Number of decimals for the associated currency.
        /// </summary>
        /// <value>Number of decimals for the associated currency.</value>
        /// <example>2</example>
        [DataMember(Name = "currency_decimal_places", EmitDefaultValue = false)]
        public int CurrencyDecimalPlaces { get; set; }

        /// <summary>
        /// The amount formatted according to the users locale
        /// </summary>
        /// <value>The amount formatted according to the users locale</value>
        /// <example>$ 12.45</example>
        [DataMember(Name = "value_parsed", EmitDefaultValue = false)]
        public string ValueParsed { get; set; }

        /// <summary>
        /// Reference to a font-awesome icon without the fa- part.
        /// </summary>
        /// <value>Reference to a font-awesome icon without the fa- part.</value>
        /// <example>balance-scale</example>
        [DataMember(Name = "local_icon", EmitDefaultValue = false)]
        public string LocalIcon { get; set; }

        /// <summary>
        /// A short explanation of the amounts origin. Already formatted according to the locale of the user or translated, if relevant.
        /// </summary>
        /// <value>A short explanation of the amounts origin. Already formatted according to the locale of the user or translated, if relevant.</value>
        /// <example>$20 + $-40</example>
        [DataMember(Name = "sub_title", EmitDefaultValue = false)]
        public string SubTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BasicSummaryEntry {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  MonetaryValue: ").Append(MonetaryValue).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  ValueParsed: ").Append(ValueParsed).Append("\n");
            sb.Append("  LocalIcon: ").Append(LocalIcon).Append("\n");
            sb.Append("  SubTitle: ").Append(SubTitle).Append("\n");
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
            return this.Equals(input as BasicSummaryEntry);
        }

        /// <summary>
        /// Returns true if BasicSummaryEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of BasicSummaryEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasicSummaryEntry input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.MonetaryValue == input.MonetaryValue ||
                    this.MonetaryValue.Equals(input.MonetaryValue)
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
                    this.ValueParsed == input.ValueParsed ||
                    (this.ValueParsed != null &&
                    this.ValueParsed.Equals(input.ValueParsed))
                ) && 
                (
                    this.LocalIcon == input.LocalIcon ||
                    (this.LocalIcon != null &&
                    this.LocalIcon.Equals(input.LocalIcon))
                ) && 
                (
                    this.SubTitle == input.SubTitle ||
                    (this.SubTitle != null &&
                    this.SubTitle.Equals(input.SubTitle))
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
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MonetaryValue.GetHashCode();
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
                if (this.ValueParsed != null)
                {
                    hashCode = (hashCode * 59) + this.ValueParsed.GetHashCode();
                }
                if (this.LocalIcon != null)
                {
                    hashCode = (hashCode * 59) + this.LocalIcon.GetHashCode();
                }
                if (this.SubTitle != null)
                {
                    hashCode = (hashCode * 59) + this.SubTitle.GetHashCode();
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
