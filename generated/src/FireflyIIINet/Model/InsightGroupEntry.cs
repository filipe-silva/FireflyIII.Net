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
    /// InsightGroupEntry
    /// </summary>
    [DataContract(Name = "InsightGroupEntry")]
    public partial class InsightGroupEntry : IEquatable<InsightGroupEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightGroupEntry" /> class.
        /// </summary>
        /// <param name="id">This ID is a reference to the original object..</param>
        /// <param name="name">This is the name of the object..</param>
        /// <param name="difference">The amount spent or earned between start date and end date, a number defined as a string, for this object and all asset accounts..</param>
        /// <param name="differenceFloat">The amount spent or earned between start date and end date, a number as a float, for this object and all asset accounts. May have rounding errors..</param>
        /// <param name="currencyId">The currency ID of the expenses listed for this account..</param>
        /// <param name="currencyCode">The currency code of the expenses listed for this account..</param>
        public InsightGroupEntry(string id = default(string), string name = default(string), string difference = default(string), double differenceFloat = default(double), string currencyId = default(string), string currencyCode = default(string))
        {
            Id = id;
            Name = name;
            Difference = difference;
            DifferenceFloat = differenceFloat;
            CurrencyId = currencyId;
            CurrencyCode = currencyCode;
        }

        /// <summary>
        /// This ID is a reference to the original object.
        /// </summary>
        /// <value>This ID is a reference to the original object.</value>
        /// <example>123</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// This is the name of the object.
        /// </summary>
        /// <value>This is the name of the object.</value>
        /// <example>Land lord</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The amount spent or earned between start date and end date, a number defined as a string, for this object and all asset accounts.
        /// </summary>
        /// <value>The amount spent or earned between start date and end date, a number defined as a string, for this object and all asset accounts.</value>
        /// <example>-123.45</example>
        [DataMember(Name = "difference", EmitDefaultValue = true)]
        public string Difference { get; set; }

        /// <summary>
        /// The amount spent or earned between start date and end date, a number as a float, for this object and all asset accounts. May have rounding errors.
        /// </summary>
        /// <value>The amount spent or earned between start date and end date, a number as a float, for this object and all asset accounts. May have rounding errors.</value>
        /// <example>-123.45</example>
        [DataMember(Name = "difference_float", EmitDefaultValue = true)]
        public double DifferenceFloat { get; set; }

        /// <summary>
        /// The currency ID of the expenses listed for this account.
        /// </summary>
        /// <value>The currency ID of the expenses listed for this account.</value>
        /// <example>5</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// The currency code of the expenses listed for this account.
        /// </summary>
        /// <value>The currency code of the expenses listed for this account.</value>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightGroupEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Difference: ").Append(Difference).Append("\n");
            sb.Append("  DifferenceFloat: ").Append(DifferenceFloat).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
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
            return Equals(input as InsightGroupEntry);
        }

        /// <summary>
        /// Returns true if InsightGroupEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightGroupEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightGroupEntry input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Id == input.Id ||
					Id.Equals(input.Id)
                ) && 
                (
                    Name == input.Name ||
					Name.Equals(input.Name)
                ) && 
                (
                    Difference == input.Difference ||
					Difference.Equals(input.Difference)
                ) && 
                (
                    DifferenceFloat == input.DifferenceFloat ||
                    DifferenceFloat.Equals(input.DifferenceFloat)
                ) && 
                (
                    CurrencyId == input.CurrencyId ||
					CurrencyId.Equals(input.CurrencyId)
                ) && 
                (
                    CurrencyCode == input.CurrencyCode ||
					CurrencyCode.Equals(input.CurrencyCode)
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
				hashCode = (hashCode * 59) + Id.GetHashCode();
				hashCode = (hashCode * 59) + Name.GetHashCode();
				hashCode = (hashCode * 59) + Difference.GetHashCode();
                hashCode = (hashCode * 59) + DifferenceFloat.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyId.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyCode.GetHashCode();
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
