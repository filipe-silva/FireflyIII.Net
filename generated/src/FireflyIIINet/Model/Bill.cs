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
    /// Bill
    /// </summary>
    [DataContract(Name = "Bill")]
    public partial class Bill : IEquatable<Bill>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RepeatFreq
        /// </summary>
        [DataMember(Name = "repeat_freq", IsRequired = true, EmitDefaultValue = true)]
        public BillRepeatFrequency RepeatFreq { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bill" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Bill() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bill" /> class.
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
        /// <param name="order">Order of the bill..</param>
        /// <param name="notes">notes.</param>
        /// <param name="objectGroupId">The group ID of the group this object is part of. NULL if no group..</param>
        /// <param name="objectGroupTitle">The name of the group. NULL if no group..</param>
        public Bill(string currencyId = default(string), string currencyCode = default(string), string name = default(string), string amountMin = default(string), string amountMax = default(string), DateTime date = default(DateTime), DateTime endDate = default(DateTime), DateTime extensionDate = default(DateTime), BillRepeatFrequency repeatFreq = default(BillRepeatFrequency), int skip = default(int), bool active = default(bool), int order = default(int), string notes = default(string), string objectGroupId = default(string), string objectGroupTitle = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Bill and cannot be null");
            }
            this.Name = name;
            // to ensure "amountMin" is required (not null)
            if (amountMin == null)
            {
                throw new ArgumentNullException("amountMin is a required property for Bill and cannot be null");
            }
            this.AmountMin = amountMin;
            // to ensure "amountMax" is required (not null)
            if (amountMax == null)
            {
                throw new ArgumentNullException("amountMax is a required property for Bill and cannot be null");
            }
            this.AmountMax = amountMax;
            this.Date = date;
            this.RepeatFreq = repeatFreq;
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
            this.EndDate = endDate;
            this.ExtensionDate = extensionDate;
            this.Skip = skip;
            this.Active = active;
            this.Order = order;
            this.Notes = notes;
            this.ObjectGroupId = objectGroupId;
            this.ObjectGroupTitle = objectGroupTitle;
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
        /// Gets or Sets CurrencyDecimalPlaces
        /// </summary>
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
        /// Order of the bill.
        /// </summary>
        /// <value>Order of the bill.</value>
        /// <example>1</example>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        /// <example>Some example notes</example>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// When the bill is expected to be due.
        /// </summary>
        /// <value>When the bill is expected to be due.</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "next_expected_match", EmitDefaultValue = true)]
        public DateTime? NextExpectedMatch { get; private set; }

        /// <summary>
        /// Returns false as NextExpectedMatch should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNextExpectedMatch()
        {
            return false;
        }
        /// <summary>
        /// Formatted (locally) when the bill is due.
        /// </summary>
        /// <value>Formatted (locally) when the bill is due.</value>
        /// <example>today</example>
        [DataMember(Name = "next_expected_match_diff", EmitDefaultValue = true)]
        public string NextExpectedMatchDiff { get; private set; }

        /// <summary>
        /// Returns false as NextExpectedMatchDiff should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNextExpectedMatchDiff()
        {
            return false;
        }
        /// <summary>
        /// The group ID of the group this object is part of. NULL if no group.
        /// </summary>
        /// <value>The group ID of the group this object is part of. NULL if no group.</value>
        /// <example>5</example>
        [DataMember(Name = "object_group_id", EmitDefaultValue = true)]
        public string ObjectGroupId { get; set; }

        /// <summary>
        /// The order of the group. At least 1, for the highest sorting.
        /// </summary>
        /// <value>The order of the group. At least 1, for the highest sorting.</value>
        /// <example>5</example>
        [DataMember(Name = "object_group_order", EmitDefaultValue = true)]
        public int? ObjectGroupOrder { get; private set; }

        /// <summary>
        /// Returns false as ObjectGroupOrder should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeObjectGroupOrder()
        {
            return false;
        }
        /// <summary>
        /// The name of the group. NULL if no group.
        /// </summary>
        /// <value>The name of the group. NULL if no group.</value>
        /// <example>Example Group</example>
        [DataMember(Name = "object_group_title", EmitDefaultValue = true)]
        public string ObjectGroupTitle { get; set; }

        /// <summary>
        /// Array of future dates when the bill is expected to be paid. Autogenerated.
        /// </summary>
        /// <value>Array of future dates when the bill is expected to be paid. Autogenerated.</value>
        [DataMember(Name = "pay_dates", EmitDefaultValue = false)]
        public List<DateTime> PayDates { get; private set; }

        /// <summary>
        /// Returns false as PayDates should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePayDates()
        {
            return false;
        }
        /// <summary>
        /// Array of past transactions when the bill was paid.
        /// </summary>
        /// <value>Array of past transactions when the bill was paid.</value>
        [DataMember(Name = "paid_dates", EmitDefaultValue = false)]
        public List<BillPaidDatesInner> PaidDates { get; private set; }

        /// <summary>
        /// Returns false as PaidDates should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaidDates()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Bill {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AmountMin: ").Append(AmountMin).Append("\n");
            sb.Append("  AmountMax: ").Append(AmountMax).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ExtensionDate: ").Append(ExtensionDate).Append("\n");
            sb.Append("  RepeatFreq: ").Append(RepeatFreq).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  NextExpectedMatch: ").Append(NextExpectedMatch).Append("\n");
            sb.Append("  NextExpectedMatchDiff: ").Append(NextExpectedMatchDiff).Append("\n");
            sb.Append("  ObjectGroupId: ").Append(ObjectGroupId).Append("\n");
            sb.Append("  ObjectGroupOrder: ").Append(ObjectGroupOrder).Append("\n");
            sb.Append("  ObjectGroupTitle: ").Append(ObjectGroupTitle).Append("\n");
            sb.Append("  PayDates: ").Append(PayDates).Append("\n");
            sb.Append("  PaidDates: ").Append(PaidDates).Append("\n");
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
            return this.Equals(input as Bill);
        }

        /// <summary>
        /// Returns true if Bill instances are equal
        /// </summary>
        /// <param name="input">Instance of Bill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bill input)
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
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.NextExpectedMatch == input.NextExpectedMatch ||
                    (this.NextExpectedMatch != null &&
                    this.NextExpectedMatch.Equals(input.NextExpectedMatch))
                ) && 
                (
                    this.NextExpectedMatchDiff == input.NextExpectedMatchDiff ||
                    (this.NextExpectedMatchDiff != null &&
                    this.NextExpectedMatchDiff.Equals(input.NextExpectedMatchDiff))
                ) && 
                (
                    this.ObjectGroupId == input.ObjectGroupId ||
                    (this.ObjectGroupId != null &&
                    this.ObjectGroupId.Equals(input.ObjectGroupId))
                ) && 
                (
                    this.ObjectGroupOrder == input.ObjectGroupOrder ||
                    (this.ObjectGroupOrder != null &&
                    this.ObjectGroupOrder.Equals(input.ObjectGroupOrder))
                ) && 
                (
                    this.ObjectGroupTitle == input.ObjectGroupTitle ||
                    (this.ObjectGroupTitle != null &&
                    this.ObjectGroupTitle.Equals(input.ObjectGroupTitle))
                ) && 
                (
                    this.PayDates == input.PayDates ||
                    this.PayDates != null &&
                    input.PayDates != null &&
                    this.PayDates.SequenceEqual(input.PayDates)
                ) && 
                (
                    this.PaidDates == input.PaidDates ||
                    this.PaidDates != null &&
                    input.PaidDates != null &&
                    this.PaidDates.SequenceEqual(input.PaidDates)
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
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.NextExpectedMatch != null)
                {
                    hashCode = (hashCode * 59) + this.NextExpectedMatch.GetHashCode();
                }
                if (this.NextExpectedMatchDiff != null)
                {
                    hashCode = (hashCode * 59) + this.NextExpectedMatchDiff.GetHashCode();
                }
                if (this.ObjectGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectGroupId.GetHashCode();
                }
                if (this.ObjectGroupOrder != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectGroupOrder.GetHashCode();
                }
                if (this.ObjectGroupTitle != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectGroupTitle.GetHashCode();
                }
                if (this.PayDates != null)
                {
                    hashCode = (hashCode * 59) + this.PayDates.GetHashCode();
                }
                if (this.PaidDates != null)
                {
                    hashCode = (hashCode * 59) + this.PaidDates.GetHashCode();
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
