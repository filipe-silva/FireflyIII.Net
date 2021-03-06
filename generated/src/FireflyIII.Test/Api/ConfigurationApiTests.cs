/* 
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 0.10.4-modified
 * Contact: thegrumpydictator@gmail.com
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

using FireflyIII.Client;
using FireflyIII.Api;
using FireflyIII.Model;

namespace FireflyIII.Test
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
            // TODO uncomment below to test 'IsInstanceOfType' ConfigurationApi
            //Assert.IsType(typeof(ConfigurationApi), instance, "instance is a ConfigurationApi");
        }

        
        /// <summary>
        /// Test GetConfiguration
        /// </summary>
        [Fact]
        public void GetConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetConfiguration();
            //Assert.IsType<SystemConfiguration> (response, "response is SystemConfiguration");
        }
        
        /// <summary>
        /// Test SetConfiguration
        /// </summary>
        [Fact]
        public void SetConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string value = null;
            //var response = instance.SetConfiguration(name, value);
            //Assert.IsType<SystemConfiguration> (response, "response is SystemConfiguration");
        }
        
    }

}
