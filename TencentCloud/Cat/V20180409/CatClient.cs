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

namespace TencentCloud.Cat.V20180409
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cat.V20180409.Models;

   public class CatClient : AbstractClient{

       private const string endpoint = "cat.tencentcloudapi.com";
       private const string version = "2018-04-09";
       private const string sdkVersion = "SDK_NET_3.0.1037";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CatClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CatClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 批量创建拨测任务
        /// </summary>
        /// <param name="req"><see cref="CreateProbeTasksRequest"/></param>
        /// <returns><see cref="CreateProbeTasksResponse"/></returns>
        public Task<CreateProbeTasksResponse> CreateProbeTasks(CreateProbeTasksRequest req)
        {
            return InternalRequestAsync<CreateProbeTasksResponse>(req, "CreateProbeTasks");
        }

        /// <summary>
        /// 批量创建拨测任务
        /// </summary>
        /// <param name="req"><see cref="CreateProbeTasksRequest"/></param>
        /// <returns><see cref="CreateProbeTasksResponse"/></returns>
        public CreateProbeTasksResponse CreateProbeTasksSync(CreateProbeTasksRequest req)
        {
            return InternalRequestAsync<CreateProbeTasksResponse>(req, "CreateProbeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除拨测任务
        /// </summary>
        /// <param name="req"><see cref="DeleteProbeTaskRequest"/></param>
        /// <returns><see cref="DeleteProbeTaskResponse"/></returns>
        public Task<DeleteProbeTaskResponse> DeleteProbeTask(DeleteProbeTaskRequest req)
        {
            return InternalRequestAsync<DeleteProbeTaskResponse>(req, "DeleteProbeTask");
        }

        /// <summary>
        /// 删除拨测任务
        /// </summary>
        /// <param name="req"><see cref="DeleteProbeTaskRequest"/></param>
        /// <returns><see cref="DeleteProbeTaskResponse"/></returns>
        public DeleteProbeTaskResponse DeleteProbeTaskSync(DeleteProbeTaskRequest req)
        {
            return InternalRequestAsync<DeleteProbeTaskResponse>(req, "DeleteProbeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据时间范围、任务ID、运营商等条件查询单次拨测详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDetailedSingleProbeDataRequest"/></param>
        /// <returns><see cref="DescribeDetailedSingleProbeDataResponse"/></returns>
        public Task<DescribeDetailedSingleProbeDataResponse> DescribeDetailedSingleProbeData(DescribeDetailedSingleProbeDataRequest req)
        {
            return InternalRequestAsync<DescribeDetailedSingleProbeDataResponse>(req, "DescribeDetailedSingleProbeData");
        }

        /// <summary>
        /// 根据时间范围、任务ID、运营商等条件查询单次拨测详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDetailedSingleProbeDataRequest"/></param>
        /// <returns><see cref="DescribeDetailedSingleProbeDataResponse"/></returns>
        public DescribeDetailedSingleProbeDataResponse DescribeDetailedSingleProbeDataSync(DescribeDetailedSingleProbeDataRequest req)
        {
            return InternalRequestAsync<DescribeDetailedSingleProbeDataResponse>(req, "DescribeDetailedSingleProbeData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取历史即时拨测任务
        /// </summary>
        /// <param name="req"><see cref="DescribeInstantTasksRequest"/></param>
        /// <returns><see cref="DescribeInstantTasksResponse"/></returns>
        public Task<DescribeInstantTasksResponse> DescribeInstantTasks(DescribeInstantTasksRequest req)
        {
            return InternalRequestAsync<DescribeInstantTasksResponse>(req, "DescribeInstantTasks");
        }

        /// <summary>
        /// 获取历史即时拨测任务
        /// </summary>
        /// <param name="req"><see cref="DescribeInstantTasksRequest"/></param>
        /// <returns><see cref="DescribeInstantTasksResponse"/></returns>
        public DescribeInstantTasksResponse DescribeInstantTasksSync(DescribeInstantTasksRequest req)
        {
            return InternalRequestAsync<DescribeInstantTasksResponse>(req, "DescribeInstantTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取拨测节点
        /// </summary>
        /// <param name="req"><see cref="DescribeNodesRequest"/></param>
        /// <returns><see cref="DescribeNodesResponse"/></returns>
        public Task<DescribeNodesResponse> DescribeNodes(DescribeNodesRequest req)
        {
            return InternalRequestAsync<DescribeNodesResponse>(req, "DescribeNodes");
        }

        /// <summary>
        /// 获取拨测节点
        /// </summary>
        /// <param name="req"><see cref="DescribeNodesRequest"/></param>
        /// <returns><see cref="DescribeNodesResponse"/></returns>
        public DescribeNodesResponse DescribeNodesSync(DescribeNodesRequest req)
        {
            return InternalRequestAsync<DescribeNodesResponse>(req, "DescribeNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云拨测指标数据，指标支持使用sum,avg,max,min聚合函数进行指标数据查询
        /// 拨测频率与groupby聚合时间设置关联，如拨测频率为 30 分钟，则 grouby 聚合时间建议设置为大于30分钟，避免出现查询数据为空的情况
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeMetricDataRequest"/></param>
        /// <returns><see cref="DescribeProbeMetricDataResponse"/></returns>
        public Task<DescribeProbeMetricDataResponse> DescribeProbeMetricData(DescribeProbeMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeProbeMetricDataResponse>(req, "DescribeProbeMetricData");
        }

        /// <summary>
        /// 查询云拨测指标数据，指标支持使用sum,avg,max,min聚合函数进行指标数据查询
        /// 拨测频率与groupby聚合时间设置关联，如拨测频率为 30 分钟，则 grouby 聚合时间建议设置为大于30分钟，避免出现查询数据为空的情况
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeMetricDataRequest"/></param>
        /// <returns><see cref="DescribeProbeMetricDataResponse"/></returns>
        public DescribeProbeMetricDataResponse DescribeProbeMetricDataSync(DescribeProbeMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeProbeMetricDataResponse>(req, "DescribeProbeMetricData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询拨测节点
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeNodesRequest"/></param>
        /// <returns><see cref="DescribeProbeNodesResponse"/></returns>
        public Task<DescribeProbeNodesResponse> DescribeProbeNodes(DescribeProbeNodesRequest req)
        {
            return InternalRequestAsync<DescribeProbeNodesResponse>(req, "DescribeProbeNodes");
        }

        /// <summary>
        /// 查询拨测节点
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeNodesRequest"/></param>
        /// <returns><see cref="DescribeProbeNodesResponse"/></returns>
        public DescribeProbeNodesResponse DescribeProbeNodesSync(DescribeProbeNodesRequest req)
        {
            return InternalRequestAsync<DescribeProbeNodesResponse>(req, "DescribeProbeNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询拨测任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeTasksRequest"/></param>
        /// <returns><see cref="DescribeProbeTasksResponse"/></returns>
        public Task<DescribeProbeTasksResponse> DescribeProbeTasks(DescribeProbeTasksRequest req)
        {
            return InternalRequestAsync<DescribeProbeTasksResponse>(req, "DescribeProbeTasks");
        }

        /// <summary>
        /// 查询拨测任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeTasksRequest"/></param>
        /// <returns><see cref="DescribeProbeTasksResponse"/></returns>
        public DescribeProbeTasksResponse DescribeProbeTasksSync(DescribeProbeTasksRequest req)
        {
            return InternalRequestAsync<DescribeProbeTasksResponse>(req, "DescribeProbeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复拨测任务
        /// </summary>
        /// <param name="req"><see cref="ResumeProbeTaskRequest"/></param>
        /// <returns><see cref="ResumeProbeTaskResponse"/></returns>
        public Task<ResumeProbeTaskResponse> ResumeProbeTask(ResumeProbeTaskRequest req)
        {
            return InternalRequestAsync<ResumeProbeTaskResponse>(req, "ResumeProbeTask");
        }

        /// <summary>
        /// 恢复拨测任务
        /// </summary>
        /// <param name="req"><see cref="ResumeProbeTaskRequest"/></param>
        /// <returns><see cref="ResumeProbeTaskResponse"/></returns>
        public ResumeProbeTaskResponse ResumeProbeTaskSync(ResumeProbeTaskRequest req)
        {
            return InternalRequestAsync<ResumeProbeTaskResponse>(req, "ResumeProbeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停拨测任务
        /// </summary>
        /// <param name="req"><see cref="SuspendProbeTaskRequest"/></param>
        /// <returns><see cref="SuspendProbeTaskResponse"/></returns>
        public Task<SuspendProbeTaskResponse> SuspendProbeTask(SuspendProbeTaskRequest req)
        {
            return InternalRequestAsync<SuspendProbeTaskResponse>(req, "SuspendProbeTask");
        }

        /// <summary>
        /// 暂停拨测任务
        /// </summary>
        /// <param name="req"><see cref="SuspendProbeTaskRequest"/></param>
        /// <returns><see cref="SuspendProbeTaskResponse"/></returns>
        public SuspendProbeTaskResponse SuspendProbeTaskSync(SuspendProbeTaskRequest req)
        {
            return InternalRequestAsync<SuspendProbeTaskResponse>(req, "SuspendProbeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新探测任务属性
        /// </summary>
        /// <param name="req"><see cref="UpdateProbeTaskAttributesRequest"/></param>
        /// <returns><see cref="UpdateProbeTaskAttributesResponse"/></returns>
        public Task<UpdateProbeTaskAttributesResponse> UpdateProbeTaskAttributes(UpdateProbeTaskAttributesRequest req)
        {
            return InternalRequestAsync<UpdateProbeTaskAttributesResponse>(req, "UpdateProbeTaskAttributes");
        }

        /// <summary>
        /// 更新探测任务属性
        /// </summary>
        /// <param name="req"><see cref="UpdateProbeTaskAttributesRequest"/></param>
        /// <returns><see cref="UpdateProbeTaskAttributesResponse"/></returns>
        public UpdateProbeTaskAttributesResponse UpdateProbeTaskAttributesSync(UpdateProbeTaskAttributesRequest req)
        {
            return InternalRequestAsync<UpdateProbeTaskAttributesResponse>(req, "UpdateProbeTaskAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量更新拨测任务配置
        /// </summary>
        /// <param name="req"><see cref="UpdateProbeTaskConfigurationListRequest"/></param>
        /// <returns><see cref="UpdateProbeTaskConfigurationListResponse"/></returns>
        public Task<UpdateProbeTaskConfigurationListResponse> UpdateProbeTaskConfigurationList(UpdateProbeTaskConfigurationListRequest req)
        {
            return InternalRequestAsync<UpdateProbeTaskConfigurationListResponse>(req, "UpdateProbeTaskConfigurationList");
        }

        /// <summary>
        /// 批量更新拨测任务配置
        /// </summary>
        /// <param name="req"><see cref="UpdateProbeTaskConfigurationListRequest"/></param>
        /// <returns><see cref="UpdateProbeTaskConfigurationListResponse"/></returns>
        public UpdateProbeTaskConfigurationListResponse UpdateProbeTaskConfigurationListSync(UpdateProbeTaskConfigurationListRequest req)
        {
            return InternalRequestAsync<UpdateProbeTaskConfigurationListResponse>(req, "UpdateProbeTaskConfigurationList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
