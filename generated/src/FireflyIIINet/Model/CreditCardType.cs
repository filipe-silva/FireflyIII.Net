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
    /// Mandatory when the account_role is ccAsset. Can only be monthlyFull or null.
    /// </summary>
    /// <value>Mandatory when the account_role is ccAsset. Can only be monthlyFull or null.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreditCardType
    {
        /// <summary>
        /// Enum MonthlyFull for value: monthlyFull
        /// </summary>
        [EnumMember(Value = "monthlyFull")]
        MonthlyFull = 1,

        /// <summary>
        /// Enum Null for value: null
        /// </summary>
        [EnumMember(Value = "null")]
        Null = 2
    }

}
