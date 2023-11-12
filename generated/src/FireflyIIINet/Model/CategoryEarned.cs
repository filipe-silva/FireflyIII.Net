/*
 * Firefly III API v2.0.2
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-05-17T04:54:43+00:00 
 *
 * The version of the OpenAPI document: 2.0.2
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
            CurrencyId = currencyId;
            CurrencyCode = currencyCode;
            CurrencySymbol = currencySymbol;
            CurrencyDecimalPlaces = currencyDecimalPlaces;
            Sum = sum;
        }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "currency_symbol", EmitDefaultValue = true)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Number of decimals supported by the currency
        /// </summary>
        /// <value>Number of decimals supported by the currency</value>
        /// <example>2</example>
        [DataMember(Name = "currency_decimal_places", EmitDefaultValue = true)]
        public int CurrencyDecimalPlaces { get; set; }

        /// <summary>
        /// The amount earned.
        /// </summary>
        /// <value>The amount earned.</value>
        /// <example>123.45</example>
        [DataMember(Name = "sum", EmitDefaultValue = true)]
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CategoryEarned);
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
                    Sum == input.Sum ||
					Sum.Equals(input.Sum)
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
				hashCode = (hashCode * 59) + CurrencyId.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyCode.GetHashCode();
				hashCode = (hashCode * 59) + CurrencySymbol.GetHashCode();
                hashCode = (hashCode * 59) + CurrencyDecimalPlaces.GetHashCode();
				hashCode = (hashCode * 59) + Sum.GetHashCode();
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
