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

namespace TencentCloud.Vod.V20240718
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vod.V20240718.Models;

   public class VodClient : AbstractClient{

       private const string endpoint = "vod.tencentcloudapi.com";
       private const string version = "2024-07-18";
       private const string sdkVersion = "SDK_NET_3.0.1165";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VodClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 用于按指定策略，生成专业版应用的临时访问凭证，比如生成用于客户端上传的临时凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateStorageCredentialsRequest"/></param>
        /// <returns><see cref="CreateStorageCredentialsResponse"/></returns>
        public Task<CreateStorageCredentialsResponse> CreateStorageCredentials(CreateStorageCredentialsRequest req)
        {
            return InternalRequestAsync<CreateStorageCredentialsResponse>(req, "CreateStorageCredentials");
        }

        /// <summary>
        /// 用于按指定策略，生成专业版应用的临时访问凭证，比如生成用于客户端上传的临时凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateStorageCredentialsRequest"/></param>
        /// <returns><see cref="CreateStorageCredentialsResponse"/></returns>
        public CreateStorageCredentialsResponse CreateStorageCredentialsSync(CreateStorageCredentialsRequest req)
        {
            return InternalRequestAsync<CreateStorageCredentialsResponse>(req, "CreateStorageCredentials")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
