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
    /// BillStore
    /// </summary>
    [DataContract(Name = "BillStore")]
    public partial class BillStore : IEquatable<BillStore>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RepeatFreq
        /// </summary>
        [DataMember(Name = "repeat_freq", IsRequired = true, EmitDefaultValue = true)]
        public BillRepeatFrequency RepeatFreq { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillStore" /> class.
        /// </summary>
        /// <param name="currencyId">Use either currency_id or currency_code.</param>
        /// <param name="currencyCode">Use either currency_id or currency_code.</param>
        /// <param name="name">name (required).</param>
        /// <param name="amountMin">amountMin (required).</param>
        /// <param name="amountMax">amountMax (required).</param>
        /// <param name="date">date (required).</param>
        /// <param name="endDate">The date after which this bill is no longer valid or applicable.</param>
        /// <param name="extensionDate">The date before which the bill must be renewed (or cancelled).</param>
        /// <param name="repeatFreq">repeatFreq (required).</param>
        /// <param name="skip">How often the bill must be skipped. 1 means a bi-monthly bill..</param>
        /// <param name="active">If the bill is active..</param>
        /// <param name="notes">notes.</param>
        /// <param name="objectGroupId">The group ID of the group this object is part of. NULL if no group..</param>
        /// <param name="objectGroupTitle">The name of the group. NULL if no group..</param>
        public BillStore(string currencyId = default(string), string currencyCode = default(string), string name = default(string), string amountMin = default(string), string amountMax = default(string), DateTime date = default(DateTime), DateTime endDate = default(DateTime), DateTime extensionDate = default(DateTime), BillRepeatFrequency repeatFreq = default(BillRepeatFrequency), int skip = default(int), bool active = default(bool), string notes = default(string), string objectGroupId = default(string), string objectGroupTitle = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for BillStore and cannot be null");
            }
            Name = name;
            // to ensure "amountMin" is required (not null)
            if (amountMin == null)
            {
                throw new ArgumentNullException("amountMin is a required property for BillStore and cannot be null");
            }
            AmountMin = amountMin;
            // to ensure "amountMax" is required (not null)
            if (amountMax == null)
            {
                throw new ArgumentNullException("amountMax is a required property for BillStore and cannot be null");
            }
            AmountMax = amountMax;
            Date = date;
            RepeatFreq = repeatFreq;
            CurrencyId = currencyId;
            CurrencyCode = currencyCode;
            EndDate = endDate;
            ExtensionDate = extensionDate;
            Skip = skip;
            Active = active;
            Notes = notes;
            ObjectGroupId = objectGroupId;
            ObjectGroupTitle = objectGroupTitle;
        }

        /// <summary>
        /// Use either currency_id or currency_code
        /// </summary>
        /// <value>Use either currency_id or currency_code</value>
        /// <example>5</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Use either currency_id or currency_code
        /// </summary>
        /// <value>Use either currency_id or currency_code</value>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>Rent</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AmountMin
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "amount_min", IsRequired = true, EmitDefaultValue = true)]
        public string AmountMin { get; set; }

        /// <summary>
        /// Gets or Sets AmountMax
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "amount_max", IsRequired = true, EmitDefaultValue = true)]
        public string AmountMax { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The date after which this bill is no longer valid or applicable
        /// </summary>
        /// <value>The date after which this bill is no longer valid or applicable</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "end_date", EmitDefaultValue = true)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The date before which the bill must be renewed (or cancelled)
        /// </summary>
        /// <value>The date before which the bill must be renewed (or cancelled)</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "extension_date", EmitDefaultValue = true)]
        public DateTime ExtensionDate { get; set; }

        /// <summary>
        /// How often the bill must be skipped. 1 means a bi-monthly bill.
        /// </summary>
        /// <value>How often the bill must be skipped. 1 means a bi-monthly bill.</value>
        /// <example>0</example>
        [DataMember(Name = "skip", EmitDefaultValue = true)]
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
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

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
            sb.Append("class BillStore {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as BillStore);
        }

        /// <summary>
        /// Returns true if BillStore instances are equal
        /// </summary>
        /// <param name="input">Instance of BillStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillStore input)
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
                    Name == input.Name ||
					Name.Equals(input.Name)
                ) && 
                (
                    AmountMin == input.AmountMin ||
					AmountMin.Equals(input.AmountMin)
                ) && 
                (
                    AmountMax == input.AmountMax ||
					AmountMax.Equals(input.AmountMax)
                ) && 
                (
                    Date == input.Date ||
					Date.Equals(input.Date)
                ) && 
                (
                    EndDate == input.EndDate ||
					EndDate.Equals(input.EndDate)
                ) && 
                (
                    ExtensionDate == input.ExtensionDate ||
					ExtensionDate.Equals(input.ExtensionDate)
                ) && 
                (
                    RepeatFreq == input.RepeatFreq ||
                    RepeatFreq.Equals(input.RepeatFreq)
                ) && 
                (
                    Skip == input.Skip ||
                    Skip.Equals(input.Skip)
                ) && 
                (
                    Active == input.Active ||
                    Active.Equals(input.Active)
                ) && 
                (
                    Notes == input.Notes ||
                    (Notes != null &&
                    Notes.Equals(input.Notes))
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
				hashCode = (hashCode * 59) + CurrencyId.GetHashCode();
				hashCode = (hashCode * 59) + CurrencyCode.GetHashCode();
				hashCode = (hashCode * 59) + Name.GetHashCode();
				hashCode = (hashCode * 59) + AmountMin.GetHashCode();
				hashCode = (hashCode * 59) + AmountMax.GetHashCode();
				hashCode = (hashCode * 59) + Date.GetHashCode();
				hashCode = (hashCode * 59) + EndDate.GetHashCode();
				hashCode = (hashCode * 59) + ExtensionDate.GetHashCode();
                hashCode = (hashCode * 59) + RepeatFreq.GetHashCode();
                hashCode = (hashCode * 59) + Skip.GetHashCode();
                hashCode = (hashCode * 59) + Active.GetHashCode();
                if (Notes != null)
                {
                    hashCode = (hashCode * 59) + Notes.GetHashCode();
                }
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
