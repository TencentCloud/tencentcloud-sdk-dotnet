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

namespace TencentCloud.Taf.V20200210
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Taf.V20200210.Models;

   public class TafClient : AbstractClient{

       private const string endpoint = "taf.tencentcloudapi.com";
       private const string version = "2020-02-10";
       private const string sdkVersion = "SDK_NET_3.0.1188";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TafClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TafClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 虚假流量识别
        /// </summary>
        /// <param name="req"><see cref="ManagePortraitRiskRequest"/></param>
        /// <returns><see cref="ManagePortraitRiskResponse"/></returns>
        public Task<ManagePortraitRiskResponse> ManagePortraitRisk(ManagePortraitRiskRequest req)
        {
            return InternalRequestAsync<ManagePortraitRiskResponse>(req, "ManagePortraitRisk");
        }

        /// <summary>
        /// 虚假流量识别
        /// </summary>
        /// <param name="req"><see cref="ManagePortraitRiskRequest"/></param>
        /// <returns><see cref="ManagePortraitRiskResponse"/></returns>
        public ManagePortraitRiskResponse ManagePortraitRiskSync(ManagePortraitRiskRequest req)
        {
            return InternalRequestAsync<ManagePortraitRiskResponse>(req, "ManagePortraitRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
