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

namespace TencentCloud.Common.Profile
{
    /// <summary>
    ///  HTTP profiles.
    ///  This class encapsulates settings related to HTTP requests, such as method, endpoint, and timeout.
    /// </summary>
    public class HttpProfile
    {
        /// <summary>
        ///  HTTPS protocol scheme.
        /// </summary>
        public static readonly string REQ_HTTPS = "https://";

        /// <summary>
        ///  HTTP protocol scheme.
        ///  Note: Using HTTP is generally not recommended for security reasons.
        /// </summary>
        public static readonly string REQ_HTTP = "http://";

        /// <summary>
        ///  HTTP method: POST.
        ///  The POST method is commonly used to send data to the server.
        /// </summary>
        public static readonly string REQ_POST = "POST";

        /// <summary>
        ///  HTTP method: GET.
        ///  The GET method is commonly used to retrieve data from the server.
        /// </summary>
        public static readonly string REQ_GET = "GET";

        /// <summary>
        ///  Time unit constant representing one minute (60 seconds).
        ///  Used for convenience in setting timeout values.
        /// </summary>
        public static readonly int TM_MINUTE = 60;

        /// <summary>
        ///  Default constructor.
        ///  Initializes the HTTP profile with common default settings:
        ///  -   Uses POST as the request method.
        ///  -   Does not set a specific endpoint (it should be set later).
        ///  -   Uses HTTPS as the protocol.
        ///  -   Sets the timeout to 1 minute.
        /// </summary>
        public HttpProfile()
        {
            this.ReqMethod = REQ_POST;
            this.Endpoint = null;
            this.Protocol = REQ_HTTPS;
            this.Timeout = TM_MINUTE;
        }

        /// <summary>
        ///  HTTP request method (e.g., GET, POST).
        ///  Determines how the request is sent to the server.
        /// </summary>
        public string ReqMethod { get; set; }

        /// <summary>
        ///  Service endpoint or domain name.
        ///  This specifies the server that the SDK will communicate with.
        ///  Example: "cvm.tencentcloudapi.com"
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        ///  HTTP protocol scheme (e.g., HTTP, HTTPS).
        ///  Defines the communication protocol. HTTPS is strongly recommended for secure communication.
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        ///  HTTP request timeout value, in seconds.
        ///  This sets the maximum time the SDK will wait for a response from the server.
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        ///  HTTP proxy settings (optional).
        ///  If your environment requires using a proxy server, you can configure it here.
        ///  The format of this string depends on the specific proxy configuration.
        /// </summary>
        public string WebProxy { get; set; }
    }
}