/*
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: thegrumpydictator@gmail.com
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
using OpenAPIDateConverter = FireflyIII.Client.OpenAPIDateConverter;

namespace FireflyIII.Model
{
    /// <summary>
    /// Defines AccountTypeProperty
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountTypeProperty
    {
        /// <summary>
        /// Enum DefaultAccount for value: Default account
        /// </summary>
        [EnumMember(Value = "Default account")]
        DefaultAccount = 1,

        /// <summary>
        /// Enum CashAccount for value: Cash account
        /// </summary>
        [EnumMember(Value = "Cash account")]
        CashAccount = 2,

        /// <summary>
        /// Enum AssetAccount for value: Asset account
        /// </summary>
        [EnumMember(Value = "Asset account")]
        AssetAccount = 3,

        /// <summary>
        /// Enum ExpenseAccount for value: Expense account
        /// </summary>
        [EnumMember(Value = "Expense account")]
        ExpenseAccount = 4,

        /// <summary>
        /// Enum RevenueAccount for value: Revenue account
        /// </summary>
        [EnumMember(Value = "Revenue account")]
        RevenueAccount = 5,

        /// <summary>
        /// Enum InitialBalanceAccount for value: Initial balance account
        /// </summary>
        [EnumMember(Value = "Initial balance account")]
        InitialBalanceAccount = 6,

        /// <summary>
        /// Enum BeneficiaryAccount for value: Beneficiary account
        /// </summary>
        [EnumMember(Value = "Beneficiary account")]
        BeneficiaryAccount = 7,

        /// <summary>
        /// Enum ImportAccount for value: Import account
        /// </summary>
        [EnumMember(Value = "Import account")]
        ImportAccount = 8,

        /// <summary>
        /// Enum ReconciliationAccount for value: Reconciliation account
        /// </summary>
        [EnumMember(Value = "Reconciliation account")]
        ReconciliationAccount = 9,

        /// <summary>
        /// Enum Loan for value: Loan
        /// </summary>
        [EnumMember(Value = "Loan")]
        Loan = 10,

        /// <summary>
        /// Enum Debt for value: Debt
        /// </summary>
        [EnumMember(Value = "Debt")]
        Debt = 11,

        /// <summary>
        /// Enum Mortgage for value: Mortgage
        /// </summary>
        [EnumMember(Value = "Mortgage")]
        Mortgage = 12
    }

}
