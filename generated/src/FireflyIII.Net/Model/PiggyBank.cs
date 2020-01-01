/* 
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 0.10.4-modified
 * Contact: thegrumpydictator@gmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FireflyIII.Net.Client.OpenAPIDateConverter;

namespace FireflyIII.Net.Model
{
    /// <summary>
    /// PiggyBank
    /// </summary>
    [DataContract]
    public partial class PiggyBank :  IEquatable<PiggyBank>, IValidatableObject
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
                throw new InvalidDataException("name is a required property for PiggyBank and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for PiggyBank and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }

            // to ensure "targetAmount" is required (not null)
            if (targetAmount == null)
            {
                throw new InvalidDataException("targetAmount is a required property for PiggyBank and cannot be null");
            }
            else
            {
                this.TargetAmount = targetAmount;
            }

            this.CurrentAmount = currentAmount;
            this.StartDate = startDate;
            this.TargetDate = targetDate;
            this.Notes = notes;
        }
        
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the asset account this piggy bank is connected to.
        /// </summary>
        /// <value>The ID of the asset account this piggy bank is connected to.</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public int AccountId { get; set; }

        /// <summary>
        /// The name of the asset account this piggy bank is connected to.
        /// </summary>
        /// <value>The name of the asset account this piggy bank is connected to.</value>
        [DataMember(Name="account_name", EmitDefaultValue=false)]
        public string AccountName { get; private set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name="currency_id", EmitDefaultValue=false)]
        public int CurrencyId { get; private set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; private set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        [DataMember(Name="currency_symbol", EmitDefaultValue=false)]
        public string CurrencySymbol { get; private set; }

        /// <summary>
        /// Number of decimals supported by the currency
        /// </summary>
        /// <value>Number of decimals supported by the currency</value>
        [DataMember(Name="currency_decimal_places", EmitDefaultValue=false)]
        public int CurrencyDecimalPlaces { get; private set; }

        /// <summary>
        /// Gets or Sets TargetAmount
        /// </summary>
        [DataMember(Name="target_amount", EmitDefaultValue=false)]
        public double TargetAmount { get; set; }

        /// <summary>
        /// Gets or Sets Percentage
        /// </summary>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public float Percentage { get; private set; }

        /// <summary>
        /// Gets or Sets CurrentAmount
        /// </summary>
        [DataMember(Name="current_amount", EmitDefaultValue=false)]
        public double CurrentAmount { get; set; }

        /// <summary>
        /// Gets or Sets LeftToSave
        /// </summary>
        [DataMember(Name="left_to_save", EmitDefaultValue=false)]
        public double LeftToSave { get; private set; }

        /// <summary>
        /// Gets or Sets SavePerMonth
        /// </summary>
        [DataMember(Name="save_per_month", EmitDefaultValue=false)]
        public double SavePerMonth { get; private set; }

        /// <summary>
        /// The date you started with this piggy bank.
        /// </summary>
        /// <value>The date you started with this piggy bank.</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The date you intend to finish saving money.
        /// </summary>
        /// <value>The date you intend to finish saving money.</value>
        [DataMember(Name="target_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime TargetDate { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int Order { get; private set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; private set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                return false;

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
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.CurrencySymbol != null)
                    hashCode = hashCode * 59 + this.CurrencySymbol.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyDecimalPlaces.GetHashCode();
                hashCode = hashCode * 59 + this.TargetAmount.GetHashCode();
                hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentAmount.GetHashCode();
                hashCode = hashCode * 59 + this.LeftToSave.GetHashCode();
                hashCode = hashCode * 59 + this.SavePerMonth.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.TargetDate != null)
                    hashCode = hashCode * 59 + this.TargetDate.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
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