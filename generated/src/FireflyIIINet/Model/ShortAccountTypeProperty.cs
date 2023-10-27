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
    /// Can only be one one these account types. import, initial-balance and reconciliation cannot be set manually.
    /// </summary>
    /// <value>Can only be one one these account types. import, initial-balance and reconciliation cannot be set manually.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShortAccountTypeProperty
    {
        /// <summary>
        /// Enum Asset for value: asset
        /// </summary>
        [EnumMember(Value = "asset")]
        Asset = 1,

        /// <summary>
        /// Enum Expense for value: expense
        /// </summary>
        [EnumMember(Value = "expense")]
        Expense = 2,

        /// <summary>
        /// Enum Import for value: import
        /// </summary>
        [EnumMember(Value = "import")]
        Import = 3,

        /// <summary>
        /// Enum Revenue for value: revenue
        /// </summary>
        [EnumMember(Value = "revenue")]
        Revenue = 4,

        /// <summary>
        /// Enum Cash for value: cash
        /// </summary>
        [EnumMember(Value = "cash")]
        Cash = 5,

        /// <summary>
        /// Enum Liability for value: liability
        /// </summary>
        [EnumMember(Value = "liability")]
        Liability = 6,

        /// <summary>
        /// Enum Liabilities for value: liabilities
        /// </summary>
        [EnumMember(Value = "liabilities")]
        Liabilities = 7,

        /// <summary>
        /// Enum InitialBalance for value: initial-balance
        /// </summary>
        [EnumMember(Value = "initial-balance")]
        InitialBalance = 8,

        /// <summary>
        /// Enum Reconciliation for value: reconciliation
        /// </summary>
        [EnumMember(Value = "reconciliation")]
        Reconciliation = 9
    }

}
