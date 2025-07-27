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

namespace TencentCloud.Wsa.V20250508
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Wsa.V20250508.Models;

   public class WsaClient : AbstractClient{

       private const string endpoint = "wsa.tencentcloudapi.com";
       private const string version = "2025-05-08";
       private const string sdkVersion = "SDK_NET_3.0.1288";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WsaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WsaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 联网搜索API，以json形式向客户提供搜索结果数据，包含不仅限于标题、摘要、内容来源url等信息
        /// </summary>
        /// <param name="req"><see cref="SearchProRequest"/></param>
        /// <returns><see cref="SearchProResponse"/></returns>
        public Task<SearchProResponse> SearchPro(SearchProRequest req)
        {
            return InternalRequestAsync<SearchProResponse>(req, "SearchPro");
        }

        /// <summary>
        /// 联网搜索API，以json形式向客户提供搜索结果数据，包含不仅限于标题、摘要、内容来源url等信息
        /// </summary>
        /// <param name="req"><see cref="SearchProRequest"/></param>
        /// <returns><see cref="SearchProResponse"/></returns>
        public SearchProResponse SearchProSync(SearchProRequest req)
        {
            return InternalRequestAsync<SearchProResponse>(req, "SearchPro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
