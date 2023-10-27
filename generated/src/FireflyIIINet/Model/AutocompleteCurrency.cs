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
    /// AutocompleteCurrency
    /// </summary>
    [DataContract(Name = "AutocompleteCurrency")]
    public partial class AutocompleteCurrency : IEquatable<AutocompleteCurrency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteCurrency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutocompleteCurrency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteCurrency" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">Currency name. (required).</param>
        /// <param name="code">Currency code. (required).</param>
        /// <param name="symbol">symbol (required).</param>
        /// <param name="decimalPlaces">decimalPlaces (required).</param>
        public AutocompleteCurrency(string id = default(string), string name = default(string), string code = default(string), string symbol = default(string), int decimalPlaces = default(int))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AutocompleteCurrency and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AutocompleteCurrency and cannot be null");
            }
            this.Name = name;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for AutocompleteCurrency and cannot be null");
            }
            this.Code = code;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for AutocompleteCurrency and cannot be null");
            }
            this.Symbol = symbol;
            this.DecimalPlaces = decimalPlaces;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Currency name.
        /// </summary>
        /// <value>Currency name.</value>
        /// <example>Currency name</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Currency code.
        /// </summary>
        /// <value>Currency code.</value>
        /// <example>EUR</example>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets DecimalPlaces
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "decimal_places", IsRequired = true, EmitDefaultValue = true)]
        public int DecimalPlaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutocompleteCurrency {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as AutocompleteCurrency);
        }

        /// <summary>
        /// Returns true if AutocompleteCurrency instances are equal
        /// </summary>
        /// <param name="input">Instance of AutocompleteCurrency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutocompleteCurrency input)
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
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
