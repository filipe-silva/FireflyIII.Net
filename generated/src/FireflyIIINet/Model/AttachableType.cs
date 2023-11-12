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
    /// The object class to which the attachment must be linked.
    /// </summary>
    /// <value>The object class to which the attachment must be linked.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttachableType
    {
        /// <summary>
        /// Enum Account for value: Account
        /// </summary>
        [EnumMember(Value = "Account")]
        Account = 1,

        /// <summary>
        /// Enum Budget for value: Budget
        /// </summary>
        [EnumMember(Value = "Budget")]
        Budget = 2,

        /// <summary>
        /// Enum Bill for value: Bill
        /// </summary>
        [EnumMember(Value = "Bill")]
        Bill = 3,

        /// <summary>
        /// Enum TransactionJournal for value: TransactionJournal
        /// </summary>
        [EnumMember(Value = "TransactionJournal")]
        TransactionJournal = 4,

        /// <summary>
        /// Enum PiggyBank for value: PiggyBank
        /// </summary>
        [EnumMember(Value = "PiggyBank")]
        PiggyBank = 5,

        /// <summary>
        /// Enum Tag for value: Tag
        /// </summary>
        [EnumMember(Value = "Tag")]
        Tag = 6
    }

}
