/*
 * Firefly III API v2.0.3
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-06-11T09:13:59+00:00 
 *
 * The version of the OpenAPI document: 2.0.3
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
    /// ChartDataSet
    /// </summary>
    [DataContract(Name = "ChartDataSet")]
    public partial class ChartDataSet : IEquatable<ChartDataSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartDataSet" /> class.
        /// </summary>
        /// <param name="label">This is the title of the current set. It can refer to an account, a budget or another object (by name)..</param>
        /// <param name="currencyId">The currency ID of the currency associated to the data in the entries..</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="currencySymbol">currencySymbol.</param>
        /// <param name="currencyDecimalPlaces">Number of decimals for the currency associated to the data in the entries..</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="type">Indicated the type of chart that is expected to be rendered. You can safely ignore this if you want..</param>
        /// <param name="yAxisID">Used to indicate the Y axis for this data set. Is usually between 0 and 1 (left and right side of the chart)..</param>
        /// <param name="entries">The actual entries for this data set. They &#39;key&#39; value is the label for the data point. The value is the actual (numerical) value..</param>
        public ChartDataSet(string label = default(string), string currencyId = default(string), string currencyCode = default(string), string currencySymbol = default(string), int currencyDecimalPlaces = default(int), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), string type = default(string), int yAxisID = default(int), List<ChartDataPoint> entries = default(List<ChartDataPoint>))
        {
            this.Label = label;
            this.CurrencyId = currencyId;
            this.CurrencyCode = currencyCode;
            this.CurrencySymbol = currencySymbol;
            this.CurrencyDecimalPlaces = currencyDecimalPlaces;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Type = type;
            this.YAxisID = yAxisID;
            this.Entries = entries;
        }

        /// <summary>
        /// This is the title of the current set. It can refer to an account, a budget or another object (by name).
        /// </summary>
        /// <value>This is the title of the current set. It can refer to an account, a budget or another object (by name).</value>
        /// <example>Checking account</example>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// The currency ID of the currency associated to the data in the entries.
        /// </summary>
        /// <value>The currency ID of the currency associated to the data in the entries.</value>
        /// <example>5</example>
        [DataMember(Name = "currency_id", EmitDefaultValue = false)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "currency_symbol", EmitDefaultValue = false)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Number of decimals for the currency associated to the data in the entries.
        /// </summary>
        /// <value>Number of decimals for the currency associated to the data in the entries.</value>
        /// <example>2</example>
        [DataMember(Name = "currency_decimal_places", EmitDefaultValue = false)]
        public int CurrencyDecimalPlaces { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        /// <example>2018-09-17T12:46:47+01:00</example>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Indicated the type of chart that is expected to be rendered. You can safely ignore this if you want.
        /// </summary>
        /// <value>Indicated the type of chart that is expected to be rendered. You can safely ignore this if you want.</value>
        /// <example>line</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Used to indicate the Y axis for this data set. Is usually between 0 and 1 (left and right side of the chart).
        /// </summary>
        /// <value>Used to indicate the Y axis for this data set. Is usually between 0 and 1 (left and right side of the chart).</value>
        /// <example>0</example>
        [DataMember(Name = "yAxisID", EmitDefaultValue = false)]
        public int YAxisID { get; set; }

        /// <summary>
        /// The actual entries for this data set. They &#39;key&#39; value is the label for the data point. The value is the actual (numerical) value.
        /// </summary>
        /// <value>The actual entries for this data set. They &#39;key&#39; value is the label for the data point. The value is the actual (numerical) value.</value>
        [DataMember(Name = "entries", EmitDefaultValue = false)]
        public List<ChartDataPoint> Entries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChartDataSet {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyDecimalPlaces: ").Append(CurrencyDecimalPlaces).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  YAxisID: ").Append(YAxisID).Append("\n");
            sb.Append("  Entries: ").Append(Entries).Append("\n");
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
            return this.Equals(input as ChartDataSet);
        }

        /// <summary>
        /// Returns true if ChartDataSet instances are equal
        /// </summary>
        /// <param name="input">Instance of ChartDataSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChartDataSet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.YAxisID == input.YAxisID ||
                    this.YAxisID.Equals(input.YAxisID)
                ) && 
                (
                    this.Entries == input.Entries ||
                    this.Entries != null &&
                    input.Entries != null &&
                    this.Entries.SequenceEqual(input.Entries)
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
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
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
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.YAxisID.GetHashCode();
                if (this.Entries != null)
                {
                    hashCode = (hashCode * 59) + this.Entries.GetHashCode();
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
