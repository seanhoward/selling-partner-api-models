/* 
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * Use the Selling Partner API for Direct Fulfillment Shipping to access a direct fulfillment vendor's shipping data.
 *
 * OpenAPI spec version: 2021-12-28
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentShipping;
using Amazon.SellingPartnerAPIAA;

namespace Amazon.SellingPartnerAPIAA.Clients.API
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICreateContainerLabelApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// createContainerLabel
        /// </summary>
        /// <remarks>
        /// Creates a container (pallet) label for the associated shipment package.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </remarks>
        /// <exception cref="Amazon.SellingPartnerAPIAA.Clients.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing the container label data.</param>
        /// <returns>CreateContainerLabelResponse</returns>
        CreateContainerLabelResponse CreateContainerLabel (CreateContainerLabelRequest body);

        /// <summary>
        /// createContainerLabel
        /// </summary>
        /// <remarks>
        /// Creates a container (pallet) label for the associated shipment package.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </remarks>
        /// <exception cref="Amazon.SellingPartnerAPIAA.Clients.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing the container label data.</param>
        /// <returns>ApiResponse of CreateContainerLabelResponse</returns>
        ApiResponse<CreateContainerLabelResponse> CreateContainerLabelWithHttpInfo (CreateContainerLabelRequest body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// createContainerLabel
        /// </summary>
        /// <remarks>
        /// Creates a container (pallet) label for the associated shipment package.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </remarks>
        /// <exception cref="Amazon.SellingPartnerAPIAA.Clients.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing the container label data.</param>
        /// <returns>Task of CreateContainerLabelResponse</returns>
        System.Threading.Tasks.Task<CreateContainerLabelResponse> CreateContainerLabelAsync (CreateContainerLabelRequest body);

        /// <summary>
        /// createContainerLabel
        /// </summary>
        /// <remarks>
        /// Creates a container (pallet) label for the associated shipment package.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </remarks>
        /// <exception cref="Amazon.SellingPartnerAPIAA.Clients.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing the container label data.</param>
        /// <returns>Task of ApiResponse (CreateContainerLabelResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateContainerLabelResponse>> CreateContainerLabelAsyncWithHttpInfo (CreateContainerLabelRequest body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CreateContainerLabelApi : ICreateContainerLabelApi
    {
        private Amazon.SellingPartnerAPIAA.Clients.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerLabelApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CreateContainerLabelApi(Amazon.SellingPartnerAPIAA.Clients.Client.Configuration configuration)
        {
            this.Configuration = configuration;
            ExceptionFactory = Amazon.SellingPartnerAPIAA.Clients.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Amazon.SellingPartnerAPIAA.Clients.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Amazon.SellingPartnerAPIAA.Clients.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// createContainerLabel Creates a container (pallet) label for the associated shipment package.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        /// <exception cref="Amazon.SellingPartnerAPIAA.Clients.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing the container label data.</param>
        /// <returns>CreateContainerLabelResponse</returns>
        public CreateContainerLabelResponse CreateContainerLabel (CreateContainerLabelRequest body)
        {
             ApiResponse<CreateContainerLabelResponse> localVarResponse = CreateContainerLabelWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// createContainerLabel Creates a container (pallet) label for the associated shipment package.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        /// <exception cref="Amazon.SellingPartnerAPIAA.Clients.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing the container label data.</param>
        /// <returns>ApiResponse of CreateContainerLabelResponse</returns>
        public ApiResponse< CreateContainerLabelResponse > CreateContainerLabelWithHttpInfo (CreateContainerLabelRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CreateContainerLabelApi->CreateContainerLabel");

            var localVarPath = "/vendor/directFulfillment/shipping/2021-12-28/containerLabel";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateContainerLabel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateContainerLabelResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateContainerLabelResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateContainerLabelResponse)));
        }

        /// <summary>
        /// createContainerLabel Creates a container (pallet) label for the associated shipment package.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        /// <exception cref="Amazon.SellingPartnerAPIAA.Clients.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing the container label data.</param>
        /// <returns>Task of CreateContainerLabelResponse</returns>
        public async System.Threading.Tasks.Task<CreateContainerLabelResponse> CreateContainerLabelAsync (CreateContainerLabelRequest body)
        {
             ApiResponse<CreateContainerLabelResponse> localVarResponse = await CreateContainerLabelAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// createContainerLabel Creates a container (pallet) label for the associated shipment package.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The preceding table contains the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        /// <exception cref="Amazon.SellingPartnerAPIAA.Clients.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing the container label data.</param>
        /// <returns>Task of ApiResponse (CreateContainerLabelResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateContainerLabelResponse>> CreateContainerLabelAsyncWithHttpInfo (CreateContainerLabelRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CreateContainerLabelApi->CreateContainerLabel");

            var localVarPath = "/vendor/directFulfillment/shipping/2021-12-28/containerLabel";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateContainerLabel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateContainerLabelResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateContainerLabelResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateContainerLabelResponse)));
        }


        public class Builder
        {
            private LWAAuthorizationCredentials lwaAuthorizationCredentials;
            private RateLimitConfiguration rateLimitConfiguration;

            public Builder SetLWAAuthorizationCredentials(LWAAuthorizationCredentials lwaAuthorizationCredentials)
            {
                this.lwaAuthorizationCredentials = lwaAuthorizationCredentials;
                return this;
            }
            
            
            public Builder SetRateLimitConfiguration(RateLimitConfiguration rateLimitConfiguration)
            {
                this.rateLimitConfiguration = rateLimitConfiguration;
                return this;
            }

            public CreateContainerLabelApi Build() 
            {
                if (lwaAuthorizationCredentials == null) 
                {
                    throw new NullReferenceException("LWAAuthoriztionCredentials not set");
                }

                
                Amazon.SellingPartnerAPIAA.Clients.Client.Configuration configuration = new Amazon.SellingPartnerAPIAA.Clients.Client.Configuration()
                {
                    AuthorizationCredentials = lwaAuthorizationCredentials,
                    RateLimitConfig = rateLimitConfiguration
                };

                // default HTTP connection timeout (in milliseconds)
                configuration.Timeout = 100000;

                return new CreateContainerLabelApi(configuration);
            }
        }
    }
}
