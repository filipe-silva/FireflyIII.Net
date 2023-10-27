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
    /// CurrencyUpdate
    /// </summary>
    [DataContract(Name = "CurrencyUpdate")]
    public partial class CurrencyUpdate : IEquatable<CurrencyUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyUpdate" /> class.
        /// </summary>
        /// <param name="enabled">If the currency is enabled.</param>
        /// <param name="varDefault">If the currency must be the default for the user. You can only submit TRUE..</param>
        /// <param name="code">The currency code.</param>
        /// <param name="name">The currency name.</param>
        /// <param name="symbol">The currency symbol.</param>
        /// <param name="decimalPlaces">How many decimals to use when displaying this currency. Between 0 and 16..</param>
        public CurrencyUpdate(bool enabled = default(bool), bool varDefault = default(bool), string code = default(string), string name = default(string), string symbol = default(string), int decimalPlaces = default(int))
        {
            this.Enabled = enabled;
            this.VarDefault = varDefault;
            this.Code = code;
            this.Name = name;
            this.Symbol = symbol;
            this.DecimalPlaces = decimalPlaces;
        }

        /// <summary>
        /// If the currency is enabled
        /// </summary>
        /// <value>If the currency is enabled</value>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// If the currency must be the default for the user. You can only submit TRUE.
        /// </summary>
        /// <value>If the currency must be the default for the user. You can only submit TRUE.</value>
        /// <example>true</example>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public bool VarDefault { get; set; }

        /// <summary>
        /// The currency code
        /// </summary>
        /// <value>The currency code</value>
        /// <example>AMS</example>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The currency name
        /// </summary>
        /// <value>The currency name</value>
        /// <example>Ankh-Morpork dollar</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The currency symbol
        /// </summary>
        /// <value>The currency symbol</value>
        /// <example>AM$</example>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// How many decimals to use when displaying this currency. Between 0 and 16.
        /// </summary>
        /// <value>How many decimals to use when displaying this currency. Between 0 and 16.</value>
        /// <example>2</example>
        [DataMember(Name = "decimal_places", EmitDefaultValue = false)]
        public int DecimalPlaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CurrencyUpdate {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  VarDefault: ").Append(VarDefault).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
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
            return this.Equals(input as CurrencyUpdate);
        }

        /// <summary>
        /// Returns true if CurrencyUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrencyUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.VarDefault == input.VarDefault ||
                    this.VarDefault.Equals(input.VarDefault)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.DecimalPlaces == input.DecimalPlaces ||
                    this.DecimalPlaces.Equals(input.DecimalPlaces)
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
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                hashCode = (hashCode * 59) + this.VarDefault.GetHashCode();
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DecimalPlaces.GetHashCode();
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
