/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Common
{
    /// <summary>
    ///   Model representing a JSON response error.
    ///   This is used to deserialize error information from the Tencent Cloud API.
    /// </summary>
    public class JsonResponseErrModel
    {
        /// <summary>
        ///   The request ID associated with the error.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        ///   The error information.
        /// </summary>
        [JsonProperty("Error")]
        public ErrorInfo Error { get; set; }
    }

    /// <summary>
    ///   Detailed error information.
    /// </summary>
    public class ErrorInfo
    {
        /// <summary>
        ///   The error code.
        /// </summary>
        [JsonProperty("Code")]
        public string Code { get; set; }

        /// <summary>
        ///   The error message.
        /// </summary>
        [JsonProperty("Message")]
        public string Message { get; set; }
    }
}