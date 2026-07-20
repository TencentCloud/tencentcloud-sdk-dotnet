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

namespace TencentCloud.Rce.V20260130
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rce.V20260130.Models;

   public class RceClient : AbstractClient{

       private const string endpoint = "rce.tencentcloudapi.com";
       private const string version = "2026-01-30";
       private const string sdkVersion = "SDK_NET_3.0.1466";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RceClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RceClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 环境风险评估
        /// </summary>
        /// <param name="req"><see cref="AssessEnvironmentRiskRequest"/></param>
        /// <returns><see cref="AssessEnvironmentRiskResponse"/></returns>
        public Task<AssessEnvironmentRiskResponse> AssessEnvironmentRisk(AssessEnvironmentRiskRequest req)
        {
            return InternalRequestAsync<AssessEnvironmentRiskResponse>(req, "AssessEnvironmentRisk");
        }

        /// <summary>
        /// 环境风险评估
        /// </summary>
        /// <param name="req"><see cref="AssessEnvironmentRiskRequest"/></param>
        /// <returns><see cref="AssessEnvironmentRiskResponse"/></returns>
        public AssessEnvironmentRiskResponse AssessEnvironmentRiskSync(AssessEnvironmentRiskRequest req)
        {
            return InternalRequestAsync<AssessEnvironmentRiskResponse>(req, "AssessEnvironmentRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
