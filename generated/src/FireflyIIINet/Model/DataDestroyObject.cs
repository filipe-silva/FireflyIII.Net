/*
 * Firefly III API v1.5.5
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2022-02-04T17:00:55+00:00 
 *
 * The version of the OpenAPI document: 1.5.5
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
    /// Defines DataDestroyObject
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataDestroyObject
    {
        /// <summary>
        /// Enum Budgets for value: budgets
        /// </summary>
        [EnumMember(Value = "budgets")]
        Budgets = 1,

        /// <summary>
        /// Enum Bills for value: bills
        /// </summary>
        [EnumMember(Value = "bills")]
        Bills = 2,

        /// <summary>
        /// Enum PiggyBanks for value: piggy_banks
        /// </summary>
        [EnumMember(Value = "piggy_banks")]
        PiggyBanks = 3,

        /// <summary>
        /// Enum Rules for value: rules
        /// </summary>
        [EnumMember(Value = "rules")]
        Rules = 4,

        /// <summary>
        /// Enum Recurring for value: recurring
        /// </summary>
        [EnumMember(Value = "recurring")]
        Recurring = 5,

        /// <summary>
        /// Enum Categories for value: categories
        /// </summary>
        [EnumMember(Value = "categories")]
        Categories = 6,

        /// <summary>
        /// Enum Tags for value: tags
        /// </summary>
        [EnumMember(Value = "tags")]
        Tags = 7,

        /// <summary>
        /// Enum ObjectGroups for value: object_groups
        /// </summary>
        [EnumMember(Value = "object_groups")]
        ObjectGroups = 8,

        /// <summary>
        /// Enum Accounts for value: accounts
        /// </summary>
        [EnumMember(Value = "accounts")]
        Accounts = 9,

        /// <summary>
        /// Enum AssetAccounts for value: asset_accounts
        /// </summary>
        [EnumMember(Value = "asset_accounts")]
        AssetAccounts = 10,

        /// <summary>
        /// Enum ExpenseAccounts for value: expense_accounts
        /// </summary>
        [EnumMember(Value = "expense_accounts")]
        ExpenseAccounts = 11,

        /// <summary>
        /// Enum RevenueAccounts for value: revenue_accounts
        /// </summary>
        [EnumMember(Value = "revenue_accounts")]
        RevenueAccounts = 12,

        /// <summary>
        /// Enum Liabilities for value: liabilities
        /// </summary>
        [EnumMember(Value = "liabilities")]
        Liabilities = 13,

        /// <summary>
        /// Enum Transactions for value: transactions
        /// </summary>
        [EnumMember(Value = "transactions")]
        Transactions = 14,

        /// <summary>
        /// Enum Withdrawals for value: withdrawals
        /// </summary>
        [EnumMember(Value = "withdrawals")]
        Withdrawals = 15,

        /// <summary>
        /// Enum Deposits for value: deposits
        /// </summary>
        [EnumMember(Value = "deposits")]
        Deposits = 16,

        /// <summary>
        /// Enum Transfers for value: transfers
        /// </summary>
        [EnumMember(Value = "transfers")]
        Transfers = 17
    }

}
