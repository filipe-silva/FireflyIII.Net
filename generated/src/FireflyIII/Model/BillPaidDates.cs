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
using OpenAPIDateConverter = FireflyIII.Client.OpenAPIDateConverter;

namespace FireflyIII.Model
{
    /// <summary>
    /// BillPaidDates
    /// </summary>
    [DataContract]
    public partial class BillPaidDates :  IEquatable<BillPaidDates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillPaidDates" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public BillPaidDates()
        {
        }

        /// <summary>
        /// Transaction group ID of the paid bill.
        /// </summary>
        /// <value>Transaction group ID of the paid bill.</value>
        [DataMember(Name="transaction_group_id", EmitDefaultValue=false)]
        public int TransactionGroupId { get; private set; }

        /// <summary>
        /// Transaction journal ID of the paid bill.
        /// </summary>
        /// <value>Transaction journal ID of the paid bill.</value>
        [DataMember(Name="transaction_journal_id", EmitDefaultValue=false)]
        public int TransactionJournalId { get; private set; }

        /// <summary>
        /// Date the bill was paid.
        /// </summary>
        /// <value>Date the bill was paid.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillPaidDates {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BillPaidDates);
        }

        /// <summary>
        /// Returns true if BillPaidDates instances are equal
        /// </summary>
        /// <param name="input">Instance of BillPaidDates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillPaidDates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionGroupId == input.TransactionGroupId ||
                    this.TransactionGroupId.Equals(input.TransactionGroupId)
                ) && 
                (
                    this.TransactionJournalId == input.TransactionJournalId ||
                    this.TransactionJournalId.Equals(input.TransactionJournalId)
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
                hashCode = hashCode * 59 + this.TransactionGroupId.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionJournalId.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
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
