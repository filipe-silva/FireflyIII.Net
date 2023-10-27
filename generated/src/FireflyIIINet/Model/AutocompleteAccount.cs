/*
 * Firefly III API v1.5.3
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2021-09-19T08:24:18+00:00 
 *
 * The version of the OpenAPI document: 1.5.3
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
    /// AutocompleteAccount
    /// </summary>
    [DataContract(Name = "AutocompleteAccount")]
    public partial class AutocompleteAccount : IEquatable<AutocompleteAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutocompleteAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteAccount" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">Name of the account found by an auto-complete search. (required).</param>
        /// <param name="nameWithBalance">Asset accounts and liabilities have a second field with the given date&#39;s account balance. (required).</param>
        /// <param name="type">Account type of the account found by the auto-complete search. (required).</param>
        /// <param name="currencyId">ID for the currency used by this account. (required).</param>
        /// <param name="currencyName">Currency name for the currency used by this account. (required).</param>
        /// <param name="currencyCode">Currency code for the currency used by this account. (required).</param>
        /// <param name="currencySymbol">Currency symbol for the currency used by this account. (required).</param>
        /// <param name="currencyDecimalPlaces">Number of decimal places for the currency used by this account. (required).</param>
        public AutocompleteAccount(string id = default(string), string name = default(string), string nameWithBalance = default(string), string type = default(string), string currencyId = default(string), string currencyName = default(string), string currencyCode = default(string), string currencySymbol = default(string), int currencyDecimalPlaces = default(int))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AutocompleteAccount and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AutocompleteAccount and cannot be null");
            }
            this.Name = name;
            // to ensure "nameWithBalance" is required (not null)
            if (nameWithBalance == null)
            {
                throw new ArgumentNullException("nameWithBalance is a required property for AutocompleteAccount and cannot be null");
            }
            this.NameWithBalance = nameWithBalance;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for AutocompleteAccount and cannot be null");
            }
            this.Type = type;
            // to ensure "currencyId" is required (not null)
            if (currencyId == null)
            {
                throw new ArgumentNullException("currencyId is a required property for AutocompleteAccount and cannot be null");
            }
            this.CurrencyId = currencyId;
            // to ensure "currencyName" is required (not null)
            if (currencyName == null)
            {
                throw new ArgumentNullException("currencyName is a required property for AutocompleteAccount and cannot be null");
            }
            this.CurrencyName = currencyName;
            // to ensure "currencyCode" is required (not null)
            if (currencyCode == null)
            {
                throw new ArgumentNullException("currencyCode is a required property for AutocompleteAccount and cannot be null");
            }
            this.CurrencyCode = currencyCode;
            // to ensure "currencySymbol" is required (not null)
            if (currencySymbol == null)
            {
                throw new ArgumentNullException("currencySymbol is a required property for AutocompleteAccount and cannot be null");
            }
            this.CurrencySymbol = currencySymbol;
            this.CurrencyDecimalPlaces = currencyDecimalPlaces;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the account found by an auto-complete search.
        /// </summary>
        /// <value>Name of the account found by an auto-complete search.</value>
        /// <example>Checking Account</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Asset accounts and liabilities have a second field with the given date&#39;s account balance.
        /// </summary>
        /// <value>Asset accounts and liabilities have a second field with the given date&#39;s account balance.</value>
        /// <example>Checking Account ($123.45)</example>
        [DataMember(Name = "name_with_balance", IsRequired = true, EmitDefaultValue = true)]
        public string NameWithBalance { get; set; }

        /// <summary>
        /// Account type of the account found by the auto-complete search.
        /// </summary>
        /// <value>Account type of the account found by the auto-complete search.</value>
        /// <example>Asset account</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// ID for the currency used by this account.
        /// </summary>
        /// <value>ID for the currency used by this account.</value>
        /// <example>12</example>
        [DataMember(Name = "currency_id", IsRequired = true, EmitDefaultValue = true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Currency name for the currency used by this account.
        /// </summary>
        /// <value>Currency name for the currency used by this account.</value>
        /// <example>Euro</example>
        [DataMember(Name = "currency_name", IsRequired = true, EmitDefaultValue = true)]
        public string CurrencyName { get; set; }

        /// <summary>
        /// Currency code for the currency used by this account.
        /// </summary>
        /// <value>Currency code for the currency used by this account.</value>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", IsRequired = true, EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Currency symbol for the currency used by this account.
        /// </summary>
        /// <value>Currency symbol for the currency used by this account.</value>
        /// <example>$</example>
        [DataMember(Name = "currency_symbol", IsRequired = true, EmitDefaultValue = true)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Number of decimal places for the currency used by this account.
        /// </summary>
        /// <value>Number of decimal places for the currency used by this account.</value>
        /// <example>2</example>
        [DataMember(Name = "currency_decimal_places", IsRequired = true, EmitDefaultValue = true)]
        public int CurrencyDecimalPlaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutocompleteAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameWithBalance: ").Append(NameWithBalance).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyName: ").Append(CurrencyName).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
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
            return this.Equals(input as AutocompleteAccount);
        }

        /// <summary>
        /// Returns true if AutocompleteAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of AutocompleteAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutocompleteAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NameWithBalance == input.NameWithBalance ||
                    (this.NameWithBalance != null &&
                    this.NameWithBalance.Equals(input.NameWithBalance))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.CurrencyName == input.CurrencyName ||
                    (this.CurrencyName != null &&
                    this.CurrencyName.Equals(input.CurrencyName))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NameWithBalance != null)
                {
                    hashCode = (hashCode * 59) + this.NameWithBalance.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.CurrencyId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyId.GetHashCode();
                }
                if (this.CurrencyName != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyName.GetHashCode();
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
