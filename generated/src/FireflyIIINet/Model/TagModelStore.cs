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
    /// TagModelStore
    /// </summary>
    [DataContract(Name = "TagModelStore")]
    public partial class TagModelStore : IEquatable<TagModelStore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagModelStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TagModelStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TagModelStore" /> class.
        /// </summary>
        /// <param name="tag">The tag (required).</param>
        /// <param name="date">The date to which the tag is applicable..</param>
        /// <param name="description">description.</param>
        /// <param name="latitude">Latitude of the tag&#39;s location, if applicable. Can be used to draw a map..</param>
        /// <param name="longitude">Latitude of the tag&#39;s location, if applicable. Can be used to draw a map..</param>
        /// <param name="zoomLevel">Zoom level for the map, if drawn. This to set the box right. Unfortunately this is a proprietary value because each map provider has different zoom levels..</param>
        public TagModelStore(string tag = default(string), DateTime? date = default(DateTime?), string description = default(string), double? latitude = default(double?), double? longitude = default(double?), int? zoomLevel = default(int?))
        {
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new ArgumentNullException("tag is a required property for TagModelStore and cannot be null");
            }
            Tag = tag;
            Date = date;
            Description = description;
            Latitude = latitude;
            Longitude = longitude;
            ZoomLevel = zoomLevel;
        }

        /// <summary>
        /// The tag
        /// </summary>
        /// <value>The tag</value>
        /// <example>expensive</example>
        [DataMember(Name = "tag", IsRequired = true, EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// The date to which the tag is applicable.
        /// </summary>
        /// <value>The date to which the tag is applicable.</value>
        /// <example>Mon Sep 17 01:00:00 WEST 2018</example>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /// <example>Tag for expensive stuff</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Latitude of the tag&#39;s location, if applicable. Can be used to draw a map.
        /// </summary>
        /// <value>Latitude of the tag&#39;s location, if applicable. Can be used to draw a map.</value>
        /// <example>51.983333</example>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Latitude of the tag&#39;s location, if applicable. Can be used to draw a map.
        /// </summary>
        /// <value>Latitude of the tag&#39;s location, if applicable. Can be used to draw a map.</value>
        /// <example>5.916667</example>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Zoom level for the map, if drawn. This to set the box right. Unfortunately this is a proprietary value because each map provider has different zoom levels.
        /// </summary>
        /// <value>Zoom level for the map, if drawn. This to set the box right. Unfortunately this is a proprietary value because each map provider has different zoom levels.</value>
        /// <example>6</example>
        [DataMember(Name = "zoom_level", EmitDefaultValue = false)]
        public int? ZoomLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TagModelStore {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  ZoomLevel: ").Append(ZoomLevel).Append("\n");
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
            return Equals(input as TagModelStore);
        }

        /// <summary>
        /// Returns true if TagModelStore instances are equal
        /// </summary>
        /// <param name="input">Instance of TagModelStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagModelStore input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    Tag == input.Tag ||
					Tag.Equals(input.Tag)
                ) && 
                (
                    Date == input.Date ||
                    (Date != null &&
                    Date.Equals(input.Date))
                ) && 
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) && 
                (
                    Latitude == input.Latitude ||
                    (Latitude != null &&
                    Latitude.Equals(input.Latitude))
                ) && 
                (
                    Longitude == input.Longitude ||
                    (Longitude != null &&
                    Longitude.Equals(input.Longitude))
                ) && 
                (
                    ZoomLevel == input.ZoomLevel ||
                    (ZoomLevel != null &&
                    ZoomLevel.Equals(input.ZoomLevel))
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
				hashCode = (hashCode * 59) + Tag.GetHashCode();
                if (Date != null)
                {
                    hashCode = (hashCode * 59) + Date.GetHashCode();
                }
                if (Description != null)
                {
                    hashCode = (hashCode * 59) + Description.GetHashCode();
                }
                if (Latitude != null)
                {
                    hashCode = (hashCode * 59) + Latitude.GetHashCode();
                }
                if (Longitude != null)
                {
                    hashCode = (hashCode * 59) + Longitude.GetHashCode();
                }
                if (ZoomLevel != null)
                {
                    hashCode = (hashCode * 59) + ZoomLevel.GetHashCode();
                }
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
