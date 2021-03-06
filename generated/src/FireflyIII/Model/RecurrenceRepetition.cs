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
    /// RecurrenceRepetition
    /// </summary>
    [DataContract]
    public partial class RecurrenceRepetition :  IEquatable<RecurrenceRepetition>, IValidatableObject
    {
        /// <summary>
        /// The type of the repetition. ndom means: the n-th weekday of the month, where you can also specify which day of the week.
        /// </summary>
        /// <value>The type of the repetition. ndom means: the n-th weekday of the month, where you can also specify which day of the week.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 1,

            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 2,

            /// <summary>
            /// Enum Ndom for value: ndom
            /// </summary>
            [EnumMember(Value = "ndom")]
            Ndom = 3,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 4,

            /// <summary>
            /// Enum Yearly for value: yearly
            /// </summary>
            [EnumMember(Value = "yearly")]
            Yearly = 5

        }

        /// <summary>
        /// The type of the repetition. ndom means: the n-th weekday of the month, where you can also specify which day of the week.
        /// </summary>
        /// <value>The type of the repetition. ndom means: the n-th weekday of the month, where you can also specify which day of the week.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceRepetition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecurrenceRepetition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceRepetition" /> class.
        /// </summary>
        /// <param name="type">The type of the repetition. ndom means: the n-th weekday of the month, where you can also specify which day of the week. (required).</param>
        /// <param name="moment">Information that defined the type of repetition. - For &#39;daily&#39;, this is empty. - For &#39;weekly&#39;, it is day of the week between 1 and 7 (Monday - Sunday). - For &#39;ndom&#39;, it is &#39;1,2&#39; or &#39;4,5&#39; or something else, where the first number is the week in the month, and the second number is the day in the week (between 1 and 7). &#39;2,3&#39; means: the 2nd Wednesday of the month - For &#39;monthly&#39; it is the day of the month (1 - 31) - For yearly, it is a full date, ie &#39;2018-09-17&#39;. The year you use does not matter.  (required).</param>
        /// <param name="skip">How many occurrences to skip. 0 means skip nothing. 1 means every other..</param>
        /// <param name="weekend">How to respond when the recurring transaction falls in the weekend. Possible values: 1. Do nothing, just create it 2. Create no transaction. 3. Skip to the previous Friday. 4. Skip to the next Monday. .</param>
        public RecurrenceRepetition(TypeEnum type = default(TypeEnum), string moment = default(string), int skip = default(int), int weekend = default(int))
        {
            this.Type = type;
            // to ensure "moment" is required (not null)
            if (moment == null)
            {
                throw new InvalidDataException("moment is a required property for RecurrenceRepetition and cannot be null");
            }
            else
            {
                this.Moment = moment;
            }

            this.Skip = skip;
            this.Weekend = weekend;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; private set; }

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
        /// Information that defined the type of repetition. - For &#39;daily&#39;, this is empty. - For &#39;weekly&#39;, it is day of the week between 1 and 7 (Monday - Sunday). - For &#39;ndom&#39;, it is &#39;1,2&#39; or &#39;4,5&#39; or something else, where the first number is the week in the month, and the second number is the day in the week (between 1 and 7). &#39;2,3&#39; means: the 2nd Wednesday of the month - For &#39;monthly&#39; it is the day of the month (1 - 31) - For yearly, it is a full date, ie &#39;2018-09-17&#39;. The year you use does not matter. 
        /// </summary>
        /// <value>Information that defined the type of repetition. - For &#39;daily&#39;, this is empty. - For &#39;weekly&#39;, it is day of the week between 1 and 7 (Monday - Sunday). - For &#39;ndom&#39;, it is &#39;1,2&#39; or &#39;4,5&#39; or something else, where the first number is the week in the month, and the second number is the day in the week (between 1 and 7). &#39;2,3&#39; means: the 2nd Wednesday of the month - For &#39;monthly&#39; it is the day of the month (1 - 31) - For yearly, it is a full date, ie &#39;2018-09-17&#39;. The year you use does not matter. </value>
        [DataMember(Name="moment", EmitDefaultValue=true)]
        public string Moment { get; set; }

        /// <summary>
        /// How many occurrences to skip. 0 means skip nothing. 1 means every other.
        /// </summary>
        /// <value>How many occurrences to skip. 0 means skip nothing. 1 means every other.</value>
        [DataMember(Name="skip", EmitDefaultValue=false)]
        public int Skip { get; set; }

        /// <summary>
        /// How to respond when the recurring transaction falls in the weekend. Possible values: 1. Do nothing, just create it 2. Create no transaction. 3. Skip to the previous Friday. 4. Skip to the next Monday. 
        /// </summary>
        /// <value>How to respond when the recurring transaction falls in the weekend. Possible values: 1. Do nothing, just create it 2. Create no transaction. 3. Skip to the previous Friday. 4. Skip to the next Monday. </value>
        [DataMember(Name="weekend", EmitDefaultValue=false)]
        public int Weekend { get; set; }

        /// <summary>
        /// Auto-generated repetition description.
        /// </summary>
        /// <value>Auto-generated repetition description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }

        /// <summary>
        /// Array of future dates when the repetition will apply to. Auto generated.
        /// </summary>
        /// <value>Array of future dates when the repetition will apply to. Auto generated.</value>
        [DataMember(Name="occurrences", EmitDefaultValue=false)]
        public List<DateTime> Occurrences { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecurrenceRepetition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Moment: ").Append(Moment).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Weekend: ").Append(Weekend).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Occurrences: ").Append(Occurrences).Append("\n");
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
            return this.Equals(input as RecurrenceRepetition);
        }

        /// <summary>
        /// Returns true if RecurrenceRepetition instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurrenceRepetition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurrenceRepetition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
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
                    this.Moment == input.Moment ||
                    (this.Moment != null &&
                    this.Moment.Equals(input.Moment))
                ) && 
                (
                    this.Skip == input.Skip ||
                    this.Skip.Equals(input.Skip)
                ) && 
                (
                    this.Weekend == input.Weekend ||
                    this.Weekend.Equals(input.Weekend)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Occurrences == input.Occurrences ||
                    this.Occurrences != null &&
                    input.Occurrences != null &&
                    this.Occurrences.SequenceEqual(input.Occurrences)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Moment != null)
                    hashCode = hashCode * 59 + this.Moment.GetHashCode();
                hashCode = hashCode * 59 + this.Skip.GetHashCode();
                hashCode = hashCode * 59 + this.Weekend.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Occurrences != null)
                    hashCode = hashCode * 59 + this.Occurrences.GetHashCode();
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
