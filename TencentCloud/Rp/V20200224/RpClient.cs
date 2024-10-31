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

namespace TencentCloud.Rp.V20200224
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rp.V20200224.Models;

   public class RpClient : AbstractClient{

       private const string endpoint = "rp.tencentcloudapi.com";
       private const string version = "2020-02-24";
       private const string sdkVersion = "SDK_NET_3.0.1115";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 注册保护服务（RegisterProtection，RP）针对网站、APP 的线上注册场景，遇到 “恶意注册” 、“小号注册” 、“注册器注册” 等恶意行为，提供基于天御 DNA 算法的恶意防护引擎，从账号、设备、行为三个维度有效识别 “恶意注册”，从“源头”上防范业务风险。  
        /// </summary>
        /// <param name="req"><see cref="QueryRegisterProtectionRequest"/></param>
        /// <returns><see cref="QueryRegisterProtectionResponse"/></returns>
        public Task<QueryRegisterProtectionResponse> QueryRegisterProtection(QueryRegisterProtectionRequest req)
        {
            return InternalRequestAsync<QueryRegisterProtectionResponse>(req, "QueryRegisterProtection");
        }

        /// <summary>
        /// 注册保护服务（RegisterProtection，RP）针对网站、APP 的线上注册场景，遇到 “恶意注册” 、“小号注册” 、“注册器注册” 等恶意行为，提供基于天御 DNA 算法的恶意防护引擎，从账号、设备、行为三个维度有效识别 “恶意注册”，从“源头”上防范业务风险。  
        /// </summary>
        /// <param name="req"><see cref="QueryRegisterProtectionRequest"/></param>
        /// <returns><see cref="QueryRegisterProtectionResponse"/></returns>
        public QueryRegisterProtectionResponse QueryRegisterProtectionSync(QueryRegisterProtectionRequest req)
        {
            return InternalRequestAsync<QueryRegisterProtectionResponse>(req, "QueryRegisterProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
