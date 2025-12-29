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

namespace TencentCloud.Cloudmate.V20251030
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cloudmate.V20251030.Models;

   public class CloudmateClient : AbstractClient{

       private const string endpoint = "cloudmate.tencentcloudapi.com";
       private const string version = "2025-10-30";
       private const string sdkVersion = "SDK_NET_3.0.1370";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudmateClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CloudmateClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 发起智能诊断对话
        /// 注意：使用该API时，请务必设置请求域名（Endpoint）为 cloudmate.ai.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="CloudMateAgentRequest"/></param>
        /// <returns><see cref="CloudMateAgentResponse"/></returns>
        public Task<CloudMateAgentResponse> CloudMateAgent(CloudMateAgentRequest req)
        {
            return InternalRequestAsync<CloudMateAgentResponse>(req, "CloudMateAgent");
        }

        /// <summary>
        /// 发起智能诊断对话
        /// 注意：使用该API时，请务必设置请求域名（Endpoint）为 cloudmate.ai.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="CloudMateAgentRequest"/></param>
        /// <returns><see cref="CloudMateAgentResponse"/></returns>
        public CloudMateAgentResponse CloudMateAgentSync(CloudMateAgentRequest req)
        {
            return InternalRequestAsync<CloudMateAgentResponse>(req, "CloudMateAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
