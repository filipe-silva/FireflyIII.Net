/*
 * Firefly III API v2.0.7
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-09-01T17:55:04+00:00 
 *
 * The version of the OpenAPI document: 2.0.7
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
    /// &#39;credit&#39; indicates somebody owes you the liability. &#39;debit&#39; Indicates you owe this debt yourself. Works only for liabiltiies.
    /// </summary>
    /// <value>&#39;credit&#39; indicates somebody owes you the liability. &#39;debit&#39; Indicates you owe this debt yourself. Works only for liabiltiies.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LiabilityDirection
    {
        /// <summary>
        /// Enum Credit for value: credit
        /// </summary>
        [EnumMember(Value = "credit")]
        Credit = 1,

        /// <summary>
        /// Enum Debit for value: debit
        /// </summary>
        [EnumMember(Value = "debit")]
        Debit = 2,

        /// <summary>
        /// Enum Null for value: null
        /// </summary>
        [EnumMember(Value = "null")]
        Null = 3
    }

}
