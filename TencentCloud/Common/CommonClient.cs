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

using System.Threading.Tasks;
using TencentCloud.Common.Profile;

namespace TencentCloud.Common
{
    /// <summary>
    ///   A common client for making API calls.
    ///   This client can be used to call any Tencent Cloud API by specifying the module, version, and action.
    /// </summary>
    public class CommonClient : AbstractClient
    {
        /// <summary>
        ///   Constructor for CommonClient.
        /// </summary>
        /// <param name="module"> The name of the Tencent Cloud service module (e.g., "cvm"). </param>
        /// <param name="version"> The version of the API to use (e.g., "2017-03-12"). </param>
        /// <param name="credential"> The user's security credentials. </param>
        /// <param name="region"> The region to access (e.g., "ap-guangzhou"). </param>
        /// <param name="profile"> The client profile with SDK settings. </param>
        public CommonClient(
            string module, string version, Credential credential, string region, ClientProfile profile)
            : base(module + ".tencentcloudapi.com", version, credential, region, profile)
        {
        }

        /// <summary>
        ///   Asynchronously calls a Tencent Cloud API and returns the raw JSON response.
        /// </summary>
        /// <param name="req"> The request object (CommonRequest). </param>
        /// <param name="action"> The name of the API action to call. </param>
        /// <returns> A task that represents the asynchronous operation. The task result contains the raw JSON response string. </returns>
        public Task<string> CallAsync(CommonRequest req, string action)
        {
            return InternalRequest(req, action);
        }

        /// <summary>
        ///   Asynchronously calls a Tencent Cloud API and deserializes the JSON response into a specific type.
        /// </summary>
        /// <typeparam name="TRep"> The type to deserialize the JSON response into. </typeparam>
        /// <param name="req"> The request object (CommonRequest). </param>
        /// <param name="action"> The name of the API action to call. </param>
        /// <returns> A task that represents the asynchronous operation. The task result contains the deserialized response object. </returns>
        public Task<TRep> CallAsync<TRep>(CommonRequest req, string action)
        {
            return InternalRequestAsync<TRep>(req, action);
        }

        /// <summary>
        ///   Synchronously calls a Tencent Cloud API and returns the raw JSON response.
        ///   It's recommended to use the asynchronous version (`CallAsync`) whenever possible to avoid blocking.
        /// </summary>
        /// <param name="req"> The request object (CommonRequest). </param>
        /// <param name="action"> The name of the API action to call. </param>
        /// <returns> The raw JSON response string. </returns>
        public string Call(CommonRequest req, string action)
        {
            return CallAsync(req, action).Result;
        }

        /// <summary>
        ///   Synchronously calls a Tencent Cloud API and deserializes the JSON response into a specific type.
        ///   It's recommended to use the asynchronous version (`CallAsync`) whenever possible to avoid blocking.
        /// </summary>
        /// <typeparam name="TRep"> The type to deserialize the JSON response into. </typeparam>
        /// <param name="req"> The request object (CommonRequest). </param>
        /// <param name="action"> The name of the API action to call. </param>
        /// <returns> The deserialized response object. </returns>
        public TRep Call<TRep>(CommonRequest req, string action)
        {
            return CallAsync<TRep>(req, action).Result;
        }
    }
}