/*
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 1.0.1
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

using FireflyIIINet.Client;
using FireflyIIINet.Api;
// uncomment below to import models
//using FireflyIIINet.Model;

namespace FireflyIIINet.Test.Api
{
    /// <summary>
    ///  Class for testing AboutApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AboutApiTests : IDisposable
    {
        private AboutApi instance;

        public AboutApiTests()
        {
            instance = new AboutApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AboutApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AboutApi
            //Assert.IsType<AboutApi>(instance);
        }

        /// <summary>
        /// Test GetAbout
        /// </summary>
        [Fact]
        public void GetAboutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAbout();
            //Assert.IsType<SystemInfo>(response);
        }

        /// <summary>
        /// Test GetCurrentUser
        /// </summary>
        [Fact]
        public void GetCurrentUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCurrentUser();
            //Assert.IsType<UserSingle>(response);
        }
    }
}
