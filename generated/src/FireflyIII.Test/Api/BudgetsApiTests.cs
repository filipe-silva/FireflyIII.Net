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
    ///  Class for testing BudgetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BudgetsApiTests : IDisposable
    {
        private BudgetsApi instance;

        public BudgetsApiTests()
        {
            instance = new BudgetsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BudgetsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BudgetsApi
            //Assert.IsType(typeof(BudgetsApi), instance, "instance is a BudgetsApi");
        }

        
        /// <summary>
        /// Test DeleteBudget
        /// </summary>
        [Fact]
        public void DeleteBudgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.DeleteBudget(id);
            
        }
        
        /// <summary>
        /// Test DeleteBudgetLimit
        /// </summary>
        [Fact]
        public void DeleteBudgetLimitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.DeleteBudgetLimit(id);
            
        }
        
        /// <summary>
        /// Test GetBudget
        /// </summary>
        [Fact]
        public void GetBudgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //var response = instance.GetBudget(id, startDate, endDate);
            //Assert.IsType<BudgetSingle> (response, "response is BudgetSingle");
        }
        
        /// <summary>
        /// Test GetBudgetLimit
        /// </summary>
        [Fact]
        public void GetBudgetLimitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.GetBudgetLimit(id);
            //Assert.IsType<BudgetLimitSingle> (response, "response is BudgetLimitSingle");
        }
        
        /// <summary>
        /// Test ListBudget
        /// </summary>
        [Fact]
        public void ListBudgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //var response = instance.ListBudget(page, start, end);
            //Assert.IsType<BudgetArray> (response, "response is BudgetArray");
        }
        
        /// <summary>
        /// Test ListBudgetLimitByBudget
        /// </summary>
        [Fact]
        public void ListBudgetLimitByBudgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //var response = instance.ListBudgetLimitByBudget(id, start, end);
            //Assert.IsType<BudgetLimitArray> (response, "response is BudgetLimitArray");
        }
        
        /// <summary>
        /// Test ListTransactionByBudget
        /// </summary>
        [Fact]
        public void ListTransactionByBudgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? limit = null;
            //int? page = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //TransactionTypeFilter type = null;
            //var response = instance.ListTransactionByBudget(id, limit, page, start, end, type);
            //Assert.IsType<TransactionArray> (response, "response is TransactionArray");
        }
        
        /// <summary>
        /// Test ListTransactionByBudgetLimit
        /// </summary>
        [Fact]
        public void ListTransactionByBudgetLimitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? page = null;
            //TransactionTypeFilter type = null;
            //var response = instance.ListTransactionByBudgetLimit(id, page, type);
            //Assert.IsType<TransactionArray> (response, "response is TransactionArray");
        }
        
        /// <summary>
        /// Test StoreBudget
        /// </summary>
        [Fact]
        public void StoreBudgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Budget budget = null;
            //var response = instance.StoreBudget(budget);
            //Assert.IsType<BudgetSingle> (response, "response is BudgetSingle");
        }
        
        /// <summary>
        /// Test StoreBudgetLimit
        /// </summary>
        [Fact]
        public void StoreBudgetLimitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //BudgetLimit budgetLimit = null;
            //var response = instance.StoreBudgetLimit(id, budgetLimit);
            //Assert.IsType<BudgetLimitSingle> (response, "response is BudgetLimitSingle");
        }
        
        /// <summary>
        /// Test UpdateBudget
        /// </summary>
        [Fact]
        public void UpdateBudgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //Budget budget = null;
            //var response = instance.UpdateBudget(id, budget);
            //Assert.IsType<BudgetSingle> (response, "response is BudgetSingle");
        }
        
        /// <summary>
        /// Test UpdateBudgetLimit
        /// </summary>
        [Fact]
        public void UpdateBudgetLimitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //BudgetLimit budgetLimit = null;
            //var response = instance.UpdateBudgetLimit(id, budgetLimit);
            //Assert.IsType<BudgetLimitSingle> (response, "response is BudgetLimitSingle");
        }
        
    }

}
