/*
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 1.0.2
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
    public interface ICurrencyExchangeRatesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get an exchange rate.
        /// </summary>
        /// <remarks>
        /// Get an exchange rate. If Firefly III doesn&#39;t know the rate it will set the rate to 1.0.
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from">The source currency code. If omitted, defaults to EUR. (optional)</param>
        /// <param name="to">The destination currency code. If omitted, defaults to USD. (optional)</param>
        /// <param name="date">The date you want to know the exchange rate on. (optional)</param>
        /// <param name="amount">The amount in the source currency. If added, Firefly III will calculate the amount in the destination currency. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExchangeRate</returns>
        ExchangeRate GetExchangeRate(string from = default(string), string to = default(string), DateTime? date = default(DateTime?), double? amount = default(double?), int operationIndex = 0);

        /// <summary>
        /// Get an exchange rate.
        /// </summary>
        /// <remarks>
        /// Get an exchange rate. If Firefly III doesn&#39;t know the rate it will set the rate to 1.0.
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from">The source currency code. If omitted, defaults to EUR. (optional)</param>
        /// <param name="to">The destination currency code. If omitted, defaults to USD. (optional)</param>
        /// <param name="date">The date you want to know the exchange rate on. (optional)</param>
        /// <param name="amount">The amount in the source currency. If added, Firefly III will calculate the amount in the destination currency. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExchangeRate</returns>
        ApiResponse<ExchangeRate> GetExchangeRateWithHttpInfo(string from = default(string), string to = default(string), DateTime? date = default(DateTime?), double? amount = default(double?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICurrencyExchangeRatesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get an exchange rate.
        /// </summary>
        /// <remarks>
        /// Get an exchange rate. If Firefly III doesn&#39;t know the rate it will set the rate to 1.0.
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from">The source currency code. If omitted, defaults to EUR. (optional)</param>
        /// <param name="to">The destination currency code. If omitted, defaults to USD. (optional)</param>
        /// <param name="date">The date you want to know the exchange rate on. (optional)</param>
        /// <param name="amount">The amount in the source currency. If added, Firefly III will calculate the amount in the destination currency. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExchangeRate</returns>
        System.Threading.Tasks.Task<ExchangeRate> GetExchangeRateAsync(string from = default(string), string to = default(string), DateTime? date = default(DateTime?), double? amount = default(double?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get an exchange rate.
        /// </summary>
        /// <remarks>
        /// Get an exchange rate. If Firefly III doesn&#39;t know the rate it will set the rate to 1.0.
        /// </remarks>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from">The source currency code. If omitted, defaults to EUR. (optional)</param>
        /// <param name="to">The destination currency code. If omitted, defaults to USD. (optional)</param>
        /// <param name="date">The date you want to know the exchange rate on. (optional)</param>
        /// <param name="amount">The amount in the source currency. If added, Firefly III will calculate the amount in the destination currency. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExchangeRate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExchangeRate>> GetExchangeRateWithHttpInfoAsync(string from = default(string), string to = default(string), DateTime? date = default(DateTime?), double? amount = default(double?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICurrencyExchangeRatesApi : ICurrencyExchangeRatesApiSync, ICurrencyExchangeRatesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CurrencyExchangeRatesApi : ICurrencyExchangeRatesApi
    {
        private FireflyIIINet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyExchangeRatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CurrencyExchangeRatesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyExchangeRatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CurrencyExchangeRatesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="CurrencyExchangeRatesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CurrencyExchangeRatesApi(FireflyIIINet.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="CurrencyExchangeRatesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CurrencyExchangeRatesApi(FireflyIIINet.Client.ISynchronousClient client, FireflyIIINet.Client.IAsynchronousClient asyncClient, FireflyIIINet.Client.IReadableConfiguration configuration)
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
        /// Get an exchange rate. Get an exchange rate. If Firefly III doesn&#39;t know the rate it will set the rate to 1.0.
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from">The source currency code. If omitted, defaults to EUR. (optional)</param>
        /// <param name="to">The destination currency code. If omitted, defaults to USD. (optional)</param>
        /// <param name="date">The date you want to know the exchange rate on. (optional)</param>
        /// <param name="amount">The amount in the source currency. If added, Firefly III will calculate the amount in the destination currency. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExchangeRate</returns>
        public ExchangeRate GetExchangeRate(string from = default(string), string to = default(string), DateTime? date = default(DateTime?), double? amount = default(double?), int operationIndex = 0)
        {
            FireflyIIINet.Client.ApiResponse<ExchangeRate> localVarResponse = GetExchangeRateWithHttpInfo(from, to, date, amount);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an exchange rate. Get an exchange rate. If Firefly III doesn&#39;t know the rate it will set the rate to 1.0.
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from">The source currency code. If omitted, defaults to EUR. (optional)</param>
        /// <param name="to">The destination currency code. If omitted, defaults to USD. (optional)</param>
        /// <param name="date">The date you want to know the exchange rate on. (optional)</param>
        /// <param name="amount">The amount in the source currency. If added, Firefly III will calculate the amount in the destination currency. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExchangeRate</returns>
        public FireflyIIINet.Client.ApiResponse<ExchangeRate> GetExchangeRateWithHttpInfo(string from = default(string), string to = default(string), DateTime? date = default(DateTime?), double? amount = default(double?), int operationIndex = 0)
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

            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "to", to));
            }
            if (date != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "date", date));
            }
            if (amount != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "amount", amount));
            }

            localVarRequestOptions.Operation = "CurrencyExchangeRatesApi.GetExchangeRate";
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
            var localVarResponse = this.Client.Get<ExchangeRate>("/api/v1/cer", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExchangeRate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an exchange rate. Get an exchange rate. If Firefly III doesn&#39;t know the rate it will set the rate to 1.0.
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from">The source currency code. If omitted, defaults to EUR. (optional)</param>
        /// <param name="to">The destination currency code. If omitted, defaults to USD. (optional)</param>
        /// <param name="date">The date you want to know the exchange rate on. (optional)</param>
        /// <param name="amount">The amount in the source currency. If added, Firefly III will calculate the amount in the destination currency. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExchangeRate</returns>
        public async System.Threading.Tasks.Task<ExchangeRate> GetExchangeRateAsync(string from = default(string), string to = default(string), DateTime? date = default(DateTime?), double? amount = default(double?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FireflyIIINet.Client.ApiResponse<ExchangeRate> localVarResponse = await GetExchangeRateWithHttpInfoAsync(from, to, date, amount, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an exchange rate. Get an exchange rate. If Firefly III doesn&#39;t know the rate it will set the rate to 1.0.
        /// </summary>
        /// <exception cref="FireflyIIINet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from">The source currency code. If omitted, defaults to EUR. (optional)</param>
        /// <param name="to">The destination currency code. If omitted, defaults to USD. (optional)</param>
        /// <param name="date">The date you want to know the exchange rate on. (optional)</param>
        /// <param name="amount">The amount in the source currency. If added, Firefly III will calculate the amount in the destination currency. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExchangeRate)</returns>
        public async System.Threading.Tasks.Task<FireflyIIINet.Client.ApiResponse<ExchangeRate>> GetExchangeRateWithHttpInfoAsync(string from = default(string), string to = default(string), DateTime? date = default(DateTime?), double? amount = default(double?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "to", to));
            }
            if (date != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "date", date));
            }
            if (amount != null)
            {
                localVarRequestOptions.QueryParameters.Add(FireflyIIINet.Client.ClientUtils.ParameterToMultiMap("", "amount", amount));
            }

            localVarRequestOptions.Operation = "CurrencyExchangeRatesApi.GetExchangeRate";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<ExchangeRate>("/api/v1/cer", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExchangeRate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
