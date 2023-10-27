/*
 * Firefly III API v2.0.5
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-08-06T04:35:40+00:00 
 *
 * The version of the OpenAPI document: 2.0.5
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
    /// This field denotes the period in which the chart data is split up. If the period is not relevant, because the chart is not time-based, it will be NULL.
    /// </summary>
    /// <value>This field denotes the period in which the chart data is split up. If the period is not relevant, because the chart is not time-based, it will be NULL.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChartV2PeriodProperty
    {
        /// <summary>
        /// Enum _1D for value: 1D
        /// </summary>
        [EnumMember(Value = "1D")]
        _1D = 1,

        /// <summary>
        /// Enum _1W for value: 1W
        /// </summary>
        [EnumMember(Value = "1W")]
        _1W = 2,

        /// <summary>
        /// Enum _1M for value: 1M
        /// </summary>
        [EnumMember(Value = "1M")]
        _1M = 3,

        /// <summary>
        /// Enum _3M for value: 3M
        /// </summary>
        [EnumMember(Value = "3M")]
        _3M = 4,

        /// <summary>
        /// Enum _6M for value: 6M
        /// </summary>
        [EnumMember(Value = "6M")]
        _6M = 5,

        /// <summary>
        /// Enum _1Y for value: 1Y
        /// </summary>
        [EnumMember(Value = "1Y")]
        _1Y = 6
    }

}
