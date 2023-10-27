/*
 * Firefly III API v2.0.6
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-09-01T03:14:46+00:00 
 *
 * The version of the OpenAPI document: 2.0.6
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
    /// Mandatory when type is liability. Period over which the interest is calculated.
    /// </summary>
    /// <value>Mandatory when type is liability. Period over which the interest is calculated.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InterestPeriod
    {
        /// <summary>
        /// Enum Weekly for value: weekly
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly = 1,

        /// <summary>
        /// Enum Monthly for value: monthly
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly = 2,

        /// <summary>
        /// Enum Quarterly for value: quarterly
        /// </summary>
        [EnumMember(Value = "quarterly")]
        Quarterly = 3,

        /// <summary>
        /// Enum HalfYear for value: half-year
        /// </summary>
        [EnumMember(Value = "half-year")]
        HalfYear = 4,

        /// <summary>
        /// Enum Yearly for value: yearly
        /// </summary>
        [EnumMember(Value = "yearly")]
        Yearly = 5,

        /// <summary>
        /// Enum Null for value: null
        /// </summary>
        [EnumMember(Value = "null")]
        Null = 6
    }

}
