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
    /// RecurrenceRepetition
    /// </summary>
    [DataContract(Name = "RecurrenceRepetition")]
    public partial class RecurrenceRepetition : IEquatable<RecurrenceRepetition>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public RecurrenceRepetitionType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceRepetition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecurrenceRepetition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceRepetition" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="moment">Information that defined the type of repetition. - For &#39;daily&#39;, this is empty. - For &#39;weekly&#39;, it is day of the week between 1 and 7 (Monday - Sunday). - For &#39;ndom&#39;, it is &#39;1,2&#39; or &#39;4,5&#39; or something else, where the first number is the week in the month, and the second number is the day in the week (between 1 and 7). &#39;2,3&#39; means: the 2nd Wednesday of the month - For &#39;monthly&#39; it is the day of the month (1 - 31) - For yearly, it is a full date, ie &#39;2018-09-17&#39;. The year you use does not matter.  (required).</param>
        /// <param name="skip">How many occurrences to skip. 0 means skip nothing. 1 means every other..</param>
        /// <param name="weekend">How to respond when the recurring transaction falls in the weekend. Possible values: 1. Do nothing, just create it 2. Create no transaction. 3. Skip to the previous Friday. 4. Skip to the next Monday. .</param>
        public RecurrenceRepetition(RecurrenceRepetitionType type = default(RecurrenceRepetitionType), string moment = default(string), int skip = default(int), int weekend = default(int))
        {
            this.Type = type;
            // to ensure "moment" is required (not null)
            if (moment == null)
            {
                throw new ArgumentNullException("moment is a required property for RecurrenceRepetition and cannot be null");
            }
            this.Moment = moment;
            this.Skip = skip;
            this.Weekend = weekend;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
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
        /// Auto-generated repetition description.
        /// </summary>
        /// <value>Auto-generated repetition description.</value>
        /// <example>Every week on Friday</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; private set; }

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return false;
        }
        /// <summary>
        /// Array of future dates when the repetition will apply to. Auto generated.
        /// </summary>
        /// <value>Array of future dates when the repetition will apply to. Auto generated.</value>
        [DataMember(Name = "occurrences", EmitDefaultValue = false)]
        public List<DateTime> Occurrences { get; private set; }

        /// <summary>
        /// Returns false as Occurrences should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOccurrences()
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Moment != null)
                {
                    hashCode = (hashCode * 59) + this.Moment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Skip.GetHashCode();
                hashCode = (hashCode * 59) + this.Weekend.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Occurrences != null)
                {
                    hashCode = (hashCode * 59) + this.Occurrences.GetHashCode();
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
