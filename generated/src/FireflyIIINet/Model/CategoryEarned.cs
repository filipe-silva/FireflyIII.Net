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
    /// CategoryEarned
    /// </summary>
    [DataContract(Name = "CategoryEarned")]
    public partial class CategoryEarned : IEquatable<CategoryEarned>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryEarned" /> class.
        /// </summary>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="currencySymbol">currencySymbol.</param>
        /// <param name="currencyDecimalPlaces">Number of decimals supported by the currency.</param>
        /// <param name="sum">The amount earned..</param>
        public CategoryEarned(string currencyId = default(string), string currencyCode = default(string), string currencySymbol = default(string), int currencyDecimalPlaces = default(int), string sum = default(string))
        {
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
            this.CurrencySymbol = currencySymbol;
            this.CurrencyDecimalPlaces = currencyDecimalPlaces;
            this.Sum = sum;
        }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = false)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "currency_symbol", EmitDefaultValue = false)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Number of decimals supported by the currency
        /// </summary>
        /// <value>Number of decimals supported by the currency</value>
        /// <example>2</example>
        [DataMember(Name = "currency_decimal_places", EmitDefaultValue = false)]
        public int CurrencyDecimalPlaces { get; set; }

        /// <summary>
        /// The amount earned.
        /// </summary>
        /// <value>The amount earned.</value>
        /// <example>123.45</example>
        [DataMember(Name = "sum", EmitDefaultValue = false)]
        public string Sum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CategoryEarned {\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
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
            return this.Equals(input as CategoryEarned);
        }

        /// <summary>
        /// Returns true if CategoryEarned instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoryEarned to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryEarned input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Sum == input.Sum ||
                    (this.Sum != null &&
                    this.Sum.Equals(input.Sum))
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
                if (this.Sum != null)
                {
                    hashCode = (hashCode * 59) + this.Sum.GetHashCode();
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
