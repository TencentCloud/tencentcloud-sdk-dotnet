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

namespace TencentCloud.Portal.V20230413
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Portal.V20230413.Models;

   public class PortalClient : AbstractClient{

       private const string endpoint = "portal.tencentcloudapi.com";
       private const string version = "2023-04-13";
       private const string sdkVersion = "SDK_NET_3.0.1493";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PortalClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public PortalClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 通过关键词搜索文档列表
        /// </summary>
        /// <param name="req"><see cref="SearchDocumentsRequest"/></param>
        /// <returns><see cref="SearchDocumentsResponse"/></returns>
        public Task<SearchDocumentsResponse> SearchDocuments(SearchDocumentsRequest req)
        {
            return InternalRequestAsync<SearchDocumentsResponse>(req, "SearchDocuments");
        }

        /// <summary>
        /// 通过关键词搜索文档列表
        /// </summary>
        /// <param name="req"><see cref="SearchDocumentsRequest"/></param>
        /// <returns><see cref="SearchDocumentsResponse"/></returns>
        public SearchDocumentsResponse SearchDocumentsSync(SearchDocumentsRequest req)
        {
            return InternalRequestAsync<SearchDocumentsResponse>(req, "SearchDocuments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
