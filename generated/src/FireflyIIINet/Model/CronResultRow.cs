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
    /// CronResultRow
    /// </summary>
    [DataContract(Name = "CronResultRow")]
    public partial class CronResultRow : IEquatable<CronResultRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CronResultRow" /> class.
        /// </summary>
        /// <param name="jobFired">This value tells you if this specific cron job actually fired. It may not fire. Some cron jobs only fire every 24 hours, for example. .</param>
        /// <param name="jobSucceeded">This value tells you if this specific cron job actually did something. The job may fire but not change anything. .</param>
        /// <param name="jobErrored">If the cron job ran into some kind of an error, this value will be true..</param>
        /// <param name="message">If the cron job ran into some kind of an error, this value will be the error message. The success message if the job actually ran OK. .</param>
        public CronResultRow(bool? jobFired = default(bool?), bool? jobSucceeded = default(bool?), bool? jobErrored = default(bool?), string message = default(string))
        {
            this.JobFired = jobFired;
            this.JobSucceeded = jobSucceeded;
            this.JobErrored = jobErrored;
            this.Message = message;
        }

        /// <summary>
        /// This value tells you if this specific cron job actually fired. It may not fire. Some cron jobs only fire every 24 hours, for example. 
        /// </summary>
        /// <value>This value tells you if this specific cron job actually fired. It may not fire. Some cron jobs only fire every 24 hours, for example. </value>
        /// <example>true</example>
        [DataMember(Name = "job_fired", EmitDefaultValue = true)]
        public bool? JobFired { get; set; }

        /// <summary>
        /// This value tells you if this specific cron job actually did something. The job may fire but not change anything. 
        /// </summary>
        /// <value>This value tells you if this specific cron job actually did something. The job may fire but not change anything. </value>
        /// <example>true</example>
        [DataMember(Name = "job_succeeded", EmitDefaultValue = true)]
        public bool? JobSucceeded { get; set; }

        /// <summary>
        /// If the cron job ran into some kind of an error, this value will be true.
        /// </summary>
        /// <value>If the cron job ran into some kind of an error, this value will be true.</value>
        /// <example>false</example>
        [DataMember(Name = "job_errored", EmitDefaultValue = true)]
        public bool? JobErrored { get; set; }

        /// <summary>
        /// If the cron job ran into some kind of an error, this value will be the error message. The success message if the job actually ran OK. 
        /// </summary>
        /// <value>If the cron job ran into some kind of an error, this value will be the error message. The success message if the job actually ran OK. </value>
        /// <example>Cron result message</example>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CronResultRow {\n");
            sb.Append("  JobFired: ").Append(JobFired).Append("\n");
            sb.Append("  JobSucceeded: ").Append(JobSucceeded).Append("\n");
            sb.Append("  JobErrored: ").Append(JobErrored).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as CronResultRow);
        }

        /// <summary>
        /// Returns true if CronResultRow instances are equal
        /// </summary>
        /// <param name="input">Instance of CronResultRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CronResultRow input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.JobFired == input.JobFired ||
                    (this.JobFired != null &&
                    this.JobFired.Equals(input.JobFired))
                ) && 
                (
                    this.JobSucceeded == input.JobSucceeded ||
                    (this.JobSucceeded != null &&
                    this.JobSucceeded.Equals(input.JobSucceeded))
                ) && 
                (
                    this.JobErrored == input.JobErrored ||
                    (this.JobErrored != null &&
                    this.JobErrored.Equals(input.JobErrored))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.JobFired != null)
                {
                    hashCode = (hashCode * 59) + this.JobFired.GetHashCode();
                }
                if (this.JobSucceeded != null)
                {
                    hashCode = (hashCode * 59) + this.JobSucceeded.GetHashCode();
                }
                if (this.JobErrored != null)
                {
                    hashCode = (hashCode * 59) + this.JobErrored.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
