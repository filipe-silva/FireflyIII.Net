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
    /// BillUpdate
    /// </summary>
    [DataContract(Name = "BillUpdate")]
    public partial class BillUpdate : IEquatable<BillUpdate>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RepeatFreq
        /// </summary>
        [DataMember(Name = "repeat_freq", EmitDefaultValue = false)]
        public BillRepeatFrequency? RepeatFreq { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillUpdate" /> class.
        /// </summary>
        /// <param name="currencyId">Use either currency_id or currency_code.</param>
        /// <param name="currencyCode">Use either currency_id or currency_code.</param>
        /// <param name="name">name.</param>
        /// <param name="amountMin">amountMin.</param>
        /// <param name="amountMax">amountMax.</param>
        /// <param name="date">date.</param>
        /// <param name="endDate">The date after which this bill is no longer valid or applicable.</param>
        /// <param name="extensionDate">The date before which the bill must be renewed (or cancelled).</param>
        /// <param name="repeatFreq">repeatFreq.</param>
        /// <param name="skip">How often the bill must be skipped. 1 means a bi-monthly bill..</param>
        /// <param name="active">If the bill is active..</param>
        /// <param name="notes">notes.</param>
        /// <param name="objectGroupId">The group ID of the group this object is part of. NULL if no group..</param>
        /// <param name="objectGroupTitle">The name of the group. NULL if no group..</param>
        public BillUpdate(string currencyId = default(string), string currencyCode = default(string), string name = default(string), string amountMin = default(string), string amountMax = default(string), DateTime date = default(DateTime), DateTime endDate = default(DateTime), DateTime extensionDate = default(DateTime), BillRepeatFrequency? repeatFreq = default(BillRepeatFrequency?), int skip = default(int), bool active = default(bool), string notes = default(string), string objectGroupId = default(string), string objectGroupTitle = default(string))
        {
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
            this.Name = name;
            this.AmountMin = amountMin;
            this.AmountMax = amountMax;
            this.Date = date;
            this.EndDate = endDate;
            this.ExtensionDate = extensionDate;
            this.RepeatFreq = repeatFreq;
            this.Skip = skip;
            this.Active = active;
            this.Notes = notes;
            this.ObjectGroupId = objectGroupId;
            this.ObjectGroupTitle = objectGroupTitle;
        }

        /// <summary>
        /// Use either currency_id or currency_code
        /// </summary>
        /// <value>Use either currency_id or currency_code</value>
        /// <example>5</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = false)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Use either currency_id or currency_code
        /// </summary>
        /// <value>Use either currency_id or currency_code</value>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>Rent</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AmountMin
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "amount_min", EmitDefaultValue = false)]
        public string AmountMin { get; set; }

        /// <summary>
        /// Gets or Sets AmountMax
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "amount_max", EmitDefaultValue = false)]
        public string AmountMax { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The date after which this bill is no longer valid or applicable
        /// </summary>
        /// <value>The date after which this bill is no longer valid or applicable</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The date before which the bill must be renewed (or cancelled)
        /// </summary>
        /// <value>The date before which the bill must be renewed (or cancelled)</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "extension_date", EmitDefaultValue = false)]
        public DateTime ExtensionDate { get; set; }

        /// <summary>
        /// How often the bill must be skipped. 1 means a bi-monthly bill.
        /// </summary>
        /// <value>How often the bill must be skipped. 1 means a bi-monthly bill.</value>
        /// <example>0</example>
        [DataMember(Name = "skip", EmitDefaultValue = false)]
        public int Skip { get; set; }

        /// <summary>
        /// If the bill is active.
        /// </summary>
        /// <value>If the bill is active.</value>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        /// <example>Some example notes</example>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// The group ID of the group this object is part of. NULL if no group.
        /// </summary>
        /// <value>The group ID of the group this object is part of. NULL if no group.</value>
        /// <example>5</example>
        [DataMember(Name = "object_group_id", EmitDefaultValue = true)]
        public string ObjectGroupId { get; set; }

        /// <summary>
        /// The name of the group. NULL if no group.
        /// </summary>
        /// <value>The name of the group. NULL if no group.</value>
        /// <example>Example Group</example>
        [DataMember(Name = "object_group_title", EmitDefaultValue = true)]
        public string ObjectGroupTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillUpdate {\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AmountMin: ").Append(AmountMin).Append("\n");
            sb.Append("  AmountMax: ").Append(AmountMax).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ExtensionDate: ").Append(ExtensionDate).Append("\n");
            sb.Append("  RepeatFreq: ").Append(RepeatFreq).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BillUpdate);
        }

        /// <summary>
        /// Returns true if BillUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of BillUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillUpdate input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AmountMin == input.AmountMin ||
                    (this.AmountMin != null &&
                    this.AmountMin.Equals(input.AmountMin))
                ) && 
                (
                    this.AmountMax == input.AmountMax ||
                    (this.AmountMax != null &&
                    this.AmountMax.Equals(input.AmountMax))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ExtensionDate == input.ExtensionDate ||
                    (this.ExtensionDate != null &&
                    this.ExtensionDate.Equals(input.ExtensionDate))
                ) && 
                (
                    this.RepeatFreq == input.RepeatFreq ||
                    this.RepeatFreq.Equals(input.RepeatFreq)
                ) && 
                (
                    this.Skip == input.Skip ||
                    this.Skip.Equals(input.Skip)
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
                    this.ObjectGroupId == input.ObjectGroupId ||
                    (this.ObjectGroupId != null &&
                    this.ObjectGroupId.Equals(input.ObjectGroupId))
                ) && 
                (
                    this.ObjectGroupTitle == input.ObjectGroupTitle ||
                    (this.ObjectGroupTitle != null &&
                    this.ObjectGroupTitle.Equals(input.ObjectGroupTitle))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.AmountMin != null)
                {
                    hashCode = (hashCode * 59) + this.AmountMin.GetHashCode();
                }
                if (this.AmountMax != null)
                {
                    hashCode = (hashCode * 59) + this.AmountMax.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.ExtensionDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExtensionDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RepeatFreq.GetHashCode();
                hashCode = (hashCode * 59) + this.Skip.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.ObjectGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectGroupId.GetHashCode();
                }
                if (this.ObjectGroupTitle != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectGroupTitle.GetHashCode();
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
