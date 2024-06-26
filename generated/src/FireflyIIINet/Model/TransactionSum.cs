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
    /// TransactionSum
    /// </summary>
    [DataContract(Name = "TransactionSum")]
    public partial class TransactionSum : IEquatable<TransactionSum>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSum" /> class.
        /// </summary>
        /// <param name="id">ID of the currency of this sum..</param>
        /// <param name="name">Currency name associated with this sum..</param>
        /// <param name="symbol">Currency symbol associated with this sum..</param>
        /// <param name="code">Currency code associated with this sum..</param>
        /// <param name="decimalPlaces">Number of decimal places for the currency associated with this sum..</param>
        /// <param name="sum">Sum as a string. Can also be negative.</param>
        /// <param name="converted">Indicates if this sum was converted to the user&#39;s native (default) currency. When false, the native_* fields will still be present and filled..</param>
        /// <param name="nativeSum">Sum as a string, expressed in the user&#39;s native (default) currency. Can also be negative.</param>
        /// <param name="nativeId">The ID of the user&#39;s native (default) currency..</param>
        /// <param name="nativeName">The name of the user&#39;s native (default) currency.</param>
        /// <param name="nativeSymbol">Currency symbol associated with this amount..</param>
        /// <param name="nativeCode">The currency code of the user&#39;s native (default) currency..</param>
        /// <param name="nativeDecimalPlaces">Number of decimal places for this currency..</param>
        public TransactionSum(string id = default(string), string name = default(string), string symbol = default(string), string code = default(string), int decimalPlaces = default(int), string sum = default(string), bool converted = default(bool), string nativeSum = default(string), string nativeId = default(string), string nativeName = default(string), string nativeSymbol = default(string), string nativeCode = default(string), int nativeDecimalPlaces = default(int))
        {
            Id = id;
            Name = name;
            Symbol = symbol;
            Code = code;
            DecimalPlaces = decimalPlaces;
            Sum = sum;
            Converted = converted;
            NativeSum = nativeSum;
            NativeId = nativeId;
            NativeName = nativeName;
            NativeSymbol = nativeSymbol;
            NativeCode = nativeCode;
            NativeDecimalPlaces = nativeDecimalPlaces;
        }

        /// <summary>
        /// ID of the currency of this sum.
        /// </summary>
        /// <value>ID of the currency of this sum.</value>
        /// <example>12</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Currency name associated with this sum.
        /// </summary>
        /// <value>Currency name associated with this sum.</value>
        /// <example>Euro</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Currency symbol associated with this sum.
        /// </summary>
        /// <value>Currency symbol associated with this sum.</value>
        /// <example>$</example>
        [DataMember(Name = "symbol", EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Currency code associated with this sum.
        /// </summary>
        /// <value>Currency code associated with this sum.</value>
        /// <example>EUR</example>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Number of decimal places for the currency associated with this sum.
        /// </summary>
        /// <value>Number of decimal places for the currency associated with this sum.</value>
        /// <example>2</example>
        [DataMember(Name = "decimal_places", EmitDefaultValue = true)]
        public int DecimalPlaces { get; set; }

        /// <summary>
        /// Sum as a string. Can also be negative
        /// </summary>
        /// <value>Sum as a string. Can also be negative</value>
        /// <example>12.34</example>
        [DataMember(Name = "sum", EmitDefaultValue = true)]
        public string Sum { get; set; }

        /// <summary>
        /// Indicates if this sum was converted to the user&#39;s native (default) currency. When false, the native_* fields will still be present and filled.
        /// </summary>
        /// <value>Indicates if this sum was converted to the user&#39;s native (default) currency. When false, the native_* fields will still be present and filled.</value>
        /// <example>false</example>
        [DataMember(Name = "converted", EmitDefaultValue = true)]
        public bool Converted { get; set; }

        /// <summary>
        /// Sum as a string, expressed in the user&#39;s native (default) currency. Can also be negative
        /// </summary>
        /// <value>Sum as a string, expressed in the user&#39;s native (default) currency. Can also be negative</value>
        /// <example>12.34</example>
        [DataMember(Name = "native_sum", EmitDefaultValue = true)]
        public string NativeSum { get; set; }

        /// <summary>
        /// The ID of the user&#39;s native (default) currency.
        /// </summary>
        /// <value>The ID of the user&#39;s native (default) currency.</value>
        /// <example>1</example>
        [DataMember(Name = "native_id", EmitDefaultValue = true)]
        public string NativeId { get; set; }

        /// <summary>
        /// The name of the user&#39;s native (default) currency
        /// </summary>
        /// <value>The name of the user&#39;s native (default) currency</value>
        /// <example>US Dollar</example>
        [DataMember(Name = "native_name", EmitDefaultValue = true)]
        public string NativeName { get; set; }

        /// <summary>
        /// Currency symbol associated with this amount.
        /// </summary>
        /// <value>Currency symbol associated with this amount.</value>
        /// <example>$</example>
        [DataMember(Name = "native_symbol", EmitDefaultValue = true)]
        public string NativeSymbol { get; set; }

        /// <summary>
        /// The currency code of the user&#39;s native (default) currency.
        /// </summary>
        /// <value>The currency code of the user&#39;s native (default) currency.</value>
        /// <example>EUR</example>
        [DataMember(Name = "native_code", EmitDefaultValue = true)]
        public string NativeCode { get; set; }

        /// <summary>
        /// Number of decimal places for this currency.
        /// </summary>
        /// <value>Number of decimal places for this currency.</value>
        /// <example>2</example>
        [DataMember(Name = "native_decimal_places", EmitDefaultValue = true)]
        public int NativeDecimalPlaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionSum {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
            sb.Append("  Converted: ").Append(Converted).Append("\n");
            sb.Append("  NativeSum: ").Append(NativeSum).Append("\n");
            sb.Append("  NativeId: ").Append(NativeId).Append("\n");
            sb.Append("  NativeName: ").Append(NativeName).Append("\n");
            sb.Append("  NativeSymbol: ").Append(NativeSymbol).Append("\n");
            sb.Append("  NativeCode: ").Append(NativeCode).Append("\n");
            sb.Append("  NativeDecimalPlaces: ").Append(NativeDecimalPlaces).Append("\n");
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
            return Equals(input as TransactionSum);
        }

        /// <summary>
        /// Returns true if TransactionSum instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionSum to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionSum input)
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
                    Symbol == input.Symbol ||
					Symbol.Equals(input.Symbol)
                ) && 
                (
                    Code == input.Code ||
					Code.Equals(input.Code)
                ) && 
                (
                    DecimalPlaces == input.DecimalPlaces ||
                    DecimalPlaces.Equals(input.DecimalPlaces)
                ) && 
                (
                    Sum == input.Sum ||
					Sum.Equals(input.Sum)
                ) && 
                (
                    Converted == input.Converted ||
                    Converted.Equals(input.Converted)
                ) && 
                (
                    NativeSum == input.NativeSum ||
					NativeSum.Equals(input.NativeSum)
                ) && 
                (
                    NativeId == input.NativeId ||
					NativeId.Equals(input.NativeId)
                ) && 
                (
                    NativeName == input.NativeName ||
					NativeName.Equals(input.NativeName)
                ) && 
                (
                    NativeSymbol == input.NativeSymbol ||
					NativeSymbol.Equals(input.NativeSymbol)
                ) && 
                (
                    NativeCode == input.NativeCode ||
					NativeCode.Equals(input.NativeCode)
                ) && 
                (
                    NativeDecimalPlaces == input.NativeDecimalPlaces ||
                    NativeDecimalPlaces.Equals(input.NativeDecimalPlaces)
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
				hashCode = (hashCode * 59) + Symbol.GetHashCode();
				hashCode = (hashCode * 59) + Code.GetHashCode();
                hashCode = (hashCode * 59) + DecimalPlaces.GetHashCode();
				hashCode = (hashCode * 59) + Sum.GetHashCode();
                hashCode = (hashCode * 59) + Converted.GetHashCode();
				hashCode = (hashCode * 59) + NativeSum.GetHashCode();
				hashCode = (hashCode * 59) + NativeId.GetHashCode();
				hashCode = (hashCode * 59) + NativeName.GetHashCode();
				hashCode = (hashCode * 59) + NativeSymbol.GetHashCode();
				hashCode = (hashCode * 59) + NativeCode.GetHashCode();
                hashCode = (hashCode * 59) + NativeDecimalPlaces.GetHashCode();
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
