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
    /// CurrencyStore
    /// </summary>
    [DataContract(Name = "CurrencyStore")]
    public partial class CurrencyStore : IEquatable<CurrencyStore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CurrencyStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyStore" /> class.
        /// </summary>
        /// <param name="enabled">Defaults to true (default to true).</param>
        /// <param name="varDefault">Make this currency the default currency..</param>
        /// <param name="code">code (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="symbol">symbol (required).</param>
        /// <param name="decimalPlaces">Supports 0-16 decimals..</param>
        public CurrencyStore(bool enabled = true, bool varDefault = default(bool), string code = default(string), string name = default(string), string symbol = default(string), int decimalPlaces = default(int))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for CurrencyStore and cannot be null");
            }
            this.Code = code;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CurrencyStore and cannot be null");
            }
            this.Name = name;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for CurrencyStore and cannot be null");
            }
            this.Symbol = symbol;
            this.Enabled = enabled;
            this.VarDefault = varDefault;
            this.DecimalPlaces = decimalPlaces;
        }

        /// <summary>
        /// Defaults to true
        /// </summary>
        /// <value>Defaults to true</value>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Make this currency the default currency.
        /// </summary>
        /// <value>Make this currency the default currency.</value>
        /// <example>false</example>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public bool VarDefault { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        /// <example>AMS</example>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>Ankh-Morpork dollar</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        /// <example>AM$</example>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Supports 0-16 decimals.
        /// </summary>
        /// <value>Supports 0-16 decimals.</value>
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
            sb.Append("class CurrencyStore {\n");
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
            return this.Equals(input as CurrencyStore);
        }

        /// <summary>
        /// Returns true if CurrencyStore instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrencyStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyStore input)
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
