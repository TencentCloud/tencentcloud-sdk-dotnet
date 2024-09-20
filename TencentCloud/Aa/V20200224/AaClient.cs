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

namespace TencentCloud.Aa.V20200224
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Aa.V20200224.Models;

   public class AaClient : AbstractClient{

       private const string endpoint = "aa.tencentcloudapi.com";
       private const string version = "2020-02-24";
       private const string sdkVersion = "SDK_NET_3.0.1091";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 腾讯云活动防刷（ActivityAntiRush，AA）是针对电商、O2O、P2P、游戏、支付等行业在促销活动中遇到“羊毛党”恶意刷取优惠福利的行为时，通过防刷引擎，精准识别出“薅羊毛”恶意行为的活动防刷服务，避免了企业被刷带来的巨大经济损失。
        /// </summary>
        /// <param name="req"><see cref="QueryActivityAntiRushRequest"/></param>
        /// <returns><see cref="QueryActivityAntiRushResponse"/></returns>
        public Task<QueryActivityAntiRushResponse> QueryActivityAntiRush(QueryActivityAntiRushRequest req)
        {
            return InternalRequestAsync<QueryActivityAntiRushResponse>(req, "QueryActivityAntiRush");
        }

        /// <summary>
        /// 腾讯云活动防刷（ActivityAntiRush，AA）是针对电商、O2O、P2P、游戏、支付等行业在促销活动中遇到“羊毛党”恶意刷取优惠福利的行为时，通过防刷引擎，精准识别出“薅羊毛”恶意行为的活动防刷服务，避免了企业被刷带来的巨大经济损失。
        /// </summary>
        /// <param name="req"><see cref="QueryActivityAntiRushRequest"/></param>
        /// <returns><see cref="QueryActivityAntiRushResponse"/></returns>
        public QueryActivityAntiRushResponse QueryActivityAntiRushSync(QueryActivityAntiRushRequest req)
        {
            return InternalRequestAsync<QueryActivityAntiRushResponse>(req, "QueryActivityAntiRush")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
