/*
 * Firefly III API v1.5.2
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2021-05-14T15:49:56+00:00 
 *
 * The version of the OpenAPI document: 1.5.2
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
    public interface IChartsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Dashboard chart with asset account balance information.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ChartDataSet&gt;</returns>
        List<ChartDataSet> GetChartAccountOverview(DateTime start, DateTime end, int operationIndex = 0);

        /// <summary>
        /// Dashboard chart with asset account balance information.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ChartDataSet&gt;</returns>
        ApiResponse<List<ChartDataSet>> GetChartAccountOverviewWithHttpInfo(DateTime start, DateTime end, int operationIndex = 0);
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
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ChartDataSet&gt;</returns>
        System.Threading.Tasks.Task<List<ChartDataSet>> GetChartAccountOverviewAsync(DateTime start, DateTime end, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Dashboard chart with asset account balance information.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ChartDataSet&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ChartDataSet>>> GetChartAccountOverviewWithHttpInfoAsync(DateTime start, DateTime end, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
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
        private FireflyIIINet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

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
        public ChartsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ChartsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ChartsApi(FireflyIIINet.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ChartsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ChartsApi(FireflyIIINet.Client.ISynchronousClient client, FireflyIIINet.Client.IAsynchronousClient asyncClient, FireflyIIINet.Client.IReadableConfiguration configuration)
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
        /// Dashboard chart with asset account balance information. This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ChartDataSet&gt;</returns>
        public List<ChartDataSet> GetChartAccountOverview(DateTime start, DateTime end, int operationIndex = 0)
        {
            FireflyIIINet.Client.ApiResponse<List<ChartDataSet>> localVarResponse = GetChartAccountOverviewWithHttpInfo(start, end);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Dashboard chart with asset account balance information. This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ChartDataSet&gt;</returns>
        public FireflyIIINet.Client.ApiResponse<List<ChartDataSet>> GetChartAccountOverviewWithHttpInfo(DateTime start, DateTime end, int operationIndex = 0)
        {
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

            localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "end", end));

            localVarRequestOptions.Operation = "ChartsApi.GetChartAccountOverview";
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
            var localVarResponse = this.Client.Get<List<ChartDataSet>>("/api/v1/chart/account/overview", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChartAccountOverview", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Dashboard chart with asset account balance information. This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ChartDataSet&gt;</returns>
        public async System.Threading.Tasks.Task<List<ChartDataSet>> GetChartAccountOverviewAsync(DateTime start, DateTime end, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FireflyIIINet.Client.ApiResponse<List<ChartDataSet>> localVarResponse = await GetChartAccountOverviewWithHttpInfoAsync(start, end, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Dashboard chart with asset account balance information. This endpoint returns the data required to generate a chart with basic asset account balance information. 
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">A date formatted YYYY-MM-DD. </param>
        /// <param name="end">A date formatted YYYY-MM-DD. </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ChartDataSet&gt;)</returns>
        public async System.Threading.Tasks.Task<FireflyIIINet.Client.ApiResponse<List<ChartDataSet>>> GetChartAccountOverviewWithHttpInfoAsync(DateTime start, DateTime end, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "end", end));

            localVarRequestOptions.Operation = "ChartsApi.GetChartAccountOverview";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ChartDataSet>>("/api/v1/chart/account/overview", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChartAccountOverview", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
