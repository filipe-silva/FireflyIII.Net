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
    /// The type of thing this trigger responds to. A limited set is possible
    /// </summary>
    /// <value>The type of thing this trigger responds to. A limited set is possible</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RuleTriggerKeyword
    {
        /// <summary>
        /// Enum FromAccountStarts for value: from_account_starts
        /// </summary>
        [EnumMember(Value = "from_account_starts")]
        FromAccountStarts = 1,

        /// <summary>
        /// Enum FromAccountEnds for value: from_account_ends
        /// </summary>
        [EnumMember(Value = "from_account_ends")]
        FromAccountEnds = 2,

        /// <summary>
        /// Enum FromAccountIs for value: from_account_is
        /// </summary>
        [EnumMember(Value = "from_account_is")]
        FromAccountIs = 3,

        /// <summary>
        /// Enum FromAccountContains for value: from_account_contains
        /// </summary>
        [EnumMember(Value = "from_account_contains")]
        FromAccountContains = 4,

        /// <summary>
        /// Enum ToAccountStarts for value: to_account_starts
        /// </summary>
        [EnumMember(Value = "to_account_starts")]
        ToAccountStarts = 5,

        /// <summary>
        /// Enum ToAccountEnds for value: to_account_ends
        /// </summary>
        [EnumMember(Value = "to_account_ends")]
        ToAccountEnds = 6,

        /// <summary>
        /// Enum ToAccountIs for value: to_account_is
        /// </summary>
        [EnumMember(Value = "to_account_is")]
        ToAccountIs = 7,

        /// <summary>
        /// Enum ToAccountContains for value: to_account_contains
        /// </summary>
        [EnumMember(Value = "to_account_contains")]
        ToAccountContains = 8,

        /// <summary>
        /// Enum AmountLess for value: amount_less
        /// </summary>
        [EnumMember(Value = "amount_less")]
        AmountLess = 9,

        /// <summary>
        /// Enum AmountExactly for value: amount_exactly
        /// </summary>
        [EnumMember(Value = "amount_exactly")]
        AmountExactly = 10,

        /// <summary>
        /// Enum AmountMore for value: amount_more
        /// </summary>
        [EnumMember(Value = "amount_more")]
        AmountMore = 11,

        /// <summary>
        /// Enum DescriptionStarts for value: description_starts
        /// </summary>
        [EnumMember(Value = "description_starts")]
        DescriptionStarts = 12,

        /// <summary>
        /// Enum DescriptionEnds for value: description_ends
        /// </summary>
        [EnumMember(Value = "description_ends")]
        DescriptionEnds = 13,

        /// <summary>
        /// Enum DescriptionContains for value: description_contains
        /// </summary>
        [EnumMember(Value = "description_contains")]
        DescriptionContains = 14,

        /// <summary>
        /// Enum DescriptionIs for value: description_is
        /// </summary>
        [EnumMember(Value = "description_is")]
        DescriptionIs = 15,

        /// <summary>
        /// Enum TransactionType for value: transaction_type
        /// </summary>
        [EnumMember(Value = "transaction_type")]
        TransactionType = 16,

        /// <summary>
        /// Enum CategoryIs for value: category_is
        /// </summary>
        [EnumMember(Value = "category_is")]
        CategoryIs = 17,

        /// <summary>
        /// Enum BudgetIs for value: budget_is
        /// </summary>
        [EnumMember(Value = "budget_is")]
        BudgetIs = 18,

        /// <summary>
        /// Enum TagIs for value: tag_is
        /// </summary>
        [EnumMember(Value = "tag_is")]
        TagIs = 19,

        /// <summary>
        /// Enum CurrencyIs for value: currency_is
        /// </summary>
        [EnumMember(Value = "currency_is")]
        CurrencyIs = 20,

        /// <summary>
        /// Enum HasAttachments for value: has_attachments
        /// </summary>
        [EnumMember(Value = "has_attachments")]
        HasAttachments = 21,

        /// <summary>
        /// Enum HasNoCategory for value: has_no_category
        /// </summary>
        [EnumMember(Value = "has_no_category")]
        HasNoCategory = 22,

        /// <summary>
        /// Enum HasAnyCategory for value: has_any_category
        /// </summary>
        [EnumMember(Value = "has_any_category")]
        HasAnyCategory = 23,

        /// <summary>
        /// Enum HasNoBudget for value: has_no_budget
        /// </summary>
        [EnumMember(Value = "has_no_budget")]
        HasNoBudget = 24,

        /// <summary>
        /// Enum HasAnyBudget for value: has_any_budget
        /// </summary>
        [EnumMember(Value = "has_any_budget")]
        HasAnyBudget = 25,

        /// <summary>
        /// Enum HasNoTag for value: has_no_tag
        /// </summary>
        [EnumMember(Value = "has_no_tag")]
        HasNoTag = 26,

        /// <summary>
        /// Enum HasAnyTag for value: has_any_tag
        /// </summary>
        [EnumMember(Value = "has_any_tag")]
        HasAnyTag = 27,

        /// <summary>
        /// Enum NotesContains for value: notes_contains
        /// </summary>
        [EnumMember(Value = "notes_contains")]
        NotesContains = 28,

        /// <summary>
        /// Enum NotesStart for value: notes_start
        /// </summary>
        [EnumMember(Value = "notes_start")]
        NotesStart = 29,

        /// <summary>
        /// Enum NotesEnd for value: notes_end
        /// </summary>
        [EnumMember(Value = "notes_end")]
        NotesEnd = 30,

        /// <summary>
        /// Enum NotesAre for value: notes_are
        /// </summary>
        [EnumMember(Value = "notes_are")]
        NotesAre = 31,

        /// <summary>
        /// Enum NoNotes for value: no_notes
        /// </summary>
        [EnumMember(Value = "no_notes")]
        NoNotes = 32,

        /// <summary>
        /// Enum AnyNotes for value: any_notes
        /// </summary>
        [EnumMember(Value = "any_notes")]
        AnyNotes = 33,

        /// <summary>
        /// Enum SourceAccountIs for value: source_account_is
        /// </summary>
        [EnumMember(Value = "source_account_is")]
        SourceAccountIs = 34,

        /// <summary>
        /// Enum DestinationAccountIs for value: destination_account_is
        /// </summary>
        [EnumMember(Value = "destination_account_is")]
        DestinationAccountIs = 35,

        /// <summary>
        /// Enum SourceAccountStarts for value: source_account_starts
        /// </summary>
        [EnumMember(Value = "source_account_starts")]
        SourceAccountStarts = 36
    }

}
