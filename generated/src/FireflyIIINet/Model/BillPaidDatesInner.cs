/*
 * Firefly III API v1.5.6
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2022-04-04T03:54:41+00:00 
 *
 * The version of the OpenAPI document: 1.5.6
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
    /// BillPaidDatesInner
    /// </summary>
    [DataContract(Name = "Bill_paid_dates_inner")]
    public partial class BillPaidDatesInner : IEquatable<BillPaidDatesInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillPaidDatesInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public BillPaidDatesInner()
        {
        }

        /// <summary>
        /// Transaction group ID of the paid bill.
        /// </summary>
        /// <value>Transaction group ID of the paid bill.</value>
        /// <example>123</example>
        [DataMember(Name = "transaction_group_id", EmitDefaultValue = false)]
        public string TransactionGroupId { get; private set; }

        /// <summary>
        /// Returns false as TransactionGroupId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionGroupId()
        {
            return false;
        }
        /// <summary>
        /// Transaction journal ID of the paid bill.
        /// </summary>
        /// <value>Transaction journal ID of the paid bill.</value>
        /// <example>123</example>
        [DataMember(Name = "transaction_journal_id", EmitDefaultValue = false)]
        public string TransactionJournalId { get; private set; }

        /// <summary>
        /// Returns false as TransactionJournalId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionJournalId()
        {
            return false;
        }
        /// <summary>
        /// Date the bill was paid.
        /// </summary>
        /// <value>Date the bill was paid.</value>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; private set; }

        /// <summary>
        /// Returns false as Date should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDate()
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
            sb.Append("class BillPaidDatesInner {\n");
            sb.Append("  TransactionGroupId: ").Append(TransactionGroupId).Append("\n");
            sb.Append("  TransactionJournalId: ").Append(TransactionJournalId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as BillPaidDatesInner);
        }

        /// <summary>
        /// Returns true if BillPaidDatesInner instances are equal
        /// </summary>
        /// <param name="input">Instance of BillPaidDatesInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillPaidDatesInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionGroupId == input.TransactionGroupId ||
                    (this.TransactionGroupId != null &&
                    this.TransactionGroupId.Equals(input.TransactionGroupId))
                ) && 
                (
                    this.TransactionJournalId == input.TransactionJournalId ||
                    (this.TransactionJournalId != null &&
                    this.TransactionJournalId.Equals(input.TransactionJournalId))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.TransactionGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionGroupId.GetHashCode();
                }
                if (this.TransactionJournalId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionJournalId.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
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
