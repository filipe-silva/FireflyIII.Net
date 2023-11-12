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
    /// TransactionLinkArray
    /// </summary>
    [DataContract(Name = "TransactionLinkArray")]
    public partial class TransactionLinkArray : IEquatable<TransactionLinkArray>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLinkArray" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionLinkArray() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLinkArray" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="meta">meta (required).</param>
        /// <param name="links">links (required).</param>
        public TransactionLinkArray(List<TransactionLinkRead> data = default(List<TransactionLinkRead>), Meta meta = default(Meta), PageLink links = default(PageLink))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for TransactionLinkArray and cannot be null");
            }
            Data = data;
            // to ensure "meta" is required (not null)
            if (meta == null)
            {
                throw new ArgumentNullException("meta is a required property for TransactionLinkArray and cannot be null");
            }
            Meta = meta;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for TransactionLinkArray and cannot be null");
            }
            Links = links;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public List<TransactionLinkRead> Data { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", IsRequired = true, EmitDefaultValue = true)]
        public Meta Meta { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public PageLink Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionLinkArray {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return Equals(input as TransactionLinkArray);
        }

        /// <summary>
        /// Returns true if TransactionLinkArray instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionLinkArray to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionLinkArray input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Data == input.Data ||
                    Data != null &&
                    input.Data != null &&
                    Data.SequenceEqual(input.Data)
                ) && 
                (
                    Meta == input.Meta ||
					Meta.Equals(input.Meta)
                ) && 
                (
                    Links == input.Links ||
					Links.Equals(input.Links)
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
				hashCode = (hashCode * 59) + Data.GetHashCode();
				hashCode = (hashCode * 59) + Meta.GetHashCode();
				hashCode = (hashCode * 59) + Links.GetHashCode();
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
