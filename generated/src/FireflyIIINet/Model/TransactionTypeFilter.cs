/*
 * Firefly III API v1.5.1
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2021-04-04T11:50:40+00:00 
 *
 * The version of the OpenAPI document: 1.5.1
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
    /// Defines TransactionTypeFilter
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionTypeFilter
    {
        /// <summary>
        /// Enum All for value: all
        /// </summary>
        [EnumMember(Value = "all")]
        All = 1,

        /// <summary>
        /// Enum Withdrawal for value: withdrawal
        /// </summary>
        [EnumMember(Value = "withdrawal")]
        Withdrawal = 2,

        /// <summary>
        /// Enum Withdrawals for value: withdrawals
        /// </summary>
        [EnumMember(Value = "withdrawals")]
        Withdrawals = 3,

        /// <summary>
        /// Enum Expense for value: expense
        /// </summary>
        [EnumMember(Value = "expense")]
        Expense = 4,

        /// <summary>
        /// Enum Deposit for value: deposit
        /// </summary>
        [EnumMember(Value = "deposit")]
        Deposit = 5,

        /// <summary>
        /// Enum Deposits for value: deposits
        /// </summary>
        [EnumMember(Value = "deposits")]
        Deposits = 6,

        /// <summary>
        /// Enum Income for value: income
        /// </summary>
        [EnumMember(Value = "income")]
        Income = 7,

        /// <summary>
        /// Enum Transfer for value: transfer
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer = 8,

        /// <summary>
        /// Enum Transfers for value: transfers
        /// </summary>
        [EnumMember(Value = "transfers")]
        Transfers = 9,

        /// <summary>
        /// Enum OpeningBalance for value: opening_balance
        /// </summary>
        [EnumMember(Value = "opening_balance")]
        OpeningBalance = 10,

        /// <summary>
        /// Enum Reconciliation for value: reconciliation
        /// </summary>
        [EnumMember(Value = "reconciliation")]
        Reconciliation = 11,

        /// <summary>
        /// Enum Special for value: special
        /// </summary>
        [EnumMember(Value = "special")]
        Special = 12,

        /// <summary>
        /// Enum Specials for value: specials
        /// </summary>
        [EnumMember(Value = "specials")]
        Specials = 13,

        /// <summary>
        /// Enum Default for value: default
        /// </summary>
        [EnumMember(Value = "default")]
        Default = 14
    }

}
