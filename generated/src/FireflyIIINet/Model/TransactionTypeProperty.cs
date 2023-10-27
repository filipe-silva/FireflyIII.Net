/*
 * Firefly III API v1.5.6
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2022-04-04T03:54:41+00:00 
 *
 * The version of the OpenAPI document: 1.5.6
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
    /// Defines TransactionTypeProperty
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionTypeProperty
    {
        /// <summary>
        /// Enum Withdrawal for value: withdrawal
        /// </summary>
        [EnumMember(Value = "withdrawal")]
        Withdrawal = 1,

        /// <summary>
        /// Enum Deposit for value: deposit
        /// </summary>
        [EnumMember(Value = "deposit")]
        Deposit = 2,

        /// <summary>
        /// Enum Transfer for value: transfer
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer = 3,

        /// <summary>
        /// Enum Reconciliation for value: reconciliation
        /// </summary>
        [EnumMember(Value = "reconciliation")]
        Reconciliation = 4,

        /// <summary>
        /// Enum OpeningBalance for value: opening balance
        /// </summary>
        [EnumMember(Value = "opening balance")]
        OpeningBalance = 5
    }

}
