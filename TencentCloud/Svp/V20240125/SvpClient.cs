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

namespace TencentCloud.Svp.V20240125
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Svp.V20240125.Models;

   public class SvpClient : AbstractClient{

       private const string endpoint = "svp.tencentcloudapi.com";
       private const string version = "2024-01-25";
       private const string sdkVersion = "SDK_NET_3.0.1149";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SvpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SvpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建节省计划订单
        /// </summary>
        /// <param name="req"><see cref="CreateSavingPlanOrderRequest"/></param>
        /// <returns><see cref="CreateSavingPlanOrderResponse"/></returns>
        public Task<CreateSavingPlanOrderResponse> CreateSavingPlanOrder(CreateSavingPlanOrderRequest req)
        {
            return InternalRequestAsync<CreateSavingPlanOrderResponse>(req, "CreateSavingPlanOrder");
        }

        /// <summary>
        /// 创建节省计划订单
        /// </summary>
        /// <param name="req"><see cref="CreateSavingPlanOrderRequest"/></param>
        /// <returns><see cref="CreateSavingPlanOrderResponse"/></returns>
        public CreateSavingPlanOrderResponse CreateSavingPlanOrderSync(CreateSavingPlanOrderRequest req)
        {
            return InternalRequestAsync<CreateSavingPlanOrderResponse>(req, "CreateSavingPlanOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询节省计划抵扣明细
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanDeductRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanDeductResponse"/></returns>
        public Task<DescribeSavingPlanDeductResponse> DescribeSavingPlanDeduct(DescribeSavingPlanDeductRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanDeductResponse>(req, "DescribeSavingPlanDeduct");
        }

        /// <summary>
        /// 查询节省计划抵扣明细
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanDeductRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanDeductResponse"/></returns>
        public DescribeSavingPlanDeductResponse DescribeSavingPlanDeductSync(DescribeSavingPlanDeductRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanDeductResponse>(req, "DescribeSavingPlanDeduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查用当前用户明细节省计划总览查询时段内的使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanOverviewRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanOverviewResponse"/></returns>
        public Task<DescribeSavingPlanOverviewResponse> DescribeSavingPlanOverview(DescribeSavingPlanOverviewRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanOverviewResponse>(req, "DescribeSavingPlanOverview");
        }

        /// <summary>
        /// 查用当前用户明细节省计划总览查询时段内的使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanOverviewRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanOverviewResponse"/></returns>
        public DescribeSavingPlanOverviewResponse DescribeSavingPlanOverviewSync(DescribeSavingPlanOverviewRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanOverviewResponse>(req, "DescribeSavingPlanOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查用当前用户明细节省计划查询时段内的使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanUsageRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanUsageResponse"/></returns>
        public Task<DescribeSavingPlanUsageResponse> DescribeSavingPlanUsage(DescribeSavingPlanUsageRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanUsageResponse>(req, "DescribeSavingPlanUsage");
        }

        /// <summary>
        /// 查用当前用户明细节省计划查询时段内的使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanUsageRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanUsageResponse"/></returns>
        public DescribeSavingPlanUsageResponse DescribeSavingPlanUsageSync(DescribeSavingPlanUsageRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanUsageResponse>(req, "DescribeSavingPlanUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
