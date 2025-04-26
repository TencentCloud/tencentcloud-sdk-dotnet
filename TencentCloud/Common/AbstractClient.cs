/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TencentCloud.Common.Http;
using TencentCloud.Common.Profile;

namespace TencentCloud.Common
{
    /// <summary>
    ///   Abstract base class for all Tencent Cloud API clients.
    ///   Provides common functionality for making API requests, handling responses, and managing credentials.
    /// </summary>
    public class AbstractClient
    {
        /// <summary>
        ///   Standard HTTP response code indicating success.
        /// </summary>
        public const int HTTP_RSP_OK = 200;

        /// <summary>
        ///   Current SDK version.
        /// </summary>
        public const string SDK_VERSION = "SDK_NET_3.0.1228";

        /// <summary>
        ///   Constructor for AbstractClient.
        /// </summary>
        /// <param name="endpoint"> The service endpoint (e.g., cvm.tencentcloudapi.com). </param>
        /// <param name="version"> The API version to use (e.g., "2017-03-12"). </param>
        /// <param name="credential"> The user's security credentials. </param>
        /// <param name="region"> The region to access (e.g., "ap-guangzhou"). </param>
        /// <param name="profile"> The client profile with SDK settings. </param>
        public AbstractClient(string endpoint, string version, Credential credential, string region,
            ClientProfile profile)
        {
            this.Credential = credential;
            this.Profile = profile;
            this.Endpoint = endpoint;
            this.Region = region;
            this.Path = "/";
            this.SdkVersion = SDK_VERSION;
            this.ApiVersion = version;
            this.HttpClient = null;
        }

        /// <summary>
        ///   User's security credentials (SecretId, SecretKey, Token).
        /// </summary>
        public Credential Credential { get; set; }

        /// <summary>
        ///   Client profile containing SDK settings (e.g., timeout, signature method).
        /// </summary>
        public ClientProfile Profile { get; set; }

        /// <summary>
        ///   The service endpoint or domain name (e.g., cvm.tencentcloudapi.com).
        ///   This is the address of the Tencent Cloud service.
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        ///   The region to access (e.g., ap-guangzhou).
        ///   Tencent Cloud services are often region-specific.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        ///   The URL path for API requests.
        ///   For API version 3.0, the default path is "/".
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        ///   The version of the Tencent Cloud SDK being used.
        /// </summary>
        public string SdkVersion { get; set; }

        /// <summary>
        ///   The version of the Tencent Cloud API being called (e.g., "2017-03-12").
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        ///   HttpClient instance used for making requests.
        ///   It is recommended to reuse HttpClient instances for performance.
        /// </summary>
        public HttpClient HttpClient { get; set; }

        /// <summary>
        ///   Internal method to make an asynchronous API request and handle the response.
        /// </summary>
        /// <param name="request"> The request object (inherits from AbstractModel). </param>
        /// <param name="actionName"> The name of the API action to call (e.g., "DescribeInstances"). </param>
        /// <returns> The raw JSON response string. </returns>
        /// <exception cref="TencentCloudSDKException"> Thrown for various API errors, including invalid HTTP status codes and API-specific errors. </exception>
        protected async Task<string> InternalRequest(AbstractModel request, string actionName)
        {
            // Ensure the request method is supported
            if ((this.Profile.HttpProfile.ReqMethod != HttpProfile.REQ_GET) &&
                (this.Profile.HttpProfile.ReqMethod != HttpProfile.REQ_POST))
            {
                throw new TencentCloudSDKException("Method only support (GET, POST)");
            }

            // Determine if using signature version 1
            var signV1 = ClientProfile.SIGN_SHA1.Equals(Profile.SignMethod)
                         || ClientProfile.SIGN_SHA256.Equals(Profile.SignMethod);

            // Make the API request (either V1 or V3 signing)
            using (var response = signV1
                       ? await RequestV1(request, actionName).ConfigureAwait(false)
                       : await RequestV3(request, actionName).ConfigureAwait(false))
            {
                // Check for a successful HTTP status code
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new TencentCloudSDKException(
                        $"invalid http status: {response.StatusCode}, body: {await response.Content.ReadAsStringAsync().ConfigureAwait(false)}");
                }

                string strResp = null;
                try
                {
                    strResp = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    throw new TencentCloudSDKException("API request failed", e);
                }

                // Deserialize the response to check for API errors
                JsonResponseModel<JsonResponseErrModel> errResp = null;
                try
                {
                    errResp = JsonConvert.DeserializeObject<JsonResponseModel<JsonResponseErrModel>>(strResp);
                }
                catch (JsonSerializationException e)
                {
                    throw new TencentCloudSDKException(e.Message);
                }

                if (errResp.Response.Error != null)
                {
                    throw new TencentCloudSDKException(
                        errResp.Response.Error.Message, errResp.Response.Error.Code, errResp.Response.RequestId);
                }

                return strResp;
            }
        }

