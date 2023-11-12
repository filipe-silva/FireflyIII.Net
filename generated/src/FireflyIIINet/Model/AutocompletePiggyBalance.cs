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
    /// AutocompletePiggyBalance
    /// </summary>
    [DataContract(Name = "AutocompletePiggyBalance")]
    public partial class AutocompletePiggyBalance : IEquatable<AutocompletePiggyBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompletePiggyBalance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutocompletePiggyBalance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompletePiggyBalance" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">Name of the piggy bank found by an auto-complete search. (required).</param>
        /// <param name="nameWithBalance">Name of the piggy bank found by an auto-complete search with the current balance formatted nicely..</param>
        /// <param name="currencyId">Currency ID for this piggy bank..</param>
        /// <param name="currencyCode">Currency code for this piggy bank..</param>
        /// <param name="currencySymbol">currencySymbol.</param>
        /// <param name="currencyDecimalPlaces">currencyDecimalPlaces.</param>
        /// <param name="objectGroupId">The group ID of the group this object is part of. NULL if no group..</param>
        /// <param name="objectGroupTitle">The name of the group. NULL if no group..</param>
        public AutocompletePiggyBalance(string id = default(string), string name = default(string), string nameWithBalance = default(string), string currencyId = default(string), string currencyCode = default(string), string currencySymbol = default(string), int currencyDecimalPlaces = default(int), string objectGroupId = default(string), string objectGroupTitle = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AutocompletePiggyBalance and cannot be null");
            }
            Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AutocompletePiggyBalance and cannot be null");
            }
            Name = name;
            NameWithBalance = nameWithBalance;
            CurrencyId = currencyId;
            CurrencyCode = currencyCode;
            CurrencySymbol = currencySymbol;
            CurrencyDecimalPlaces = currencyDecimalPlaces;
            ObjectGroupId = objectGroupId;
            ObjectGroupTitle = objectGroupTitle;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the piggy bank found by an auto-complete search.
        /// </summary>
        /// <value>Name of the piggy bank found by an auto-complete search.</value>
        /// <example>New couch</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the piggy bank found by an auto-complete search with the current balance formatted nicely.
        /// </summary>
        /// <value>Name of the piggy bank found by an auto-complete search with the current balance formatted nicely.</value>
        /// <example>New couch ($ 12.34)</example>
        [DataMember(Name = "name_with_balance", EmitDefaultValue = true)]
        public string NameWithBalance { get; set; }

        /// <summary>
        /// Currency ID for this piggy bank.
        /// </summary>
        /// <value>Currency ID for this piggy bank.</value>
        /// <example>12</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Currency code for this piggy bank.
        /// </summary>
        /// <value>Currency code for this piggy bank.</value>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "currency_symbol", EmitDefaultValue = true)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyDecimalPlaces
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "currency_decimal_places", EmitDefaultValue = true)]
        public int CurrencyDecimalPlaces { get; set; }

        /// <summary>
        /// The group ID of the group this object is part of. NULL if no group.
        /// </summary>
        /// <value>The group ID of the group this object is part of. NULL if no group.</value>
        /// <example>5</example>
        [DataMember(Name = "object_group_id", EmitDefaultValue = false)]
        public string ObjectGroupId { get; set; }

        /// <summary>
        /// The name of the group. NULL if no group.
        /// </summary>
        /// <value>The name of the group. NULL if no group.</value>
        /// <example>Example Group</example>
        [DataMember(Name = "object_group_title", EmitDefaultValue = false)]
        public string ObjectGroupTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutocompletePiggyBalance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameWithBalance: ").Append(NameWithBalance).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  ObjectGroupId: ").Append(ObjectGroupId).Append("\n");
            sb.Append("  ObjectGroupTitle: ").Append(ObjectGroupTitle).Append("\n");
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
            return Equals(input as AutocompletePiggyBalance);
        }

        /// <summary>
        /// Returns true if AutocompletePiggyBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of AutocompletePiggyBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutocompletePiggyBalance input)
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
                    NameWithBalance == input.NameWithBalance ||
					NameWithBalance.Equals(input.NameWithBalance)
                ) && 
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
                    ObjectGroupId == input.ObjectGroupId ||
                    (ObjectGroupId != null &&
                    ObjectGroupId.Equals(input.ObjectGroupId))
                ) && 
                (
                    ObjectGroupTitle == input.ObjectGroupTitle ||
                    (ObjectGroupTitle != null &&
                    ObjectGroupTitle.Equals(input.ObjectGroupTitle))
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
				hashCode = (hashCode * 59) + NameWithBalance.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyId.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyCode.GetHashCode();
				hashCode = (hashCode * 59) + CurrencySymbol.GetHashCode();
                hashCode = (hashCode * 59) + CurrencyDecimalPlaces.GetHashCode();
                if (ObjectGroupId != null)
                {
                    hashCode = (hashCode * 59) + ObjectGroupId.GetHashCode();
                }
                if (ObjectGroupTitle != null)
                {
                    hashCode = (hashCode * 59) + ObjectGroupTitle.GetHashCode();
                }
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
