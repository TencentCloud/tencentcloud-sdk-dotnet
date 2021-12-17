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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CatClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 绑定拨测任务和告警策略组
        /// </summary>
        /// <param name="req"><see cref="BindAlarmPolicyRequest"/></param>
        /// <returns><see cref="BindAlarmPolicyResponse"/></returns>
        public async Task<BindAlarmPolicyResponse> BindAlarmPolicy(BindAlarmPolicyRequest req)
        {
             JsonResponseModel<BindAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定拨测任务和告警策略组
        /// </summary>
        /// <param name="req"><see cref="BindAlarmPolicyRequest"/></param>
        /// <returns><see cref="BindAlarmPolicyResponse"/></returns>
        public BindAlarmPolicyResponse BindAlarmPolicySync(BindAlarmPolicyRequest req)
        {
             JsonResponseModel<BindAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加拨测分组
        /// </summary>
        /// <param name="req"><see cref="CreateAgentGroupRequest"/></param>
        /// <returns><see cref="CreateAgentGroupResponse"/></returns>
        public async Task<CreateAgentGroupResponse> CreateAgentGroup(CreateAgentGroupRequest req)
        {
             JsonResponseModel<CreateAgentGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAgentGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAgentGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加拨测分组
        /// </summary>
        /// <param name="req"><see cref="CreateAgentGroupRequest"/></param>
        /// <returns><see cref="CreateAgentGroupResponse"/></returns>
        public CreateAgentGroupResponse CreateAgentGroupSync(CreateAgentGroupRequest req)
        {
             JsonResponseModel<CreateAgentGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAgentGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAgentGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量创建探测任务
        /// </summary>
        /// <param name="req"><see cref="CreateProbeTasksRequest"/></param>
        /// <returns><see cref="CreateProbeTasksResponse"/></returns>
        public async Task<CreateProbeTasksResponse> CreateProbeTasks(CreateProbeTasksRequest req)
        {
             JsonResponseModel<CreateProbeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProbeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProbeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量创建探测任务
        /// </summary>
        /// <param name="req"><see cref="CreateProbeTasksRequest"/></param>
        /// <returns><see cref="CreateProbeTasksResponse"/></returns>
        public CreateProbeTasksResponse CreateProbeTasksSync(CreateProbeTasksRequest req)
        {
             JsonResponseModel<CreateProbeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProbeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProbeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建拨测任务(扩展)
        /// </summary>
        /// <param name="req"><see cref="CreateTaskExRequest"/></param>
        /// <returns><see cref="CreateTaskExResponse"/></returns>
        public async Task<CreateTaskExResponse> CreateTaskEx(CreateTaskExRequest req)
        {
             JsonResponseModel<CreateTaskExResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTaskEx");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskExResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建拨测任务(扩展)
        /// </summary>
        /// <param name="req"><see cref="CreateTaskExRequest"/></param>
        /// <returns><see cref="CreateTaskExResponse"/></returns>
        public CreateTaskExResponse CreateTaskExSync(CreateTaskExRequest req)
        {
             JsonResponseModel<CreateTaskExResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTaskEx");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskExResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除拨测分组
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentGroupRequest"/></param>
        /// <returns><see cref="DeleteAgentGroupResponse"/></returns>
        public async Task<DeleteAgentGroupResponse> DeleteAgentGroup(DeleteAgentGroupRequest req)
        {
             JsonResponseModel<DeleteAgentGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAgentGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAgentGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除拨测分组
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentGroupRequest"/></param>
        /// <returns><see cref="DeleteAgentGroupResponse"/></returns>
        public DeleteAgentGroupResponse DeleteAgentGroupSync(DeleteAgentGroupRequest req)
        {
             JsonResponseModel<DeleteAgentGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAgentGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAgentGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除拨测任务
        /// </summary>
        /// <param name="req"><see cref="DeleteProbeTaskRequest"/></param>
        /// <returns><see cref="DeleteProbeTaskResponse"/></returns>
        public async Task<DeleteProbeTaskResponse> DeleteProbeTask(DeleteProbeTaskRequest req)
        {
             JsonResponseModel<DeleteProbeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProbeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProbeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除拨测任务
        /// </summary>
        /// <param name="req"><see cref="DeleteProbeTaskRequest"/></param>
        /// <returns><see cref="DeleteProbeTaskResponse"/></returns>
        public DeleteProbeTaskResponse DeleteProbeTaskSync(DeleteProbeTaskRequest req)
        {
             JsonResponseModel<DeleteProbeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProbeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProbeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除多个拨测任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTasksRequest"/></param>
        /// <returns><see cref="DeleteTasksResponse"/></returns>
        public async Task<DeleteTasksResponse> DeleteTasks(DeleteTasksRequest req)
        {
             JsonResponseModel<DeleteTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除多个拨测任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTasksRequest"/></param>
        /// <returns><see cref="DeleteTasksResponse"/></returns>
        public DeleteTasksResponse DeleteTasksSync(DeleteTasksRequest req)
        {
             JsonResponseModel<DeleteTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测分组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentGroupsRequest"/></param>
        /// <returns><see cref="DescribeAgentGroupsResponse"/></returns>
        public async Task<DescribeAgentGroupsResponse> DescribeAgentGroups(DescribeAgentGroupsRequest req)
        {
             JsonResponseModel<DescribeAgentGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测分组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentGroupsRequest"/></param>
        /// <returns><see cref="DescribeAgentGroupsResponse"/></returns>
        public DescribeAgentGroupsResponse DescribeAgentGroupsSync(DescribeAgentGroupsRequest req)
        {
             JsonResponseModel<DescribeAgentGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAgentGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本用户可选的拨测点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentsRequest"/></param>
        /// <returns><see cref="DescribeAgentsResponse"/></returns>
        public async Task<DescribeAgentsResponse> DescribeAgents(DescribeAgentsRequest req)
        {
             JsonResponseModel<DescribeAgentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本用户可选的拨测点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentsRequest"/></param>
        /// <returns><see cref="DescribeAgentsResponse"/></returns>
        public DescribeAgentsResponse DescribeAgentsSync(DescribeAgentsRequest req)
        {
             JsonResponseModel<DescribeAgentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAgents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户的告警主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmTopicRequest"/></param>
        /// <returns><see cref="DescribeAlarmTopicResponse"/></returns>
        public async Task<DescribeAlarmTopicResponse> DescribeAlarmTopic(DescribeAlarmTopicRequest req)
        {
             JsonResponseModel<DescribeAlarmTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户的告警主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmTopicRequest"/></param>
        /// <returns><see cref="DescribeAlarmTopicResponse"/></returns>
        public DescribeAlarmTopicResponse DescribeAlarmTopicSync(DescribeAlarmTopicRequest req)
        {
             JsonResponseModel<DescribeAlarmTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsRequest"/></param>
        /// <returns><see cref="DescribeAlarmsResponse"/></returns>
        public async Task<DescribeAlarmsResponse> DescribeAlarms(DescribeAlarmsRequest req)
        {
             JsonResponseModel<DescribeAlarmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsRequest"/></param>
        /// <returns><see cref="DescribeAlarmsResponse"/></returns>
        public DescribeAlarmsResponse DescribeAlarmsSync(DescribeAlarmsRequest req)
        {
             JsonResponseModel<DescribeAlarmsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按任务查询拨测告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsByTaskRequest"/></param>
        /// <returns><see cref="DescribeAlarmsByTaskResponse"/></returns>
        public async Task<DescribeAlarmsByTaskResponse> DescribeAlarmsByTask(DescribeAlarmsByTaskRequest req)
        {
             JsonResponseModel<DescribeAlarmsByTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmsByTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmsByTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按任务查询拨测告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsByTaskRequest"/></param>
        /// <returns><see cref="DescribeAlarmsByTaskResponse"/></returns>
        public DescribeAlarmsByTaskResponse DescribeAlarmsByTaskSync(DescribeAlarmsByTaskRequest req)
        {
             JsonResponseModel<DescribeAlarmsByTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmsByTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmsByTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测流水
        /// </summary>
        /// <param name="req"><see cref="DescribeCatLogsRequest"/></param>
        /// <returns><see cref="DescribeCatLogsResponse"/></returns>
        public async Task<DescribeCatLogsResponse> DescribeCatLogs(DescribeCatLogsRequest req)
        {
             JsonResponseModel<DescribeCatLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCatLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCatLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测流水
        /// </summary>
        /// <param name="req"><see cref="DescribeCatLogsRequest"/></param>
        /// <returns><see cref="DescribeCatLogsResponse"/></returns>
        public DescribeCatLogsResponse DescribeCatLogsSync(DescribeCatLogsRequest req)
        {
             JsonResponseModel<DescribeCatLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCatLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCatLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据时间范围、任务ID、运营商等条件查询单次拨测详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDetailedSingleProbeDataRequest"/></param>
        /// <returns><see cref="DescribeDetailedSingleProbeDataResponse"/></returns>
        public async Task<DescribeDetailedSingleProbeDataResponse> DescribeDetailedSingleProbeData(DescribeDetailedSingleProbeDataRequest req)
        {
             JsonResponseModel<DescribeDetailedSingleProbeDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDetailedSingleProbeData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDetailedSingleProbeDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据时间范围、任务ID、运营商等条件查询单次拨测详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDetailedSingleProbeDataRequest"/></param>
        /// <returns><see cref="DescribeDetailedSingleProbeDataResponse"/></returns>
        public DescribeDetailedSingleProbeDataResponse DescribeDetailedSingleProbeDataSync(DescribeDetailedSingleProbeDataRequest req)
        {
             JsonResponseModel<DescribeDetailedSingleProbeDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDetailedSingleProbeData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDetailedSingleProbeDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测节点
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeNodesRequest"/></param>
        /// <returns><see cref="DescribeProbeNodesResponse"/></returns>
        public async Task<DescribeProbeNodesResponse> DescribeProbeNodes(DescribeProbeNodesRequest req)
        {
             JsonResponseModel<DescribeProbeNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProbeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProbeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测节点
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeNodesRequest"/></param>
        /// <returns><see cref="DescribeProbeNodesResponse"/></returns>
        public DescribeProbeNodesResponse DescribeProbeNodesSync(DescribeProbeNodesRequest req)
        {
             JsonResponseModel<DescribeProbeNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProbeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProbeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询探测任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeTasksRequest"/></param>
        /// <returns><see cref="DescribeProbeTasksResponse"/></returns>
        public async Task<DescribeProbeTasksResponse> DescribeProbeTasks(DescribeProbeTasksRequest req)
        {
             JsonResponseModel<DescribeProbeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProbeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProbeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询探测任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeTasksRequest"/></param>
        /// <returns><see cref="DescribeProbeTasksResponse"/></returns>
        public DescribeProbeTasksResponse DescribeProbeTasksSync(DescribeProbeTasksRequest req)
        {
             JsonResponseModel<DescribeProbeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProbeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProbeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按类型查询拨测任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksByTypeRequest"/></param>
        /// <returns><see cref="DescribeTasksByTypeResponse"/></returns>
        public async Task<DescribeTasksByTypeResponse> DescribeTasksByType(DescribeTasksByTypeRequest req)
        {
             JsonResponseModel<DescribeTasksByTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasksByType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksByTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按类型查询拨测任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksByTypeRequest"/></param>
        /// <returns><see cref="DescribeTasksByTypeResponse"/></returns>
        public DescribeTasksByTypeResponse DescribeTasksByTypeSync(DescribeTasksByTypeRequest req)
        {
             JsonResponseModel<DescribeTasksByTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasksByType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksByTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户可用资源限制
        /// </summary>
        /// <param name="req"><see cref="DescribeUserLimitRequest"/></param>
        /// <returns><see cref="DescribeUserLimitResponse"/></returns>
        public async Task<DescribeUserLimitResponse> DescribeUserLimit(DescribeUserLimitRequest req)
        {
             JsonResponseModel<DescribeUserLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户可用资源限制
        /// </summary>
        /// <param name="req"><see cref="DescribeUserLimitRequest"/></param>
        /// <returns><see cref="DescribeUserLimitResponse"/></returns>
        public DescribeUserLimitResponse DescribeUserLimitSync(DescribeUserLimitRequest req)
        {
             JsonResponseModel<DescribeUserLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定时刻的可用率地图信息
        /// </summary>
        /// <param name="req"><see cref="GetAvailRatioHistoryRequest"/></param>
        /// <returns><see cref="GetAvailRatioHistoryResponse"/></returns>
        public async Task<GetAvailRatioHistoryResponse> GetAvailRatioHistory(GetAvailRatioHistoryRequest req)
        {
             JsonResponseModel<GetAvailRatioHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAvailRatioHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAvailRatioHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定时刻的可用率地图信息
        /// </summary>
        /// <param name="req"><see cref="GetAvailRatioHistoryRequest"/></param>
        /// <returns><see cref="GetAvailRatioHistoryResponse"/></returns>
        public GetAvailRatioHistoryResponse GetAvailRatioHistorySync(GetAvailRatioHistoryRequest req)
        {
             JsonResponseModel<GetAvailRatioHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAvailRatioHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAvailRatioHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取一天的整体可用率信息
        /// </summary>
        /// <param name="req"><see cref="GetDailyAvailRatioRequest"/></param>
        /// <returns><see cref="GetDailyAvailRatioResponse"/></returns>
        public async Task<GetDailyAvailRatioResponse> GetDailyAvailRatio(GetDailyAvailRatioRequest req)
        {
             JsonResponseModel<GetDailyAvailRatioResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDailyAvailRatio");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDailyAvailRatioResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取一天的整体可用率信息
        /// </summary>
        /// <param name="req"><see cref="GetDailyAvailRatioRequest"/></param>
        /// <returns><see cref="GetDailyAvailRatioResponse"/></returns>
        public GetDailyAvailRatioResponse GetDailyAvailRatioSync(GetDailyAvailRatioRequest req)
        {
             JsonResponseModel<GetDailyAvailRatioResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDailyAvailRatio");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDailyAvailRatioResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实时可用率信息
        /// </summary>
        /// <param name="req"><see cref="GetRealAvailRatioRequest"/></param>
        /// <returns><see cref="GetRealAvailRatioResponse"/></returns>
        public async Task<GetRealAvailRatioResponse> GetRealAvailRatio(GetRealAvailRatioRequest req)
        {
             JsonResponseModel<GetRealAvailRatioResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRealAvailRatio");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRealAvailRatioResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实时可用率信息
        /// </summary>
        /// <param name="req"><see cref="GetRealAvailRatioRequest"/></param>
        /// <returns><see cref="GetRealAvailRatioResponse"/></returns>
        public GetRealAvailRatioResponse GetRealAvailRatioSync(GetRealAvailRatioRequest req)
        {
             JsonResponseModel<GetRealAvailRatioResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRealAvailRatio");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRealAvailRatioResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测任务的走势数据
        /// </summary>
        /// <param name="req"><see cref="GetRespTimeTrendExRequest"/></param>
        /// <returns><see cref="GetRespTimeTrendExResponse"/></returns>
        public async Task<GetRespTimeTrendExResponse> GetRespTimeTrendEx(GetRespTimeTrendExRequest req)
        {
             JsonResponseModel<GetRespTimeTrendExResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRespTimeTrendEx");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRespTimeTrendExResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测任务的走势数据
        /// </summary>
        /// <param name="req"><see cref="GetRespTimeTrendExRequest"/></param>
        /// <returns><see cref="GetRespTimeTrendExResponse"/></returns>
        public GetRespTimeTrendExResponse GetRespTimeTrendExSync(GetRespTimeTrendExRequest req)
        {
             JsonResponseModel<GetRespTimeTrendExResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRespTimeTrendEx");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRespTimeTrendExResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务列表的实时数据
        /// </summary>
        /// <param name="req"><see cref="GetResultSummaryRequest"/></param>
        /// <returns><see cref="GetResultSummaryResponse"/></returns>
        public async Task<GetResultSummaryResponse> GetResultSummary(GetResultSummaryRequest req)
        {
             JsonResponseModel<GetResultSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetResultSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetResultSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务列表的实时数据
        /// </summary>
        /// <param name="req"><see cref="GetResultSummaryRequest"/></param>
        /// <returns><see cref="GetResultSummaryResponse"/></returns>
        public GetResultSummaryResponse GetResultSummarySync(GetResultSummaryRequest req)
        {
             JsonResponseModel<GetResultSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetResultSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetResultSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测任务的历史返回码信息
        /// </summary>
        /// <param name="req"><see cref="GetReturnCodeHistoryRequest"/></param>
        /// <returns><see cref="GetReturnCodeHistoryResponse"/></returns>
        public async Task<GetReturnCodeHistoryResponse> GetReturnCodeHistory(GetReturnCodeHistoryRequest req)
        {
             JsonResponseModel<GetReturnCodeHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetReturnCodeHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetReturnCodeHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测任务的历史返回码信息
        /// </summary>
        /// <param name="req"><see cref="GetReturnCodeHistoryRequest"/></param>
        /// <returns><see cref="GetReturnCodeHistoryResponse"/></returns>
        public GetReturnCodeHistoryResponse GetReturnCodeHistorySync(GetReturnCodeHistoryRequest req)
        {
             JsonResponseModel<GetReturnCodeHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetReturnCodeHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetReturnCodeHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测任务的返回码统计信息
        /// </summary>
        /// <param name="req"><see cref="GetReturnCodeInfoRequest"/></param>
        /// <returns><see cref="GetReturnCodeInfoResponse"/></returns>
        public async Task<GetReturnCodeInfoResponse> GetReturnCodeInfo(GetReturnCodeInfoRequest req)
        {
             JsonResponseModel<GetReturnCodeInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetReturnCodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetReturnCodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测任务的返回码统计信息
        /// </summary>
        /// <param name="req"><see cref="GetReturnCodeInfoRequest"/></param>
        /// <returns><see cref="GetReturnCodeInfoResponse"/></returns>
        public GetReturnCodeInfoResponse GetReturnCodeInfoSync(GetReturnCodeInfoRequest req)
        {
             JsonResponseModel<GetReturnCodeInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetReturnCodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetReturnCodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取AppId下的拨测任务总数
        /// </summary>
        /// <param name="req"><see cref="GetTaskTotalNumberRequest"/></param>
        /// <returns><see cref="GetTaskTotalNumberResponse"/></returns>
        public async Task<GetTaskTotalNumberResponse> GetTaskTotalNumber(GetTaskTotalNumberRequest req)
        {
             JsonResponseModel<GetTaskTotalNumberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTaskTotalNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTaskTotalNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取AppId下的拨测任务总数
        /// </summary>
        /// <param name="req"><see cref="GetTaskTotalNumberRequest"/></param>
        /// <returns><see cref="GetTaskTotalNumberResponse"/></returns>
        public GetTaskTotalNumberResponse GetTaskTotalNumberSync(GetTaskTotalNumberRequest req)
        {
             JsonResponseModel<GetTaskTotalNumberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTaskTotalNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTaskTotalNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改拨测分组
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentGroupRequest"/></param>
        /// <returns><see cref="ModifyAgentGroupResponse"/></returns>
        public async Task<ModifyAgentGroupResponse> ModifyAgentGroup(ModifyAgentGroupRequest req)
        {
             JsonResponseModel<ModifyAgentGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAgentGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAgentGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改拨测分组
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentGroupRequest"/></param>
        /// <returns><see cref="ModifyAgentGroupResponse"/></returns>
        public ModifyAgentGroupResponse ModifyAgentGroupSync(ModifyAgentGroupRequest req)
        {
             JsonResponseModel<ModifyAgentGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAgentGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAgentGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改拨测任务(扩展)
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskExRequest"/></param>
        /// <returns><see cref="ModifyTaskExResponse"/></returns>
        public async Task<ModifyTaskExResponse> ModifyTaskEx(ModifyTaskExRequest req)
        {
             JsonResponseModel<ModifyTaskExResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTaskEx");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskExResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改拨测任务(扩展)
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskExRequest"/></param>
        /// <returns><see cref="ModifyTaskExResponse"/></returns>
        public ModifyTaskExResponse ModifyTaskExSync(ModifyTaskExRequest req)
        {
             JsonResponseModel<ModifyTaskExResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTaskEx");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskExResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停拨测任务
        /// </summary>
        /// <param name="req"><see cref="PauseTaskRequest"/></param>
        /// <returns><see cref="PauseTaskResponse"/></returns>
        public async Task<PauseTaskResponse> PauseTask(PauseTaskRequest req)
        {
             JsonResponseModel<PauseTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PauseTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PauseTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停拨测任务
        /// </summary>
        /// <param name="req"><see cref="PauseTaskRequest"/></param>
        /// <returns><see cref="PauseTaskResponse"/></returns>
        public PauseTaskResponse PauseTaskSync(PauseTaskRequest req)
        {
             JsonResponseModel<PauseTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PauseTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PauseTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复拨测任务
        /// </summary>
        /// <param name="req"><see cref="ResumeProbeTaskRequest"/></param>
        /// <returns><see cref="ResumeProbeTaskResponse"/></returns>
        public async Task<ResumeProbeTaskResponse> ResumeProbeTask(ResumeProbeTaskRequest req)
        {
             JsonResponseModel<ResumeProbeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeProbeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeProbeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复拨测任务
        /// </summary>
        /// <param name="req"><see cref="ResumeProbeTaskRequest"/></param>
        /// <returns><see cref="ResumeProbeTaskResponse"/></returns>
        public ResumeProbeTaskResponse ResumeProbeTaskSync(ResumeProbeTaskRequest req)
        {
             JsonResponseModel<ResumeProbeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeProbeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeProbeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行拨测任务
        /// </summary>
        /// <param name="req"><see cref="RunTaskRequest"/></param>
        /// <returns><see cref="RunTaskResponse"/></returns>
        public async Task<RunTaskResponse> RunTask(RunTaskRequest req)
        {
             JsonResponseModel<RunTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行拨测任务
        /// </summary>
        /// <param name="req"><see cref="RunTaskRequest"/></param>
        /// <returns><see cref="RunTaskResponse"/></returns>
        public RunTaskResponse RunTaskSync(RunTaskRequest req)
        {
             JsonResponseModel<RunTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停拨测任务
        /// </summary>
        /// <param name="req"><see cref="SuspendProbeTaskRequest"/></param>
        /// <returns><see cref="SuspendProbeTaskResponse"/></returns>
        public async Task<SuspendProbeTaskResponse> SuspendProbeTask(SuspendProbeTaskRequest req)
        {
             JsonResponseModel<SuspendProbeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SuspendProbeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SuspendProbeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停拨测任务
        /// </summary>
        /// <param name="req"><see cref="SuspendProbeTaskRequest"/></param>
        /// <returns><see cref="SuspendProbeTaskResponse"/></returns>
        public SuspendProbeTaskResponse SuspendProbeTaskSync(SuspendProbeTaskRequest req)
        {
             JsonResponseModel<SuspendProbeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SuspendProbeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SuspendProbeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量更新拨测任务配置
        /// </summary>
        /// <param name="req"><see cref="UpdateProbeTaskConfigurationListRequest"/></param>
        /// <returns><see cref="UpdateProbeTaskConfigurationListResponse"/></returns>
        public async Task<UpdateProbeTaskConfigurationListResponse> UpdateProbeTaskConfigurationList(UpdateProbeTaskConfigurationListRequest req)
        {
             JsonResponseModel<UpdateProbeTaskConfigurationListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateProbeTaskConfigurationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProbeTaskConfigurationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量更新拨测任务配置
        /// </summary>
        /// <param name="req"><see cref="UpdateProbeTaskConfigurationListRequest"/></param>
        /// <returns><see cref="UpdateProbeTaskConfigurationListResponse"/></returns>
        public UpdateProbeTaskConfigurationListResponse UpdateProbeTaskConfigurationListSync(UpdateProbeTaskConfigurationListRequest req)
        {
             JsonResponseModel<UpdateProbeTaskConfigurationListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateProbeTaskConfigurationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProbeTaskConfigurationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证拨测任务，结果验证查询（验证成功的，才建议创建拨测任务）
        /// </summary>
        /// <param name="req"><see cref="VerifyResultRequest"/></param>
        /// <returns><see cref="VerifyResultResponse"/></returns>
        public async Task<VerifyResultResponse> VerifyResult(VerifyResultRequest req)
        {
             JsonResponseModel<VerifyResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证拨测任务，结果验证查询（验证成功的，才建议创建拨测任务）
        /// </summary>
        /// <param name="req"><see cref="VerifyResultRequest"/></param>
        /// <returns><see cref="VerifyResultResponse"/></returns>
        public VerifyResultResponse VerifyResultSync(VerifyResultRequest req)
        {
             JsonResponseModel<VerifyResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
