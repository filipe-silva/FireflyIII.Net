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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using FireflyIIINet.Client;
using FireflyIIINet.Api;
// uncomment below to import models
//using FireflyIIINet.Model;

namespace FireflyIIINet.Test.Api
{
    /// <summary>
    ///  Class for testing ConfigurationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConfigurationApiTests : IDisposable
    {
        private ConfigurationApi instance;

        public ConfigurationApiTests()
        {
            instance = new ConfigurationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConfigurationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ConfigurationApi
            //Assert.IsType<ConfigurationApi>(instance);
        }

        /// <summary>
        /// Test GetConfiguration
        /// </summary>
        [Fact]
        public void GetConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? xTraceId = null;
            //var response = instance.GetConfiguration(xTraceId);
            //Assert.IsType<List<ModelConfiguration>>(response);
        }

        /// <summary>
        /// Test GetSingleConfiguration
        /// </summary>
        [Fact]
        public void GetSingleConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ConfigValueFilter name = null;
            //Guid? xTraceId = null;
            //var response = instance.GetSingleConfiguration(name, xTraceId);
            //Assert.IsType<ConfigurationSingle>(response);
        }

        /// <summary>
        /// Test SetConfiguration
        /// </summary>
        [Fact]
        public void SetConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ConfigValueUpdateFilter name = null;
            //PolymorphicProperty value = null;
            //Guid? xTraceId = null;
            //var response = instance.SetConfiguration(name, value, xTraceId);
            //Assert.IsType<ConfigurationSingle>(response);
        }
    }
}
