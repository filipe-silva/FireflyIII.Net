/*
 * Firefly III API v2.0.10
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-10-15T12:13:25+00:00  Please keep in mind that the demo site does not accept requests from curl, colly, wget, etc. You must use a browser or a tool like Postman to make requests. Too many script kiddies out there, sorry about that. 
 *
 * The version of the OpenAPI document: 2.0.10
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
    /// MetaPagination
    /// </summary>
    [DataContract(Name = "Meta_pagination")]
    public partial class MetaPagination : IEquatable<MetaPagination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaPagination" /> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="count">count.</param>
        /// <param name="perPage">perPage.</param>
        /// <param name="currentPage">currentPage.</param>
        /// <param name="totalPages">totalPages.</param>
        public MetaPagination(int total = default(int), int count = default(int), int perPage = default(int), int currentPage = default(int), int totalPages = default(int))
        {
            this.Total = total;
            this.Count = count;
            this.PerPage = perPage;
            this.CurrentPage = currentPage;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets PerPage
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "per_page", EmitDefaultValue = false)]
        public int PerPage { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "current_page", EmitDefaultValue = false)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "total_pages", EmitDefaultValue = false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetaPagination {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
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
            return this.Equals(input as MetaPagination);
        }

        /// <summary>
        /// Returns true if MetaPagination instances are equal
        /// </summary>
        /// <param name="input">Instance of MetaPagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaPagination input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    this.PerPage.Equals(input.PerPage)
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    this.CurrentPage.Equals(input.CurrentPage)
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    this.TotalPages.Equals(input.TotalPages)
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
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                hashCode = (hashCode * 59) + this.PerPage.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentPage.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPages.GetHashCode();
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
