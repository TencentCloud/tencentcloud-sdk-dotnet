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

namespace TencentCloud.Rce.V20201103
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rce.V20201103.Models;

   public class RceClient : AbstractClient{

       private const string endpoint = "rce.tencentcloudapi.com";
       private const string version = "2020-11-03";
       private const string sdkVersion = "SDK_NET_3.0.966";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RceClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RceClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 此接口用于查询风险评估结果
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskAssessmentRequest"/></param>
        /// <returns><see cref="DescribeRiskAssessmentResponse"/></returns>
        public Task<DescribeRiskAssessmentResponse> DescribeRiskAssessment(DescribeRiskAssessmentRequest req)
        {
            return InternalRequestAsync<DescribeRiskAssessmentResponse>(req, "DescribeRiskAssessment");
        }

        /// <summary>
        /// 此接口用于查询风险评估结果
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskAssessmentRequest"/></param>
        /// <returns><see cref="DescribeRiskAssessmentResponse"/></returns>
        public DescribeRiskAssessmentResponse DescribeRiskAssessmentSync(DescribeRiskAssessmentRequest req)
        {
            return InternalRequestAsync<DescribeRiskAssessmentResponse>(req, "DescribeRiskAssessment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 以图表形式展示三种请求状态的趋势变化
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskTrendsRequest"/></param>
        /// <returns><see cref="DescribeRiskTrendsResponse"/></returns>
        public Task<DescribeRiskTrendsResponse> DescribeRiskTrends(DescribeRiskTrendsRequest req)
        {
            return InternalRequestAsync<DescribeRiskTrendsResponse>(req, "DescribeRiskTrends");
        }

        /// <summary>
        /// 以图表形式展示三种请求状态的趋势变化
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskTrendsRequest"/></param>
        /// <returns><see cref="DescribeRiskTrendsResponse"/></returns>
        public DescribeRiskTrendsResponse DescribeRiskTrendsSync(DescribeRiskTrendsRequest req)
        {
            return InternalRequestAsync<DescribeRiskTrendsResponse>(req, "DescribeRiskTrends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 全栈式风控引擎（RiskControlEngine，RCE）是基于人工智能技术和腾讯20年风控实战沉淀，依托腾讯海量业务构建的风控引擎，以轻量级的 SaaS 服务方式接入，帮助您快速解决注册、登录、营销活动等关键场景遇到的欺诈问题，实时防御黑灰产作恶。
        /// </summary>
        /// <param name="req"><see cref="ManageMarketingRiskRequest"/></param>
        /// <returns><see cref="ManageMarketingRiskResponse"/></returns>
        public Task<ManageMarketingRiskResponse> ManageMarketingRisk(ManageMarketingRiskRequest req)
        {
            return InternalRequestAsync<ManageMarketingRiskResponse>(req, "ManageMarketingRisk");
        }

        /// <summary>
        /// 全栈式风控引擎（RiskControlEngine，RCE）是基于人工智能技术和腾讯20年风控实战沉淀，依托腾讯海量业务构建的风控引擎，以轻量级的 SaaS 服务方式接入，帮助您快速解决注册、登录、营销活动等关键场景遇到的欺诈问题，实时防御黑灰产作恶。
        /// </summary>
        /// <param name="req"><see cref="ManageMarketingRiskRequest"/></param>
        /// <returns><see cref="ManageMarketingRiskResponse"/></returns>
        public ManageMarketingRiskResponse ManageMarketingRiskSync(ManageMarketingRiskRequest req)
        {
            return InternalRequestAsync<ManageMarketingRiskResponse>(req, "ManageMarketingRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
