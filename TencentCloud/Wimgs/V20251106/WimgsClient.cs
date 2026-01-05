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

namespace TencentCloud.Wimgs.V20251106
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Wimgs.V20251106.Models;

   public class WimgsClient : AbstractClient{

       private const string endpoint = "wimgs.tencentcloudapi.com";
       private const string version = "2025-11-06";
       private const string sdkVersion = "SDK_NET_3.0.1374";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WimgsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WimgsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 文搜图接口，本服务将针对您输入的搜索关键词，检索并以JSON形式返回相关图片的标题、宽高、缩略图、内容来源url等信息。
        /// </summary>
        /// <param name="req"><see cref="SearchByTextRequest"/></param>
        /// <returns><see cref="SearchByTextResponse"/></returns>
        public Task<SearchByTextResponse> SearchByText(SearchByTextRequest req)
        {
            return InternalRequestAsync<SearchByTextResponse>(req, "SearchByText");
        }

        /// <summary>
        /// 文搜图接口，本服务将针对您输入的搜索关键词，检索并以JSON形式返回相关图片的标题、宽高、缩略图、内容来源url等信息。
        /// </summary>
        /// <param name="req"><see cref="SearchByTextRequest"/></param>
        /// <returns><see cref="SearchByTextResponse"/></returns>
        public SearchByTextResponse SearchByTextSync(SearchByTextRequest req)
        {
            return InternalRequestAsync<SearchByTextResponse>(req, "SearchByText")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
