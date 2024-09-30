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

namespace TencentCloud.Apm.V20210622
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Apm.V20210622.Models;

   public class ApmClient : AbstractClient{

       private const string endpoint = "apm.tencentcloudapi.com";
       private const string version = "2021-06-22";
       private const string sdkVersion = "SDK_NET_3.0.1100";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ApmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 业务购买APM实例，调用该接口创建
        /// </summary>
        /// <param name="req"><see cref="CreateApmInstanceRequest"/></param>
        /// <returns><see cref="CreateApmInstanceResponse"/></returns>
        public Task<CreateApmInstanceResponse> CreateApmInstance(CreateApmInstanceRequest req)
        {
            return InternalRequestAsync<CreateApmInstanceResponse>(req, "CreateApmInstance");
        }

        /// <summary>
        /// 业务购买APM实例，调用该接口创建
        /// </summary>
        /// <param name="req"><see cref="CreateApmInstanceRequest"/></param>
        /// <returns><see cref="CreateApmInstanceResponse"/></returns>
        public CreateApmInstanceResponse CreateApmInstanceSync(CreateApmInstanceRequest req)
        {
            return InternalRequestAsync<CreateApmInstanceResponse>(req, "CreateApmInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取APM Agent信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAgentRequest"/></param>
        /// <returns><see cref="DescribeApmAgentResponse"/></returns>
        public Task<DescribeApmAgentResponse> DescribeApmAgent(DescribeApmAgentRequest req)
        {
            return InternalRequestAsync<DescribeApmAgentResponse>(req, "DescribeApmAgent");
        }

        /// <summary>
        /// 获取APM Agent信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAgentRequest"/></param>
        /// <returns><see cref="DescribeApmAgentResponse"/></returns>
        public DescribeApmAgentResponse DescribeApmAgentSync(DescribeApmAgentRequest req)
        {
            return InternalRequestAsync<DescribeApmAgentResponse>(req, "DescribeApmAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// APM实例列表拉取
        /// </summary>
        /// <param name="req"><see cref="DescribeApmInstancesRequest"/></param>
        /// <returns><see cref="DescribeApmInstancesResponse"/></returns>
        public Task<DescribeApmInstancesResponse> DescribeApmInstances(DescribeApmInstancesRequest req)
        {
            return InternalRequestAsync<DescribeApmInstancesResponse>(req, "DescribeApmInstances");
        }

        /// <summary>
        /// APM实例列表拉取
        /// </summary>
        /// <param name="req"><see cref="DescribeApmInstancesRequest"/></param>
        /// <returns><see cref="DescribeApmInstancesResponse"/></returns>
        public DescribeApmInstancesResponse DescribeApmInstancesSync(DescribeApmInstancesRequest req)
        {
            return InternalRequestAsync<DescribeApmInstancesResponse>(req, "DescribeApmInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询应用配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralApmApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeGeneralApmApplicationConfigResponse"/></returns>
        public Task<DescribeGeneralApmApplicationConfigResponse> DescribeGeneralApmApplicationConfig(DescribeGeneralApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeGeneralApmApplicationConfigResponse>(req, "DescribeGeneralApmApplicationConfig");
        }

        /// <summary>
        /// 查询应用配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralApmApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeGeneralApmApplicationConfigResponse"/></returns>
        public DescribeGeneralApmApplicationConfigResponse DescribeGeneralApmApplicationConfigSync(DescribeGeneralApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeGeneralApmApplicationConfigResponse>(req, "DescribeGeneralApmApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指标数据通用接口。用户根据需要上送请求参数，返回对应的指标数据。
        /// 接口调用频率限制为：20次/秒，1200次/分钟。单请求的数据点数限制为1440个。
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralMetricDataRequest"/></param>
        /// <returns><see cref="DescribeGeneralMetricDataResponse"/></returns>
        public Task<DescribeGeneralMetricDataResponse> DescribeGeneralMetricData(DescribeGeneralMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeGeneralMetricDataResponse>(req, "DescribeGeneralMetricData");
        }

        /// <summary>
        /// 获取指标数据通用接口。用户根据需要上送请求参数，返回对应的指标数据。
        /// 接口调用频率限制为：20次/秒，1200次/分钟。单请求的数据点数限制为1440个。
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralMetricDataRequest"/></param>
        /// <returns><see cref="DescribeGeneralMetricDataResponse"/></returns>
        public DescribeGeneralMetricDataResponse DescribeGeneralMetricDataSync(DescribeGeneralMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeGeneralMetricDataResponse>(req, "DescribeGeneralMetricData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通用查询调用链列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralSpanListRequest"/></param>
        /// <returns><see cref="DescribeGeneralSpanListResponse"/></returns>
        public Task<DescribeGeneralSpanListResponse> DescribeGeneralSpanList(DescribeGeneralSpanListRequest req)
        {
            return InternalRequestAsync<DescribeGeneralSpanListResponse>(req, "DescribeGeneralSpanList");
        }

        /// <summary>
        /// 通用查询调用链列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralSpanListRequest"/></param>
        /// <returns><see cref="DescribeGeneralSpanListResponse"/></returns>
        public DescribeGeneralSpanListResponse DescribeGeneralSpanListSync(DescribeGeneralSpanListRequest req)
        {
            return InternalRequestAsync<DescribeGeneralSpanListResponse>(req, "DescribeGeneralSpanList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取通用指标列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricRecordsRequest"/></param>
        /// <returns><see cref="DescribeMetricRecordsResponse"/></returns>
        public Task<DescribeMetricRecordsResponse> DescribeMetricRecords(DescribeMetricRecordsRequest req)
        {
            return InternalRequestAsync<DescribeMetricRecordsResponse>(req, "DescribeMetricRecords");
        }

        /// <summary>
        /// 拉取通用指标列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricRecordsRequest"/></param>
        /// <returns><see cref="DescribeMetricRecordsResponse"/></returns>
        public DescribeMetricRecordsResponse DescribeMetricRecordsSync(DescribeMetricRecordsRequest req)
        {
            return InternalRequestAsync<DescribeMetricRecordsResponse>(req, "DescribeMetricRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 服务概览数据拉取
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceOverviewRequest"/></param>
        /// <returns><see cref="DescribeServiceOverviewResponse"/></returns>
        public Task<DescribeServiceOverviewResponse> DescribeServiceOverview(DescribeServiceOverviewRequest req)
        {
            return InternalRequestAsync<DescribeServiceOverviewResponse>(req, "DescribeServiceOverview");
        }

        /// <summary>
        /// 服务概览数据拉取
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceOverviewRequest"/></param>
        /// <returns><see cref="DescribeServiceOverviewResponse"/></returns>
        public DescribeServiceOverviewResponse DescribeServiceOverviewSync(DescribeServiceOverviewRequest req)
        {
            return InternalRequestAsync<DescribeServiceOverviewResponse>(req, "DescribeServiceOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据维度名和过滤条件，查询维度数据.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public Task<DescribeTagValuesResponse> DescribeTagValues(DescribeTagValuesRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesResponse>(req, "DescribeTagValues");
        }

        /// <summary>
        /// 根据维度名和过滤条件，查询维度数据.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public DescribeTagValuesResponse DescribeTagValuesSync(DescribeTagValuesRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesResponse>(req, "DescribeTagValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改APM实例接口
        /// </summary>
        /// <param name="req"><see cref="ModifyApmInstanceRequest"/></param>
        /// <returns><see cref="ModifyApmInstanceResponse"/></returns>
        public Task<ModifyApmInstanceResponse> ModifyApmInstance(ModifyApmInstanceRequest req)
        {
            return InternalRequestAsync<ModifyApmInstanceResponse>(req, "ModifyApmInstance");
        }

        /// <summary>
        /// 修改APM实例接口
        /// </summary>
        /// <param name="req"><see cref="ModifyApmInstanceRequest"/></param>
        /// <returns><see cref="ModifyApmInstanceResponse"/></returns>
        public ModifyApmInstanceResponse ModifyApmInstanceSync(ModifyApmInstanceRequest req)
        {
            return InternalRequestAsync<ModifyApmInstanceResponse>(req, "ModifyApmInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对外开放的openApi，客户可以灵活的指定需要修改的字段，再加入需要修改的服务列表.
        /// </summary>
        /// <param name="req"><see cref="ModifyGeneralApmApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyGeneralApmApplicationConfigResponse"/></returns>
        public Task<ModifyGeneralApmApplicationConfigResponse> ModifyGeneralApmApplicationConfig(ModifyGeneralApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<ModifyGeneralApmApplicationConfigResponse>(req, "ModifyGeneralApmApplicationConfig");
        }

        /// <summary>
        /// 对外开放的openApi，客户可以灵活的指定需要修改的字段，再加入需要修改的服务列表.
        /// </summary>
        /// <param name="req"><see cref="ModifyGeneralApmApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyGeneralApmApplicationConfigResponse"/></returns>
        public ModifyGeneralApmApplicationConfigResponse ModifyGeneralApmApplicationConfigSync(ModifyGeneralApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<ModifyGeneralApmApplicationConfigResponse>(req, "ModifyGeneralApmApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// apm销毁实例
        /// </summary>
        /// <param name="req"><see cref="TerminateApmInstanceRequest"/></param>
        /// <returns><see cref="TerminateApmInstanceResponse"/></returns>
        public Task<TerminateApmInstanceResponse> TerminateApmInstance(TerminateApmInstanceRequest req)
        {
            return InternalRequestAsync<TerminateApmInstanceResponse>(req, "TerminateApmInstance");
        }

        /// <summary>
        /// apm销毁实例
        /// </summary>
        /// <param name="req"><see cref="TerminateApmInstanceRequest"/></param>
        /// <returns><see cref="TerminateApmInstanceResponse"/></returns>
        public TerminateApmInstanceResponse TerminateApmInstanceSync(TerminateApmInstanceRequest req)
        {
            return InternalRequestAsync<TerminateApmInstanceResponse>(req, "TerminateApmInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
