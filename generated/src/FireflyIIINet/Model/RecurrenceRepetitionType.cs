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
    /// The type of the repetition. ndom means: the n-th weekday of the month, where you can also specify which day of the week.
    /// </summary>
    /// <value>The type of the repetition. ndom means: the n-th weekday of the month, where you can also specify which day of the week.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecurrenceRepetitionType
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

}
