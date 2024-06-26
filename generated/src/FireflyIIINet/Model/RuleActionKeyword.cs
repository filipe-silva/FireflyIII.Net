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
    /// The type of thing this action will do. A limited set is possible.
    /// </summary>
    /// <value>The type of thing this action will do. A limited set is possible.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RuleActionKeyword
    {
        /// <summary>
        /// Enum UserAction for value: user_action
        /// </summary>
        [EnumMember(Value = "user_action")]
        UserAction = 1,

        /// <summary>
        /// Enum SetCategory for value: set_category
        /// </summary>
        [EnumMember(Value = "set_category")]
        SetCategory = 2,

        /// <summary>
        /// Enum ClearCategory for value: clear_category
        /// </summary>
        [EnumMember(Value = "clear_category")]
        ClearCategory = 3,

        /// <summary>
        /// Enum SetBudget for value: set_budget
        /// </summary>
        [EnumMember(Value = "set_budget")]
        SetBudget = 4,

        /// <summary>
        /// Enum ClearBudget for value: clear_budget
        /// </summary>
        [EnumMember(Value = "clear_budget")]
        ClearBudget = 5,

        /// <summary>
        /// Enum AddTag for value: add_tag
        /// </summary>
        [EnumMember(Value = "add_tag")]
        AddTag = 6,

        /// <summary>
        /// Enum RemoveTag for value: remove_tag
        /// </summary>
        [EnumMember(Value = "remove_tag")]
        RemoveTag = 7,

        /// <summary>
        /// Enum RemoveAllTags for value: remove_all_tags
        /// </summary>
        [EnumMember(Value = "remove_all_tags")]
        RemoveAllTags = 8,

        /// <summary>
        /// Enum SetDescription for value: set_description
        /// </summary>
        [EnumMember(Value = "set_description")]
        SetDescription = 9,

        /// <summary>
        /// Enum AppendDescription for value: append_description
        /// </summary>
        [EnumMember(Value = "append_description")]
        AppendDescription = 10,

        /// <summary>
        /// Enum PrependDescription for value: prepend_description
        /// </summary>
        [EnumMember(Value = "prepend_description")]
        PrependDescription = 11,

        /// <summary>
        /// Enum SetSourceAccount for value: set_source_account
        /// </summary>
        [EnumMember(Value = "set_source_account")]
        SetSourceAccount = 12,

        /// <summary>
        /// Enum SetDestinationAccount for value: set_destination_account
        /// </summary>
        [EnumMember(Value = "set_destination_account")]
        SetDestinationAccount = 13,

        /// <summary>
        /// Enum SetNotes for value: set_notes
        /// </summary>
        [EnumMember(Value = "set_notes")]
        SetNotes = 14,

        /// <summary>
        /// Enum AppendNotes for value: append_notes
        /// </summary>
        [EnumMember(Value = "append_notes")]
        AppendNotes = 15,

        /// <summary>
        /// Enum PrependNotes for value: prepend_notes
        /// </summary>
        [EnumMember(Value = "prepend_notes")]
        PrependNotes = 16,

        /// <summary>
        /// Enum ClearNotes for value: clear_notes
        /// </summary>
        [EnumMember(Value = "clear_notes")]
        ClearNotes = 17,

        /// <summary>
        /// Enum LinkToBill for value: link_to_bill
        /// </summary>
        [EnumMember(Value = "link_to_bill")]
        LinkToBill = 18,

        /// <summary>
        /// Enum ConvertWithdrawal for value: convert_withdrawal
        /// </summary>
        [EnumMember(Value = "convert_withdrawal")]
        ConvertWithdrawal = 19,

        /// <summary>
        /// Enum ConvertDeposit for value: convert_deposit
        /// </summary>
        [EnumMember(Value = "convert_deposit")]
        ConvertDeposit = 20,

        /// <summary>
        /// Enum ConvertTransfer for value: convert_transfer
        /// </summary>
        [EnumMember(Value = "convert_transfer")]
        ConvertTransfer = 21,

        /// <summary>
        /// Enum DeleteTransaction for value: delete_transaction
        /// </summary>
        [EnumMember(Value = "delete_transaction")]
        DeleteTransaction = 22
    }

}
