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
    /// Defines AccountTypeFilter
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountTypeFilter
    {
        /// <summary>
        /// Enum All for value: all
        /// </summary>
        [EnumMember(Value = "all")]
        All = 1,

        /// <summary>
        /// Enum Asset for value: asset
        /// </summary>
        [EnumMember(Value = "asset")]
        Asset = 2,

        /// <summary>
        /// Enum Cash for value: cash
        /// </summary>
        [EnumMember(Value = "cash")]
        Cash = 3,

        /// <summary>
        /// Enum Expense for value: expense
        /// </summary>
        [EnumMember(Value = "expense")]
        Expense = 4,

        /// <summary>
        /// Enum Revenue for value: revenue
        /// </summary>
        [EnumMember(Value = "revenue")]
        Revenue = 5,

        /// <summary>
        /// Enum Special for value: special
        /// </summary>
        [EnumMember(Value = "special")]
        Special = 6,

        /// <summary>
        /// Enum Hidden for value: hidden
        /// </summary>
        [EnumMember(Value = "hidden")]
        Hidden = 7,

        /// <summary>
        /// Enum Liability for value: liability
        /// </summary>
        [EnumMember(Value = "liability")]
        Liability = 8,

        /// <summary>
        /// Enum Liabilities for value: liabilities
        /// </summary>
        [EnumMember(Value = "liabilities")]
        Liabilities = 9,

        /// <summary>
        /// Enum DefaultAccount for value: Default account
        /// </summary>
        [EnumMember(Value = "Default account")]
        DefaultAccount = 10,

        /// <summary>
        /// Enum CashAccount for value: Cash account
        /// </summary>
        [EnumMember(Value = "Cash account")]
        CashAccount = 11,

        /// <summary>
        /// Enum AssetAccount for value: Asset account
        /// </summary>
        [EnumMember(Value = "Asset account")]
        AssetAccount = 12,

        /// <summary>
        /// Enum ExpenseAccount for value: Expense account
        /// </summary>
        [EnumMember(Value = "Expense account")]
        ExpenseAccount = 13,

        /// <summary>
        /// Enum RevenueAccount for value: Revenue account
        /// </summary>
        [EnumMember(Value = "Revenue account")]
        RevenueAccount = 14,

        /// <summary>
        /// Enum InitialBalanceAccount for value: Initial balance account
        /// </summary>
        [EnumMember(Value = "Initial balance account")]
        InitialBalanceAccount = 15,

        /// <summary>
        /// Enum BeneficiaryAccount for value: Beneficiary account
        /// </summary>
        [EnumMember(Value = "Beneficiary account")]
        BeneficiaryAccount = 16,

        /// <summary>
        /// Enum ImportAccount for value: Import account
        /// </summary>
        [EnumMember(Value = "Import account")]
        ImportAccount = 17,

        /// <summary>
        /// Enum ReconciliationAccount for value: Reconciliation account
        /// </summary>
        [EnumMember(Value = "Reconciliation account")]
        ReconciliationAccount = 18,

        /// <summary>
        /// Enum Loan for value: Loan
        /// </summary>
        [EnumMember(Value = "Loan")]
        Loan = 19,

        /// <summary>
        /// Enum Debt for value: Debt
        /// </summary>
        [EnumMember(Value = "Debt")]
        Debt = 20,

        /// <summary>
        /// Enum Mortgage for value: Mortgage
        /// </summary>
        [EnumMember(Value = "Mortgage")]
        Mortgage = 21
    }

}
