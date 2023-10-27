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
    /// Defines ConfigValueFilter
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConfigValueFilter
    {
        /// <summary>
        /// Enum ConfigurationIsDemoSite for value: configuration.is_demo_site
        /// </summary>
        [EnumMember(Value = "configuration.is_demo_site")]
        ConfigurationIsDemoSite = 1,

        /// <summary>
        /// Enum ConfigurationPermissionUpdateCheck for value: configuration.permission_update_check
        /// </summary>
        [EnumMember(Value = "configuration.permission_update_check")]
        ConfigurationPermissionUpdateCheck = 2,

        /// <summary>
        /// Enum ConfigurationLastUpdateCheck for value: configuration.last_update_check
        /// </summary>
        [EnumMember(Value = "configuration.last_update_check")]
        ConfigurationLastUpdateCheck = 3,

        /// <summary>
        /// Enum ConfigurationSingleUserMode for value: configuration.single_user_mode
        /// </summary>
        [EnumMember(Value = "configuration.single_user_mode")]
        ConfigurationSingleUserMode = 4,

        /// <summary>
        /// Enum FireflyVersion for value: firefly.version
        /// </summary>
        [EnumMember(Value = "firefly.version")]
        FireflyVersion = 5,

        /// <summary>
        /// Enum FireflyApiVersion for value: firefly.api_version
        /// </summary>
        [EnumMember(Value = "firefly.api_version")]
        FireflyApiVersion = 6,

        /// <summary>
        /// Enum FireflyDefaultLocation for value: firefly.default_location
        /// </summary>
        [EnumMember(Value = "firefly.default_location")]
        FireflyDefaultLocation = 7,

        /// <summary>
        /// Enum FireflyAccountToTransaction for value: firefly.account_to_transaction
        /// </summary>
        [EnumMember(Value = "firefly.account_to_transaction")]
        FireflyAccountToTransaction = 8,

        /// <summary>
        /// Enum FireflyAllowedOpposingTypes for value: firefly.allowed_opposing_types
        /// </summary>
        [EnumMember(Value = "firefly.allowed_opposing_types")]
        FireflyAllowedOpposingTypes = 9
    }

}
