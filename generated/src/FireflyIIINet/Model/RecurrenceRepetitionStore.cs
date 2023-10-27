/*
 * Firefly III API v1.5.1
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2021-04-04T11:50:40+00:00 
 *
 * The version of the OpenAPI document: 1.5.1
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
    /// RecurrenceRepetitionStore
    /// </summary>
    [DataContract(Name = "RecurrenceRepetitionStore")]
    public partial class RecurrenceRepetitionStore : IEquatable<RecurrenceRepetitionStore>, IValidatableObject
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
        /// <example>weekly</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceRepetitionStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecurrenceRepetitionStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceRepetitionStore" /> class.
        /// </summary>
        /// <param name="type">The type of the repetition. ndom means: the n-th weekday of the month, where you can also specify which day of the week. (required).</param>
        /// <param name="moment">Information that defined the type of repetition. - For &#39;daily&#39;, this is empty. - For &#39;weekly&#39;, it is day of the week between 1 and 7 (Monday - Sunday). - For &#39;ndom&#39;, it is &#39;1,2&#39; or &#39;4,5&#39; or something else, where the first number is the week in the month, and the second number is the day in the week (between 1 and 7). &#39;2,3&#39; means: the 2nd Wednesday of the month - For &#39;monthly&#39; it is the day of the month (1 - 31) - For yearly, it is a full date, ie &#39;2018-09-17&#39;. The year you use does not matter.  (required).</param>
        /// <param name="skip">How many occurrences to skip. 0 means skip nothing. 1 means every other..</param>
        /// <param name="weekend">How to respond when the recurring transaction falls in the weekend. Possible values: 1. Do nothing, just create it 2. Create no transaction. 3. Skip to the previous Friday. 4. Skip to the next Monday. .</param>
        public RecurrenceRepetitionStore(TypeEnum type = default(TypeEnum), string moment = default(string), int skip = default(int), int weekend = default(int))
        {
            this.Type = type;
            // to ensure "moment" is required (not null)
            if (moment == null)
            {
                throw new ArgumentNullException("moment is a required property for RecurrenceRepetitionStore and cannot be null");
            }
            this.Moment = moment;
            this.Skip = skip;
            this.Weekend = weekend;
        }

        /// <summary>
        /// Information that defined the type of repetition. - For &#39;daily&#39;, this is empty. - For &#39;weekly&#39;, it is day of the week between 1 and 7 (Monday - Sunday). - For &#39;ndom&#39;, it is &#39;1,2&#39; or &#39;4,5&#39; or something else, where the first number is the week in the month, and the second number is the day in the week (between 1 and 7). &#39;2,3&#39; means: the 2nd Wednesday of the month - For &#39;monthly&#39; it is the day of the month (1 - 31) - For yearly, it is a full date, ie &#39;2018-09-17&#39;. The year you use does not matter. 
        /// </summary>
        /// <value>Information that defined the type of repetition. - For &#39;daily&#39;, this is empty. - For &#39;weekly&#39;, it is day of the week between 1 and 7 (Monday - Sunday). - For &#39;ndom&#39;, it is &#39;1,2&#39; or &#39;4,5&#39; or something else, where the first number is the week in the month, and the second number is the day in the week (between 1 and 7). &#39;2,3&#39; means: the 2nd Wednesday of the month - For &#39;monthly&#39; it is the day of the month (1 - 31) - For yearly, it is a full date, ie &#39;2018-09-17&#39;. The year you use does not matter. </value>
        /// <example>3</example>
        [DataMember(Name = "moment", IsRequired = true, EmitDefaultValue = true)]
        public string Moment { get; set; }

        /// <summary>
        /// How many occurrences to skip. 0 means skip nothing. 1 means every other.
        /// </summary>
        /// <value>How many occurrences to skip. 0 means skip nothing. 1 means every other.</value>
        /// <example>0</example>
        [DataMember(Name = "skip", EmitDefaultValue = false)]
        public int Skip { get; set; }

        /// <summary>
        /// How to respond when the recurring transaction falls in the weekend. Possible values: 1. Do nothing, just create it 2. Create no transaction. 3. Skip to the previous Friday. 4. Skip to the next Monday. 
        /// </summary>
        /// <value>How to respond when the recurring transaction falls in the weekend. Possible values: 1. Do nothing, just create it 2. Create no transaction. 3. Skip to the previous Friday. 4. Skip to the next Monday. </value>
        /// <example>1</example>
        [DataMember(Name = "weekend", EmitDefaultValue = false)]
        public int Weekend { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecurrenceRepetitionStore {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Moment: ").Append(Moment).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Weekend: ").Append(Weekend).Append("\n");
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
            return this.Equals(input as RecurrenceRepetitionStore);
        }

        /// <summary>
        /// Returns true if RecurrenceRepetitionStore instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurrenceRepetitionStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurrenceRepetitionStore input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Moment != null)
                {
                    hashCode = (hashCode * 59) + this.Moment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Skip.GetHashCode();
                hashCode = (hashCode * 59) + this.Weekend.GetHashCode();
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
