/* 
 * API for MyQ Devices
 *
 * This is a reverse engineered and incomplete version of the MyQ API.
 *
 * The version of the OpenAPI document: 5.1
 * Contact: geregam@gmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using spydersoft.myq.Client;
using spydersoft.myq.Model;

namespace spydersoft.myq.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// log in to the service and receive a token
        /// </summary>
        /// <remarks>
        /// Authenticate with the MyQ service and receive a security token 
        /// </remarks>
        /// <exception cref="spydersoft.myq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion">For right now, this should be v5 except for the Accounts/{id}/Devices, which is v5.1 </param>
        /// <param name="myQApplicationId"> (optional, default to &quot;JVM/G9Nwih5BwKgNCjLxiFUQxQijAebyyg8QUHr7JOrP+tuPb8iHfRHKwTmDzHOu&quot;)</param>
        /// <param name="brandId"> (optional, default to &quot;2&quot;)</param>
        /// <param name="culture"> (optional, default to &quot;en&quot;)</param>
        /// <param name="loginBody">Login Details (optional)</param>
        /// <returns>LoginResponse</returns>
        LoginResponse Login (string apiVersion, string myQApplicationId = default(string), string brandId = default(string), string culture = default(string), LoginBody loginBody = default(LoginBody));

        /// <summary>
        /// log in to the service and receive a token
        /// </summary>
        /// <remarks>
        /// Authenticate with the MyQ service and receive a security token 
        /// </remarks>
        /// <exception cref="spydersoft.myq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion">For right now, this should be v5 except for the Accounts/{id}/Devices, which is v5.1 </param>
        /// <param name="myQApplicationId"> (optional, default to &quot;JVM/G9Nwih5BwKgNCjLxiFUQxQijAebyyg8QUHr7JOrP+tuPb8iHfRHKwTmDzHOu&quot;)</param>
        /// <param name="brandId"> (optional, default to &quot;2&quot;)</param>
        /// <param name="culture"> (optional, default to &quot;en&quot;)</param>
        /// <param name="loginBody">Login Details (optional)</param>
        /// <returns>ApiResponse of LoginResponse</returns>
        ApiResponse<LoginResponse> LoginWithHttpInfo (string apiVersion, string myQApplicationId = default(string), string brandId = default(string), string culture = default(string), LoginBody loginBody = default(LoginBody));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// log in to the service and receive a token
        /// </summary>
        /// <remarks>
        /// Authenticate with the MyQ service and receive a security token 
        /// </remarks>
        /// <exception cref="spydersoft.myq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion">For right now, this should be v5 except for the Accounts/{id}/Devices, which is v5.1 </param>
        /// <param name="myQApplicationId"> (optional, default to &quot;JVM/G9Nwih5BwKgNCjLxiFUQxQijAebyyg8QUHr7JOrP+tuPb8iHfRHKwTmDzHOu&quot;)</param>
        /// <param name="brandId"> (optional, default to &quot;2&quot;)</param>
        /// <param name="culture"> (optional, default to &quot;en&quot;)</param>
        /// <param name="loginBody">Login Details (optional)</param>
        /// <returns>Task of LoginResponse</returns>
        System.Threading.Tasks.Task<LoginResponse> LoginAsync (string apiVersion, string myQApplicationId = default(string), string brandId = default(string), string culture = default(string), LoginBody loginBody = default(LoginBody));

        /// <summary>
        /// log in to the service and receive a token
        /// </summary>
        /// <remarks>
        /// Authenticate with the MyQ service and receive a security token 
        /// </remarks>
        /// <exception cref="spydersoft.myq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion">For right now, this should be v5 except for the Accounts/{id}/Devices, which is v5.1 </param>
        /// <param name="myQApplicationId"> (optional, default to &quot;JVM/G9Nwih5BwKgNCjLxiFUQxQijAebyyg8QUHr7JOrP+tuPb8iHfRHKwTmDzHOu&quot;)</param>
        /// <param name="brandId"> (optional, default to &quot;2&quot;)</param>
        /// <param name="culture"> (optional, default to &quot;en&quot;)</param>
        /// <param name="loginBody">Login Details (optional)</param>
        /// <returns>Task of ApiResponse (LoginResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoginResponse>> LoginAsyncWithHttpInfo (string apiVersion, string myQApplicationId = default(string), string brandId = default(string), string culture = default(string), LoginBody loginBody = default(LoginBody));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi : IAuthenticationApiSync, IAuthenticationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticationApi : IAuthenticationApi
    {
        private spydersoft.myq.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(String basePath)
        {
            this.Configuration = spydersoft.myq.Client.Configuration.MergeConfigurations(
                spydersoft.myq.Client.GlobalConfiguration.Instance,
                new spydersoft.myq.Client.Configuration { BasePath = basePath }
            );
            this.Client = new spydersoft.myq.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new spydersoft.myq.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = spydersoft.myq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticationApi(spydersoft.myq.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = spydersoft.myq.Client.Configuration.MergeConfigurations(
                spydersoft.myq.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new spydersoft.myq.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new spydersoft.myq.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = spydersoft.myq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuthenticationApi(spydersoft.myq.Client.ISynchronousClient client,spydersoft.myq.Client.IAsynchronousClient asyncClient, spydersoft.myq.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = spydersoft.myq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public spydersoft.myq.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public spydersoft.myq.Client.ISynchronousClient Client { get; set; }

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
        public spydersoft.myq.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public spydersoft.myq.Client.ExceptionFactory ExceptionFactory
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
        /// log in to the service and receive a token Authenticate with the MyQ service and receive a security token 
        /// </summary>
        /// <exception cref="spydersoft.myq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion">For right now, this should be v5 except for the Accounts/{id}/Devices, which is v5.1 </param>
        /// <param name="myQApplicationId"> (optional, default to &quot;JVM/G9Nwih5BwKgNCjLxiFUQxQijAebyyg8QUHr7JOrP+tuPb8iHfRHKwTmDzHOu&quot;)</param>
        /// <param name="brandId"> (optional, default to &quot;2&quot;)</param>
        /// <param name="culture"> (optional, default to &quot;en&quot;)</param>
        /// <param name="loginBody">Login Details (optional)</param>
        /// <returns>LoginResponse</returns>
        public LoginResponse Login (string apiVersion, string myQApplicationId = default(string), string brandId = default(string), string culture = default(string), LoginBody loginBody = default(LoginBody))
        {
             spydersoft.myq.Client.ApiResponse<LoginResponse> localVarResponse = LoginWithHttpInfo(apiVersion, myQApplicationId, brandId, culture, loginBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// log in to the service and receive a token Authenticate with the MyQ service and receive a security token 
        /// </summary>
        /// <exception cref="spydersoft.myq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion">For right now, this should be v5 except for the Accounts/{id}/Devices, which is v5.1 </param>
        /// <param name="myQApplicationId"> (optional, default to &quot;JVM/G9Nwih5BwKgNCjLxiFUQxQijAebyyg8QUHr7JOrP+tuPb8iHfRHKwTmDzHOu&quot;)</param>
        /// <param name="brandId"> (optional, default to &quot;2&quot;)</param>
        /// <param name="culture"> (optional, default to &quot;en&quot;)</param>
        /// <param name="loginBody">Login Details (optional)</param>
        /// <returns>ApiResponse of LoginResponse</returns>
        public spydersoft.myq.Client.ApiResponse< LoginResponse > LoginWithHttpInfo (string apiVersion, string myQApplicationId = default(string), string brandId = default(string), string culture = default(string), LoginBody loginBody = default(LoginBody))
        {
            // verify the required parameter 'apiVersion' is set
            if (apiVersion == null)
                throw new spydersoft.myq.Client.ApiException(400, "Missing required parameter 'apiVersion' when calling AuthenticationApi->Login");

            spydersoft.myq.Client.RequestOptions localVarRequestOptions = new spydersoft.myq.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = spydersoft.myq.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = spydersoft.myq.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("apiVersion", spydersoft.myq.Client.ClientUtils.ParameterToString(apiVersion)); // path parameter
            if (myQApplicationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("MyQApplicationId", spydersoft.myq.Client.ClientUtils.ParameterToString(myQApplicationId)); // header parameter
            }
            if (brandId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("BrandId", spydersoft.myq.Client.ClientUtils.ParameterToString(brandId)); // header parameter
            }
            if (culture != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Culture", spydersoft.myq.Client.ClientUtils.ParameterToString(culture)); // header parameter
            }
            localVarRequestOptions.Data = loginBody;


            // make the HTTP request
            var localVarResponse = this.Client.Post< LoginResponse >("/{apiVersion}/Login", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Login", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// log in to the service and receive a token Authenticate with the MyQ service and receive a security token 
        /// </summary>
        /// <exception cref="spydersoft.myq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion">For right now, this should be v5 except for the Accounts/{id}/Devices, which is v5.1 </param>
        /// <param name="myQApplicationId"> (optional, default to &quot;JVM/G9Nwih5BwKgNCjLxiFUQxQijAebyyg8QUHr7JOrP+tuPb8iHfRHKwTmDzHOu&quot;)</param>
        /// <param name="brandId"> (optional, default to &quot;2&quot;)</param>
        /// <param name="culture"> (optional, default to &quot;en&quot;)</param>
        /// <param name="loginBody">Login Details (optional)</param>
        /// <returns>Task of LoginResponse</returns>
        public async System.Threading.Tasks.Task<LoginResponse> LoginAsync (string apiVersion, string myQApplicationId = default(string), string brandId = default(string), string culture = default(string), LoginBody loginBody = default(LoginBody))
        {
             spydersoft.myq.Client.ApiResponse<LoginResponse> localVarResponse = await LoginAsyncWithHttpInfo(apiVersion, myQApplicationId, brandId, culture, loginBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// log in to the service and receive a token Authenticate with the MyQ service and receive a security token 
        /// </summary>
        /// <exception cref="spydersoft.myq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion">For right now, this should be v5 except for the Accounts/{id}/Devices, which is v5.1 </param>
        /// <param name="myQApplicationId"> (optional, default to &quot;JVM/G9Nwih5BwKgNCjLxiFUQxQijAebyyg8QUHr7JOrP+tuPb8iHfRHKwTmDzHOu&quot;)</param>
        /// <param name="brandId"> (optional, default to &quot;2&quot;)</param>
        /// <param name="culture"> (optional, default to &quot;en&quot;)</param>
        /// <param name="loginBody">Login Details (optional)</param>
        /// <returns>Task of ApiResponse (LoginResponse)</returns>
        public async System.Threading.Tasks.Task<spydersoft.myq.Client.ApiResponse<LoginResponse>> LoginAsyncWithHttpInfo (string apiVersion, string myQApplicationId = default(string), string brandId = default(string), string culture = default(string), LoginBody loginBody = default(LoginBody))
        {
            // verify the required parameter 'apiVersion' is set
            if (apiVersion == null)
                throw new spydersoft.myq.Client.ApiException(400, "Missing required parameter 'apiVersion' when calling AuthenticationApi->Login");


            spydersoft.myq.Client.RequestOptions localVarRequestOptions = new spydersoft.myq.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("apiVersion", spydersoft.myq.Client.ClientUtils.ParameterToString(apiVersion)); // path parameter
            if (myQApplicationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("MyQApplicationId", spydersoft.myq.Client.ClientUtils.ParameterToString(myQApplicationId)); // header parameter
            }
            if (brandId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("BrandId", spydersoft.myq.Client.ClientUtils.ParameterToString(brandId)); // header parameter
            }
            if (culture != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Culture", spydersoft.myq.Client.ClientUtils.ParameterToString(culture)); // header parameter
            }
            localVarRequestOptions.Data = loginBody;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<LoginResponse>("/{apiVersion}/Login", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Login", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
