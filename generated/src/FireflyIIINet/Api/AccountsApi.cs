/*
 * Firefly III API v2.0.8
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-09-16T02:55:22+00:00  Please keep in mind that the demo site does not accept requests from curl, colly, wget, etc. You must use a browser or a tool like Postman to make requests. Too many script kiddies out there, sorry about that. 
 *
 * The version of the OpenAPI document: 2.0.8
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
    public interface IAccountsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List all transactions related to the account.
        /// </summary>
        /// <remarks>
        /// This endpoint returns a list of all the transactions connected to the account. 
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the account.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="page">Page number. The default pagination is per 50 items. (optional)</param>
        /// <param name="limit">Limits the number of results on one page. (optional)</param>
        /// <param name="start">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="end">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="type">Optional filter on the transaction type(s) returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TransactionArray</returns>
        TransactionArray ListTransactionByAccount(string id, Guid? xTraceId = default(Guid?), int? page = default(int?), int? limit = default(int?), DateTime? start = default(DateTime?), DateTime? end = default(DateTime?), TransactionTypeFilter? type = default(TransactionTypeFilter?), int operationIndex = 0);

        /// <summary>
        /// List all transactions related to the account.
        /// </summary>
        /// <remarks>
        /// This endpoint returns a list of all the transactions connected to the account. 
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the account.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="page">Page number. The default pagination is per 50 items. (optional)</param>
        /// <param name="limit">Limits the number of results on one page. (optional)</param>
        /// <param name="start">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="end">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="type">Optional filter on the transaction type(s) returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TransactionArray</returns>
        ApiResponse<TransactionArray> ListTransactionByAccountWithHttpInfo(string id, Guid? xTraceId = default(Guid?), int? page = default(int?), int? limit = default(int?), DateTime? start = default(DateTime?), DateTime? end = default(DateTime?), TransactionTypeFilter? type = default(TransactionTypeFilter?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List all transactions related to the account.
        /// </summary>
        /// <remarks>
        /// This endpoint returns a list of all the transactions connected to the account. 
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the account.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="page">Page number. The default pagination is per 50 items. (optional)</param>
        /// <param name="limit">Limits the number of results on one page. (optional)</param>
        /// <param name="start">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="end">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="type">Optional filter on the transaction type(s) returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TransactionArray</returns>
        System.Threading.Tasks.Task<TransactionArray> ListTransactionByAccountAsync(string id, Guid? xTraceId = default(Guid?), int? page = default(int?), int? limit = default(int?), DateTime? start = default(DateTime?), DateTime? end = default(DateTime?), TransactionTypeFilter? type = default(TransactionTypeFilter?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all transactions related to the account.
        /// </summary>
        /// <remarks>
        /// This endpoint returns a list of all the transactions connected to the account. 
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the account.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="page">Page number. The default pagination is per 50 items. (optional)</param>
        /// <param name="limit">Limits the number of results on one page. (optional)</param>
        /// <param name="start">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="end">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="type">Optional filter on the transaction type(s) returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TransactionArray)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionArray>> ListTransactionByAccountWithHttpInfoAsync(string id, Guid? xTraceId = default(Guid?), int? page = default(int?), int? limit = default(int?), DateTime? start = default(DateTime?), DateTime? end = default(DateTime?), TransactionTypeFilter? type = default(TransactionTypeFilter?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApi : IAccountsApiSync, IAccountsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountsApi : IAccountsApi
    {
        private FireflyIIINet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountsApi(FireflyIIINet.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AccountsApi(FireflyIIINet.Client.ISynchronousClient client, FireflyIIINet.Client.IAsynchronousClient asyncClient, FireflyIIINet.Client.IReadableConfiguration configuration)
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
        /// List all transactions related to the account. This endpoint returns a list of all the transactions connected to the account. 
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the account.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="page">Page number. The default pagination is per 50 items. (optional)</param>
        /// <param name="limit">Limits the number of results on one page. (optional)</param>
        /// <param name="start">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="end">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="type">Optional filter on the transaction type(s) returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TransactionArray</returns>
        public TransactionArray ListTransactionByAccount(string id, Guid? xTraceId = default(Guid?), int? page = default(int?), int? limit = default(int?), DateTime? start = default(DateTime?), DateTime? end = default(DateTime?), TransactionTypeFilter? type = default(TransactionTypeFilter?), int operationIndex = 0)
        {
            FireflyIIINet.Client.ApiResponse<TransactionArray> localVarResponse = ListTransactionByAccountWithHttpInfo(id, xTraceId, page, limit, start, end, type);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all transactions related to the account. This endpoint returns a list of all the transactions connected to the account. 
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the account.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="page">Page number. The default pagination is per 50 items. (optional)</param>
        /// <param name="limit">Limits the number of results on one page. (optional)</param>
        /// <param name="start">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="end">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="type">Optional filter on the transaction type(s) returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TransactionArray</returns>
        public FireflyIIINet.Client.ApiResponse<TransactionArray> ListTransactionByAccountWithHttpInfo(string id, Guid? xTraceId = default(Guid?), int? page = default(int?), int? limit = default(int?), DateTime? start = default(DateTime?), DateTime? end = default(DateTime?), TransactionTypeFilter? type = default(TransactionTypeFilter?), int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new FireflyIIINet.Client.ApiException(400, "Missing required parameter 'id' when calling AccountsApi->ListTransactionByAccount");
            }

            FireflyIIINet.Client.RequestOptions localVarRequestOptions = new FireflyIIINet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "application/vnd.api+json"
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

            localVarRequestOptions.PathParameters.Add("id", FireflyIIINet.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            }
            if (end != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "end", end));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (xTraceId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Trace-Id", FireflyIIINet.Client.ClientUtils.ParameterToString(xTraceId)); // header parameter
            }

            localVarRequestOptions.Operation = "AccountsApi.ListTransactionByAccount";
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
            var localVarResponse = this.Client.Get<TransactionArray>("/v2/accounts/{id}/transactions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListTransactionByAccount", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all transactions related to the account. This endpoint returns a list of all the transactions connected to the account. 
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the account.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="page">Page number. The default pagination is per 50 items. (optional)</param>
        /// <param name="limit">Limits the number of results on one page. (optional)</param>
        /// <param name="start">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="end">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="type">Optional filter on the transaction type(s) returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TransactionArray</returns>
        public async System.Threading.Tasks.Task<TransactionArray> ListTransactionByAccountAsync(string id, Guid? xTraceId = default(Guid?), int? page = default(int?), int? limit = default(int?), DateTime? start = default(DateTime?), DateTime? end = default(DateTime?), TransactionTypeFilter? type = default(TransactionTypeFilter?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FireflyIIINet.Client.ApiResponse<TransactionArray> localVarResponse = await ListTransactionByAccountWithHttpInfoAsync(id, xTraceId, page, limit, start, end, type, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all transactions related to the account. This endpoint returns a list of all the transactions connected to the account. 
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the account.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="page">Page number. The default pagination is per 50 items. (optional)</param>
        /// <param name="limit">Limits the number of results on one page. (optional)</param>
        /// <param name="start">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="end">A date formatted YYYY-MM-DD.  (optional)</param>
        /// <param name="type">Optional filter on the transaction type(s) returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TransactionArray)</returns>
        public async System.Threading.Tasks.Task<FireflyIIINet.Client.ApiResponse<TransactionArray>> ListTransactionByAccountWithHttpInfoAsync(string id, Guid? xTraceId = default(Guid?), int? page = default(int?), int? limit = default(int?), DateTime? start = default(DateTime?), DateTime? end = default(DateTime?), TransactionTypeFilter? type = default(TransactionTypeFilter?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new FireflyIIINet.Client.ApiException(400, "Missing required parameter 'id' when calling AccountsApi->ListTransactionByAccount");
            }


            FireflyIIINet.Client.RequestOptions localVarRequestOptions = new FireflyIIINet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "application/vnd.api+json"
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

            localVarRequestOptions.PathParameters.Add("id", FireflyIIINet.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            }
            if (end != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "end", end));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (xTraceId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Trace-Id", FireflyIIINet.Client.ClientUtils.ParameterToString(xTraceId)); // header parameter
            }

            localVarRequestOptions.Operation = "AccountsApi.ListTransactionByAccount";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<TransactionArray>("/v2/accounts/{id}/transactions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListTransactionByAccount", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
