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
    /// PiggyBankEvent
    /// </summary>
    [DataContract(Name = "PiggyBankEvent")]
    public partial class PiggyBankEvent : IEquatable<PiggyBankEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PiggyBankEvent" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="currencySymbol">currencySymbol.</param>
        /// <param name="currencyDecimalPlaces">currencyDecimalPlaces.</param>
        /// <param name="amount">amount.</param>
        /// <param name="transactionJournalId">The journal associated with the event..</param>
        /// <param name="transactionGroupId">The transaction group associated with the event..</param>
        public PiggyBankEvent(DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string currencyId = default(string), string currencyCode = default(string), string currencySymbol = default(string), int currencyDecimalPlaces = default(int), string amount = default(string), string transactionJournalId = default(string), string transactionGroupId = default(string))
        {
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
            this.CurrencySymbol = currencySymbol;
            this.CurrencyDecimalPlaces = currencyDecimalPlaces;
            this.Amount = amount;
            this.TransactionJournalId = transactionJournalId;
            this.TransactionGroupId = transactionGroupId;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
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
        /// Gets or Sets CurrencyDecimalPlaces
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "currency_decimal_places", EmitDefaultValue = false)]
        public int CurrencyDecimalPlaces { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// The journal associated with the event.
        /// </summary>
        /// <value>The journal associated with the event.</value>
        /// <example>4291</example>
        [DataMember(Name = "transaction_journal_id", EmitDefaultValue = false)]
        public string TransactionJournalId { get; set; }

        /// <summary>
        /// The transaction group associated with the event.
        /// </summary>
        /// <value>The transaction group associated with the event.</value>
        /// <example>4291</example>
        [DataMember(Name = "transaction_group_id", EmitDefaultValue = false)]
        public string TransactionGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PiggyBankEvent {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TransactionJournalId: ").Append(TransactionJournalId).Append("\n");
            sb.Append("  TransactionGroupId: ").Append(TransactionGroupId).Append("\n");
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
            return this.Equals(input as PiggyBankEvent);
        }

        /// <summary>
        /// Returns true if PiggyBankEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of PiggyBankEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PiggyBankEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.TransactionJournalId == input.TransactionJournalId ||
                    (this.TransactionJournalId != null &&
                    this.TransactionJournalId.Equals(input.TransactionJournalId))
                ) && 
                (
                    this.TransactionGroupId == input.TransactionGroupId ||
                    (this.TransactionGroupId != null &&
                    this.TransactionGroupId.Equals(input.TransactionGroupId))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.TransactionJournalId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionJournalId.GetHashCode();
                }
                if (this.TransactionGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionGroupId.GetHashCode();
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
