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
    public interface IChartsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Dashboard chart with asset account balance information.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ChartDataSet&gt;</returns>
        List<ChartDataSet> GetChartAccountOverview(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0);

        /// <summary>
        /// Dashboard chart with asset account balance information.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ChartDataSet&gt;</returns>
        ApiResponse<List<ChartDataSet>> GetChartAccountOverviewWithHttpInfo(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0);
        /// <summary>
        /// Dashboard chart with asset account balance information.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ChartDataSetV2&gt;</returns>
        List<ChartDataSetV2> GetChartAccountOverviewV2(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0);

        /// <summary>
        /// Dashboard chart with asset account balance information.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ChartDataSetV2&gt;</returns>
        ApiResponse<List<ChartDataSetV2>> GetChartAccountOverviewV2WithHttpInfo(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IChartsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Dashboard chart with asset account balance information.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ChartDataSet&gt;</returns>
        Task<List<ChartDataSet>> GetChartAccountOverviewAsync(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Dashboard chart with asset account balance information.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ChartDataSet&gt;)</returns>
        Task<ApiResponse<List<ChartDataSet>>> GetChartAccountOverviewWithHttpInfoAsync(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Dashboard chart with asset account balance information.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ChartDataSetV2&gt;</returns>
        Task<List<ChartDataSetV2>> GetChartAccountOverviewV2Async(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Dashboard chart with asset account balance information.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ChartDataSetV2&gt;)</returns>
        Task<ApiResponse<List<ChartDataSetV2>>> GetChartAccountOverviewV2WithHttpInfoAsync(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IChartsApi : IChartsApiSync, IChartsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ChartsApi : IChartsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChartsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChartsApi(string basePath) : this(new ConfigurationClient { BasePath = basePath })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ChartsApi(ConfigurationClient configuration)
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
        /// Initializes a new instance of the <see cref="ChartsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ChartsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Provides a specific RequestOptions object for GetChartAccountOverview.
        /// </summary>
		private RequestOptions GetRequestOptionsGetChartAccountOverview(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0)
		{
            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            RequestOptions localVarRequestOptions = GetRequestOptions(_contentTypes, _accepts,"ChartsApi.GetChartAccountOverview" ,operationIndex);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "start", start));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "end", end));
            if (xTraceId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Trace-Id", ClientUtils.ParameterToString(xTraceId)); // header parameter
            }

            // authentication (firefly_iii_auth) required
            localVarRequestOptions = SetAuthorization(localVarRequestOptions);
			return localVarRequestOptions;
		}

        /// <summary>
        /// Dashboard chart with asset account balance information. This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ChartDataSet&gt;</returns>
        public List<ChartDataSet> GetChartAccountOverview(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0)
        {
            ApiResponse<List<ChartDataSet>> localVarResponse = GetChartAccountOverviewWithHttpInfo(start, end, xTraceId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Dashboard chart with asset account balance information. This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ChartDataSet&gt;</returns>
        public ApiResponse<List<ChartDataSet>> GetChartAccountOverviewWithHttpInfo(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = GetRequestOptionsGetChartAccountOverview(start, end, xTraceId, operationIndex);

            // make the HTTP request
            var localVarResponse = Client.Get<List<ChartDataSet>>("/v1/chart/account/overview", localVarRequestOptions, Configuration);
            ValidateException("GetChartAccountOverview", localVarResponse);
            return localVarResponse;
        }

        /// <summary>
        /// Dashboard chart with asset account balance information. This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ChartDataSet&gt;</returns>
        public async Task<List<ChartDataSet>> GetChartAccountOverviewAsync(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken))
        {
            ApiResponse<List<ChartDataSet>> localVarResponse = await GetChartAccountOverviewWithHttpInfoAsync(start, end, xTraceId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Dashboard chart with asset account balance information. This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ChartDataSet&gt;)</returns>
        public async Task<ApiResponse<List<ChartDataSet>>> GetChartAccountOverviewWithHttpInfoAsync(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken))
        {
            RequestOptions localVarRequestOptions = GetRequestOptionsGetChartAccountOverview(start, end, xTraceId, operationIndex);

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<List<ChartDataSet>>("/v1/chart/account/overview", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);
            ValidateException("GetChartAccountOverview", localVarResponse);
            return localVarResponse;
        }

        /// <summary>
        /// Provides a specific RequestOptions object for GetChartAccountOverviewV2.
        /// </summary>
		private RequestOptions GetRequestOptionsGetChartAccountOverviewV2(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0)
		{
            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            RequestOptions localVarRequestOptions = GetRequestOptions(_contentTypes, _accepts,"ChartsApi.GetChartAccountOverviewV2" ,operationIndex);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "start", start));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "end", end));
            if (xTraceId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Trace-Id", ClientUtils.ParameterToString(xTraceId)); // header parameter
            }

            // authentication (firefly_iii_auth) required
            localVarRequestOptions = SetAuthorization(localVarRequestOptions);
			return localVarRequestOptions;
		}

        /// <summary>
        /// Dashboard chart with asset account balance information. This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ChartDataSetV2&gt;</returns>
        public List<ChartDataSetV2> GetChartAccountOverviewV2(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0)
        {
            ApiResponse<List<ChartDataSetV2>> localVarResponse = GetChartAccountOverviewV2WithHttpInfo(start, end, xTraceId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Dashboard chart with asset account balance information. This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ChartDataSetV2&gt;</returns>
        public ApiResponse<List<ChartDataSetV2>> GetChartAccountOverviewV2WithHttpInfo(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = GetRequestOptionsGetChartAccountOverviewV2(start, end, xTraceId, operationIndex);

            // make the HTTP request
            var localVarResponse = Client.Get<List<ChartDataSetV2>>("/v2/chart/account/dashboard", localVarRequestOptions, Configuration);
            ValidateException("GetChartAccountOverviewV2", localVarResponse);
            return localVarResponse;
        }

        /// <summary>
        /// Dashboard chart with asset account balance information. This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ChartDataSetV2&gt;</returns>
        public async Task<List<ChartDataSetV2>> GetChartAccountOverviewV2Async(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken))
        {
            ApiResponse<List<ChartDataSetV2>> localVarResponse = await GetChartAccountOverviewV2WithHttpInfoAsync(start, end, xTraceId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Dashboard chart with asset account balance information. This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="xTraceId">Unique identifier associated with this request. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ChartDataSetV2&gt;)</returns>
        public async Task<ApiResponse<List<ChartDataSetV2>>> GetChartAccountOverviewV2WithHttpInfoAsync(DateTime start, DateTime end, Guid? xTraceId = default(Guid?), int operationIndex = 0, CancellationToken cancellationToken = default(CancellationToken))
        {
            RequestOptions localVarRequestOptions = GetRequestOptionsGetChartAccountOverviewV2(start, end, xTraceId, operationIndex);

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<List<ChartDataSetV2>>("/v2/chart/account/dashboard", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);
            ValidateException("GetChartAccountOverviewV2", localVarResponse);
            return localVarResponse;
        }
    }
}