        /// <summary>
        ///   Synchronous version of InternalRequest (blocks until completion).  Use with caution in async contexts.
        /// </summary>
        /// <param name="request"> The request object. </param>
        /// <param name="actionName"> The API action name. </param>
        /// <returns> The raw JSON response string. </returns>
        protected string InternalRequestSync(AbstractModel request, string actionName)
        {
            return Task.Run(() => InternalRequest(request, actionName)).Result;
        }

        /// <summary>
        ///   Asynchronously makes an API request and deserializes the JSON response into a specific type.
        /// </summary>
        /// <typeparam name="T"> The type to deserialize the JSON response into. </typeparam>
        /// <param name="request"> The request object. </param>
        /// <param name="actionName"> The API action name. </param>
        /// <returns> The deserialized response object. </returns>
        /// <exception cref="TencentCloudSDKException"> Thrown for API errors. </exception>
        protected async Task<T> InternalRequestAsync<T>(AbstractModel request, string actionName)
        {
            if (Profile.HttpProfile.ReqMethod != HttpProfile.REQ_GET &&
                Profile.HttpProfile.ReqMethod != HttpProfile.REQ_POST)
            {
                throw new TencentCloudSDKException("Method only support (GET, POST)");
            }

            var signV1 = ClientProfile.SIGN_SHA1.Equals(Profile.SignMethod)
                         || ClientProfile.SIGN_SHA256.Equals(Profile.SignMethod);

            var response = signV1
                ? await RequestV1(request, actionName).ConfigureAwait(false)
                : await RequestV3(request, actionName).ConfigureAwait(false);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                response.Dispose();
                throw new TencentCloudSDKException(
                    $"invalid http status: {response.StatusCode}, body: {await response.Content.ReadAsStringAsync().ConfigureAwait(false)}");
            }

            if (response.Content.Headers.TryGetValues("Content-Type", out var cts) &&
                cts.First() == "text/event-stream")
            {
                return await ReadSSEResponseAsync<T>(response).ConfigureAwait(false);
            }

