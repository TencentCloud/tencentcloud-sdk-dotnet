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

namespace TencentCloud.Rce.V20250425
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rce.V20250425.Models;

   public class RceClient : AbstractClient{

       private const string endpoint = "rce.tencentcloudapi.com";
       private const string version = "2025-04-25";
       private const string sdkVersion = "SDK_NET_3.0.1375";

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
        /// IP画像接口
        /// </summary>
        /// <param name="req"><see cref="ManageIPPortraitRiskRequest"/></param>
        /// <returns><see cref="ManageIPPortraitRiskResponse"/></returns>
        public Task<ManageIPPortraitRiskResponse> ManageIPPortraitRisk(ManageIPPortraitRiskRequest req)
        {
            return InternalRequestAsync<ManageIPPortraitRiskResponse>(req, "ManageIPPortraitRisk");
        }

        /// <summary>
        /// IP画像接口
        /// </summary>
        /// <param name="req"><see cref="ManageIPPortraitRiskRequest"/></param>
        /// <returns><see cref="ManageIPPortraitRiskResponse"/></returns>
        public ManageIPPortraitRiskResponse ManageIPPortraitRiskSync(ManageIPPortraitRiskRequest req)
        {
            return InternalRequestAsync<ManageIPPortraitRiskResponse>(req, "ManageIPPortraitRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
