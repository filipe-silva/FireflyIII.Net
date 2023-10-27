/*
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 1.4.0
 * Contact: james@firefly-iii.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using FireflyIIINet.Client;
using FireflyIIINet.Client.Auth;
using FireflyIIINet.Model;

namespace FireflyIIINet.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Search for accounts
        /// </summary>
        /// <remarks>
        /// Search for accounts
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="type">The type of accounts you wish to limit the search to.</param>
        /// <param name="field">The account field(s) you want to search in.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AccountArray</returns>
        AccountArray SearchAccounts(string query, AccountTypeFilter type, AccountSearchFieldFilter field, int? page = default(int?), int operationIndex = 0);

        /// <summary>
        /// Search for accounts
        /// </summary>
        /// <remarks>
        /// Search for accounts
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="type">The type of accounts you wish to limit the search to.</param>
        /// <param name="field">The account field(s) you want to search in.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AccountArray</returns>
        ApiResponse<AccountArray> SearchAccountsWithHttpInfo(string query, AccountTypeFilter type, AccountSearchFieldFilter field, int? page = default(int?), int operationIndex = 0);
        /// <summary>
        /// Search for transactions
        /// </summary>
        /// <remarks>
        /// Search for transactions
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TransactionArray</returns>
        TransactionArray SearchTransactions(string query, int? page = default(int?), int operationIndex = 0);

        /// <summary>
        /// Search for transactions
        /// </summary>
        /// <remarks>
        /// Search for transactions
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TransactionArray</returns>
        ApiResponse<TransactionArray> SearchTransactionsWithHttpInfo(string query, int? page = default(int?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Search for accounts
        /// </summary>
        /// <remarks>
        /// Search for accounts
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="type">The type of accounts you wish to limit the search to.</param>
        /// <param name="field">The account field(s) you want to search in.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountArray</returns>
        System.Threading.Tasks.Task<AccountArray> SearchAccountsAsync(string query, AccountTypeFilter type, AccountSearchFieldFilter field, int? page = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Search for accounts
        /// </summary>
        /// <remarks>
        /// Search for accounts
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="type">The type of accounts you wish to limit the search to.</param>
        /// <param name="field">The account field(s) you want to search in.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountArray)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountArray>> SearchAccountsWithHttpInfoAsync(string query, AccountTypeFilter type, AccountSearchFieldFilter field, int? page = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Search for transactions
        /// </summary>
        /// <remarks>
        /// Search for transactions
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TransactionArray</returns>
        System.Threading.Tasks.Task<TransactionArray> SearchTransactionsAsync(string query, int? page = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Search for transactions
        /// </summary>
        /// <remarks>
        /// Search for transactions
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TransactionArray)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionArray>> SearchTransactionsWithHttpInfoAsync(string query, int? page = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApi : ISearchApiSync, ISearchApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SearchApi : ISearchApi
    {
        private FireflyIIINet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(string basePath)
        {
            this.Configuration = FireflyIIINet.Client.Configuration.MergeConfigurations(
                FireflyIIINet.Client.GlobalConfiguration.Instance,
                new FireflyIIINet.Client.Configuration { BasePath = basePath }
            );
            this.Client = new FireflyIIINet.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FireflyIIINet.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = FireflyIIINet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchApi(FireflyIIINet.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = FireflyIIINet.Client.Configuration.MergeConfigurations(
                FireflyIIINet.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new FireflyIIINet.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FireflyIIINet.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = FireflyIIINet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SearchApi(FireflyIIINet.Client.ISynchronousClient client, FireflyIIINet.Client.IAsynchronousClient asyncClient, FireflyIIINet.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = FireflyIIINet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public FireflyIIINet.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public FireflyIIINet.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public FireflyIIINet.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FireflyIIINet.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Search for accounts Search for accounts
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="type">The type of accounts you wish to limit the search to.</param>
        /// <param name="field">The account field(s) you want to search in.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AccountArray</returns>
        public AccountArray SearchAccounts(string query, AccountTypeFilter type, AccountSearchFieldFilter field, int? page = default(int?), int operationIndex = 0)
        {
            FireflyIIINet.Client.ApiResponse<AccountArray> localVarResponse = SearchAccountsWithHttpInfo(query, type, field, page);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search for accounts Search for accounts
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="type">The type of accounts you wish to limit the search to.</param>
        /// <param name="field">The account field(s) you want to search in.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AccountArray</returns>
        public FireflyIIINet.Client.ApiResponse<AccountArray> SearchAccountsWithHttpInfo(string query, AccountTypeFilter type, AccountSearchFieldFilter field, int? page = default(int?), int operationIndex = 0)
        {
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new FireflyIIINet.Client.ApiException(400, "Missing required parameter 'query' when calling SearchApi->SearchAccounts");
            }

            // verify the required parameter 'type' is set
            if (type == null)
            {
                throw new FireflyIIINet.Client.ApiException(400, "Missing required parameter 'type' when calling SearchApi->SearchAccounts");
            }

            // verify the required parameter 'field' is set
            if (field == null)
            {
                throw new FireflyIIINet.Client.ApiException(400, "Missing required parameter 'field' when calling SearchApi->SearchAccounts");
            }

            FireflyIIINet.Client.RequestOptions localVarRequestOptions = new FireflyIIINet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = FireflyIIINet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FireflyIIINet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "query", query));
            localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "field", field));

            localVarRequestOptions.Operation = "SearchApi.SearchAccounts";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (firefly_iii_auth) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AccountArray>("/api/v1/search/accounts", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SearchAccounts", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search for accounts Search for accounts
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="type">The type of accounts you wish to limit the search to.</param>
        /// <param name="field">The account field(s) you want to search in.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountArray</returns>
        public async System.Threading.Tasks.Task<AccountArray> SearchAccountsAsync(string query, AccountTypeFilter type, AccountSearchFieldFilter field, int? page = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FireflyIIINet.Client.ApiResponse<AccountArray> localVarResponse = await SearchAccountsWithHttpInfoAsync(query, type, field, page, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search for accounts Search for accounts
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="type">The type of accounts you wish to limit the search to.</param>
        /// <param name="field">The account field(s) you want to search in.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountArray)</returns>
        public async System.Threading.Tasks.Task<FireflyIIINet.Client.ApiResponse<AccountArray>> SearchAccountsWithHttpInfoAsync(string query, AccountTypeFilter type, AccountSearchFieldFilter field, int? page = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new FireflyIIINet.Client.ApiException(400, "Missing required parameter 'query' when calling SearchApi->SearchAccounts");
            }

            // verify the required parameter 'type' is set
            if (type == null)
            {
                throw new FireflyIIINet.Client.ApiException(400, "Missing required parameter 'type' when calling SearchApi->SearchAccounts");
            }

            // verify the required parameter 'field' is set
            if (field == null)
            {
                throw new FireflyIIINet.Client.ApiException(400, "Missing required parameter 'field' when calling SearchApi->SearchAccounts");
            }


            FireflyIIINet.Client.RequestOptions localVarRequestOptions = new FireflyIIINet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = FireflyIIINet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FireflyIIINet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "query", query));
            localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "field", field));

            localVarRequestOptions.Operation = "SearchApi.SearchAccounts";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (firefly_iii_auth) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AccountArray>("/api/v1/search/accounts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SearchAccounts", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search for transactions Search for transactions
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TransactionArray</returns>
        public TransactionArray SearchTransactions(string query, int? page = default(int?), int operationIndex = 0)
        {
            FireflyIIINet.Client.ApiResponse<TransactionArray> localVarResponse = SearchTransactionsWithHttpInfo(query, page);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search for transactions Search for transactions
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TransactionArray</returns>
        public FireflyIIINet.Client.ApiResponse<TransactionArray> SearchTransactionsWithHttpInfo(string query, int? page = default(int?), int operationIndex = 0)
        {
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new FireflyIIINet.Client.ApiException(400, "Missing required parameter 'query' when calling SearchApi->SearchTransactions");
            }

            FireflyIIINet.Client.RequestOptions localVarRequestOptions = new FireflyIIINet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = FireflyIIINet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FireflyIIINet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "query", query));
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }

            localVarRequestOptions.Operation = "SearchApi.SearchTransactions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (firefly_iii_auth) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<TransactionArray>("/api/v1/search/transactions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SearchTransactions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search for transactions Search for transactions
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TransactionArray</returns>
        public async System.Threading.Tasks.Task<TransactionArray> SearchTransactionsAsync(string query, int? page = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FireflyIIINet.Client.ApiResponse<TransactionArray> localVarResponse = await SearchTransactionsWithHttpInfoAsync(query, page, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search for transactions Search for transactions
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query you wish to search for.</param>
        /// <param name="page">Page number. The default pagination is 50 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TransactionArray)</returns>
        public async System.Threading.Tasks.Task<FireflyIIINet.Client.ApiResponse<TransactionArray>> SearchTransactionsWithHttpInfoAsync(string query, int? page = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new FireflyIIINet.Client.ApiException(400, "Missing required parameter 'query' when calling SearchApi->SearchTransactions");
            }


            FireflyIIINet.Client.RequestOptions localVarRequestOptions = new FireflyIIINet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = FireflyIIINet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FireflyIIINet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "query", query));
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }

            localVarRequestOptions.Operation = "SearchApi.SearchTransactions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (firefly_iii_auth) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<TransactionArray>("/api/v1/search/transactions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SearchTransactions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
