/*
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 1.0.2
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
    /// PiggyBank
    /// </summary>
    [DataContract(Name = "PiggyBank")]
    public partial class PiggyBank : IEquatable<PiggyBank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PiggyBank" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PiggyBank() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PiggyBank" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="accountId">The ID of the asset account this piggy bank is connected to. (required).</param>
        /// <param name="targetAmount">targetAmount (required).</param>
        /// <param name="currentAmount">currentAmount.</param>
        /// <param name="startDate">The date you started with this piggy bank..</param>
        /// <param name="targetDate">The date you intend to finish saving money..</param>
        /// <param name="notes">notes.</param>
        public PiggyBank(string name = default(string), int accountId = default(int), double targetAmount = default(double), double currentAmount = default(double), DateTime startDate = default(DateTime), DateTime targetDate = default(DateTime), string notes = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PiggyBank and cannot be null");
            }
            this.Name = name;
            this.AccountId = accountId;
            this.TargetAmount = targetAmount;
            this.CurrentAmount = currentAmount;
            this.StartDate = startDate;
            this.TargetDate = targetDate;
            this.Notes = notes;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>New digital camera</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the asset account this piggy bank is connected to.
        /// </summary>
        /// <value>The ID of the asset account this piggy bank is connected to.</value>
        /// <example>13</example>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = true)]
        public int AccountId { get; set; }

        /// <summary>
        /// The name of the asset account this piggy bank is connected to.
        /// </summary>
        /// <value>The name of the asset account this piggy bank is connected to.</value>
        /// <example>Savings account</example>
        [DataMember(Name = "account_name", EmitDefaultValue = false)]
        public string AccountName { get; private set; }

        /// <summary>
        /// Returns false as AccountName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccountName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = false)]
        public int CurrencyId { get; private set; }

        /// <summary>
        /// Returns false as CurrencyId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrencyId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; private set; }

        /// <summary>
        /// Returns false as CurrencyCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrencyCode()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "currency_symbol", EmitDefaultValue = false)]
        public string CurrencySymbol { get; private set; }

        /// <summary>
        /// Returns false as CurrencySymbol should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrencySymbol()
        {
            return false;
        }
        /// <summary>
        /// Number of decimals supported by the currency
        /// </summary>
        /// <value>Number of decimals supported by the currency</value>
        /// <example>2</example>
        [DataMember(Name = "currency_decimal_places", EmitDefaultValue = false)]
        public int CurrencyDecimalPlaces { get; private set; }

        /// <summary>
        /// Returns false as CurrencyDecimalPlaces should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrencyDecimalPlaces()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TargetAmount
        /// </summary>
        /// <example>800</example>
        [DataMember(Name = "target_amount", IsRequired = true, EmitDefaultValue = true)]
        public double TargetAmount { get; set; }

        /// <summary>
        /// Gets or Sets Percentage
        /// </summary>
        /// <example>12.5</example>
        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        public float Percentage { get; private set; }

        /// <summary>
        /// Returns false as Percentage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePercentage()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrentAmount
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "current_amount", EmitDefaultValue = false)]
        public double CurrentAmount { get; set; }

        /// <summary>
        /// Gets or Sets LeftToSave
        /// </summary>
        /// <example>700</example>
        [DataMember(Name = "left_to_save", EmitDefaultValue = false)]
        public double LeftToSave { get; private set; }

        /// <summary>
        /// Returns false as LeftToSave should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLeftToSave()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SavePerMonth
        /// </summary>
        /// <example>12.45</example>
        [DataMember(Name = "save_per_month", EmitDefaultValue = false)]
        public double SavePerMonth { get; private set; }

        /// <summary>
        /// Returns false as SavePerMonth should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSavePerMonth()
        {
            return false;
        }
        /// <summary>
        /// The date you started with this piggy bank.
        /// </summary>
        /// <value>The date you started with this piggy bank.</value>
        /// <example>Mon Sep 17 01:00:00 WEST 2018</example>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The date you intend to finish saving money.
        /// </summary>
        /// <value>The date you intend to finish saving money.</value>
        /// <example>Thu Sep 17 01:00:00 WEST 2020</example>
        [DataMember(Name = "target_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime TargetDate { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; private set; }

        /// <summary>
        /// Returns false as Order should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOrder()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; private set; }

        /// <summary>
        /// Returns false as Active should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActive()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        /// <example>Some notes</example>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PiggyBank {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  TargetAmount: ").Append(TargetAmount).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  CurrentAmount: ").Append(CurrentAmount).Append("\n");
            sb.Append("  LeftToSave: ").Append(LeftToSave).Append("\n");
            sb.Append("  SavePerMonth: ").Append(SavePerMonth).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as PiggyBank);
        }

        /// <summary>
        /// Returns true if PiggyBank instances are equal
        /// </summary>
        /// <param name="input">Instance of PiggyBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PiggyBank input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    this.AccountId.Equals(input.AccountId)
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    this.CurrencyId.Equals(input.CurrencyId)
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
                    this.TargetAmount == input.TargetAmount ||
                    this.TargetAmount.Equals(input.TargetAmount)
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
                ) && 
                (
                    this.CurrentAmount == input.CurrentAmount ||
                    this.CurrentAmount.Equals(input.CurrentAmount)
                ) && 
                (
                    this.LeftToSave == input.LeftToSave ||
                    this.LeftToSave.Equals(input.LeftToSave)
                ) && 
                (
                    this.SavePerMonth == input.SavePerMonth ||
                    this.SavePerMonth.Equals(input.SavePerMonth)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.TargetDate == input.TargetDate ||
                    (this.TargetDate != null &&
                    this.TargetDate.Equals(input.TargetDate))
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CurrencyId.GetHashCode();
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.CurrencySymbol != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencySymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CurrencyDecimalPlaces.GetHashCode();
                hashCode = (hashCode * 59) + this.TargetAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.Percentage.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.LeftToSave.GetHashCode();
                hashCode = (hashCode * 59) + this.SavePerMonth.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.TargetDate != null)
                {
                    hashCode = (hashCode * 59) + this.TargetDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
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