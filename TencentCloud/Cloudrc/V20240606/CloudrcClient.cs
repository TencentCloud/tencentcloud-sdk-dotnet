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

namespace TencentCloud.Cloudrc.V20240606
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cloudrc.V20240606.Models;

   public class CloudrcClient : AbstractClient{

       private const string endpoint = "cloudrc.tencentcloudapi.com";
       private const string version = "2024-06-06";
       private const string sdkVersion = "SDK_NET_3.0.1493";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudrcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CloudrcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 查询资源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceRequest"/></param>
        /// <returns><see cref="DescribeResourceResponse"/></returns>
        public Task<DescribeResourceResponse> DescribeResource(DescribeResourceRequest req)
        {
            return InternalRequestAsync<DescribeResourceResponse>(req, "DescribeResource");
        }

        /// <summary>
        /// 查询资源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceRequest"/></param>
        /// <returns><see cref="DescribeResourceResponse"/></returns>
        public DescribeResourceResponse DescribeResourceSync(DescribeResourceRequest req)
        {
            return InternalRequestAsync<DescribeResourceResponse>(req, "DescribeResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 搜索资源
        /// </summary>
        /// <param name="req"><see cref="SearchResourcesRequest"/></param>
        /// <returns><see cref="SearchResourcesResponse"/></returns>
        public Task<SearchResourcesResponse> SearchResources(SearchResourcesRequest req)
        {
            return InternalRequestAsync<SearchResourcesResponse>(req, "SearchResources");
        }

        /// <summary>
        /// 搜索资源
        /// </summary>
        /// <param name="req"><see cref="SearchResourcesRequest"/></param>
        /// <returns><see cref="SearchResourcesResponse"/></returns>
        public SearchResourcesResponse SearchResourcesSync(SearchResourcesRequest req)
        {
            return InternalRequestAsync<SearchResourcesResponse>(req, "SearchResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
