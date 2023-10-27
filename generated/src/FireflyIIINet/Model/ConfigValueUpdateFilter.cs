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
    /// Defines ConfigValueUpdateFilter
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConfigValueUpdateFilter
    {
        /// <summary>
        /// Enum IsDemoSite for value: configuration.is_demo_site
        /// </summary>
        [EnumMember(Value = "configuration.is_demo_site")]
        IsDemoSite = 1,

        /// <summary>
        /// Enum PermissionUpdateCheck for value: configuration.permission_update_check
        /// </summary>
        [EnumMember(Value = "configuration.permission_update_check")]
        PermissionUpdateCheck = 2,

        /// <summary>
        /// Enum LastUpdateCheck for value: configuration.last_update_check
        /// </summary>
        [EnumMember(Value = "configuration.last_update_check")]
        LastUpdateCheck = 3,

        /// <summary>
        /// Enum SingleUserMode for value: configuration.single_user_mode
        /// </summary>
        [EnumMember(Value = "configuration.single_user_mode")]
        SingleUserMode = 4
    }

}
