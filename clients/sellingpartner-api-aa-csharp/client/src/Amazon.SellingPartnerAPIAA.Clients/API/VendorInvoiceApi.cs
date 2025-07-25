/* 
 * Selling Partner API for Direct Fulfillment Payments
 *
 * The Selling Partner API for Direct Fulfillment Payments provides programmatic access to a direct fulfillment vendor's invoice data.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentPayments;
using RestSharp;

namespace Amazon.SellingPartnerAPIAA.Clients.API
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVendorInvoiceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Submits one or more invoices for a vendor&#39;s direct fulfillment orders.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body containing one or more invoices for vendor orders.</param>
        /// <returns>SubmitInvoiceResponse</returns>
        SubmitInvoiceResponse SubmitInvoice(SubmitInvoiceRequest body);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Submits one or more invoices for a vendor&#39;s direct fulfillment orders.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body containing one or more invoices for vendor orders.</param>
        /// <returns>ApiResponse of SubmitInvoiceResponse</returns>
        ApiResponse<SubmitInvoiceResponse> SubmitInvoiceWithHttpInfo(SubmitInvoiceRequest body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Submits one or more invoices for a vendor&#39;s direct fulfillment orders.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body containing one or more invoices for vendor orders.</param>
        /// <returns>Task of SubmitInvoiceResponse</returns>
        System.Threading.Tasks.Task<SubmitInvoiceResponse> SubmitInvoiceAsync(SubmitInvoiceRequest body);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Submits one or more invoices for a vendor&#39;s direct fulfillment orders.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body containing one or more invoices for vendor orders.</param>
        /// <returns>Task of ApiResponse (SubmitInvoiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubmitInvoiceResponse>> SubmitInvoiceAsyncWithHttpInfo(SubmitInvoiceRequest body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VendorInvoiceApi : IVendorInvoiceApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VendorInvoiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VendorInvoiceApi(Configuration configuration)
        {
            this.Configuration = configuration;
            ExceptionFactory = Configuration.DefaultExceptionFactory;
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
        public Configuration Configuration { get; set; }

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
        ///  Submits one or more invoices for a vendor&#39;s direct fulfillment orders.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body containing one or more invoices for vendor orders.</param>
        /// <returns>SubmitInvoiceResponse</returns>
        public SubmitInvoiceResponse SubmitInvoice(SubmitInvoiceRequest body)
        {
            ApiResponse<SubmitInvoiceResponse> localVarResponse = SubmitInvoiceWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Submits one or more invoices for a vendor&#39;s direct fulfillment orders.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body containing one or more invoices for vendor orders.</param>
        /// <returns>ApiResponse of SubmitInvoiceResponse</returns>
        public ApiResponse<SubmitInvoiceResponse> SubmitInvoiceWithHttpInfo(SubmitInvoiceRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VendorInvoiceApi->SubmitInvoice");

            var localVarPath = "/vendor/directFulfillment/payments/v1/invoices";
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
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubmitInvoiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubmitInvoiceResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubmitInvoiceResponse)));
        }

        /// <summary>
        ///  Submits one or more invoices for a vendor&#39;s direct fulfillment orders.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body containing one or more invoices for vendor orders.</param>
        /// <returns>Task of SubmitInvoiceResponse</returns>
        public async System.Threading.Tasks.Task<SubmitInvoiceResponse> SubmitInvoiceAsync(SubmitInvoiceRequest body)
        {
            ApiResponse<SubmitInvoiceResponse> localVarResponse = await SubmitInvoiceAsyncWithHttpInfo(body);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  Submits one or more invoices for a vendor&#39;s direct fulfillment orders.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The request body containing one or more invoices for vendor orders.</param>
        /// <returns>Task of ApiResponse (SubmitInvoiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubmitInvoiceResponse>> SubmitInvoiceAsyncWithHttpInfo(SubmitInvoiceRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VendorInvoiceApi->SubmitInvoice");

            var localVarPath = "/vendor/directFulfillment/payments/v1/invoices";
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
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubmitInvoiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubmitInvoiceResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubmitInvoiceResponse)));
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

            public VendorInvoiceApi Build()
            {
                if (lwaAuthorizationCredentials == null)
                {
                    throw new NullReferenceException("LWAAuthoriztionCredentials not set");
                }


                Configuration configuration = new Configuration
                {
                    AuthorizationCredentials = lwaAuthorizationCredentials,
                    RateLimitConfig = rateLimitConfiguration,
                    // default HTTP connection timeout (in milliseconds)
                    Timeout = 100000
                };

                return new VendorInvoiceApi(configuration);
            }
        }
    }
}
