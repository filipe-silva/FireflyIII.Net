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
    /// The type of auto-budget that Firefly III must create.
    /// </summary>
    /// <value>The type of auto-budget that Firefly III must create.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutoBudgetType
    {
        /// <summary>
        /// Enum Reset for value: reset
        /// </summary>
        [EnumMember(Value = "reset")]
        Reset = 1,

        /// <summary>
        /// Enum Rollover for value: rollover
        /// </summary>
        [EnumMember(Value = "rollover")]
        Rollover = 2,

        /// <summary>
        /// Enum None for value: none
        /// </summary>
        [EnumMember(Value = "none")]
        None = 3,

        /// <summary>
        /// Enum Null for value: null
        /// </summary>
        [EnumMember(Value = "null")]
        Null = 4
    }

}
