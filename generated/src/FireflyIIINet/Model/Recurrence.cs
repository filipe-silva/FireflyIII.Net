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
    /// Recurrence
    /// </summary>
    [DataContract(Name = "Recurrence")]
    public partial class Recurrence : IEquatable<Recurrence>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Withdrawal for value: withdrawal
            /// </summary>
            [EnumMember(Value = "withdrawal")]
            Withdrawal = 1,

            /// <summary>
            /// Enum Transfer for value: transfer
            /// </summary>
            [EnumMember(Value = "transfer")]
            Transfer = 2,

            /// <summary>
            /// Enum Deposit for value: deposit
            /// </summary>
            [EnumMember(Value = "deposit")]
            Deposit = 3
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>withdrawal</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Recurrence" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="title">title.</param>
        /// <param name="description">Not to be confused with the description of the actual transaction(s) being created..</param>
        /// <param name="firstDate">First time the recurring transaction will fire. Must be after today..</param>
        /// <param name="repeatUntil">Date until the recurring transaction can fire. Use either this field or repetitions..</param>
        /// <param name="nrOfRepetitions">Max number of created transactions. Use either this field or repeat_until..</param>
        /// <param name="applyRules">Whether or not to fire the rules after the creation of a transaction..</param>
        /// <param name="active">If the recurrence is even active..</param>
        /// <param name="notes">notes.</param>
        /// <param name="repetitions">repetitions.</param>
        /// <param name="transactions">transactions.</param>
        public Recurrence(TypeEnum? type = default(TypeEnum?), string title = default(string), string description = default(string), DateTime firstDate = default(DateTime), DateTime? repeatUntil = default(DateTime?), int? nrOfRepetitions = default(int?), bool applyRules = default(bool), bool active = default(bool), string notes = default(string), List<RecurrenceRepetition> repetitions = default(List<RecurrenceRepetition>), List<RecurrenceTransaction> transactions = default(List<RecurrenceTransaction>))
        {
            this.Type = type;
            this.Title = title;
            this.Description = description;
            this.FirstDate = firstDate;
            this.RepeatUntil = repeatUntil;
            this.NrOfRepetitions = nrOfRepetitions;
            this.ApplyRules = applyRules;
            this.Active = active;
            this.Notes = notes;
            this.Repetitions = repetitions;
            this.Transactions = transactions;
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
        /// Gets or Sets Title
        /// </summary>
        /// <example>Rent</example>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Not to be confused with the description of the actual transaction(s) being created.
        /// </summary>
        /// <value>Not to be confused with the description of the actual transaction(s) being created.</value>
        /// <example>Recurring transaction for the monthly rent</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// First time the recurring transaction will fire. Must be after today.
        /// </summary>
        /// <value>First time the recurring transaction will fire. Must be after today.</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "first_date", EmitDefaultValue = false)]
        public DateTime FirstDate { get; set; }

        /// <summary>
        /// Last time the recurring transaction has fired.
        /// </summary>
        /// <value>Last time the recurring transaction has fired.</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "latest_date", EmitDefaultValue = true)]
        public DateTime? LatestDate { get; private set; }

        /// <summary>
        /// Returns false as LatestDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLatestDate()
        {
            return false;
        }
        /// <summary>
        /// Date until the recurring transaction can fire. Use either this field or repetitions.
        /// </summary>
        /// <value>Date until the recurring transaction can fire. Use either this field or repetitions.</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "repeat_until", EmitDefaultValue = true)]
        public DateTime? RepeatUntil { get; set; }

        /// <summary>
        /// Max number of created transactions. Use either this field or repeat_until.
        /// </summary>
        /// <value>Max number of created transactions. Use either this field or repeat_until.</value>
        /// <example>5</example>
        [DataMember(Name = "nr_of_repetitions", EmitDefaultValue = true)]
        public int? NrOfRepetitions { get; set; }

        /// <summary>
        /// Whether or not to fire the rules after the creation of a transaction.
        /// </summary>
        /// <value>Whether or not to fire the rules after the creation of a transaction.</value>
        /// <example>true</example>
        [DataMember(Name = "apply_rules", EmitDefaultValue = true)]
        public bool ApplyRules { get; set; }

        /// <summary>
        /// If the recurrence is even active.
        /// </summary>
        /// <value>If the recurrence is even active.</value>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        /// <example>Some notes</example>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets Repetitions
        /// </summary>
        [DataMember(Name = "repetitions", EmitDefaultValue = false)]
        public List<RecurrenceRepetition> Repetitions { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<RecurrenceTransaction> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Recurrence {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FirstDate: ").Append(FirstDate).Append("\n");
            sb.Append("  LatestDate: ").Append(LatestDate).Append("\n");
            sb.Append("  RepeatUntil: ").Append(RepeatUntil).Append("\n");
            sb.Append("  NrOfRepetitions: ").Append(NrOfRepetitions).Append("\n");
            sb.Append("  ApplyRules: ").Append(ApplyRules).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Repetitions: ").Append(Repetitions).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as Recurrence);
        }

        /// <summary>
        /// Returns true if Recurrence instances are equal
        /// </summary>
        /// <param name="input">Instance of Recurrence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Recurrence input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FirstDate == input.FirstDate ||
                    (this.FirstDate != null &&
                    this.FirstDate.Equals(input.FirstDate))
                ) && 
                (
                    this.LatestDate == input.LatestDate ||
                    (this.LatestDate != null &&
                    this.LatestDate.Equals(input.LatestDate))
                ) && 
                (
                    this.RepeatUntil == input.RepeatUntil ||
                    (this.RepeatUntil != null &&
                    this.RepeatUntil.Equals(input.RepeatUntil))
                ) && 
                (
                    this.NrOfRepetitions == input.NrOfRepetitions ||
                    (this.NrOfRepetitions != null &&
                    this.NrOfRepetitions.Equals(input.NrOfRepetitions))
                ) && 
                (
                    this.ApplyRules == input.ApplyRules ||
                    this.ApplyRules.Equals(input.ApplyRules)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Repetitions == input.Repetitions ||
                    this.Repetitions != null &&
                    input.Repetitions != null &&
                    this.Repetitions.SequenceEqual(input.Repetitions)
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.FirstDate != null)
                {
                    hashCode = (hashCode * 59) + this.FirstDate.GetHashCode();
                }
                if (this.LatestDate != null)
                {
                    hashCode = (hashCode * 59) + this.LatestDate.GetHashCode();
                }
                if (this.RepeatUntil != null)
                {
                    hashCode = (hashCode * 59) + this.RepeatUntil.GetHashCode();
                }
                if (this.NrOfRepetitions != null)
                {
                    hashCode = (hashCode * 59) + this.NrOfRepetitions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ApplyRules.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.Repetitions != null)
                {
                    hashCode = (hashCode * 59) + this.Repetitions.GetHashCode();
                }
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
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
