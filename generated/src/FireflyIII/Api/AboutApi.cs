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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using FireflyIII.Client;
using FireflyIII.Model;

namespace FireflyIII.Api
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
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SystemInfo</returns>
        SystemInfo GetAbout ();

        /// <summary>
        /// System information end point.
        /// </summary>
        /// <remarks>
        /// Returns general system information and versions of the (supporting) software. 
        /// </remarks>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SystemInfo</returns>
        ApiResponse<SystemInfo> GetAboutWithHttpInfo ();
        /// <summary>
        /// Currently authenticated user endpoint.
        /// </summary>
        /// <remarks>
        /// Returns the currently authenticated user. 
        /// </remarks>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserSingle</returns>
        UserSingle GetCurrentUser ();

        /// <summary>
        /// Currently authenticated user endpoint.
        /// </summary>
        /// <remarks>
        /// Returns the currently authenticated user. 
        /// </remarks>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserSingle</returns>
        ApiResponse<UserSingle> GetCurrentUserWithHttpInfo ();
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
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SystemInfo</returns>
        System.Threading.Tasks.Task<SystemInfo> GetAboutAsync ();

        /// <summary>
        /// System information end point.
        /// </summary>
        /// <remarks>
        /// Returns general system information and versions of the (supporting) software. 
        /// </remarks>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SystemInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemInfo>> GetAboutAsyncWithHttpInfo ();
        /// <summary>
        /// Currently authenticated user endpoint.
        /// </summary>
        /// <remarks>
        /// Returns the currently authenticated user. 
        /// </remarks>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserSingle</returns>
        System.Threading.Tasks.Task<UserSingle> GetCurrentUserAsync ();

        /// <summary>
        /// Currently authenticated user endpoint.
        /// </summary>
        /// <remarks>
        /// Returns the currently authenticated user. 
        /// </remarks>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserSingle>> GetCurrentUserAsyncWithHttpInfo ();
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
        private FireflyIII.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AboutApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AboutApi(String basePath)
        {
            this.Configuration = FireflyIII.Client.Configuration.MergeConfigurations(
                FireflyIII.Client.GlobalConfiguration.Instance,
                new FireflyIII.Client.Configuration { BasePath = basePath }
            );
            this.Client = new FireflyIII.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FireflyIII.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = FireflyIII.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AboutApi(FireflyIII.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = FireflyIII.Client.Configuration.MergeConfigurations(
                FireflyIII.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new FireflyIII.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FireflyIII.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = FireflyIII.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AboutApi(FireflyIII.Client.ISynchronousClient client,FireflyIII.Client.IAsynchronousClient asyncClient, FireflyIII.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = FireflyIII.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public FireflyIII.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public FireflyIII.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public FireflyIII.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FireflyIII.Client.ExceptionFactory ExceptionFactory
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
        /// System information end point. Returns general system information and versions of the (supporting) software. 
        /// </summary>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SystemInfo</returns>
        public SystemInfo GetAbout ()
        {
             FireflyIII.Client.ApiResponse<SystemInfo> localVarResponse = GetAboutWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// System information end point. Returns general system information and versions of the (supporting) software. 
        /// </summary>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SystemInfo</returns>
        public FireflyIII.Client.ApiResponse< SystemInfo > GetAboutWithHttpInfo ()
        {
            FireflyIII.Client.RequestOptions localVarRequestOptions = new FireflyIII.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = FireflyIII.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FireflyIII.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (firefly_iii_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< SystemInfo >("/api/v1/about", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAbout", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// System information end point. Returns general system information and versions of the (supporting) software. 
        /// </summary>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SystemInfo</returns>
        public async System.Threading.Tasks.Task<SystemInfo> GetAboutAsync ()
        {
             FireflyIII.Client.ApiResponse<SystemInfo> localVarResponse = await GetAboutAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// System information end point. Returns general system information and versions of the (supporting) software. 
        /// </summary>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SystemInfo)</returns>
        public async System.Threading.Tasks.Task<FireflyIII.Client.ApiResponse<SystemInfo>> GetAboutAsyncWithHttpInfo ()
        {

            FireflyIII.Client.RequestOptions localVarRequestOptions = new FireflyIII.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (firefly_iii_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<SystemInfo>("/api/v1/about", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAbout", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Currently authenticated user endpoint. Returns the currently authenticated user. 
        /// </summary>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserSingle</returns>
        public UserSingle GetCurrentUser ()
        {
             FireflyIII.Client.ApiResponse<UserSingle> localVarResponse = GetCurrentUserWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Currently authenticated user endpoint. Returns the currently authenticated user. 
        /// </summary>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserSingle</returns>
        public FireflyIII.Client.ApiResponse< UserSingle > GetCurrentUserWithHttpInfo ()
        {
            FireflyIII.Client.RequestOptions localVarRequestOptions = new FireflyIII.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = FireflyIII.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FireflyIII.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (firefly_iii_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< UserSingle >("/api/v1/about/user", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCurrentUser", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Currently authenticated user endpoint. Returns the currently authenticated user. 
        /// </summary>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserSingle</returns>
        public async System.Threading.Tasks.Task<UserSingle> GetCurrentUserAsync ()
        {
             FireflyIII.Client.ApiResponse<UserSingle> localVarResponse = await GetCurrentUserAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Currently authenticated user endpoint. Returns the currently authenticated user. 
        /// </summary>
        /// <exception cref="FireflyIII.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserSingle)</returns>
        public async System.Threading.Tasks.Task<FireflyIII.Client.ApiResponse<UserSingle>> GetCurrentUserAsyncWithHttpInfo ()
        {

            FireflyIII.Client.RequestOptions localVarRequestOptions = new FireflyIII.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (firefly_iii_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<UserSingle>("/api/v1/about/user", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCurrentUser", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
