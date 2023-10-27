/*
 * Firefly III API v2.0.0
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-03-05T14:16:31+00:00 
 *
 * The version of the OpenAPI document: 2.0.0
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
    /// Role for the user. Can be empty or omitted.
    /// </summary>
    /// <value>Role for the user. Can be empty or omitted.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserRoleProperty
    {
        /// <summary>
        /// Enum Owner for value: owner
        /// </summary>
        [EnumMember(Value = "owner")]
        Owner = 1,

        /// <summary>
        /// Enum Demo for value: demo
        /// </summary>
        [EnumMember(Value = "demo")]
        Demo = 2,

        /// <summary>
        /// Enum Null for value: null
        /// </summary>
        [EnumMember(Value = "null")]
        Null = 3
    }

}
