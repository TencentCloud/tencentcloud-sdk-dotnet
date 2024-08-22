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

namespace TencentCloud.Cdz.V20221123
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdz.V20221123.Models;

   public class CdzClient : AbstractClient{

       private const string endpoint = "cdz.tencentcloudapi.com";
       private const string version = "2022-11-23";
       private const string sdkVersion = "SDK_NET_3.0.1075";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdzClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdzClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 查询可用区的Host和Host上部署的实例
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudDedicatedZoneHostsRequest"/></param>
        /// <returns><see cref="DescribeCloudDedicatedZoneHostsResponse"/></returns>
        public Task<DescribeCloudDedicatedZoneHostsResponse> DescribeCloudDedicatedZoneHosts(DescribeCloudDedicatedZoneHostsRequest req)
        {
            return InternalRequestAsync<DescribeCloudDedicatedZoneHostsResponse>(req, "DescribeCloudDedicatedZoneHosts");
        }

        /// <summary>
        /// 查询可用区的Host和Host上部署的实例
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudDedicatedZoneHostsRequest"/></param>
        /// <returns><see cref="DescribeCloudDedicatedZoneHostsResponse"/></returns>
        public DescribeCloudDedicatedZoneHostsResponse DescribeCloudDedicatedZoneHostsSync(DescribeCloudDedicatedZoneHostsRequest req)
        {
            return InternalRequestAsync<DescribeCloudDedicatedZoneHostsResponse>(req, "DescribeCloudDedicatedZoneHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询专属可用区各个垂直产品的资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudDedicatedZoneResourceSummaryRequest"/></param>
        /// <returns><see cref="DescribeCloudDedicatedZoneResourceSummaryResponse"/></returns>
        public Task<DescribeCloudDedicatedZoneResourceSummaryResponse> DescribeCloudDedicatedZoneResourceSummary(DescribeCloudDedicatedZoneResourceSummaryRequest req)
        {
            return InternalRequestAsync<DescribeCloudDedicatedZoneResourceSummaryResponse>(req, "DescribeCloudDedicatedZoneResourceSummary");
        }

        /// <summary>
        /// 查询专属可用区各个垂直产品的资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudDedicatedZoneResourceSummaryRequest"/></param>
        /// <returns><see cref="DescribeCloudDedicatedZoneResourceSummaryResponse"/></returns>
        public DescribeCloudDedicatedZoneResourceSummaryResponse DescribeCloudDedicatedZoneResourceSummarySync(DescribeCloudDedicatedZoneResourceSummaryRequest req)
        {
            return InternalRequestAsync<DescribeCloudDedicatedZoneResourceSummaryResponse>(req, "DescribeCloudDedicatedZoneResourceSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
