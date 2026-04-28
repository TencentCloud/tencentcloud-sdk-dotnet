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

namespace TencentCloud.Antiddos.V20250903
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Antiddos.V20250903.Models;

   public class AntiddosClient : AbstractClient{

       private const string endpoint = "antiddos.tencentcloudapi.com";
       private const string version = "2025-09-03";
       private const string sdkVersion = "SDK_NET_3.0.1418";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AntiddosClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AntiddosClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 查询封堵解封记录和解封配额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSBlockRecordsRequest"/></param>
        /// <returns><see cref="DescribeDDoSBlockRecordsResponse"/></returns>
        public Task<DescribeDDoSBlockRecordsResponse> DescribeDDoSBlockRecords(DescribeDDoSBlockRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDDoSBlockRecordsResponse>(req, "DescribeDDoSBlockRecords");
        }

        /// <summary>
        /// 查询封堵解封记录和解封配额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSBlockRecordsRequest"/></param>
        /// <returns><see cref="DescribeDDoSBlockRecordsResponse"/></returns>
        public DescribeDDoSBlockRecordsResponse DescribeDDoSBlockRecordsSync(DescribeDDoSBlockRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDDoSBlockRecordsResponse>(req, "DescribeDDoSBlockRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 申请解封资源，可通过 DescribeDDoSBlockRecords 接口获取资源的封堵解封状态。
        /// </summary>
        /// <param name="req"><see cref="UnblockResourcesRequest"/></param>
        /// <returns><see cref="UnblockResourcesResponse"/></returns>
        public Task<UnblockResourcesResponse> UnblockResources(UnblockResourcesRequest req)
        {
            return InternalRequestAsync<UnblockResourcesResponse>(req, "UnblockResources");
        }

        /// <summary>
        /// 申请解封资源，可通过 DescribeDDoSBlockRecords 接口获取资源的封堵解封状态。
        /// </summary>
        /// <param name="req"><see cref="UnblockResourcesRequest"/></param>
        /// <returns><see cref="UnblockResourcesResponse"/></returns>
        public UnblockResourcesResponse UnblockResourcesSync(UnblockResourcesRequest req)
        {
            return InternalRequestAsync<UnblockResourcesResponse>(req, "UnblockResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
