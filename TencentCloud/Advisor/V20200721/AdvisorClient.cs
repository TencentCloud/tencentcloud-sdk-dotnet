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

namespace TencentCloud.Advisor.V20200721
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Advisor.V20200721.Models;

   public class AdvisorClient : AbstractClient{

       private const string endpoint = "advisor.tencentcloudapi.com";
       private const string version = "2020-07-21";
       private const string sdkVersion = "SDK_NET_3.0.1208";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AdvisorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AdvisorClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 用于查询评估项的信息
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategiesRequest"/></param>
        /// <returns><see cref="DescribeStrategiesResponse"/></returns>
        public Task<DescribeStrategiesResponse> DescribeStrategies(DescribeStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeStrategiesResponse>(req, "DescribeStrategies");
        }

        /// <summary>
        /// 用于查询评估项的信息
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategiesRequest"/></param>
        /// <returns><see cref="DescribeStrategiesResponse"/></returns>
        public DescribeStrategiesResponse DescribeStrategiesSync(DescribeStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeStrategiesResponse>(req, "DescribeStrategies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询评估项风险实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStrategyRisksRequest"/></param>
        /// <returns><see cref="DescribeTaskStrategyRisksResponse"/></returns>
        public Task<DescribeTaskStrategyRisksResponse> DescribeTaskStrategyRisks(DescribeTaskStrategyRisksRequest req)
        {
            return InternalRequestAsync<DescribeTaskStrategyRisksResponse>(req, "DescribeTaskStrategyRisks");
        }

        /// <summary>
        /// 查询评估项风险实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStrategyRisksRequest"/></param>
        /// <returns><see cref="DescribeTaskStrategyRisksResponse"/></returns>
        public DescribeTaskStrategyRisksResponse DescribeTaskStrategyRisksSync(DescribeTaskStrategyRisksRequest req)
        {
            return InternalRequestAsync<DescribeTaskStrategyRisksResponse>(req, "DescribeTaskStrategyRisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