            try
            {
                return await ReadJsonResponseAsync<T>(response).ConfigureAwait(false);
            }
            finally
            {
                response.Dispose();
            }
        }

        /// <summary>
        ///   Reads and deserializes a standard JSON API response.
        /// </summary>
        /// <typeparam name="T"> The type to deserialize the response's 'Response' section into. </typeparam>
        /// <param name="response"> The HttpResponseMessage containing the API response. </param>
        /// <returns> The deserialized response object. </returns>
        /// <exception cref="TencentCloudSDKException"> Thrown if there are issues reading or deserializing the response. </exception>
        private async Task<T> ReadJsonResponseAsync<T>(HttpResponseMessage response)
        {
            string strResp = null;
            try
            {
                strResp = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new TencentCloudSDKException("API request failed", e);
            }

            JsonResponseModel<JsonResponseErrModel> errResp = null;
            try
            {
                errResp = JsonConvert.DeserializeObject<JsonResponseModel<JsonResponseErrModel>>(strResp);
            }
            catch (JsonSerializationException e)
            {
                throw new TencentCloudSDKException(e.Message);
            }

            if (errResp.Response.Error != null)
            {
                throw new TencentCloudSDKException(
                    errResp.Response.Error.Message, errResp.Response.Error.Code, errResp.Response.RequestId);
            }

            return JsonConvert.DeserializeObject<JsonResponseModel<T>>(strResp).Response;
        }

        /// <summary>
        ///   Handles Server-Sent Events (SSE) responses.
        /// </summary>
        /// <typeparam name="T"> The type to deserialize the SSE events into (must inherit from AbstractSSEModel). </typeparam>
        /// <param name="response"> The HttpResponseMessage containing the SSE stream. </param>
        /// <returns> The deserialized response object. </returns>
        /// <exception cref="InvalidCastException"> Thrown if the specified type is not a subclass of AbstractSSEModel. </exception>
        private Task<T> ReadSSEResponseAsync<T>(HttpResponseMessage response)
        {
            if (!typeof(AbstractSSEModel).IsAssignableFrom(typeof(T)))
            {
                throw new InvalidCastException(
                    $"invalid type: {typeof(T)} is not subclass of {nameof(AbstractSSEModel)}");
            }

            var resp = Activator.CreateInstance<T>() as AbstractSSEModel;
            if (resp == null)
            {
                throw new InvalidCastException(
                    $"invalid type: {typeof(T)} is not subclass of {nameof(AbstractSSEModel)}");
            }

            resp.RequestId = response.Headers.GetValues("X-TC-RequestId").FirstOrDefault();
            resp.Response = response;

            return Task.FromResult((T)(object)resp);
        }

        /// <summary>
        ///   Makes an API request using signature version 3.
        /// </summary>
        /// <param name="request"> The request object. </param>
        /// <param name="actionName"> The API action name. </param>
        /// <returns> The HttpResponseMessage for the request. </returns>
        /// <exception cref="TencentCloudSDKException"> Thrown if the API request fails. </exception>
        private async Task<HttpResponseMessage> RequestV3(AbstractModel request, string actionName)
        {
            string canonicalQueryString = this.BuildCanonicalQueryString(request);
            byte[] requestPayload = this.BuildRequestPayload(request);
            string contentType = this.BuildContentType(request);

            Dictionary<string, string> headers =
                this.BuildHeaders(contentType, requestPayload, canonicalQueryString, request);
            headers.Add("X-TC-Action", actionName);
            string endpoint = headers["Host"];

            HttpConnection conn = new HttpConnection(
                $"{this.Profile.HttpProfile.Protocol}{endpoint}",
                this.Profile.HttpProfile.Timeout,
                this.Profile.HttpProfile.WebProxy,
                this.HttpClient);

            try
            {
                if (this.Profile.HttpProfile.ReqMethod == HttpProfile.REQ_GET)
                    return await conn.GetRequestAsync(this.Path, canonicalQueryString, headers).ConfigureAwait(false);

                if (this.Profile.HttpProfile.ReqMethod == HttpProfile.REQ_POST)
                    return await conn.PostRequestAsync(this.Path, requestPayload, headers).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new TencentCloudSDKException("API request failed", e);
            }

            return null;
        }

        /// <summary>
        ///   Builds the headers for an API request using signature version 3.
        /// </summary>
        /// <param name="contentType"> The Content-Type header value. </param>
        /// <param name="requestPayload"> The request payload (body). </param>
        /// <param name="canonicalQueryString"> The canonical query string. </param>
        /// <param name="request"> The request object. </param>
        /// <returns> A dictionary of headers to include in the request. </returns>
        private Dictionary<string, string> BuildHeaders(string contentType, byte[] requestPayload,
            string canonicalQueryString, AbstractModel request)
        {
            string endpoint = this.Endpoint;
            if (!string.IsNullOrEmpty(this.Profile.HttpProfile.Endpoint))
            {
                endpoint = this.Profile.HttpProfile.Endpoint;
            }

            string httpRequestMethod = this.Profile.HttpProfile.ReqMethod;
            string canonicalURI = "/";
            string canonicalHeaders = "content-type:" + contentType + "\nhost:" + endpoint + "\n";
            string signedHeaders = "content-type;host";
            string hashedRequestPayload = SignHelper.SHA256Hex(requestPayload);
            string canonicalRequest = httpRequestMethod + "\n"
                                                        + canonicalURI + "\n"
                                                        + canonicalQueryString + "\n"
                                                        + canonicalHeaders + "\n"
                                                        + signedHeaders + "\n"
                                                        + hashedRequestPayload;

            string algorithm = "TC3-HMAC-SHA256";
            long timestamp = ToTimestamp() / 1000;
            string requestTimestamp = timestamp.ToString();
            string date = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp)
                .ToString("yyyy-MM-dd");
            string service = endpoint.Split('.')[0];
            string credentialScope = date + "/" + service + "/" + "tc3_request";
            string hashedCanonicalRequest = SignHelper.SHA256Hex(canonicalRequest);
            string stringToSign = algorithm + "\n"
                                            + requestTimestamp + "\n"
                                            + credentialScope + "\n"
                                            + hashedCanonicalRequest;

            byte[] tc3SecretKey = Encoding.UTF8.GetBytes("TC3" + Credential.SecretKey);
            byte[] secretDate = SignHelper.HmacSHA256(tc3SecretKey, Encoding.UTF8.GetBytes(date));
            byte[] secretService = SignHelper.HmacSHA256(secretDate, Encoding.UTF8.GetBytes(service));
            byte[] secretSigning = SignHelper.HmacSHA256(secretService, Encoding.UTF8.GetBytes("tc3_request"));
            byte[] signatureBytes = SignHelper.HmacSHA256(secretSigning, Encoding.UTF8.GetBytes(stringToSign));
            string signature = BitConverter.ToString(signatureBytes).Replace("-", "").ToLower();

            string authorization = algorithm + " "
                                             + "Credential=" + Credential.SecretId + "/" + credentialScope + ", "
                                             + "SignedHeaders=" + signedHeaders + ", "
                                             + "Signature=" + signature;

            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Authorization", authorization);
            headers.Add("Host", endpoint);
            headers.Add("Content-Type", contentType);
            headers.Add("X-TC-Timestamp", requestTimestamp);
            headers.Add("X-TC-Version", this.ApiVersion);
            headers.Add("X-TC-Region", this.Region);
            headers.Add("X-TC-RequestClient", this.SdkVersion);
            if (!string.IsNullOrEmpty(this.Credential.Token))
            {
                headers.Add("X-TC-Token", this.Credential.Token);
            }

            if (this.Profile.Language == Language.EN_US)
            {
                headers.Add("X-TC-Language", "en-US");
            }
            else
            {
                headers.Add("X-TC-Language", "zh-CN");
            }

            if (contentType == "application/octet-stream")
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                request.ToMap(param, "X-" + service.ToUpper() + "-");
                foreach (KeyValuePair<string, string> kv in param)
                    headers.Add(kv.Key, kv.Value);
            }

            return headers;
        }

        private string BuildContentType(AbstractModel request)
        {
            if (request is IOctetRequest)
                return "application/octet-stream";

            string httpRequestMethod = this.Profile.HttpProfile.ReqMethod;
            if (HttpProfile.REQ_GET.Equals(httpRequestMethod))
            {
                return "application/x-www-form-urlencoded";
            }
            else
            {
                return "application/json";
            }
        }

        /// <summary>
        ///   Builds the canonical query string for a GET request.
        ///   This string is part of the signature calculation.
        /// </summary>
        /// <param name="request"> The request object containing parameters. </param>
        /// <returns> The canonical query string. </returns>
        private string BuildCanonicalQueryString(AbstractModel request)
        {
            string httpRequestMethod = this.Profile.HttpProfile.ReqMethod;
            // Only build a query string for GET requests
            if (!HttpProfile.REQ_GET.Equals(httpRequestMethod))
            {
                return "";
            }

            Dictionary<string, string> param = new Dictionary<string, string>();
            request.ToMap(param, "");
            StringBuilder urlBuilder = new StringBuilder();
            // Build the query string by encoding keys and values
            foreach (KeyValuePair<string, string> kvp in param)
            {
                urlBuilder.Append($"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}&");
            }

            return urlBuilder.ToString().TrimEnd('&');
        }

        /// <summary>
        ///   Builds the request payload (body) for POST requests.
        ///   Handles different types of request bodies (JSON, Serializable, OctetStream).
        /// </summary>
        /// <param name="request"> The request object. </param>
        /// <returns> The byte array representing the request payload. </returns>
        private byte[] BuildRequestPayload(AbstractModel request)
        {
            string httpRequestMethod = this.Profile.HttpProfile.ReqMethod;
            // GET requests don't have a payload
            if (HttpProfile.REQ_GET.Equals(httpRequestMethod))
            {
                return Encoding.UTF8.GetBytes("");
            }

            // Handle requests that implement ISerializable (custom serialization)
            var serializableRequest = request as ISerializable;
            if (serializableRequest != null)
                return Encoding.UTF8.GetBytes(serializableRequest.Serialize());

            // Handle requests that implement IOctetRequest (raw byte stream)
            var octetRequest = request as IOctetRequest;
            if (octetRequest != null)
            {
                byte[] octetBody = octetRequest.OctetBody;
                if (octetBody != null)
                    return octetBody;
                return Encoding.UTF8.GetBytes("");
            }

            // Default: Serialize the request object to JSON
            return Encoding.UTF8.GetBytes(
                JsonConvert.SerializeObject(request, Formatting.None,
                    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
        }

        /// <summary>
        ///   Builds the parameter dictionary for signing and sending the request.
        ///   It populates the dictionary from the request object and adds common parameters.
        /// </summary>
        /// <param name="request"> The request object. </param>
        /// <param name="actionName"> The name of the API action. </param>
        /// <returns> The dictionary of parameters. </returns>
        private Dictionary<string, string> BuildParam(AbstractModel request, string actionName)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            request.ToMap(param, "");
            // inplace change
            this.FormatRequestData(actionName, param);
            return param;
        }

        /// <summary>
        ///   Makes an API request using signature version 1.
        ///   This is an older signature method and might be less secure.
        /// </summary>
        /// <param name="request"> The request object. </param>
        /// <param name="actionName"> The name of the API action. </param>
        /// <returns> The HttpResponseMessage for the request. </returns>
        /// <exception cref="TencentCloudSDKException"> Thrown if the API request fails. </exception>
        private async Task<HttpResponseMessage> RequestV1(AbstractModel request, string actionName)
        {
            Dictionary<string, string> param = BuildParam(request, actionName); // Build the parameter dictionary
            string endpoint = this.Endpoint;
            // Use a custom endpoint if provided in the profile
            if (!string.IsNullOrEmpty(this.Profile.HttpProfile.Endpoint))
            {
                endpoint = this.Profile.HttpProfile.Endpoint;
            }

            HttpConnection conn = new HttpConnection(
                $"{this.Profile.HttpProfile.Protocol}{endpoint}",
                this.Profile.HttpProfile.Timeout,
                this.Profile.HttpProfile.WebProxy,
                this.HttpClient);

            try
            {
                // Make the appropriate HTTP request (GET or POST)
                if (this.Profile.HttpProfile.ReqMethod == HttpProfile.REQ_GET)
                    return await conn.GetRequestAsync(this.Path, param).ConfigureAwait(false);

                if (this.Profile.HttpProfile.ReqMethod == HttpProfile.REQ_POST)
                    return await conn.PostRequestAsync(this.Path, param).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new TencentCloudSDKException("API request failed", e);
            }

            return null;
        }

        private Dictionary<string, string> FormatRequestData(string action, Dictionary<string, string> param)
        {
            param.Add("Action", action);
            param.Add("RequestClient", this.SdkVersion);
            param.Add("Nonce", Math.Abs(new Random().Next()).ToString());

            long unixTime = ToTimestamp();
            param.Add("Timestamp", (unixTime / 1000).ToString());
            param.Add("Version", this.ApiVersion);

            if (!string.IsNullOrEmpty(this.Credential.SecretId))
            {
                param.Add("SecretId", this.Credential.SecretId);
            }

            if (!string.IsNullOrEmpty(this.Region))
            {
                param.Add("Region", this.Region);
            }

            if (!string.IsNullOrEmpty(this.Profile.SignMethod))
            {
                param.Add("SignatureMethod", this.Profile.SignMethod);
            }

            if (!string.IsNullOrEmpty(this.Credential.Token))
            {
                param.Add("Token", this.Credential.Token);
            }

            if (this.Profile.Language == Language.EN_US)
            {
                param.Add("Language", "en-US");
            }
            else if (this.Profile.Language == Language.ZH_CN)
            {
                param.Add("Language", "zh-CN");
            }

            string endpoint = this.Endpoint;
            if (!string.IsNullOrEmpty(this.Profile.HttpProfile.Endpoint))
            {
                endpoint = this.Profile.HttpProfile.Endpoint;
            }

            string sigInParam = SignHelper.MakeSignPlainText(
                new SortedDictionary<string, string>(param, StringComparer.Ordinal),
                this.Profile.HttpProfile.ReqMethod, endpoint, this.Path);
            string sigOutParam = SignHelper.Sign(this.Credential.SecretKey, sigInParam, this.Profile.SignMethod);
            param.Add("Signature", sigOutParam);
            return param;
        }

        public long ToTimestamp()
        {
#if NET45
            DateTime startTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            DateTime nowTime = DateTime.UtcNow;
            long unixTime = (long)Math.Round((nowTime - startTime).TotalMilliseconds, MidpointRounding.AwayFromZero);
            return unixTime;
#endif

#if NS2 || NETSTANDARD2_0
            DateTimeOffset expiresAtOffset = DateTimeOffset.Now;
            var totalSeconds = expiresAtOffset.ToUnixTimeMilliseconds();
            return totalSeconds;
#endif
        }
    }
}