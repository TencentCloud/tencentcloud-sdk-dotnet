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

namespace TencentCloud.Tourism.V20230215
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tourism.V20230215.Models;

   public class TourismClient : AbstractClient{

       private const string endpoint = "tourism.tencentcloudapi.com";
       private const string version = "2023-02-15";
       private const string sdkVersion = "SDK_NET_3.0.1143";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TourismClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TourismClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 依据客户的Uin查询开通的资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDrawResourceListRequest"/></param>
        /// <returns><see cref="DescribeDrawResourceListResponse"/></returns>
        public Task<DescribeDrawResourceListResponse> DescribeDrawResourceList(DescribeDrawResourceListRequest req)
        {
            return InternalRequestAsync<DescribeDrawResourceListResponse>(req, "DescribeDrawResourceList");
        }

        /// <summary>
        /// 依据客户的Uin查询开通的资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDrawResourceListRequest"/></param>
        /// <returns><see cref="DescribeDrawResourceListResponse"/></returns>
        public DescribeDrawResourceListResponse DescribeDrawResourceListSync(DescribeDrawResourceListRequest req)
        {
            return InternalRequestAsync<DescribeDrawResourceListResponse>(req, "DescribeDrawResourceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
