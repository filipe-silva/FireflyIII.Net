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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading;
using System.Threading.Tasks;
using FireflyIIINet.Client;
using FireflyIIINet.Client.Auth;
using FireflyIIINet.Model;
using ConfigurationClient = FireflyIIINet.Client.Configuration;

namespace FireflyIIINet.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAboutApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// System information end point.
        /// </summary>
        /// <remarks>
        /// Returns general system information and versions of the (supporting) software. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SystemInfo</returns>
        SystemInfo GetAbout(Guid? xTraceId = default(Guid?), int operationIndex = 0);

        /// <summary>
        /// System information end point.
        /// </summary>
        /// <remarks>
        /// Returns general system information and versions of the (supporting) software. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SystemInfo</returns>
        ApiResponse<SystemInfo> GetAboutWithHttpInfo(Guid? xTraceId = default(Guid?), int operationIndex = 0);
        /// <summary>
        /// Cron job endpoint
        /// </summary>
        /// <remarks>
        /// Firefly III has one endpoint for its various cron related tasks. Send a GET to this endpoint to run the cron. The cron requires the CLI token to be present. The cron job will fire for all users. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cliToken">The CLI token of any user in Firefly III, required to run the cron job.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="date">A date formatted YYYY-MM-DD. This can be used to make the cron job pretend it&#39;s running on another day.  (optional)</param>
        /// <param name="force">Forces the cron job to fire, regardless of whether it has fired before. This may result in double transactions or weird budgets, so be careful.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CronResult</returns>
        CronResult GetCron(string cliToken, Guid? xTraceId = default(Guid?), DateTime? date = default(DateTime?), bool? force = default(bool?), int operationIndex = 0);

        /// <summary>
        /// Cron job endpoint
        /// </summary>
        /// <remarks>
        /// Firefly III has one endpoint for its various cron related tasks. Send a GET to this endpoint to run the cron. The cron requires the CLI token to be present. The cron job will fire for all users. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cliToken">The CLI token of any user in Firefly III, required to run the cron job.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="date">A date formatted YYYY-MM-DD. This can be used to make the cron job pretend it&#39;s running on another day.  (optional)</param>
        /// <param name="force">Forces the cron job to fire, regardless of whether it has fired before. This may result in double transactions or weird budgets, so be careful.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CronResult</returns>
        ApiResponse<CronResult> GetCronWithHttpInfo(string cliToken, Guid? xTraceId = default(Guid?), DateTime? date = default(DateTime?), bool? force = default(bool?), int operationIndex = 0);
        /// <summary>
        /// Currently authenticated user endpoint.
        /// </summary>
        /// <remarks>
        /// Returns the currently authenticated user. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserSingle</returns>
        UserSingle GetCurrentUser(Guid? xTraceId = default(Guid?), int operationIndex = 0);

        /// <summary>
        /// Currently authenticated user endpoint.
        /// </summary>
        /// <remarks>
        /// Returns the currently authenticated user. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserSingle</returns>
        ApiResponse<UserSingle> GetCurrentUserWithHttpInfo(Guid? xTraceId = default(Guid?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAboutApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// System information end point.
        /// </summary>
        /// <remarks>
        /// Returns general system information and versions of the (supporting) software. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SystemInfo</returns>
        Task<SystemInfo> GetAboutAsync(Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// System information end point.
        /// </summary>
        /// <remarks>
        /// Returns general system information and versions of the (supporting) software. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SystemInfo)</returns>
        Task<ApiResponse<SystemInfo>> GetAboutWithHttpInfoAsync(Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cron job endpoint
        /// </summary>
        /// <remarks>
        /// Firefly III has one endpoint for its various cron related tasks. Send a GET to this endpoint to run the cron. The cron requires the CLI token to be present. The cron job will fire for all users. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cliToken">The CLI token of any user in Firefly III, required to run the cron job.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="date">A date formatted YYYY-MM-DD. This can be used to make the cron job pretend it&#39;s running on another day.  (optional)</param>
        /// <param name="force">Forces the cron job to fire, regardless of whether it has fired before. This may result in double transactions or weird budgets, so be careful.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CronResult</returns>
        Task<CronResult> GetCronAsync(string cliToken, Guid? xTraceId = default(Guid?), DateTime? date = default(DateTime?), bool? force = default(bool?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Cron job endpoint
        /// </summary>
        /// <remarks>
        /// Firefly III has one endpoint for its various cron related tasks. Send a GET to this endpoint to run the cron. The cron requires the CLI token to be present. The cron job will fire for all users. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cliToken">The CLI token of any user in Firefly III, required to run the cron job.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="date">A date formatted YYYY-MM-DD. This can be used to make the cron job pretend it&#39;s running on another day.  (optional)</param>
        /// <param name="force">Forces the cron job to fire, regardless of whether it has fired before. This may result in double transactions or weird budgets, so be careful.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CronResult)</returns>
        Task<ApiResponse<CronResult>> GetCronWithHttpInfoAsync(string cliToken, Guid? xTraceId = default(Guid?), DateTime? date = default(DateTime?), bool? force = default(bool?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Currently authenticated user endpoint.
        /// </summary>
        /// <remarks>
        /// Returns the currently authenticated user. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UserSingle</returns>
        Task<UserSingle> GetCurrentUserAsync(Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Currently authenticated user endpoint.
        /// </summary>
        /// <remarks>
        /// Returns the currently authenticated user. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UserSingle)</returns>
        Task<ApiResponse<UserSingle>> GetCurrentUserWithHttpInfoAsync(Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAboutApi : IAboutApiSync, IAboutApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AboutApi : IAboutApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AboutApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AboutApi(string basePath) : this(new ConfigurationClient { BasePath = basePath })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AboutApi(ConfigurationClient configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            Configuration = ConfigurationClient.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            Client = new ApiClient(Configuration.BasePath);
            AsynchronousClient = new ApiClient(Configuration.BasePath);
            ExceptionFactory = ConfigurationClient.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AboutApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (asyncClient == null) throw new ArgumentNullException(nameof(asyncClient));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            Client = client;
            AsynchronousClient = asyncClient;
            Configuration = configuration;
            ExceptionFactory = ConfigurationClient.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
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
        /// Provides a common RequestOptions object for all operations.
        /// </summary>
		private RequestOptions GetRequestOptions(string[] _contentTypes, string[] _accepts, string operationId, int operationIndex)
		{
            RequestOptions localVarRequestOptions = new RequestOptions();
            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Operation = operationId;
            localVarRequestOptions.OperationIndex = operationIndex;

            return localVarRequestOptions;
		}

        /// <summary>
        /// Sets RequestOptions Authorization headers with bearer or oauth.
        /// </summary>
        private RequestOptions SetAuthorization(RequestOptions localVarRequestOptions)
        {
			// oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }
            return localVarRequestOptions;
		}

        /// <summary>
        /// Validates if operation has an exception and rethrows it.
        /// </summary>
        private void ValidateException(string operationName, IApiResponse localVarResponse)
        {
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory(operationName, localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }
		}

        /// <summary>
        /// Provides a specific RequestOptions object for GetAbout.
        /// </summary>
		private RequestOptions GetRequestOptionsGetAbout(Guid? xTraceId = default(Guid?), int operationIndex = 0)
		{
            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            RequestOptions localVarRequestOptions = GetRequestOptions(_contentTypes, _accepts,"AboutApi.GetAbout" ,operationIndex);

            if (xTraceId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Trace-Id", ClientUtils.ParameterToString(xTraceId)); // header parameter
            }

            // authentication (firefly_iii_auth) required
            localVarRequestOptions = SetAuthorization(localVarRequestOptions);
			return localVarRequestOptions;
		}

        /// <summary>
        /// System information end point. Returns general system information and versions of the (supporting) software. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SystemInfo</returns>
        public SystemInfo GetAbout(Guid? xTraceId = default(Guid?), int operationIndex = 0)
        {
            ApiResponse<SystemInfo> localVarResponse = GetAboutWithHttpInfo(xTraceId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// System information end point. Returns general system information and versions of the (supporting) software. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SystemInfo</returns>
        public ApiResponse<SystemInfo> GetAboutWithHttpInfo(Guid? xTraceId = default(Guid?), int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = GetRequestOptionsGetAbout(xTraceId, operationIndex);

            // make the HTTP request
            var localVarResponse = Client.Get<SystemInfo>("/v1/about", localVarRequestOptions, Configuration);
            ValidateException("GetAbout", localVarResponse);
            return localVarResponse;
        }

        /// <summary>
        /// System information end point. Returns general system information and versions of the (supporting) software. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SystemInfo</returns>
        public async Task<SystemInfo> GetAboutAsync(Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken))
        {
            ApiResponse<SystemInfo> localVarResponse = await GetAboutWithHttpInfoAsync(xTraceId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// System information end point. Returns general system information and versions of the (supporting) software. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SystemInfo)</returns>
        public async Task<ApiResponse<SystemInfo>> GetAboutWithHttpInfoAsync(Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken))
        {
            RequestOptions localVarRequestOptions = GetRequestOptionsGetAbout(xTraceId, operationIndex);

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<SystemInfo>("/v1/about", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);
            ValidateException("GetAbout", localVarResponse);
            return localVarResponse;
        }

        /// <summary>
        /// Provides a specific RequestOptions object for GetCron.
        /// </summary>
		private RequestOptions GetRequestOptionsGetCron(string cliToken, Guid? xTraceId = default(Guid?), DateTime? date = default(DateTime?), bool? force = default(bool?), int operationIndex = 0)
		{
            // verify the required parameter 'cliToken' is set
            if (cliToken == null)
            {
                throw new ApiException(400, "Missing required parameter 'cliToken' when calling AboutApi->GetCron");
            }

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            RequestOptions localVarRequestOptions = GetRequestOptions(_contentTypes, _accepts,"AboutApi.GetCron" ,operationIndex);

            localVarRequestOptions.PathParameters.Add("cliToken", ClientUtils.ParameterToString(cliToken)); // path parameter
            if (date != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "date", date));
            }
            if (force != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "force", force));
            }
            if (xTraceId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Trace-Id", ClientUtils.ParameterToString(xTraceId)); // header parameter
            }

            // authentication (firefly_iii_auth) required
            localVarRequestOptions = SetAuthorization(localVarRequestOptions);
			return localVarRequestOptions;
		}

        /// <summary>
        /// Cron job endpoint Firefly III has one endpoint for its various cron related tasks. Send a GET to this endpoint to run the cron. The cron requires the CLI token to be present. The cron job will fire for all users. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cliToken">The CLI token of any user in Firefly III, required to run the cron job.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="date">A date formatted YYYY-MM-DD. This can be used to make the cron job pretend it&#39;s running on another day.  (optional)</param>
        /// <param name="force">Forces the cron job to fire, regardless of whether it has fired before. This may result in double transactions or weird budgets, so be careful.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CronResult</returns>
        public CronResult GetCron(string cliToken, Guid? xTraceId = default(Guid?), DateTime? date = default(DateTime?), bool? force = default(bool?), int operationIndex = 0)
        {
            ApiResponse<CronResult> localVarResponse = GetCronWithHttpInfo(cliToken, xTraceId, date, force);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cron job endpoint Firefly III has one endpoint for its various cron related tasks. Send a GET to this endpoint to run the cron. The cron requires the CLI token to be present. The cron job will fire for all users. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cliToken">The CLI token of any user in Firefly III, required to run the cron job.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="date">A date formatted YYYY-MM-DD. This can be used to make the cron job pretend it&#39;s running on another day.  (optional)</param>
        /// <param name="force">Forces the cron job to fire, regardless of whether it has fired before. This may result in double transactions or weird budgets, so be careful.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CronResult</returns>
        public ApiResponse<CronResult> GetCronWithHttpInfo(string cliToken, Guid? xTraceId = default(Guid?), DateTime? date = default(DateTime?), bool? force = default(bool?), int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = GetRequestOptionsGetCron(cliToken, xTraceId, date, force, operationIndex);

            // make the HTTP request
            var localVarResponse = Client.Get<CronResult>("/v1/cron/{cliToken}", localVarRequestOptions, Configuration);
            ValidateException("GetCron", localVarResponse);
            return localVarResponse;
        }

        /// <summary>
        /// Cron job endpoint Firefly III has one endpoint for its various cron related tasks. Send a GET to this endpoint to run the cron. The cron requires the CLI token to be present. The cron job will fire for all users. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cliToken">The CLI token of any user in Firefly III, required to run the cron job.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="date">A date formatted YYYY-MM-DD. This can be used to make the cron job pretend it&#39;s running on another day.  (optional)</param>
        /// <param name="force">Forces the cron job to fire, regardless of whether it has fired before. This may result in double transactions or weird budgets, so be careful.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CronResult</returns>
        public async Task<CronResult> GetCronAsync(string cliToken, Guid? xTraceId = default(Guid?), DateTime? date = default(DateTime?), bool? force = default(bool?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken))
        {
            ApiResponse<CronResult> localVarResponse = await GetCronWithHttpInfoAsync(cliToken, xTraceId, date, force, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cron job endpoint Firefly III has one endpoint for its various cron related tasks. Send a GET to this endpoint to run the cron. The cron requires the CLI token to be present. The cron job will fire for all users. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cliToken">The CLI token of any user in Firefly III, required to run the cron job.</param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="date">A date formatted YYYY-MM-DD. This can be used to make the cron job pretend it&#39;s running on another day.  (optional)</param>
        /// <param name="force">Forces the cron job to fire, regardless of whether it has fired before. This may result in double transactions or weird budgets, so be careful.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CronResult)</returns>
        public async Task<ApiResponse<CronResult>> GetCronWithHttpInfoAsync(string cliToken, Guid? xTraceId = default(Guid?), DateTime? date = default(DateTime?), bool? force = default(bool?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken))
        {
            RequestOptions localVarRequestOptions = GetRequestOptionsGetCron(cliToken, xTraceId, date, force, operationIndex);

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<CronResult>("/v1/cron/{cliToken}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);
            ValidateException("GetCron", localVarResponse);
            return localVarResponse;
        }

        /// <summary>
        /// Provides a specific RequestOptions object for GetCurrentUser.
        /// </summary>
		private RequestOptions GetRequestOptionsGetCurrentUser(Guid? xTraceId = default(Guid?), int operationIndex = 0)
		{
            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "application/vnd.api+json"
            };

            RequestOptions localVarRequestOptions = GetRequestOptions(_contentTypes, _accepts,"AboutApi.GetCurrentUser" ,operationIndex);

            if (xTraceId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Trace-Id", ClientUtils.ParameterToString(xTraceId)); // header parameter
            }

            // authentication (firefly_iii_auth) required
            localVarRequestOptions = SetAuthorization(localVarRequestOptions);
			return localVarRequestOptions;
		}

        /// <summary>
        /// Currently authenticated user endpoint. Returns the currently authenticated user. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserSingle</returns>
        public UserSingle GetCurrentUser(Guid? xTraceId = default(Guid?), int operationIndex = 0)
        {
            ApiResponse<UserSingle> localVarResponse = GetCurrentUserWithHttpInfo(xTraceId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Currently authenticated user endpoint. Returns the currently authenticated user. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserSingle</returns>
        public ApiResponse<UserSingle> GetCurrentUserWithHttpInfo(Guid? xTraceId = default(Guid?), int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = GetRequestOptionsGetCurrentUser(xTraceId, operationIndex);

            // make the HTTP request
            var localVarResponse = Client.Get<UserSingle>("/v1/about/user", localVarRequestOptions, Configuration);
            ValidateException("GetCurrentUser", localVarResponse);
            return localVarResponse;
        }

        /// <summary>
        /// Currently authenticated user endpoint. Returns the currently authenticated user. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UserSingle</returns>
        public async Task<UserSingle> GetCurrentUserAsync(Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken))
        {
            ApiResponse<UserSingle> localVarResponse = await GetCurrentUserWithHttpInfoAsync(xTraceId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Currently authenticated user endpoint. Returns the currently authenticated user. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UserSingle)</returns>
        public async Task<ApiResponse<UserSingle>> GetCurrentUserWithHttpInfoAsync(Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken))
        {
            RequestOptions localVarRequestOptions = GetRequestOptionsGetCurrentUser(xTraceId, operationIndex);

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<UserSingle>("/v1/about/user", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);
            ValidateException("GetCurrentUser", localVarResponse);
            return localVarResponse;
        }
    }
}
