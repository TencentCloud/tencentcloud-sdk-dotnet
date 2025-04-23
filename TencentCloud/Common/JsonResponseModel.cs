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

namespace TencentCloud.Common
{
    /// <summary>
    ///   Model representing a standard JSON response from the Tencent Cloud API.
    ///   This class is used to deserialize the "Response" part of the API response,
    ///   which contains either the successful result or an error.
    ///   The type parameter T represents the type of the successful response data.
    /// </summary>
    /// <typeparam name="T">The type of the response data.</typeparam>
    public class JsonResponseModel<T>
    {
        /// <summary>
        ///   The actual response data from the API.
        ///   If the API call is successful, this property will contain the deserialized data.
        ///   If there is an error, this property might be null, and the error
        ///   information will be available elsewhere (e.g., in an Error property).
        /// </summary>
        [JsonProperty("Response")]
        public T Response { get; set; }
    }
}